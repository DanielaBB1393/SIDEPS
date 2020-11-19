using Entidades;
using LogicaNegocios.Implementacion;
using LogicaNegocios.Interfaces;
using System;
using System.Collections.Generic;

public class CasosSvc : ICasosSvc
{
    private readonly ICasosLN casosLN = new CasosLN();
    private readonly IPersonasLN personasLN = new PersonasLN();
    private readonly IAspectoSaludLN aspectoSaludLN = new AspectoSaludLN();
    private readonly IViviendaLN viviendaLN = new ViviendaLN();
    private readonly IGrupoFamiliarLN situacionFinancieraLN = new GrupoFamiliarLN();
    private readonly IEgresosLN egresosLN = new EgresosLN();
    private readonly ICategoriasLN categoriasLN = new CategoriasLN();
    private readonly IDiaconiaLN diaconiaLN = new DiaconiaLN();

    public int SP_Ins_Caso(SIDEPS_25REGCASO caso)
    {
        try
        {
            return this.casosLN.SP_Ins_Caso(caso);
        }
        catch
        {
            throw;
        }
    }

    public bool SP_Mod_Caso(SIDEPS_25REGCASO caso)
    {
        try
        {
            return this.casosLN.SP_Mod_Caso(caso);
        }
        catch
        {
            throw;
        }
    }

    public bool SP_Ins_Persona(SIDEPS_13REGPERS persona)
    {
        try
        {
            return this.personasLN.SP_Ins_RegistroPersona(persona);
        }
        catch
        {
            throw;
        }
    }

    public int SP_Ins_AspectoSalud(SIDEPS_16REGASPS aspecto, int codigoCaso)
    {
        try
        {
            return this.aspectoSaludLN.SP_Ins_AspectoSalud(aspecto, codigoCaso);
        }
        catch
        {
            throw;
        }
    }

    public int SP_Ins_Vivienda(SIDEPS_20REGVIVI vivienda, int codigoCaso)
    {
        try
        {
            return this.viviendaLN.SP_Ins_Vivienda(vivienda, codigoCaso);
        }
        catch
        {
            throw;
        }
    }

    public bool SP_Ins_GrupoFamiliar(SIDEPS_22REGFAML grupoFamiliar)
    {
        try
        {
            return this.situacionFinancieraLN.SP_Ins_GrupoFamiliar(grupoFamiliar);
        }
        catch
        {
            throw;
        }
    }

    public int SP_Ins_Egresos(SIDEPS_24REGEGRF egresos, int codigoCaso)
    {
        try
        {
            return this.egresosLN.SP_Ins_Egresos(egresos, codigoCaso);
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_CATRELG_Result> SP_Con_Religiones()
    {
        try
        {
            return this.categoriasLN.SP_Con_Religiones();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_CATCANT_Result> SP_Con_Cantones()
    {
        try
        {
            return this.categoriasLN.SP_Con_Cantones();
        }
        catch
        {
            throw;
        }
    }

    public List<SIDEPS_04REGDIAC> Diaconia()
    {
        List<SIDEPS_04REGDIAC> lstRespuesta = new List<SIDEPS_04REGDIAC>();
        try
        {
            lstRespuesta = diaconiaLN.Diaconia();
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
            lstRespuesta = diaconiaLN.conDiaconias();
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
            lstRespuesta = diaconiaLN.conDiaconiasXId(pid);
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
            objRespuesta = diaconiaLN.insDiaconia(pobjDiac);

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
            objRespuesta = diaconiaLN.modDiaconia(pobjDiac);

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
            objRespuesta = diaconiaLN.delDiaconia(pobjDiac);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        return objRespuesta;
    }
}