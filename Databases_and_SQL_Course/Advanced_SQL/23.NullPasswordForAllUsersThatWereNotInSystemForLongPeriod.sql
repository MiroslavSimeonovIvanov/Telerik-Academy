ALTER TABLE [TelerikAcademy].[dbo].[Users]
ALTER COLUMN Password nvarchar(50) NULL;
GO

ALTER TABLE [TelerikAcademy].[dbo].[Users]
DROP CONSTRAINT CHK_Users;
GO

UPDATE [TelerikAcademy].[dbo].[Users]
SET Password = NULL
WHERE LastLoginTime < '10.03.2010';
GO
