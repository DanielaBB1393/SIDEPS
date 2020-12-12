using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;

namespace LogicaNegocios.Implementacion
{
    public class PersonasLN : IPersonasLN
    {
        private readonly IPersonasAD registroPersonaAD = new PersonasAD();

        public bool SP_InsMod_RegistroPersona(SIDEPS_13REGPERS persona, int? codigoCaso)
        {
            try
            {
                return registroPersonaAD.SP_InsMod_RegistroPersona(persona, codigoCaso);
            }
            catch
            {
                throw;
            }
        }
    }
}