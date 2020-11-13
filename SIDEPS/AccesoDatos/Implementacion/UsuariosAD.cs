using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class UsuariosAD
    {
        private SIDEPSEntities gobjContextoSIDEPS;
        public UsuariosAD(SIDEPSEntities _objContextoSIDEPS)
        {
            this.gobjContextoSIDEPS = _objContextoSIDEPS;
        }
        public List<SIDEPS_07REGUSRO> ListaUsuarios()
        {
            List<SIDEPS_07REGUSRO> lobjRespuesta = new List<SIDEPS_07REGUSRO>();

            try
            {
                lobjRespuesta = gobjContextoSIDEPS.SIDEPS_07REGUSRO.ToList();

        }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

    }
}
