using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Database;

namespace BusinessLogic.Repository
{
    public sealed class ProductInfo
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int SupplierId { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public sealed class CategoryInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() { return Name; }
    }

    public class ProductRepo
    {
        public List<CategoryInfo> GetCategories()
        {
            var categories = new List<CategoryInfo>();
            using (var con = LocalDatabase.CreateConnection())
            using (var cmd = new SqlCommand("SELECT Id, CategoryName FROM dbo.tblCategories ORDER BY CategoryName", con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        categories.Add(new CategoryInfo { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                }
            }
            return categories;
        }

        public List<ProductInfo> GetProducts(string search = "", int? categoryId = null)
        {
            var products = new List<ProductInfo>();
            const string query = @"
SELECT p.Id, p.ProductCode, p.ProductName, p.CategoryId,
       c.CategoryName, p.SupplierId, p.Price, p.Quantity, p.UnitOfMeasure
FROM dbo.tblProducts p
JOIN dbo.tblCategories c ON p.CategoryId = c.Id
WHERE (@search = N'' OR p.ProductName LIKE N'%' + @search + N'%' OR p.ProductCode LIKE N'%' + @search + N'%')
  AND (@categoryId IS NULL OR p.CategoryId = @categoryId)
ORDER BY p.ProductName, p.Id;";
            using (var con = LocalDatabase.CreateConnection())
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@search", SqlDbType.NVarChar, 100).Value = (search ?? "").Trim();
                cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value =
                    categoryId.HasValue ? (object)categoryId.Value : DBNull.Value;
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        products.Add(ReadProduct(reader));
                }
            }
            return products;
        }

        public ProductInfo GetProduct(int id)
        {
            const string query = @"
SELECT p.Id, p.ProductCode, p.ProductName, p.CategoryId,
       c.CategoryName, p.SupplierId, p.Price, p.Quantity, p.UnitOfMeasure
FROM dbo.tblProducts p
JOIN dbo.tblCategories c ON p.CategoryId = c.Id
WHERE p.Id = @id;";
            using (var con = LocalDatabase.CreateConnection())
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                con.Open();
                using (var reader = cmd.ExecuteReader())
                    return reader.Read() ? ReadProduct(reader) : null;
            }
        }

        private static ProductInfo ReadProduct(SqlDataReader r)
        {
            return new ProductInfo
            {
                Id = r.GetInt32(0),
                ProductCode = r.GetString(1),
                ProductName = r.GetString(2),
                CategoryId = r.GetInt32(3),
                CategoryName = r.GetString(4),
                SupplierId = r.GetInt32(5),
                Price = r.GetDecimal(6),
                Quantity = r.GetInt32(7),
                UnitOfMeasure = r.GetString(8)
            };
        }

        public void SaveProduct(ProductInfo product)
        {
            if (product == null) throw new ArgumentNullException("product");
            if (string.IsNullOrWhiteSpace(product.ProductCode) || product.ProductCode.Length > 50 ||
                string.IsNullOrWhiteSpace(product.ProductName) || product.ProductName.Length > 100 ||
                product.CategoryId <= 0 || product.Price < 0 || product.Quantity < 0 ||
                string.IsNullOrWhiteSpace(product.UnitOfMeasure) || product.UnitOfMeasure.Length > 20)
                throw new ArgumentException("Enter valid product details, including a category and unit.");

            using (var con = LocalDatabase.CreateConnection())
            {
                con.Open();
                // Registration form does not have a supplier field. Use the seeded default supplier.
                using (var supplierCmd = new SqlCommand(
                    "SELECT TOP 1 Id FROM dbo.tblSuppliers WHERE SupplierName=N'Default Supplier' ORDER BY Id", con))
                {
                    object supplier = supplierCmd.ExecuteScalar();
                    if (supplier == null) throw new InvalidOperationException("Default Supplier missing. Restart the application.");
                    product.SupplierId = Convert.ToInt32(supplier);
                }

                const string sql = @"
IF @id = 0
BEGIN
 INSERT INTO dbo.tblProducts
    (ProductCode, ProductName, CategoryId, SupplierId, Price, Quantity, UnitOfMeasure)
 VALUES (@code, @name, @category, @supplier, @price, @quantity, @unit);
END
ELSE
BEGIN
 UPDATE dbo.tblProducts SET
    ProductCode=@code, ProductName=@name, CategoryId=@category,
    Price=@price, Quantity=@quantity, UnitOfMeasure=@unit
 WHERE Id = @id;
 IF @@ROWCOUNT = 0 THROW 50002, 'Product no longer exists.', 1;
END;";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = product.Id;
                    cmd.Parameters.Add("@code", SqlDbType.NVarChar, 50).Value = product.ProductCode.Trim();
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = product.ProductName.Trim();
                    cmd.Parameters.Add("@category", SqlDbType.Int).Value = product.CategoryId;
                    cmd.Parameters.Add("@supplier", SqlDbType.Int).Value = product.SupplierId;
                    var price = cmd.Parameters.Add("@price", SqlDbType.Decimal);
                    price.Precision = 18; price.Scale = 2; price.Value = product.Price;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = product.Quantity;
                    cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 20).Value = product.UnitOfMeasure.Trim();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(int id)
        {
            using (var con = LocalDatabase.CreateConnection())
            using (var cmd = new SqlCommand("DELETE FROM dbo.tblProducts WHERE Id=@id", con))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                con.Open();
                try { cmd.ExecuteNonQuery(); }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                        throw new InvalidOperationException(
                            "This product belongs to an existing sale and cannot be deleted. Change its stock to zero instead.", ex);
                    throw;
                }
            }
        }
    }
}
