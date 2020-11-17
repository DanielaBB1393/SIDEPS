using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;

namespace LogicaNegocios.Implementacion
{
    public class EgresosLN : IEgresosLN
    {
        private readonly IEgresosAD egresosAD = new EgresosAD();

        public int SP_Ins_Egresos(SIDEPS_24REGEGRF egresos, int codigoCaso)
        {
            try
            {
                return this.egresosAD.SP_Ins_Egresos(egresos, codigoCaso);
            }
            catch
            {
                throw;
            }
        }
    }
}