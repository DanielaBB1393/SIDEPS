using AccesoDatos.Interfaces;
using Entidades;
using System;

namespace AccesoDatos.Implementacion
{
    public class CasosAD : ICasosAD
    {
        SIDEPSEntities contexto = new SIDEPSEntities();

        public bool SP_Ins_Caso(SIDEPS_25REGCASO caso)
        {
            try
            {
                using (var contexto = new SIDEPSEntities())
                {
                    var result = contexto.SIDEPS_25REGCASO.Add(caso);
                    contexto.SaveChanges();
                    //result.codigo contiene el codigo que se genero en BD
                    return true;
                }

                return contexto.SP_INS_REGCASO(
                    caso.CEDPERS13,
                    caso.CODASPS16,
                    caso.CEDUSRO07,
                    caso.CODVIVI20,
                    caso.CODEGRF24,
                    caso.FEICASO25,
                    caso.FEFCASO25,
                    caso.DESCASO25,
                    caso.OPICASO25,
                    caso.ESTCASO25) > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}