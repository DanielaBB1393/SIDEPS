using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Interfaces;
using Entidades;

namespace AccesoDatos.Implementacion
{
    public class DiaconiasAD : IDiaconiaAD
    {
        private SIDEPSEntities gobjContextoSP;

        public DiaconiasAD(SIDEPSEntities _gobjContextoPS)
        {
            this.gobjContextoSP = _gobjContextoPS;
        }
        public List<SIDEPS_04REGDIAC> Diaconia()
        {
            List<SIDEPS_04REGDIAC> lobjRespuesta = new List<SIDEPS_04REGDIAC>();
            try
            {
                lobjRespuesta = gobjContextoSP.SIDEPS_04REGDIAC.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }
        public List<SP_CON_REGDIAC_Result> conDiaconias()
        {
            List<SP_CON_REGDIAC_Result> lobjRespuesta = new List<SP_CON_REGDIAC_Result>();
            try
            {
                lobjRespuesta = gobjContextoSP.SP_CON_REGDIAC().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }
        public SP_CONXID_REGDIAC_Result conDiaconiasXId(int pid)
        {
            SP_CONXID_REGDIAC_Result lobjRespuesta = new SP_CONXID_REGDIAC_Result();
            try
            {
                lobjRespuesta = gobjContextoSP.SP_CONXID_REGDIAC(pid).Single();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }
        public bool insDiaconia(SIDEPS_04REGDIAC pobjDiac)
        {
            bool lobjRespuesta = new bool();
            try
            {
                lobjRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoSP.SP_INS_REGDIAC(pobjDiac.NOMDIAC04, pobjDiac.LUGDIAC04, pobjDiac.TELDIAC04, pobjDiac.CODCANT03);
                if (intVal == 1)
                {
                    lobjRespuesta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool modDiaconia(SIDEPS_04REGDIAC pobjDiac)
        {
            bool lobjRespuesta = new bool();
            try
            {
                lobjRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoSP.SP_MOD_REGDIAC(pobjDiac.CODDIAC04,pobjDiac.NOMDIAC04, pobjDiac.LUGDIAC04, pobjDiac.TELDIAC04, pobjDiac.ESTDIAC04, pobjDiac.CODCANT03);
                if (intVal == 1)
                {
                    lobjRespuesta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }
        public bool delDiaconia(SIDEPS_04REGDIAC pobjDiac)
        {
            bool lobjRespuesta = new bool();
            try
            {
                lobjRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoSP.SP_DEL_REGDIAC(pobjDiac.CODDIAC04);
                if (intVal == 1)
                {
                    lobjRespuesta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

    }
}
