CREATE TABLE [dbo].[tblSales]
(
 [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
 [SaleDate] DATETIME NOT NULL DEFAULT (GETDATE()),
 [Subtotal] DECIMAL(18,2) NOT NULL CHECK ([Subtotal] >= 0),
 [Discount] DECIMAL(18,2) NOT NULL DEFAULT (0) CHECK ([Discount] >= 0),
 [TotalAmount] DECIMAL(18,2) NOT NULL CHECK ([TotalAmount] >= 0),
 [PaymentMethod] NVARCHAR(20) NOT NULL CHECK ([PaymentMethod] IN (N'Cash', N'Card', N'GCash')),
 [AmountReceived] DECIMAL(18,2) NULL,
 [ChangeAmount] DECIMAL(18,2) NULL,
 [CashierUsername] NVARCHAR(50) NULL,
 [Status] NVARCHAR(20) NOT NULL DEFAULT (N'Completed') CHECK ([Status] IN (N'Completed',N'Cancelled'))
);
