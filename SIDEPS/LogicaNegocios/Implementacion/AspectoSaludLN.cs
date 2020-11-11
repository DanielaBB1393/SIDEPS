using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;

namespace LogicaNegocios.Implementacion
{
    public class AspectoSaludLN : IAspectoSaludLN
    {
        private readonly IAspectoSaludAD aspectoSaludAD = new AspectoSaludAD();

        public bool SP_Ins_AspectoSalud(SIDEPS_16REGASPS aspecto)
        {
            try
            {
                return this.aspectoSaludAD.SP_Ins_AspectoSalud(aspecto);
            }
            catch
            {
                throw;
            }
        }
    }
}