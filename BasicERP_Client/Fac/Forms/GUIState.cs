using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac.Forms
{

    public interface IGUIStates {
        void AdvanceState(GUIState state);
    }

    public enum GUIActionState { 
        Nothing,
        EmpresaCancelDelete,
        EmpresaDelete,
        EmpresaDeleteConfirmation,
        EmpresaModificar,
        EmpresaInsertar,
       
    }

    public enum GUIState
    {
        AppStart,
        EmpresaSeleccionada,
        VistaPrevia,
        Detalle,
        EmpresaAlta,
        EmpresaModi,
        BusquedaEmpresa,
        AppExit,

    }
}
