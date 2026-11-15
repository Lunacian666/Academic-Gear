using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public sealed class StockAvailability : Form
    {
        private readonly ProductRepo products = new ProductRepo();
        private readonly DataGridView grid = new DataGridView();
        private readonly TextBox search = new TextBox();
        private readonly CheckBox lowStock = new CheckBox();

        public StockAvailability()
        {
            Text = "Product Catalog and Stock Availability";
            Size = new Size(920, 600);
            StartPosition = FormStartPosition.CenterScreen;
            var bar = new Panel { Dock = DockStyle.Top, Height = 52 };
            search.Location = new Point(12, 13);
            search.Width = 260;
            lowStock.Text = "Low Stock (10 or fewer)";
            lowStock.Location = new Point(285, 14);
            lowStock.Width = 188;
            var refresh = new Button { Text = "Refresh", Location = new Point(510, 10), Width = 90 };
            var back = new Button { Text = "Back", Location = new Point(610, 10), Width = 90 };
            bar.Controls.AddRange(new Control[] { search, lowStock, refresh, back });
            grid.Dock = DockStyle.Fill;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.Columns.Add("code", "Product Code");
            grid.Columns.Add("product", "Product Name");
            grid.Columns.Add("category", "Category");
            grid.Columns.Add("unit", "Unit");
            grid.Columns.Add("price", "Price");
            grid.Columns.Add("quantity", "Stock");
            Controls.Add(grid);
            Controls.Add(bar);
            search.TextChanged += (s, e) => Reload();
            lowStock.CheckedChanged += (s, e) => Reload();
            refresh.Click += (s, e) => Reload();
            back.Click += (s, e) => Close();
            Shown += (s, e) => Reload();
        }

        private void Reload()
        {
            try
            {
                grid.Rows.Clear();
                foreach (ProductInfo p in products.GetProducts(search.Text))
                {
                    if (lowStock.Checked && p.Quantity > 10) continue;
                    grid.Rows.Add(p.ProductCode, p.ProductName, p.CategoryName, p.UnitOfMeasure,
                        p.Price.ToString("N2"), p.Quantity);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Catalog Error"); }
        }
    }
}
