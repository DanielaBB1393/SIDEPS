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
    }
}