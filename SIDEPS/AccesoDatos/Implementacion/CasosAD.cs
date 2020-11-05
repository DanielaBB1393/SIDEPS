using AccesoDatos.Interfaces;
using Entidades;
using System;

namespace AccesoDatos.Implementacion
{
    public class CasosAD : ICasosAD
    {
        SIDEPSEntities contexto = new SIDEPSEntities();

        public int SP_Ins_Caso(SIDEPS_25REGCASO caso)
        {
            try
            {
                return contexto.SP_INS_REGCASO(caso.CEDPERS13, caso.CODASPS16, caso.CEDUSRO07, caso.CODVIVI20, caso.CODEGRF24, caso.FEICASO25, caso.FEFCASO25, caso.DESCASO25, caso.OPICASO25, caso.ESTCASO25);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}