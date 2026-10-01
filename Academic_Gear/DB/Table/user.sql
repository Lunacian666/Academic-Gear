CREATE TABLE [dbo].[Users]
(
    [UserId] INT IDENTITY(1,1) NOT NULL,
    [Username] VARCHAR(50) NOT NULL,
    [Password] VARCHAR(100) NOT NULL,
    [Role] VARCHAR(30) NOT NULL,

    CONSTRAINT [PK_Users] PRIMARY KEY ([UserId])
);