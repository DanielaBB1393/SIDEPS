using System.ServiceModel;
using Entidades;

[ServiceContract]
public interface ICasosSvc
{
    [OperationContract]
    bool SP_Ins_Caso(SIDEPS_25REGCASO caso);

    [OperationContract]
    bool SP_Ins_Persona(SIDEPS_13REGPERS persona);

    [OperationContract]
    bool SP_Ins_AspectoSalud(SIDEPS_16REGASPS aspecto);
}