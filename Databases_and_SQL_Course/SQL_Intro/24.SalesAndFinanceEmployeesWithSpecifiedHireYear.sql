SELECT e.FirstName + ' ' + e.LastName AS Employee, d.Name AS Department,
	FORMAT(e.HireDate, 'yyyy', 'de-de') AS HireYear
FROM [TelerikAcademy].[dbo].[Employees] AS e
	INNER JOIN [TelerikAcademy].[dbo].[Departments] AS d
	ON e.DepartmentID = d.DepartmentID
WHERE e.HireDate BETWEEN '1995' AND '2005' AND d.Name IN ('Sales', 'Finance');
