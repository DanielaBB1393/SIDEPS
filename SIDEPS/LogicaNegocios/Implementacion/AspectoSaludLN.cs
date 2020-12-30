using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;

namespace LogicaNegocios.Implementacion
{
    public class AspectoSaludLN : IAspectoSaludLN
    {
        private readonly IAspectoSaludAD aspectoSaludAD = new AspectoSaludAD();

        public int SP_InsMod_AspectoSalud(SIDEPS_16REGASPS aspecto, int codigoCaso)
        {
            try
            {
                return this.aspectoSaludAD.SP_InsMod_AspectoSalud(aspecto, codigoCaso);
            }
            catch
            {
                throw;
            }
        }
    }
}