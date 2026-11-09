
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class InventoryManagement : Form
    {
        public InventoryManagement()
        {
            InitializeComponent();

            dgvProductManagement.AutoGenerateColumns = false;
            //kinoconnect ang datagrid sa shared na product list
            dgvProductManagement.DataSource = ProductData.Products;
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
                dgvProductManagement.Refresh();
            };

            productForm.Show();
        }
    }
}
