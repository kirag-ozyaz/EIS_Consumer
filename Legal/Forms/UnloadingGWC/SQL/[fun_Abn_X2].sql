USE [Org]
GO
/****** Объект:  UserDefinedFunction [dbo].[fun_Abn_X2]    Дата сценария: 08/10/2010 02:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[fun_Abn_X2]
(	
	@Year int
)
RETURNS TABLE 
AS
RETURN 
(
SELECT     SUBSTRING('0000', 1, 4 - LEN(dbo.tblAbn.Code)) + CAST(dbo.tblAbn.Code AS varchar) AS Code, 
dbo.tblAbn.AbnID, 
--dbo.tblAbn.NameShort, '' AS Napruga, 
                     -- '' AS Tarif, 
Sum(dbo.tblAbnLimit.Month01) Month01, Sum(dbo.tblAbnLimit.Month02) Month02, Sum(dbo.tblAbnLimit.Month03) Month03, Sum(dbo.tblAbnLimit.Month04) Month04, Sum(dbo.tblAbnLimit.Month05) Month05, 
Sum(dbo.tblAbnLimit.Month06) Month06, Sum(dbo.tblAbnLimit.Month07) Month07, Sum(dbo.tblAbnLimit.Month08) Month08, Sum(dbo.tblAbnLimit.Month09) Month09, Sum(dbo.tblAbnLimit.Month10) Month10, 
Sum(dbo.tblAbnLimit.Month11) Month11, Sum(dbo.tblAbnLimit.Month12) Month12

,Sum(dbo.tblAbnLimit.Month01+ dbo.tblAbnLimit.Month02+ dbo.tblAbnLimit.Month03+ dbo.tblAbnLimit.Month04+ dbo.tblAbnLimit.Month05+ 
dbo.tblAbnLimit.Month06+ dbo.tblAbnLimit.Month07+ dbo.tblAbnLimit.Month08+ dbo.tblAbnLimit.Month09+ dbo.tblAbnLimit.Month10+ 
dbo.tblAbnLimit.Month11+ dbo.tblAbnLimit.Month12) [Всего]

, 50 AS Pay1, 30 AS Pay2, 20 AS Pay3, 15 AS LastPay
FROM         dbo.tblAbn LEFT OUTER JOIN
                      dbo.tblAbnLimit ON dbo.tblAbn.AbnID = dbo.tblAbnLimit.AbnID
WHERE     (dbo.tblAbn.Deleted = 0)AND (dbo.tblAbnLimit.Year = @Year)
group by SUBSTRING('0000', 1, 4 - LEN(dbo.tblAbn.Code)) + CAST(dbo.tblAbn.Code AS varchar)
			, dbo.tblAbn.AbnID
-- AND (dbo.tblAbnLimit.Year = 2010)

)
