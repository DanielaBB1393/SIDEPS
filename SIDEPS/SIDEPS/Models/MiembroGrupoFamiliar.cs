using System;
using System.ComponentModel;

namespace SIDEPS.Models
{
    public class MiembroGrupoFamiliar
    {
        [DisplayName("Cédula")]
        public string CEDFAML22 { get; set; }
        [DisplayName("Nombre")]
        public string NOMFAML22 { get; set; }
        [DisplayName("Edad")]
        public Nullable<int> EDAFAML22 { get; set; }
        [DisplayName("Estado Civil")]
        public Nullable<int> CODESTC06 { get; set; }
        [DisplayName("Nivel Educativo")]
        public Nullable<int> CODNEDU09 { get; set; }
        [DisplayName("Ocupación actual")]
        public string OACFAML22 { get; set; }
        [DisplayName("Ingreso económico")]
        public Nullable<decimal> INGFAML22 { get; set; }
        [DisplayName("Descripción del familiar")]
        public string DESFAML22 { get; set; }
        [DisplayName("Organización")]
        public Nullable<int> CODORGS21 { get; set; }
        [DisplayName("Enfermedad")]
        public Nullable<int> CODENFR15 { get; set; }
        [DisplayName("Parentesco")]
        public Nullable<int> CODPARE12 { get; set; }
    }
}