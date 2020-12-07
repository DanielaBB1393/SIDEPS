USE [SIDEPS]
GO
/****** Object:  StoredProcedure [dbo].[SP_CON_REGDIAC]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_CON_REGDIAC') IS NOT NULL DROP PROCEDURE SP_CON_REGDIAC
GO
CREATE PROCEDURE [dbo].[SP_CON_REGDIAC]
AS
BEGIN
SELECT * FROM [dbo].[SIDEPS_04REGDIAC]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CON_REGUSRO]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_CON_REGUSRO') IS NOT NULL DROP PROCEDURE SP_CON_REGUSRO
GO
CREATE PROCEDURE [dbo].[SP_CON_REGUSRO]
AS
BEGIN
SELECT * FROM [dbo].[SIDEPS_07REGUSRO]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONXID_REGDIAC]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_CONXID_REGDIAC') IS NOT NULL DROP PROCEDURE SP_CONXID_REGDIAC
GO
CREATE PROCEDURE [dbo].[SP_CONXID_REGDIAC]
@CODDIAC04 INT
AS
BEGIN
SELECT * FROM [dbo].[SIDEPS_04REGDIAC]
WHERE CODDIAC04 = @CODDIAC04
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONXID_REGUSRO]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_CONXID_REGUSRO') IS NOT NULL DROP PROCEDURE SP_CONXID_REGUSRO
GO
CREATE PROCEDURE [dbo].[SP_CONXID_REGUSRO]
@CEDUSRO07 INT
AS
BEGIN
SELECT * FROM [dbo].[SIDEPS_07REGUSRO]
WHERE CEDUSRO07 = @CEDUSRO07
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DEL_REGDIAC]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_DEL_REGDIAC') IS NOT NULL DROP PROCEDURE SP_DEL_REGDIAC
GO
CREATE PROCEDURE [dbo].[SP_DEL_REGDIAC]
@CODDIAC04 INT

AS
BEGIN
UPDATE SIDEPS_04REGDIAC
SET ESTDIAC04 = 'INACTIVO'
WHERE CODDIAC04 = @CODDIAC04

END
GO
/****** Object:  StoredProcedure [dbo].[SP_DEL_REGUSRO]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_DEL_REGUSRO') IS NOT NULL DROP PROCEDURE SP_DEL_REGUSRO
GO
CREATE PROCEDURE [dbo].[SP_DEL_REGUSRO]
@CEDUSRO07 VARCHAR(20)


AS
BEGIN
UPDATE SIDEPS_07REGUSRO
SET ESTUSRO07 = 'INACTIVO', FEFUSRO07 = GETDATE()
WHERE CEDUSRO07 = @CEDUSRO07

END
GO
/****** Object:  StoredProcedure [dbo].[SP_INS_REGASPS]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_INS_REGASPS') IS NOT NULL DROP PROCEDURE SP_INS_REGASPS
GO
CREATE PROCEDURE [dbo].[SP_INS_REGASPS]
		 @CEDPERS13 varchar(20)
		,@CODSEGU14 int
		,@CODENFR15 int
		,@DESENFR16 varchar(50)
		,@RECTRAT16 varchar(2)
		,@DESTRAT16 varchar(50)
AS
BEGIN
BEGIN TRY
	INSERT INTO dbo.SIDEPS_16REGASPS
    (
		 CEDPERS13
		,CODSEGU14
		,CODENFR15
		,DESENFR16
		,RECTRAT16
		,DESTRAT16
	)
    VALUES (
		 @CEDPERS13
		,@CODSEGU14
		,@CODENFR15
		,@DESENFR16
		,@RECTRAT16
		,@DESTRAT16
	)

	RETURN 0
END TRY
BEGIN CATCH
	RETURN -1
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INS_REGCASO]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_INS_REGCASO') IS NOT NULL DROP PROCEDURE SP_INS_REGCASO
GO
CREATE PROCEDURE [dbo].[SP_INS_REGCASO]
		 @CEDPERS13 varchar(20)
		,@CODASPS16 int
		,@CEDUSRO07 varchar(20)
		,@CODVIVI20 int
		,@CODEGRF24 int
		,@FEICASO25 datetime
		,@FEFCASO25 datetime
		,@DESCASO25 varchar(200)
		,@OPICASO25 varchar(200)
		,@ESTCASO25 varchar(20)
AS
BEGIN
BEGIN TRY
	INSERT INTO dbo.SIDEPS_25REGCASO
    (
		 CEDPERS13
		,CODASPS16
		,CEDUSRO07
		,CODVIVI20
		,CODEGRF24
		,FEICASO25
		,FEFCASO25
		,DESCASO25
		,OPICASO25
		,ESTCASO25
	)
    VALUES 
	(
		 @CEDPERS13
		,@CODASPS16
		,@CEDUSRO07
		,@CODVIVI20
		,@CODEGRF24
		,@FEICASO25
		,@FEFCASO25
		,@DESCASO25
		,@OPICASO25
		,@ESTCASO25
	)

	RETURN 0
END TRY
BEGIN CATCH
	RETURN -1
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INS_REGDIAC]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_INS_REGDIAC') IS NOT NULL DROP PROCEDURE SP_INS_REGDIAC
GO
CREATE  PROCEDURE [dbo].[SP_INS_REGDIAC]
@NOMDIAC04 VARCHAR(50),
@LUGDIAC04 VARCHAR(100),
@TELDIAC04 VARCHAR(12),
@CODCANT03 INT
AS
BEGIN

INSERT INTO SIDEPS_04REGDIAC ( NOMDIAC04 ,LUGDIAC04 ,TELDIAC04 ,ESTDIAC04,CODCANT03 )
VALUES (@NOMDIAC04 ,@LUGDIAC04 ,@TELDIAC04 ,'ACTIVO',@CODCANT03 )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INS_REGEGRF]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_INS_REGEGRF') IS NOT NULL DROP PROCEDURE SP_INS_REGEGRF
GO
CREATE PROCEDURE [dbo].[SP_INS_REGEGRF]
		 @MTOALQU24 decimal(18,4)
		,@MTOALIM24 decimal(18,4)
		,@MTOELEC24 decimal(18,4)
		,@MTOGAST24 decimal(18,4)
		,@MTCAGUA24 decimal(18,4)
		,@MTOCABL24 decimal(18,4)
		,@MTOTELF24 decimal(18,4)
		,@MTOINTE24 decimal(18,4)
		,@MTOEDUC24 decimal(18,4)
		,@MTOSEGU24 decimal(18,4)
		,@MTOOTRO24 decimal(18,4)
AS
BEGIN
BEGIN TRY
	INSERT INTO dbo.SIDEPS_24REGEGRF
    (
		 MTOALQU24
		,MTOALIM24
		,MTOELEC24
		,MTOGAST24
		,MTCAGUA24
		,MTOCABL24
		,MTOTELF24
		,MTOINTE24
		,MTOEDUC24
		,MTOSEGU24
		,MTOOTRO24
	)
    VALUES 
	(			
		 @MTOALQU24
		,@MTOALIM24
		,@MTOELEC24
		,@MTOGAST24
		,@MTCAGUA24
		,@MTOCABL24
		,@MTOTELF24
		,@MTOINTE24
		,@MTOEDUC24
		,@MTOSEGU24
		,@MTOOTRO24
	)

	RETURN 0
END TRY
BEGIN CATCH
	RETURN -1
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INS_REGFAML]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_INS_REGFAML') IS NOT NULL DROP PROCEDURE SP_INS_REGFAML
GO
CREATE PROCEDURE [dbo].[SP_INS_REGFAML]
		 @CEDFAML22 varchar(20)
		,@NOMFAML22 varchar(50)
		,@EDAFAML22 int
		,@CODESTC06 int
		,@CODNEDU09 int
		,@OACFAML22 varchar(100)
		,@INGFAML22 decimal(18,4)
		,@DESFAML22 varchar(200)
		,@CODORGS21 int
		,@CODENFR15 int
		,@CODPARE12 int
AS
BEGIN
BEGIN TRY
	INSERT INTO dbo.SIDEPS_22REGFAML
    (
		 CEDFAML22
		,NOMFAML22
		,EDAFAML22
		,CODESTC06
		,CODNEDU09
		,OACFAML22
		,INGFAML22
		,DESFAML22
		,CODORGS21
		,CODENFR15
		,CODPARE12
	)
    VALUES 
	(
		 @CEDFAML22
		,@NOMFAML22
		,@EDAFAML22
		,@CODESTC06
		,@CODNEDU09
		,@OACFAML22
		,@INGFAML22
		,@DESFAML22
		,@CODORGS21
		,@CODENFR15
		,@CODPARE12
	)

	RETURN 0
END TRY
BEGIN CATCH
	RETURN -1
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INS_REGPERS]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_INS_REGPERS') IS NOT NULL DROP PROCEDURE SP_INS_REGPERS
GO
CREATE PROCEDURE [dbo].[SP_INS_REGPERS]
		 @CEDPERS13 varchar(20)
		,@CODESTC06 int
		,@CODNEDU09 int
		,@CODCANT03 int
		,@CODSOLI10 int
		,@CODRELG11 int
		,@NOMPERS13 varchar(20)
		,@PAPPERS13 varchar(20)
		,@SAPPERS13 varchar(20)
		,@NACPERS13 varchar(50)
		,@DIRPERS13 varchar(200)
		,@OACPERS13 varchar(100)
		,@OANPERS13 varchar(100)
AS
BEGIN
BEGIN TRY
	INSERT INTO dbo.SIDEPS_13REGPERS
    (
		 CEDPERS13
        ,CODESTC06
        ,CODNEDU09
        ,CODCANT03
        ,CODSOLI10
        ,CODRELG11
        ,NOMPERS13
        ,PAPPERS13
        ,SAPPERS13
        ,NACPERS13
        ,DIRPERS13
        ,OACPERS13
        ,OANPERS13
	)
    VALUES
	(
		 @CEDPERS13
		,@CODESTC06
		,@CODNEDU09
		,@CODCANT03
		,@CODSOLI10
		,@CODRELG11
		,@NOMPERS13
		,@PAPPERS13
		,@SAPPERS13
		,@NACPERS13
		,@DIRPERS13
		,@OACPERS13
		,@OANPERS13
	)

	RETURN 0
END TRY
BEGIN CATCH
	RETURN -1
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INS_REGUSRO]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_INS_REGUSRO') IS NOT NULL DROP PROCEDURE SP_INS_REGUSRO
GO
CREATE  PROCEDURE [dbo].[SP_INS_REGUSRO]
@CEDUSRO07 VARCHAR(20),
@NOMUSRO07 VARCHAR(50),
@PAPUSRO07 VARCHAR(50),
@SAPUSRO07 VARCHAR(50),
@CODCANT03 INT,
@CODDIAC04 INT,
@CODUSRO05 INT,
@DIRUSRO07 VARCHAR(200),
@NACUSRO07 VARCHAR(15),
@CNTUSRO07 VARCHAR(30),
@FENUSRO07 DATETIME
AS
BEGIN

INSERT INTO SIDEPS_07REGUSRO
(CEDUSRO07,NOMUSRO07,PAPUSRO07,SAPUSRO07,CODCANT03,CODDIAC04,CODUSRO05,ESTUSRO07,DIRUSRO07,NACUSRO07,CNTUSRO07,FEIUSRO07,FEFUSRO07,FENUSRO07)
VALUES(
@CEDUSRO07, @NOMUSRO07, @PAPUSRO07, @SAPUSRO07,@CODCANT03, @CODDIAC04, @CODUSRO05,'ACTIVO', @DIRUSRO07, @NACUSRO07, @CNTUSRO07, GETDATE(), '9999-12-12',
@FENUSRO07)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INS_REGVIVI]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_INS_REGVIVI') IS NOT NULL DROP PROCEDURE SP_INS_REGVIVI
GO
CREATE PROCEDURE [dbo].[SP_INS_REGVIVI]
		 @CODTIPV18 int
        ,@CODESTV19 int
        ,@CODMATE17 int
        ,@MTOVIVI20 decimal(18,4)
        ,@NAPVIVI20 varchar(20)
        ,@SRCVIVI20 varchar(2)
        ,@SRIVIVI20 varchar(2)
        ,@SRLVIVI20 varchar(2)
        ,@SRMVIVI20 varchar(2)
        ,@SRBVIVI20 varchar(2)
        ,@SREVIVI20 varchar(2)
AS
BEGIN
BEGIN TRY
	INSERT INTO dbo.SIDEPS_20REGVIVI
    (
		 CODTIPV18
		,CODESTV19
		,CODMATE17
		,MTOVIVI20
		,NAPVIVI20
		,SRCVIVI20
		,SRIVIVI20
		,SRLVIVI20
		,SRMVIVI20
		,SRBVIVI20
		,SREVIVI20
	)
    VALUES (
		 @CODTIPV18
		,@CODESTV19
		,@CODMATE17
		,@MTOVIVI20
		,@NAPVIVI20
		,@SRCVIVI20
		,@SRIVIVI20
		,@SRLVIVI20
		,@SRMVIVI20
		,@SRBVIVI20
		,@SREVIVI20
	)

	RETURN 0
END TRY
BEGIN CATCH
	RETURN -1
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MOD_REGDIAC]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_MOD_REGDIAC') IS NOT NULL DROP PROCEDURE SP_MOD_REGDIAC
GO
CREATE PROCEDURE [dbo].[SP_MOD_REGDIAC]
@CODDIAC04 INT,
@NOMDIAC04 VARCHAR(50),
@LUGDIAC04 VARCHAR(100),
@TELDIAC04 VARCHAR(12),
@ESTDIAC04 VARCHAR(20),
@CODCANT03 INT
AS
BEGIN
UPDATE SIDEPS_04REGDIAC
SET NOMDIAC04 = @NOMDIAC04, LUGDIAC04 = @LUGDIAC04, TELDIAC04 = @TELDIAC04, ESTDIAC04 = @ESTDIAC04, CODCANT03 = @CODCANT03
WHERE CODDIAC04 = @CODDIAC04

END
GO
/****** Object:  StoredProcedure [dbo].[SP_MOD_REGUSRO]    Script Date: 11/13/2020 12:17:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF object_id('SP_MOD_REGUSRO') IS NOT NULL DROP PROCEDURE SP_MOD_REGUSRO
GO
CREATE PROCEDURE [dbo].[SP_MOD_REGUSRO]
@CEDUSRO07 VARCHAR(20),
@NOMUSRO07 VARCHAR(50),
@PAPUSRO07 VARCHAR(50),
@SAPUSRO07 VARCHAR(50),
@CODCANT03 INT,
@CODDIAC04 INT,
@CODUSRO05 INT,
@ESTUSRO07 VARCHAR(20),
@DIRUSRO07 VARCHAR(200),
@NACUSRO07 VARCHAR(15),
@CNTUSRO07 VARCHAR(30),
@FENUSRO07 DATETIME

AS
BEGIN
UPDATE SIDEPS_07REGUSRO
SET NOMUSRO07 = @NOMUSRO07, PAPUSRO07 = @PAPUSRO07, SAPUSRO07 = @SAPUSRO07,CODCANT03 = @CODCANT03,CODDIAC04=@CODDIAC04,CODUSRO05=@CODUSRO05,ESTUSRO07=@ESTUSRO07,
DIRUSRO07=@DIRUSRO07,NACUSRO07=@NACUSRO07,CNTUSRO07=@CNTUSRO07,FENUSRO07=@FENUSRO07
WHERE CEDUSRO07 = @CEDUSRO07

END
GO

IF object_id('SP_CON_CATRELG') IS NOT NULL DROP PROCEDURE SP_CON_CATRELG
GO
CREATE PROCEDURE [dbo].[SP_CON_CATRELG]
AS
BEGIN
SELECT * FROM [dbo].[SIDEPS_11CATRELG]
END
GO

--estadocivil
IF object_id('SP_CON_CATESTC') IS NOT NULL DROP PROCEDURE SP_CON_CATESTC
GO
CREATE PROCEDURE [dbo].[SP_CON_CATESTC]
AS
BEGIN
SELECT * FROM [dbo].[SIDEPS_06CATESTC]
END
GO

--escolaridad
IF object_id('SP_CON_CATNEDU') IS NOT NULL DROP PROCEDURE SP_CON_CATNEDU
GO
CREATE PROCEDURE [dbo].[SP_CON_CATNEDU]
AS
BEGIN
SELECT * FROM [dbo].[SIDEPS_09CATNEDU]
END
GO

--canton
IF object_id('SP_CON_CATCANT') IS NOT NULL DROP PROCEDURE SP_CON_CATCANT
GO
CREATE PROCEDURE [dbo].[SP_CON_CATCANT]
AS
BEGIN
SELECT * FROM [dbo].[SIDEPS_03CATCANT]
END
GO

-- consulta grupo familiar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF object_id('SP_CON_REGFAML') IS NOT NULL DROP PROCEDURE SP_CON_REGFAML
GO
CREATE PROCEDURE [dbo].[SP_CON_REGFAML](
	@cedulaSolicitante varchar(20)
)
AS
BEGIN
SELECT 
		t22.* 
FROM 
		[dbo].[SIDEPS_22REGFAML] t22
		INNER JOIN [dbo].[SIDEPS_23CATFINA] t23 on
				t22.CEDFAML22 = t23.CEDFAML22

WHERE
		t23.CEDPERS13 = @cedulaSolicitante
END

-- consulta miembro familiar por ID
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF object_id('SP_CONXID_REGFAML') IS NOT NULL DROP PROCEDURE SP_CONXID_REGFAML
GO
CREATE PROCEDURE [dbo].[SP_CONXID_REGFAML](
	@cedula varchar(20)
)
AS
BEGIN
SELECT 
		* 
FROM 
		[dbo].[SIDEPS_22REGFAML]

WHERE
		 CEDFAML22 = @cedula
END
GO

-- MISCELANEOS --
-----------------

--SELECT(OBJECT_ID('SP_CON_CATPAIS'))

IF OBJECT_ID('SP_CON_CATPAIS') IS NOT NULL
	DROP PROCEDURE SP_CON_CATPAIS
GO 
CREATE PROCEDURE [dbo].[SP_CON_CATPAIS] AS
BEGIN
	SELECT * FROM [SIDEPS_01CATPAIS]
END
GO


IF OBJECT_ID('SP_CON_CATPROV') IS NOT NULL
	DROP PROCEDURE SP_CON_CATPROV
GO 
CREATE PROCEDURE [dbo].[SP_CON_CATPROV] AS
BEGIN
	SELECT * FROM [SIDEPS_02CATPROV]
END
GO


IF OBJECT_ID('SP_CON_TIPUSRO') IS NOT NULL
	DROP PROCEDURE SP_CON_TIPUSRO
GO 
CREATE PROCEDURE [dbo].[SP_CON_TIPUSRO] AS
BEGIN
	SELECT * FROM [SIDEPS_05TIPUSRO]
END
GO


IF OBJECT_ID('SP_CON_CATESTC') IS NOT NULL
	DROP PROCEDURE SP_CON_CATESTC
GO 
CREATE PROCEDURE [dbo].[SP_CON_CATESTC] AS
BEGIN
	SELECT * FROM [SIDEPS_06CATESTC]
END
GO


IF OBJECT_ID('SP_CON_CATSOLI') IS NOT NULL
	DROP PROCEDURE SP_CON_CATSOLI
GO 
CREATE PROCEDURE [dbo].[SP_CON_CATSOLI] AS
BEGIN
	SELECT * FROM [SIDEPS_10CATSOLI]
END
GO


IF OBJECT_ID('SP_CON_CATPARE') IS NOT NULL
	DROP PROCEDURE SP_CON_CATPARE
GO 
CREATE PROCEDURE [dbo].[SP_CON_CATPARE] AS
BEGIN
	SELECT * FROM [SIDEPS_12CATPARE]
END
GO


IF OBJECT_ID('SP_CON_CATSEGU') IS NOT NULL
	DROP PROCEDURE SP_CON_CATSEGU
GO 
CREATE PROCEDURE [dbo].[SP_CON_CATSEGU] AS
BEGIN
	SELECT * FROM [SIDEPS_14CATSEGU]
END
GO

IF OBJECT_ID('SP_CON_CATENFR') IS NOT NULL
	DROP PROCEDURE SP_CON_CATENFR
GO 
CREATE PROCEDURE [dbo].[SP_CON_CATENFR] AS
BEGIN
	SELECT * FROM [SIDEPS_15CATENFR]
END
GO

IF OBJECT_ID('SP_CON_CATMATE') IS NOT NULL
	DROP PROCEDURE SP_CON_CATMATE
GO 
CREATE PROCEDURE [dbo].[SP_CON_CATMATE] AS
BEGIN
	SELECT * FROM [SIDEPS_17CATMATE]
END
GO


IF OBJECT_ID('SP_CON_TIPVIVI') IS NOT NULL
	DROP PROCEDURE SP_CON_TIPVIVI
GO 
CREATE PROCEDURE [dbo].[SP_CON_TIPVIVI] AS
BEGIN
	SELECT * FROM [SIDEPS_18TIPVIVI]
END
GO


IF OBJECT_ID('SP_CON_ESTVIVI') IS NOT NULL
	DROP PROCEDURE SP_CON_ESTVIVI
GO 
CREATE PROCEDURE [dbo].[SP_CON_ESTVIVI] AS
BEGIN
	SELECT * FROM [SIDEPS_19ESTVIVI]
END
GO


IF OBJECT_ID('SP_CON_CATORGS') IS NOT NULL
	DROP PROCEDURE SP_CON_CATORGS
GO 
CREATE PROCEDURE [dbo].[SP_CON_CATORGS] AS
BEGIN
	SELECT * FROM [SIDEPS_21CATORGS]
END
GO


IF OBJECT_ID('SP_CON_CATAYUD') IS NOT NULL
	DROP PROCEDURE SP_CON_CATAYUD
GO 
CREATE PROCEDURE [dbo].[SP_CON_CATAYUD] AS
BEGIN
	SELECT * FROM [SIDEPS_26CATAYUD]
END
GO


IF OBJECT_ID('SP_CON_TIPAYUD') IS NOT NULL
	DROP PROCEDURE SP_CON_TIPAYUD
GO 
CREATE PROCEDURE [dbo].[SP_CON_TIPAYUD] AS
BEGIN
	SELECT * FROM [SIDEPS_27TIPAYUD]
END
GO


-- END MISCELANEOS --
---------------------


-- Historicos de casos --
-------------------------

IF OBJECT_ID('SP_CON_HISTCASOS') IS NOT NULL
	DROP PROCEDURE SP_CON_HISTCASOS
GO 
CREATE PROCEDURE [dbo].[SP_CON_HISTCASOS](
	@diaconia int
)
AS
BEGIN

SELECT 
		CASO.CEDPERS13,
		CASO.CEDUSRO07,
		CASO.CODCASO25,
		CASO.FEICASO25,
		CASO.FEFCASO25,
		CASO.DESCASO25,
		CASO.OPICASO25,
		CASO.ESTCASO25,
		USRS.NOMUSRO07,
		USRS.PAPUSRO07,
		PERS.NOMPERS13,
		PERS.PAPPERS13
FROM 
		SIDEPS_04REGDIAC DIAC
		INNER JOIN SIDEPS_07REGUSRO USRS ON
				DIAC.CODDIAC04 = USRS.CODDIAC04
		INNER JOIN dbo.SIDEPS_25REGCASO CASO ON
				CASO.CEDUSRO07 = USRS.CEDUSRO07
		INNER JOIN dbo.SIDEPS_13REGPERS PERS ON
				CASO.CEDPERS13 = PERS.CEDPERS13
WHERE
		1=1
		AND DIAC.CODDIAC04 = @diaconia
END
GO

---------------------------------detalle de persona
IF OBJECT_ID('DETPERS') IS NOT NULL
	DROP PROCEDURE DETPERS
GO 
CREATE PROCEDURE DETPERS
@CODCASO25 INT
AS
BEGIN
SELECT 
	P.CEDPERS13,
	P.NOMPERS13,
	P.PAPPERS13,
	P.SAPPERS13,
	EST.DESESTC06,
	CAN.NOMCANT03,
	SOL.DESSOLI10,
	REL.DESRELG11,
	P.NACPERS13,
	P.DIRPERS13,
	P.OACPERS13,
	P.OANPERS13,
	P.FENPERS13 
FROM SIDEPS_13REGPERS AS P
JOIN SIDEPS_06CATESTC AS EST ON P.CODESTC06=EST.CODESTC06
JOIN SIDEPS_03CATCANT AS CAN ON CAN.CODCANT03=P.CODCANT03
JOIN SIDEPS_10CATSOLI AS SOL ON SOL.CODSOLI10=P.CODSOLI10
JOIN SIDEPS_11CATRELG AS REL ON REL.CODRELG11=P.CODRELG11
JOIN SIDEPS_25REGCASO AS CAS ON CAS.CEDPERS13=P.CEDPERS13
WHERE CAS.CODCASO25=@CODCASO25
END
GO

-----------------------------aspecto salud
IF OBJECT_ID('DETASPS') IS NOT NULL
	DROP PROCEDURE DETASPS
GO 
CREATE PROCEDURE DETASPS
@CODCASO25 INT
AS
BEGIN
SELECT 
		ASP.DESENFR16, 
		ASP.RECTRAT16,
		ASP.DESTRAT16,
		ENF.DESENFR15,
		SEG.DESSEGU14
FROM SIDEPS_16REGASPS ASP
LEFT JOIN SIDEPS_15CATENFR AS ENF ON ENF.CODENFR15=ASP.CODENFR15
JOIN SIDEPS_14CATSEGU AS SEG ON SEG.CODSEGU14=ASP.CODSEGU14
JOIN SIDEPS_25REGCASO  AS CAS ON CAS.CEDPERS13=ASP.CEDPERS13
WHERE CAS.CODCASO25=@CODCASO25
END
GO

--------------------------DETALLE VIVIENDA
IF OBJECT_ID('DETVIVI') IS NOT NULL
	DROP PROCEDURE DETVIVI
GO 
CREATE PROCEDURE DETVIVI
@CODCASO25 INT
AS
BEGIN
SELECT 
		VIV.MTOVIVI20,
		VIV.NAPVIVI20,
		VIV.SRCVIVI20,
		VIV.SRIVIVI20,
		VIV.SRLVIVI20,
		VIV.SRMVIVI20,
		VIV.SRBVIVI20,
		VIV.SREVIVI20,
		TPV.DESTIPV18,
		ESV.DESESTV19,
		MAT.DESMATE17
FROM SIDEPS_20REGVIVI AS VIV
JOIN SIDEPS_18TIPVIVI AS TPV ON TPV.CODTIPV18=VIV.CODTIPV18
JOIN SIDEPS_19ESTVIVI AS ESV ON ESV.CODESTV19=VIV.CODESTV19
JOIN SIDEPS_17CATMATE AS MAT ON MAT.CODMATE17=VIV.CODMATE17
JOIN SIDEPS_25REGCASO AS CAS ON CAS.CODVIVI20=VIV.CODVIVI20
WHERE CAS.CODCASO25=@CODCASO25
END
GO

-------------------DETALLE  EGRESO
IF OBJECT_ID('DETEGRF') IS NOT NULL
	DROP PROCEDURE DETEGRF
GO 
CREATE PROCEDURE DETEGRF
@CODCASO25 INT
AS
BEGIN
SELECT 
		EGR.MTOALQU24,
		EGR.MTOALIM24,
		EGR.MTOELEC24,
		EGR.MTOGAST24,
		EGR.MTCAGUA24,
		EGR.MTOCABL24,
		EGR.MTOTELF24,
		EGR.MTOINTE24,
		EGR.MTOEDUC24,
		EGR.MTOSEGU24,
		EGR.MTOOTRO24

FROM SIDEPS_24REGEGRF AS EGR
JOIN SIDEPS_25REGCASO AS CAS ON CAS.CODEGRF24=EGR.CODEGRF24
WHERE CAS.CODCASO25=@CODCASO25
END
GO

------------------DETALLE OPINION CASO
IF OBJECT_ID('DETCASO') IS NOT NULL
	DROP PROCEDURE DETCASO
GO 
CREATE PROCEDURE DETCASO
@CODCASO25 INT
AS
BEGIN
SELECT CAS.OPICASO25 FROM SIDEPS_25REGCASO  AS CAS
WHERE CAS.CODCASO25=@CODCASO25
END
GO

------------------DETALLE DE FAMILIA
IF OBJECT_ID('DETFAML') IS NOT NULL
	DROP PROCEDURE DETFAML
GO 
CREATE PROCEDURE DETFAML
@CODCASO25 INT
AS
BEGIN
SELECT 
       FAM.CEDFAML22,
	   FAM.NOMFAML22,
	   FAM.EDAFAML22,
	   FAM.OACFAML22,
	   FAM.INGFAML22,
	   FAM.DESFAML22,
	   EST.DESESTC06,
	   EDU.DESNEDU09,
	   ORG.DESORGS21,
	   ENF.DESENFR15,
	   PAR.DESPARE12,
	   FIN.CEDPERS13
FROM SIDEPS_22REGFAML AS FAM
JOIN SIDEPS_06CATESTC AS EST ON EST.CODESTC06=FAM.CODESTC06
JOIN SIDEPS_09CATNEDU AS EDU ON EDU.CODNEDU09=FAM.CODNEDU09
JOIN SIDEPS_21CATORGS AS ORG ON ORG.CODORGS21=FAM.CODORGS21
JOIN SIDEPS_15CATENFR AS ENF ON ENF.CODENFR15=FAM.CODENFR15
JOIN SIDEPS_12CATPARE AS PAR ON PAR.CODPARE12=FAM.CODPARE12
JOIN SIDEPS_23CATFINA AS FIN ON FIN.CEDFAML22=FAM.CEDFAML22 
JOIN SIDEPS_13REGPERS AS PER ON PER.CEDPERS13=FIN.CEDPERS13
JOIN SIDEPS_25REGCASO AS CAS ON CAS.CEDPERS13=PER.CEDPERS13
WHERE CAS.CODCASO25=@CODCASO25
END
GO


IF OBJECT_ID('SP_CON_CATCASOAY') IS NOT NULL
	DROP PROCEDURE SP_CON_CATCASOAY
GO 
CREATE PROCEDURE SP_CON_CATCASOAY
@CODCASO25 INT
AS
BEGIN
SELECT CA.CODAYUD26
      ,CA.DESAYUD26
  FROM SIDEPS_26CATAYUD AS CA
  JOIN SIDEPS_27TIPAYUD AS TA ON CA.CODAYUD26=TA.CODAYUD26
  JOIN SIDEPS_25REGCASO AS CAS ON CAS.CODCASO25=TA.CODCASO25
WHERE CAS.CODCASO25=@CODCASO25
END
GO

IF OBJECT_ID('SP_CON_CASOXID') IS NOT NULL
	DROP PROCEDURE SP_CON_CASOXID
GO 
CREATE PROCEDURE SP_CON_CASOXID
@CODCASO25 INT
AS
BEGIN
SELECT 
		*
FROM
		SIDEPS_25REGCASO
WHERE
		CODCASO25 = @CODCASO25
END
GO


IF OBJECT_ID('SP_CON_USROXCED') IS NOT NULL
	DROP PROCEDURE SP_CON_USROXCED
GO 
CREATE PROCEDURE SP_CON_USROXCED
@CEDUSRO07 VARCHAR(20)
AS
BEGIN
SELECT 
		*
FROM
		SIDEPS_07REGUSRO
WHERE
		CEDUSRO07 = @CEDUSRO07
END
GO