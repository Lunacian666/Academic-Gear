CREATE TABLE [dbo].[tblProducts]
(
 [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
 [ProductCode] NVARCHAR(50) NOT NULL UNIQUE,
 [ProductName] NVARCHAR(100) NOT NULL,
 [CategoryId] INT NOT NULL REFERENCES [dbo].[tblCategories]([Id]),
 [SupplierId] INT NOT NULL REFERENCES [dbo].[tblSuppliers]([Id]),
 [Price] DECIMAL(18,2) NOT NULL CHECK ([Price] >= 0),
 [Quantity] INT NOT NULL DEFAULT (0) CHECK ([Quantity] >= 0),
 [UnitOfMeasure] NVARCHAR(20) NOT NULL DEFAULT (N'Piece')
);
