using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;
using System;
using System.Collections.Generic;

namespace LogicaNegocios.Implementacion
{
    public class UsuariosLN : IUsuariosLN
    {
        public static SIDEPSEntities _gobjContextoPS = new SIDEPSEntities();
        public readonly IUsuariosAD objUsuarioAD = new UsuariosAD(_gobjContextoPS);

        public List<SIDEPS_07REGUSRO> Usuario()
        {
            List<SIDEPS_07REGUSRO> lstRespuesta = new List<SIDEPS_07REGUSRO>();
            try
            {
                lstRespuesta = objUsuarioAD.Usuario();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstRespuesta;
        }

        public List<SP_CON_REGUSRO_Result> conUsuario()
        {
            List<SP_CON_REGUSRO_Result> lstRespuesta = new List<SP_CON_REGUSRO_Result>();
            try
            {
                lstRespuesta = objUsuarioAD.conUsuario();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstRespuesta;
        }

        public SP_CONXID_REGUSRO_Result conUsuarioXId(int pid)

        {
            SP_CONXID_REGUSRO_Result lstRespuesta = new SP_CONXID_REGUSRO_Result();
            try
            {
                lstRespuesta = objUsuarioAD.conUsuarioXId(pid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstRespuesta;
        }

        public bool insUsuario(SIDEPS_07REGUSRO pobjUsuario)
        {
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = objUsuarioAD.insUsuario(pobjUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }

        public bool modUsuario(SIDEPS_07REGUSRO pobjUsuario)
        {
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = objUsuarioAD.modUsuario(pobjUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }

        public bool delUsuario(SIDEPS_07REGUSRO pobjUsuario)
        {
            bool objRespuesta = new bool();
            try
            {
                objRespuesta = objUsuarioAD.delUsuario(pobjUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objRespuesta;
        }
    }
}