using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic.Database
{
    /// <summary>
    /// Each Windows user receives an independent AcademicGearDB in their own LocalDB instance.
    /// Runs on application startup; does not require SSMS or a cloud server.
    /// </summary>
    public static class LocalDatabase
    {
        public static string ConnectionString
        {
            get
            {
                ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["POSDatabase"];
                if (setting == null || string.IsNullOrWhiteSpace(setting.ConnectionString))
                    throw new InvalidOperationException("Missing POSDatabase in UI/App.config.");
                return setting.ConnectionString;
            }
        }

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static void Initialize()
        {
            var target = new SqlConnectionStringBuilder(ConnectionString);
            if (!string.Equals(target.InitialCatalog, "AcademicGearDB", StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Connection database must be AcademicGearDB.");

            var master = new SqlConnectionStringBuilder(target.ConnectionString);
            master.InitialCatalog = "master";

            using (var con = new SqlConnection(master.ConnectionString))
            using (var cmd = new SqlCommand(@"
IF DB_ID(@name) IS NULL
BEGIN
    DECLARE @statement NVARCHAR(MAX) = N'CREATE DATABASE ' + QUOTENAME(@name);
    EXEC (@statement);
END;", con))
            {
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 128).Value = target.InitialCatalog;
                cmd.CommandTimeout = 90;
                con.Open();
                cmd.ExecuteNonQuery();
            }

            using (var con = CreateConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand(SchemaSql, con))
                {
                    cmd.CommandTimeout = 90;
                    cmd.ExecuteNonQuery();
                }
                using (var cmd = new SqlCommand(SeedSql, con))
                {
                    cmd.CommandTimeout = 90;
                    cmd.ExecuteNonQuery();
                }
                using (var cmd = new SqlCommand(ValidateSql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // The IF checks make repeated startup safe; no existing data is deleted.
        private const string SchemaSql = @"
IF OBJECT_ID(N'dbo.tblLogin', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblLogin (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Username VARCHAR(50) NOT NULL UNIQUE,
        [Password] VARCHAR(50) NOT NULL,
        Role VARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'Cashier'))
    );
END;

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
END;";

        // Demo users only. Existing account passwords are never reset on launch.
        private const string SeedSql = @"
IF NOT EXISTS (SELECT 1 FROM dbo.tblLogin WHERE Username = 'admin')
    INSERT INTO dbo.tblLogin (Username, [Password], Role)
    VALUES ('admin', 'admin123', 'Admin');

IF NOT EXISTS (SELECT 1 FROM dbo.tblLogin WHERE Username = 'cashier')
    INSERT INTO dbo.tblLogin (Username, [Password], Role)
    VALUES ('cashier', 'cashier123', 'Cashier');

IF NOT EXISTS (SELECT 1 FROM dbo.tblCategories WHERE CategoryName = N'School Supplies')
    INSERT INTO dbo.tblCategories (CategoryName) VALUES (N'School Supplies');
IF NOT EXISTS (SELECT 1 FROM dbo.tblCategories WHERE CategoryName = N'Uniforms')
    INSERT INTO dbo.tblCategories (CategoryName) VALUES (N'Uniforms');
IF NOT EXISTS (SELECT 1 FROM dbo.tblCategories WHERE CategoryName = N'Accessories')
    INSERT INTO dbo.tblCategories (CategoryName) VALUES (N'Accessories');
IF NOT EXISTS (SELECT 1 FROM dbo.tblSuppliers WHERE SupplierName = N'Default Supplier')
    INSERT INTO dbo.tblSuppliers (SupplierName) VALUES (N'Default Supplier');";

        private const string ValidateSql = @"
IF COL_LENGTH(N'dbo.tblLogin', N'Username') IS NULL
 OR COL_LENGTH(N'dbo.tblLogin', N'Password') IS NULL
 OR COL_LENGTH(N'dbo.tblLogin', N'Role') IS NULL
 OR COL_LENGTH(N'dbo.tblProducts', N'Id') IS NULL
 OR COL_LENGTH(N'dbo.tblProducts', N'ProductName') IS NULL
 OR COL_LENGTH(N'dbo.tblProducts', N'CategoryId') IS NULL
 OR COL_LENGTH(N'dbo.tblProducts', N'SupplierId') IS NULL
 OR COL_LENGTH(N'dbo.tblProducts', N'Price') IS NULL
 OR COL_LENGTH(N'dbo.tblProducts', N'Quantity') IS NULL
 OR COL_LENGTH(N'dbo.tblSales', N'TotalAmount') IS NULL
 OR COL_LENGTH(N'dbo.tblSaleItems', N'UnitPrice') IS NULL
    THROW 50001, 'Existing AcademicGearDB has an incompatible table layout. Back up the database and compare it with SETUP.md before migrating.', 1;";
    }
}
