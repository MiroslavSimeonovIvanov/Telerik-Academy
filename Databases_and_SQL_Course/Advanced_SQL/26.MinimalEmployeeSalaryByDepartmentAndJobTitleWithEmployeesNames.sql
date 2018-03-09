SELECT d.Name AS [Department], e.JobTitle AS [Job Title], e.FirstName + ' ' + e.LastName AS [Employee Name],
	MIN(e.Salary) AS [Min Salary]
FROM [TelerikAcademy].[dbo].[Employees] AS e
	INNER JOIN [TelerikAcademy].[dbo].[Departments] AS d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle, e.FirstName, e.LastName;
