
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class InventoryManagement : Form
    {
        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void btnBack_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewProduct_Click(
            object sender, EventArgs e)
        {
            ProductRegistrations productForm =
                new ProductRegistrations();

            productForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            productForm.Show();
            this.Hide();
        }
    }
}
