SELECT d.Name AS [Department], e.JobTitle AS [Job Title], AVG(e.Salary) AS [Average Salary]
FROM [TelerikAcademy].[dbo].[Employees] AS e
	INNER JOIN [TelerikAcademy].[dbo].[Departments] AS d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle;
