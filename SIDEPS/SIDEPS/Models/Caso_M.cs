using SIDEPS.WCFCasos;
using System;

namespace SIDEPS.Models
{
    public class Caso_M
    {
        public int CODCASO25 { get; set; }
        public string CEDPERS13 { get; set; }
        public Nullable<int> CODASPS16 { get; set; }
        public string CEDUSRO07 { get; set; }
        public Nullable<int> CODVIVI20 { get; set; }
        public Nullable<int> CODEGRF24 { get; set; }
        public Nullable<DateTime> FEICASO25 { get; set; }
        public Nullable<DateTime> FEFCASO25 { get; set; }
        public string DESCASO25 { get; set; }
        public string OPICASO25 { get; set; }
        public string ESTCASO25 { get; set; }

        public Caso_M()
        {
        }

        public Caso_M(SIDEPS_25REGCASO caso)
        {
            this.CODCASO25 = caso.CODCASO25;
            this.CEDPERS13 = caso.CEDPERS13;
            this.CODASPS16 = caso.CODASPS16;
            this.CEDUSRO07 = caso.CEDUSRO07;
            this.CODVIVI20 = caso.CODVIVI20;
            this.CODEGRF24 = caso.CODEGRF24;
            this.FEICASO25 = caso.FEICASO25;
            this.FEFCASO25 = caso.FEFCASO25;
            this.DESCASO25 = caso.DESCASO25;
            this.OPICASO25 = caso.OPICASO25;
            this.ESTCASO25 = caso.ESTCASO25;
        }

        public SIDEPS_25REGCASO ConvertirEntidad()
        {
            return new SIDEPS_25REGCASO
            {
                CODCASO25 = this.CODCASO25,
                CEDPERS13 = this.CEDPERS13,
                CODASPS16 = this.CODASPS16,
                CEDUSRO07 = this.CEDUSRO07,
                CODVIVI20 = this.CODVIVI20,
                CODEGRF24 = this.CODEGRF24,
                FEICASO25 = this.FEICASO25,
                FEFCASO25 = this.FEFCASO25,
                DESCASO25 = this.DESCASO25,
                OPICASO25 = this.OPICASO25,
                ESTCASO25 = this.ESTCASO25,
            };
        }
    }
}