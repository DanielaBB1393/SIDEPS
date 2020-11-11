using LogicaNegocios.Implementacion;
using LogicaNegocios.Interfaces;
using Entidades;

public class CasosSvc : ICasosSvc
{
    private readonly ICasosLN casosLN = new CasosLN();
    private readonly IPersonasLN personasLN = new PersonasLN();
    private readonly IAspectoSaludLN aspectoSaludLN = new AspectoSaludLN();

    public bool SP_Ins_Caso(SIDEPS_25REGCASO caso)
    {
        try
        {
            return this.casosLN.SP_Ins_Caso(caso);
        }
        catch
        {
            throw;
        }
    }

    public bool SP_Ins_Persona(SIDEPS_13REGPERS persona)
    {
        try
        {
            return this.personasLN.SP_Ins_RegistroPersona(persona);
        }
        catch
        {
            throw;
        }
    }
    public bool SP_Ins_AspectoSalud(SIDEPS_16REGASPS aspecto)
    {
        return this.aspectoSaludLN.SP_Ins_AspectoSalud(aspecto);
    }
}