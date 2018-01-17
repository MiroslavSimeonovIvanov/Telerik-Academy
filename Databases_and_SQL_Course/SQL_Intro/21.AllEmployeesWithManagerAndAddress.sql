SELECT e.FirstName + ' ' + e.LastName AS Employee, m.FirstName + ' ' + m.LastName AS Manager,
	t.Name AS Town, a.AddressText AS Address
FROM [TelerikAcademy].[dbo].[Employees] AS e
	INNER JOIN [TelerikAcademy].[dbo].[Employees] AS m
	ON e.ManagerID = m.EmployeeID
	INNER JOIN [TelerikAcademy].[dbo].[Addresses] AS a
	ON e.AddressID = a.AddressID
	INNER JOIN [TelerikAcademy].[dbo].[Towns] AS t
	ON a.TownID = t.TownID;
