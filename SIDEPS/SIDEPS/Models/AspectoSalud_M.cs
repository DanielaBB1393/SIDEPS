using SIDEPS.ServiciosWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SIDEPS.Models
{
    public class AspectoSalud_M
    {
        [Required(ErrorMessage = "El Nombre es Requerido.")]
        [DisplayName("Código Aspecto")]
        public int CODASPS16 { get; set; }

        [DisplayName("Cédula")]
        [Required(ErrorMessage = "La Cédula es Requerida.")]
        public string CEDPERS13 { get; set; }

        [DisplayName("Tipo Seguro")]
        [Required(ErrorMessage = "Tipo Seguro Requerido.")]
        public Nullable<int> CODSEGU14 { get; set; }
        [DisplayName("Descripción enfermedad")]
        public Nullable<int> CODENFR15 { get; set; }
        [DisplayName("Sufre alguna enfermedad")]
        public string DESENFR16 { get; set; }

        [DisplayName("Recibe algún tratamiento")]
        [Required(ErrorMessage = "Recibe algún tratamiento Requerido.")]
        public string RECTRAT16 { get; set; }

        [DisplayName("Descripción tratamiento")]
        public string DESTRAT16 { get; set; }

        [DisplayName("Enfermedad")]
        public string DESENFR15 { get; set; }

        [DisplayName("Seguro")]
        public string DESSEGU14 { get; set; }

        public List<Categoria> Enfermedades { get; set; }
        public List<Categoria> TiposSeguro { get; set; }

        public AspectoSalud_M()
        {
        }

        public AspectoSalud_M(DETASPS_Result aspecto)
        {
            if (aspecto != null)
            {
                this.CODASPS16 = aspecto.CODASPS16;
                this.DESENFR16 = aspecto.DESENFR16;
                this.RECTRAT16 = aspecto.RECTRAT16;
                this.DESTRAT16 = aspecto.DESTRAT16;
                this.DESENFR15 = aspecto.DESENFR15;
                this.DESSEGU14 = aspecto.DESSEGU14;
            }
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