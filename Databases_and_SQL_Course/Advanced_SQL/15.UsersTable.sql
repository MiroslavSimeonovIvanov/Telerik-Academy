CREATE TABLE [TelerikAcademy].[dbo].[Users] (
	UserID int IDENTITY(1,1) NOT NULL,
	Username nvarchar(50) NOT NULL,
	Password nvarchar(50) NOT NULL,
	FullName nvarchar(100) NOT NULL,
	LastLoginTime datetime NOT NULL, 
	CONSTRAINT PK_Users PRIMARY KEY(UserID),
	CONSTRAINT AK_Users UNIQUE(Username),
	CONSTRAINT CHK_Users CHECK(LEN(Password) >= 5)
);
