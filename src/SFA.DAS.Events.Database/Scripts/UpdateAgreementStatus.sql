BEGIN TRANSACTION [Tran1]
BEGIN TRY

UPDATE [SFA.DAS.Events.Database].[dbo].[ApprenticeshipEvents]
SET [AgreementStatus]='0'
WHERE [AgreementStatus]='NotAgreed'

UPDATE [SFA.DAS.Events.Database].[dbo].[ApprenticeshipEvents]
SET [AgreementStatus]='1'
WHERE [AgreementStatus]='EmployerAgreed'

UPDATE [SFA.DAS.Events.Database].[dbo].[ApprenticeshipEvents]
SET [AgreementStatus]='2'
WHERE [AgreementStatus]='ProviderAgreed'

UPDATE [SFA.DAS.Events.Database].[dbo].[ApprenticeshipEvents]
SET [AgreementStatus]='3'
WHERE [AgreementStatus]='BothAgreed'

ALTER TABLE [SFA.DAS.Events.Database].[dbo].[ApprenticeshipEvents] ALTER COLUMN AgreementStatus SMALLINT NOT NULL

COMMIT TRANSACTION [Tran1]
END TRY
BEGIN CATCH
  ROLLBACK TRANSACTION [Tran1]
END CATCH  

GO