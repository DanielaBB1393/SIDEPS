﻿using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IUsuariosLN
    {

        List<SIDEPS_07REGUSRO> Usuario();
        List<SP_CON_REGUSRO_Result> conUsuario();
        SP_CONXID_REGUSRO_Result conUsuarioXId(int pid);
        bool insUsuario(SIDEPS_07REGUSRO pobjUsuario);
        bool modUsuario(SIDEPS_07REGUSRO pobjUsuario);
        bool delUsuario(SIDEPS_07REGUSRO pobjUsuario);
    }
}
