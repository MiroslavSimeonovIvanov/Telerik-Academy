USE FinancialInformation;
GO

CREATE FUNCTION ufn_CalculateAnnualCompoundInterest(@sum money, @yearlyInterestRate decimal,
	@numberOfMonths int)
RETURNS money
AS
BEGIN
	DECLARE @compoundInterest money;
	DECLARE @sumOfOneAndAnnualRate decimal;

	SET @sumOfOneAndAnnualRate = (1 + @yearlyInterestRate);
	SET @compoundInterest = @sum * POWER(@sumOfOneAndAnnualRate, @numberOfMonths);

	RETURN @compoundInterest;
END;
GO

SELECT Balance, dbo.ufn_CalculateAnnualCompoundInterest(30000, 0.05, 12) AS [Compound Interest]
FROM Accounts
WHERE Balance = 30000;
GO
