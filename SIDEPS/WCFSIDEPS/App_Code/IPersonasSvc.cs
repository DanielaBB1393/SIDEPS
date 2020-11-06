using Entidades;
using System.ServiceModel;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRegistroPersona" in both code and config file together.
[ServiceContract]
public interface IPersonasSvc
{
    [OperationContract]
    bool SP_Ins_RegistroPersona(SIDEPS_13REGPERS persona);
}