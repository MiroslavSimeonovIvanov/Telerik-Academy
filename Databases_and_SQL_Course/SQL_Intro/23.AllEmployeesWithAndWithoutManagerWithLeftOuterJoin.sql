SELECT e.FirstName + ' ' + e.LastName AS Employee, m.FirstName + ' ' + m.LastName AS Manager
FROM [TelerikAcademy].[dbo].[Employees] AS e
	LEFT OUTER JOIN [TelerikAcademy].[dbo].[Employees] AS m
	ON e.ManagerID = m.EmployeeID;
