using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Model
{
    public class DocType
    {
        //Defaults
        public static DocType Factura = new DocType(1, "Factura");
        public static DocType NotaCredito = new DocType(1, "NotaCredito");
        public static DocType NotaDebito = new DocType(1, "NotaDebito");
        public static DocType OrdenPago = new DocType(1, "OrdenPago");

        public int id;
        public string descripcion;

        public DocType(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public override string ToString()
        {
            return descripcion;
        }

    }
}
