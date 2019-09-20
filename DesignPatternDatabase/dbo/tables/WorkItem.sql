CREATE TABLE [dbo].[WorkItem]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [State] NVARCHAR(50) NULL, 
    [Title] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(50) NULL
)
