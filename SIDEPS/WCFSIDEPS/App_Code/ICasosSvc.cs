using System.ServiceModel;
using Entidades;

[ServiceContract]
public interface ICasosSvc
{
    [OperationContract]
    bool SP_Ins_Caso(SIDEPS_25REGCASO caso);
}