using Entidades;
using LogicaNegocios.Implementacion;
using LogicaNegocios.Interfaces;
using System;
using System.Collections.Generic;

public class ServiciosWCF : IServiciosWCF
{
    private readonly ICasosLN casosLN = new CasosLN();
    private readonly IPersonasLN personasLN = new PersonasLN();
    private readonly IAspectoSaludLN aspectoSaludLN = new AspectoSaludLN();
    private readonly IViviendaLN viviendaLN = new ViviendaLN();
    private readonly IGrupoFamiliarLN grupoFamiliarLN = new GrupoFamiliarLN();
    private readonly IEgresosLN egresosLN = new EgresosLN();
    private readonly ICategoriasLN categoriasLN = new CategoriasLN();
    private readonly IDiaconiaLN diaconiaLN = new DiaconiaLN();
    private readonly IUsuariosLN objUsuario = new UsuariosLN();

    public List<SP_CON_HISTCASOS_Result> SP_Con_HistoricoCasos(string cedulaUsuario)
    {
        try
        {
            return this.casosLN.SP_Con_HistoricoCasos(cedulaUsuario);
        }
        catch
        {
            throw;
        }
    }

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

    public bool SP_Ins_MiembroFamiliar(SIDEPS_22REGFAML grupoFamiliar, string cedulaPersona)
    {
        try
        {
            return this.grupoFamiliarLN.SP_Ins_MiembroFamiliar(grupoFamiliar, cedulaPersona);
        }
        catch
        {
            throw;
        }
    }

    public SP_CONXID_REGFAML_Result SP_Con_MiembroFamiliarXid(string cedFamiliar)
    {
        try
        {
            return this.grupoFamiliarLN.SP_Con_MiembroFamiliarXid(cedFamiliar);
        }
        catch
        {
            throw;
        }
    }

    public void SP_Del_MiembroFamiliarXid(string cedFamiliar)
    {
        try
        {
            this.grupoFamiliarLN.SP_Del_MiembroFamiliarXid(cedFamiliar);
        }
        catch
        {
            throw;
        }
    }

    public bool SP_Mod_MiembroFamiliar(SIDEPS_22REGFAML miembroFamiliar)
    {
        try
        {
            return this.grupoFamiliarLN.SP_Mod_MiembroFamiliar(miembroFamiliar);
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_REGFAML_Result> ConGrupoFamiliarXId(string cedulaSolicitante)
    {
        try
        {
            return this.grupoFamiliarLN.ConGrupoFamiliarXId(cedulaSolicitante);
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

    public List<SP_CON_CATESTC_Result> SP_Con_EstadosCivil()
    {
        try
        {
            return this.categoriasLN.SP_Con_EstadosCivil();
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

    public List<SP_CON_CATNEDU_Result> SP_Con_NivelEducativo()
    {
        try
        {
            return this.categoriasLN.SP_Con_NivelEducativo();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_CATPAIS_Result> SP_Con_Pais()
    {
        try
        {
            return this.categoriasLN.SP_Con_Pais();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_CATPROV_Result> SP_Con_Provincia()
    {
        try
        {
            return this.categoriasLN.SP_Con_Provincia();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_TIPUSRO_Result> SP_Con_TipoUsuario()
    {
        try
        {
            return this.categoriasLN.SP_Con_TipoUsuario();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_CATSOLI_Result> SP_Con_CategoriaSolicitud()
    {
        try
        {
            return this.categoriasLN.SP_Con_CategoriaSolicitud();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_CATPARE_Result> SP_Con_Parentescos()
    {
        try
        {
            return this.categoriasLN.SP_Con_Parentescos();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_CATSEGU_Result> SP_Con_Seguros()
    {
        try
        {
            return this.categoriasLN.SP_Con_Seguros();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_CATENFR_Result> SP_Con_Enfermedades()
    {
        try
        {
            return this.categoriasLN.SP_Con_Enfermedades();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_CATMATE_Result> SP_Con_Materiales()
    {
        try
        {
            return this.categoriasLN.SP_Con_Materiales();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_TIPVIVI_Result> SP_Con_TipoVivienda()
    {
        try
        {
            return this.categoriasLN.SP_Con_TipoVivienda();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_ESTVIVI_Result> SP_Con_EstadoVivienda()
    {
        try
        {
            return this.categoriasLN.SP_Con_EstadoVivienda();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_CATORGS_Result> SP_Con_Organizaciones()
    {
        try
        {
            return this.categoriasLN.SP_Con_Organizaciones();
        }
        catch
        {
            throw;
        }
    }

    public List<SP_CON_CATAYUD_Result> SP_Con_CategoriasAyudas()
    {
        try
        {
            return this.categoriasLN.SP_Con_CategoriasAyudas();
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

    public string Login(string cedula, string contrasena)
    {
        try
        {
            return objUsuario.Login(cedula, contrasena);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DETASPS_Result SP_Con_AspectoSalud(int codigoCaso)
    {
        try
        {
            return this.casosLN.SP_Con_AspectoSalud(codigoCaso);
        }
        catch
        {
            throw;
        }
    }

    public DETPERS_Result SP_Con_DatosPersonales(int codigoCaso)
    {
        try
        {
            return this.casosLN.SP_Con_DatosPersonales(codigoCaso);
        }
        catch
        {
            throw;
        }
    }

    public DETEGRF_Result SP_Con_Egresos(int codigoCaso)
    {
        try
        {
            return this.casosLN.SP_Con_Egresos(codigoCaso);
        }
        catch
        {
            throw;
        }
    }

    public List<DETFAML_Result> SP_Con_GrupoFamiliar(int codigoCaso)
    {
        try
        {
            return this.casosLN.SP_Con_GrupoFamiliar(codigoCaso);
        }
        catch
        {
            throw;
        }
    }

    public string SP_Con_ObservacionesCaso(int codigoCaso)
    {
        try
        {
            return this.casosLN.SP_Con_ObservacionesCaso(codigoCaso);
        }
        catch
        {
            throw;
        }
    }

    public DETVIVI_Result SP_Con_Vivienda(int codigoCaso)
    {
        try
        {
            return this.casosLN.SP_Con_Vivienda(codigoCaso);
        }
        catch
        {
            throw;
        }
    }

    public SP_CON_CASOXID_Result ConCaso(int codigoCaso)
    {
        try
        {
            return this.casosLN.ConCaso(codigoCaso);
        }
        catch
        {
            throw;
        }
    }
}