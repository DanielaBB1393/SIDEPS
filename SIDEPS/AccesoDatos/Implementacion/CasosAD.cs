using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos.Implementacion
{
    public class CasosAD : ICasosAD
    {
        SIDEPSEntities contexto = new SIDEPSEntities();

        public List<SP_CON_HISTCASOS_Result> SP_Con_HistoricoCasos(string cedulaUsuario)
        {
            try
            {
                return this.contexto.SP_CON_HISTCASOS(cedulaUsuario).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int SP_Ins_Caso(SIDEPS_25REGCASO caso)
        {
            try
            {
                var resultado = this.contexto.SIDEPS_25REGCASO.Add(caso);
                this.contexto.SaveChanges();

                return resultado.CODCASO25;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SP_Mod_Caso(SIDEPS_25REGCASO caso)
        {
            try
            {
                var resultado = this.contexto.SIDEPS_25REGCASO.Find(caso.CODCASO25);

                resultado.CEDPERS13 = caso.CEDPERS13 ?? resultado.CEDPERS13;
                resultado.CODASPS16 = caso.CODASPS16 ?? resultado.CODASPS16;
                resultado.CEDUSRO07 = caso.CEDUSRO07 ?? resultado.CEDUSRO07;
                resultado.CODVIVI20 = caso.CODVIVI20 ?? resultado.CODVIVI20;
                resultado.CODEGRF24 = caso.CODEGRF24 ?? resultado.CODEGRF24;
                resultado.FEICASO25 = caso.FEICASO25 ?? resultado.FEICASO25;
                resultado.FEFCASO25 = caso.FEFCASO25 ?? resultado.FEFCASO25;
                resultado.DESCASO25 = caso.DESCASO25 ?? resultado.DESCASO25;
                resultado.OPICASO25 = caso.OPICASO25 ?? resultado.OPICASO25;
                resultado.ESTCASO25 = caso.ESTCASO25 ?? resultado.ESTCASO25;

                return this.contexto.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}