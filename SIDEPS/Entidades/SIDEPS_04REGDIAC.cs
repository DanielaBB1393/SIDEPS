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
    
    public partial class SIDEPS_04REGDIAC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SIDEPS_04REGDIAC()
        {
            this.SIDEPS_07REGUSRO = new HashSet<SIDEPS_07REGUSRO>();
        }
    
        public int CODDIAC04 { get; set; }
        public string NOMDIAC04 { get; set; }
        public string LUGDIAC04 { get; set; }
        public string TELDIAC04 { get; set; }
        public string ESTDIAC04 { get; set; }
        public Nullable<int> CODCANT03 { get; set; }
    
        public virtual SIDEPS_03CATCANT SIDEPS_03CATCANT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SIDEPS_07REGUSRO> SIDEPS_07REGUSRO { get; set; }
    }
}
