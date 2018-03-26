CREATE DATABASE FinancialInformation;
GO

USE FinancialInformation;
GO

CREATE TABLE [Persons] (
	PersonId int IDENTITY(1,1) NOT NULL,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	SSN nvarchar(11),
	CONSTRAINT PK_Persons PRIMARY KEY(PersonId)
);
GO

CREATE TABLE [Accounts] (
	AccountId int IDENTITY(1,1) NOT NULL,
	PersonId int,
	Balance money,
	CONSTRAINT PK_Accounts PRIMARY KEY(AccountId),
	CONSTRAINT FK_Accounts_Persons FOREIGN KEY(PersonId) REFERENCES Persons(PersonId)
);
GO

INSERT INTO [Persons]
VALUES ('Keanu', 'Reeves', '002091964'),
	('Laurence', 'Fishburne', '030071961'),
	('Carrie-Anne', 'Moss', '021081967'),
	('Hugo', 'Weaving', '004041960'),
	('Joe', 'Pantoliano', NULL),
	('Gloria', 'Foster', '0150111933'),
	('Marcus', 'Chong', '0080071967'),
	('Robert', 'Taylor', '0070071963'),
	('Julian', 'Arahanga', '0180121972'),
	('Belinda', 'McClory', '0010111968'),
	('Anthony', 'Parker', '0130051958'),
	('Matthew', 'Doran', '0300031976'),
	('Ada', 'Nicodemou', '0140051977');
GO

INSERT INTO [Accounts]
VALUES (NULL, 30000000),
	(NULL, 20000000),
	(NULL, 3000000),
	(NULL, 9000000),
	(NULL, 160000),
	(NULL, 20000),
	(NULL, 24000),
	(NULL, 18000),
	(NULL, 30000),
	(NULL, 28000),
	(NULL, 21000),
	(NULL, 29000),
	(NULL, 10000);
GO

CREATE PROCEDURE usp_GetPersonFullName
AS
	SELECT FirstName + ' ' + LastName AS [Person Full Name]
	FROM Persons;
GO

EXECUTE usp_GetPersonFullName;
GO
