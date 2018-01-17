SELECT e.FirstName, e.LastName, t.Name AS Town, a.AddressText AS Address
FROM [TelerikAcademy].[dbo].[Employees] AS e,
	[TelerikAcademy].[dbo].[Addresses] AS a,
	[TelerikAcademy].[dbo].[Towns] AS t
WHERE e.AddressID = a.AddressID AND a.TownID = t.TownID;
