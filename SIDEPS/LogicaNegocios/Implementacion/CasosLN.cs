using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;
using System.Collections.Generic;

namespace LogicaNegocios.Implementacion
{
    public class CasosLN : ICasosLN
    {
        private readonly ICasosAD accesoDatos = new CasosAD();

        public SP_CON_CASOXID_Result ConCaso(int codigoCaso)
        {
            try
            {
                return this.accesoDatos.ConCaso(codigoCaso);
            }
            catch
            {
                throw;
            }
        }

        public void EliminarCaso(int codigoCaso)
        {
            try
            {
                this.accesoDatos.EliminarCaso(codigoCaso);
            }
            catch
            {
                throw;
            }
        }

        public DETASPS_Result SP_Con_AspectoSalud(int codigoCaso)
        {
            try
            {
                return this.accesoDatos.SP_Con_AspectoSalud(codigoCaso);
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_CATCASOAY_Result> SP_Con_AyudasXcaso(int codigoCaso)
        {
            try
            {
                return this.accesoDatos.SP_Con_AyudasXcaso(codigoCaso);
            }
            catch
            {
                throw;
            }
        }

        public DETPERS_Result SP_Con_DatosPersonales(int codigoCaso)
        {
            try
            {
                return this.accesoDatos.SP_Con_DatosPersonales(codigoCaso);
            }
            catch
            {
                throw;
            }
        }

        public DETEGRF_Result SP_Con_Egresos(int codigoCaso)
        {
            try
            {
                return this.accesoDatos.SP_Con_Egresos(codigoCaso);
            }
            catch
            {
                throw;
            }
        }

        public List<DETFAML_Result> SP_Con_GrupoFamiliar(int codigoCaso)
        {
            try
            {
                return this.accesoDatos.SP_Con_GrupoFamiliar(codigoCaso);
            }
            catch
            {
                throw;
            }
        }

        public List<SP_CON_HISTCASOS_Result> SP_Con_HistoricoCasos(int diaconia)
        {
            try
            {
                return this.accesoDatos.SP_Con_HistoricoCasos(diaconia);
            }
            catch
            {
                throw;
            }
        }

        public string SP_Con_ObservacionesCaso(int codigoCaso)
        {
            try
            {
                return this.accesoDatos.SP_Con_ObservacionesCaso(codigoCaso);
            }
            catch
            {
                throw;
            }
        }

        public DETVIVI_Result SP_Con_Vivienda(int codigoCaso)
        {
            try
            {
                return this.accesoDatos.SP_Con_Vivienda(codigoCaso);
            }
            catch
            {
                throw;
            }
        }

        public bool SP_Ins_AyudasXCaso(List<SIDEPS_27TIPAYUD> ayudasAprobadas)
        {
            try
            {
                return this.accesoDatos.SP_Ins_AyudasXCaso(ayudasAprobadas);
            }
            catch
            {
                throw;
            }
        }

        public int SP_Ins_Caso(SIDEPS_25REGCASO caso)
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

        public bool SP_Mod_Caso(SIDEPS_25REGCASO caso)
        {
            try
            {
                return accesoDatos.SP_Mod_Caso(caso);
            }
            catch
            {
                throw;
            }
        }
    }
}