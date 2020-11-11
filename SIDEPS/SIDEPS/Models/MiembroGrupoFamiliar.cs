using System;
using System.ComponentModel;

namespace SIDEPS.Models
{
    public class MiembroGrupoFamiliar
    {
        [DisplayName("Cedula")]
        public string CEDFAML22 { get; set; }
        [DisplayName("Nombre")]
        public string NOMFAML22 { get; set; }
        [DisplayName("Edad")]
        public Nullable<int> EDAFAML22 { get; set; }
        [DisplayName("Estado Civil")]
        public Nullable<int> CODESTC06 { get; set; }
        [DisplayName("Nivel Educacion")]
        public Nullable<int> CODNEDU09 { get; set; }
        [DisplayName("OACFAML22")]
        public string OACFAML22 { get; set; }
        [DisplayName("Ingresos")]
        public Nullable<decimal> INGFAML22 { get; set; }
        [DisplayName("Descripcion")]
        public string DESFAML22 { get; set; }
        [DisplayName("CODORGS21")]
        public Nullable<int> CODORGS21 { get; set; }
        [DisplayName("Enfermedad")]
        public Nullable<int> CODENFR15 { get; set; }
        [DisplayName("Parentesco")]
        public Nullable<int> CODPARE12 { get; set; }
    }
}