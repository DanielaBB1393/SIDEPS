using Entidades;
using System.Collections.Generic;

namespace AccesoDatos.Interfaces
{
    public interface IUsuariosAD
    {
        List<SIDEPS_07REGUSRO> Usuario();

        List<SP_CON_REGUSRO_Result> conUsuario();

        SP_CONXID_REGUSRO_Result conUsuarioXId(int pid);

        bool insUsuario(SIDEPS_07REGUSRO pobjUsuario);

        bool modUsuario(SIDEPS_07REGUSRO pobjUsuario);

        bool delUsuario(SIDEPS_07REGUSRO pobjUsuario);
    }
}