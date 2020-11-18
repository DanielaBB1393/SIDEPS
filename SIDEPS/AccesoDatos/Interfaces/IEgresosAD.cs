using Entidades;

namespace AccesoDatos.Interfaces
{
    public interface IEgresosAD
    {
        int SP_Ins_Egresos(SIDEPS_24REGEGRF egresos, int codigoCaso);
    }
}