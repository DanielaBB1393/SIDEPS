using Entidades;
using System.Collections.Generic;

namespace LogicaNegocios.Interfaces
{
    public interface ICasosLN
    {
        int SP_Ins_Caso(SIDEPS_25REGCASO caso);
        bool SP_Mod_Caso(SIDEPS_25REGCASO caso);
        List<SP_CON_HISTCASOS_Result> SP_Con_HistoricoCasos(string cedulaUsuario);
    }
}