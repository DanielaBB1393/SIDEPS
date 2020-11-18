using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvDiaconia" en el código, en svc y en el archivo de configuración a la vez.
public class srvDiaconia : IsrvDiaconia
{


    private IDiaconiaLN objDiac = new DiaconiaLN();

    public List<SIDEPS_04REGDIAC> Diaconia()
    {
        List<SIDEPS_04REGDIAC> lstRespuesta = new List<SIDEPS_04REGDIAC>();
        try
        {
            lstRespuesta = objDiac.Diaconia();
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
            lstRespuesta = objDiac.conDiaconias();
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
            lstRespuesta = objDiac.conDiaconiasXId(pid);
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
            objRespuesta = objDiac.insDiaconia(pobjDiac);

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
            objRespuesta = objDiac.modDiaconia(pobjDiac);

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
            objRespuesta = objDiac.delDiaconia(pobjDiac);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        return objRespuesta;
    }

 
}
