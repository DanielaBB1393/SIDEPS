using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;

namespace LogicaNegocios.Implementacion
{
    public class PersonasLN : IPersonasLN
    {
        private readonly IPersonasAD registroPersonaAD = new PersonasAD();

        public bool SP_Ins_RegistroPersona(SIDEPS_13REGPERS persona)
        {
            try
            {
                return registroPersonaAD.SP_Ins_RegistroPersona(persona);
            }
            catch
            {
                throw;
            }
        }
    }
}