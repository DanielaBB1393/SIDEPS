using System;
using System.ComponentModel.DataAnnotations;

namespace SIDEPS.Models
{
    public class Diaconia_M
    {
        [Display(Name = "Codigo de Diaconia")]
        public int CODDIAC04 { get; set; }

        [Required(ErrorMessage = "El Nombre es Requerido.")]
        [Display(Name = "Nombre")]
        [MaxLength(60, ErrorMessage = "El nombre debe ser menor o igual a 60 caracteres")]
        [MinLength(3, ErrorMessage = "El nombre debe ser mayor o igual a 3 caracteres")]
        public string NOMDIAC04 { get; set; }

        [Required(ErrorMessage = "El lugar es Requerido.")]
        [Display(Name = "Lugar de ubicacion")]
        [MaxLength(60, ErrorMessage = "El nombre del lugar debe ser menor o igual a 60 caracteres")]
        [MinLength(3, ErrorMessage = "El nombre del lugar debe ser mayor o igual a 3 caracteres")]
        public string LUGDIAC04 { get; set; }

        [Required(ErrorMessage = "Telefono de Diaconia Requerido.")]
        [Display(Name = "Numero de Diaconia")]
        public string TELDIAC04 { get; set; }

        [Display(Name = "Estado")]
        public string ESTDIAC04 { get; set; }

        [Required(ErrorMessage = "Numero de Canton Requerido.")]
        [Display(Name = "Numero de Canton")]
        public Nullable<int> CODCANT03 { get; set; }
    }
}