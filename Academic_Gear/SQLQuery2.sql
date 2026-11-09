
USE AcademicGearDB;
GO

-- =====================================
-- 1. PRODUCT CATEGORIES
-- =====================================

IF OBJECT_ID('dbo.tblCategories', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblCategories
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        CategoryName NVARCHAR(50) NOT NULL UNIQUE,
        Description NVARCHAR(255) NULL
    );
END
GO

-- =====================================
-- 2. SUPPLIERS
-- =====================================

IF OBJECT_ID('dbo.tblSuppliers', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblSuppliers
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        SupplierName NVARCHAR(100) NOT NULL,
        ContactPerson NVARCHAR(100) NULL,
        ContactNumber NVARCHAR(20) NULL
    );
END
GO

-- =====================================
-- 3. PRODUCTS / INVENTORY
-- =====================================

IF OBJECT_ID('dbo.tblProducts', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblProducts
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        ProductCode NVARCHAR(50) NOT NULL UNIQUE,
        ProductName NVARCHAR(100) NOT NULL,
        CategoryId INT NOT NULL,
        SupplierId INT NOT NULL,
        Price DECIMAL(18,2) NOT NULL
            CHECK (Price >= 0),
        Quantity INT NOT NULL DEFAULT 0
            CHECK (Quantity >= 0),

        CONSTRAINT FK_tblProducts_tblCategories
            FOREIGN KEY (CategoryId)
            REFERENCES dbo.tblCategories(Id),

        CONSTRAINT FK_tblProducts_tblSuppliers
            FOREIGN KEY (SupplierId)
            REFERENCES dbo.tblSuppliers(Id)
    );
END
GO

-- =====================================
-- 4. SALES / TRANSACTIONS
-- =====================================

IF OBJECT_ID('dbo.tblSales', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblSales
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,

        SaleDate DATETIME NOT NULL
            DEFAULT GETDATE(),

        Subtotal DECIMAL(18,2) NOT NULL
            CHECK (Subtotal >= 0),

        Discount DECIMAL(18,2) NOT NULL
            DEFAULT 0 CHECK (Discount >= 0),

        TotalAmount DECIMAL(18,2) NOT NULL
            CHECK (TotalAmount >= 0),

        PaymentMethod NVARCHAR(20) NOT NULL
            CHECK (PaymentMethod IN
                ('Cash', 'Card', 'GCash')),

        AmountReceived DECIMAL(18,2) NULL,

        ChangeAmount DECIMAL(18,2) NULL,

        CashierUsername NVARCHAR(50) NULL,

        Status NVARCHAR(20) NOT NULL
            DEFAULT 'Completed'
            CHECK (Status IN
                ('Completed', 'Cancelled'))
    );
END
GO

-- =====================================
-- 5. SALE ITEMS
-- =====================================

IF OBJECT_ID('dbo.tblSaleItems', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblSaleItems
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,

        SaleId INT NOT NULL,
        ProductId INT NOT NULL,

        Quantity INT NOT NULL
            CHECK (Quantity > 0),

        UnitPrice DECIMAL(18,2) NOT NULL
            CHECK (UnitPrice >= 0),

        LineTotal AS
            (CONVERT(DECIMAL(18,2),
                Quantity * UnitPrice)) PERSISTED,

        CONSTRAINT FK_tblSaleItems_tblSales
            FOREIGN KEY (SaleId)
            REFERENCES dbo.tblSales(Id),

        CONSTRAINT FK_tblSaleItems_tblProducts
            FOREIGN KEY (ProductId)
            REFERENCES dbo.tblProducts(Id)
    );
END
GO

-- =====================================
-- VIEW ALL CREATED TABLES
-- =====================================

SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME;
GO
