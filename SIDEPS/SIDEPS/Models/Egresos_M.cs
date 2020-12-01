using SIDEPS.ServiciosWCF;
using System;
using System.ComponentModel;

namespace SIDEPS.Models
{
    public class Egresos_M
    {
        [DisplayName("Código Egresos")]
        public int CODEGRF24 { get; set; }

        [DisplayName("Alquiler")]
        public Nullable<decimal> MTOALQU24 { get; set; }

        [DisplayName("Alimentación")]
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

        public Egresos_M()
        {
        }

        public Egresos_M(SIDEPS_24REGEGRF egresos)
        {
            this.CODEGRF24 = egresos.CODEGRF24;
            this.MTOALQU24 = egresos.MTOALQU24;
            this.MTOALIM24 = egresos.MTOALIM24;
            this.MTOELEC24 = egresos.MTOELEC24;
            this.MTOGAST24 = egresos.MTOGAST24;
            this.MTCAGUA24 = egresos.MTCAGUA24;
            this.MTOCABL24 = egresos.MTOCABL24;
            this.MTOTELF24 = egresos.MTOTELF24;
            this.MTOINTE24 = egresos.MTOINTE24;
            this.MTOEDUC24 = egresos.MTOEDUC24;
            this.MTOSEGU24 = egresos.MTOSEGU24;
            this.MTOOTRO24 = egresos.MTOOTRO24;
        }

        public SIDEPS_24REGEGRF ConvertirEntidad()
        {
            return new SIDEPS_24REGEGRF
            {
                CODEGRF24 = this.CODEGRF24,
                MTOALQU24 = this.MTOALQU24,
                MTOALIM24 = this.MTOALIM24,
                MTOELEC24 = this.MTOELEC24,
                MTOGAST24 = this.MTOGAST24,
                MTCAGUA24 = this.MTCAGUA24,
                MTOCABL24 = this.MTOCABL24,
                MTOTELF24 = this.MTOTELF24,
                MTOINTE24 = this.MTOINTE24,
                MTOEDUC24 = this.MTOEDUC24,
                MTOSEGU24 = this.MTOSEGU24,
                MTOOTRO24 = this.MTOOTRO24,
            };
        }
    }
}