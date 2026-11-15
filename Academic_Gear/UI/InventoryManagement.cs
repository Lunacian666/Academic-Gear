using System;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class InventoryManagement : Form
    {
        private readonly ProductRepo products = new ProductRepo();
        private bool loading;

        public InventoryManagement()
        {
            InitializeComponent();
            dgvProductManagement.ReadOnly = true;
            dgvProductManagement.AllowUserToAddRows = false;
            dgvProductManagement.MultiSelect = false;
            dgvProductManagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductManagement.AutoGenerateColumns = false;
            dgvProductManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AddAction("ViewProduct", "VIEW", "View");
            AddAction("AddProductStock", "ADD STOCK", "Add Stock");
            AddAction("EditProduct", "EDIT", "Edit");
            AddAction("DeleteProduct", "DELETE", "Delete");
            dgvProductManagement.CellContentClick += ProductClicked;
            btnSearchPN.Click += (s, e) => LoadProducts();
            txtSearchProduct.TextChanged += (s, e) => LoadProducts();
            txtSearchProduct.Enter += (s, e) => { if (txtSearchProduct.Text == "Search by product name...") txtSearchProduct.Clear(); };
            cmbCategories.SelectedIndexChanged += (s, e) => { if (!loading) LoadProducts(); };
            Shown += (s, e) => Reload();
        }

        private void AddAction(string name, string header, string value)
        {
            if (dgvProductManagement.Columns.Contains(name)) return;
            dgvProductManagement.Columns.Add(new DataGridViewButtonColumn
            {
                Name = name, HeaderText = header, Text = value, UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }

        private void Reload()
        {
            try
            {
                loading = true;
                string previous = (cmbCategories.SelectedItem as CategoryInfo)?.Name;
                cmbCategories.Items.Clear();
                cmbCategories.Items.Add("All Categories");
                foreach (CategoryInfo category in products.GetCategories()) cmbCategories.Items.Add(category);
                cmbCategories.SelectedIndex = 0;
                if (!string.IsNullOrEmpty(previous))
                    for (int i = 1; i < cmbCategories.Items.Count; i++)
                        if ((cmbCategories.Items[i] as CategoryInfo).Name == previous) cmbCategories.SelectedIndex = i;
                loading = false;
                LoadProducts();
            }
            catch (Exception ex) { loading = false; ShowError(ex); }
        }

        private void LoadProducts()
        {
            if (loading) return;
            try
            {
                string search = txtSearchProduct.Text == "Search by product name..." ? "" : txtSearchProduct.Text.Trim();
                int? category = (cmbCategories.SelectedItem as CategoryInfo)?.Id;
                dgvProductManagement.Rows.Clear();
                foreach (ProductInfo product in products.GetProducts(search, category))
                {
                    int row = dgvProductManagement.Rows.Add(product.ProductCode, product.ProductName,
                        product.CategoryName, product.Price.ToString("N2"), product.Quantity,
                        "View", "Add Stock", "Edit", "Delete");
                    dgvProductManagement.Rows[row].Tag = product;
                }
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void ProductClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            ProductInfo product = dgvProductManagement.Rows[e.RowIndex].Tag as ProductInfo;
            if (product == null) return;
            string action = dgvProductManagement.Columns[e.ColumnIndex].Name;
            try
            {
                if (action == "ViewProduct")
                    MessageBox.Show("Code: " + product.ProductCode + "\nName: " + product.ProductName +
                        "\nCategory: " + product.CategoryName + "\nUnit: " + product.UnitOfMeasure +
                        "\nPrice: " + product.Price.ToString("N2") + "\nStock: " + product.Quantity,
                        "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (action == "AddProductStock")
                {
                    using (var form = new AddStock(product))
                        if (form.ShowDialog(this) == DialogResult.OK) LoadProducts();
                }
                else if (action == "EditProduct") OpenProduct(product.Id);
                else if (action == "DeleteProduct")
                {
                    if (MessageBox.Show("Delete " + product.ProductName + "?", "Delete Product",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
                    products.DeleteProduct(product.Id);
                    LoadProducts();
                }
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void OpenProduct(int id)
        {
            var form = new ProductRegistrations(id);
            form.FormClosed += (s, e) => { Show(); Reload(); };
            form.Show();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e) { Close(); }
        private void btnAddNewProduct_Click(object sender, EventArgs e) { OpenProduct(0); }

        private static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Inventory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
