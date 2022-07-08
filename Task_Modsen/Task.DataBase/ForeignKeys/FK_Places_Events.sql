ALTER TABLE [dbo].[Events]
	ADD CONSTRAINT [FK_Places_Events]
	FOREIGN KEY (PlaceId)
	REFERENCES [Places] (Id)
