using Fac.Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Model
{
    public interface IDoc
    {
        ObjectId empId { get; set; }
        DocType type { get; set; }
        DateTime fecha { get; set; }
        double importe { get; set; }
        string observacion { get; set; }
        List<Doc> aplicaciones { get; set; }

        ObjectId pagoId { get; set; }
    }
}
