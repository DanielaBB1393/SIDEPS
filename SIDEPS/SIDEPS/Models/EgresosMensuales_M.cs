using System;
using System.ComponentModel;

namespace SIDEPS.Models
{
    public class EgresosMensuales_M
    {
        [DisplayName("Código Egresos")]
        public int CODEGRF24 { get; set; }
        [DisplayName("Alquiler")]
        public Nullable<decimal> MTOALQU24 { get; set; }
        [DisplayName("Alimentacién")]
        public Nullable<decimal> MTOALIM24 { get; set; }
        [DisplayName("Electricidad")]
        public Nullable<decimal> MTOELEC24 { get; set; }
        [DisplayName("Gastos")]
        public Nullable<decimal> MTOGAST24 { get; set; }
        [DisplayName("Agua")]
        public Nullable<decimal> MTCAGUA24 { get; set; }
        [DisplayName("Cable")]
        public Nullable<decimal> MTOCABL24 { get; set; }
        [DisplayName("Teléfono")]
        public Nullable<decimal> MTOTELF24 { get; set; }
        [DisplayName("Internet")]
        public Nullable<decimal> MTOINTE24 { get; set; }
        [DisplayName("Educación")]
        public Nullable<decimal> MTOEDUC24 { get; set; }
        [DisplayName("Seguro")]
        public Nullable<decimal> MTOSEGU24 { get; set; }
        [DisplayName("Otros")]
        public Nullable<decimal> MTOOTRO24 { get; set; }
    }
}