ALTER TABLE [dbo].[EventOrganizers]
ADD CONSTRAINT [FK_EventOrganizers_Events]
	FOREIGN KEY (EventId)
	REFERENCES [Events] (Id)
