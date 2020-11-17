using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;

namespace LogicaNegocios.Implementacion
{
    public class GrupoFamiliarLN : IGrupoFamiliarLN
    {
        private readonly IGrupoFamiliarAD grupoFamiliarLN = new GrupoFamiliarAD();

        public bool SP_Ins_GrupoFamiliar(SIDEPS_22REGFAML grupoFamiliar)
        {
            try
            {
                return this.grupoFamiliarLN.SP_Ins_GrupoFamiliar(grupoFamiliar);
            }
            catch
            {
                throw;
            }
        }
    }
}