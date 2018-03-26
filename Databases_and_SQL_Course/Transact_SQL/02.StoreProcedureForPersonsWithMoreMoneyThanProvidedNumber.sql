USE FinancialInformation;
GO

CREATE PROCEDURE usp_ReturnPersonsWithMoreMoneyThanProvidedNumber(@number money)
AS
	SELECT FirstName, LastName, Balance
	FROM Persons
		INNER JOIN Accounts
		ON Persons.PersonId = Accounts.PersonId
	WHERE Balance > @number;
GO

EXECUTE usp_ReturnPersonsWithMoreMoneyThanProvidedNumber 9000000;
GO
