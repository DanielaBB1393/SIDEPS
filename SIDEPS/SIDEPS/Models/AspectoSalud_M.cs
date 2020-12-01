using SIDEPS.ServiciosWCF;
using System;
using System.ComponentModel;

namespace SIDEPS.Models
{
    public class AspectoSalud_M
    {
        [DisplayName("Código Aspecto")]
        public int CODASPS16 { get; set; }
        [DisplayName("Cédula")]
        public string CEDPERS13 { get; set; }
        [DisplayName("Tipo Seguro")]
        public Nullable<int> CODSEGU14 { get; set; }
        [DisplayName("Sufre alguna enfermedad")]
        public Nullable<int> CODENFR15 { get; set; }
        [DisplayName("Descripción enfermedad")]
        public string DESENFR16 { get; set; }
        [DisplayName("Recibe algún tratamiento")]
        public string RECTRAT16 { get; set; }
        [DisplayName("Descripción tratamiento")]
        public string DESTRAT16 { get; set; }

        public AspectoSalud_M()
        {
        }

        public AspectoSalud_M(SIDEPS_16REGASPS aspecto)
        {
            this.CODASPS16 = aspecto.CODASPS16;
            this.CEDPERS13 = aspecto.CEDPERS13;
            this.CODSEGU14 = aspecto.CODSEGU14;
            this.CODENFR15 = aspecto.CODENFR15;
            this.DESENFR16 = aspecto.DESENFR16;
            this.RECTRAT16 = aspecto.RECTRAT16;
            this.DESTRAT16 = aspecto.DESTRAT16;
        }

        public SIDEPS_16REGASPS ConvertirEntidad()
        {
            return new SIDEPS_16REGASPS
            {
                CODASPS16 = this.CODASPS16,
                CEDPERS13 = this.CEDPERS13,
                CODSEGU14 = this.CODSEGU14,
                CODENFR15 = this.CODENFR15,
                DESENFR16 = this.DESENFR16,
                RECTRAT16 = this.RECTRAT16,
                DESTRAT16 = this.DESTRAT16,
            };
        }
    }
}