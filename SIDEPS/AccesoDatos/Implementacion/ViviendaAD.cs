using AccesoDatos.Interfaces;
using Entidades;
using System;

namespace AccesoDatos.Implementacion
{
    public class ViviendaAD : IViviendaAD
    {
        private readonly SIDEPSEntities contexto = new SIDEPSEntities();

        public int SP_Ins_Vivienda(SIDEPS_20REGVIVI vivienda, int codigoCaso)
        {
            try
            {
                var resultado = this.contexto.SIDEPS_20REGVIVI.Add(vivienda);
                this.contexto.SaveChanges();

                SIDEPS_25REGCASO caso = this.contexto.SIDEPS_25REGCASO.Find(codigoCaso);
                caso.CODVIVI20 = resultado.CODVIVI20;
                this.contexto.SaveChanges();

                return resultado.CODVIVI20;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}