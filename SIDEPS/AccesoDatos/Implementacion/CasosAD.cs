using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos.Implementacion
{
    public class CasosAD : ICasosAD
    {
        SIDEPSEntities contexto = new SIDEPSEntities();

        // Metodo para consultar los aspectos de salud
        public DETASPS_Result SP_Con_AspectoSalud(int codigoCaso) // recibe como parametro 
        {
            try
            {
                return this.contexto.DETASPS(codigoCaso).FirstOrDefault(); // devuelve el primer elemento si lo encuentra o sino devuelve nulo
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        // Metodo para consultar los datos personales 
        public DETPERS_Result SP_Con_DatosPersonales(int codigoCaso) // recibe como parametro
        {
            try
            {
                return this.contexto.DETPERS(codigoCaso).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        // Metodo para consultar los egresos
        public DETEGRF_Result SP_Con_Egresos(int codigoCaso)// recibe como parametro
        {
            try
            {
                return this.contexto.DETEGRF(codigoCaso).FirstOrDefault(); 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        // Metodo para consultar las personas del grupo familiar
        public List<DETFAML_Result> SP_Con_GrupoFamiliar(int codigoCaso)// recibe como parametro
        {
            try
            {
                return this.contexto.DETFAML(codigoCaso).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        // Metodo para consultar el detalle del caso
        public string SP_Con_ObservacionesCaso(int codigoCaso)// recibe como parametro
        {
            try
            {
                return this.contexto.DETCASO(codigoCaso).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        // Metodo para consultar la informacion de la vivienda
        public DETVIVI_Result SP_Con_Vivienda(int codigoCaso)// recibe como parametro
        {
            try
            {
                return this.contexto.DETVIVI(codigoCaso).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        // Metodo para consultar el historico de los casos
        public List<SP_CON_HISTCASOS_Result> SP_Con_HistoricoCasos(int diaconia)// recibe como parametro
        {
            try
            {
                return this.contexto.SP_CON_HISTCASOS(diaconia).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        // Metodo para insertar el caso
        public int SP_Ins_Caso(SIDEPS_25REGCASO caso)// recibe como parametro
        {
            try
            {
                var resultado = this.contexto.SIDEPS_25REGCASO.Add(caso);
                this.contexto.SaveChanges(); // inserta y recibe el numero del caso

                return resultado.CODCASO25;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Metodo para modificar el caso
        public bool SP_Mod_Caso(SIDEPS_25REGCASO caso)
        {
            try
            {
                var casoBD = this.contexto.SIDEPS_25REGCASO.Find(caso.CODCASO25);// busca el caso en bd

                // modifica unicamente los campos que vienen diferente a nulo
                // if(caso.CEDPERS13 != null)
                // {
                //     casoBD.CEDPERS13 = caso.CEDPERS13;
                // }

                casoBD.CEDPERS13 = caso.CEDPERS13 ?? casoBD.CEDPERS13;
                casoBD.CODASPS16 = caso.CODASPS16 ?? casoBD.CODASPS16;
                casoBD.CEDUSRO07 = caso.CEDUSRO07 ?? casoBD.CEDUSRO07;
                casoBD.CODVIVI20 = caso.CODVIVI20 ?? casoBD.CODVIVI20;
                casoBD.CODEGRF24 = caso.CODEGRF24 ?? casoBD.CODEGRF24;
                casoBD.FEICASO25 = caso.FEICASO25 ?? casoBD.FEICASO25;
                casoBD.FEFCASO25 = caso.FEFCASO25 ?? casoBD.FEFCASO25;
                casoBD.DESCASO25 = caso.DESCASO25 ?? casoBD.DESCASO25;
                casoBD.OPICASO25 = caso.OPICASO25 ?? casoBD.OPICASO25;
                casoBD.ESTCASO25 = caso.ESTCASO25 ?? casoBD.ESTCASO25;

                return this.contexto.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Metodo para consultar el caso
        public SP_CON_CASOXID_Result ConCaso(int codigoCaso)// recibe como parametro
        {
            try
            {
                return this.contexto.SP_CON_CASOXID(codigoCaso).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Metodo para eliminar el caso
        public void EliminarCaso(int codigoCaso)// recibe como parametro
        {
            try
            {
                this.contexto.SP_DEL_REGCASO(codigoCaso);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        // Metodo para insertar  las ayudas que recibe un caso
        public bool SP_InsMod_AyudasXCaso(List<SIDEPS_27TIPAYUD> ayudasAprobadas, int codigoCaso)// recibe como parametro
        {
            try
            {
                //ayudas asignadas al caso (si existen)
                var ayudasActuales = this.contexto.SIDEPS_27TIPAYUD
                    .Where(ayuda => ayuda.CODCASO25 == codigoCaso);

                foreach (var ayudaActual in ayudasActuales)
                {
                    // elimino las ayudas actualmente asignadas
                    this.contexto.SIDEPS_27TIPAYUD.Remove(ayudaActual);
                }

                foreach (var ayuda in ayudasAprobadas)
                {
                    // reinserto las nuevas ayudas del caso
                    this.contexto.SIDEPS_27TIPAYUD.Add(ayuda);
                }

                return
                    this.contexto.SaveChanges() > 0  // SaveChanges => cantidad de filas afectadas
                    //condicion cuando no hay ayudas aprobadas pero el metodo tiene que retornar true                              
                    || ayudasAprobadas.Count == 0;          
            }
            catch
            {
                throw;
            }
        }
        // Metodo para consultar ayudas por numero de caso
        public List<SP_CON_CATCASOAY_Result> SP_Con_AyudasXcaso(int codigoCaso)
        {
            try
            {
                return this.contexto.SP_CON_CATCASOAY(codigoCaso).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}