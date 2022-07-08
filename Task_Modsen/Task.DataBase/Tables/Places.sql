CREATE TABLE [dbo].[Places]
(
	[Id]                INT     IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [Title]              NVARCHAR(50) NOT NULL, 
    [Address]    NVARCHAR(100) NOT NULL,
    [Description]    NVARCHAR(200) NOT NULL,
)
