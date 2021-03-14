CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [PasswordHash] BINARY(500) NOT NULL, 
    [PasswordSalt] BINARY(500) NOT NULL, 
    [Status] BIT NOT NULL
)
