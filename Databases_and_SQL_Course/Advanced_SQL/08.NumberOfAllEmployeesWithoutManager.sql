SELECT COUNT(*) AS [Number of Employees]
FROM [TelerikAcademy].[dbo].[Employees] AS e
WHERE e.ManagerID IS NULL;
