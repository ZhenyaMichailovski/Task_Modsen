ALTER TABLE [dbo].[EventOrganizers]
	ADD CONSTRAINT [FK_Organizers_EventOrganizers]
	FOREIGN KEY (OrdanizerId)
	REFERENCES [Organizers] (Id)
