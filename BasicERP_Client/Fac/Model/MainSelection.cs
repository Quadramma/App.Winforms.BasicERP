using Fac.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Model
{

    public enum EmpCRUDMode { 
        Alta,Modi
    }

    public class MainSelection
    {
        public static Emp emp;
        public static GUIState state = GUIState.AppStart;
        public static GUIActionState action = GUIActionState.Nothing;
        public static EmpCRUDMode empMode = EmpCRUDMode.Alta;
    }
}
