using Entidades;
using System.Collections.Generic;

namespace AccesoDatos.Interfaces
{
    public interface ICategoriasAD
    {
        List<SP_CON_CATRELG_Result> SP_Con_Religiones();
        List<SP_CON_CATESTC_Result> SP_Con_EstadosCivil();
        List<SP_CON_CATCANT_Result> SP_Con_Cantones();
    }
}