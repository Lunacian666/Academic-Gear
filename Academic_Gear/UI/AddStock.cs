using System;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class AddStock : Form
    {
        private readonly ProductInfo product;
        private readonly ProductRepo repository = new ProductRepo();

        public AddStock(ProductInfo selected)
        {
            InitializeComponent();
            product = selected ?? throw new ArgumentNullException("selected");
            lblProductCode.Text = product.ProductCode;
            lblProductName.Text = product.ProductName;
            lblCategory.Text = product.CategoryName;
            lblCurrentStock.Text = product.Quantity.ToString();
            numAdditionalQuantity.Minimum = 1;
            numAdditionalQuantity.Maximum = 1000000;
            numAdditionalQuantity.Value = 1;
            btnConfirmAdd.Click += Confirm;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void Confirm(object sender, EventArgs e)
        {
            try
            {
                int updated = repository.AddStock(product.Id, (int)numAdditionalQuantity.Value);
                lblCurrentStock.Text = updated.ToString();
                MessageBox.Show("Stock updated. New quantity: " + updated, "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
