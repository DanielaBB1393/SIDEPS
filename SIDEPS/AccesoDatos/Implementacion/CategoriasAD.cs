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
    }
}