using LogicaNegocios.Implementacion;
using LogicaNegocios.Interfaces;
using Entidades;

public class CasosSvc : ICasosSvc
{
    private readonly ICasosLN casosLN = new CasosLN();

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
}