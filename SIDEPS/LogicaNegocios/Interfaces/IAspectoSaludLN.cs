using Entidades;

namespace LogicaNegocios.Interfaces
{
    public interface IAspectoSaludLN
    {
        int SP_Ins_AspectoSalud(SIDEPS_16REGASPS aspecto, int codigoCaso);
    }
}