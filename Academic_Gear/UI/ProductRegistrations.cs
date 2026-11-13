using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace UI
{
    public partial class ProductRegistrations : Form
    {
        private ProductItem productBeingEdited = null;
        public ProductRegistrations()
        {
            InitializeComponent();

            cmbCategory.Items.Clear();

            //Available products sa categories
            cmbCategory.Items.Add("Writing Materials");
            cmbCategory.Items.Add("Art Materials");
            cmbCategory.Items.Add("Folders and Envelopes");
            cmbCategory.Items.Add("School Supplies");
            cmbCategory.Items.Add("Office Supplies");
            cmbCategory.Items.Add("Paper Products");

            //para maka select ang user sa available na options
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;

            cmbUnitPerMeasure.Items.Clear();

            cmbUnitPerMeasure.Items.Add("Piece (pc)");
            cmbUnitPerMeasure.Items.Add("Pack");
            cmbUnitPerMeasure.Items.Add("Ream");
            cmbUnitPerMeasure.Items.Add("Box");
            cmbUnitPerMeasure.Items.Add("Set");
            cmbUnitPerMeasure.Items.Add("Pad");
            cmbUnitPerMeasure.Items.Add("Roll");
            cmbUnitPerMeasure.Items.Add("Bottle");
            cmbUnitPerMeasure.Items.Add("Tube");
            cmbUnitPerMeasure.Items.Add("Sheet");
            cmbUnitPerMeasure.Items.Add("Bundle");
            cmbUnitPerMeasure.Items.Add("Pair");

            cmbUnitPerMeasure.SelectedIndex = 1;

            SetupPlaceholder(txtProductName, "Enter product name");
            SetupPlaceholder(txtPrice, "Enter price");
            SetupPlaceholder(txtQuantity, "Enter quantity");
        }

        public ProductRegistrations(ProductItem product): this()
        {
            productBeingEdited = product;

            //Dinidisplay ang existing product info
            txtProductCode.Text = product.ProductCode;
            txtProductName.Text = product.ProductName;
            cmbCategory.Text = product.Category;
            cmbUnitPerMeasure.Text = product.UnitPerMeasure;
            txtPrice.Text = product.Price.ToString();
            txtQuantity.Text = product.Quantity.ToString();

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //input sa Category kukunin
            string category = cmbCategory.SelectedItem?.ToString();
 
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please select a category.");
                cmbCategory.Focus();
                return;
            }

            //chinecheck kung nakapag generate na ng code ang system
            if (string.IsNullOrWhiteSpace(txtProductCode.Text))
            {
                MessageBox.Show("Unable to generate Product Code.");
                GenerateProductCode();
                return;
            }

            string unit = cmbUnitPerMeasure.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(unit))
            {
                MessageBox.Show("Please select a unit per measure.");
                cmbUnitPerMeasure.Focus();
                return;
            }

            decimal price;
            if (string.IsNullOrWhiteSpace(txtPrice.Text) ||
            txtPrice.Text == "Enter price")
            {
                MessageBox.Show("Please input a price.");
                txtPrice.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.");
                txtPrice.Focus();
                return;
            }

            string productName = txtProductName.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                productName == "Enter product name")
            {
                MessageBox.Show("Please input a product name.");
                txtProductName.Focus();
                return;
            }

            int quantity;
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                txtQuantity.Text == "Enter quantity")
            {
                MessageBox.Show("Please input a quantity.");
                txtQuantity.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                txtQuantity.Focus();
                return;
            }

            if (productBeingEdited != null)
            {
                //Updatting existing product
                productBeingEdited.ProductName = txtProductName.Text;
                productBeingEdited.Category = cmbCategory.Text;
                productBeingEdited.UnitPerMeasure = cmbUnitPerMeasure.Text;
                productBeingEdited.Price = decimal.Parse(txtPrice.Text);
                productBeingEdited.Quantity = int.Parse(txtQuantity.Text);

                MessageBox.Show("Product updated successfully!");
            }

            ProductItem newProduct = new ProductItem()
            {
                ProductCode = txtProductCode.Text.Trim(),
                ProductName = productName,
                Category = category,
                UnitPerMeasure = unit,
                Price = price,
                Quantity = quantity
            };
            ProductData.Products.Add(newProduct);
            MessageBox.Show("Product registered successfully!", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateProductCode();
        }

        private void GenerateProductCode()
        {
            //unique product code (date and time)
            string category = cmbCategory.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(category))
            {
                txtProductCode.Clear();
                return;
            }
            //dinedetermine dito kung anong product code prefix ang pipiliin based sa category
            string prefix = "";
            switch (category)
            {
                case "Writing Materials":
                    prefix = "WRT";
                    break;

                case "Art Materials":
                    prefix = "ART";
                    break;

                case "Folders and Envelopes":
                    prefix = "FDE";
                    break;

                case "School Supplies":
                    prefix = "SCH";
                    break;

                case "Office Supplies":
                    prefix = "OFF";
                    break;

                case "Paper Products":
                    prefix = "PAP";
                    break;

                default: MessageBox.Show("Invalid category selected.");
                    txtProductCode.Clear();
                    return;
            }
            //PARA MAG GENERATE NG UNIQUE 4 DIGITS
            string uniqueCode = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();
            //PAG GENERATE NG CODE 
            string productCode = prefix + "-" + DateTime.Now.ToString("yyyyMMdd") + uniqueCode.ToString();
            //DISPLAY NG GENERATED NA PRODUCT CODE
            txtProductCode.Text = productCode;
            txtProductCode.ReadOnly = true;
        }
    }
}