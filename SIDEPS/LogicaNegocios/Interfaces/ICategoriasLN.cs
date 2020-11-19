using Entidades;
using System.Collections.Generic;

namespace LogicaNegocios.Interfaces
{
    public interface ICategoriasLN
    {
        List<SP_CON_CATRELG_Result> SP_Con_Religiones();
        List<SP_CON_CATCANT_Result> SP_Con_Cantones();
    }
}