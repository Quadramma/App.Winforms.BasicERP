using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Model
{
    public interface IEmp
    {
        ObjectId _id { get; set; }
        string name { get; set; }
        EmpType type { get; set; }


        string addresses { get; set; }
        string phones { get; set; }
        string contactoAlternativo { get; set; }
        string deParteDe { get; set; }
        string cuil { get; set; }

        List<Doc> docs { get; set; }
    }
}
