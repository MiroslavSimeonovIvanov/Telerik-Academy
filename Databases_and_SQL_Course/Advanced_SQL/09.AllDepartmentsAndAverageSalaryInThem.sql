SELECT AVG(Salary) AS [Average Salary], d.Name AS [Department]
FROM [TelerikAcademy].[dbo].[Employees] AS e
	INNER JOIN [TelerikAcademy].[dbo].[Departments] AS d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name;
