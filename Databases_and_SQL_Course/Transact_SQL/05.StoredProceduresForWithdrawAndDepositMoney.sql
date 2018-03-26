USE FinancialInformation;
GO

CREATE PROCEDURE usp_WithdrawMoney(@accountId int, @money money)
AS
	DECLARE @remainingBalance money;
	DECLARE @balance money;

	SET @balance = (
		SELECT Balance
		FROM Accounts
		WHERE AccountId = @accountId
	);
	SET @remainingBalance = @balance - @money;

	UPDATE Accounts
	SET Balance = @remainingBalance
	WHERE AccountId = @accountId;
GO

CREATE PROCEDURE usp_DepositMoney(@accountId int, @money money)
AS
	DECLARE @remainingBalance money;
	DECLARE @balance money;

	SET @balance = (
		SELECT Balance
		FROM Accounts
		WHERE AccountId = @accountId
	);
	SET @remainingBalance = @balance + @money;

	UPDATE Accounts
	SET Balance = @remainingBalance
	WHERE AccountId = @accountId;
GO

BEGIN TRANSACTION;
EXECUTE usp_WithdrawMoney 13, 5000;
COMMIT;
GO

BEGIN TRANSACTION;
EXECUTE usp_DepositMoney 13, 5000;
COMMIT;
GO
