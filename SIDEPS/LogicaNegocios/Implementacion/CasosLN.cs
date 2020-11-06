﻿using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;

namespace LogicaNegocios.Implementacion
{
    public class CasosLN : ICasosLN
    {
        private readonly ICasosAD accesoDatos = new CasosAD();


        public bool SP_Ins_Caso(SIDEPS_25REGCASO caso)
        {
            try
            {
                return accesoDatos.SP_Ins_Caso(caso);
            }
            catch
            {
                throw;
            }
        }
    }
}