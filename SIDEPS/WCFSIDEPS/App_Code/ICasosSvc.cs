using Entidades;
using System.Collections.Generic;
using System.ServiceModel;

[ServiceContract]
public interface ICasosSvc
{
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
    bool SP_Ins_GrupoFamiliar(SIDEPS_22REGFAML grupoFamiliar, string cedulaPersona);

    [OperationContract]
    int SP_Ins_Egresos(SIDEPS_24REGEGRF egresos, int codigoCaso);

    [OperationContract]
    List<SP_CON_CATRELG_Result> SP_Con_Religiones();

    [OperationContract]
    List<SP_CON_CATCANT_Result> SP_Con_Cantones();

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
}