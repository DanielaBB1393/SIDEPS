using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocios.Interfaces;

namespace LogicaNegocios.Implementacion
{
    public class ViviendaLN : IViviendaLN
    {
        private readonly IViviendaAD viviendaAD = new ViviendaAD();

        public int SP_Ins_Vivienda(SIDEPS_20REGVIVI vivienda, int codigoCaso)
        {
            try
            {
                return this.viviendaAD.SP_Ins_Vivienda(vivienda, codigoCaso);
            }
            catch
            {
                throw;
            }
        }
    }
}