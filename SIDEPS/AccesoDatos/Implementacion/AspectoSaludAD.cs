using AccesoDatos.Interfaces;
using Entidades;
using System;

namespace AccesoDatos.Implementacion
{
    public class AspectoSaludAD : IAspectoSaludAD
    {
        private readonly SIDEPSEntities contexto = new SIDEPSEntities();
        // Metodo para insertar  y modificar el aspecto de salud
        public int SP_Ins_AspectoSalud(SIDEPS_16REGASPS aspecto, int codigoCaso)// recibe como parametros
        {
            try
            {
                if(this.contexto.SIDEPS_16REGASPS.Find(aspecto.CODASPS16) != null)// Si el aspecto de salud es diferente de null
                {
                    //modifica aspecto salud existente
                    return this.contexto.SP_MOD_REGASPS(
                        aspecto.CODASPS16,
                        aspecto.CEDPERS13,
                        aspecto.CODSEGU14,
                        aspecto.CODENFR15,
                        aspecto.DESENFR16,
                        aspecto.RECTRAT16,
                        aspecto.DESTRAT16
                    );                    
                }
                else
                {
                    //inserta aspecto salud nuevo
                    var resultado = this.contexto.SIDEPS_16REGASPS.Add(aspecto);
                    this.contexto.SaveChanges();

                    //al caso existente le referencia el nuevo aspecto salud
                    SIDEPS_25REGCASO caso = this.contexto.SIDEPS_25REGCASO.Find(codigoCaso);
                    caso.CODASPS16 = resultado.CODASPS16;
                    this.contexto.SaveChanges(); // Devuelve el numero de aspecto de salud creado

                    return resultado.CODASPS16;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}