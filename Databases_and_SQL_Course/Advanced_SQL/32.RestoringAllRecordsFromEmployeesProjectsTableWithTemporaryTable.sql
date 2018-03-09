SELECT *
INTO #EmployeesProjectsBackup
FROM [TelerikAcademy].[dbo].[EmployeesProjects];
GO

DROP TABLE [TelerikAcademy].[dbo].[EmployeesProjects];
GO

SELECT *
INTO [TelerikAcademy].[dbo].[EmployeesProjects]
FROM #EmployeesProjectsBackup;
GO
