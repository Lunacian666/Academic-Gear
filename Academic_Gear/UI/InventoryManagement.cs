using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class InventoryManagement : Form
    {
        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            ProductRegistrations productForm = new ProductRegistrations();

            productForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            productForm.Show();
            this.Hide();
        }
    }
}
