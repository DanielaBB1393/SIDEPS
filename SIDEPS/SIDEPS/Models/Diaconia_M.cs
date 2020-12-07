using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIDEPS.Models
{
    public class Diaconia_M
    {
        [Display(Name = "Código")]
        public int CODDIAC04 { get; set; }

        [Required(ErrorMessage = "El Nombre es Requerido.")]
        [Display(Name = "Nombre")]
        [MaxLength(60, ErrorMessage = "El nombre debe ser menor o igual a 60 caracteres")]
        [MinLength(3, ErrorMessage = "El nombre debe ser mayor o igual a 3 caracteres")]
        public string NOMDIAC04 { get; set; }

        [Required(ErrorMessage = "El lugar es Requerido.")]
        [Display(Name = "Dirección")]
        [MaxLength(60, ErrorMessage = "El nombre del lugar debe ser menor o igual a 60 caracteres")]
        [MinLength(3, ErrorMessage = "El nombre del lugar debe ser mayor o igual a 3 caracteres")]
        public string LUGDIAC04 { get; set; }

        [Required(ErrorMessage = "Teléfono de Diaconia Requerido.")]
        [Display(Name = "Teléfono")]
        public string TELDIAC04 { get; set; }

        [Display(Name = "Estado")]
        public string ESTDIAC04 { get; set; }

        [Required(ErrorMessage = "Cantón Requerido.")]
        [Display(Name = "Cantón")]
        public Nullable<int> CODCANT03 { get; set; }
        public List<Categoria> Cantones { get; set; }
    }
}