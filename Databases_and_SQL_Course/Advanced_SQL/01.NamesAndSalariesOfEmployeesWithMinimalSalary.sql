SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], Salary
FROM [TelerikAcademy].[dbo].[Employees] AS e
WHERE Salary = 
	(SELECT MIN(Salary)
	 FROM [TelerikAcademy].[dbo].[Employees]);
