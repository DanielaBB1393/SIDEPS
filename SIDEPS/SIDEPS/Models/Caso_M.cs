using SIDEPS.WCFServices;
using System;
using System.Collections.Generic;

namespace SIDEPS.Models
{
    public class Caso_M
    {
        public Caso_M(SIDEPS_25REGCASO caso)
        {
            this.CODCASO25 = caso.CODCASO25;
            this.CEDPERS13 = caso.CEDPERS13;
            this.CODASPS16 = caso.CODASPS16;
            this.CEDUSRO07 = caso.CEDUSRO07;
            this.CODVIVI20 = caso.CODVIVI20;
            this.CODEGRF24 = caso.CODEGRF24;
            this.FEICASO25 = caso.FEICASO25;
            this.FEFCASO25 = caso.FEFCASO25;
            this.DESCASO25 = caso.DESCASO25;
            this.OPICASO25 = caso.OPICASO25;
            this.ESTCASO25 = caso.ESTCASO25;
            this.SIDEPS_07REGUSRO = caso.SIDEPS_07REGUSRO;
            this.SIDEPS_13REGPERS = caso.SIDEPS_13REGPERS;
            this.SIDEPS_16REGASPS = caso.SIDEPS_16REGASPS;
            this.SIDEPS_20REGVIVI = caso.SIDEPS_20REGVIVI;
            this.SIDEPS_24REGEGRF = caso.SIDEPS_24REGEGRF;
            this.SIDEPS_27TIPAYUD = caso.SIDEPS_27TIPAYUD;
            this.SIDEPS_28REGHIS = caso.SIDEPS_28REGHIS;
        }

        public int CODCASO25 { get; set; }
        public string CEDPERS13 { get; set; }
        public Nullable<int> CODASPS16 { get; set; }
        public string CEDUSRO07 { get; set; }
        public Nullable<int> CODVIVI20 { get; set; }
        public Nullable<int> CODEGRF24 { get; set; }
        public Nullable<DateTime> FEICASO25 { get; set; }
        public Nullable<DateTime> FEFCASO25 { get; set; }
        public string DESCASO25 { get; set; }
        public string OPICASO25 { get; set; }
        public string ESTCASO25 { get; set; }
        public virtual SIDEPS_07REGUSRO SIDEPS_07REGUSRO { get; set; }
        public virtual SIDEPS_13REGPERS SIDEPS_13REGPERS { get; set; }
        public virtual SIDEPS_16REGASPS SIDEPS_16REGASPS { get; set; }
        public virtual SIDEPS_20REGVIVI SIDEPS_20REGVIVI { get; set; }
        public virtual SIDEPS_24REGEGRF SIDEPS_24REGEGRF { get; set; }
        public virtual ICollection<SIDEPS_27TIPAYUD> SIDEPS_27TIPAYUD { get; set; }
        public virtual ICollection<SIDEPS_28REGHIS> SIDEPS_28REGHIS { get; set; }
    }
}