namespace Fac.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "ROLO",
            "tttttt"}, -1);
            this.tabControMainMain = new System.Windows.Forms.TabControl();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.tlpClientesMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbEmp = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lBuscar = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabResumen = new System.Windows.Forms.TabPage();
            this.labelBalanceRTA = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.btnOTs = new System.Windows.Forms.Button();
            this.btnCheques = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.lResumenNombre = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lFiltro = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.lMainTipo = new System.Windows.Forms.Label();
            this.cbMainTipo = new System.Windows.Forms.ComboBox();
            this.tabDetalle = new System.Windows.Forms.TabPage();
            this.lvDetalle = new System.Windows.Forms.ListView();
            this.chFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDocumento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chObservaciones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabDocumento = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabEmpresa = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCUIL = new System.Windows.Forms.Label();
            this.txtCUIL = new System.Windows.Forms.TextBox();
            this.labelContactoAlternativo = new System.Windows.Forms.Label();
            this.txtContactoAlternativo = new System.Windows.Forms.TextBox();
            this.txtDeParteDe = new System.Windows.Forms.TextBox();
            this.btnEmpGuardar = new System.Windows.Forms.Button();
            this.btnEmpEliminar = new System.Windows.Forms.Button();
            this.tlpEmpFields = new System.Windows.Forms.TableLayoutPanel();
            this.txtPhones = new System.Windows.Forms.TextBox();
            this.labelPhones = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControMainMain.SuspendLayout();
            this.tabBusqueda.SuspendLayout();
            this.tlpClientesMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabResumen.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabDetalle.SuspendLayout();
            this.tabDocumento.SuspendLayout();
            this.tabEmpresa.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpEmpFields.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControMainMain
            // 
            this.tabControMainMain.Controls.Add(this.tabBusqueda);
            this.tabControMainMain.Controls.Add(this.tabDetalle);
            this.tabControMainMain.Controls.Add(this.tabDocumento);
            this.tabControMainMain.Controls.Add(this.tabEmpresa);
            this.tabControMainMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControMainMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControMainMain.Location = new System.Drawing.Point(0, 28);
            this.tabControMainMain.Name = "tabControMainMain";
            this.tabControMainMain.SelectedIndex = 0;
            this.tabControMainMain.Size = new System.Drawing.Size(906, 481);
            this.tabControMainMain.TabIndex = 0;
            this.tabControMainMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControMainMain_Selecting);
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Controls.Add(this.tlpClientesMain);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 34);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(898, 443);
            this.tabBusqueda.TabIndex = 0;
            this.tabBusqueda.Text = "Busqueda";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // tlpClientesMain
            // 
            this.tlpClientesMain.ColumnCount = 2;
            this.tlpClientesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClientesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpClientesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpClientesMain.Controls.Add(this.lbEmp, 0, 1);
            this.tlpClientesMain.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tlpClientesMain.Controls.Add(this.tabControlMain, 1, 1);
            this.tlpClientesMain.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tlpClientesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpClientesMain.Location = new System.Drawing.Point(3, 3);
            this.tlpClientesMain.Name = "tlpClientesMain";
            this.tlpClientesMain.RowCount = 2;
            this.tlpClientesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpClientesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpClientesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpClientesMain.Size = new System.Drawing.Size(892, 437);
            this.tlpClientesMain.TabIndex = 1;
            // 
            // lbEmp
            // 
            this.lbEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp.FormattingEnabled = true;
            this.lbEmp.ItemHeight = 25;
            this.lbEmp.Items.AddRange(new object[] {
            "Juan Jose Garcia Hermnos",
            "Clarity S.A",
            "Petersen",
            "Quadramma",
            "R & G Graficos",
            "Los hermanos",
            "Los Nocheros",
            "Sprite S.A",
            "Mac Donals",
            "River Plate Sociedad Anonima",
            "Mar del Plata Churros S.A",
            "Los Caballos Restobar",
            "El Acantilado Fierros S.A",
            "Formula Dos Repuestos S.A",
            "Rutamar Transportes ",
            "Rapido del Norte S.A",
            "Dos mil S.A"});
            this.lbEmp.Location = new System.Drawing.Point(3, 53);
            this.lbEmp.Name = "lbEmp";
            this.lbEmp.Size = new System.Drawing.Size(440, 381);
            this.lbEmp.TabIndex = 4;
            this.lbEmp.SelectedIndexChanged += new System.EventHandler(this.lbEmp_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lBuscar);
            this.flowLayoutPanel1.Controls.Add(this.txtBusqueda);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 44);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lBuscar
            // 
            this.lBuscar.AutoSize = true;
            this.lBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBuscar.Location = new System.Drawing.Point(3, 0);
            this.lBuscar.Name = "lBuscar";
            this.lBuscar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lBuscar.Size = new System.Drawing.Size(79, 30);
            this.lBuscar.TabIndex = 1;
            this.lBuscar.Text = "Buscar";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(88, 3);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(308, 31);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabResumen);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(449, 53);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(440, 381);
            this.tabControlMain.TabIndex = 6;
            // 
            // tabResumen
            // 
            this.tabResumen.Controls.Add(this.labelBalanceRTA);
            this.tabResumen.Controls.Add(this.labelBalance);
            this.tabResumen.Controls.Add(this.btnOTs);
            this.tabResumen.Controls.Add(this.btnCheques);
            this.tabResumen.Controls.Add(this.btnDetalle);
            this.tabResumen.Controls.Add(this.btnDatos);
            this.tabResumen.Controls.Add(this.lResumenNombre);
            this.tabResumen.Location = new System.Drawing.Point(4, 34);
            this.tabResumen.Name = "tabResumen";
            this.tabResumen.Padding = new System.Windows.Forms.Padding(3);
            this.tabResumen.Size = new System.Drawing.Size(432, 343);
            this.tabResumen.TabIndex = 0;
            this.tabResumen.Text = "Resumen";
            this.tabResumen.UseVisualStyleBackColor = true;
            // 
            // labelBalanceRTA
            // 
            this.labelBalanceRTA.Location = new System.Drawing.Point(217, 298);
            this.labelBalanceRTA.Name = "labelBalanceRTA";
            this.labelBalanceRTA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBalanceRTA.Size = new System.Drawing.Size(204, 25);
            this.labelBalanceRTA.TabIndex = 6;
            this.labelBalanceRTA.Text = "45678.50";
            this.labelBalanceRTA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(121, 298);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(96, 25);
            this.labelBalance.TabIndex = 5;
            this.labelBalance.Text = "Balance:";
            // 
            // btnOTs
            // 
            this.btnOTs.Enabled = false;
            this.btnOTs.Location = new System.Drawing.Point(11, 218);
            this.btnOTs.Name = "btnOTs";
            this.btnOTs.Size = new System.Drawing.Size(108, 41);
            this.btnOTs.TabIndex = 8;
            this.btnOTs.Text = "OTs";
            this.btnOTs.UseVisualStyleBackColor = true;
            // 
            // btnCheques
            // 
            this.btnCheques.Enabled = false;
            this.btnCheques.Location = new System.Drawing.Point(11, 171);
            this.btnCheques.Name = "btnCheques";
            this.btnCheques.Size = new System.Drawing.Size(108, 41);
            this.btnCheques.TabIndex = 7;
            this.btnCheques.Text = "Cheques";
            this.btnCheques.UseVisualStyleBackColor = true;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Enabled = false;
            this.btnDetalle.Location = new System.Drawing.Point(11, 124);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(108, 41);
            this.btnDetalle.TabIndex = 6;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(11, 77);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(108, 41);
            this.btnDatos.TabIndex = 5;
            this.btnDatos.Text = "Datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // lResumenNombre
            // 
            this.lResumenNombre.AutoSize = true;
            this.lResumenNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResumenNombre.Location = new System.Drawing.Point(7, 20);
            this.lResumenNombre.Name = "lResumenNombre";
            this.lResumenNombre.Size = new System.Drawing.Size(232, 31);
            this.lResumenNombre.TabIndex = 0;
            this.lResumenNombre.Text = "lResumenNombre";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lFiltro);
            this.flowLayoutPanel2.Controls.Add(this.cbFiltro);
            this.flowLayoutPanel2.Controls.Add(this.lMainTipo);
            this.flowLayoutPanel2.Controls.Add(this.cbMainTipo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(449, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(436, 44);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // lFiltro
            // 
            this.lFiltro.AutoSize = true;
            this.lFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFiltro.Location = new System.Drawing.Point(3, 0);
            this.lFiltro.Name = "lFiltro";
            this.lFiltro.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lFiltro.Size = new System.Drawing.Size(60, 30);
            this.lFiltro.TabIndex = 9;
            this.lFiltro.Text = "Filtro";
            this.lFiltro.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cbFiltro
            // 
            this.cbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Por Nombre",
            "Por Apellido",
            "Por CUIT"});
            this.cbFiltro.Location = new System.Drawing.Point(69, 3);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(141, 33);
            this.cbFiltro.TabIndex = 2;
            // 
            // lMainTipo
            // 
            this.lMainTipo.AutoSize = true;
            this.lMainTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMainTipo.Location = new System.Drawing.Point(216, 0);
            this.lMainTipo.Name = "lMainTipo";
            this.lMainTipo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lMainTipo.Size = new System.Drawing.Size(54, 30);
            this.lMainTipo.TabIndex = 11;
            this.lMainTipo.Text = "Tipo";
            this.lMainTipo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cbMainTipo
            // 
            this.cbMainTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMainTipo.FormattingEnabled = true;
            this.cbMainTipo.Items.AddRange(new object[] {
            "Por Nombre",
            "Por Apellido",
            "Por CUIT"});
            this.cbMainTipo.Location = new System.Drawing.Point(276, 3);
            this.cbMainTipo.Name = "cbMainTipo";
            this.cbMainTipo.Size = new System.Drawing.Size(149, 33);
            this.cbMainTipo.TabIndex = 3;
            this.cbMainTipo.SelectedIndexChanged += new System.EventHandler(this.cbMainTipo_SelectedIndexChanged);
            // 
            // tabDetalle
            // 
            this.tabDetalle.Controls.Add(this.lvDetalle);
            this.tabDetalle.Location = new System.Drawing.Point(4, 34);
            this.tabDetalle.Name = "tabDetalle";
            this.tabDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalle.Size = new System.Drawing.Size(898, 443);
            this.tabDetalle.TabIndex = 1;
            this.tabDetalle.Text = "Detalle";
            this.tabDetalle.UseVisualStyleBackColor = true;
            // 
            // lvDetalle
            // 
            this.lvDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFecha,
            this.chDocumento,
            this.chImporte,
            this.chPago,
            this.chObservaciones});
            this.lvDetalle.FullRowSelect = true;
            this.lvDetalle.GridLines = true;
            this.lvDetalle.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDetalle.HideSelection = false;
            this.lvDetalle.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvDetalle.LabelEdit = true;
            this.lvDetalle.Location = new System.Drawing.Point(6, 6);
            this.lvDetalle.MultiSelect = false;
            this.lvDetalle.Name = "lvDetalle";
            this.lvDetalle.ShowItemToolTips = true;
            this.lvDetalle.Size = new System.Drawing.Size(871, 419);
            this.lvDetalle.TabIndex = 0;
            this.lvDetalle.UseCompatibleStateImageBehavior = false;
            this.lvDetalle.View = System.Windows.Forms.View.Details;
            // 
            // chFecha
            // 
            this.chFecha.Text = "Fecha";
            this.chFecha.Width = 120;
            // 
            // chDocumento
            // 
            this.chDocumento.Text = "Documento";
            this.chDocumento.Width = 150;
            // 
            // chImporte
            // 
            this.chImporte.Text = "Importe";
            this.chImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chImporte.Width = 100;
            // 
            // chPago
            // 
            this.chPago.Text = "Pago";
            this.chPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chPago.Width = 100;
            // 
            // chObservaciones
            // 
            this.chObservaciones.Text = "Observaciones";
            this.chObservaciones.Width = 400;
            // 
            // tabDocumento
            // 
            this.tabDocumento.Controls.Add(this.tableLayoutPanel1);
            this.tabDocumento.Location = new System.Drawing.Point(4, 34);
            this.tabDocumento.Name = "tabDocumento";
            this.tabDocumento.Size = new System.Drawing.Size(898, 443);
            this.tabDocumento.TabIndex = 2;
            this.tabDocumento.Text = "Documento";
            this.tabDocumento.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 273);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabEmpresa
            // 
            this.tabEmpresa.Controls.Add(this.tableLayoutPanel2);
            this.tabEmpresa.Controls.Add(this.btnEmpGuardar);
            this.tabEmpresa.Controls.Add(this.btnEmpEliminar);
            this.tabEmpresa.Controls.Add(this.tlpEmpFields);
            this.tabEmpresa.Location = new System.Drawing.Point(4, 34);
            this.tabEmpresa.Name = "tabEmpresa";
            this.tabEmpresa.Size = new System.Drawing.Size(898, 443);
            this.tabEmpresa.TabIndex = 3;
            this.tabEmpresa.Text = "Empresa";
            this.tabEmpresa.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelCUIL, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCUIL, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelContactoAlternativo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtContactoAlternativo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDeParteDe, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 224);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(872, 157);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "De parte de";
            // 
            // labelCUIL
            // 
            this.labelCUIL.AutoSize = true;
            this.labelCUIL.Location = new System.Drawing.Point(3, 50);
            this.labelCUIL.Name = "labelCUIL";
            this.labelCUIL.Size = new System.Drawing.Size(59, 25);
            this.labelCUIL.TabIndex = 0;
            this.labelCUIL.Text = "CUIL";
            // 
            // txtCUIL
            // 
            this.txtCUIL.Location = new System.Drawing.Point(196, 53);
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.Size = new System.Drawing.Size(555, 31);
            this.txtCUIL.TabIndex = 6;
            // 
            // labelContactoAlternativo
            // 
            this.labelContactoAlternativo.AutoSize = true;
            this.labelContactoAlternativo.Location = new System.Drawing.Point(3, 0);
            this.labelContactoAlternativo.Name = "labelContactoAlternativo";
            this.labelContactoAlternativo.Size = new System.Drawing.Size(114, 50);
            this.labelContactoAlternativo.TabIndex = 4;
            this.labelContactoAlternativo.Text = "Contacto Alternativo";
            // 
            // txtContactoAlternativo
            // 
            this.txtContactoAlternativo.Location = new System.Drawing.Point(196, 3);
            this.txtContactoAlternativo.Name = "txtContactoAlternativo";
            this.txtContactoAlternativo.Size = new System.Drawing.Size(555, 31);
            this.txtContactoAlternativo.TabIndex = 5;
            // 
            // txtDeParteDe
            // 
            this.txtDeParteDe.Location = new System.Drawing.Point(196, 90);
            this.txtDeParteDe.Name = "txtDeParteDe";
            this.txtDeParteDe.Size = new System.Drawing.Size(555, 31);
            this.txtDeParteDe.TabIndex = 7;
            // 
            // btnEmpGuardar
            // 
            this.btnEmpGuardar.Location = new System.Drawing.Point(519, 387);
            this.btnEmpGuardar.Name = "btnEmpGuardar";
            this.btnEmpGuardar.Size = new System.Drawing.Size(170, 35);
            this.btnEmpGuardar.TabIndex = 8;
            this.btnEmpGuardar.Text = "Guardar";
            this.btnEmpGuardar.UseVisualStyleBackColor = true;
            this.btnEmpGuardar.Click += new System.EventHandler(this.btnEmpGuardar_Click_1);
            // 
            // btnEmpEliminar
            // 
            this.btnEmpEliminar.Location = new System.Drawing.Point(712, 387);
            this.btnEmpEliminar.Name = "btnEmpEliminar";
            this.btnEmpEliminar.Size = new System.Drawing.Size(171, 35);
            this.btnEmpEliminar.TabIndex = 9;
            this.btnEmpEliminar.Text = "Eliminar";
            this.btnEmpEliminar.UseVisualStyleBackColor = true;
            this.btnEmpEliminar.Click += new System.EventHandler(this.btnEmpEliminar_Click_1);
            // 
            // tlpEmpFields
            // 
            this.tlpEmpFields.ColumnCount = 2;
            this.tlpEmpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpEmpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tlpEmpFields.Controls.Add(this.txtPhones, 1, 4);
            this.tlpEmpFields.Controls.Add(this.labelPhones, 0, 4);
            this.tlpEmpFields.Controls.Add(this.txtAddress, 1, 3);
            this.tlpEmpFields.Controls.Add(this.labelAddress, 0, 3);
            this.tlpEmpFields.Controls.Add(this.label2, 0, 2);
            this.tlpEmpFields.Controls.Add(this.txtEmpTipo, 1, 2);
            this.tlpEmpFields.Controls.Add(this.label1, 0, 1);
            this.tlpEmpFields.Controls.Add(this.txtEmpName, 1, 1);
            this.tlpEmpFields.Controls.Add(this.label3, 0, 0);
            this.tlpEmpFields.Controls.Add(this.txtEmpId, 1, 0);
            this.tlpEmpFields.Location = new System.Drawing.Point(8, 20);
            this.tlpEmpFields.Name = "tlpEmpFields";
            this.tlpEmpFields.RowCount = 6;
            this.tlpEmpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmpFields.Size = new System.Drawing.Size(872, 198);
            this.tlpEmpFields.TabIndex = 0;
            // 
            // txtPhones
            // 
            this.txtPhones.Location = new System.Drawing.Point(196, 153);
            this.txtPhones.Name = "txtPhones";
            this.txtPhones.Size = new System.Drawing.Size(555, 31);
            this.txtPhones.TabIndex = 4;
            // 
            // labelPhones
            // 
            this.labelPhones.AutoSize = true;
            this.labelPhones.Location = new System.Drawing.Point(3, 150);
            this.labelPhones.Name = "labelPhones";
            this.labelPhones.Size = new System.Drawing.Size(107, 25);
            this.labelPhones.TabIndex = 8;
            this.labelPhones.Text = "Telefonos";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(196, 116);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(555, 31);
            this.txtAddress.TabIndex = 3;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(3, 113);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(102, 25);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // txtEmpTipo
            // 
            this.txtEmpTipo.FormattingEnabled = true;
            this.txtEmpTipo.Location = new System.Drawing.Point(196, 77);
            this.txtEmpTipo.Name = "txtEmpTipo";
            this.txtEmpTipo.Size = new System.Drawing.Size(555, 33);
            this.txtEmpTipo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(196, 40);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(555, 31);
            this.txtEmpName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id Interno";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Enabled = false;
            this.txtEmpId.Location = new System.Drawing.Point(196, 3);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(279, 31);
            this.txtEmpId.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaEmpresaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevaEmpresaToolStripMenuItem
            // 
            this.nuevaEmpresaToolStripMenuItem.Name = "nuevaEmpresaToolStripMenuItem";
            this.nuevaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.nuevaEmpresaToolStripMenuItem.Text = "Nueva Empresa";
            this.nuevaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.nuevaEmpresaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(906, 509);
            this.ControlBox = false;
            this.Controls.Add(this.tabControMainMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.tabControMainMain.ResumeLayout(false);
            this.tabBusqueda.ResumeLayout(false);
            this.tlpClientesMain.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabResumen.ResumeLayout(false);
            this.tabResumen.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabDetalle.ResumeLayout(false);
            this.tabDocumento.ResumeLayout(false);
            this.tabEmpresa.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpEmpFields.ResumeLayout(false);
            this.tlpEmpFields.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControMainMain;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.TableLayoutPanel tlpClientesMain;
        private System.Windows.Forms.ListBox lbEmp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabResumen;
        private System.Windows.Forms.TabPage tabDetalle;
        private System.Windows.Forms.Label lResumenNombre;
        private System.Windows.Forms.TabPage tabDocumento;
        private System.Windows.Forms.ListView lvDetalle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lFiltro;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.ColumnHeader chFecha;
        private System.Windows.Forms.ColumnHeader chDocumento;
        private System.Windows.Forms.ColumnHeader chImporte;
        private System.Windows.Forms.ColumnHeader chPago;
        private System.Windows.Forms.ColumnHeader chObservaciones;
        private System.Windows.Forms.TabPage tabEmpresa;
        private System.Windows.Forms.TableLayoutPanel tlpEmpFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtEmpTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label lMainTipo;
        private System.Windows.Forms.ComboBox cbMainTipo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem nuevaEmpresaToolStripMenuItem;
        private System.Windows.Forms.Label labelBalanceRTA;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Button btnOTs;
        private System.Windows.Forms.Button btnCheques;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.TextBox txtPhones;
        private System.Windows.Forms.Label labelPhones;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button btnEmpGuardar;
        private System.Windows.Forms.Button btnEmpEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCUIL;
        private System.Windows.Forms.TextBox txtCUIL;
        private System.Windows.Forms.Label labelContactoAlternativo;
        private System.Windows.Forms.TextBox txtContactoAlternativo;
        private System.Windows.Forms.TextBox txtDeParteDe;

    }
}