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
    public partial class ProductRegistrations : Form
    {
        public ProductRegistrations()
        {
            InitializeComponent();

            SetupPlaceholder(txtProductCode, "Enter product code");
            SetupPlaceholder(txtProductName, "Enter product name");
            SetupPlaceholder(txtPrice, "Enter price");
            SetupPlaceholder(txtQuantity, "Enter quantity");

        }
        private void SetupPlaceholder(TextBox txt, string placeholder)
        {
            // Set initial text and enforce black text color
            txt.Text = placeholder;
            txt.ForeColor = Color.Black;

            txt.Enter += (sender, e) =>
            {
                // Clear text when clicked
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.Leave += (sender, e) =>
            {
                // Restore placeholder if left empty
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Black;
                }
            };
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}