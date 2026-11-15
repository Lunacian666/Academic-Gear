using System;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Database;

namespace BusinessLogic.Repository
{
    public class SupplierRepo
    {
        public DataTable GetSuppliers()
        {
            var table = new DataTable();
            using (var con = LocalDatabase.CreateConnection())
            using (var adapter = new SqlDataAdapter("SELECT Id, SupplierName, ContactPerson, ContactNumber FROM dbo.tblSuppliers ORDER BY SupplierName", con))
                adapter.Fill(table);
            return table;
        }

        public void Save(int id, string name, string person, string phone)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Trim().Length > 100 ||
                (person ?? "").Length > 100 || (phone ?? "").Length > 20)
                throw new ArgumentException("Enter valid supplier details.");
            using (var con = LocalDatabase.CreateConnection())
            using (var cmd = new SqlCommand(@"IF @id > 0 AND @name <> N'Default Supplier' AND EXISTS
(SELECT 1 FROM dbo.tblSuppliers WHERE Id=@id AND SupplierName=N'Default Supplier')
    THROW 50003, 'The default supplier name cannot be changed.', 1;
IF @id = 0
INSERT INTO dbo.tblSuppliers (SupplierName, ContactPerson, ContactNumber) VALUES (@name, @person, @phone)
ELSE UPDATE dbo.tblSuppliers SET SupplierName=@name, ContactPerson=@person, ContactNumber=@phone WHERE Id=@id", con))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = name.Trim();
                cmd.Parameters.Add("@person", SqlDbType.NVarChar, 100).Value = person ?? "";
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 20).Value = phone ?? "";
                con.Open();
                if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("Supplier not found.");
            }
        }

        public void Delete(int id)
        {
            using (var con = LocalDatabase.CreateConnection())
            using (var cmd = new SqlCommand(@"IF EXISTS (SELECT 1 FROM dbo.tblSuppliers WHERE Id=@id AND SupplierName=N'Default Supplier')
THROW 50004, 'Default Supplier cannot be deleted.', 1;
DELETE FROM dbo.tblSuppliers WHERE Id=@id", con))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                con.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("Supplier not found.");
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                        throw new InvalidOperationException("This supplier is used by products and cannot be deleted.", ex);
                    throw;
                }
            }
        }
    }
}
