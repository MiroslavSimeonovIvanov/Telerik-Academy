CREATE VIEW [UsersThatEnteredTheSystemToday] AS
SELECT u.Username AS [User], u.LastLoginTime AS [Logins for Today]
FROM [TelerikAcademy].[dbo].[Users] AS u
WHERE CONVERT(date, u.LastLoginTime) = CONVERT(date, '2018-02-06');
