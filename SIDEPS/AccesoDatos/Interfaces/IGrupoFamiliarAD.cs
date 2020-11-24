using Entidades;

namespace AccesoDatos.Interfaces
{
    public interface IGrupoFamiliarAD
    {
        bool SP_Ins_GrupoFamiliar(SIDEPS_22REGFAML grupoFamiliar, string cedulaPersona);
    }
}