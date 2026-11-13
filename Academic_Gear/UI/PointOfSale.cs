using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PointOfSale : Form
    {
        //TEMPORARY POS
        private class CartLine
        {
            public string ProductCode { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }

            public decimal LineTotal
            {
                get { return Quantity *  UnitPrice; }
            }
        }

        private readonly List<CartLine> cart = new List<CartLine>();
        public PointOfSale()
        {
            InitializeComponent();

            // PRODUCTS DATAGRID
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.MultiSelect = false;
            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // SALES ITEMS DATAGRID
            dgvSalesItem.ReadOnly = true;
            dgvSalesItem.AllowUserToAddRows = false;
            dgvSalesItem.MultiSelect = false;
            dgvSalesItem.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // QUANTITY
            udQuantity.Minimum = 1;
            udQuantity.Maximum = 100000;
            udQuantity.Value = 1;

            // BUTTON EVENTS
            btnSearchPN.Click += (s, e) => LoadProducts();
            txtSearchProduct.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    LoadProducts();
                }
            };
            txtSearchProduct.Enter += (s, e) =>
            {
                if (txtSearchProduct.Text == "Search by product name...")
                {
                    txtSearchProduct.Clear();
                }
            };

            btnAddProduct.Click += btnAddProduct_Click;
            btnClear.Click += (s, e) =>
            {
                cart.Clear();
                RefreshCart();
            };

            btnNewSale.Click += btnProcessPayment_Click;
            dgvSalesItem.CellContentClick += CartClicked;
            txtDiscount.TextChanged += (s, e) => RefreshTotals();
            Shown += (s, e) =>
            {
                LoadProducts();
                RefreshCart();
            };

            btnProcessPayment.Click += btnProcessPayment_Click;

        }
        //LOAD PRODUCST
        private void LoadProducts()
        {
            try
            {
                string search = txtSearchProduct.Text == "Search by product name..." ? "" : txtSearchProduct.Text.Trim();
                dgvProducts.Rows.Clear();
                
                foreach(ProductItem item in ProductData.Products)
                {
                    if (!item.ProductName.ToLower().Contains(search.ToLower()))
                        continue;

                    int row = dgvProducts.Rows.Add(
                        item.ProductCode,
                        item.ProductName,
                        item.Category,
                        item.Price.ToString("N2"),
                        item.Quantity);

                    dgvProducts.Rows[row].Tag = item;
                }
            }

            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        //ADD PRODUCT SA CART
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Select a product first.");
                return;
            }
            string productCode = Convert.ToString(dgvProducts.CurrentRow.Cells[0].Value);
            ProductItem current = ProductData.Products.FirstOrDefault(x => x.ProductCode == productCode);

            if (current == null)
            {
                MessageBox.Show("Product no longer exists.");
                LoadProducts();
                return;
            }

            //get the quantity entered by the cashier
            int eneteredQuantity = (int)udQuantity.Value;

            //check the existing cart qty
            CartLine existing = cart.FirstOrDefault(x => x.ProductCode == productCode);

            int totalQuantity = eneteredQuantity + (existing == null ? 0 : existing.Quantity);

            //Check available inventory



            if(totalQuantity > current.Quantity)
            {
                MessageBox.Show(
                    "Only " + current.Quantity +
                    " unit(s) of available stock.");
                return;
            }

            int enteredQuantity = (int)udQuantity.Value;

            if (existing == null)
            {
                cart.Add(new CartLine { 
                ProductCode = current.ProductCode,
                ProductName = current.ProductName,
                Quantity = enteredQuantity,
                UnitPrice = current.Price
                });
            }
            else
            {
                existing.Quantity = totalQuantity;
                existing.UnitPrice = current.Price; 
            }
            RefreshCart();

            //reset quantity input
            udQuantity.Value = 1;
        }

        //CartItens: Delete at update
        private void CartClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string productCode = Convert.ToString(dgvSalesItem.Rows[e.RowIndex].Tag);

            CartLine item = cart.FirstOrDefault(x => x.ProductCode == productCode);

            if (item == null) return;

            string column = dgvSalesItem.Columns[e.ColumnIndex].Name;

            if (column == "clmDelete")
            {
                cart.Remove(item);
                RefreshCart();
            }

            else if(column == "clmUpdate")
            {
                ProductItem current = ProductData.Products.FirstOrDefault(x => x.ProductCode == productCode);

                if (current == null) return;

                int newQuantity = (int)udQuantity.Value;

                if(newQuantity > current.Quantity)
                {
                    MessageBox.Show("Only " + current.Quantity +
                        " unit(s) available.");
                    return;
                }

                item.Quantity = newQuantity;
                RefreshCart();
            }
        }

        //DataGrid: Refresh cart
        private void RefreshCart()
        {
            dgvSalesItem.Rows.Clear();

            foreach(CartLine item in cart)
            {
                int row = dgvSalesItem.Rows.Add(
                    item.ProductName,
                    item.Quantity,
                    item.UnitPrice.ToString("N2"),
                    item.LineTotal.ToString("N2"),
                    "Update",
                    "Delete");

                dgvSalesItem.Rows[row].Tag = item.ProductCode;
            }
            RefreshTotals();        
        }

        //SubTotal
        private decimal SubTotal
        {
            get
            {
                return cart.Sum(XmlReadMode => XmlReadMode.LineTotal);
            }
        }

        //Discount Validation
        private bool TryGetDiscount(out decimal discount)
        {
            string input = txtDiscount.Text.Trim();

            if (input == "")
            {
                discount = 0m;
                return true;
            }

            if (!decimal.TryParse(input,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out discount))
            {
                return false;
            }

            return discount >= 0m &&
                discount <= SubTotal;
        }

        //Refresh Total
        private void RefreshTotals()
        {
            decimal discount;

            bool valid = TryGetDiscount(out discount);
            
            lblNumSubTotal.Text = SubTotal.ToString("N2");
            lblNumDiscount.Text = valid ? discount.ToString("N2") : "Invalid";
            lblNumTotalAmount.Text = valid ? (SubTotal - discount).ToString("N2") : "--";
        }

        //Payment Method
        private string GetSelectedPaymentMethod()
        {
            if (rbCash.Checked) return "Cash";
            if (rbCard.Checked) return "Card";
            if (rbGCash.Checked) return "GCash";
            return null;
        }

        //Transfering ng sales sa admin hsitory
        private void TransferSalesHistory(string method, decimal discount)
        {
            decimal remainingDiscount = discount;
            decimal subTotal = cart.Sum(x => x.LineTotal);
            DateTime saleDate = DateTime.Now;

            for (int i = 0; i < cart.Count; i++)
            {
                CartLine item = cart[i];
                decimal lineDiscount;

                if( i == cart.Count - 1)
                {
                    lineDiscount = remainingDiscount;
                }
                else
                {
                    lineDiscount = Math.Round(discount * item.LineTotal / subTotal, 2);
                }

                remainingDiscount -= lineDiscount;
                SalesItem sale = new SalesItem
                {
                    ProductName = item.ProductName,
                    Price = item.UnitPrice,
                    Quantity = item.Quantity,
                    Total = item.LineTotal - lineDiscount,
                    Date = saleDate,
                    PaymentMethod = method
                };

                SalesData.SalesHistory.Add(sale);
            }
        }

        //pROCESS the PAyement
        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Add at least one product to the cart.");
                return;
            }

            decimal discount;
            if (!TryGetDiscount(out discount))
            {
                MessageBox.Show("Invalid discount amount.");
                return;
            }

            string method = GetSelectedPaymentMethod();

            if(method == null)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            decimal total = SubTotal - discount;

            if(MessageBox.Show("Process payment of " + 
                total.ToString("N2") + 
                " using " + method + "?",
                "Confirm Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                //ccheck muna ang stock bago bumawas
                foreach (CartLine item in cart)
                {
                    ProductItem product = ProductData.Products.FirstOrDefault(x => x.ProductCode == item.ProductCode);

                    if (product == null || product.Quantity < item.Quantity)
                    {
                        MessageBox.Show("Insufficient stock for " + item.ProductName + ". Please refresh the products.");
                        LoadProducts();
                        return;
                    }
                }

                //Transfer sa sales history
                TransferSalesHistory(method, discount);

                //Deduct sa inventory stock
                foreach(CartLine item in cart)
                {
                    ProductItem product = ProductData.Products.FirstOrDefault(
                            x => x.ProductCode == item.ProductCode);
                    product.Quantity -= item.Quantity;
                }
                cart.Clear();
                txtDiscount.Clear();
                RefreshCart();
                LoadProducts();

                MessageBox.Show(
                    "Payment processed successfully!\n\n" +
                    "Sales transferred to Admin Sales History.\n" +
                    "Inventory stock updated successfully.",
                    "Payment Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        //New sale
        private void NewSale()
        {
            if(cart.Count > 0 &&
                MessageBox.Show("" +
                "Clear the current cart and start a new sale?",
                "New Sale", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes){
                return;
            }
            cart.Clear();
            txtDiscount.Clear();
            rbCash.Checked = false;
            rbCard.Checked = false;
            rbGCash.Checked = false;

            udQuantity.Value = 1;

            RefreshCart();
            LoadProducts();
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(
                "Are you sure you want to cancel the sale?",
                "Cancel sale",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Close();
            }
        }
        
        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            Receipt receiptForm = new Receipt();

            receiptForm.ShowDialog(this);
        }
        
        //eRROR HANDLING
        private static void ShowError(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "POS Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnProcessPayment_Click_1(object sender, EventArgs e)
        {
            //is empty cart?
            if(cart.Count == 0)
            {
                MessageBox.Show("Please add products first.");
                    return;
            }

            //get payment method
            string method = rbCash.Checked ? "Cash" :
                    rbCard.Checked ? "Card" :
                    rbGCash.Checked ? "GCash" : null;

            if (method == null)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            // Get discount
            decimal discount;

            if (!TryGetDiscount(out discount))
            {
                MessageBox.Show("Invalid discount amount.");
                return;
            }

            decimal total = SubTotal - discount;

            // Confirm payment
            DialogResult result = MessageBox.Show(
                "Total Amount: " + total.ToString("N2") +
                "\nPayment Method: " + method +
                "\n\nConfirm payment?",
                "Process Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                // Transfer products to Admin Sales History
                TransferSalesHistory(method, discount);

                MessageBox.Show(
                    "Payment successful!\nSales transferred to Admin Sales History.",
                    "Payment Completed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Clear POS cart after successful transfer
                cart.Clear();

                txtDiscount.Clear();

                rbCash.Checked = false;
                rbCard.Checked = false;
                rbGCash.Checked = false;

                udQuantity.Value = 1;

                RefreshCart();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}