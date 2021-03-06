USE [Org]
GO
/****** Объект:  UserDefinedFunction [dbo].[fun_AbnObj_Month_Value_X5]    Дата сценария: 08/09/2010 22:29:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[fun_AbnObj_X7]
(	
	@Date datetime
)
RETURNS TABLE 
AS
RETURN 
(
SELECT  
		SUBSTRING('0000', 1, 4 - LEN(tblAbn.Code)) + CAST(tblAbn.Code AS varchar) AS Code,  
		tblAbn.AbnID, 
		tblAbn.NameShort, 
		-- ROW_NUMBER() OVER(PARTITION by tblAbn.AbnID Order BY tblAbn.AbnID, tblAbnObj.AbnObjID ASC) AS 'Row Number',
        Cast(tblAbn.AbnID as varchar) + '_'+ Cast(ROW_NUMBER() OVER(PARTITION by tblAbn.AbnID Order BY tblAbn.AbnID, tblAbnObj.AbnObjID ASC) as varchar) AS 'Row Number',
		tblAbnObj.AbnObjID, 
		tblAbnObj.Title, 
		tbl_Tariff.Voltage 
		-- ,IsNull(dd.[Sum-Quantity], 0) AS [Sum-Quantity]
		, tblAbnObj.Categor [Категория],  
		tblAbnObj.Power [Установленная мощность], 
		'' [Точка подключения (отключения)],
		tbl_SalesCompany.TitleCompany [Э/с компания]
FROM (tblAbn INNER JOIN tblAbnObj 
	ON tblAbn.AbnID = tblAbnObj.AbnID) INNER JOIN tbl_Tariff 
	ON tblAbnObj.idTariff = tbl_Tariff.idTariff
	left join 
	(
		SELECT tbl_DocSchet.idAbnObj, Sum(tbl_DocSchet.Quantity) AS [Sum-Quantity]
		FROM tblAbn 
			INNER JOIN (tbl_Doc INNER JOIN tbl_DocSchet ON tbl_Doc.idDoc = tbl_DocSchet.idDoc) 
				ON tblAbn.AbnID = tbl_Doc.idAbn
		WHERE --tbl_Doc.dtPay Between '2010-06-01' And '2010-06-30' 
			Month(tbl_Doc.dtPay) = Month(@Date)
			and Year(tbl_Doc.dtPay) = Year(@Date)
					
							 and  (tbl_Doc.dtPay <= @Date)		
		AND tbl_Doc.IsDoc<>0 
		AND tbl_DocSchet.Type1=0 
		AND tbl_DocSchet.Type2 In (1,4,5) AND tbl_DocSchet.Summa<>0 -- 1,
		GROUP BY tbl_DocSchet.idAbnObj		
	) dd on tblAbnObj.AbnObjID = dd.idAbnObj
	left join tbl_SalesCompany on tbl_SalesCompany.NumberCompany = tblAbnObj.[FactDiv]
WHERE -- tblAbn.Code < 9003 
 
-- tblAbnObj.deleted <> 1 and tblAbn.deleted <> 1
-- and tblAbnObj.TranspFlag = 1 and tblAbnObj.ActEngFlag = 1

-- and tblAbn.Code = 34 -- and tblAbnObj.CodeObj = 126 
-- and tblAbn.Code = 9002 -- and tblAbnObj.CodeObj = 126 
-- tblAbn.Code = 34 and
 (((
		  Case 
				When tblAbnObj.CodeSub <> 0 and dd.[Sum-Quantity]<>0 Then 1
				When tblAbnObj.CodeSub = 0 Then 1
				Else 0
		  End
		  ) = 1)
)
and  [Sum-Quantity] <> 0 
--ORDER BY tblAbn.Code, tblAbnObj.Title;
)
