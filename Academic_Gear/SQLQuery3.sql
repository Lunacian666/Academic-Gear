
USE AcademicGearDB;
GO

-- CATEGORIES
IF NOT EXISTS (
    SELECT 1 FROM tblCategories
    WHERE CategoryName = 'School Supplies')
INSERT INTO tblCategories (CategoryName)
VALUES ('School Supplies');

IF NOT EXISTS (
    SELECT 1 FROM tblCategories
    WHERE CategoryName = 'Uniforms')
INSERT INTO tblCategories (CategoryName)
VALUES ('Uniforms');

IF NOT EXISTS (
    SELECT 1 FROM tblCategories
    WHERE CategoryName = 'Accessories')
INSERT INTO tblCategories (CategoryName)
VALUES ('Accessories');

-- DEFAULT SUPPLIER
IF NOT EXISTS (
    SELECT 1 FROM tblSuppliers
    WHERE SupplierName = 'Default Supplier')
INSERT INTO tblSuppliers (SupplierName)
VALUES ('Default Supplier');

-- SAMPLE PRODUCTS
DECLARE @CategoryId INT =
(
    SELECT Id FROM tblCategories
    WHERE CategoryName = 'School Supplies'
);

DECLARE @SupplierId INT =
(
    SELECT TOP 1 Id FROM tblSuppliers
    WHERE SupplierName = 'Default Supplier'
);

IF NOT EXISTS (
    SELECT 1 FROM tblProducts
    WHERE ProductCode = 'PRD001')
INSERT INTO tblProducts
(ProductCode, ProductName, CategoryId,
 SupplierId, Price, Quantity)
VALUES
('PRD001', 'Notebook', @CategoryId,
 @SupplierId, 45.00, 100);

IF NOT EXISTS (
    SELECT 1 FROM tblProducts
    WHERE ProductCode = 'PRD002')
INSERT INTO tblProducts
(ProductCode, ProductName, CategoryId,
 SupplierId, Price, Quantity)
VALUES
('PRD002', 'Ballpen', @CategoryId,
 @SupplierId, 15.00, 200);

IF NOT EXISTS (
    SELECT 1 FROM tblProducts
    WHERE ProductCode = 'PRD003')
INSERT INTO tblProducts
(ProductCode, ProductName, CategoryId,
 SupplierId, Price, Quantity)
VALUES
('PRD003', 'Pencil', @CategoryId,
 @SupplierId, 10.00, 150);
GO

SELECT
    p.ProductCode AS [PRODUCT CODE],
    p.ProductName AS [PRODUCT NAME],
    c.CategoryName AS [CATEGORY],
    p.Price AS [PRICE],
    p.Quantity AS [AVAILABLE STOCK]
FROM tblProducts p
INNER JOIN tblCategories c
    ON p.CategoryId = c.Id;

    USE AcademicGearDB;
GO

SELECT * FROM tblProducts;
SELECT * FROM tblCategories;
SELECT * FROM tblSuppliers;
SELECT * FROM tblSales;
SELECT * FROM tblSaleItems;