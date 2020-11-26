using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IsrvUsuarios
{
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
}
