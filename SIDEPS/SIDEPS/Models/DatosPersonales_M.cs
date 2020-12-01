using SIDEPS.ServiciosWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SIDEPS.Models
{
    public class DatosPersonales_M
    {
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
        [DisplayName("Nombre")]
        public string NOMPERS13 { get; set; }
        [DisplayName("Primer Apellido")]
        public string PAPPERS13 { get; set; }
        [DisplayName("Segundo Apellido")]
        public string SAPPERS13 { get; set; }
        [DisplayName("Nacionalidad")]
        public string NACPERS13 { get; set; }
        [DisplayName("Dirección")]
        public string DIRPERS13 { get; set; }
        [DisplayName("Opinion 1")]
        public string OACPERS13 { get; set; }
        [DisplayName("Opinion 2")]
        public string OANPERS13 { get; set; }

        public List<Categoria> Religiones { get; set; } = new List<Categoria>();
        public List<Categoria> Cantones { get; set; } = new List<Categoria>();
        public List<Categoria> EstadosCiviles { get; set; } = new List<Categoria>();

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
            };
        }
    }
}