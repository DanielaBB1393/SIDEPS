using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos.Implementacion
{
    public class CategoriasAD : ICategoriasAD
    {
        private readonly SIDEPSEntities contexto = new SIDEPSEntities();

        public List<SP_CON_CATCANT_Result> SP_Con_Cantones()
        {
            try
            {
                return this.contexto.SP_CON_CATCANT().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_CATESTC_Result> SP_Con_EstadosCivil()
        {
            try
            {
                return this.contexto.SP_CON_CATESTC().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<SP_CON_CATRELG_Result> SP_Con_Religiones()
        {
            try
            {
                return this.contexto.SP_CON_CATRELG().ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_CATNEDU_Result> SP_Con_NivelEducativo()
        {
            try
            {
                return this.contexto.SP_CON_CATNEDU().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_CATPAIS_Result> SP_Con_Pais()
        {
            try
            {
                return this.contexto.SP_CON_CATPAIS().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_CATPROV_Result> SP_Con_Provincia()
        {
            try
            {
                return this.contexto.SP_CON_CATPROV().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_TIPUSRO_Result> SP_Con_TipoUsuario()
        {
            try
            {
                return this.contexto.SP_CON_TIPUSRO().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_CATSOLI_Result> SP_Con_CategoriaSolicitud()
        {
            try
            {
                return this.contexto.SP_CON_CATSOLI().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_CATPARE_Result> SP_Con_Parentescos()
        {
            try
            {
                return this.contexto.SP_CON_CATPARE().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_CATSEGU_Result> SP_Con_Seguros()
        {
            try
            {
                return this.contexto.SP_CON_CATSEGU().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_CATENFR_Result> SP_Con_Enfermedades()
        {
            try
            {
                return this.contexto.SP_CON_CATENFR().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_CATMATE_Result> SP_Con_Materiales()
        {
            try
            {
                return this.contexto.SP_CON_CATMATE().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_TIPVIVI_Result> SP_Con_TipoVivienda()
        {
            try
            {
                return this.contexto.SP_CON_TIPVIVI().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_ESTVIVI_Result> SP_Con_EstadoVivienda()
        {
            try
            {
                return this.contexto.SP_CON_ESTVIVI().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_CATORGS_Result> SP_Con_Organizaciones()
        {
            try
            {
                return this.contexto.SP_CON_CATORGS().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SP_CON_CATAYUD_Result> SP_Con_CategoriasAyudas()
        {
            try
            {
                return this.contexto.SP_CON_CATAYUD().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}