ALTER TABLE [TelerikAcademy].[dbo].[Users]
ADD GroupID int
	CONSTRAINT FK_Users_Groups FOREIGN KEY(GroupID) REFERENCES Groups(GroupID);
