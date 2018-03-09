ALTER TABLE [TelerikAcademy].[dbo].[Users]
ALTER COLUMN LastLoginTime datetime NULL;
GO

ALTER TABLE [TelerikAcademy].[dbo].[Users]
DROP CONSTRAINT AK_Users, CONSTRAINT CHK_Users;
GO

INSERT [TelerikAcademy].[dbo].[Users] (Username, Password, FullName, LastLoginTime)
	SELECT SUBSTRING(e.FirstName, 1, 1) + LOWER(e.LastName), SUBSTRING(e.FirstName, 1, 1) + LOWER(e.LastName),
	e.FirstName + ' ' + e.LastName, NULL
	FROM [TelerikAcademy].[dbo].[Employees] AS e;
GO
