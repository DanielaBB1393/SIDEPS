using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos.Implementacion
{
    public class GrupoFamiliarAD : IGrupoFamiliarAD
    {
        private readonly SIDEPSEntities contexto = new SIDEPSEntities();

        public List<SP_CON_REGFAML_Result> ConGrupoFamiliarXId(string cedFamiliar)
        {
            try
            {
                return this.contexto.SP_CON_REGFAML(cedFamiliar).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SP_CONXID_REGFAML_Result SP_Con_MiembroFamiliarXid(string cedFamiliar)
        {
            try
            {
                return this.contexto.SP_CONXID_REGFAML(cedFamiliar).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SP_Del_MiembroFamiliarXid(string cedFamiliar)
        {
            try
            {
                var referencia = this.contexto.SIDEPS_23CATFINA.Where(r => r.CEDFAML22.Equals(cedFamiliar, StringComparison.OrdinalIgnoreCase)).First();
                this.contexto.SIDEPS_23CATFINA.Remove(referencia);
                this.contexto.SaveChanges();

                var familiar = this.contexto.SIDEPS_22REGFAML.Find(cedFamiliar);
                this.contexto.SIDEPS_22REGFAML.Remove(familiar);
                this.contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SP_Ins_MiembroFamiliar(SIDEPS_22REGFAML grupoFamiliar, string cedulaPersona)
        {
            try
            {
                // agrega el nuevo familiar
                var familiar = this.contexto.SIDEPS_22REGFAML.Add(grupoFamiliar);
                this.contexto.SaveChanges();

                // relacion familiares por usuario solicitante
                var referencia = this.contexto.SIDEPS_23CATFINA.Add(new SIDEPS_23CATFINA
                {
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

        public bool SP_Mod_MiembroFamiliar(SIDEPS_22REGFAML miembroFamiliar)
        {
            try
            {
                var familiar = this.contexto.SIDEPS_22REGFAML.Find(miembroFamiliar.CEDFAML22);

                familiar.CEDFAML22 = miembroFamiliar.CEDFAML22;
                familiar.NOMFAML22 = miembroFamiliar.NOMFAML22;
                familiar.EDAFAML22 = miembroFamiliar.EDAFAML22;
                familiar.CODESTC06 = miembroFamiliar.CODESTC06;
                familiar.CODNEDU09 = miembroFamiliar.CODNEDU09;
                familiar.OACFAML22 = miembroFamiliar.OACFAML22;
                familiar.INGFAML22 = miembroFamiliar.INGFAML22;
                familiar.DESFAML22 = miembroFamiliar.DESFAML22;
                familiar.CODORGS21 = miembroFamiliar.CODORGS21;
                familiar.CODENFR15 = miembroFamiliar.CODENFR15;
                familiar.CODPARE12 = miembroFamiliar.CODPARE12;

                return this.contexto.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}