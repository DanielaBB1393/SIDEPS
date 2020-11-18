using Entidades;

namespace LogicaNegocios.Interfaces
{
    public interface IEgresosLN
    {
        int SP_Ins_Egresos(SIDEPS_24REGEGRF egresos, int codigoCaso);
    }
}