SELECT t.Name AS [Town], COUNT(m.EmployeeID) AS [Number of Managers]
FROM [TelerikAcademy].[dbo].[Employees] AS e
	INNER JOIN [TelerikAcademy].[dbo].[Addresses] AS a
	ON e.AddressID = a.AddressID
	INNER JOIN [TelerikAcademy].[dbo].[Towns] AS t
	ON a.TownID = t.TownID
	INNER JOIN [TelerikAcademy].[dbo].[Employees] AS m
	ON e.ManagerID = m.EmployeeID
GROUP BY t.Name;
