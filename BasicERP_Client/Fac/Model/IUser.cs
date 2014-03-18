using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Model
{
    public interface IUser
    {
        string username { get; set; }
        string password { get; set; }
    }
}
