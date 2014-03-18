using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Model
{
    public class EmpType
    {
        public static readonly EmpType Cliente = new EmpType(1, "Cliente");
        public static readonly EmpType Proveedor = new EmpType(2, "Proveedor");

        public int _id;
        public string descripcion;
        public EmpType(int id, string descripcion)
        {
            this._id = id;
            this.descripcion = descripcion;
        }

        public bool Equals(EmpType t)
        {
          
                return t._id.Equals(this._id);
            
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
