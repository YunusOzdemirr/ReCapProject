CREATE TABLE [dbo].[Customer] (
    [UserId]    INT    NOT NULL,
    [CompanyName] VARCHAR (50) NULL,
   
    PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [fkCustomerId] FOREIGN KEY (UserId) REFERENCES [dbo].[Users] ([Id])
);

