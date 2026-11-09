using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    // Created programmatically so your existing designer files stay untouched.
    public class SalesHistory : Form
    {
        private readonly SalesRepo repo = new SalesRepo();
        private readonly DataGridView grid = new DataGridView();

        public SalesHistory()
        {
            Text = "Sales History";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(820, 530);
            var refresh = new Button { Text = "Refresh", Dock = DockStyle.Left, Width = 110 };
            var openReceipt = new Button { Text = "View Receipt", Dock = DockStyle.Right, Width = 125 };
            var bar = new Panel { Dock = DockStyle.Top, Height = 45, Padding = new Padding(6) };
            bar.Controls.Add(refresh);
            bar.Controls.Add(openReceipt);
            grid.Dock = DockStyle.Fill;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Controls.Add(grid);
            Controls.Add(bar);
            refresh.Click += (s, e) => LoadSales();
            openReceipt.Click += (s, e) => OpenSelectedReceipt();
            grid.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) OpenSelectedReceipt(); };
            Shown += (s, e) => LoadSales();
        }

        private void LoadSales()
        {
            try { grid.DataSource = repo.GetRecentSales(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Sales Error"); }
        }

        private void OpenSelectedReceipt()
        {
            if (grid.CurrentRow == null) return;
            int id = Convert.ToInt32(grid.CurrentRow.Cells["Sale ID"].Value);
            if (string.Equals(Convert.ToString(grid.CurrentRow.Cells["Status"].Value), "Cancelled",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Cancelled sales do not have a completed-sale receipt.");
                return;
            }
            using (var receipt = new Receipt(id)) receipt.ShowDialog(this);
        }
    }
}
