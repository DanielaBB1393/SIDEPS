using Entidades;

namespace AccesoDatos.Interfaces
{
    public interface IPersonasAD
    {
        bool SP_Ins_RegistroPersona(SIDEPS_13REGPERS persona);
    }
}