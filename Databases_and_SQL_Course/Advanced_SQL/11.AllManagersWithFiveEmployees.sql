SELECT m.FirstName + ' ' + m.LastName AS [Manager Name]
FROM [TelerikAcademy].[dbo].[Employees] AS e
	INNER JOIN [TelerikAcademy].[dbo].[Employees] AS m
	ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(e.EmployeeID) = 5;
