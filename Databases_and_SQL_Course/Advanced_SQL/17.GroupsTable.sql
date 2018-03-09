CREATE TABLE [TelerikAcademy].[dbo].[Groups] (
	GroupID int IDENTITY(1,1) NOT NULL,
	GroupName nvarchar(50) NOT NULL,
	CONSTRAINT PK_Groups PRIMARY KEY(GroupID),
	CONSTRAINT AK_Groups UNIQUE(GroupName)
);
