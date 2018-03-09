SELECT t.Name AS [Town], COUNT(e.EmployeeID) AS [Max Number of Employees]
FROM [TelerikAcademy].[dbo].[Employees] AS e
	INNER JOIN [TelerikAcademy].[dbo].[Addresses] AS a
	ON e.AddressID = a.AddressID
	INNER JOIN [TelerikAcademy].[dbo].[Towns] AS t
	ON a.TownID = t.TownID
GROUP BY t.Name
HAVING COUNT(e.EmployeeID) =
	(SELECT MAX(c.[Number of Employees])
	 FROM (SELECT t.Name AS [Town], COUNT(e.EmployeeID) AS [Number of Employees]
		   FROM [TelerikAcademy].[dbo].[Employees] AS e
			   INNER JOIN [TelerikAcademy].[dbo].[Addresses] AS a
			   ON e.AddressID = a.AddressID
			   INNER JOIN [TelerikAcademy].[dbo].[Towns] AS t
			   ON a.TownID = t.TownID
		   GROUP BY t.Name) AS c);
