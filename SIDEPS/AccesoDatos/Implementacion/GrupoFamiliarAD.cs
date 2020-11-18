using AccesoDatos.Interfaces;
using Entidades;
using System;

namespace AccesoDatos.Implementacion
{
    public class GrupoFamiliarAD : IGrupoFamiliarAD
    {
        private readonly SIDEPSEntities contexto = new SIDEPSEntities();

        public bool SP_Ins_GrupoFamiliar(SIDEPS_22REGFAML grupoFamiliar)
        {
            try
            {
                this.contexto.SIDEPS_22REGFAML.Add(grupoFamiliar);
                return this.contexto.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}