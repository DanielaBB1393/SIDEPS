using Entidades;

namespace LogicaNegocios.Interfaces
{
    public interface IAspectoSaludLN
    {
        int SP_InsMod_AspectoSalud(SIDEPS_16REGASPS aspecto, int codigoCaso);
    }
}