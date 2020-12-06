
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/05/2020 09:54:35
-- Generated from EDMX file: C:\source\SIDEPS\SIDEPS\AccesoDatos\SIDEPS.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SIDEPS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CEDFAML22]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_23CATFINA] DROP CONSTRAINT [FK__SIDEPS_CEDFAML22];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CEDPERS13]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_16REGASPS] DROP CONSTRAINT [FK__SIDEPS_CEDPERS13];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CEDPERS13_02]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_23CATFINA] DROP CONSTRAINT [FK__SIDEPS_CEDPERS13_02];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CEDPERS13_03]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_25REGCASO] DROP CONSTRAINT [FK__SIDEPS_CEDPERS13_03];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CEDUSRO07]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_08REGTELF] DROP CONSTRAINT [FK__SIDEPS_CEDUSRO07];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CEDUSRO07_03]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_25REGCASO] DROP CONSTRAINT [FK__SIDEPS_CEDUSRO07_03];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODASPS16]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_25REGCASO] DROP CONSTRAINT [FK__SIDEPS_CODASPS16];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODAYUD26]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_27TIPAYUD] DROP CONSTRAINT [FK__SIDEPS_CODAYUD26];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODCANT03]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_04REGDIAC] DROP CONSTRAINT [FK__SIDEPS_CODCANT03];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODCANT03_02]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_07REGUSRO] DROP CONSTRAINT [FK__SIDEPS_CODCANT03_02];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODCANT03_3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_13REGPERS] DROP CONSTRAINT [FK__SIDEPS_CODCANT03_3];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODCASO25]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_27TIPAYUD] DROP CONSTRAINT [FK__SIDEPS_CODCASO25];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODCASO25_02]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_28REGHIS] DROP CONSTRAINT [FK__SIDEPS_CODCASO25_02];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODDIAC04]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_07REGUSRO] DROP CONSTRAINT [FK__SIDEPS_CODDIAC04];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODEGRF24]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_25REGCASO] DROP CONSTRAINT [FK__SIDEPS_CODEGRF24];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODENFR15]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_16REGASPS] DROP CONSTRAINT [FK__SIDEPS_CODENFR15];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODENFR15_02]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_22REGFAML] DROP CONSTRAINT [FK__SIDEPS_CODENFR15_02];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODESTC06]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_13REGPERS] DROP CONSTRAINT [FK__SIDEPS_CODESTC06];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODESTC06_02]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_22REGFAML] DROP CONSTRAINT [FK__SIDEPS_CODESTC06_02];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODESTV19]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_20REGVIVI] DROP CONSTRAINT [FK__SIDEPS_CODESTV19];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODMATE17]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_20REGVIVI] DROP CONSTRAINT [FK__SIDEPS_CODMATE17];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODNEDU09]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_13REGPERS] DROP CONSTRAINT [FK__SIDEPS_CODNEDU09];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODNEDU09_02]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_22REGFAML] DROP CONSTRAINT [FK__SIDEPS_CODNEDU09_02];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODORGS21]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_22REGFAML] DROP CONSTRAINT [FK__SIDEPS_CODORGS21];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODPAIS01]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_02CATPROV] DROP CONSTRAINT [FK__SIDEPS_CODPAIS01];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODPARE12]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_22REGFAML] DROP CONSTRAINT [FK__SIDEPS_CODPARE12];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODPROV02]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_03CATCANT] DROP CONSTRAINT [FK__SIDEPS_CODPROV02];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODRELG11]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_13REGPERS] DROP CONSTRAINT [FK__SIDEPS_CODRELG11];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODSEGU14]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_16REGASPS] DROP CONSTRAINT [FK__SIDEPS_CODSEGU14];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODSOLI10]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_13REGPERS] DROP CONSTRAINT [FK__SIDEPS_CODSOLI10];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODTIPV18]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_20REGVIVI] DROP CONSTRAINT [FK__SIDEPS_CODTIPV18];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODUSRO05]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_07REGUSRO] DROP CONSTRAINT [FK__SIDEPS_CODUSRO05];
GO
IF OBJECT_ID(N'[dbo].[FK__SIDEPS_CODVIVI20]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SIDEPS_25REGCASO] DROP CONSTRAINT [FK__SIDEPS_CODVIVI20];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[SIDEPS_01CATPAIS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_01CATPAIS];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_02CATPROV]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_02CATPROV];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_03CATCANT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_03CATCANT];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_04REGDIAC]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_04REGDIAC];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_05TIPUSRO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_05TIPUSRO];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_06CATESTC]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_06CATESTC];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_07REGUSRO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_07REGUSRO];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_08REGTELF]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_08REGTELF];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_09CATNEDU]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_09CATNEDU];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_10CATSOLI]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_10CATSOLI];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_11CATRELG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_11CATRELG];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_12CATPARE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_12CATPARE];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_13REGPERS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_13REGPERS];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_14CATSEGU]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_14CATSEGU];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_15CATENFR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_15CATENFR];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_16REGASPS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_16REGASPS];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_17CATMATE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_17CATMATE];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_18TIPVIVI]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_18TIPVIVI];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_19ESTVIVI]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_19ESTVIVI];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_20REGVIVI]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_20REGVIVI];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_21CATORGS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_21CATORGS];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_22REGFAML]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_22REGFAML];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_23CATFINA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_23CATFINA];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_24REGEGRF]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_24REGEGRF];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_25REGCASO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_25REGCASO];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_26CATAYUD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_26CATAYUD];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_27TIPAYUD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_27TIPAYUD];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_28REGHIS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_28REGHIS];
GO
IF OBJECT_ID(N'[dbo].[SIDEPS_29REGCNTR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SIDEPS_29REGCNTR];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SIDEPS_01CATPAIS'
CREATE TABLE [dbo].[SIDEPS_01CATPAIS] (
    [CODPAIS01] int IDENTITY(1,1) NOT NULL,
    [NOMPAIS01] varchar(50)  NOT NULL
);
GO

-- Creating table 'SIDEPS_02CATPROV'
CREATE TABLE [dbo].[SIDEPS_02CATPROV] (
    [CODPROV02] int IDENTITY(1,1) NOT NULL,
    [NOMPROV02] varchar(50)  NOT NULL,
    [CODPAIS01] int  NULL
);
GO

-- Creating table 'SIDEPS_03CATCANT'
CREATE TABLE [dbo].[SIDEPS_03CATCANT] (
    [CODCANT03] int IDENTITY(1,1) NOT NULL,
    [NOMCANT03] varchar(50)  NULL,
    [CODPROV02] int  NULL
);
GO

-- Creating table 'SIDEPS_04REGDIAC'
CREATE TABLE [dbo].[SIDEPS_04REGDIAC] (
    [CODDIAC04] int IDENTITY(1,1) NOT NULL,
    [NOMDIAC04] varchar(50)  NULL,
    [LUGDIAC04] varchar(100)  NULL,
    [TELDIAC04] varchar(12)  NULL,
    [ESTDIAC04] varchar(20)  NULL,
    [CODCANT03] int  NULL
);
GO

-- Creating table 'SIDEPS_05TIPUSRO'
CREATE TABLE [dbo].[SIDEPS_05TIPUSRO] (
    [CODUSRO05] int IDENTITY(1,1) NOT NULL,
    [DESUSRO05] varchar(50)  NULL
);
GO

-- Creating table 'SIDEPS_06CATESTC'
CREATE TABLE [dbo].[SIDEPS_06CATESTC] (
    [CODESTC06] int IDENTITY(1,1) NOT NULL,
    [DESESTC06] varchar(50)  NULL
);
GO

-- Creating table 'SIDEPS_07REGUSRO'
CREATE TABLE [dbo].[SIDEPS_07REGUSRO] (
    [CEDUSRO07] varchar(20)  NOT NULL,
    [NOMUSRO07] varchar(50)  NULL,
    [PAPUSRO07] varchar(50)  NULL,
    [SAPUSRO07] varchar(50)  NULL,
    [CODCANT03] int  NULL,
    [CODDIAC04] int  NULL,
    [CODUSRO05] int  NULL,
    [ESTUSRO07] varchar(20)  NULL,
    [DIRUSRO07] varchar(200)  NULL,
    [NACUSRO07] varchar(15)  NULL,
    [CNTUSRO07] varchar(30)  NULL,
    [FEIUSRO07] datetime  NULL,
    [FEFUSRO07] datetime  NULL,
    [FENUSRO07] datetime  NULL
);
GO

-- Creating table 'SIDEPS_08REGTELF'
CREATE TABLE [dbo].[SIDEPS_08REGTELF] (
    [CODTELF08] int IDENTITY(1,1) NOT NULL,
    [CEDUSRO07] varchar(20)  NULL,
    [NUMTELF08] varchar(20)  NULL
);
GO

-- Creating table 'SIDEPS_09CATNEDU'
CREATE TABLE [dbo].[SIDEPS_09CATNEDU] (
    [CODNEDU09] int IDENTITY(1,1) NOT NULL,
    [DESNEDU09] varchar(30)  NULL
);
GO

-- Creating table 'SIDEPS_10CATSOLI'
CREATE TABLE [dbo].[SIDEPS_10CATSOLI] (
    [CODSOLI10] int IDENTITY(1,1) NOT NULL,
    [DESSOLI10] varchar(20)  NULL
);
GO

-- Creating table 'SIDEPS_11CATRELG'
CREATE TABLE [dbo].[SIDEPS_11CATRELG] (
    [CODRELG11] int IDENTITY(1,1) NOT NULL,
    [DESRELG11] varchar(50)  NULL
);
GO

-- Creating table 'SIDEPS_12CATPARE'
CREATE TABLE [dbo].[SIDEPS_12CATPARE] (
    [CODPARE12] int IDENTITY(1,1) NOT NULL,
    [DESPARE12] varchar(50)  NULL
);
GO

-- Creating table 'SIDEPS_13REGPERS'
CREATE TABLE [dbo].[SIDEPS_13REGPERS] (
    [CEDPERS13] varchar(20)  NOT NULL,
    [CODESTC06] int  NULL,
    [CODNEDU09] int  NULL,
    [CODCANT03] int  NULL,
    [CODSOLI10] int  NULL,
    [CODRELG11] int  NULL,
    [NOMPERS13] varchar(20)  NULL,
    [PAPPERS13] varchar(20)  NULL,
    [SAPPERS13] varchar(20)  NULL,
    [NACPERS13] varchar(50)  NULL,
    [DIRPERS13] varchar(200)  NULL,
    [OACPERS13] varchar(100)  NULL,
    [OANPERS13] varchar(100)  NULL,
    [FENPERS13] datetime  NULL
);
GO

-- Creating table 'SIDEPS_14CATSEGU'
CREATE TABLE [dbo].[SIDEPS_14CATSEGU] (
    [CODSEGU14] int IDENTITY(1,1) NOT NULL,
    [DESSEGU14] varchar(50)  NULL
);
GO

-- Creating table 'SIDEPS_15CATENFR'
CREATE TABLE [dbo].[SIDEPS_15CATENFR] (
    [CODENFR15] int IDENTITY(1,1) NOT NULL,
    [DESENFR15] varchar(50)  NULL
);
GO

-- Creating table 'SIDEPS_16REGASPS'
CREATE TABLE [dbo].[SIDEPS_16REGASPS] (
    [CODASPS16] int IDENTITY(1,1) NOT NULL,
    [CEDPERS13] varchar(20)  NULL,
    [CODSEGU14] int  NULL,
    [CODENFR15] int  NULL,
    [DESENFR16] varchar(50)  NULL,
    [RECTRAT16] varchar(2)  NULL,
    [DESTRAT16] varchar(50)  NULL
);
GO

-- Creating table 'SIDEPS_17CATMATE'
CREATE TABLE [dbo].[SIDEPS_17CATMATE] (
    [CODMATE17] int IDENTITY(1,1) NOT NULL,
    [DESMATE17] varchar(50)  NULL
);
GO

-- Creating table 'SIDEPS_18TIPVIVI'
CREATE TABLE [dbo].[SIDEPS_18TIPVIVI] (
    [CODTIPV18] int IDENTITY(1,1) NOT NULL,
    [DESTIPV18] varchar(60)  NULL
);
GO

-- Creating table 'SIDEPS_19ESTVIVI'
CREATE TABLE [dbo].[SIDEPS_19ESTVIVI] (
    [CODESTV19] int IDENTITY(1,1) NOT NULL,
    [DESESTV19] varchar(60)  NULL
);
GO

-- Creating table 'SIDEPS_20REGVIVI'
CREATE TABLE [dbo].[SIDEPS_20REGVIVI] (
    [CODVIVI20] int IDENTITY(1,1) NOT NULL,
    [CODTIPV18] int  NULL,
    [CODESTV19] int  NULL,
    [CODMATE17] int  NULL,
    [MTOVIVI20] decimal(18,4)  NULL,
    [NAPVIVI20] int  NULL,
    [SRCVIVI20] bit  NULL,
    [SRIVIVI20] bit  NULL,
    [SRLVIVI20] bit  NULL,
    [SRMVIVI20] bit  NULL,
    [SRBVIVI20] bit  NULL,
    [SREVIVI20] bit  NULL
);
GO

-- Creating table 'SIDEPS_21CATORGS'
CREATE TABLE [dbo].[SIDEPS_21CATORGS] (
    [CODORGS21] int IDENTITY(1,1) NOT NULL,
    [DESORGS21] varchar(50)  NULL
);
GO

-- Creating table 'SIDEPS_22REGFAML'
CREATE TABLE [dbo].[SIDEPS_22REGFAML] (
    [CEDFAML22] varchar(20)  NOT NULL,
    [NOMFAML22] varchar(50)  NULL,
    [EDAFAML22] int  NULL,
    [CODESTC06] int  NULL,
    [CODNEDU09] int  NULL,
    [OACFAML22] varchar(100)  NULL,
    [INGFAML22] decimal(18,4)  NULL,
    [DESFAML22] varchar(200)  NULL,
    [CODORGS21] int  NULL,
    [CODENFR15] int  NULL,
    [CODPARE12] int  NULL
);
GO

-- Creating table 'SIDEPS_23CATFINA'
CREATE TABLE [dbo].[SIDEPS_23CATFINA] (
    [CODFINA23] int IDENTITY(1,1) NOT NULL,
    [CEDFAML22] varchar(20)  NULL,
    [CEDPERS13] varchar(20)  NULL
);
GO

-- Creating table 'SIDEPS_24REGEGRF'
CREATE TABLE [dbo].[SIDEPS_24REGEGRF] (
    [CODEGRF24] int IDENTITY(1,1) NOT NULL,
    [MTOALQU24] decimal(18,4)  NULL,
    [MTOALIM24] decimal(18,4)  NULL,
    [MTOELEC24] decimal(18,4)  NULL,
    [MTOGAST24] decimal(18,4)  NULL,
    [MTCAGUA24] decimal(18,4)  NULL,
    [MTOCABL24] decimal(18,4)  NULL,
    [MTOTELF24] decimal(18,4)  NULL,
    [MTOINTE24] decimal(18,4)  NULL,
    [MTOEDUC24] decimal(18,4)  NULL,
    [MTOSEGU24] decimal(18,4)  NULL,
    [MTOOTRO24] decimal(18,4)  NULL
);
GO

-- Creating table 'SIDEPS_25REGCASO'
CREATE TABLE [dbo].[SIDEPS_25REGCASO] (
    [CODCASO25] int IDENTITY(1,1) NOT NULL,
    [CEDPERS13] varchar(20)  NULL,
    [CODASPS16] int  NULL,
    [CEDUSRO07] varchar(20)  NULL,
    [CODVIVI20] int  NULL,
    [CODEGRF24] int  NULL,
    [FEICASO25] datetime  NULL,
    [FEFCASO25] datetime  NULL,
    [DESCASO25] varchar(200)  NULL,
    [OPICASO25] varchar(200)  NULL,
    [ESTCASO25] varchar(20)  NULL
);
GO

-- Creating table 'SIDEPS_26CATAYUD'
CREATE TABLE [dbo].[SIDEPS_26CATAYUD] (
    [CODAYUD26] int IDENTITY(1,1) NOT NULL,
    [DESAYUD26] varchar(50)  NULL
);
GO

-- Creating table 'SIDEPS_27TIPAYUD'
CREATE TABLE [dbo].[SIDEPS_27TIPAYUD] (
    [CODTIPA27] int IDENTITY(1,1) NOT NULL,
    [CODAYUD26] int  NULL,
    [CODCASO25] int  NULL
);
GO

-- Creating table 'SIDEPS_28REGHIS'
CREATE TABLE [dbo].[SIDEPS_28REGHIS] (
    [CODHIST28] int IDENTITY(1,1) NOT NULL,
    [CODCASO25] int  NULL,
    [DESCASO28] varchar(20)  NULL,
    [ESTCASO28] varchar(15)  NULL,
    [FECCASO28] datetime  NULL,
    [FECACTU28] datetime  NULL
);
GO

-- Creating table 'SIDEPS_29REGCNTR'
CREATE TABLE [dbo].[SIDEPS_29REGCNTR] (
    [CODCASO] int  NULL,
    [ESTCASO] varchar(2)  NULL,
    [CODCNTR] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CODPAIS01] in table 'SIDEPS_01CATPAIS'
ALTER TABLE [dbo].[SIDEPS_01CATPAIS]
ADD CONSTRAINT [PK_SIDEPS_01CATPAIS]
    PRIMARY KEY CLUSTERED ([CODPAIS01] ASC);
GO

-- Creating primary key on [CODPROV02] in table 'SIDEPS_02CATPROV'
ALTER TABLE [dbo].[SIDEPS_02CATPROV]
ADD CONSTRAINT [PK_SIDEPS_02CATPROV]
    PRIMARY KEY CLUSTERED ([CODPROV02] ASC);
GO

-- Creating primary key on [CODCANT03] in table 'SIDEPS_03CATCANT'
ALTER TABLE [dbo].[SIDEPS_03CATCANT]
ADD CONSTRAINT [PK_SIDEPS_03CATCANT]
    PRIMARY KEY CLUSTERED ([CODCANT03] ASC);
GO

-- Creating primary key on [CODDIAC04] in table 'SIDEPS_04REGDIAC'
ALTER TABLE [dbo].[SIDEPS_04REGDIAC]
ADD CONSTRAINT [PK_SIDEPS_04REGDIAC]
    PRIMARY KEY CLUSTERED ([CODDIAC04] ASC);
GO

-- Creating primary key on [CODUSRO05] in table 'SIDEPS_05TIPUSRO'
ALTER TABLE [dbo].[SIDEPS_05TIPUSRO]
ADD CONSTRAINT [PK_SIDEPS_05TIPUSRO]
    PRIMARY KEY CLUSTERED ([CODUSRO05] ASC);
GO

-- Creating primary key on [CODESTC06] in table 'SIDEPS_06CATESTC'
ALTER TABLE [dbo].[SIDEPS_06CATESTC]
ADD CONSTRAINT [PK_SIDEPS_06CATESTC]
    PRIMARY KEY CLUSTERED ([CODESTC06] ASC);
GO

-- Creating primary key on [CEDUSRO07] in table 'SIDEPS_07REGUSRO'
ALTER TABLE [dbo].[SIDEPS_07REGUSRO]
ADD CONSTRAINT [PK_SIDEPS_07REGUSRO]
    PRIMARY KEY CLUSTERED ([CEDUSRO07] ASC);
GO

-- Creating primary key on [CODTELF08] in table 'SIDEPS_08REGTELF'
ALTER TABLE [dbo].[SIDEPS_08REGTELF]
ADD CONSTRAINT [PK_SIDEPS_08REGTELF]
    PRIMARY KEY CLUSTERED ([CODTELF08] ASC);
GO

-- Creating primary key on [CODNEDU09] in table 'SIDEPS_09CATNEDU'
ALTER TABLE [dbo].[SIDEPS_09CATNEDU]
ADD CONSTRAINT [PK_SIDEPS_09CATNEDU]
    PRIMARY KEY CLUSTERED ([CODNEDU09] ASC);
GO

-- Creating primary key on [CODSOLI10] in table 'SIDEPS_10CATSOLI'
ALTER TABLE [dbo].[SIDEPS_10CATSOLI]
ADD CONSTRAINT [PK_SIDEPS_10CATSOLI]
    PRIMARY KEY CLUSTERED ([CODSOLI10] ASC);
GO

-- Creating primary key on [CODRELG11] in table 'SIDEPS_11CATRELG'
ALTER TABLE [dbo].[SIDEPS_11CATRELG]
ADD CONSTRAINT [PK_SIDEPS_11CATRELG]
    PRIMARY KEY CLUSTERED ([CODRELG11] ASC);
GO

-- Creating primary key on [CODPARE12] in table 'SIDEPS_12CATPARE'
ALTER TABLE [dbo].[SIDEPS_12CATPARE]
ADD CONSTRAINT [PK_SIDEPS_12CATPARE]
    PRIMARY KEY CLUSTERED ([CODPARE12] ASC);
GO

-- Creating primary key on [CEDPERS13] in table 'SIDEPS_13REGPERS'
ALTER TABLE [dbo].[SIDEPS_13REGPERS]
ADD CONSTRAINT [PK_SIDEPS_13REGPERS]
    PRIMARY KEY CLUSTERED ([CEDPERS13] ASC);
GO

-- Creating primary key on [CODSEGU14] in table 'SIDEPS_14CATSEGU'
ALTER TABLE [dbo].[SIDEPS_14CATSEGU]
ADD CONSTRAINT [PK_SIDEPS_14CATSEGU]
    PRIMARY KEY CLUSTERED ([CODSEGU14] ASC);
GO

-- Creating primary key on [CODENFR15] in table 'SIDEPS_15CATENFR'
ALTER TABLE [dbo].[SIDEPS_15CATENFR]
ADD CONSTRAINT [PK_SIDEPS_15CATENFR]
    PRIMARY KEY CLUSTERED ([CODENFR15] ASC);
GO

-- Creating primary key on [CODASPS16] in table 'SIDEPS_16REGASPS'
ALTER TABLE [dbo].[SIDEPS_16REGASPS]
ADD CONSTRAINT [PK_SIDEPS_16REGASPS]
    PRIMARY KEY CLUSTERED ([CODASPS16] ASC);
GO

-- Creating primary key on [CODMATE17] in table 'SIDEPS_17CATMATE'
ALTER TABLE [dbo].[SIDEPS_17CATMATE]
ADD CONSTRAINT [PK_SIDEPS_17CATMATE]
    PRIMARY KEY CLUSTERED ([CODMATE17] ASC);
GO

-- Creating primary key on [CODTIPV18] in table 'SIDEPS_18TIPVIVI'
ALTER TABLE [dbo].[SIDEPS_18TIPVIVI]
ADD CONSTRAINT [PK_SIDEPS_18TIPVIVI]
    PRIMARY KEY CLUSTERED ([CODTIPV18] ASC);
GO

-- Creating primary key on [CODESTV19] in table 'SIDEPS_19ESTVIVI'
ALTER TABLE [dbo].[SIDEPS_19ESTVIVI]
ADD CONSTRAINT [PK_SIDEPS_19ESTVIVI]
    PRIMARY KEY CLUSTERED ([CODESTV19] ASC);
GO

-- Creating primary key on [CODVIVI20] in table 'SIDEPS_20REGVIVI'
ALTER TABLE [dbo].[SIDEPS_20REGVIVI]
ADD CONSTRAINT [PK_SIDEPS_20REGVIVI]
    PRIMARY KEY CLUSTERED ([CODVIVI20] ASC);
GO

-- Creating primary key on [CODORGS21] in table 'SIDEPS_21CATORGS'
ALTER TABLE [dbo].[SIDEPS_21CATORGS]
ADD CONSTRAINT [PK_SIDEPS_21CATORGS]
    PRIMARY KEY CLUSTERED ([CODORGS21] ASC);
GO

-- Creating primary key on [CEDFAML22] in table 'SIDEPS_22REGFAML'
ALTER TABLE [dbo].[SIDEPS_22REGFAML]
ADD CONSTRAINT [PK_SIDEPS_22REGFAML]
    PRIMARY KEY CLUSTERED ([CEDFAML22] ASC);
GO

-- Creating primary key on [CODFINA23] in table 'SIDEPS_23CATFINA'
ALTER TABLE [dbo].[SIDEPS_23CATFINA]
ADD CONSTRAINT [PK_SIDEPS_23CATFINA]
    PRIMARY KEY CLUSTERED ([CODFINA23] ASC);
GO

-- Creating primary key on [CODEGRF24] in table 'SIDEPS_24REGEGRF'
ALTER TABLE [dbo].[SIDEPS_24REGEGRF]
ADD CONSTRAINT [PK_SIDEPS_24REGEGRF]
    PRIMARY KEY CLUSTERED ([CODEGRF24] ASC);
GO

-- Creating primary key on [CODCASO25] in table 'SIDEPS_25REGCASO'
ALTER TABLE [dbo].[SIDEPS_25REGCASO]
ADD CONSTRAINT [PK_SIDEPS_25REGCASO]
    PRIMARY KEY CLUSTERED ([CODCASO25] ASC);
GO

-- Creating primary key on [CODAYUD26] in table 'SIDEPS_26CATAYUD'
ALTER TABLE [dbo].[SIDEPS_26CATAYUD]
ADD CONSTRAINT [PK_SIDEPS_26CATAYUD]
    PRIMARY KEY CLUSTERED ([CODAYUD26] ASC);
GO

-- Creating primary key on [CODTIPA27] in table 'SIDEPS_27TIPAYUD'
ALTER TABLE [dbo].[SIDEPS_27TIPAYUD]
ADD CONSTRAINT [PK_SIDEPS_27TIPAYUD]
    PRIMARY KEY CLUSTERED ([CODTIPA27] ASC);
GO

-- Creating primary key on [CODHIST28] in table 'SIDEPS_28REGHIS'
ALTER TABLE [dbo].[SIDEPS_28REGHIS]
ADD CONSTRAINT [PK_SIDEPS_28REGHIS]
    PRIMARY KEY CLUSTERED ([CODHIST28] ASC);
GO

-- Creating primary key on [CODCNTR] in table 'SIDEPS_29REGCNTR'
ALTER TABLE [dbo].[SIDEPS_29REGCNTR]
ADD CONSTRAINT [PK_SIDEPS_29REGCNTR]
    PRIMARY KEY CLUSTERED ([CODCNTR] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CODPAIS01] in table 'SIDEPS_02CATPROV'
ALTER TABLE [dbo].[SIDEPS_02CATPROV]
ADD CONSTRAINT [FK__SIDEPS_CODPAIS01]
    FOREIGN KEY ([CODPAIS01])
    REFERENCES [dbo].[SIDEPS_01CATPAIS]
        ([CODPAIS01])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODPAIS01'
CREATE INDEX [IX_FK__SIDEPS_CODPAIS01]
ON [dbo].[SIDEPS_02CATPROV]
    ([CODPAIS01]);
GO

-- Creating foreign key on [CODPROV02] in table 'SIDEPS_03CATCANT'
ALTER TABLE [dbo].[SIDEPS_03CATCANT]
ADD CONSTRAINT [FK__SIDEPS_CODPROV02]
    FOREIGN KEY ([CODPROV02])
    REFERENCES [dbo].[SIDEPS_02CATPROV]
        ([CODPROV02])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODPROV02'
CREATE INDEX [IX_FK__SIDEPS_CODPROV02]
ON [dbo].[SIDEPS_03CATCANT]
    ([CODPROV02]);
GO

-- Creating foreign key on [CODCANT03] in table 'SIDEPS_04REGDIAC'
ALTER TABLE [dbo].[SIDEPS_04REGDIAC]
ADD CONSTRAINT [FK__SIDEPS_CODCANT03]
    FOREIGN KEY ([CODCANT03])
    REFERENCES [dbo].[SIDEPS_03CATCANT]
        ([CODCANT03])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODCANT03'
CREATE INDEX [IX_FK__SIDEPS_CODCANT03]
ON [dbo].[SIDEPS_04REGDIAC]
    ([CODCANT03]);
GO

-- Creating foreign key on [CODCANT03] in table 'SIDEPS_07REGUSRO'
ALTER TABLE [dbo].[SIDEPS_07REGUSRO]
ADD CONSTRAINT [FK__SIDEPS_CODCANT03_02]
    FOREIGN KEY ([CODCANT03])
    REFERENCES [dbo].[SIDEPS_03CATCANT]
        ([CODCANT03])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODCANT03_02'
CREATE INDEX [IX_FK__SIDEPS_CODCANT03_02]
ON [dbo].[SIDEPS_07REGUSRO]
    ([CODCANT03]);
GO

-- Creating foreign key on [CODCANT03] in table 'SIDEPS_13REGPERS'
ALTER TABLE [dbo].[SIDEPS_13REGPERS]
ADD CONSTRAINT [FK__SIDEPS_CODCANT03_3]
    FOREIGN KEY ([CODCANT03])
    REFERENCES [dbo].[SIDEPS_03CATCANT]
        ([CODCANT03])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODCANT03_3'
CREATE INDEX [IX_FK__SIDEPS_CODCANT03_3]
ON [dbo].[SIDEPS_13REGPERS]
    ([CODCANT03]);
GO

-- Creating foreign key on [CODDIAC04] in table 'SIDEPS_07REGUSRO'
ALTER TABLE [dbo].[SIDEPS_07REGUSRO]
ADD CONSTRAINT [FK__SIDEPS_CODDIAC04]
    FOREIGN KEY ([CODDIAC04])
    REFERENCES [dbo].[SIDEPS_04REGDIAC]
        ([CODDIAC04])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODDIAC04'
CREATE INDEX [IX_FK__SIDEPS_CODDIAC04]
ON [dbo].[SIDEPS_07REGUSRO]
    ([CODDIAC04]);
GO

-- Creating foreign key on [CODUSRO05] in table 'SIDEPS_07REGUSRO'
ALTER TABLE [dbo].[SIDEPS_07REGUSRO]
ADD CONSTRAINT [FK__SIDEPS_CODUSRO05]
    FOREIGN KEY ([CODUSRO05])
    REFERENCES [dbo].[SIDEPS_05TIPUSRO]
        ([CODUSRO05])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODUSRO05'
CREATE INDEX [IX_FK__SIDEPS_CODUSRO05]
ON [dbo].[SIDEPS_07REGUSRO]
    ([CODUSRO05]);
GO

-- Creating foreign key on [CODESTC06] in table 'SIDEPS_13REGPERS'
ALTER TABLE [dbo].[SIDEPS_13REGPERS]
ADD CONSTRAINT [FK__SIDEPS_CODESTC06]
    FOREIGN KEY ([CODESTC06])
    REFERENCES [dbo].[SIDEPS_06CATESTC]
        ([CODESTC06])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODESTC06'
CREATE INDEX [IX_FK__SIDEPS_CODESTC06]
ON [dbo].[SIDEPS_13REGPERS]
    ([CODESTC06]);
GO

-- Creating foreign key on [CODESTC06] in table 'SIDEPS_22REGFAML'
ALTER TABLE [dbo].[SIDEPS_22REGFAML]
ADD CONSTRAINT [FK__SIDEPS_CODESTC06_02]
    FOREIGN KEY ([CODESTC06])
    REFERENCES [dbo].[SIDEPS_06CATESTC]
        ([CODESTC06])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODESTC06_02'
CREATE INDEX [IX_FK__SIDEPS_CODESTC06_02]
ON [dbo].[SIDEPS_22REGFAML]
    ([CODESTC06]);
GO

-- Creating foreign key on [CEDUSRO07] in table 'SIDEPS_08REGTELF'
ALTER TABLE [dbo].[SIDEPS_08REGTELF]
ADD CONSTRAINT [FK__SIDEPS_CEDUSRO07]
    FOREIGN KEY ([CEDUSRO07])
    REFERENCES [dbo].[SIDEPS_07REGUSRO]
        ([CEDUSRO07])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CEDUSRO07'
CREATE INDEX [IX_FK__SIDEPS_CEDUSRO07]
ON [dbo].[SIDEPS_08REGTELF]
    ([CEDUSRO07]);
GO

-- Creating foreign key on [CEDUSRO07] in table 'SIDEPS_25REGCASO'
ALTER TABLE [dbo].[SIDEPS_25REGCASO]
ADD CONSTRAINT [FK__SIDEPS_CEDUSRO07_03]
    FOREIGN KEY ([CEDUSRO07])
    REFERENCES [dbo].[SIDEPS_07REGUSRO]
        ([CEDUSRO07])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CEDUSRO07_03'
CREATE INDEX [IX_FK__SIDEPS_CEDUSRO07_03]
ON [dbo].[SIDEPS_25REGCASO]
    ([CEDUSRO07]);
GO

-- Creating foreign key on [CODNEDU09] in table 'SIDEPS_13REGPERS'
ALTER TABLE [dbo].[SIDEPS_13REGPERS]
ADD CONSTRAINT [FK__SIDEPS_CODNEDU09]
    FOREIGN KEY ([CODNEDU09])
    REFERENCES [dbo].[SIDEPS_09CATNEDU]
        ([CODNEDU09])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODNEDU09'
CREATE INDEX [IX_FK__SIDEPS_CODNEDU09]
ON [dbo].[SIDEPS_13REGPERS]
    ([CODNEDU09]);
GO

-- Creating foreign key on [CODNEDU09] in table 'SIDEPS_22REGFAML'
ALTER TABLE [dbo].[SIDEPS_22REGFAML]
ADD CONSTRAINT [FK__SIDEPS_CODNEDU09_02]
    FOREIGN KEY ([CODNEDU09])
    REFERENCES [dbo].[SIDEPS_09CATNEDU]
        ([CODNEDU09])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODNEDU09_02'
CREATE INDEX [IX_FK__SIDEPS_CODNEDU09_02]
ON [dbo].[SIDEPS_22REGFAML]
    ([CODNEDU09]);
GO

-- Creating foreign key on [CODSOLI10] in table 'SIDEPS_13REGPERS'
ALTER TABLE [dbo].[SIDEPS_13REGPERS]
ADD CONSTRAINT [FK__SIDEPS_CODSOLI10]
    FOREIGN KEY ([CODSOLI10])
    REFERENCES [dbo].[SIDEPS_10CATSOLI]
        ([CODSOLI10])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODSOLI10'
CREATE INDEX [IX_FK__SIDEPS_CODSOLI10]
ON [dbo].[SIDEPS_13REGPERS]
    ([CODSOLI10]);
GO

-- Creating foreign key on [CODRELG11] in table 'SIDEPS_13REGPERS'
ALTER TABLE [dbo].[SIDEPS_13REGPERS]
ADD CONSTRAINT [FK__SIDEPS_CODRELG11]
    FOREIGN KEY ([CODRELG11])
    REFERENCES [dbo].[SIDEPS_11CATRELG]
        ([CODRELG11])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODRELG11'
CREATE INDEX [IX_FK__SIDEPS_CODRELG11]
ON [dbo].[SIDEPS_13REGPERS]
    ([CODRELG11]);
GO

-- Creating foreign key on [CODPARE12] in table 'SIDEPS_22REGFAML'
ALTER TABLE [dbo].[SIDEPS_22REGFAML]
ADD CONSTRAINT [FK__SIDEPS_CODPARE12]
    FOREIGN KEY ([CODPARE12])
    REFERENCES [dbo].[SIDEPS_12CATPARE]
        ([CODPARE12])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODPARE12'
CREATE INDEX [IX_FK__SIDEPS_CODPARE12]
ON [dbo].[SIDEPS_22REGFAML]
    ([CODPARE12]);
GO

-- Creating foreign key on [CEDPERS13] in table 'SIDEPS_16REGASPS'
ALTER TABLE [dbo].[SIDEPS_16REGASPS]
ADD CONSTRAINT [FK__SIDEPS_CEDPERS13]
    FOREIGN KEY ([CEDPERS13])
    REFERENCES [dbo].[SIDEPS_13REGPERS]
        ([CEDPERS13])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CEDPERS13'
CREATE INDEX [IX_FK__SIDEPS_CEDPERS13]
ON [dbo].[SIDEPS_16REGASPS]
    ([CEDPERS13]);
GO

-- Creating foreign key on [CEDPERS13] in table 'SIDEPS_23CATFINA'
ALTER TABLE [dbo].[SIDEPS_23CATFINA]
ADD CONSTRAINT [FK__SIDEPS_CEDPERS13_02]
    FOREIGN KEY ([CEDPERS13])
    REFERENCES [dbo].[SIDEPS_13REGPERS]
        ([CEDPERS13])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CEDPERS13_02'
CREATE INDEX [IX_FK__SIDEPS_CEDPERS13_02]
ON [dbo].[SIDEPS_23CATFINA]
    ([CEDPERS13]);
GO

-- Creating foreign key on [CEDPERS13] in table 'SIDEPS_25REGCASO'
ALTER TABLE [dbo].[SIDEPS_25REGCASO]
ADD CONSTRAINT [FK__SIDEPS_CEDPERS13_03]
    FOREIGN KEY ([CEDPERS13])
    REFERENCES [dbo].[SIDEPS_13REGPERS]
        ([CEDPERS13])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CEDPERS13_03'
CREATE INDEX [IX_FK__SIDEPS_CEDPERS13_03]
ON [dbo].[SIDEPS_25REGCASO]
    ([CEDPERS13]);
GO

-- Creating foreign key on [CODSEGU14] in table 'SIDEPS_16REGASPS'
ALTER TABLE [dbo].[SIDEPS_16REGASPS]
ADD CONSTRAINT [FK__SIDEPS_CODSEGU14]
    FOREIGN KEY ([CODSEGU14])
    REFERENCES [dbo].[SIDEPS_14CATSEGU]
        ([CODSEGU14])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODSEGU14'
CREATE INDEX [IX_FK__SIDEPS_CODSEGU14]
ON [dbo].[SIDEPS_16REGASPS]
    ([CODSEGU14]);
GO

-- Creating foreign key on [CODENFR15] in table 'SIDEPS_16REGASPS'
ALTER TABLE [dbo].[SIDEPS_16REGASPS]
ADD CONSTRAINT [FK__SIDEPS_CODENFR15]
    FOREIGN KEY ([CODENFR15])
    REFERENCES [dbo].[SIDEPS_15CATENFR]
        ([CODENFR15])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODENFR15'
CREATE INDEX [IX_FK__SIDEPS_CODENFR15]
ON [dbo].[SIDEPS_16REGASPS]
    ([CODENFR15]);
GO

-- Creating foreign key on [CODENFR15] in table 'SIDEPS_22REGFAML'
ALTER TABLE [dbo].[SIDEPS_22REGFAML]
ADD CONSTRAINT [FK__SIDEPS_CODENFR15_02]
    FOREIGN KEY ([CODENFR15])
    REFERENCES [dbo].[SIDEPS_15CATENFR]
        ([CODENFR15])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODENFR15_02'
CREATE INDEX [IX_FK__SIDEPS_CODENFR15_02]
ON [dbo].[SIDEPS_22REGFAML]
    ([CODENFR15]);
GO

-- Creating foreign key on [CODASPS16] in table 'SIDEPS_25REGCASO'
ALTER TABLE [dbo].[SIDEPS_25REGCASO]
ADD CONSTRAINT [FK__SIDEPS_CODASPS16]
    FOREIGN KEY ([CODASPS16])
    REFERENCES [dbo].[SIDEPS_16REGASPS]
        ([CODASPS16])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODASPS16'
CREATE INDEX [IX_FK__SIDEPS_CODASPS16]
ON [dbo].[SIDEPS_25REGCASO]
    ([CODASPS16]);
GO

-- Creating foreign key on [CODMATE17] in table 'SIDEPS_20REGVIVI'
ALTER TABLE [dbo].[SIDEPS_20REGVIVI]
ADD CONSTRAINT [FK__SIDEPS_CODMATE17]
    FOREIGN KEY ([CODMATE17])
    REFERENCES [dbo].[SIDEPS_17CATMATE]
        ([CODMATE17])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODMATE17'
CREATE INDEX [IX_FK__SIDEPS_CODMATE17]
ON [dbo].[SIDEPS_20REGVIVI]
    ([CODMATE17]);
GO

-- Creating foreign key on [CODTIPV18] in table 'SIDEPS_20REGVIVI'
ALTER TABLE [dbo].[SIDEPS_20REGVIVI]
ADD CONSTRAINT [FK__SIDEPS_CODTIPV18]
    FOREIGN KEY ([CODTIPV18])
    REFERENCES [dbo].[SIDEPS_18TIPVIVI]
        ([CODTIPV18])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODTIPV18'
CREATE INDEX [IX_FK__SIDEPS_CODTIPV18]
ON [dbo].[SIDEPS_20REGVIVI]
    ([CODTIPV18]);
GO

-- Creating foreign key on [CODESTV19] in table 'SIDEPS_20REGVIVI'
ALTER TABLE [dbo].[SIDEPS_20REGVIVI]
ADD CONSTRAINT [FK__SIDEPS_CODESTV19]
    FOREIGN KEY ([CODESTV19])
    REFERENCES [dbo].[SIDEPS_19ESTVIVI]
        ([CODESTV19])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODESTV19'
CREATE INDEX [IX_FK__SIDEPS_CODESTV19]
ON [dbo].[SIDEPS_20REGVIVI]
    ([CODESTV19]);
GO

-- Creating foreign key on [CODVIVI20] in table 'SIDEPS_25REGCASO'
ALTER TABLE [dbo].[SIDEPS_25REGCASO]
ADD CONSTRAINT [FK__SIDEPS_CODVIVI20]
    FOREIGN KEY ([CODVIVI20])
    REFERENCES [dbo].[SIDEPS_20REGVIVI]
        ([CODVIVI20])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODVIVI20'
CREATE INDEX [IX_FK__SIDEPS_CODVIVI20]
ON [dbo].[SIDEPS_25REGCASO]
    ([CODVIVI20]);
GO

-- Creating foreign key on [CODORGS21] in table 'SIDEPS_22REGFAML'
ALTER TABLE [dbo].[SIDEPS_22REGFAML]
ADD CONSTRAINT [FK__SIDEPS_CODORGS21]
    FOREIGN KEY ([CODORGS21])
    REFERENCES [dbo].[SIDEPS_21CATORGS]
        ([CODORGS21])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODORGS21'
CREATE INDEX [IX_FK__SIDEPS_CODORGS21]
ON [dbo].[SIDEPS_22REGFAML]
    ([CODORGS21]);
GO

-- Creating foreign key on [CEDFAML22] in table 'SIDEPS_23CATFINA'
ALTER TABLE [dbo].[SIDEPS_23CATFINA]
ADD CONSTRAINT [FK__SIDEPS_CEDFAML22]
    FOREIGN KEY ([CEDFAML22])
    REFERENCES [dbo].[SIDEPS_22REGFAML]
        ([CEDFAML22])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CEDFAML22'
CREATE INDEX [IX_FK__SIDEPS_CEDFAML22]
ON [dbo].[SIDEPS_23CATFINA]
    ([CEDFAML22]);
GO

-- Creating foreign key on [CODEGRF24] in table 'SIDEPS_25REGCASO'
ALTER TABLE [dbo].[SIDEPS_25REGCASO]
ADD CONSTRAINT [FK__SIDEPS_CODEGRF24]
    FOREIGN KEY ([CODEGRF24])
    REFERENCES [dbo].[SIDEPS_24REGEGRF]
        ([CODEGRF24])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODEGRF24'
CREATE INDEX [IX_FK__SIDEPS_CODEGRF24]
ON [dbo].[SIDEPS_25REGCASO]
    ([CODEGRF24]);
GO

-- Creating foreign key on [CODCASO25] in table 'SIDEPS_27TIPAYUD'
ALTER TABLE [dbo].[SIDEPS_27TIPAYUD]
ADD CONSTRAINT [FK__SIDEPS_CODCASO25]
    FOREIGN KEY ([CODCASO25])
    REFERENCES [dbo].[SIDEPS_25REGCASO]
        ([CODCASO25])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODCASO25'
CREATE INDEX [IX_FK__SIDEPS_CODCASO25]
ON [dbo].[SIDEPS_27TIPAYUD]
    ([CODCASO25]);
GO

-- Creating foreign key on [CODCASO25] in table 'SIDEPS_28REGHIS'
ALTER TABLE [dbo].[SIDEPS_28REGHIS]
ADD CONSTRAINT [FK__SIDEPS_CODCASO25_02]
    FOREIGN KEY ([CODCASO25])
    REFERENCES [dbo].[SIDEPS_25REGCASO]
        ([CODCASO25])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODCASO25_02'
CREATE INDEX [IX_FK__SIDEPS_CODCASO25_02]
ON [dbo].[SIDEPS_28REGHIS]
    ([CODCASO25]);
GO

-- Creating foreign key on [CODAYUD26] in table 'SIDEPS_27TIPAYUD'
ALTER TABLE [dbo].[SIDEPS_27TIPAYUD]
ADD CONSTRAINT [FK__SIDEPS_CODAYUD26]
    FOREIGN KEY ([CODAYUD26])
    REFERENCES [dbo].[SIDEPS_26CATAYUD]
        ([CODAYUD26])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SIDEPS_CODAYUD26'
CREATE INDEX [IX_FK__SIDEPS_CODAYUD26]
ON [dbo].[SIDEPS_27TIPAYUD]
    ([CODAYUD26]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------