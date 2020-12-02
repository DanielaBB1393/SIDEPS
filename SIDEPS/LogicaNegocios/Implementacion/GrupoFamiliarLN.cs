using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;
using System.Collections.Generic;

namespace LogicaNegocios.Implementacion
{
    public class GrupoFamiliarLN : IGrupoFamiliarLN
    {
        private readonly IGrupoFamiliarAD grupoFamiliarAD = new GrupoFamiliarAD();

        public List<SP_CON_REGFAML_Result> ConGrupoFamiliarXId(string cedFamiliar)
        {
            try
            {
                return this.grupoFamiliarAD.ConGrupoFamiliarXId(cedFamiliar);
            }
            catch
            {
                throw;
            }
        }

        public SP_CONXID_REGFAML_Result SP_Con_MiembroFamiliarXid(string cedFamiliar)
        {
            try
            {
                return this.grupoFamiliarAD.SP_Con_MiembroFamiliarXid(cedFamiliar);
            }
            catch
            {
                throw;
            }
        }

        public void SP_Del_MiembroFamiliarXid(string cedFamiliar)
        {
            try
            {
                this.grupoFamiliarAD.SP_Del_MiembroFamiliarXid(cedFamiliar);
            }
            catch
            {
                throw;
            }
        }

        public bool SP_Ins_MiembroFamiliar(SIDEPS_22REGFAML grupoFamiliar, string cedulaPersona)
        {
            try
            {
                return this.grupoFamiliarAD.SP_Ins_MiembroFamiliar(grupoFamiliar, cedulaPersona);
            }
            catch
            {
                throw;
            }
        }

        public bool SP_Mod_MiembroFamiliar(SIDEPS_22REGFAML miembroFamiliar)
        {
            try
            {
                return this.grupoFamiliarAD.SP_Mod_MiembroFamiliar(miembroFamiliar);
            }
            catch
            {
                throw;
            }
        }
    }
}