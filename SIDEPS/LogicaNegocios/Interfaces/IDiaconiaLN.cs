using Entidades;
using System.Collections.Generic;

namespace LogicaNegocios.Interfaces
{
    public interface IDiaconiaLN
    {
        List<SIDEPS_04REGDIAC> Diaconia();

        List<SP_CON_REGDIAC_Result> conDiaconias();

        SP_CONXID_REGDIAC_Result conDiaconiasXId(int pid);

        bool insDiaconia(SIDEPS_04REGDIAC pobjDiac);

        bool modDiaconia(SIDEPS_04REGDIAC pobjDiac);

        bool delDiaconia(SIDEPS_04REGDIAC pobjDiac);
    }
}