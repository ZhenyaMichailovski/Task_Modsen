CREATE TABLE [dbo].[Organizers]
(
	[Id]                INT     IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [Name]              NVARCHAR(50) NOT NULL, 
    [TypeOfActivity]    NVARCHAR(100) NOT NULL,
)
