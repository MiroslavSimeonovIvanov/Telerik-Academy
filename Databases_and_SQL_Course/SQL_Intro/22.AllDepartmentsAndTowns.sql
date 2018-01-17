SELECT d.Name AS DepartmentsAndTowns
FROM [TelerikAcademy].[dbo].[Departments] AS d
UNION
SELECT t.Name AS DepartmentsAndTowns
FROM [TelerikAcademy].[dbo].[Towns] AS t;
