using Entidades;
using System.Collections.Generic;

namespace LogicaNegocios.Interfaces
{
    public interface IGrupoFamiliarLN
    {
        bool SP_Ins_MiembroFamiliar(SIDEPS_22REGFAML grupoFamiliar, string cedulaPersona);

        SP_CONXID_REGFAML_Result SP_Con_MiembroFamiliarXid(string cedFamiliar);

        void SP_Del_MiembroFamiliarXid(string cedFamiliar);

        bool SP_Mod_MiembroFamiliar(SIDEPS_22REGFAML miembroFamiliar);
        
        List<SP_CON_REGFAML_Result> ConGrupoFamiliarXId(string miembroFamiliar);
    }
}