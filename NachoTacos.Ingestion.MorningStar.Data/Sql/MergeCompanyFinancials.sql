/****** Object:  StoredProcedure [dbo].[MergeCompanyFinancials]    Script Date: 1/9/2020 5:02:15 PM ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'MergeCompanyFinancials')
DROP PROCEDURE [dbo].[MergeCompanyFinancials]
GO

/****** Object:  StoredProcedure [dbo].[MergeCompanyFinancials]    Script Date: 1/9/2020 5:02:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Kevin Wu
-- Create date: 6th Jan 2020
-- Description:	Merge data from temporary job table [MStar].[TCompanyFinancialAvailability]
--				to master table [MStar].[MCompanyFinancialAvailability]
-- Example: EXECUTE MergeCompanyFinancials @TaskId='83156B67-F362-42C9-8E43-A9663FBA7E8E'
-- =============================================
CREATE PROCEDURE MergeCompanyFinancials
	-- Add the parameters for the stored procedure here
	@TaskId AS UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @SummaryOfChanges TABLE(Change VARCHAR(20));

	MERGE INTO [MStar].[MCompanyFinancialAvailability] AS TargetTable
	USING
	(SELECT [CompanyName]
      ,[ExchangeId]
      ,[Symbol]
      ,[CUSIP]
      ,[CIK]
      ,[ISIN]
      ,[SEDOL]
      ,[Start]
      ,[End]
      ,[SectorId]
      ,[SectorName]
      ,[IndustryGroupId]
      ,[IndustryGroupName]
      ,[IndustryId]
      ,[IndustryName]
      ,[LatestQuarterlyReportDate]
      ,[LatestAnnualReportDate]
      ,[LatestPreliminaryReportDate]
      ,[LatestSemiAnnualReportDate]
      ,[TemplateCode]
      ,[GlobalTemplateCode]
	  FROM [MStar].[TCompanyFinancialAvailability]
	  WHERE IngestionTaskId = @TaskId)
	  AS SourceTable (
      [CompanyName]
      ,[ExchangeId]
      ,[Symbol]
      ,[CUSIP]
      ,[CIK]
      ,[ISIN]
      ,[SEDOL]
      ,[Start]
      ,[End]
      ,[SectorId]
      ,[SectorName]
      ,[IndustryGroupId]
      ,[IndustryGroupName]
      ,[IndustryId]
      ,[IndustryName]
      ,[LatestQuarterlyReportDate]
      ,[LatestAnnualReportDate]
      ,[LatestPreliminaryReportDate]
      ,[LatestSemiAnnualReportDate]
      ,[TemplateCode]
      ,[GlobalTemplateCode])
	ON TargetTable.[ExchangeId] = SourceTable.[ExchangeId]
	AND TargetTable.[Symbol] = SourceTable.[Symbol]

	WHEN MATCHED THEN
	UPDATE  
	SET [CompanyName] = SourceTable.[CompanyName]
      ,[CUSIP] = SourceTable.[CUSIP]
      ,[CIK] = SourceTable.[CIK]
      ,[ISIN] = SourceTable.[ISIN]
      ,[SEDOL] = SourceTable.[SEDOL]
      ,[Start] = SourceTable.[Start]
      ,[End] = SourceTable.[End]
      ,[SectorId] = SourceTable.[SectorId]
      ,[SectorName] = SourceTable.[SectorName]
      ,[IndustryGroupId] = SourceTable.[IndustryGroupId]
      ,[IndustryGroupName] = SourceTable.[IndustryGroupName]
      ,[IndustryId] = SourceTable.[IndustryId]
      ,[IndustryName] = SourceTable.[IndustryName]
      ,[LatestQuarterlyReportDate] = SourceTable.[LatestQuarterlyReportDate]
      ,[LatestAnnualReportDate] = SourceTable.[LatestAnnualReportDate]
      ,[LatestPreliminaryReportDate] = SourceTable.[LatestPreliminaryReportDate]
      ,[LatestSemiAnnualReportDate] = SourceTable.[LatestSemiAnnualReportDate]
      ,[TemplateCode] = SourceTable.[TemplateCode]
      ,[GlobalTemplateCode] = SourceTable.[GlobalTemplateCode]
	  ,[UpdatedDate] = GETUTCDATE()

	WHEN NOT MATCHED BY TARGET THEN
	INSERT(
      [MCompanyFinancialAvailabilityId]
      ,[CreatedDate]
      ,[UpdatedDate]
      ,[CompanyName]
      ,[ExchangeId]
      ,[Symbol]
      ,[CUSIP]
      ,[CIK]
      ,[ISIN]
      ,[SEDOL]
      ,[Start]
      ,[End]
      ,[SectorId]
      ,[SectorName]
      ,[IndustryGroupId]
      ,[IndustryGroupName]
      ,[IndustryId]
      ,[IndustryName]
      ,[LatestQuarterlyReportDate]
      ,[LatestAnnualReportDate]
      ,[LatestPreliminaryReportDate]
      ,[LatestSemiAnnualReportDate]
      ,[TemplateCode]
      ,[GlobalTemplateCode]) 
	VALUES (NEWID()
		   ,GETUTCDATE()
		   ,GETUTCDATE()
		   ,[CompanyName]
          ,[ExchangeId]
          ,[Symbol]
          ,[CUSIP]
          ,[CIK]
          ,[ISIN]
          ,[SEDOL]
          ,[Start]
          ,[End]
          ,[SectorId]
          ,[SectorName]
          ,[IndustryGroupId]
          ,[IndustryGroupName]
          ,[IndustryId]
          ,[IndustryName]
          ,[LatestQuarterlyReportDate]
          ,[LatestAnnualReportDate]
          ,[LatestPreliminaryReportDate]
          ,[LatestSemiAnnualReportDate]
          ,[TemplateCode]
          ,[GlobalTemplateCode])
	OUTPUT $action INTO @SummaryOfChanges;

	UPDATE [dbo].[IngestionTasks]
	SET IsProcessed = 1
	WHERE IngestionTaskId = @TaskId;

	-- Query the results of the table variable.  
	SELECT Change, COUNT(*) AS CountPerChange  
	FROM @SummaryOfChanges  
	GROUP BY Change;

END
GO
