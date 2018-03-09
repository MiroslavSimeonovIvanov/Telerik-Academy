SELECT e.FirstName + ' ' + e.LastName AS [Employee],
	ISNULL(CAST(e.ManagerID AS nvarchar), '(no manager)') AS [ManagerID]
FROM [TelerikAcademy].[dbo].[Employees] AS e
	LEFT OUTER JOIN [TelerikAcademy].[dbo].[Employees] AS m
	ON e.ManagerID = m.EmployeeID;
