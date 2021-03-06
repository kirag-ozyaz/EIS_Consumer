USE [Org]
GO
/****** Объект:  UserDefinedFunction [dbo].[fun_Abn_Value_X4]    Дата сценария: 08/10/2010 01:51:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION  [dbo].[fun_Abn_Value_X4]
(	
	@DateBegin datetime, 
	@DateEnd datetime
)
RETURNS TABLE 
AS
RETURN 
(
		SELECT     SUBSTRING('0000', 1, 4 - LEN(tblAbn.Code)) + CAST(tblAbn.Code AS varchar) AS Code,  
					tblAbn.AbnID, 
					tblAbn.NameShort [Наименование],
					Sum([Quantity]) as [Потребление, кВт]
					
		FROM         tblAbn INNER JOIN
							  tbl_Doc INNER JOIN
							  tbl_DocSchet ON tbl_Doc.idDoc = tbl_DocSchet.idDoc ON tblAbn.AbnID = tbl_Doc.idAbn
		WHERE    
			(tbl_Doc.dtPay >=
				 (Convert(datetime, 
							Cast(Year (Convert(datetime, @DateBegin, 102))as varchar)+'-'+
							Cast(Month(Convert(datetime, @DateBegin, 102))as varchar)+'-1',102)) and 
				tbl_Doc.dtPay < (Convert(datetime, 
							Cast(Year (DATEADD(month,1,Convert(datetime, @DateEnd, 102)))as varchar)+'-'+
							Cast(Month(DATEADD(month,1,Convert(datetime, @DateEnd, 102)))as varchar)+'-1',102))) 



							 AND (tbl_Doc.IsDoc <> 0) -- наличие документа
							 AND (tbl_DocSchet.Type1 = 0) 
							 AND (tbl_DocSchet.Type2 = 4 OR
							 tbl_DocSchet.Type2 = 5 or
							 tbl_DocSchet.Type2 = 1) -- электроэнергия, бездоговорные
							 AND (tbl_DocSchet.Summa <> 0)
							 
		GROUP BY tblAbn.AbnID, tblAbn.Code, tblAbn.NameShort--, ((tbl_Doc.SumRealiz + tbl_Doc.SumNalog + tbl_Doc.SumPeni)/1000)


--ORDER BY tblAbn.Code
)

