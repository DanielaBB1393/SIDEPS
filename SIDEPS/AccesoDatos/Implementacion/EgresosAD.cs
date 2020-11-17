using AccesoDatos.Interfaces;
using Entidades;
using System;

namespace AccesoDatos.Implementacion
{
    public class EgresosAD : IEgresosAD
    {
        private readonly SIDEPSEntities contexto = new SIDEPSEntities();

        public int SP_Ins_Egresos(SIDEPS_24REGEGRF egresos, int codigoCaso)
        {
            try
            {
                var resultado = this.contexto.SIDEPS_24REGEGRF.Add(egresos);
                this.contexto.SaveChanges();

                SIDEPS_25REGCASO caso = this.contexto.SIDEPS_25REGCASO.Find(codigoCaso);
                caso.CODEGRF24 = resultado.CODEGRF24;
                this.contexto.SaveChanges();

                return resultado.CODEGRF24;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}