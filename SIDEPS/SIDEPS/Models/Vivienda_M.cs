using System;
using System.ComponentModel;

namespace SIDEPS.Models
{
    public class Vivienda_M
    {
        [DisplayName("Codigo Vivienda")]
        public int CODVIVI20 { get; set; }
        [DisplayName("Tipo Vivienda")]
        public Nullable<int> CODTIPV18 { get; set; }
        [DisplayName("Estado")]
        public Nullable<int> CODESTV19 { get; set; }
        [DisplayName("Materiales")]
        public Nullable<int> CODMATE17 { get; set; }
        [DisplayName("MTOVIVI20")]
        public Nullable<decimal> MTOVIVI20 { get; set; }
        [DisplayName("Numero Aposentos")]
        public string NAPVIVI20 { get; set; }
        [DisplayName("SRCVIVI20")]
        public string SRCVIVI20 { get; set; }
        [DisplayName("SRIVIVI20")]
        public string SRIVIVI20 { get; set; }
        [DisplayName("Letrina")]
        public string SRLVIVI20 { get; set; }
        [DisplayName("Servicio Municipalidad")]
        public string SRMVIVI20 { get; set; }
        [DisplayName("Recoleccion Basura")]
        public string SRBVIVI20 { get; set; }
        [DisplayName("Electricidad")]
        public string SREVIVI20 { get; set; }
    }
}