using System.ServiceModel;
using Entidades;

[ServiceContract]
public interface ICasosSvc
{
    [OperationContract]
    int SP_Ins_Caso(SIDEPS_25REGCASO caso);
}