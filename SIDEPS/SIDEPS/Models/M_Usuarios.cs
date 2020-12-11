using SIDEPS.ServiciosWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIDEPS.Models
{
    public class M_Usuarios
    {
        [Required(ErrorMessage = "La Cédula es Requerida.")]
        [Display(Name = "Cédula")]
        public string CEDUSRO07 { get; set; }

        [Required(ErrorMessage = "El Nombre es Requerido.")]
        [Display(Name = "Nombre")]
        public string NOMUSRO07 { get; set; }

        [Required(ErrorMessage = "El Apellido es Requerido.")]
        [Display(Name = "Apellido 1")]
        [MaxLength(60, ErrorMessage = "El Apellido  debe ser menor o igual a 60 caracteres")]
        [MinLength(3, ErrorMessage = "El Apellido debe ser mayor o igual a 3 caracteres")]
        public string PAPUSRO07 { get; set; }

        [Required(ErrorMessage = "El Apellido es Requerido.")]
        [Display(Name = "Apellido 2")]
        [MaxLength(60, ErrorMessage = "El Apellido  debe ser menor o igual a 60 caracteres")]
        [MinLength(3, ErrorMessage = "El Apellido debe ser mayor o igual a 3 caracteres")]
        public string SAPUSRO07 { get; set; }

        [Required(ErrorMessage = "Número de Cantón Requerido.")]
        [Display(Name = "Cantón")]
        public Nullable<int> CODCANT03 { get; set; }

        [Required(ErrorMessage = "Número de Diaconia Requerido.")]
        [Display(Name = "Diaconia")]
        public Nullable<int> CODDIAC04 { get; set; }

        [Required(ErrorMessage = "Rol del Usuario Requerido.")]
        [Display(Name = "Rol")]
        public Nullable<int> CODUSRO05 { get; set; }

        [Required(ErrorMessage = "Estado de Usuario Requerido.")]
        [Display(Name = "Estado")]
        public string ESTUSRO07 { get; set; }

        [Required(ErrorMessage = "Direccion de Usuario Requerido.")]
        [Display(Name = "Dirección")]
        public string DIRUSRO07 { get; set; }

        [Required(ErrorMessage = "Nacionalidad del Usuario Requerido.")]
        [Display(Name = "Nacionalidad")]
        public string NACUSRO07 { get; set; }

        [Required(ErrorMessage = "Contraseña del Usuario Requerido.")]
        [Display(Name = "Contraseña")]
        public string CNTUSRO07 { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Ingreso")]
        public Nullable<System.DateTime> FEIUSRO07 { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Salida")]
        public Nullable<System.DateTime> FEFUSRO07 { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Nacimiento")]
        public Nullable<System.DateTime> FENUSRO07 { get; set; }

        public List<Categoria> Cantones { get; set; }
        public List<Categoria> Diaconias { get; set; }
        public List<Categoria> Roles { get; set; }

        public SIDEPS_07REGUSRO ConvertirEntidad()
        {
            return new SIDEPS_07REGUSRO
            {
                CEDUSRO07 = this.CEDUSRO07,
                NOMUSRO07 = this.NOMUSRO07,
                PAPUSRO07 = this.PAPUSRO07,
                SAPUSRO07 = this.SAPUSRO07,
                CODCANT03 = this.CODCANT03,
                CODDIAC04 = this.CODDIAC04,
                CODUSRO05 = this.CODUSRO05,
                ESTUSRO07 = this.ESTUSRO07,
                DIRUSRO07 = this.DIRUSRO07,
                NACUSRO07 = this.NACUSRO07,
                CNTUSRO07 = this.CNTUSRO07,
                FEIUSRO07 = this.FEIUSRO07,
                FEFUSRO07 = this.FEFUSRO07,
                FENUSRO07 = this.FENUSRO07,
            };
        }
    }
}