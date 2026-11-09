using System;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class InventoryManagement : Form
    {
        private readonly ProductRepo repo = new ProductRepo();

        public InventoryManagement()
        {
            InitializeComponent();
            dgvProductManagement.AllowUserToAddRows = false;
            dgvProductManagement.ReadOnly = true;
            dgvProductManagement.MultiSelect = false;
            dgvProductManagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnSearchPN.Click += (s, e) => LoadProducts();
            txtSearchProduct.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; LoadProducts(); }
            };
            txtSearchProduct.Enter += (s, e) =>
            {
                if (txtSearchProduct.Text == "Search by product name...") txtSearchProduct.Clear();
            };
            cmbCategories.SelectedIndexChanged += (s, e) => LoadProducts();
            dgvProductManagement.CellContentClick += ProductCellClicked;
            Shown += (s, e) => LoadCategoriesAndProducts();
        }

        private void LoadCategoriesAndProducts()
        {
            try
            {
                cmbCategories.Items.Clear();
                cmbCategories.Items.Add("All Categories");
                foreach (CategoryInfo cat in repo.GetCategories()) cmbCategories.Items.Add(cat);
                cmbCategories.SelectedIndex = 0;
                LoadProducts();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void LoadProducts()
        {
            try
            {
                int? categoryId = (cmbCategories.SelectedItem as CategoryInfo)?.Id;
                string search = txtSearchProduct.Text == "Search by product name..."
                    ? "" : txtSearchProduct.Text;
                var items = repo.GetProducts(search, categoryId);
                dgvProductManagement.Rows.Clear();
                foreach (ProductInfo item in items)
                {
                    int rowId = dgvProductManagement.Rows.Add(
                        item.ProductCode, item.ProductName, item.CategoryName,
                        item.Price.ToString("N2"), item.Quantity, "View", "Edit", "Delete");
                    dgvProductManagement.Rows[rowId].Tag = item;
                }
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void ProductCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            ProductInfo item = dgvProductManagement.Rows[e.RowIndex].Tag as ProductInfo;
            if (item == null) return;
            string columnName = dgvProductManagement.Columns[e.ColumnIndex].Name;
            if (columnName == "View")
            {
                MessageBox.Show(
                    "Code: " + item.ProductCode + "\nName: " + item.ProductName +
                    "\nCategory: " + item.CategoryName + "\nUnit: " + item.UnitOfMeasure +
                    "\nPrice: " + item.Price.ToString("N2") +
                    "\nAvailable Stock: " + item.Quantity,
                    "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (columnName == "Edit")
            {
                OpenRegistration(item.Id);
            }
            else if (columnName == "Delete")
            {
                if (MessageBox.Show("Delete product '" + item.ProductName + "'?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
                try { repo.DeleteProduct(item.Id); LoadProducts(); }
                catch (Exception ex) { ShowError(ex); }
            }
        }

        private void OpenRegistration(int productId)
        {
            ProductRegistrations form = productId == 0
                ? new ProductRegistrations() : new ProductRegistrations(productId);
            form.FormClosed += (s, e) => { Show(); LoadProducts(); };
            form.Show();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e) { Close(); }
        private void btnAddNewProduct_Click(object sender, EventArgs e) { OpenRegistration(0); }

        private static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Inventory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
