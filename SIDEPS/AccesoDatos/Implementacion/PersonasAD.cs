using AccesoDatos.Interfaces;
using Entidades;
using System;

namespace AccesoDatos.Implementacion
{
    public class PersonasAD : IPersonasAD
    {
        private readonly SIDEPSEntities contexto = new SIDEPSEntities();

        public bool SP_Ins_RegistroPersona(SIDEPS_13REGPERS persona)
        {
            try
            {
                var resultado = contexto.SP_INS_REGPERS(
                                    persona.CEDPERS13,
                                    persona.CODESTC06,
                                    persona.CODNEDU09,
                                    persona.CODCANT03,
                                    persona.CODSOLI10,
                                    persona.CODRELG11,
                                    persona.NOMPERS13,
                                    persona.PAPPERS13,
                                    persona.SAPPERS13,
                                    persona.NACPERS13,
                                    persona.DIRPERS13,
                                    persona.OACPERS13,
                                    persona.OANPERS13);

                return resultado > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}