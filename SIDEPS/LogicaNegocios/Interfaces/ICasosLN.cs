using Entidades;

namespace LogicaNegocios.Interfaces
{
    public interface ICasosLN
    {
        int SP_Ins_Caso(SIDEPS_25REGCASO caso);
        bool SP_Mod_Caso(SIDEPS_25REGCASO caso);
    }
}