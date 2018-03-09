SELECT COUNT(*) AS [Number of Employees]
FROM [TelerikAcademy].[dbo].[Employees] AS e
	INNER JOIN [TelerikAcademy].[dbo].[Employees] AS m
	ON e.ManagerID = m.EmployeeID;
