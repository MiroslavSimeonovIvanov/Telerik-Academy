USE FinancialInformation;
GO

CREATE PROCEDURE usp_CalculateSimpleInterest(@accountId int, @interestRate decimal)
AS
	DECLARE @simpleInterest money;
	DECLARE @rateOfInterest decimal(8,4);
	DECLARE @time decimal(8,4);
	DECLARE @rateOfInterestMultipliedByTime decimal(8,4);
	DECLARE @principalAmount money;

	SET @rateOfInterest = @interestRate / 100;
	SET @time = 0.08;
	SET @rateOfInterestMultipliedByTime = @rateOfInterest * @time;
	SET @principalAmount = (
		SELECT Balance
		FROM Accounts
		WHERE AccountId = @accountId
	);
	SET @simpleInterest = @principalAmount * (1 + @rateOfInterestMultipliedByTime);

	SELECT AccountId, Balance, @simpleInterest AS [Simple Interest]
	FROM Accounts
	WHERE AccountId = @accountId;
GO

EXECUTE usp_CalculateSimpleInterest 7, 1;
GO
