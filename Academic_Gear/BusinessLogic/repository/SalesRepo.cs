using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using BusinessLogic.Database;

namespace BusinessLogic.Repository
{
    public sealed class SaleLine
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get { return UnitPrice * Quantity; } }
    }

    public sealed class SaleInfo
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Cashier { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public decimal Received { get; set; }
        public decimal Change { get; set; }
        public List<SaleLine> Items { get; set; } = new List<SaleLine>();
    }

    public sealed class SalesSummary
    {
        public int CompletedSales { get; set; }
        public decimal Gross { get; set; }
        public decimal Discounts { get; set; }
        public decimal Net { get; set; }
    }

    public class SalesRepo
    {
        public int Checkout(IList<SaleLine> cart, decimal discount, string paymentMethod,
                            decimal amountReceived, string cashier)
        {
            if (cart == null || cart.Count == 0) throw new InvalidOperationException("The cart is empty.");
            if (cart.Any(x => x.ProductId <= 0 || x.Quantity <= 0))
                throw new InvalidOperationException("Invalid product or quantity.");
            if (cart.Select(x => x.ProductId).Distinct().Count() != cart.Count)
                throw new InvalidOperationException("The same product is in the cart more than once.");
            if (discount < 0 || amountReceived < 0)
                throw new InvalidOperationException("Invalid discount or payment.");
            if (paymentMethod != "Cash" && paymentMethod != "Card" && paymentMethod != "GCash")
                throw new InvalidOperationException("Choose Cash, Card, or GCash.");

            using (var con = LocalDatabase.CreateConnection())
            {
                con.Open();
                using (SqlTransaction tx = con.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        var confirmed = new List<SaleLine>();
                        decimal subtotal = 0m;

                        foreach (var item in cart.OrderBy(x => x.ProductId))
                        {
                            using (var cmd = new SqlCommand(@"
SELECT ProductName, Price, Quantity FROM dbo.tblProducts WITH (UPDLOCK, HOLDLOCK)
WHERE Id = @id;", con, tx))
                            {
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = item.ProductId;
                                using (var reader = cmd.ExecuteReader())
                                {
                                    if (!reader.Read())
                                        throw new InvalidOperationException("A product in your cart no longer exists.");
                                    string name = reader.GetString(0);
                                    decimal price = reader.GetDecimal(1);
                                    int available = reader.GetInt32(2);
                                    if (available < item.Quantity)
                                        throw new InvalidOperationException(name + " only has " + available + " unit(s) available.");
                                    confirmed.Add(new SaleLine
                                    {
                                        ProductId = item.ProductId,
                                        ProductName = name,
                                        Quantity = item.Quantity,
                                        UnitPrice = price
                                    });
                                    subtotal = checked(subtotal + price * item.Quantity);
                                }
                            }
                        }

                        subtotal = decimal.Round(subtotal, 2);
                        if (discount > subtotal)
                            throw new InvalidOperationException("Discount cannot exceed the subtotal.");
                        decimal total = subtotal - discount;
                        if (amountReceived < total)
                            throw new InvalidOperationException("Amount received is less than the total. Please check current prices.");
                        decimal change = amountReceived - total;
                        int saleId;

                        using (var cmd = new SqlCommand(@"
INSERT INTO dbo.tblSales
(Subtotal, Discount, TotalAmount, PaymentMethod, AmountReceived, ChangeAmount, CashierUsername, Status)
OUTPUT INSERTED.Id
VALUES (@subtotal, @discount, @total, @method, @received, @change, @cashier, N'Completed');", con, tx))
                        {
                            AddMoney(cmd, "@subtotal", subtotal);
                            AddMoney(cmd, "@discount", discount);
                            AddMoney(cmd, "@total", total);
                            AddMoney(cmd, "@received", amountReceived);
                            AddMoney(cmd, "@change", change);
                            cmd.Parameters.Add("@method", SqlDbType.NVarChar, 20).Value = paymentMethod;
                            cmd.Parameters.Add("@cashier", SqlDbType.NVarChar, 50).Value =
                                (object)(cashier ?? "cashier");
                            saleId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        foreach (var item in confirmed)
                        {
                            using (var cmd = new SqlCommand(@"
INSERT INTO dbo.tblSaleItems (SaleId, ProductId, Quantity, UnitPrice, ProductNameSnapshot)
VALUES (@sale, @product, @qty, @price, @name);", con, tx))
                            {
                                cmd.Parameters.Add("@sale", SqlDbType.Int).Value = saleId;
                                cmd.Parameters.Add("@product", SqlDbType.Int).Value = item.ProductId;
                                cmd.Parameters.Add("@qty", SqlDbType.Int).Value = item.Quantity;
                                AddMoney(cmd, "@price", item.UnitPrice);
                                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = item.ProductName;
                                cmd.ExecuteNonQuery();
                            }

                            using (var cmd = new SqlCommand(@"
UPDATE dbo.tblProducts SET Quantity = Quantity - @qty
WHERE Id = @id AND Quantity >= @qty;", con, tx))
                            {
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = item.ProductId;
                                cmd.Parameters.Add("@qty", SqlDbType.Int).Value = item.Quantity;
                                if (cmd.ExecuteNonQuery() != 1)
                                    throw new InvalidOperationException("Stock changed during checkout. No sale was saved.");
                            }
                        }
                        tx.Commit();
                        return saleId;
                    }
                    catch
                    {
                        try { tx.Rollback(); } catch (SqlException) { }
                        throw;
                    }
                }
            }
        }

        private static void AddMoney(SqlCommand cmd, string name, decimal value)
        {
            var p = cmd.Parameters.Add(name, SqlDbType.Decimal);
            p.Precision = 18; p.Scale = 2; p.Value = value;
        }

        public SaleInfo GetSale(int saleId)
        {
            using (var con = LocalDatabase.CreateConnection())
            {
                con.Open();
                SaleInfo sale;
                using (var cmd = new SqlCommand(@"
SELECT Id, SaleDate, CashierUsername, PaymentMethod,
       Subtotal, Discount, TotalAmount, AmountReceived, ChangeAmount
FROM dbo.tblSales WHERE Id = @id AND Status = N'Completed';", con))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = saleId;
                    using (var r = cmd.ExecuteReader())
                    {
                        if (!r.Read()) return null;
                        sale = new SaleInfo
                        {
                            Id = r.GetInt32(0),
                            Date = r.GetDateTime(1),
                            Cashier = r.IsDBNull(2) ? "cashier" : r.GetString(2),
                            PaymentMethod = r.GetString(3),
                            Subtotal = r.GetDecimal(4),
                            Discount = r.GetDecimal(5),
                            Total = r.GetDecimal(6),
                            Received = r.IsDBNull(7) ? r.GetDecimal(6) : r.GetDecimal(7),
                            Change = r.IsDBNull(8) ? 0m : r.GetDecimal(8)
                        };
                    }
                }
                using (var cmd = new SqlCommand(@"
SELECT si.ProductId, COALESCE(si.ProductNameSnapshot, p.ProductName), si.Quantity, si.UnitPrice
FROM dbo.tblSaleItems si
JOIN dbo.tblProducts p ON p.Id=si.ProductId
WHERE si.SaleId=@id ORDER BY si.Id;", con))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = saleId;
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                            sale.Items.Add(new SaleLine
                            {
                                ProductId = r.GetInt32(0),
                                ProductName = r.GetString(1),
                                Quantity = r.GetInt32(2),
                                UnitPrice = r.GetDecimal(3)
                            });
                    }
                }
                return sale;
            }
        }

        public DataTable GetRecentSales()
        {
            var table = new DataTable();
            using (var con = LocalDatabase.CreateConnection())
            using (var adapter = new SqlDataAdapter(@"
SELECT TOP 100 Id AS [Sale ID], SaleDate AS [Date],
 CashierUsername AS [Cashier], PaymentMethod AS [Method],
 TotalAmount AS [Total], Status
FROM dbo.tblSales ORDER BY Id DESC;", con))
                adapter.Fill(table);
            return table;
        }

        public int? GetLatestSaleId()
        {
            using (var con = LocalDatabase.CreateConnection())
            using (var cmd = new SqlCommand(@"
SELECT TOP 1 Id FROM dbo.tblSales WHERE Status = N'Completed' ORDER BY Id DESC;", con))
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                return result == null || result == DBNull.Value ? (int?)null : Convert.ToInt32(result);
            }
        }
        public DataTable GetHistoryLines()
        {
            var table = new DataTable();
            using (var con = LocalDatabase.CreateConnection())
            using (var adapter = new SqlDataAdapter(@"
SELECT s.Id AS SaleId, COALESCE(si.ProductNameSnapshot, p.ProductName) AS ProductName,
si.UnitPrice AS Price, si.Quantity, si.LineTotal AS Total,
s.SaleDate AS SaleDate, s.PaymentMethod AS PaymentMethod, s.Status AS Status
FROM dbo.tblSaleItems si
JOIN dbo.tblSales s ON s.Id=si.SaleId
JOIN dbo.tblProducts p ON p.Id=si.ProductId
ORDER BY s.Id DESC, si.Id;", con))
            {
                adapter.Fill(table);
            }
            return table;
        }

        public DataTable SearchReceipts(string search, string method, DateTime? date)
        {
            var table = new DataTable();
            using (var con = LocalDatabase.CreateConnection())
            using (var cmd = new SqlCommand(@"
SELECT TOP 200 s.Id, s.SaleDate, s.CashierUsername, s.TotalAmount, s.PaymentMethod, s.Status
FROM dbo.tblSales s
WHERE (@search = '' OR CONVERT(VARCHAR(20), s.Id) LIKE '%' + @search + '%'
    OR s.CashierUsername LIKE '%' + @search + '%')
AND (@method = '' OR s.PaymentMethod=@method)
AND (@date IS NULL OR CAST(s.SaleDate AS DATE)=@date)
ORDER BY s.Id DESC;", con))
            {
                cmd.Parameters.Add("@search", SqlDbType.VarChar, 80).Value = (search ?? "").Trim();
                cmd.Parameters.Add("@method", SqlDbType.NVarChar, 20).Value = method ?? "";
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = date.HasValue ? (object)date.Value.Date : DBNull.Value;
                using (var adapter = new SqlDataAdapter(cmd)) adapter.Fill(table);
            }
            return table;
        }

        public void CancelSale(int saleId)
        {
            using (var con = LocalDatabase.CreateConnection())
            {
                con.Open();
                using (var tx = con.BeginTransaction())
                {
                    try
                    {
                        using (var cmd = new SqlCommand(@"
UPDATE dbo.tblSales SET Status=N'Cancelled'
WHERE Id=@id AND Status=N'Completed';", con, tx))
                        {
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = saleId;
                            if (cmd.ExecuteNonQuery() != 1)
                                throw new InvalidOperationException("Sale not found or already cancelled.");
                        }
                        using (var cmd = new SqlCommand(@"
UPDATE p SET p.Quantity=p.Quantity+si.Quantity
FROM dbo.tblProducts p JOIN dbo.tblSaleItems si ON si.ProductId=p.Id
WHERE si.SaleId=@id AND p.Quantity <= 2147483647-si.Quantity;", con, tx))
                        {
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = saleId;
                            int restored = cmd.ExecuteNonQuery();
                            using (var verify = new SqlCommand("SELECT COUNT(*) FROM dbo.tblSaleItems WHERE SaleId=@id", con, tx))
                            {
                                verify.Parameters.Add("@id", SqlDbType.Int).Value = saleId;
                                if (restored != Convert.ToInt32(verify.ExecuteScalar()))
                                    throw new InvalidOperationException("Could not restore stock safely.");
                            }
                        }
                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        public SalesSummary GetSummary()
        {
            using (var con = LocalDatabase.CreateConnection())
            using (var cmd = new SqlCommand(@"
SELECT COUNT(*), COALESCE(SUM(Subtotal),0), COALESCE(SUM(Discount),0),
COALESCE(SUM(TotalAmount),0)
FROM dbo.tblSales WHERE Status=N'Completed';", con))
            {
                con.Open();
                using (var r = cmd.ExecuteReader())
                {
                    r.Read();
                    return new SalesSummary
                    {
                        CompletedSales = r.GetInt32(0),
                        Gross = r.GetDecimal(1),
                        Discounts = r.GetDecimal(2),
                        Net = r.GetDecimal(3)
                    };
                }
            }
        }

    }
}
