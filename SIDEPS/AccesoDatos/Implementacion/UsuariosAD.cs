using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos.Implementacion
{
    public class UsuariosAD : IUsuariosAD
    {
        private SIDEPSEntities gobjContextoSP;

        public UsuariosAD(SIDEPSEntities _gobjContextoPS)
        {
            this.gobjContextoSP = _gobjContextoPS;
        }

        public List<SIDEPS_07REGUSRO> Usuario()
        {
            List<SIDEPS_07REGUSRO> lobjRespuesta = new List<SIDEPS_07REGUSRO>();
            try
            {
                lobjRespuesta = gobjContextoSP.SIDEPS_07REGUSRO.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public List<SP_CON_REGUSRO_Result> conUsuario()
        {
            List<SP_CON_REGUSRO_Result> lobjRespuesta = new List<SP_CON_REGUSRO_Result>();
            try
            {
                lobjRespuesta = gobjContextoSP.SP_CON_REGUSRO().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public SP_CONXID_REGUSRO_Result conUsuarioXId(int pid)
        {
            SP_CONXID_REGUSRO_Result lobjRespuesta = new SP_CONXID_REGUSRO_Result();
            try
            {
                lobjRespuesta = gobjContextoSP.SP_CONXID_REGUSRO(pid).Single();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public SP_CONXID_REGUSRO_Result conUsuarioXCedula(string cedulaUsuario)
        {
            SP_CONXID_REGUSRO_Result lobjRespuesta = new SP_CONXID_REGUSRO_Result();
            try
            {
                lobjRespuesta = gobjContextoSP.SP_CON_USROXCED(cedulaUsuario).Single();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool insUsuario(SIDEPS_07REGUSRO pobjUsuario)
        {
            bool lobjRespuesta = new bool();
            try
            {
                var existente = gobjContextoSP.SIDEPS_07REGUSRO
                    .Any(usuario => usuario.CEDUSRO07.Equals(pobjUsuario.CEDUSRO07, StringComparison.OrdinalIgnoreCase));

                if (existente)
                {
                    // ya existe un usuario con esta cédula
                    return false;
                }

                lobjRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoSP.SP_INS_REGUSRO(pobjUsuario.CEDUSRO07, pobjUsuario.NOMUSRO07,
                    pobjUsuario.PAPUSRO07, pobjUsuario.SAPUSRO07, pobjUsuario.CODCANT03,
                    pobjUsuario.CODDIAC04, pobjUsuario.CODUSRO05, pobjUsuario.DIRUSRO07,
                    pobjUsuario.NACUSRO07, pobjUsuario.CNTUSRO07, pobjUsuario.FENUSRO07);
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

        public bool modUsuario(SIDEPS_07REGUSRO pobjUsuario)
        {
            bool lobjRespuesta = new bool();
            try
            {
                lobjRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoSP.SP_MOD_REGUSRO(pobjUsuario.CEDUSRO07, pobjUsuario.NOMUSRO07,
                    pobjUsuario.PAPUSRO07, pobjUsuario.SAPUSRO07, pobjUsuario.CODCANT03, pobjUsuario.CODDIAC04,
                    pobjUsuario.CODUSRO05, pobjUsuario.ESTUSRO07, pobjUsuario.DIRUSRO07, pobjUsuario.NACUSRO07,
                    pobjUsuario.CNTUSRO07, pobjUsuario.FEIUSRO07,pobjUsuario.FEFUSRO07,pobjUsuario.FENUSRO07);
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

        public bool delUsuario(SIDEPS_07REGUSRO pobjUsuario)
        {
            bool lobjRespuesta = new bool();
            try
            {
                lobjRespuesta = false;
                int intVal = 0;
                intVal = gobjContextoSP.SP_DEL_REGUSRO(pobjUsuario.CEDUSRO07);
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

        public string Login(string cedula, string contrasena)
        {
            try
            {
                var rolUsuario = gobjContextoSP.SIDEPS_07REGUSRO
                    .Where(usr => 
                        usr.CEDUSRO07.Equals(cedula, StringComparison.OrdinalIgnoreCase) && 
                        usr.CNTUSRO07.Equals(contrasena) &&
                        usr.ESTUSRO07.Equals("ACTIVO", StringComparison.OrdinalIgnoreCase))
                    .FirstOrDefault()?.CODUSRO05;

                if (rolUsuario.HasValue)
                {
                    return this.gobjContextoSP.SIDEPS_05TIPUSRO.Find(rolUsuario).DESUSRO05;
                }

                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}