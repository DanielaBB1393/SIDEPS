﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using Entidades;

    public partial class SIDEPSEntities : DbContext
    {
        public SIDEPSEntities()
            : base("name=SIDEPSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SIDEPS_01CATPAIS> SIDEPS_01CATPAIS { get; set; }
        public virtual DbSet<SIDEPS_02CATPROV> SIDEPS_02CATPROV { get; set; }
        public virtual DbSet<SIDEPS_03CATCANT> SIDEPS_03CATCANT { get; set; }
        public virtual DbSet<SIDEPS_04REGDIAC> SIDEPS_04REGDIAC { get; set; }
        public virtual DbSet<SIDEPS_05TIPUSRO> SIDEPS_05TIPUSRO { get; set; }
        public virtual DbSet<SIDEPS_06CATESTC> SIDEPS_06CATESTC { get; set; }
        public virtual DbSet<SIDEPS_07REGUSRO> SIDEPS_07REGUSRO { get; set; }
        public virtual DbSet<SIDEPS_08REGTELF> SIDEPS_08REGTELF { get; set; }
        public virtual DbSet<SIDEPS_09CATNEDU> SIDEPS_09CATNEDU { get; set; }
        public virtual DbSet<SIDEPS_10CATSOLI> SIDEPS_10CATSOLI { get; set; }
        public virtual DbSet<SIDEPS_11CATRELG> SIDEPS_11CATRELG { get; set; }
        public virtual DbSet<SIDEPS_12CATPARE> SIDEPS_12CATPARE { get; set; }
        public virtual DbSet<SIDEPS_13REGPERS> SIDEPS_13REGPERS { get; set; }
        public virtual DbSet<SIDEPS_14CATSEGU> SIDEPS_14CATSEGU { get; set; }
        public virtual DbSet<SIDEPS_15CATENFR> SIDEPS_15CATENFR { get; set; }
        public virtual DbSet<SIDEPS_16REGASPS> SIDEPS_16REGASPS { get; set; }
        public virtual DbSet<SIDEPS_17CATMATE> SIDEPS_17CATMATE { get; set; }
        public virtual DbSet<SIDEPS_18TIPVIVI> SIDEPS_18TIPVIVI { get; set; }
        public virtual DbSet<SIDEPS_19ESTVIVI> SIDEPS_19ESTVIVI { get; set; }
        public virtual DbSet<SIDEPS_20REGVIVI> SIDEPS_20REGVIVI { get; set; }
        public virtual DbSet<SIDEPS_21CATORGS> SIDEPS_21CATORGS { get; set; }
        public virtual DbSet<SIDEPS_22REGFAML> SIDEPS_22REGFAML { get; set; }
        public virtual DbSet<SIDEPS_23CATFINA> SIDEPS_23CATFINA { get; set; }
        public virtual DbSet<SIDEPS_24REGEGRF> SIDEPS_24REGEGRF { get; set; }
        public virtual DbSet<SIDEPS_25REGCASO> SIDEPS_25REGCASO { get; set; }
        public virtual DbSet<SIDEPS_26CATAYUD> SIDEPS_26CATAYUD { get; set; }
        public virtual DbSet<SIDEPS_27TIPAYUD> SIDEPS_27TIPAYUD { get; set; }
        public virtual DbSet<SIDEPS_28REGHIS> SIDEPS_28REGHIS { get; set; }
        public virtual DbSet<SIDEPS_29REGCNTR> SIDEPS_29REGCNTR { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual ObjectResult<SP_CON_CATCANT_Result> SP_CON_CATCANT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CON_CATCANT_Result>("SP_CON_CATCANT");
        }
    
        public virtual ObjectResult<SP_CON_CATESTC_Result> SP_CON_CATESTC()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CON_CATESTC_Result>("SP_CON_CATESTC");
        }
    
        public virtual ObjectResult<SP_CON_CATNEDU_Result> SP_CON_CATNEDU()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CON_CATNEDU_Result>("SP_CON_CATNEDU");
        }
    
        public virtual ObjectResult<SP_CON_CATRELG_Result> SP_CON_CATRELG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CON_CATRELG_Result>("SP_CON_CATRELG");
        }
    
        public virtual ObjectResult<SP_CON_REGDIAC_Result> SP_CON_REGDIAC()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CON_REGDIAC_Result>("SP_CON_REGDIAC");
        }
    
        public virtual ObjectResult<SP_CON_REGUSRO_Result> SP_CON_REGUSRO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CON_REGUSRO_Result>("SP_CON_REGUSRO");
        }
    
        public virtual ObjectResult<SP_CONXID_REGDIAC_Result> SP_CONXID_REGDIAC(Nullable<int> cODDIAC04)
        {
            var cODDIAC04Parameter = cODDIAC04.HasValue ?
                new ObjectParameter("CODDIAC04", cODDIAC04) :
                new ObjectParameter("CODDIAC04", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CONXID_REGDIAC_Result>("SP_CONXID_REGDIAC", cODDIAC04Parameter);
        }
    
        public virtual ObjectResult<SP_CONXID_REGUSRO_Result> SP_CONXID_REGUSRO(Nullable<int> cEDUSRO07)
        {
            var cEDUSRO07Parameter = cEDUSRO07.HasValue ?
                new ObjectParameter("CEDUSRO07", cEDUSRO07) :
                new ObjectParameter("CEDUSRO07", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CONXID_REGUSRO_Result>("SP_CONXID_REGUSRO", cEDUSRO07Parameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int SP_DEL_REGDIAC(Nullable<int> cODDIAC04)
        {
            var cODDIAC04Parameter = cODDIAC04.HasValue ?
                new ObjectParameter("CODDIAC04", cODDIAC04) :
                new ObjectParameter("CODDIAC04", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DEL_REGDIAC", cODDIAC04Parameter);
        }
    
        public virtual int SP_DEL_REGUSRO(string cEDUSRO07)
        {
            var cEDUSRO07Parameter = cEDUSRO07 != null ?
                new ObjectParameter("CEDUSRO07", cEDUSRO07) :
                new ObjectParameter("CEDUSRO07", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DEL_REGUSRO", cEDUSRO07Parameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int SP_INS_REGASPS(string cEDPERS13, Nullable<int> cODSEGU14, Nullable<int> cODENFR15, string dESENFR16, string rECTRAT16, string dESTRAT16)
        {
            var cEDPERS13Parameter = cEDPERS13 != null ?
                new ObjectParameter("CEDPERS13", cEDPERS13) :
                new ObjectParameter("CEDPERS13", typeof(string));
    
            var cODSEGU14Parameter = cODSEGU14.HasValue ?
                new ObjectParameter("CODSEGU14", cODSEGU14) :
                new ObjectParameter("CODSEGU14", typeof(int));
    
            var cODENFR15Parameter = cODENFR15.HasValue ?
                new ObjectParameter("CODENFR15", cODENFR15) :
                new ObjectParameter("CODENFR15", typeof(int));
    
            var dESENFR16Parameter = dESENFR16 != null ?
                new ObjectParameter("DESENFR16", dESENFR16) :
                new ObjectParameter("DESENFR16", typeof(string));
    
            var rECTRAT16Parameter = rECTRAT16 != null ?
                new ObjectParameter("RECTRAT16", rECTRAT16) :
                new ObjectParameter("RECTRAT16", typeof(string));
    
            var dESTRAT16Parameter = dESTRAT16 != null ?
                new ObjectParameter("DESTRAT16", dESTRAT16) :
                new ObjectParameter("DESTRAT16", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INS_REGASPS", cEDPERS13Parameter, cODSEGU14Parameter, cODENFR15Parameter, dESENFR16Parameter, rECTRAT16Parameter, dESTRAT16Parameter);
        }
    
        public virtual int SP_INS_REGCASO(string cEDPERS13, Nullable<int> cODASPS16, string cEDUSRO07, Nullable<int> cODVIVI20, Nullable<int> cODEGRF24, Nullable<System.DateTime> fEICASO25, Nullable<System.DateTime> fEFCASO25, string dESCASO25, string oPICASO25, string eSTCASO25)
        {
            var cEDPERS13Parameter = cEDPERS13 != null ?
                new ObjectParameter("CEDPERS13", cEDPERS13) :
                new ObjectParameter("CEDPERS13", typeof(string));
    
            var cODASPS16Parameter = cODASPS16.HasValue ?
                new ObjectParameter("CODASPS16", cODASPS16) :
                new ObjectParameter("CODASPS16", typeof(int));
    
            var cEDUSRO07Parameter = cEDUSRO07 != null ?
                new ObjectParameter("CEDUSRO07", cEDUSRO07) :
                new ObjectParameter("CEDUSRO07", typeof(string));
    
            var cODVIVI20Parameter = cODVIVI20.HasValue ?
                new ObjectParameter("CODVIVI20", cODVIVI20) :
                new ObjectParameter("CODVIVI20", typeof(int));
    
            var cODEGRF24Parameter = cODEGRF24.HasValue ?
                new ObjectParameter("CODEGRF24", cODEGRF24) :
                new ObjectParameter("CODEGRF24", typeof(int));
    
            var fEICASO25Parameter = fEICASO25.HasValue ?
                new ObjectParameter("FEICASO25", fEICASO25) :
                new ObjectParameter("FEICASO25", typeof(System.DateTime));
    
            var fEFCASO25Parameter = fEFCASO25.HasValue ?
                new ObjectParameter("FEFCASO25", fEFCASO25) :
                new ObjectParameter("FEFCASO25", typeof(System.DateTime));
    
            var dESCASO25Parameter = dESCASO25 != null ?
                new ObjectParameter("DESCASO25", dESCASO25) :
                new ObjectParameter("DESCASO25", typeof(string));
    
            var oPICASO25Parameter = oPICASO25 != null ?
                new ObjectParameter("OPICASO25", oPICASO25) :
                new ObjectParameter("OPICASO25", typeof(string));
    
            var eSTCASO25Parameter = eSTCASO25 != null ?
                new ObjectParameter("ESTCASO25", eSTCASO25) :
                new ObjectParameter("ESTCASO25", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INS_REGCASO", cEDPERS13Parameter, cODASPS16Parameter, cEDUSRO07Parameter, cODVIVI20Parameter, cODEGRF24Parameter, fEICASO25Parameter, fEFCASO25Parameter, dESCASO25Parameter, oPICASO25Parameter, eSTCASO25Parameter);
        }
    
        public virtual int SP_INS_REGDIAC(string nOMDIAC04, string lUGDIAC04, string tELDIAC04, Nullable<int> cODCANT03)
        {
            var nOMDIAC04Parameter = nOMDIAC04 != null ?
                new ObjectParameter("NOMDIAC04", nOMDIAC04) :
                new ObjectParameter("NOMDIAC04", typeof(string));
    
            var lUGDIAC04Parameter = lUGDIAC04 != null ?
                new ObjectParameter("LUGDIAC04", lUGDIAC04) :
                new ObjectParameter("LUGDIAC04", typeof(string));
    
            var tELDIAC04Parameter = tELDIAC04 != null ?
                new ObjectParameter("TELDIAC04", tELDIAC04) :
                new ObjectParameter("TELDIAC04", typeof(string));
    
            var cODCANT03Parameter = cODCANT03.HasValue ?
                new ObjectParameter("CODCANT03", cODCANT03) :
                new ObjectParameter("CODCANT03", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INS_REGDIAC", nOMDIAC04Parameter, lUGDIAC04Parameter, tELDIAC04Parameter, cODCANT03Parameter);
        }
    
        public virtual int SP_INS_REGEGRF(Nullable<decimal> mTOALQU24, Nullable<decimal> mTOALIM24, Nullable<decimal> mTOELEC24, Nullable<decimal> mTOGAST24, Nullable<decimal> mTCAGUA24, Nullable<decimal> mTOCABL24, Nullable<decimal> mTOTELF24, Nullable<decimal> mTOINTE24, Nullable<decimal> mTOEDUC24, Nullable<decimal> mTOSEGU24, Nullable<decimal> mTOOTRO24)
        {
            var mTOALQU24Parameter = mTOALQU24.HasValue ?
                new ObjectParameter("MTOALQU24", mTOALQU24) :
                new ObjectParameter("MTOALQU24", typeof(decimal));
    
            var mTOALIM24Parameter = mTOALIM24.HasValue ?
                new ObjectParameter("MTOALIM24", mTOALIM24) :
                new ObjectParameter("MTOALIM24", typeof(decimal));
    
            var mTOELEC24Parameter = mTOELEC24.HasValue ?
                new ObjectParameter("MTOELEC24", mTOELEC24) :
                new ObjectParameter("MTOELEC24", typeof(decimal));
    
            var mTOGAST24Parameter = mTOGAST24.HasValue ?
                new ObjectParameter("MTOGAST24", mTOGAST24) :
                new ObjectParameter("MTOGAST24", typeof(decimal));
    
            var mTCAGUA24Parameter = mTCAGUA24.HasValue ?
                new ObjectParameter("MTCAGUA24", mTCAGUA24) :
                new ObjectParameter("MTCAGUA24", typeof(decimal));
    
            var mTOCABL24Parameter = mTOCABL24.HasValue ?
                new ObjectParameter("MTOCABL24", mTOCABL24) :
                new ObjectParameter("MTOCABL24", typeof(decimal));
    
            var mTOTELF24Parameter = mTOTELF24.HasValue ?
                new ObjectParameter("MTOTELF24", mTOTELF24) :
                new ObjectParameter("MTOTELF24", typeof(decimal));
    
            var mTOINTE24Parameter = mTOINTE24.HasValue ?
                new ObjectParameter("MTOINTE24", mTOINTE24) :
                new ObjectParameter("MTOINTE24", typeof(decimal));
    
            var mTOEDUC24Parameter = mTOEDUC24.HasValue ?
                new ObjectParameter("MTOEDUC24", mTOEDUC24) :
                new ObjectParameter("MTOEDUC24", typeof(decimal));
    
            var mTOSEGU24Parameter = mTOSEGU24.HasValue ?
                new ObjectParameter("MTOSEGU24", mTOSEGU24) :
                new ObjectParameter("MTOSEGU24", typeof(decimal));
    
            var mTOOTRO24Parameter = mTOOTRO24.HasValue ?
                new ObjectParameter("MTOOTRO24", mTOOTRO24) :
                new ObjectParameter("MTOOTRO24", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INS_REGEGRF", mTOALQU24Parameter, mTOALIM24Parameter, mTOELEC24Parameter, mTOGAST24Parameter, mTCAGUA24Parameter, mTOCABL24Parameter, mTOTELF24Parameter, mTOINTE24Parameter, mTOEDUC24Parameter, mTOSEGU24Parameter, mTOOTRO24Parameter);
        }
    
        public virtual int SP_INS_REGFAML(string cEDFAML22, string nOMFAML22, Nullable<int> eDAFAML22, Nullable<int> cODESTC06, Nullable<int> cODNEDU09, string oACFAML22, Nullable<decimal> iNGFAML22, string dESFAML22, Nullable<int> cODORGS21, Nullable<int> cODENFR15, Nullable<int> cODPARE12)
        {
            var cEDFAML22Parameter = cEDFAML22 != null ?
                new ObjectParameter("CEDFAML22", cEDFAML22) :
                new ObjectParameter("CEDFAML22", typeof(string));
    
            var nOMFAML22Parameter = nOMFAML22 != null ?
                new ObjectParameter("NOMFAML22", nOMFAML22) :
                new ObjectParameter("NOMFAML22", typeof(string));
    
            var eDAFAML22Parameter = eDAFAML22.HasValue ?
                new ObjectParameter("EDAFAML22", eDAFAML22) :
                new ObjectParameter("EDAFAML22", typeof(int));
    
            var cODESTC06Parameter = cODESTC06.HasValue ?
                new ObjectParameter("CODESTC06", cODESTC06) :
                new ObjectParameter("CODESTC06", typeof(int));
    
            var cODNEDU09Parameter = cODNEDU09.HasValue ?
                new ObjectParameter("CODNEDU09", cODNEDU09) :
                new ObjectParameter("CODNEDU09", typeof(int));
    
            var oACFAML22Parameter = oACFAML22 != null ?
                new ObjectParameter("OACFAML22", oACFAML22) :
                new ObjectParameter("OACFAML22", typeof(string));
    
            var iNGFAML22Parameter = iNGFAML22.HasValue ?
                new ObjectParameter("INGFAML22", iNGFAML22) :
                new ObjectParameter("INGFAML22", typeof(decimal));
    
            var dESFAML22Parameter = dESFAML22 != null ?
                new ObjectParameter("DESFAML22", dESFAML22) :
                new ObjectParameter("DESFAML22", typeof(string));
    
            var cODORGS21Parameter = cODORGS21.HasValue ?
                new ObjectParameter("CODORGS21", cODORGS21) :
                new ObjectParameter("CODORGS21", typeof(int));
    
            var cODENFR15Parameter = cODENFR15.HasValue ?
                new ObjectParameter("CODENFR15", cODENFR15) :
                new ObjectParameter("CODENFR15", typeof(int));
    
            var cODPARE12Parameter = cODPARE12.HasValue ?
                new ObjectParameter("CODPARE12", cODPARE12) :
                new ObjectParameter("CODPARE12", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INS_REGFAML", cEDFAML22Parameter, nOMFAML22Parameter, eDAFAML22Parameter, cODESTC06Parameter, cODNEDU09Parameter, oACFAML22Parameter, iNGFAML22Parameter, dESFAML22Parameter, cODORGS21Parameter, cODENFR15Parameter, cODPARE12Parameter);
        }
    
        public virtual int SP_INS_REGPERS(string cEDPERS13, Nullable<int> cODESTC06, Nullable<int> cODNEDU09, Nullable<int> cODCANT03, Nullable<int> cODSOLI10, Nullable<int> cODRELG11, string nOMPERS13, string pAPPERS13, string sAPPERS13, string nACPERS13, string dIRPERS13, string oACPERS13, string oANPERS13)
        {
            var cEDPERS13Parameter = cEDPERS13 != null ?
                new ObjectParameter("CEDPERS13", cEDPERS13) :
                new ObjectParameter("CEDPERS13", typeof(string));
    
            var cODESTC06Parameter = cODESTC06.HasValue ?
                new ObjectParameter("CODESTC06", cODESTC06) :
                new ObjectParameter("CODESTC06", typeof(int));
    
            var cODNEDU09Parameter = cODNEDU09.HasValue ?
                new ObjectParameter("CODNEDU09", cODNEDU09) :
                new ObjectParameter("CODNEDU09", typeof(int));
    
            var cODCANT03Parameter = cODCANT03.HasValue ?
                new ObjectParameter("CODCANT03", cODCANT03) :
                new ObjectParameter("CODCANT03", typeof(int));
    
            var cODSOLI10Parameter = cODSOLI10.HasValue ?
                new ObjectParameter("CODSOLI10", cODSOLI10) :
                new ObjectParameter("CODSOLI10", typeof(int));
    
            var cODRELG11Parameter = cODRELG11.HasValue ?
                new ObjectParameter("CODRELG11", cODRELG11) :
                new ObjectParameter("CODRELG11", typeof(int));
    
            var nOMPERS13Parameter = nOMPERS13 != null ?
                new ObjectParameter("NOMPERS13", nOMPERS13) :
                new ObjectParameter("NOMPERS13", typeof(string));
    
            var pAPPERS13Parameter = pAPPERS13 != null ?
                new ObjectParameter("PAPPERS13", pAPPERS13) :
                new ObjectParameter("PAPPERS13", typeof(string));
    
            var sAPPERS13Parameter = sAPPERS13 != null ?
                new ObjectParameter("SAPPERS13", sAPPERS13) :
                new ObjectParameter("SAPPERS13", typeof(string));
    
            var nACPERS13Parameter = nACPERS13 != null ?
                new ObjectParameter("NACPERS13", nACPERS13) :
                new ObjectParameter("NACPERS13", typeof(string));
    
            var dIRPERS13Parameter = dIRPERS13 != null ?
                new ObjectParameter("DIRPERS13", dIRPERS13) :
                new ObjectParameter("DIRPERS13", typeof(string));
    
            var oACPERS13Parameter = oACPERS13 != null ?
                new ObjectParameter("OACPERS13", oACPERS13) :
                new ObjectParameter("OACPERS13", typeof(string));
    
            var oANPERS13Parameter = oANPERS13 != null ?
                new ObjectParameter("OANPERS13", oANPERS13) :
                new ObjectParameter("OANPERS13", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INS_REGPERS", cEDPERS13Parameter, cODESTC06Parameter, cODNEDU09Parameter, cODCANT03Parameter, cODSOLI10Parameter, cODRELG11Parameter, nOMPERS13Parameter, pAPPERS13Parameter, sAPPERS13Parameter, nACPERS13Parameter, dIRPERS13Parameter, oACPERS13Parameter, oANPERS13Parameter);
        }
    
        public virtual int SP_INS_REGUSRO(string cEDUSRO07, string nOMUSRO07, string pAPUSRO07, string sAPUSRO07, Nullable<int> cODCANT03, Nullable<int> cODDIAC04, Nullable<int> cODUSRO05, string dIRUSRO07, string nACUSRO07, string cNTUSRO07, Nullable<System.DateTime> fENUSRO07)
        {
            var cEDUSRO07Parameter = cEDUSRO07 != null ?
                new ObjectParameter("CEDUSRO07", cEDUSRO07) :
                new ObjectParameter("CEDUSRO07", typeof(string));
    
            var nOMUSRO07Parameter = nOMUSRO07 != null ?
                new ObjectParameter("NOMUSRO07", nOMUSRO07) :
                new ObjectParameter("NOMUSRO07", typeof(string));
    
            var pAPUSRO07Parameter = pAPUSRO07 != null ?
                new ObjectParameter("PAPUSRO07", pAPUSRO07) :
                new ObjectParameter("PAPUSRO07", typeof(string));
    
            var sAPUSRO07Parameter = sAPUSRO07 != null ?
                new ObjectParameter("SAPUSRO07", sAPUSRO07) :
                new ObjectParameter("SAPUSRO07", typeof(string));
    
            var cODCANT03Parameter = cODCANT03.HasValue ?
                new ObjectParameter("CODCANT03", cODCANT03) :
                new ObjectParameter("CODCANT03", typeof(int));
    
            var cODDIAC04Parameter = cODDIAC04.HasValue ?
                new ObjectParameter("CODDIAC04", cODDIAC04) :
                new ObjectParameter("CODDIAC04", typeof(int));
    
            var cODUSRO05Parameter = cODUSRO05.HasValue ?
                new ObjectParameter("CODUSRO05", cODUSRO05) :
                new ObjectParameter("CODUSRO05", typeof(int));
    
            var dIRUSRO07Parameter = dIRUSRO07 != null ?
                new ObjectParameter("DIRUSRO07", dIRUSRO07) :
                new ObjectParameter("DIRUSRO07", typeof(string));
    
            var nACUSRO07Parameter = nACUSRO07 != null ?
                new ObjectParameter("NACUSRO07", nACUSRO07) :
                new ObjectParameter("NACUSRO07", typeof(string));
    
            var cNTUSRO07Parameter = cNTUSRO07 != null ?
                new ObjectParameter("CNTUSRO07", cNTUSRO07) :
                new ObjectParameter("CNTUSRO07", typeof(string));
    
            var fENUSRO07Parameter = fENUSRO07.HasValue ?
                new ObjectParameter("FENUSRO07", fENUSRO07) :
                new ObjectParameter("FENUSRO07", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INS_REGUSRO", cEDUSRO07Parameter, nOMUSRO07Parameter, pAPUSRO07Parameter, sAPUSRO07Parameter, cODCANT03Parameter, cODDIAC04Parameter, cODUSRO05Parameter, dIRUSRO07Parameter, nACUSRO07Parameter, cNTUSRO07Parameter, fENUSRO07Parameter);
        }
    
        public virtual int SP_INS_REGVIVI(Nullable<int> cODTIPV18, Nullable<int> cODESTV19, Nullable<int> cODMATE17, Nullable<decimal> mTOVIVI20, string nAPVIVI20, string sRCVIVI20, string sRIVIVI20, string sRLVIVI20, string sRMVIVI20, string sRBVIVI20, string sREVIVI20)
        {
            var cODTIPV18Parameter = cODTIPV18.HasValue ?
                new ObjectParameter("CODTIPV18", cODTIPV18) :
                new ObjectParameter("CODTIPV18", typeof(int));
    
            var cODESTV19Parameter = cODESTV19.HasValue ?
                new ObjectParameter("CODESTV19", cODESTV19) :
                new ObjectParameter("CODESTV19", typeof(int));
    
            var cODMATE17Parameter = cODMATE17.HasValue ?
                new ObjectParameter("CODMATE17", cODMATE17) :
                new ObjectParameter("CODMATE17", typeof(int));
    
            var mTOVIVI20Parameter = mTOVIVI20.HasValue ?
                new ObjectParameter("MTOVIVI20", mTOVIVI20) :
                new ObjectParameter("MTOVIVI20", typeof(decimal));
    
            var nAPVIVI20Parameter = nAPVIVI20 != null ?
                new ObjectParameter("NAPVIVI20", nAPVIVI20) :
                new ObjectParameter("NAPVIVI20", typeof(string));
    
            var sRCVIVI20Parameter = sRCVIVI20 != null ?
                new ObjectParameter("SRCVIVI20", sRCVIVI20) :
                new ObjectParameter("SRCVIVI20", typeof(string));
    
            var sRIVIVI20Parameter = sRIVIVI20 != null ?
                new ObjectParameter("SRIVIVI20", sRIVIVI20) :
                new ObjectParameter("SRIVIVI20", typeof(string));
    
            var sRLVIVI20Parameter = sRLVIVI20 != null ?
                new ObjectParameter("SRLVIVI20", sRLVIVI20) :
                new ObjectParameter("SRLVIVI20", typeof(string));
    
            var sRMVIVI20Parameter = sRMVIVI20 != null ?
                new ObjectParameter("SRMVIVI20", sRMVIVI20) :
                new ObjectParameter("SRMVIVI20", typeof(string));
    
            var sRBVIVI20Parameter = sRBVIVI20 != null ?
                new ObjectParameter("SRBVIVI20", sRBVIVI20) :
                new ObjectParameter("SRBVIVI20", typeof(string));
    
            var sREVIVI20Parameter = sREVIVI20 != null ?
                new ObjectParameter("SREVIVI20", sREVIVI20) :
                new ObjectParameter("SREVIVI20", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INS_REGVIVI", cODTIPV18Parameter, cODESTV19Parameter, cODMATE17Parameter, mTOVIVI20Parameter, nAPVIVI20Parameter, sRCVIVI20Parameter, sRIVIVI20Parameter, sRLVIVI20Parameter, sRMVIVI20Parameter, sRBVIVI20Parameter, sREVIVI20Parameter);
        }
    
        public virtual int SP_MOD_REGDIAC(Nullable<int> cODDIAC04, string nOMDIAC04, string lUGDIAC04, string tELDIAC04, string eSTDIAC04, Nullable<int> cODCANT03)
        {
            var cODDIAC04Parameter = cODDIAC04.HasValue ?
                new ObjectParameter("CODDIAC04", cODDIAC04) :
                new ObjectParameter("CODDIAC04", typeof(int));
    
            var nOMDIAC04Parameter = nOMDIAC04 != null ?
                new ObjectParameter("NOMDIAC04", nOMDIAC04) :
                new ObjectParameter("NOMDIAC04", typeof(string));
    
            var lUGDIAC04Parameter = lUGDIAC04 != null ?
                new ObjectParameter("LUGDIAC04", lUGDIAC04) :
                new ObjectParameter("LUGDIAC04", typeof(string));
    
            var tELDIAC04Parameter = tELDIAC04 != null ?
                new ObjectParameter("TELDIAC04", tELDIAC04) :
                new ObjectParameter("TELDIAC04", typeof(string));
    
            var eSTDIAC04Parameter = eSTDIAC04 != null ?
                new ObjectParameter("ESTDIAC04", eSTDIAC04) :
                new ObjectParameter("ESTDIAC04", typeof(string));
    
            var cODCANT03Parameter = cODCANT03.HasValue ?
                new ObjectParameter("CODCANT03", cODCANT03) :
                new ObjectParameter("CODCANT03", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MOD_REGDIAC", cODDIAC04Parameter, nOMDIAC04Parameter, lUGDIAC04Parameter, tELDIAC04Parameter, eSTDIAC04Parameter, cODCANT03Parameter);
        }
    
        public virtual int SP_MOD_REGUSRO(string cEDUSRO07, string nOMUSRO07, string pAPUSRO07, string sAPUSRO07, Nullable<int> cODCANT03, Nullable<int> cODDIAC04, Nullable<int> cODUSRO05, string eSTUSRO07, string dIRUSRO07, string nACUSRO07, string cNTUSRO07, Nullable<System.DateTime> fENUSRO07)
        {
            var cEDUSRO07Parameter = cEDUSRO07 != null ?
                new ObjectParameter("CEDUSRO07", cEDUSRO07) :
                new ObjectParameter("CEDUSRO07", typeof(string));
    
            var nOMUSRO07Parameter = nOMUSRO07 != null ?
                new ObjectParameter("NOMUSRO07", nOMUSRO07) :
                new ObjectParameter("NOMUSRO07", typeof(string));
    
            var pAPUSRO07Parameter = pAPUSRO07 != null ?
                new ObjectParameter("PAPUSRO07", pAPUSRO07) :
                new ObjectParameter("PAPUSRO07", typeof(string));
    
            var sAPUSRO07Parameter = sAPUSRO07 != null ?
                new ObjectParameter("SAPUSRO07", sAPUSRO07) :
                new ObjectParameter("SAPUSRO07", typeof(string));
    
            var cODCANT03Parameter = cODCANT03.HasValue ?
                new ObjectParameter("CODCANT03", cODCANT03) :
                new ObjectParameter("CODCANT03", typeof(int));
    
            var cODDIAC04Parameter = cODDIAC04.HasValue ?
                new ObjectParameter("CODDIAC04", cODDIAC04) :
                new ObjectParameter("CODDIAC04", typeof(int));
    
            var cODUSRO05Parameter = cODUSRO05.HasValue ?
                new ObjectParameter("CODUSRO05", cODUSRO05) :
                new ObjectParameter("CODUSRO05", typeof(int));
    
            var eSTUSRO07Parameter = eSTUSRO07 != null ?
                new ObjectParameter("ESTUSRO07", eSTUSRO07) :
                new ObjectParameter("ESTUSRO07", typeof(string));
    
            var dIRUSRO07Parameter = dIRUSRO07 != null ?
                new ObjectParameter("DIRUSRO07", dIRUSRO07) :
                new ObjectParameter("DIRUSRO07", typeof(string));
    
            var nACUSRO07Parameter = nACUSRO07 != null ?
                new ObjectParameter("NACUSRO07", nACUSRO07) :
                new ObjectParameter("NACUSRO07", typeof(string));
    
            var cNTUSRO07Parameter = cNTUSRO07 != null ?
                new ObjectParameter("CNTUSRO07", cNTUSRO07) :
                new ObjectParameter("CNTUSRO07", typeof(string));
    
            var fENUSRO07Parameter = fENUSRO07.HasValue ?
                new ObjectParameter("FENUSRO07", fENUSRO07) :
                new ObjectParameter("FENUSRO07", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MOD_REGUSRO", cEDUSRO07Parameter, nOMUSRO07Parameter, pAPUSRO07Parameter, sAPUSRO07Parameter, cODCANT03Parameter, cODDIAC04Parameter, cODUSRO05Parameter, eSTUSRO07Parameter, dIRUSRO07Parameter, nACUSRO07Parameter, cNTUSRO07Parameter, fENUSRO07Parameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<SP_CON_REGFAML_Result> SP_CON_REGFAML(string cedulaSolicitante)
        {
            var cedulaSolicitanteParameter = cedulaSolicitante != null ?
                new ObjectParameter("cedulaSolicitante", cedulaSolicitante) :
                new ObjectParameter("cedulaSolicitante", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CON_REGFAML_Result>("SP_CON_REGFAML", cedulaSolicitanteParameter);
        }
    
        public virtual ObjectResult<SP_CONXID_REGFAML_Result> SP_CONXID_REGFAML(string cedula)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CONXID_REGFAML_Result>("SP_CONXID_REGFAML", cedulaParameter);
        }
    }
}
