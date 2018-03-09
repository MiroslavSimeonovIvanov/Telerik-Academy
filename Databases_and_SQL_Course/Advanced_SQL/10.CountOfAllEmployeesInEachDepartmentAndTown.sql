SELECT COUNT(*) AS [Number of Employees], d.Name AS [Department], t.Name AS [Town]
FROM [TelerikAcademy].[dbo].[Employees] AS e
	INNER JOIN [TelerikAcademy].[dbo].[Departments] AS d
	ON e.DepartmentID = d.DepartmentID
	INNER JOIN [TelerikAcademy].[dbo].[Addresses] AS a
	ON e.AddressID = a.AddressID
	INNER JOIN [TelerikAcademy].[dbo].[Towns] AS t
	ON a.TownID = t.TownID
GROUP BY d.Name, t.Name;
