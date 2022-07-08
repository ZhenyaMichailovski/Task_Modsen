CREATE TABLE [dbo].[EventOrganizers]
(
	[Id]                INT     IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [EventId]           INT NOT NULL, 
    [OrdanizerId]       INT NOT NULL,

)
