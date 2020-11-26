using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class srvUsuarios : IsrvUsuarios
{
    private IUsuariosLN objUsuario = new UsuariosLN();

    public List<SIDEPS_07REGUSRO> Usuario()
    {
        List<SIDEPS_07REGUSRO> lstRespuesta = new List<SIDEPS_07REGUSRO>();
        try
        {
            lstRespuesta = objUsuario.Usuario();
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
            lstRespuesta = objUsuario.conUsuario();
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
            lstRespuesta = objUsuario.conUsuarioXId(pid);
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
            objRespuesta = objUsuario.insUsuario(pobjUsuario);

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
            objRespuesta = objUsuario.modUsuario(pobjUsuario);

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
            objRespuesta = objUsuario.delUsuario(pobjUsuario);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        return objRespuesta;
    }


}
