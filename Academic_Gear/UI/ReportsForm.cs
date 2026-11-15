using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public sealed class ReportsForm : Form
    {
        private readonly SalesRepo sales = new SalesRepo();
        private readonly ProductRepo products = new ProductRepo();
        private readonly DataGridView grid = new DataGridView();
        private readonly Label totals = new Label();

        public ReportsForm()
        {
            Text = "AcademicGear Reports";
            Size = new Size(850, 600);
            StartPosition = FormStartPosition.CenterScreen;
            var bar = new Panel { Dock = DockStyle.Top, Height = 95 };
            totals.AutoSize = false;
            totals.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            totals.Location = new Point(12, 8);
            totals.Size = new Size(810, 55);
            var refresh = new Button { Text = "Refresh", Location = new Point(12, 63), Width = 100 };
            var back = new Button { Text = "Back", Location = new Point(122, 63), Width = 100 };
            refresh.Click += (s, e) => Reload();
            back.Click += (s, e) => Close();
            bar.Controls.AddRange(new Control[] { totals, refresh, back });
            grid.Dock = DockStyle.Fill;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Controls.Add(grid);
            Controls.Add(bar);
            Shown += (s, e) => Reload();
        }

        private void Reload()
        {
            try
            {
                DataTable records = sales.GetHistoryLines();
                var items = products.GetProducts();
                SalesSummary summary = sales.GetSummary();
                int low = items.Count(p => p.Quantity <= 10);
                totals.Text = "Sales: " + summary.CompletedSales + "   Net: " + summary.Net.ToString("N2") +
                    "   Discounts: " + summary.Discounts.ToString("N2") +
                    "\nProducts: " + items.Count + "   Low stock: " + low +
                    "   Gross: " + summary.Gross.ToString("N2");
                grid.DataSource = records;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Reports Error"); }
        }
    }
}
