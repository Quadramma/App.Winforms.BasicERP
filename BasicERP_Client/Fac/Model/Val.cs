using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fac.Model
{
    public class Val
    {
        public static bool EmpresaValidate(string name, int typeIndex
            //string addresses, string phones, string contactoAlternativo, string deParteDe
            ){

            if (name.Length < 1) {
                MessageBox.Show("Nombre requerido ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (typeIndex == -1) {
                MessageBox.Show("Tipo requerido ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }

                return true;
        }
    }
}
