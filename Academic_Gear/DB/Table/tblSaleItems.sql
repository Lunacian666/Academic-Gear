CREATE TABLE [dbo].[tblSaleItems]
(
 [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
 [SaleId] INT NOT NULL REFERENCES [dbo].[tblSales]([Id]),
 [ProductId] INT NOT NULL REFERENCES [dbo].[tblProducts]([Id]),
 [Quantity] INT NOT NULL CHECK ([Quantity] > 0),
 [UnitPrice] DECIMAL(18,2) NOT NULL CHECK ([UnitPrice] >= 0),
 [LineTotal] AS (CONVERT(DECIMAL(18,2), [Quantity] * [UnitPrice])) PERSISTED,
 [ProductNameSnapshot] NVARCHAR(100) NULL
);
