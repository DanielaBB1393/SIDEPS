using Entidades;

namespace AccesoDatos.Interfaces
{
    public interface IAspectoSaludAD
    {
        int SP_InsMod_AspectoSalud(SIDEPS_16REGASPS aspecto, int codigoCaso);
    }
}