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
    
    public partial class SIDEPS_20REGVIVI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SIDEPS_20REGVIVI()
        {
            this.SIDEPS_25REGCASO = new HashSet<SIDEPS_25REGCASO>();
        }
    
        public int CODVIVI20 { get; set; }
        public Nullable<int> CODTIPV18 { get; set; }
        public Nullable<int> CODESTV19 { get; set; }
        public Nullable<int> CODMATE17 { get; set; }
        public Nullable<decimal> MTOVIVI20 { get; set; }
        public Nullable<int> NAPVIVI20 { get; set; }
        public Nullable<bool> SRCVIVI20 { get; set; }
        public Nullable<bool> SRIVIVI20 { get; set; }
        public Nullable<bool> SRLVIVI20 { get; set; }
        public Nullable<bool> SRMVIVI20 { get; set; }
        public Nullable<bool> SRBVIVI20 { get; set; }
        public Nullable<bool> SREVIVI20 { get; set; }
    
        public virtual SIDEPS_17CATMATE SIDEPS_17CATMATE { get; set; }
        public virtual SIDEPS_18TIPVIVI SIDEPS_18TIPVIVI { get; set; }
        public virtual SIDEPS_19ESTVIVI SIDEPS_19ESTVIVI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SIDEPS_25REGCASO> SIDEPS_25REGCASO { get; set; }
    }
}
