using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;
using System;
using System.Collections.Generic;

namespace LogicaNegocios.Implementacion
{
    public class DiaconiaLN : IDiaconiaLN
    {
        public static SIDEPSEntities _gobjContextoPS = new SIDEPSEntities();
        public readonly IDiaconiaAD objDiacAD = new DiaconiasAD(_gobjContextoPS);

        public List<SIDEPS_04REGDIAC> Diaconia()
        {
            List<SIDEPS_04REGDIAC> lstRespuesta = new List<SIDEPS_04REGDIAC>();
            try
            {
                lstRespuesta = objDiacAD.Diaconia();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstRespuesta;
        }

        public List<SP_CON_REGDIAC_Result> conDiaconias()
        {
            List<SP_CON_REGDIAC_Result> lstRespuesta = new List<SP_CON_REGDIAC_Result>();
            try
            {
                lstRespuesta = objDiacAD.conDiaconias();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstRespuesta;
        }

        public SP_CONXID_REGDIAC_Result conDiaconiasXId(int pid)

        {
            SP_CONXID_REGDIAC_Result lstRespuesta = new SP_CONXID_REGDIAC_Result();
            try
            {
                lstRespuesta = objDiacAD.conDiaconiasXId(pid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstRespuesta;
        }

        public bool insDiaconia(SIDEPS_04REGDIAC pobjDiac)
        {
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = objDiacAD.insDiaconia(pobjDiac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }

        public bool modDiaconia(SIDEPS_04REGDIAC pobjDiac)
        {
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = objDiacAD.modDiaconia(pobjDiac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }

        public bool delDiaconia(SIDEPS_04REGDIAC pobjDiac)
        {
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = objDiacAD.delDiaconia(pobjDiac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }
    }
}