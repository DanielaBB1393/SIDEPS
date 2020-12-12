using Entidades;

namespace LogicaNegocios.Interfaces
{
    public interface IPersonasLN
    {
        bool SP_InsMod_RegistroPersona(SIDEPS_13REGPERS persona, int? codigoCaso);
    }
}