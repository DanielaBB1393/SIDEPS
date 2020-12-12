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
                if (this.contexto.SIDEPS_24REGEGRF.Find(egresos.CODEGRF24) != null)
                {
                    //modifica egresos existentes
                    return this.contexto.SP_MOD_REGEGRF(
                        egresos.CODEGRF24,
                        egresos.MTOALQU24,
                        egresos.MTOALIM24,
                        egresos.MTOELEC24,
                        egresos.MTOGAST24,
                        egresos.MTCAGUA24,
                        egresos.MTOCABL24,
                        egresos.MTOTELF24,
                        egresos.MTOINTE24,
                        egresos.MTOEDUC24,
                        egresos.MTOSEGU24,
                        egresos.MTOOTRO24
                    );
                }
                else
                {
                    //inserta nuevos egresos
                    var resultado = this.contexto.SIDEPS_24REGEGRF.Add(egresos);
                    this.contexto.SaveChanges();

                    SIDEPS_25REGCASO caso = this.contexto.SIDEPS_25REGCASO.Find(codigoCaso);
                    caso.CODEGRF24 = resultado.CODEGRF24;
                    this.contexto.SaveChanges();

                    return resultado.CODEGRF24;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}