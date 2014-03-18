using Fac.Db;
using Fac.Model;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fac.Forms
{


    public partial class FrmMain : Form, IGUIStates
    {



        public FrmMain()
        {
            InitializeComponent();

            //MainDb.deleteUsers();
            //MainDb.deleteEmpresas();
            //MainDb.deleteDocumentos();

            MainPool.Initialize();
            MainPool.DummyData();
            AdvanceState(GUIState.AppStart);
        }

        private void updateListaEmpresas()
        {
            lbEmp.Items.Clear();
            List<Emp> emps = new List<Emp>();
            EmpType type = (EmpType)cbMainTipo.SelectedItem;
            foreach (Emp em in MainPool.empresas)
            {
                if (em.type.Equals(type))
                {
                    emps.Add(em);
                }
            }
            lbEmp.Items.AddRange(emps.ToArray());
        }

        private void lbEmp_SelectedIndexChanged(object sender, EventArgs e) //EMP SELECTED
        {

            AdvanceState(GUIState.EmpresaSeleccionada);


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

            MainPool.onMatch(MainPool.empresas, txtBusqueda.Text, cbFiltro.SelectedIndex, (object matched) =>
            {
                lbEmp.SelectedItem = matched;
                return;
            });

        }

        private void btnEmpNueva_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpGuardar_Click(object sender, EventArgs e)
        {
            switch (MainSelection.state)
            {
                case GUIState.EmpresaAlta:
                    if (Val.EmpresaValidate(txtEmpName.Text, txtEmpTipo.SelectedIndex))
                    {
                        Execute(GUIActionState.EmpresaInsertar);
                    }
                    break;
                case GUIState.EmpresaModi:
                    if (Val.EmpresaValidate(txtEmpName.Text,txtEmpTipo.SelectedIndex))
                    {
                        Execute(GUIActionState.EmpresaModificar);
                    }
                    break;
                default:
                    throw new Exception("Estado no contemplado al dar boton guardar en empresa " + MainSelection.state.ToString());
            }
        }

        public void seleccionarEmpresa(Emp emp)
        {
            for (int x = 0; x < lbEmp.Items.Count; x++)
            {
                Emp e = (Emp)lbEmp.Items[x];
                if (e != null)
                {
                    if (e._id == emp._id)
                    {
                        lbEmp.SelectedIndex = x;
                        lbEmp.SetSelected(x,true);
                        AdvanceState(GUIState.EmpresaSeleccionada);
                        return;
                    }
                }
            }
        }

        private void btnEmpEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void cbMainTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateListaEmpresas();
        }

        public void tabResumen_Toggle(bool val)
        {
            if (val)
            {
                if (!tabControlMain.TabPages.Contains(tabResumen))
                {
                    tabControlMain.TabPages.Add(tabResumen);
                }
            }
            else
            {
                tabControlMain.TabPages.Remove(tabResumen);
            }

        }


        public void Execute(GUIActionState action)
        {
            MainSelection.action = action;
            switch (MainSelection.action)
            {
                case GUIActionState.EmpresaDelete:
                    MainDb.deleteEmpresa(MainSelection.emp);
                    MainPool.empresas.Remove(MainSelection.emp);
                    break;
                case GUIActionState.EmpresaDeleteConfirmation:
                    if (MainSelection.state == GUIState.EmpresaAlta)
                    {
                        Execute(GUIActionState.EmpresaCancelDelete);
                    }
                    else
                    {
                        if (MessageBox.Show("Eliminar ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Execute(GUIActionState.EmpresaDelete);
                            AdvanceState(GUIState.BusquedaEmpresa);
                        }
                    }
                    break;
                case GUIActionState.EmpresaCancelDelete:
                    AdvanceState(GUIState.BusquedaEmpresa);
                    break;
                case GUIActionState.EmpresaInsertar:
                    Emp emp = new Emp()
                    {
                        name = txtEmpName.Text,
                        type = ((EmpType)txtEmpTipo.Items[txtEmpTipo.SelectedIndex]),
                        addresses = txtAddress.Text,
                        phones = txtPhones.Text,
                        contactoAlternativo = txtContactoAlternativo.Text,
                        cuil = txtCUIL.Text,
                        deParteDe = txtDeParteDe.Text
                    };
                    MainPool.empresas.Add(emp);
                    MainDb.SaveEmpresa(emp);
                    AdvanceState(GUIState.BusquedaEmpresa);
                    seleccionarEmpresa(emp);
                    AdvanceState(GUIState.EmpresaSeleccionada);
                    break;
                case GUIActionState.EmpresaModificar:
                    MainSelection.emp.name = txtEmpName.Text;
                    MainSelection.emp.type = ((EmpType)txtEmpTipo.Items[txtEmpTipo.SelectedIndex]);
                    MainSelection.emp.addresses = txtAddress.Text;
                    MainSelection.emp.phones = txtPhones.Text;
                    MainSelection.emp.contactoAlternativo = txtContactoAlternativo.Text;
                    MainSelection.emp.cuil = txtCUIL.Text;
                    MainSelection.emp.deParteDe = txtDeParteDe.Text;
                    MainDb.SaveEmpresa(MainSelection.emp);
                    AdvanceState(GUIState.BusquedaEmpresa);
                    AdvanceState(GUIState.EmpresaSeleccionada);
                    break;
            }
        }

        public void AdvanceState(GUIState state) //-------------------***********************************************
        {
            MainSelection.state = state;
            switch (MainSelection.state)
            {
                case GUIState.AppExit:
                    MongoDBController.shutdown();
                    break;
                case GUIState.AppStart: //----------------------------------------------------------------------------

                    txtEmpTipo.Items.Clear();
                    txtEmpTipo.Items.AddRange(new object[]{
                EmpType.Cliente,EmpType.Proveedor
            });
                    cbFiltro.SelectedIndex = 0; //set filtro default
                    cbMainTipo.Items.Clear();
                    cbMainTipo.Items.AddRange(new object[]{
                EmpType.Cliente,EmpType.Proveedor
            });
                    cbMainTipo.SelectedIndex = 0; //set tipo default
                    updateListaEmpresas();

                    tabDetalle.Enabled = false;
                    tabEmpresa.Enabled = false;
                    tabDocumento.Enabled = false;

                    tabResumen_Toggle(false);
                    AdvanceState(GUIState.BusquedaEmpresa);

                    break;
                case GUIState.BusquedaEmpresa: //----------------------------------------------------------------------------
                    updateListaEmpresas();
                    tabDetalle.Text = "";
                    tabEmpresa.Text = "";
                    tabDocumento.Text = "";
                    tabBusqueda.Text = "Busqueda";
                    tabResumen_Toggle(false);
                    tabControMainMain.SelectTab(tabBusqueda);
                    break;
                case GUIState.EmpresaSeleccionada: //----------------------------------------------------------------------------
                    tabDetalle.Text = "";
                    tabEmpresa.Text = "";
                    tabDocumento.Text = "";
                    tabBusqueda.Text = "Busqueda";
                    tabControMainMain.SelectTab(tabBusqueda);
                    tabResumen_Toggle(true);
                    Emp em = (Emp)lbEmp.SelectedItem;
                    if (em != null)
                    {
                        MainSelection.emp = em;
                        lResumenNombre.Text = em.name;

                        //Carga detalle
                        lvDetalle.Items.Clear();
                        foreach (Doc d in em.docs)
                        {
                            ListViewItem item = new ListViewItem(d.fecha.ToShortDateString());
                            item.SubItems.Add(d.type.descripcion, Color.LightBlue, Color.LawnGreen, lvDetalle.Font);
                            item.SubItems.Add(d.importe.ToString(), Color.LightBlue, Color.LawnGreen, lvDetalle.Font);
                            item.SubItems.Add("", Color.LightBlue, Color.LawnGreen, lvDetalle.Font);
                            item.SubItems.Add(d.observacion, Color.LightBlue, Color.LawnGreen, lvDetalle.Font);
                            lvDetalle.Items.Add(item);
                        }
                    }

                    break;
                case GUIState.EmpresaAlta: //----------------------------------------------------------------------------
                    txtEmpId.Text = "";
                    txtEmpName.Text = "";
                    txtAddress.Text = "";
                    txtPhones.Text = "";
                    txtContactoAlternativo.Text = "";
                    txtCUIL.Text = "";
                    txtDeParteDe.Text = "";
                    txtEmpTipo.SelectedIndex = 1;
                    btnEmpGuardar.Enabled = true;
                    btnEmpEliminar.Enabled = true;
                    btnEmpEliminar.Text = "Cancelar";
                    tabBusqueda.Text = "";
                    tabEmpresa.Text = "Empresa";
                    tabEmpresa.Enabled = true;
                    tabControMainMain.SelectTab(tabEmpresa);
                    break;
                case GUIState.EmpresaModi: //----------------------------------------------------------------------------
                    txtEmpId.Text = MainSelection.emp._id.ToString();
                    txtAddress.Text = MainSelection.emp.addresses;
                    txtPhones.Text = MainSelection.emp.phones;
                    txtContactoAlternativo.Text = MainSelection.emp.contactoAlternativo;
                    txtCUIL.Text = MainSelection.emp.cuil;
                    txtDeParteDe.Text = MainSelection.emp.deParteDe;
                    //
                    txtEmpName.Text = MainSelection.emp.name.ToString();
                    for (int x = 0; x < txtEmpTipo.Items.Count; x++)
                    {
                        EmpType t = (EmpType)txtEmpTipo.Items[x];
                        if (t != null && t._id == MainSelection.emp.type._id)
                        {
                            txtEmpTipo.SelectedIndex = x;
                        }
                    }
                    btnEmpGuardar.Enabled = true;
                    btnEmpEliminar.Enabled = true;
                    btnEmpEliminar.Text = "Eliminar";
                    tabBusqueda.Text = "";
                    tabEmpresa.Text = "Empresa";
                    tabEmpresa.Enabled = true;
                    tabControMainMain.SelectTab(tabEmpresa);
                    break;


            }
        }

        private void tabControMainMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //CLICK ON TAB
            e.Cancel = !e.TabPage.Enabled;
        }

        private void nuevaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvanceState(GUIState.EmpresaAlta);
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            AdvanceState(GUIState.EmpresaModi);
        }

        private void btnEmpGuardar_Click_1(object sender, EventArgs e)
        {
            btnEmpGuardar_Click(sender, e);
        }

        private void btnEmpEliminar_Click_1(object sender, EventArgs e)
        {
            Execute(GUIActionState.EmpresaDeleteConfirmation);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdvanceState(GUIState.AppExit);
        }
    }
}
