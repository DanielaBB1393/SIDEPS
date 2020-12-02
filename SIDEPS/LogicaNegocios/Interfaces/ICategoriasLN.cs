using Entidades;
using System.Collections.Generic;

namespace LogicaNegocios.Interfaces
{
    public interface ICategoriasLN
    {
        List<SP_CON_CATRELG_Result> SP_Con_Religiones();
        List<SP_CON_CATESTC_Result> SP_Con_EstadosCivil();
        List<SP_CON_CATCANT_Result> SP_Con_Cantones();
        List<SP_CON_CATNEDU_Result> SP_Con_NivelEducativo();
        List<SP_CON_CATPAIS_Result> SP_Con_Pais();
        List<SP_CON_CATPROV_Result> SP_Con_Provincia();
        List<SP_CON_TIPUSRO_Result> SP_Con_TipoUsuario();
        List<SP_CON_CATSOLI_Result> SP_Con_CategoriaSolicitud();
        List<SP_CON_CATPARE_Result> SP_Con_Parentescos();
        List<SP_CON_CATSEGU_Result> SP_Con_Seguros();
        List<SP_CON_CATENFR_Result> SP_Con_Enfermedades();
        List<SP_CON_CATMATE_Result> SP_Con_Materiales();
        List<SP_CON_TIPVIVI_Result> SP_Con_TipoVivienda();
        List<SP_CON_ESTVIVI_Result> SP_Con_EstadoVivienda();
        List<SP_CON_CATORGS_Result> SP_Con_Organizaciones();
        List<SP_CON_CATAYUD_Result> SP_Con_CategoriasAyudas();
    }
}