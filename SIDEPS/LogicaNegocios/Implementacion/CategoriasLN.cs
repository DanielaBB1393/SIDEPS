using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;
using System.Collections.Generic;

namespace LogicaNegocios.Implementacion
{
    public class CategoriasLN : ICategoriasLN
    {
        private readonly ICategoriasAD categoriasAD = new CategoriasAD();

        public List<SP_CON_CATCANT_Result> SP_Con_Cantones()
        {
            try
            {
                return this.categoriasAD.SP_Con_Cantones();
            }
            catch
            {
                throw;
            }
        }
        public List<SP_CON_CATESTC_Result> SP_Con_EstadosCivil()
        {
            try
            {
                return this.categoriasAD.SP_Con_EstadosCivil();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_CATRELG_Result> SP_Con_Religiones()
        {
            try
            {
                return this.categoriasAD.SP_Con_Religiones();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_CATNEDU_Result> SP_Con_NivelEducativo()
        {
            try
            {
                return this.categoriasAD.SP_Con_NivelEducativo();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_CATPAIS_Result> SP_Con_Pais()
        {
            try
            {
                return this.categoriasAD.SP_Con_Pais();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_CATPROV_Result> SP_Con_Provincia()
        {
            try
            {
                return this.categoriasAD.SP_Con_Provincia();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_TIPUSRO_Result> SP_Con_TipoUsuario()
        {
            try
            {
                return this.categoriasAD.SP_Con_TipoUsuario();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_CATSOLI_Result> SP_Con_CategoriaSolicitud()
        {
            try
            {
                return this.categoriasAD.SP_Con_CategoriaSolicitud();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_CATPARE_Result> SP_Con_Parentescos()
        {
            try
            {
                return this.categoriasAD.SP_Con_Parentescos();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_CATSEGU_Result> SP_Con_Seguros()
        {
            try
            {
                return this.categoriasAD.SP_Con_Seguros();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_CATENFR_Result> SP_Con_Enfermedades()
        {
            try
            {
                return this.categoriasAD.SP_Con_Enfermedades();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_CATMATE_Result> SP_Con_Materiales()
        {
            try
            {
                return this.categoriasAD.SP_Con_Materiales();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_TIPVIVI_Result> SP_Con_TipoVivienda()
        {
            try
            {
                return this.categoriasAD.SP_Con_TipoVivienda();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_ESTVIVI_Result> SP_Con_EstadoVivienda()
        {
            try
            {
                return this.categoriasAD.SP_Con_EstadoVivienda();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_CATORGS_Result> SP_Con_Organizaciones()
        {
            try
            {
                return this.categoriasAD.SP_Con_Organizaciones();
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_CATAYUD_Result> SP_Con_CategoriasAyudas()
        {
            try
            {
                return this.categoriasAD.SP_Con_CategoriasAyudas();
            }
            catch
            {
                throw;
            }
        }
    }
}