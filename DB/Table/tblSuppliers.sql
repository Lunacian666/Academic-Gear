CREATE TABLE [dbo].[tblSuppliers]
(
 [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
 [SupplierName] NVARCHAR(100) NOT NULL,
 [ContactPerson] NVARCHAR(100) NULL,
 [ContactNumber] NVARCHAR(20) NULL
);
