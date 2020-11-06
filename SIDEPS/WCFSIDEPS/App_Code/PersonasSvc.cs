using Entidades;
using LogicaNegocios.Implementacion;
using LogicaNegocios.Interfaces;

public class PersonasSvc : IPersonasSvc
{
    private readonly IPersonasLN registroPersonaLN = new PersonasLN();

    public bool SP_Ins_RegistroPersona(SIDEPS_13REGPERS persona)
    {
        try
        {
            return this.registroPersonaLN.SP_Ins_RegistroPersona(persona);
        }
        catch
        {
            throw;
        }
    }
}