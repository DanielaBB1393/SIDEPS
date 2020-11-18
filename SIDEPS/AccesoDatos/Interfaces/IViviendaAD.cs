using Entidades;

namespace AccesoDatos.Interfaces
{
    public interface IViviendaAD
    {
        int SP_Ins_Vivienda(SIDEPS_20REGVIVI vivienda, int codigoCaso);
    }
}