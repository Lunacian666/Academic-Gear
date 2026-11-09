using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class PointOfSale : Form
    {
        private readonly ProductRepo products = new ProductRepo();
        private readonly SalesRepo sales = new SalesRepo();
        private readonly List<SaleLine> cart = new List<SaleLine>();
        private int? lastSaleId;

        public PointOfSale()
        {
            InitializeComponent();
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.MultiSelect = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesItem.ReadOnly = true;
            dgvSalesItem.AllowUserToAddRows = false;
            dgvSalesItem.MultiSelect = false;
            dgvSalesItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            udQuantity.Minimum = 1;
            udQuantity.Maximum = 100000;
            udQuantity.Value = 1;
            btnSearchPN.Click += (s, e) => LoadProducts();
            txtSearchProduct.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; LoadProducts(); }
            };
            txtSearchProduct.Enter += (s, e) =>
            {
                if (txtSearchProduct.Text == "Search by product name...") txtSearchProduct.Clear();
            };
            btnAddProduct.Click += btnAddProduct_Click;
            btnClear.Click += (s, e) => { cart.Clear(); RefreshCart(); };
            btnNewSale.Click += (s, e) => NewSale();
            btnProcessPayment.Click += btnProcessPayment_Click;
            dgvSalesItem.CellContentClick += CartClicked;
            txtDiscount.TextChanged += (s, e) => RefreshTotals();
            Shown += (s, e) => { LoadProducts(); RefreshCart(); };
        }

        private void LoadProducts()
        {
            try
            {
                string search = txtSearchProduct.Text == "Search by product name..." ? "" : txtSearchProduct.Text;
                dgvProducts.Rows.Clear();
                foreach (ProductInfo item in products.GetProducts(search))
                {
                    int row = dgvProducts.Rows.Add(item.ProductCode, item.ProductName,
                        item.CategoryName, item.Price.ToString("N2"), item.Quantity);
                    dgvProducts.Rows[row].Tag = item;
                }
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) { MessageBox.Show("Select a product first."); return; }
            var selected = dgvProducts.CurrentRow.Tag as ProductInfo;
            if (selected == null) return;
            try
            {
                ProductInfo current = products.GetProduct(selected.Id);
                if (current == null) { MessageBox.Show("Product no longer exists."); LoadProducts(); return; }
                SaleLine existing = cart.FirstOrDefault(x => x.ProductId == selected.Id);
                int desired = (int)udQuantity.Value + (existing == null ? 0 : existing.Quantity);
                if (desired > current.Quantity)
                {
                    MessageBox.Show("Only " + current.Quantity + " unit(s) of " + current.ProductName + " available.");
                    return;
                }
                if (existing == null)
                    cart.Add(new SaleLine { ProductId = current.Id, ProductName = current.ProductName,
                        Quantity = desired, UnitPrice = current.Price });
                else
                {
                    existing.Quantity = desired;
                    existing.UnitPrice = current.Price;
                    existing.ProductName = current.ProductName;
                }
                RefreshCart();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void CartClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int id = (int)dgvSalesItem.Rows[e.RowIndex].Tag;
            SaleLine entry = cart.FirstOrDefault(x => x.ProductId == id);
            if (entry == null) return;
            string column = dgvSalesItem.Columns[e.ColumnIndex].Name;
            if (column == "clmDelete") { cart.Remove(entry); RefreshCart(); }
            else if (column == "clmUpdate")
            {
                try
                {
                    ProductInfo current = products.GetProduct(id);
                    if (current == null) { MessageBox.Show("Product no longer exists."); return; }
                    int? qty = UiPrompts.AskQuantity(entry.ProductName, entry.Quantity, current.Quantity);
                    if (!qty.HasValue) return;
                    entry.Quantity = qty.Value;
                    entry.UnitPrice = current.Price;
                    RefreshCart();
                }
                catch (Exception ex) { ShowError(ex); }
            }
        }

        private void RefreshCart()
        {
            dgvSalesItem.Rows.Clear();
            foreach (SaleLine item in cart)
            {
                int row = dgvSalesItem.Rows.Add(item.ProductName, item.Quantity,
                    item.UnitPrice.ToString("N2"), item.LineTotal.ToString("N2"), "Update", "Delete");
                dgvSalesItem.Rows[row].Tag = item.ProductId;
            }
            RefreshTotals();
        }

        private decimal Subtotal { get { return cart.Sum(x => x.LineTotal); } }

        private bool TryGetDiscount(out decimal discount)
        {
            string input = txtDiscount.Text.Trim();
            if (input == "") { discount = 0m; return true; }
            if (!decimal.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out discount))
                return false;
            return discount >= 0m && discount <= Subtotal;
        }

        private void RefreshTotals()
        {
            decimal subtotal = Subtotal;
            decimal discount;
            bool valid = TryGetDiscount(out discount);
            lblNumSubTotal.Text = subtotal.ToString("N2");
            lblNumDiscount.Text = valid ? discount.ToString("N2") : "Invalid";
            lblNumTotalAmount.Text = valid ? (subtotal - discount).ToString("N2") : "--";
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0) { MessageBox.Show("Add at least one product to the cart."); return; }
            decimal discount;
            if (!TryGetDiscount(out discount))
            {
                MessageBox.Show("Discount must be a valid amount between zero and the subtotal."); return;
            }
            string method = rbCash.Checked ? "Cash" : rbCard.Checked ? "Card" : rbGCash.Checked ? "GCash" : null;
            if (method == null) { MessageBox.Show("Select a payment method."); return; }
            decimal total = Subtotal - discount;
            decimal received = total;
            if (method == "Cash")
            {
                decimal? entered = UiPrompts.AskPayment(total);
                if (!entered.HasValue) return;
                received = entered.Value;
            }
            if (MessageBox.Show("Process payment of " + total.ToString("N2") + " using " + method + "?",
                "Confirm Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                int saleId = sales.Checkout(cart.ToList(), discount, method, received,
                    string.IsNullOrWhiteSpace(Session.Username) ? "cashier" : Session.Username);
                lastSaleId = saleId;
                cart.Clear();
                txtDiscount.Clear();
                RefreshCart();
                LoadProducts();
                MessageBox.Show("Payment saved! Receipt #" + saleId, "Sale Completed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (var receipt = new Receipt(saleId)) receipt.ShowDialog(this);
            }
            catch (Exception ex) { ShowError(ex); LoadProducts(); }
        }

        private void NewSale()
        {
            if (cart.Count > 0 && MessageBox.Show("Clear the current cart and start a new sale?",
                "New Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            cart.Clear();
            lastSaleId = null;
            txtDiscount.Clear();
            rbCash.Checked = false; rbCard.Checked = false; rbGCash.Checked = false;
            udQuantity.Value = 1;
            RefreshCart();
            LoadProducts();
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel this sale and return to the dashboard?", "Cancel Sale",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (!lastSaleId.HasValue) { MessageBox.Show("Process a payment before printing a receipt."); return; }
            using (var receipt = new Receipt(lastSaleId.Value)) receipt.ShowDialog(this);
        }

        private static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "POS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
