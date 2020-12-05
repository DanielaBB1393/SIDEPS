using Entidades;
using System.Collections.Generic;
using System.ServiceModel;

[ServiceContract]
public interface IServiciosWCF
{
    [OperationContract]
    List<SP_CON_HISTCASOS_Result> SP_Con_HistoricoCasos(string cedulaUsuario);

    [OperationContract]
    int SP_Ins_Caso(SIDEPS_25REGCASO caso);

    [OperationContract]
    bool SP_Mod_Caso(SIDEPS_25REGCASO caso);

    [OperationContract]
    bool SP_Ins_Persona(SIDEPS_13REGPERS persona);

    [OperationContract]
    int SP_Ins_AspectoSalud(SIDEPS_16REGASPS aspecto, int codigoCaso);

    [OperationContract]
    int SP_Ins_Vivienda(SIDEPS_20REGVIVI vivienda, int codigoCaso);

    [OperationContract]
    bool SP_Ins_MiembroFamiliar(SIDEPS_22REGFAML grupoFamiliar, string cedulaPersona);

    [OperationContract]
    SP_CONXID_REGFAML_Result SP_Con_MiembroFamiliarXid(string cedFamiliar);

    [OperationContract]
    void SP_Del_MiembroFamiliarXid(string cedFamiliar);

    [OperationContract]
    bool SP_Mod_MiembroFamiliar(SIDEPS_22REGFAML miembroFamiliar);

    [OperationContract]
    List<SP_CON_REGFAML_Result> ConGrupoFamiliarXId(string cedulaSolicitante);

    [OperationContract]
    int SP_Ins_Egresos(SIDEPS_24REGEGRF egresos, int codigoCaso);

    [OperationContract]
    List<SP_CON_CATRELG_Result> SP_Con_Religiones();

    [OperationContract]
    List<SP_CON_CATESTC_Result> SP_Con_EstadosCivil();

    [OperationContract]
    List<SP_CON_CATCANT_Result> SP_Con_Cantones();
    
    [OperationContract]
    List<SP_CON_CATNEDU_Result> SP_Con_NivelEducativo();
    
    [OperationContract]
    List<SP_CON_CATPAIS_Result> SP_Con_Pais();
    
    [OperationContract]
    List<SP_CON_CATPROV_Result> SP_Con_Provincia();
    
    [OperationContract]
    List<SP_CON_TIPUSRO_Result> SP_Con_TipoUsuario();
    
    [OperationContract]
    List<SP_CON_CATSOLI_Result> SP_Con_CategoriaSolicitud();
    
    [OperationContract]
    List<SP_CON_CATPARE_Result> SP_Con_Parentescos();
    
    [OperationContract]
    List<SP_CON_CATSEGU_Result> SP_Con_Seguros();
    
    [OperationContract]
    List<SP_CON_CATENFR_Result> SP_Con_Enfermedades();
    
    [OperationContract]
    List<SP_CON_CATMATE_Result> SP_Con_Materiales();
    
    [OperationContract]
    List<SP_CON_TIPVIVI_Result> SP_Con_TipoVivienda();
    
    [OperationContract]
    List<SP_CON_ESTVIVI_Result> SP_Con_EstadoVivienda();
    
    [OperationContract]
    List<SP_CON_CATORGS_Result> SP_Con_Organizaciones();
    
    [OperationContract]
    List<SP_CON_CATAYUD_Result> SP_Con_CategoriasAyudas();

    [OperationContract]
    List<SIDEPS_04REGDIAC> Diaconia();

    [OperationContract]
    List<SP_CON_REGDIAC_Result> conDiaconias();

    [OperationContract]
    SP_CONXID_REGDIAC_Result conDiaconiasXId(int pid);

    [OperationContract]
    bool insDiaconia(SIDEPS_04REGDIAC pobjDiac);

    [OperationContract]
    bool modDiaconia(SIDEPS_04REGDIAC pobjDiac);

    [OperationContract]
    bool delDiaconia(SIDEPS_04REGDIAC pobjDiac);

    [OperationContract]
    List<SIDEPS_07REGUSRO> Usuario();

    [OperationContract]
    List<SP_CON_REGUSRO_Result> conUsuario();

    [OperationContract]
    SP_CONXID_REGUSRO_Result conUsuarioXId(int pid);

    [OperationContract]
    bool insUsuario(SIDEPS_07REGUSRO pobjUsuario);

    [OperationContract]
    bool modUsuario(SIDEPS_07REGUSRO pobjUsuario);

    [OperationContract]
    bool delUsuario(SIDEPS_07REGUSRO pobjUsuario);

    [OperationContract]
    SIDEPS_07REGUSRO Login(string cedula, string contrasena);
}