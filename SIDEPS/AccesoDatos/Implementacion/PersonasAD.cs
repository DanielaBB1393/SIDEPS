using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Linq;

namespace AccesoDatos.Implementacion
{
    public class PersonasAD : IPersonasAD
    {
        private readonly SIDEPSEntities contexto = new SIDEPSEntities();

        public bool SP_Ins_RegistroPersona(SIDEPS_13REGPERS persona)
        {
            try
            {
                bool existe = this.contexto.SIDEPS_13REGPERS
                    .Any(regper => regper.CEDPERS13.Equals(persona.CEDPERS13, StringComparison.OrdinalIgnoreCase));

                if (existe)
                {
                    // no puede insertar porque ya la cedula existe
                    return false;
                }

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