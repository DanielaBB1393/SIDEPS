using Entidades;
using System.Collections.Generic;

namespace LogicaNegocios.Interfaces
{
    public interface ICasosLN
    {
        int SP_Ins_Caso(SIDEPS_25REGCASO caso);

        bool SP_Mod_Caso(SIDEPS_25REGCASO caso);

        List<SP_CON_HISTCASOS_Result> SP_Con_HistoricoCasos(int diaconia);

        DETPERS_Result SP_Con_DatosPersonales(int codigoCaso);

        DETASPS_Result SP_Con_AspectoSalud(int codigoCaso);

        DETVIVI_Result SP_Con_Vivienda(int codigoCaso);

        List<DETFAML_Result> SP_Con_GrupoFamiliar(int codigoCaso);

        DETEGRF_Result SP_Con_Egresos(int codigoCaso);

        string SP_Con_ObservacionesCaso(int codigoCaso);

        SP_CON_CASOXID_Result ConCaso(int codigoCaso);

        bool SP_Ins_AyudasXCaso(List<SIDEPS_27TIPAYUD> ayudasAprobadas);
    }
}