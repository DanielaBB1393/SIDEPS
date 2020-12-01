using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIDEPS.Models
{
    public class M_Usuarios
    {
        [Display(Name = "Cedula de Usuario")]
        public string CEDUSRO07 { get; set; }

        [Required(ErrorMessage = "El Nombre es Requerido.")]
        [Display(Name = "Nombre")]
        [MaxLength(60, ErrorMessage = "El nombre debe ser menor o igual a 60 caracteres")]
        [MinLength(3, ErrorMessage = "El nombre debe ser mayor o igual a 3 caracteres")]
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

        [Required(ErrorMessage = "Numero de Canton Requerido.")]
        [Display(Name = "Numero de Canton")]
        public Nullable<int> CODCANT03 { get; set; }

        [Required(ErrorMessage = "Numero de Diaconia Requerido.")]
        [Display(Name = "Numero de Diaconia")]
        public Nullable<int> CODDIAC04 { get; set; }

        [Required(ErrorMessage = "Rol del Usuario Requerido.")]
        [Display(Name = "Rol del Usuario")]
        public Nullable<int> CODUSRO05 { get; set; }

        [Required(ErrorMessage = "Estado de Usuario Requerido.")]
        [Display(Name = "Estado de Usuario")]
        public string ESTUSRO07 { get; set; }

        [Required(ErrorMessage = "Direccion de Usuario Requerido.")]
        [Display(Name = "Direccion de Usuario")]
        public string DIRUSRO07 { get; set; }

        [Required(ErrorMessage = "Nacionalidad del Usuario Requerido.")]
        [Display(Name = "Nacionalidad del Usuario")]
        public string NACUSRO07 { get; set; }

        [Required(ErrorMessage = "Contraseña del Usuario Requerido.")]
        [Display(Name = "Contraseña del Usuario")]
        public string CNTUSRO07 { get; set; }

        [Required(ErrorMessage = "Fecha de Inicio del Usuario Requerido.")]
        [Display(Name = "Fecha de Ingreso del Usuario")]
        public Nullable<System.DateTime> FEIUSRO07 { get; set; }

        [Required(ErrorMessage = "Fecha de Salida del Usuario Requerido.")]
        [Display(Name = "Fecha de Salida del Usuario")]
        public Nullable<System.DateTime> FEFUSRO07 { get; set; }

        [Required(ErrorMessage = "Fecha de Nacimiento del Usuario Requerido.")]
        [Display(Name = "Fecha de Nacimiento del Usuario")]
        public Nullable<System.DateTime> FENUSRO07 { get; set; }

        public List<Categoria> Cantones { get; set; } = new List<Categoria>();
        public List<Categoria> Diaconias { get; set; } = new List<Categoria>();
    }
}