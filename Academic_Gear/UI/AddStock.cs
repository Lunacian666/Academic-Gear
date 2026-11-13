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
    public partial class AddStock : Form
    {
        private ProductItem selectedProduct;
        public AddStock(ProductItem product)
        {
            InitializeComponent();

            selectedProduct = product;

            //Dinisidplay yung existing product na information
            lblProductCode.Text = selectedProduct.ProductCode;
            lblProductName.Text = selectedProduct.ProductName;
            lblCategory.Text = selectedProduct.Category;
            lblCurrentStock.Text = selectedProduct.Quantity.ToString();

            //Additional na quantity
            numAdditionalQuantity.Minimum = 1;
            numAdditionalQuantity.Maximum = 100000;
            numAdditionalQuantity.Value = 1;

            //Pagconnect ng mga buttons
            btnConfirmAdd.Click += btnConfirmAdd_Click;
            btnCancel.Click += btnCancel_Click;
        }

        //Confirm add button
        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            int additionalQuantity = (int)numAdditionalQuantity.Value;

            if(additionalQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            //pag uupdate ng existing na product stock
            selectedProduct.Quantity = selectedProduct.Quantity + additionalQuantity;

            //pag uupdate naman ng naka display na current stock
            lblCurrentStock.Text = selectedProduct.Quantity.ToString();

            MessageBox.Show(
                 "Stock succesfully added!" +
                    "\nProduct: " + selectedProduct.ProductName +
                    "\nNew Stock: " + selectedProduct.Quantity,
                    "Stock Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
