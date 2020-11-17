using Entidades;

namespace AccesoDatos.Interfaces
{
    public interface ICasosAD
    {
        int SP_Ins_Caso(SIDEPS_25REGCASO caso);
        bool SP_Mod_Caso(SIDEPS_25REGCASO caso);
    }
}