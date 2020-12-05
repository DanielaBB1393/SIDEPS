using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;
using System.Collections.Generic;

namespace LogicaNegocios.Implementacion
{
    public class CasosLN : ICasosLN
    {
        private readonly ICasosAD accesoDatos = new CasosAD();

        public List<SP_CON_HISTCASOS_Result> SP_Con_HistoricoCasos(string cedulaUsuario)
        {
            try
            {
                return this.accesoDatos.SP_Con_HistoricoCasos(cedulaUsuario);
            }
            catch
            {
                throw;
            }
        }

        public int SP_Ins_Caso(SIDEPS_25REGCASO caso)
        {
            try
            {
                return accesoDatos.SP_Ins_Caso(caso);
            }
            catch
            {
                throw;
            }
        }

        public bool SP_Mod_Caso(SIDEPS_25REGCASO caso)
        {
            try
            {
                return accesoDatos.SP_Mod_Caso(caso);
            }
            catch
            {
                throw;
            }
        }
    }
}