using Entidades;

namespace AccesoDatos.Interfaces
{
    public interface IPersonasAD
    {
        bool SP_InsMod_RegistroPersona(SIDEPS_13REGPERS persona, int? codigoCaso);
    }
}