CREATE TABLE [TelerikAcademy].[dbo].[WorkHours] (
	WorkHourID int IDENTITY(1,1) NOT NULL,
	Date date NOT NULL,
	Task nvarchar(300) NOT NULL,
	Hours int NOT NULL,
	Comments nvarchar(100),
	EmployeeID int,
	CONSTRAINT PK_WorkHours PRIMARY KEY(WorkHourID),
	CONSTRAINT FK_WorkHours_Employees FOREIGN KEY(EmployeeID) REFERENCES Employees(EmployeeID)
);
GO

CREATE TABLE [TelerikAcademy].[dbo].[WorkHoursLogs] (
	WorkHourLogID int IDENTITY(1,1) NOT NULL,
	Date date NOT NULL,
	Task nvarchar(300) NOT NULL,
	Hours int NOT NULL,
	Comments nvarchar(100),
	EmployeeID int,
	CONSTRAINT PK_WorkHoursLogs PRIMARY KEY(WorkHourLogID)
);
GO

CREATE TRIGGER PutInsertedData
ON [TelerikAcademy].[dbo].[WorkHours]
AFTER INSERT
AS
BEGIN
	INSERT INTO [TelerikAcademy].[dbo].[WorkHoursLogs] (Date, Task, Hours, Comments, EmployeeID)
		SELECT Date, Task, Hours, Comments, EmployeeID
		FROM inserted;
END;
GO

CREATE TRIGGER PutUpdatedData
ON [TelerikAcademy].[dbo].[WorkHours]
AFTER UPDATE
AS
BEGIN
	INSERT INTO [TelerikAcademy].[dbo].[WorkHoursLogs] (Date, Task, Hours, Comments, EmployeeID)
		SELECT Date, Task, Hours, Comments, EmployeeID
		FROM deleted;

	INSERT INTO [TelerikAcademy].[dbo].[WorkHoursLogs] (Date, Task, Hours, Comments, EmployeeID)
		SELECT Date, Task, Hours, Comments, EmployeeID
		FROM inserted;
END;
GO

CREATE TRIGGER PutDeletedData
ON [TelerikAcademy].[dbo].[WorkHours]
AFTER DELETE
AS
BEGIN
	INSERT INTO [TelerikAcademy].[dbo].[WorkHoursLogs] (Date, Task, Hours, Comments, EmployeeID)
		SELECT Date, Task, Hours, Comments, EmployeeID
		FROM deleted;
END;
GO

INSERT INTO [TelerikAcademy].[dbo].[WorkHours]
VALUES ('2018-02-21', 'Identify or Order IT Equipment', 21, NULL, 34),
	('2018-02-22', 'Order Business Cards', 14, NULL, 2),
	('2018-02-16', 'Obtain PM/Mentor assignments from Manager', 5, NULL, 103),
	('2018-01-06', 'Key to building and office', 1, NULL, 121),
	('2018-01-27', 'Explain the Welcome Party and give them some ideas', 2, NULL, 106),
	('2018-02-08', 'Check employment eligibility via E-verify', 2, NULL, 154),
	('2018-01-31', 'Explain the Activity Fund', 7, NULL, 71),
	('2018-02-09', 'Hold benefits meeting', 30, NULL, 178);
GO

UPDATE [TelerikAcademy].[dbo].[WorkHours]
SET Date = '2018-01-28'
WHERE EmployeeID = 71;
GO

DELETE FROM [TelerikAcademy].[dbo].[WorkHours]
WHERE Task = 'Explain the Welcome Party and give them some ideas';
GO
