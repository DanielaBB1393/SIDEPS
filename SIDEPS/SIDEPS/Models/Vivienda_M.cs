using System;
using System.ComponentModel;
using SIDEPS.ServiciosWCF;

namespace SIDEPS.Models
{
    public class Vivienda_M
    {
        [DisplayName("Codigo vivienda")]
        public int CODVIVI20 { get; set; }
        [DisplayName("Tipo vivienda")]
        public Nullable<int> CODTIPV18 { get; set; }
        [DisplayName("Estado")]
        public Nullable<int> CODESTV19 { get; set; }
        [DisplayName("Materiales")]
        public Nullable<int> CODMATE17 { get; set; }
        [DisplayName("Monto vivienda")]
        public Nullable<decimal> MTOVIVI20 { get; set; }
        [DisplayName("Numero aposentos")]
        public int? NAPVIVI20 { get; set; }
        [DisplayName("Servicio cable")]
        public bool SRCVIVI20 { get; set; }
        [DisplayName("Servicio internet")]
        public bool SRIVIVI20 { get; set; }
        [DisplayName("Letrina")]
        public bool SRLVIVI20 { get; set; }
        [DisplayName("Servicio municipalidad")]
        public bool SRMVIVI20 { get; set; }
        [DisplayName("Recolección basura")]
        public bool SRBVIVI20 { get; set; }
        [DisplayName("Electricidad")]
        public bool SREVIVI20 { get; set; }

        public Vivienda_M()
        {
        }

        public Vivienda_M(SIDEPS_20REGVIVI vivienda)
        {
            this.CODVIVI20 = vivienda.CODVIVI20;
            this.CODTIPV18 = vivienda.CODTIPV18;
            this.CODESTV19 = vivienda.CODESTV19;
            this.CODMATE17 = vivienda.CODMATE17;
            this.MTOVIVI20 = vivienda.MTOVIVI20;
            this.NAPVIVI20 = vivienda.NAPVIVI20;
            this.SRCVIVI20 = vivienda.SRCVIVI20.GetValueOrDefault();
            this.SRIVIVI20 = vivienda.SRIVIVI20.GetValueOrDefault();
            this.SRLVIVI20 = vivienda.SRLVIVI20.GetValueOrDefault();
            this.SRMVIVI20 = vivienda.SRMVIVI20.GetValueOrDefault();
            this.SRBVIVI20 = vivienda.SRBVIVI20.GetValueOrDefault();
            this.SREVIVI20 = vivienda.SREVIVI20.GetValueOrDefault();
        }

        public SIDEPS_20REGVIVI ConvertirEntidad()
        {
            return new SIDEPS_20REGVIVI
            {
                CODVIVI20 = this.CODVIVI20,
                CODTIPV18 = this.CODTIPV18,
                CODESTV19 = this.CODESTV19,
                CODMATE17 = this.CODMATE17,
                MTOVIVI20 = this.MTOVIVI20,
                NAPVIVI20 = this.NAPVIVI20,
                SRCVIVI20 = this.SRCVIVI20,
                SRIVIVI20 = this.SRIVIVI20,
                SRLVIVI20 = this.SRLVIVI20,
                SRMVIVI20 = this.SRMVIVI20,
                SRBVIVI20 = this.SRBVIVI20,
                SREVIVI20 = this.SREVIVI20,
            };
        }
    }
}