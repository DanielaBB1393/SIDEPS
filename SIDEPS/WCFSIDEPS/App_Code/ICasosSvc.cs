using System.Collections.Generic;
using System.ServiceModel;
using Entidades;

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
    bool SP_Ins_GrupoFamiliar(SIDEPS_22REGFAML grupoFamiliar);

    [OperationContract]
    int SP_Ins_Egresos(SIDEPS_24REGEGRF egresos, int codigoCaso);

    [OperationContract]
    List<SP_CON_CATRELG_Result> SP_Con_Religiones();

    [OperationContract]
    List<SP_CON_CATCANT_Result> SP_Con_Cantones();
}