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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset all fields?",
                "Confirm Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                ResetFields(this);
            }
        }

        private void ResetFields(Control control)
        {
            foreach (Control child in control.Controls)
            {
                if (child is TextBox textBox)
                {
                    // Restore original default text
                    switch (textBox.Name)
                    {
                        case "txtPrice":
                            textBox.Text = "Enter price";
                            break;

                        case "txtProductName":
                            textBox.Text = "Enter product name";
                            break;

                        case "txtProductCode":
                            textBox.Text = "Enter product code";
                            break;

                        case "txtQuantity":
                            textBox.Text = "Enter quantity";
                            break;
                    }
                }
                else if (child is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                    comboBox.Text = "Select Category";
                }

                // Handle controls inside panels and group boxes
                if (child.HasChildren)
                {
                    ResetFields(child);
                }
            }
        }
    }
}