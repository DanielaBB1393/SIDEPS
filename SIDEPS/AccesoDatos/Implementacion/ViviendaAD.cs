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
                if(this.contexto.SIDEPS_20REGVIVI.Find(vivienda.CODVIVI20) != null)
                {
                    //modifica datos vivienda existentes
                    return this.contexto.SP_MOD_REGVIVI(
                        vivienda.CODVIVI20,
                        vivienda.CODTIPV18,
                        vivienda.CODESTV19,
                        vivienda.CODMATE17,
                        vivienda.MTOVIVI20,
                        vivienda.NAPVIVI20,
                        vivienda.SRCVIVI20,
                        vivienda.SRIVIVI20,
                        vivienda.SRLVIVI20,
                        vivienda.SRMVIVI20,
                        vivienda.SRBVIVI20,
                        vivienda.SREVIVI20
                    );
                }
                else
                {
                    //inserta datos de vivienda nuevo
                    var resultado = this.contexto.SIDEPS_20REGVIVI.Add(vivienda);
                    this.contexto.SaveChanges();

                    //referencia los nuevos datos de vivienda con el caso existente
                    SIDEPS_25REGCASO caso = this.contexto.SIDEPS_25REGCASO.Find(codigoCaso);
                    caso.CODVIVI20 = resultado.CODVIVI20;
                    this.contexto.SaveChanges();
                    return resultado.CODVIVI20;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}