SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], Salary
FROM [TelerikAcademy].[dbo].[Employees] AS e
WHERE Salary BETWEEN 9000 AND 9900
ORDER BY Salary ASC;
