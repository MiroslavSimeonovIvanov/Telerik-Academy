USE FinancialInformation;
GO

CREATE TABLE [Logs] (
	LogID int IDENTITY(1,1) NOT NULL,
	AccountId int,
	OldSum money,
	NewSum money,
	CONSTRAINT PK_Logs PRIMARY KEY(LogID),
	CONSTRAINT FK_Logs_Accounts FOREIGN KEY(AccountId) REFERENCES Accounts(AccountId)
);
GO

CREATE TRIGGER tr_BalanceChange
ON Accounts
AFTER UPDATE
AS
	INSERT INTO [Logs] (AccountId, OldSum)
		SELECT AccountId, Balance
		FROM deleted;

	INSERT INTO [Logs] (AccountId, NewSum)
		SELECT AccountId, Balance
		FROM inserted;
GO

UPDATE [Accounts]
SET Balance = 17000
WHERE AccountId = 8;
GO
