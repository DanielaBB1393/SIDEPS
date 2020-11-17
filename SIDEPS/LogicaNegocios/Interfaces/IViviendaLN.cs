using Entidades;

namespace LogicaNegocios.Interfaces
{
    public interface IViviendaLN
    {
        int SP_Ins_Vivienda(SIDEPS_20REGVIVI vivienda, int codigoCaso);
    }
}