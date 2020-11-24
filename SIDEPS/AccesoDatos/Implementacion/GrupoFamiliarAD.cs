using AccesoDatos.Interfaces;
using Entidades;
using System;

namespace AccesoDatos.Implementacion
{
    public class GrupoFamiliarAD : IGrupoFamiliarAD
    {
        private readonly SIDEPSEntities contexto = new SIDEPSEntities();

        public bool SP_Ins_GrupoFamiliar(SIDEPS_22REGFAML grupoFamiliar, string cedulaPersona)
        {
            try
            {
                var familiar = this.contexto.SIDEPS_22REGFAML.Add(grupoFamiliar);
                this.contexto.SaveChanges();
                var referencia = this.contexto.SIDEPS_23CATFINA.Add(new SIDEPS_23CATFINA {
                    CEDPERS13 = cedulaPersona,
                    CEDFAML22 = familiar.CEDFAML22
                });
                return this.contexto.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}