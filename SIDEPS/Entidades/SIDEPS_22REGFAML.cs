//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class SIDEPS_22REGFAML
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SIDEPS_22REGFAML()
        {
            this.SIDEPS_23CATFINA = new HashSet<SIDEPS_23CATFINA>();
        }
    
        public string CEDFAML22 { get; set; }
        public string NOMFAML22 { get; set; }
        public Nullable<int> EDAFAML22 { get; set; }
        public Nullable<int> CODESTC06 { get; set; }
        public Nullable<int> CODNEDU09 { get; set; }
        public string OACFAML22 { get; set; }
        public Nullable<decimal> INGFAML22 { get; set; }
        public string DESFAML22 { get; set; }
        public Nullable<int> CODORGS21 { get; set; }
        public Nullable<int> CODENFR15 { get; set; }
        public Nullable<int> CODPARE12 { get; set; }
    
        public virtual SIDEPS_06CATESTC SIDEPS_06CATESTC { get; set; }
        public virtual SIDEPS_09CATNEDU SIDEPS_09CATNEDU { get; set; }
        public virtual SIDEPS_12CATPARE SIDEPS_12CATPARE { get; set; }
        public virtual SIDEPS_15CATENFR SIDEPS_15CATENFR { get; set; }
        public virtual SIDEPS_21CATORGS SIDEPS_21CATORGS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SIDEPS_23CATFINA> SIDEPS_23CATFINA { get; set; }
    }
}
