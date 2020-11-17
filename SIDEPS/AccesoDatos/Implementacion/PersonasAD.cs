﻿using AccesoDatos.Interfaces;
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
                var resultado = this.contexto.SIDEPS_13REGPERS.Add(persona);
                return this.contexto.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}