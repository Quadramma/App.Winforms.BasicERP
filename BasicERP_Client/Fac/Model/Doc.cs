using Fac.Db;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Model
{
    public class Doc : MongoDynamic, IDoc
    {

        public Doc()
        {
            this.aplicaciones = new List<Doc>();
        }
        public ObjectId empId
        {
            get;
            set;
        }

        public DocType type
        {
            get;
            set;
        }

        public DateTime fecha
        {
            get;
            set;
        }

        public double importe
        {
            get;
            set;
        }

        public string observacion
        {
            get;
            set;
        }

        public List<Doc> aplicaciones
        {
            get;
            set;
        }


        public ObjectId pagoId
        {
            get;
            set;
        }
    }
}
