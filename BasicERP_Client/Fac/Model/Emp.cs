using Fac.Db;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Model
{
    public enum EmpFiltro
    {
        name = 0,
        apellido = 1,
        cuit = 2
    }
    public class Emp : IEmp
    {
        public Emp()
        {
            docs = new List<Doc>();
        }
        public override string ToString()
        {
            return this.name;// +"(" + this.type.descripcion + ")";
        }

        public string name
        {
            get;
            set;
        }

        public EmpType type
        {
            get;
            set;
        }
        public List<Doc> docs
        {
            get;
            set;
        }



        List<Doc> IEmp.docs
        {
            get;
            set;
        }

        public ObjectId _id
        {
            get;
            set;
        }
        

        public override bool Equals(object obj)
        {
            if (obj.GetType() == Type.GetType("System.DBNull")) return false;
            Emp e = (Emp)obj;
            return e._id == this._id;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public string addresses
        {
            get;
            set;
        }

        public string phones
        {
            get;
            set;
        }

        public string contactoAlternativo
        {
            get;
            set;
        }

        public string deParteDe
        {
            get;
            set;
        }


        public string cuil
        {
            get;
            set;
        }
    }
}
