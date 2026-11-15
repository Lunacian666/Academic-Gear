IF DB_ID(N'AcademicGearDB') IS NULL
    EXEC(N'CREATE DATABASE [AcademicGearDB]');
GO
USE [AcademicGearDB];
GO

IF OBJECT_ID(N'dbo.tblLogin', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblLogin (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Username VARCHAR(50) NOT NULL UNIQUE,
        [Password] VARCHAR(50) NOT NULL,
        Role VARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'Cashier'))
    );
END;

IF COL_LENGTH(N'dbo.tblLogin', N'EmployeeId') IS NULL
    ALTER TABLE dbo.tblLogin ADD EmployeeId NVARCHAR(30) NULL;
IF COL_LENGTH(N'dbo.tblLogin', N'Email') IS NULL
    ALTER TABLE dbo.tblLogin ADD Email NVARCHAR(120) NULL;
IF COL_LENGTH(N'dbo.tblLogin', N'FullName') IS NULL
    ALTER TABLE dbo.tblLogin ADD FullName NVARCHAR(100) NULL;

IF OBJECT_ID(N'dbo.tblCategories', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblCategories (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        CategoryName NVARCHAR(50) NOT NULL UNIQUE,
        Description NVARCHAR(255) NULL
    );
END;

IF OBJECT_ID(N'dbo.tblSuppliers', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblSuppliers (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        SupplierName NVARCHAR(100) NOT NULL,
        ContactPerson NVARCHAR(100) NULL,
        ContactNumber NVARCHAR(20) NULL
    );
END;

IF OBJECT_ID(N'dbo.tblProducts', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblProducts (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        ProductCode NVARCHAR(50) NOT NULL UNIQUE,
        ProductName NVARCHAR(100) NOT NULL,
        CategoryId INT NOT NULL REFERENCES dbo.tblCategories(Id),
        SupplierId INT NOT NULL REFERENCES dbo.tblSuppliers(Id),
        Price DECIMAL(18,2) NOT NULL CHECK (Price >= 0),
        Quantity INT NOT NULL DEFAULT (0) CHECK (Quantity >= 0),
        UnitOfMeasure NVARCHAR(20) NOT NULL DEFAULT (N'Piece')
    );
END;

IF OBJECT_ID(N'dbo.tblProducts', N'U') IS NOT NULL
   AND COL_LENGTH(N'dbo.tblProducts', N'UnitOfMeasure') IS NULL
BEGIN
    ALTER TABLE dbo.tblProducts
        ADD UnitOfMeasure NVARCHAR(20) NOT NULL
            CONSTRAINT DF_AcademicGear_Unit DEFAULT (N'Piece') WITH VALUES;
END;

IF OBJECT_ID(N'dbo.tblSales', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblSales (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        SaleDate DATETIME NOT NULL DEFAULT (GETDATE()),
        Subtotal DECIMAL(18,2) NOT NULL CHECK (Subtotal >= 0),
        Discount DECIMAL(18,2) NOT NULL DEFAULT (0) CHECK (Discount >= 0),
        TotalAmount DECIMAL(18,2) NOT NULL CHECK (TotalAmount >= 0),
        PaymentMethod NVARCHAR(20) NOT NULL CHECK (PaymentMethod IN (N'Cash', N'Card', N'GCash')),
        AmountReceived DECIMAL(18,2) NULL,
        ChangeAmount DECIMAL(18,2) NULL,
        CashierUsername NVARCHAR(50) NULL,
        Status NVARCHAR(20) NOT NULL DEFAULT (N'Completed')
            CHECK (Status IN (N'Completed', N'Cancelled'))
    );
END;

IF OBJECT_ID(N'dbo.tblSaleItems', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblSaleItems (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        SaleId INT NOT NULL REFERENCES dbo.tblSales(Id),
        ProductId INT NOT NULL REFERENCES dbo.tblProducts(Id),
        Quantity INT NOT NULL CHECK (Quantity > 0),
        UnitPrice DECIMAL(18,2) NOT NULL CHECK (UnitPrice >= 0),
        LineTotal AS (CONVERT(DECIMAL(18,2), Quantity * UnitPrice)) PERSISTED,
        ProductNameSnapshot NVARCHAR(100) NULL
    );
END;

IF OBJECT_ID(N'dbo.tblSaleItems', N'U') IS NOT NULL
   AND COL_LENGTH(N'dbo.tblSaleItems', N'ProductNameSnapshot') IS NULL
BEGIN
    ALTER TABLE dbo.tblSaleItems ADD ProductNameSnapshot NVARCHAR(100) NULL;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.tblLogin WHERE Username = 'admin')
    INSERT INTO dbo.tblLogin (Username, [Password], Role)
    VALUES ('admin', 'admin123', 'Admin');

IF NOT EXISTS (SELECT 1 FROM dbo.tblLogin WHERE Username = 'cashier')
    INSERT INTO dbo.tblLogin (Username, [Password], Role)
    VALUES ('cashier', 'cashier123', 'Cashier');

IF NOT EXISTS (SELECT 1 FROM dbo.tblCategories WHERE CategoryName = N'Writing Materials')
    INSERT INTO dbo.tblCategories (CategoryName) VALUES (N'Writing Materials');
IF NOT EXISTS (SELECT 1 FROM dbo.tblCategories WHERE CategoryName = N'Art Materials')
    INSERT INTO dbo.tblCategories (CategoryName) VALUES (N'Art Materials');
IF NOT EXISTS (SELECT 1 FROM dbo.tblCategories WHERE CategoryName = N'Folders and Envelopes')
    INSERT INTO dbo.tblCategories (CategoryName) VALUES (N'Folders and Envelopes');
IF NOT EXISTS (SELECT 1 FROM dbo.tblCategories WHERE CategoryName = N'Office Supplies')
    INSERT INTO dbo.tblCategories (CategoryName) VALUES (N'Office Supplies');
IF NOT EXISTS (SELECT 1 FROM dbo.tblCategories WHERE CategoryName = N'Paper Products')
    INSERT INTO dbo.tblCategories (CategoryName) VALUES (N'Paper Products');
IF NOT EXISTS (SELECT 1 FROM dbo.tblCategories WHERE CategoryName = N'School Supplies')
    INSERT INTO dbo.tblCategories (CategoryName) VALUES (N'School Supplies');
IF NOT EXISTS (SELECT 1 FROM dbo.tblCategories WHERE CategoryName = N'Uniforms')
    INSERT INTO dbo.tblCategories (CategoryName) VALUES (N'Uniforms');
IF NOT EXISTS (SELECT 1 FROM dbo.tblCategories WHERE CategoryName = N'Accessories')
    INSERT INTO dbo.tblCategories (CategoryName) VALUES (N'Accessories');
IF NOT EXISTS (SELECT 1 FROM dbo.tblSuppliers WHERE SupplierName = N'Default Supplier')
    INSERT INTO dbo.tblSuppliers (SupplierName) VALUES (N'Default Supplier');
GO
