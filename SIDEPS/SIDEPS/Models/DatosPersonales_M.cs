using SIDEPS.ServiciosWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SIDEPS.Models
{
    public class DatosPersonales_M
    {

        [Required(ErrorMessage = "La cedula es Requerida.")]
        [DisplayName("Cédula")]
        public string CEDPERS13 { get; set; }

        [DisplayName("Estado Civil")]
        public Nullable<int> CODESTC06 { get; set; }

        [DisplayName("Escolaridad")]
        public Nullable<int> CODNEDU09 { get; set; }

        [DisplayName("Cantón")]
        public Nullable<int> CODCANT03 { get; set; }

        [DisplayName("Solicitud")]
        public Nullable<int> CODSOLI10 { get; set; }

        [DisplayName("Religión")]
        public Nullable<int> CODRELG11 { get; set; }

        [Required(ErrorMessage = "El Nombre es Requerido.")]

        [DisplayName("Nombre")]
        public string NOMPERS13 { get; set; }

        [Required(ErrorMessage = "El Primer Apellido es Requerido.")]

        [DisplayName("Primer Apellido")]
        public string PAPPERS13 { get; set; }
        [Required(ErrorMessage = "El Segundo Apellido es Requerido.")]

        [DisplayName("Segundo Apellido")]
        public string SAPPERS13 { get; set; }
        [Required(ErrorMessage = "La nacionalidad es Requerida.")]

        [DisplayName("Nacionalidad")]
        public string NACPERS13 { get; set; }
        [Required(ErrorMessage = "La Direccion es Requerida.")]

        [DisplayName("Dirección")]
        public string DIRPERS13 { get; set; }
        [Required(ErrorMessage = "La Ocupación Actual es Requerida.")]
        [DisplayName("Ocupación Actual")]
        public string OACPERS13 { get; set; }

        [DisplayName("Ocupación Anterior")]
        public string OANPERS13 { get; set; }

        [DisplayName("Estado Civil")]
        public string DESESTC06 { get; set; }

        [DisplayName("Cantón")]
        public string NOMCANT03 { get; set; }

        [DisplayName("Solicitud")]
        public string DESSOLI10 { get; set; }

        [DisplayName("Religión")]
        public string DESRELG11 { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Nacimiento")]
        public Nullable<System.DateTime> FENPERS13 { get; set; }

        public List<Categoria> Religiones { get; set; }
        public List<Categoria> Cantones { get; set; }
        public List<Categoria> EstadosCiviles { get; set; }
        public List<Categoria> Escolaridades { get; set; }
        public List<Categoria> CategoriaSolicitante { get; set; }

        public DatosPersonales_M()
        {
        }

        public DatosPersonales_M(SIDEPS_13REGPERS persona)
        {
            this.CEDPERS13 = persona.CEDPERS13;
            this.CODESTC06 = persona.CODESTC06;
            this.CODNEDU09 = persona.CODNEDU09;
            this.CODCANT03 = persona.CODCANT03;
            this.CODSOLI10 = persona.CODSOLI10;
            this.CODRELG11 = persona.CODRELG11;
            this.NOMPERS13 = persona.NOMPERS13;
            this.PAPPERS13 = persona.PAPPERS13;
            this.SAPPERS13 = persona.SAPPERS13;
            this.NACPERS13 = persona.NACPERS13;
            this.DIRPERS13 = persona.DIRPERS13;
            this.OACPERS13 = persona.OACPERS13;
            this.OANPERS13 = persona.OANPERS13;
            this.FENPERS13 = persona.FENPERS13;
        }

        public DatosPersonales_M(DETPERS_Result persona)
        {
            this.CEDPERS13 = persona.CEDPERS13;
            this.NOMPERS13 = persona.NOMPERS13;
            this.PAPPERS13 = persona.PAPPERS13;
            this.SAPPERS13 = persona.SAPPERS13;
            this.DESESTC06 = persona.DESESTC06;
            this.NOMCANT03 = persona.NOMCANT03;
            this.DESSOLI10 = persona.DESSOLI10;
            this.DESRELG11 = persona.DESRELG11;
            this.NACPERS13 = persona.NACPERS13;
            this.DIRPERS13 = persona.DIRPERS13;
            this.OACPERS13 = persona.OACPERS13;
            this.OANPERS13 = persona.OANPERS13;
            this.FENPERS13 = persona.FENPERS13;
        }

        public SIDEPS_13REGPERS ConvertirEntidad()
        {
            return new SIDEPS_13REGPERS
            {
                CEDPERS13 = this.CEDPERS13,
                CODESTC06 = this.CODESTC06,
                CODNEDU09 = this.CODNEDU09,
                CODCANT03 = this.CODCANT03,
                CODSOLI10 = this.CODSOLI10,
                CODRELG11 = this.CODRELG11,
                NOMPERS13 = this.NOMPERS13,
                PAPPERS13 = this.PAPPERS13,
                SAPPERS13 = this.SAPPERS13,
                NACPERS13 = this.NACPERS13,
                DIRPERS13 = this.DIRPERS13,
                OACPERS13 = this.OACPERS13,
                OANPERS13 = this.OANPERS13,
                FENPERS13 = this.FENPERS13,
        };
        }
    }
}