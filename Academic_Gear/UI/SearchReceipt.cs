using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class SearchReceipt : Form
    {
        private readonly SalesRepo sales = new SalesRepo();

        public SearchReceipt()
        {
            InitializeComponent();
            dgSearchReceipt.ReadOnly = true;
            dgSearchReceipt.AllowUserToAddRows = false;
            dgSearchReceipt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSearchReceipt.MultiSelect = false;
            dgSearchReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPayment.Items.AddRange(new object[] { "All Payments", "Cash", "Card", "GCash" });
            cmbPayment.SelectedIndex = 0;
            dtReceipt.ShowCheckBox = true;
            dtReceipt.Checked = false;
            btnBack.Click += (s, e) => Close();
            btnSearchReceipt.Click += (s, e) => LoadReceipts();
            txtSearchReceipt.Enter += (s, e) =>
            {
                if (txtSearchReceipt.Text == "Search by Receipt Number....") txtSearchReceipt.Clear();
            };
            cmbPayment.SelectedIndexChanged += (s, e) => LoadReceipts();
            dtReceipt.ValueChanged += (s, e) => LoadReceipts();
            dgSearchReceipt.CellContentClick += ReceiptClicked;
            dgSearchReceipt.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) OpenReceipt(e.RowIndex); };
            Shown += (s, e) => LoadReceipts();
        }

        private void LoadReceipts()
        {
            try
            {
                string search = txtSearchReceipt.Text == "Search by Receipt Number...." ? "" : txtSearchReceipt.Text.Trim();
                string method = cmbPayment.SelectedIndex <= 0 ? "" : cmbPayment.SelectedItem.ToString();
                DateTime? date = dtReceipt.Checked ? (DateTime?)dtReceipt.Value.Date : null;
                DataTable table = sales.SearchReceipts(search, method, date);
                dgSearchReceipt.Rows.Clear();
                foreach (DataRow record in table.Rows)
                {
                    bool cancelled = Convert.ToString(record["Status"]) == "Cancelled";
                    int row = dgSearchReceipt.Rows.Add(record["Id"],
                        Convert.ToDateTime(record["SaleDate"]).ToString("yyyy-MM-dd HH:mm"),
                        Convert.ToString(record["CashierUsername"]), Convert.ToDecimal(record["TotalAmount"]).ToString("N2"),
                        Convert.ToString(record["PaymentMethod"]), cancelled ? "Cancelled" : "View",
                        cancelled ? "Cancelled" : "Cancel Sale");
                    dgSearchReceipt.Rows[row].Tag = Convert.ToInt32(record["Id"]);
                    if (cancelled) dgSearchReceipt.Rows[row].DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Receipt Search Error"); }
        }

        private void ReceiptClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string action = dgSearchReceipt.Columns[e.ColumnIndex].Name;
            if (action == "clmView") OpenReceipt(e.RowIndex);
            else if (action == "clmDelete") CancelReceipt(e.RowIndex);
        }

        private void OpenReceipt(int row)
        {
            int id = Convert.ToInt32(dgSearchReceipt.Rows[row].Tag);
            try
            {
                if (sales.GetSale(id) == null)
                {
                    MessageBox.Show("Sale has been cancelled; a completed receipt is not available.");
                    return;
                }
                using (var form = new Receipt(id)) form.ShowDialog(this);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Receipt Error"); }
        }

        private void CancelReceipt(int row)
        {
            if (Session.Role != "Admin") { MessageBox.Show("Only Admin can cancel completed sales."); return; }
            int id = Convert.ToInt32(dgSearchReceipt.Rows[row].Tag);
            if (MessageBox.Show("Cancel sale #" + id + " and restore its stock? This will preserve its history.",
                "Cancel Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                sales.CancelSale(id);
                LoadReceipts();
                MessageBox.Show("Sale cancelled and stock restored.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Cancellation Error"); }
        }
    }
}
