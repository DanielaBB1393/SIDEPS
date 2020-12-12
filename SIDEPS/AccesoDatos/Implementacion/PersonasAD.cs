using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Linq;

namespace AccesoDatos.Implementacion
{
    public class PersonasAD : IPersonasAD
    {
        private readonly SIDEPSEntities contexto = new SIDEPSEntities();

        public bool SP_InsMod_RegistroPersona(SIDEPS_13REGPERS persona, int? codigoCaso)
        {
            try
            {
                bool existe = this.contexto.SIDEPS_13REGPERS
                    .Any(regper => regper.CEDPERS13.Equals(persona.CEDPERS13, StringComparison.OrdinalIgnoreCase));

                if (existe && !codigoCaso.HasValue)
                {
                    // no puede insertar porque ya la cedula existe
                    return false;
                }

                if (codigoCaso.HasValue)
                {
                    //modifica
                    return this.contexto.SP_MOD_REGPERS(
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
                        persona.OANPERS13,
                        persona.FENPERS13
                    ) > 0;
                }
                else
                {
                    //inserta
                    this.contexto.SIDEPS_13REGPERS.Add(persona);
                }
                
                return this.contexto.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}