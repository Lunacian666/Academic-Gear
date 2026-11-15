using BusinessLogic.Repository;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class SalesHistory : Form
    {
        private readonly SalesRepo sales = new SalesRepo();

        public SalesHistory()
        {

            InitializeComponent();
            
            //search bar
            txtSearchProduct.Text = "Search by Product Name...";
            txtSearchProduct.ForeColor = Color.Black;

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
            txtSearchProduct.Enter += txtSearchProduct_Enter;
            txtSearchProduct.Leave += txtSearchProduct_Leave;

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
                string search = txtSearchProduct.Text.Trim();

                if (search == "Search by Product Name...")
                {
                    search = "";
                }
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

        private void txtSearchProduct_Enter(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text == "Search by Product Name...")
            {
                txtSearchProduct.Text = "";
                txtSearchProduct.ForeColor = Color.Black;
            }
        }
        

        private void txtSearchProduct_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchProduct.Text))
            {
                txtSearchProduct.Text = "Search by Product Name...";
                txtSearchProduct.ForeColor = Color.Black;
            }
        }
    }
}
