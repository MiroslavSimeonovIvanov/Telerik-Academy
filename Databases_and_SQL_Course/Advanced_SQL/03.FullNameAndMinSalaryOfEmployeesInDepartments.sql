SELECT e.FirstName + ' ' + ISNULL(e.MiddleName, '') + ' ' + e.LastName AS [Employee Full Name],
	Salary, DepartmentID
FROM [TelerikAcademy].[dbo].[Employees] AS e
WHERE Salary = 
	(SELECT MIN(Salary)
	 FROM [TelerikAcademy].[dbo].[Employees]
	 WHERE DepartmentID = e.DepartmentID);
