using System;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;

namespace UI
{
    public partial class InventoryManagement : Form
    {
            private BindingList<ProductItem> filteredProducts = new BindingList<ProductItem>();
        public InventoryManagement()
        {
            InitializeComponent();

            SetUpActionButtons();
            dgvProductManagement.CellContentClick += dgvProductManagement_CellContentClick;
            
            dgvProductManagement.AllowUserToAddRows = false;
            dgvProductManagement.AutoGenerateColumns = false;
            //kinoconnect ang datagrid sa shared na product list
            dgvProductManagement.DataSource = filteredProducts;

            //Load category options
            LoadCategoryFilter();
            //dinidisplay lahat ng products
            RefreshProductGrid();

            //pinagcoconnect abf searcg at category events
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
        }
         
        private void SetUpActionButtons()
        {
            DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn();
            viewButton.Name = "colView";
            viewButton.HeaderText = "VIEW";
            viewButton.Text = "View";
            viewButton.UseColumnTextForButtonValue = true;
            viewButton.Width = 80;

            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            addButton.Name = "colAdd";
            addButton.HeaderText = "ADD STOCK";
            addButton.Text = "Add";
            addButton.UseColumnTextForButtonValue= true;


            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "colEdit";
            editButton.HeaderText = "EDIT";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            editButton.Width = 80;

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "colDelete";
            deleteButton.HeaderText = "DELETE";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Width = 80;

            dgvProductManagement.Columns.Add(viewButton);
            dgvProductManagement.Columns.Add(addButton);
            dgvProductManagement.Columns.Add(editButton);
            dgvProductManagement.Columns.Add(deleteButton);

        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            RefreshProductGrid();
        }


        private void LoadCategoryFilter()
        {
            cmbCategories.Items.Clear();
            cmbCategories.Items.Add("All Categories");

            var categories =  ProductData.Products.Select(p => p.Category).Where(c => !string.IsNullOrWhiteSpace(c)).Distinct().OrderBy(c => c);

            foreach (var category in categories)
            {
                cmbCategories.Items.Add(category);
            }

            cmbCategories.SelectedIndex = 0;
        }

        private void RefreshProductGrid()
        {

            string searchText = txtSearchProduct.Text.Trim();
            if (searchText == "Search by product name...")
            {
                searchText = "";
            }

            string selectedCategory = cmbCategories.SelectedItem?.ToString() ?? "All Categories";
           
            var results = ProductData.Products.Where(p =>
            {
                bool matchSearch = p.ProductName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                p.ProductName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;

                bool matchesCategory = selectedCategory == "All Categories" || string.Equals(p.Category, selectedCategory, StringComparison.OrdinalIgnoreCase);

                return matchSearch && matchesCategory;
            }).ToList();

            filteredProducts.RaiseListChangedEvents = false;
            filteredProducts.Clear();

            foreach (var product in results)
            {
                filteredProducts.Add(product);
            }

            filteredProducts.RaiseListChangedEvents = true;
            filteredProducts.ResetBindings();
        }

            private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e) {

            RefreshProductGrid();
        }

        private void btnBack_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewProduct_Click(
            object sender, EventArgs e)
        {
            this.Hide();

            ProductRegistrations productForm = new ProductRegistrations();

            productForm.FormClosed += (s, args) =>
            {
                this.Show();
                LoadCategoryFilter();
                RefreshProductGrid();
            };
            productForm.Show();
        }

        private void dgvProductManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            ProductItem selectedProduct = dgvProductManagement.Rows[e.RowIndex].DataBoundItem as ProductItem;

            if (selectedProduct == null)
                return;

            string columnName = dgvProductManagement.Columns[e.ColumnIndex].Name;

            //VIEW BUTTON
            if (columnName == "colView")
            {
                MessageBox.Show(
                    "Product Code: " + selectedProduct.ProductCode +
                    "\nProduct Name: " + selectedProduct.ProductName +
                    "\nCategory: " + selectedProduct.Category +
                    "\nUnit: " + selectedProduct.UnitPerMeasure +
                    "\nPrice: " + selectedProduct.Price +
                    "\nAvailable Stock: " + selectedProduct.Quantity,
                    "Product Details");
            }

            //ADD BUTTON
            else if (columnName == "colAdd")
            {
                AddStock addStock = new AddStock(selectedProduct);

                if (addStock.ShowDialog() == DialogResult.OK)
                {
                    RefreshProductGrid();
                    MessageBox.Show(
                        "Inventory updated successfully!",
                        "Stock Updated",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }

            //EDIT BUTTON
            else if (columnName == "colEdit")
            {
                this.Hide();

                ProductRegistrations productForm = new ProductRegistrations(selectedProduct);

                productForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    LoadCategoryFilter();
                    RefreshProductGrid();
                };

                productForm.Show();
            }

            //DELETE BUTTON
            else if (columnName == "colDelete")
            {
                DialogResult = MessageBox.Show(
                    "Are you sure you want to delete" + selectedProduct.ProductName + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult == DialogResult.Yes)
                {
                    ProductData.Products.Remove(selectedProduct);
                    LoadCategoryFilter();
                    RefreshProductGrid();
                    MessageBox.Show("Product deleted successfully!");
                }

            }

        }
    }
}
