using System;
using System.ComponentModel;

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
        public string NAPVIVI20 { get; set; }
        [DisplayName("Servicio cable")]
        public string SRCVIVI20 { get; set; }
        [DisplayName("Servicio internet")]
        public bool SRIVIVI20 { get; set; }
        [DisplayName("Letrina")]
        public string SRLVIVI20 { get; set; }
        [DisplayName("Servicio municipalidad")]
        public string SRMVIVI20 { get; set; }
        [DisplayName("Recolección basura")]
        public string SRBVIVI20 { get; set; }
        [DisplayName("Electricidad")]
        public string SREVIVI20 { get; set; }
    }
}