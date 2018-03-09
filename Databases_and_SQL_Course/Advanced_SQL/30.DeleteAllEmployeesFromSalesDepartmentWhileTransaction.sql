BEGIN TRANSACTION;
ALTER TABLE [TelerikAcademy].[dbo].[Departments]
DROP CONSTRAINT FK_Departments_Employees;

DELETE FROM [TelerikAcademy].[dbo].[Employees]
	WHERE DepartmentID = 3;
ROLLBACK;
