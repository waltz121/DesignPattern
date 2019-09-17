CREATE TABLE [dbo].[Address]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerId] INT NOT NULL, 
    [StreetAddress] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [State] NVARCHAR(50) NULL, 
    [ZipCode] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Address_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([CustomerId])
)
