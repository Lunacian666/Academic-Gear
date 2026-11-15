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
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalesItem.AllowUserToAddRows = false;
            dgvSalesItem.ReadOnly = true;
            dgvSalesItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesItem.MultiSelect = false;
            dgvSalesItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalesItem.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "UpdateCart", HeaderText = "UPDATE", Text = "Update", UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvSalesItem.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "RemoveCart", HeaderText = "DELETE", Text = "Delete", UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            udQuantity.Minimum = 1;
            udQuantity.Maximum = 1000000;
            udQuantity.Value = 1;
            btnSearchPN.Click += (s, e) => LoadProducts();
            txtSearchProduct.TextChanged += (s, e) => LoadProducts();
            txtSearchProduct.Enter += (s, e) =>
            {
                if (txtSearchProduct.Text == "Search by product name...") txtSearchProduct.Clear();
            };
            btnAddProduct.Click += AddProduct;
            btnClear.Click += (s, e) => ClearCart(true);
            btnNewSale.Click += (s, e) => NewSale();
            btnProcessPayment.Click += ProcessPayment;
            txtDiscount.TextChanged += (s, e) => RefreshTotals();
            dgvSalesItem.CellContentClick += EditCart;
            Shown += (s, e) => { LoadProducts(); RefreshTotals(); };
        }

        private void LoadProducts()
        {
            try
            {
                string search = txtSearchProduct.Text == "Search by product name..." ? "" : txtSearchProduct.Text.Trim();
                dgvProducts.Rows.Clear();
                foreach (ProductInfo product in products.GetProducts(search))
                {
                    int row = dgvProducts.Rows.Add(product.ProductCode, product.ProductName,
                        product.CategoryName, product.Price.ToString("N2"), product.Quantity);
                    dgvProducts.Rows[row].Tag = product;
                }
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void AddProduct(object sender, EventArgs e)
        {
            ProductInfo selected = dgvProducts.CurrentRow?.Tag as ProductInfo;
            if (selected == null) { MessageBox.Show("Select a product first."); return; }
            try
            {
                ProductInfo live = products.GetProduct(selected.Id);
                if (live == null) throw new InvalidOperationException("Product not found. Refresh the list.");
                int quantity = (int)udQuantity.Value;
                SaleLine existing = cart.FirstOrDefault(x => x.ProductId == selected.Id);
                int current = existing == null ? 0 : existing.Quantity;
                if ((long)quantity + current > live.Quantity)
                    throw new InvalidOperationException("Only " + live.Quantity + " units available.");
                if (existing == null)
                    cart.Add(new SaleLine { ProductId = live.Id, ProductName = live.ProductName,
                        UnitPrice = live.Price, Quantity = quantity });
                else
                {
                    existing.Quantity += quantity;
                    existing.UnitPrice = live.Price;
                    existing.ProductName = live.ProductName;
                }
                RefreshCart();
                udQuantity.Value = 1;
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void EditCart(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int? id = dgvSalesItem.Rows[e.RowIndex].Tag as int?;
            if (!id.HasValue) return;
            SaleLine line = cart.FirstOrDefault(x => x.ProductId == id.Value);
            if (line == null) return;
            string name = dgvSalesItem.Columns[e.ColumnIndex].Name;
            if (name == "RemoveCart") { cart.Remove(line); RefreshCart(); return; }
            if (name != "UpdateCart") return;
            try
            {
                ProductInfo product = products.GetProduct(line.ProductId);
                if (product == null) throw new InvalidOperationException("Product no longer exists.");
                int? newQty = UiPrompts.AskQuantity(product.ProductName, line.Quantity, product.Quantity);
                if (!newQty.HasValue) return;
                line.Quantity = newQty.Value;
                line.UnitPrice = product.Price;
                line.ProductName = product.ProductName;
                RefreshCart();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void RefreshCart()
        {
            dgvSalesItem.Rows.Clear();
            foreach (SaleLine line in cart)
            {
                int row = dgvSalesItem.Rows.Add(line.ProductName, line.Quantity,
                    line.UnitPrice.ToString("N2"), line.LineTotal.ToString("N2"), "Update", "Delete");
                dgvSalesItem.Rows[row].Tag = line.ProductId;
            }
            RefreshTotals();
        }

        private decimal Subtotal { get { return cart.Sum(x => x.LineTotal); } }

        private bool TryGetDiscount(out decimal discount)
        {
            if (string.IsNullOrWhiteSpace(txtDiscount.Text)) { discount = 0m; return true; }
            return decimal.TryParse(txtDiscount.Text.Trim(), NumberStyles.Number,
                CultureInfo.CurrentCulture, out discount) && discount >= 0m && discount <= Subtotal;
        }

        private void RefreshTotals()
        {
            decimal discount;
            bool valid = TryGetDiscount(out discount);
            lblNumSubTotal.Text = Subtotal.ToString("N2");
            lblNumDiscount.Text = valid ? discount.ToString("N2") : "Invalid";
            lblNumTotalAmount.Text = valid ? (Subtotal - discount).ToString("N2") : "Invalid";
        }

        private string Method()
        {
            if (rbCash.Checked) return "Cash";
            if (rbCard.Checked) return "Card";
            if (rbGCash.Checked) return "GCash";
            return null;
        }

        private void ProcessPayment(object sender, EventArgs e)
        {
            if (cart.Count == 0) { MessageBox.Show("Add a product first."); return; }
            decimal discount;
            if (!TryGetDiscount(out discount)) { MessageBox.Show("Enter a valid discount."); return; }
            string method = Method();
            if (method == null) { MessageBox.Show("Select a payment method."); return; }
            decimal total = Subtotal - discount;
            decimal received = total;
            if (method == "Cash")
            {
                decimal? entered = UiPrompts.AskPayment(total);
                if (!entered.HasValue) return;
                received = entered.Value;
            }
            if (MessageBox.Show("Complete " + method + " payment of " + total.ToString("N2") + "?",
                "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                int id = sales.Checkout(cart, discount, method, received, Session.Username);
                lastSaleId = id;
                cart.Clear();
                txtDiscount.Clear();
                rbCash.Checked = rbCard.Checked = rbGCash.Checked = false;
                udQuantity.Value = 1;
                RefreshCart();
                LoadProducts();
                MessageBox.Show("Payment saved. Receipt #" + id + "\nStock updated.",
                    "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (var receipt = new Receipt(id)) receipt.ShowDialog(this);
            }
            catch (Exception ex) { ShowError(ex); LoadProducts(); }
        }

        private void ClearCart(bool ask)
        {
            if (ask && cart.Count > 0 && MessageBox.Show("Clear the current cart?", "Clear Cart",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            cart.Clear();
            RefreshCart();
        }

        private void NewSale()
        {
            if (cart.Count > 0 && MessageBox.Show("Discard the current cart?", "New Sale",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            ClearCart(false);
            txtDiscount.Clear();
            rbCash.Checked = rbCard.Checked = rbGCash.Checked = false;
            udQuantity.Value = 1;
            LoadProducts();
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close Point of Sale? Unsaved cart items will be discarded.",
                "Cancel Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = lastSaleId ?? sales.GetLatestSaleId();
                if (!id.HasValue) { MessageBox.Show("No completed sale is available yet."); return; }
                using (var receipt = new Receipt(id.Value)) receipt.ShowDialog(this);
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "POS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
