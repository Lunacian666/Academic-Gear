using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class SalesHistory : Form
    {
        private readonly SalesRepo sales = new SalesRepo();

        public SalesHistory()
        {
            InitializeComponent();
            dgSalesHistory.ReadOnly = true;
            dgSalesHistory.AllowUserToAddRows = false;
            dgSalesHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSalesHistory.MultiSelect = false;
            dgSalesHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPayment.Items.AddRange(new object[] { "All Payments", "Cash", "Card", "GCash" });
            cmbPayment.SelectedIndex = 0;
            dtSalesHistory.ShowCheckBox = true;
            dtSalesHistory.Checked = false;
            btnBack.Click += (s, e) => Close();
            btnSearchPN.Click += (s, e) => LoadSales();
            txtSearchProduct.TextChanged += (s, e) => LoadSales();
            txtSearchProduct.Enter += (s, e) =>
            {
                if (txtSearchProduct.Text == "Search by product name...") txtSearchProduct.Clear();
            };
            cmbPayment.SelectedIndexChanged += (s, e) => LoadSales();
            dtSalesHistory.ValueChanged += (s, e) => LoadSales();
            dgSalesHistory.CellDoubleClick += OpenReceipt;
            Shown += (s, e) => LoadSales();
        }

        private void LoadSales()
        {
            try
            {
                DataTable table = sales.GetHistoryLines();
                string search = txtSearchProduct.Text == "Search by product name..." ? "" : txtSearchProduct.Text.Trim();
                string method = cmbPayment.SelectedIndex <= 0 ? "" : cmbPayment.SelectedItem.ToString();
                dgSalesHistory.Rows.Clear();
                foreach (DataRow data in table.Rows)
                {
                    string productName = Convert.ToString(data["ProductName"]);
                    if (search.Length > 0 && productName.IndexOf(search, StringComparison.OrdinalIgnoreCase) < 0 &&
                        Convert.ToString(data["SaleId"]).IndexOf(search, StringComparison.OrdinalIgnoreCase) < 0) continue;
                    if (method.Length > 0 && !string.Equals(method, Convert.ToString(data["PaymentMethod"]),
                        StringComparison.OrdinalIgnoreCase)) continue;
                    DateTime date = Convert.ToDateTime(data["SaleDate"]);
                    if (dtSalesHistory.Checked && date.Date != dtSalesHistory.Value.Date) continue;
                    int row = dgSalesHistory.Rows.Add(productName, Convert.ToDecimal(data["Price"]).ToString("N2"),
                        data["Quantity"], Convert.ToDecimal(data["Total"]).ToString("N2"),
                        date.ToString("yyyy-MM-dd HH:mm"), Convert.ToString(data["PaymentMethod"]));
                    dgSalesHistory.Rows[row].Tag = Convert.ToInt32(data["SaleId"]);
                    if (string.Equals(Convert.ToString(data["Status"]), "Cancelled", StringComparison.OrdinalIgnoreCase))
                        dgSalesHistory.Rows[row].DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Sales History Error"); }
        }

        private void OpenReceipt(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dgSalesHistory.Rows[e.RowIndex].Tag);
            try
            {
                if (sales.GetSale(id) == null)
                {
                    MessageBox.Show("This sale was cancelled. Its completed receipt is unavailable.");
                    return;
                }
                using (var form = new Receipt(id)) form.ShowDialog(this);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Receipt Error"); }
        }
    }
}
