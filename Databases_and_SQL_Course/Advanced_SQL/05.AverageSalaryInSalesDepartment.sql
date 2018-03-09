SELECT AVG(Salary) AS [Average Salary]
FROM [TelerikAcademy].[dbo].[Employees] AS e
	INNER JOIN [TelerikAcademy].[dbo].[Departments] AS d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales';
