using Fac.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Model
{
    public class User : MongoDynamic, IUser
    {
        public User() { 
            
        }

        public string username
        {
            get;
            set;
        }

        public string password
        {
            get;
            set;
        }
    }
}
