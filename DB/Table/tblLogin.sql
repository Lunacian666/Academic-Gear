CREATE TABLE [dbo].[tblLogin]
(
 [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
 [Username] VARCHAR(50) NOT NULL UNIQUE,
 [Password] VARCHAR(50) NOT NULL,
 [Role] VARCHAR(20) NOT NULL CHECK ([Role] IN ('Admin','Cashier'))
);
