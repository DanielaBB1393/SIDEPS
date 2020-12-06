using SIDEPS.ServiciosWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SIDEPS.Models
{
    public class MiembroFamiliar_M
    {
        [DisplayName("Cédula")]
        public string CEDFAML22 { get; set; }

        [DisplayName("Nombre")]
        public string NOMFAML22 { get; set; }

        [DisplayName("Edad")]
        public Nullable<int> EDAFAML22 { get; set; }

        [DisplayName("Estado Civil")]
        public Nullable<int> CODESTC06 { get; set; }

        [DisplayName("Escolaridad")]
        public Nullable<int> CODNEDU09 { get; set; }

        [DisplayName("Ocupación actual")]
        public string OACFAML22 { get; set; }

        [DisplayName("Ingreso económico")]
        public Nullable<decimal> INGFAML22 { get; set; }

        [DisplayName("Descripción del familiar")]
        public string DESFAML22 { get; set; }

        [DisplayName("Estado Civil")]
        public string DESESTC06 { get; set; }

        [DisplayName("Escolaridad")]
        public string DESNEDU09 { get; set; }

        [DisplayName("Organización")]
        public string DESORGS21 { get; set; }

        [DisplayName("Enfermedad")]
        public string DESENFR15 { get; set; }

        [DisplayName("Parentesco")]
        public string DESPARE12 { get; set; }

        [DisplayName("Solicitante")]
        public string CEDPERS13 { get; set; }

        [DisplayName("Organización")]
        public Nullable<int> CODORGS21 { get; set; }

        [DisplayName("Enfermedad")]
        public Nullable<int> CODENFR15 { get; set; }

        [DisplayName("Parentesco")]
        public Nullable<int> CODPARE12 { get; set; }

        public List<Categoria> EstadosCiviles { get; set; }
        public List<Categoria> Escolaridad { get; set; }
        public List<Categoria> Organizaciones { get; set; }
        public List<Categoria> Enfermedades { get; set; }
        public List<Categoria> Parentescos { get; set; }

        public MiembroFamiliar_M()
        {
        }

        public MiembroFamiliar_M(SIDEPS_22REGFAML familiar)
        {
            this.CEDFAML22 = familiar.CEDFAML22;
            this.NOMFAML22 = familiar.NOMFAML22;
            this.EDAFAML22 = familiar.EDAFAML22;
            this.CODESTC06 = familiar.CODESTC06;
            this.CODNEDU09 = familiar.CODNEDU09;
            this.OACFAML22 = familiar.OACFAML22;
            this.INGFAML22 = familiar.INGFAML22;
            this.DESFAML22 = familiar.DESFAML22;
            this.CODORGS21 = familiar.CODORGS21;
            this.CODENFR15 = familiar.CODENFR15;
            this.CODPARE12 = familiar.CODPARE12;
        }

        public MiembroFamiliar_M(SP_CON_REGFAML_Result familiar)
        {
            this.CEDFAML22 = familiar.CEDFAML22;
            this.NOMFAML22 = familiar.NOMFAML22;
            this.EDAFAML22 = familiar.EDAFAML22;
            this.CODESTC06 = familiar.CODESTC06;
            this.CODNEDU09 = familiar.CODNEDU09;
            this.OACFAML22 = familiar.OACFAML22;
            this.INGFAML22 = familiar.INGFAML22;
            this.DESFAML22 = familiar.DESFAML22;
            this.CODORGS21 = familiar.CODORGS21;
            this.CODENFR15 = familiar.CODENFR15;
            this.CODPARE12 = familiar.CODPARE12;
        }

        public MiembroFamiliar_M(SP_CONXID_REGFAML_Result familiar)
        {
            this.CEDFAML22 = familiar.CEDFAML22;
            this.NOMFAML22 = familiar.NOMFAML22;
            this.EDAFAML22 = familiar.EDAFAML22;
            this.CODESTC06 = familiar.CODESTC06;
            this.CODNEDU09 = familiar.CODNEDU09;
            this.OACFAML22 = familiar.OACFAML22;
            this.INGFAML22 = familiar.INGFAML22;
            this.DESFAML22 = familiar.DESFAML22;
            this.CODORGS21 = familiar.CODORGS21;
            this.CODENFR15 = familiar.CODENFR15;
            this.CODPARE12 = familiar.CODPARE12;
        }

        public MiembroFamiliar_M(DETFAML_Result familiar)
        {
            this.CEDFAML22 = familiar.CEDFAML22;
            this.NOMFAML22 = familiar.NOMFAML22;
            this.EDAFAML22 = familiar.EDAFAML22;
            this.OACFAML22 = familiar.OACFAML22;
            this.INGFAML22 = familiar.INGFAML22;
            this.DESFAML22 = familiar.DESFAML22;
            this.DESESTC06 = familiar.DESESTC06;
            this.DESNEDU09 = familiar.DESNEDU09;
            this.DESORGS21 = familiar.DESORGS21;
            this.DESENFR15 = familiar.DESENFR15;
            this.DESPARE12 = familiar.DESPARE12;
            this.CEDPERS13 = familiar.CEDPERS13;
        }

        public SIDEPS_22REGFAML ConvertirEntidad()
        {
            return new SIDEPS_22REGFAML
            {
                CEDFAML22 = this.CEDFAML22,
                NOMFAML22 = this.NOMFAML22,
                EDAFAML22 = this.EDAFAML22,
                CODESTC06 = this.CODESTC06,
                CODNEDU09 = this.CODNEDU09,
                OACFAML22 = this.OACFAML22,
                INGFAML22 = this.INGFAML22,
                DESFAML22 = this.DESFAML22,
                CODORGS21 = this.CODORGS21,
                CODENFR15 = this.CODENFR15,
                CODPARE12 = this.CODPARE12,
            };
        }
    }
}