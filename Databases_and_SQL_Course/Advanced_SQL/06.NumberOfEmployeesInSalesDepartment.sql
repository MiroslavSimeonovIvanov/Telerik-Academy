SELECT COUNT(*) AS [Number of Employees]
FROM [TelerikAcademy].[dbo].[Employees] AS e
	INNER JOIN [TelerikAcademy].[dbo].[Departments] AS d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales';
