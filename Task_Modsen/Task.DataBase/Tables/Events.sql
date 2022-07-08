CREATE TABLE [dbo].[Events] (
    [Id]                INT     IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [Title]             NVARCHAR(50) NOT NULL, 
    [Description]       NVARCHAR(200) NOT NULL,
    [TimeOfEvent]       DATETIMEOFFSET (7) NOT NULL,
    [PlaceId]           INT NOT NULL 
);
