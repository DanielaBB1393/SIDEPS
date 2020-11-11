using AccesoDatos.Interfaces;
using Entidades;
using System;

namespace AccesoDatos.Implementacion
{
    public class AspectoSaludAD : IAspectoSaludAD
    {
        private readonly SIDEPSEntities contexto = new SIDEPSEntities();

        public bool SP_Ins_AspectoSalud(SIDEPS_16REGASPS aspecto)
        {
            try
            {
                var resultado = this.contexto.SP_INS_REGASPS(
                        aspecto.CEDPERS13,
                        aspecto.CODSEGU14,
                        aspecto.CODENFR15,
                        aspecto.DESENFR16,
                        aspecto.RECTRAT16,
                        aspecto.DESTRAT16
                    );

                return resultado > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}