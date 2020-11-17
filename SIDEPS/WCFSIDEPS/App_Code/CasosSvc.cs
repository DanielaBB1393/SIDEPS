﻿using LogicaNegocios.Implementacion;
using LogicaNegocios.Interfaces;
using Entidades;

public class CasosSvc : ICasosSvc
{
    private readonly ICasosLN casosLN = new CasosLN();
    private readonly IPersonasLN personasLN = new PersonasLN();
    private readonly IAspectoSaludLN aspectoSaludLN = new AspectoSaludLN();
    private readonly IViviendaLN viviendaLN = new ViviendaLN();
    private readonly IGrupoFamiliarLN situacionFinancieraLN = new GrupoFamiliarLN();
    private readonly IEgresosLN egresosLN = new EgresosLN();

    public int SP_Ins_Caso(SIDEPS_25REGCASO caso)
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

    public bool SP_Mod_Caso(SIDEPS_25REGCASO caso)
    {
        try
        {
            return this.casosLN.SP_Mod_Caso(caso);
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
    public int SP_Ins_AspectoSalud(SIDEPS_16REGASPS aspecto, int codigoCaso)
    {
        try
        {
            return this.aspectoSaludLN.SP_Ins_AspectoSalud(aspecto, codigoCaso);
        }
        catch
        {
            throw;
        }
    }

    public int SP_Ins_Vivienda(SIDEPS_20REGVIVI vivienda, int codigoCaso)
    {
        try
        {
            return this.viviendaLN.SP_Ins_Vivienda(vivienda, codigoCaso);
        }
        catch
        {
            throw;
        }
    }

    public bool SP_Ins_GrupoFamiliar(SIDEPS_22REGFAML grupoFamiliar)
    {
        try
        {
            return this.situacionFinancieraLN.SP_Ins_GrupoFamiliar(grupoFamiliar);
        }
        catch
        {
            throw;
        }
    }

    public int SP_Ins_Egresos(SIDEPS_24REGEGRF egresos, int codigoCaso)
    {
        try
        {
            return this.egresosLN.SP_Ins_Egresos(egresos, codigoCaso);
        }
        catch
        {
            throw;
        }
    }
}