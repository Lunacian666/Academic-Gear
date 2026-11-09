
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic.Database
{
    public static class LocalDatabase
    {
        public static string ConnectionString
        {
            get
            {
                ConnectionStringSettings item =
                    ConfigurationManager
                    .ConnectionStrings["POSDatabase"];

                if (item == null ||
                    string.IsNullOrWhiteSpace(item.ConnectionString))
                {
                    throw new InvalidOperationException(
                        "POSDatabase connection string is missing.");
                }

                return item.ConnectionString;
            }
        }

        public static void Initialize()
        {
            // Get the local database connection
            var dbBuilder =
                new SqlConnectionStringBuilder(ConnectionString);

            if (string.IsNullOrWhiteSpace(
                dbBuilder.InitialCatalog))
            {
                throw new InvalidOperationException(
                    "Database name is missing.");
            }

            // Connect to master first
            var masterBuilder =
                new SqlConnectionStringBuilder(
                    dbBuilder.ConnectionString);

            masterBuilder.InitialCatalog = "master";

            using (SqlConnection connection =
                new SqlConnection(masterBuilder.ConnectionString))
            {
                connection.Open();

                // Automatically create database if missing
                string createDatabase = @"
                    IF DB_ID(@DatabaseName) IS NULL
                    BEGIN
                        DECLARE @sql NVARCHAR(MAX) =
                            N'CREATE DATABASE ' +
                            QUOTENAME(@DatabaseName);

                        EXEC (@sql);
                    END;";

                using (SqlCommand command =
                    new SqlCommand(createDatabase, connection))
                {
                    command.CommandTimeout = 60;

                    command.Parameters.Add(
                        "@DatabaseName",
                        SqlDbType.NVarChar, 128)
                        .Value = dbBuilder.InitialCatalog;

                    command.ExecuteNonQuery();
                }
            }

            // Connect to AcademicGearDB
            using (SqlConnection connection =
                new SqlConnection(dbBuilder.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command =
                    new SqlCommand(SchemaSql, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteNonQuery();
                }
            }
        }

        private const string SchemaSql = @"

-- =====================================
-- LOGIN TABLE
-- =====================================

IF OBJECT_ID('dbo.tblLogin', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblLogin
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Username VARCHAR(50) NOT NULL UNIQUE,
        [Password] VARCHAR(50) NOT NULL,
        Role VARCHAR(20) NOT NULL
            CHECK (Role IN ('Admin', 'Cashier'))
    );
END;

-- =====================================
-- CATEGORY TABLE
-- =====================================

IF OBJECT_ID('dbo.tblCategories', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblCategories
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        CategoryName NVARCHAR(50) NOT NULL UNIQUE,
        Description NVARCHAR(255) NULL
    );
END;

-- =====================================
-- SUPPLIER TABLE
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
END;

-- =====================================
-- PRODUCT TABLE
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

        CONSTRAINT FK_Products_Categories
            FOREIGN KEY (CategoryId)
            REFERENCES dbo.tblCategories(Id),

        CONSTRAINT FK_Products_Suppliers
            FOREIGN KEY (SupplierId)
            REFERENCES dbo.tblSuppliers(Id)
    );
END;

-- =====================================
-- SALES TABLE
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
END;

-- =====================================
-- SALE ITEMS TABLE
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
        (
            CONVERT(DECIMAL(18,2),
                Quantity * UnitPrice)
        ) PERSISTED,

        CONSTRAINT FK_SaleItems_Sales
            FOREIGN KEY (SaleId)
            REFERENCES dbo.tblSales(Id),

        CONSTRAINT FK_SaleItems_Products
            FOREIGN KEY (ProductId)
            REFERENCES dbo.tblProducts(Id)
    );
END;

-- =====================================
-- CREATE LOGIN ACCOUNTS
-- =====================================

IF NOT EXISTS (SELECT 1 FROM dbo.tblLogin)
BEGIN
    INSERT INTO dbo.tblLogin
        (Username, [Password], Role)
    VALUES
        ('admin', 'admin123', 'Admin'),
        ('cashier', 'cashier123', 'Cashier');
END;

-- =====================================
-- DEFAULT CATEGORIES
-- =====================================

IF NOT EXISTS (SELECT 1 FROM dbo.tblCategories)
BEGIN
    INSERT INTO dbo.tblCategories
        (CategoryName)
    VALUES
        (N'School Supplies'),
        (N'Uniforms'),
        (N'Accessories');
END;

-- =====================================
-- DEFAULT SUPPLIER
-- =====================================

IF NOT EXISTS (SELECT 1 FROM dbo.tblSuppliers)
BEGIN
    INSERT INTO dbo.tblSuppliers
        (SupplierName)
    VALUES
        (N'Default Supplier');
END;
";
    }
}
