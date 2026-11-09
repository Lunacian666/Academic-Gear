using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class ProductRegistrations : Form
    {
        private readonly ProductRepo repo = new ProductRepo();
        private readonly int editingProductId;

        public ProductRegistrations() : this(0) { }

        public ProductRegistrations(int productId)
        {
            editingProductId = productId;
            InitializeComponent();
            SetupPlaceholder(txtProductCode, "Enter product code");
            SetupPlaceholder(txtProductName, "Enter product name");
            SetupPlaceholder(txtPrice, "Enter price");
            SetupPlaceholder(txtQuantity, "Enter quantity");

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnitPerMeasure.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnitPerMeasure.Items.Clear();
            cmbUnitPerMeasure.Items.AddRange(new object[] { "Piece", "Pack", "Box", "Set", "Pair", "Other" });
            cmbUnitPerMeasure.SelectedIndex = -1;
            btnSave.Click += btnSave_Click;
            Shown += ProductRegistrations_Shown;
        }

        private void ProductRegistrations_Shown(object sender, EventArgs e)
        {
            try
            {
                cmbCategory.DataSource = repo.GetCategories();
                cmbCategory.SelectedIndex = -1;
                if (editingProductId > 0)
                {
                    ProductInfo item = repo.GetProduct(editingProductId);
                    if (item == null) { MessageBox.Show("Product not found."); Close(); return; }
                    txtProductCode.Text = item.ProductCode;
                    txtProductName.Text = item.ProductName;
                    txtPrice.Text = item.Price.ToString("0.00");
                    txtQuantity.Text = item.Quantity.ToString();
                    for (int i = 0; i < cmbCategory.Items.Count; i++)
                    {
                        CategoryInfo cat = cmbCategory.Items[i] as CategoryInfo;
                        if (cat != null && cat.Id == item.CategoryId) { cmbCategory.SelectedIndex = i; break; }
                    }
                    if (!cmbUnitPerMeasure.Items.Contains(item.UnitOfMeasure))
                        cmbUnitPerMeasure.Items.Add(item.UnitOfMeasure);
                    cmbUnitPerMeasure.SelectedItem = item.UnitOfMeasure;
                    lblProductRegistration.Text = "Edit Product";
                    btnSave.Text = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load product details.\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string code = InputValue(txtProductCode, "Enter product code");
            string name = InputValue(txtProductName, "Enter product name");
            string priceText = InputValue(txtPrice, "Enter price");
            string qtyText = InputValue(txtQuantity, "Enter quantity");
            decimal price;
            int quantity;
            var category = cmbCategory.SelectedItem as CategoryInfo;
            string unit = cmbUnitPerMeasure.SelectedItem as string;

            if (code.Length == 0 || name.Length == 0 || category == null ||
                string.IsNullOrWhiteSpace(unit) ||
                !decimal.TryParse(priceText, NumberStyles.Number, CultureInfo.CurrentCulture, out price) ||
                price < 0 || price > 9999999999999999m ||
                !int.TryParse(qtyText, out quantity) || quantity < 0)
            {
                MessageBox.Show("Enter a unique code, name, category, unit, valid price and nonnegative stock.",
                    "Check Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                repo.SaveProduct(new ProductInfo
                {
                    Id = editingProductId,
                    ProductCode = code,
                    ProductName = name,
                    CategoryId = category.Id,
                    UnitOfMeasure = unit,
                    Price = price,
                    Quantity = quantity
                });
                MessageBox.Show(editingProductId == 0 ? "Product saved." : "Product updated.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Number == 2601 || ex.Number == 2627
                    ? "That product code already exists. Use a different code."
                    : "Unable to save product.\n" + ex.Message,
                    "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save product.\n" + ex.Message,
                    "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string InputValue(TextBox box, string placeholder)
        {
            string text = box.Text.Trim();
            return text == placeholder ? "" : text;
        }

        private static void SetupPlaceholder(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.Enter += (sender, e) => { if (txt.Text == placeholder) txt.Text = ""; };
            txt.Leave += (sender, e) => { if (string.IsNullOrWhiteSpace(txt.Text)) txt.Text = placeholder; };
        }

        private void btnBack_Click(object sender, EventArgs e) { Close(); }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset all fields?", "Confirm Reset", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes) return;
            txtProductCode.Text = "Enter product code";
            txtProductName.Text = "Enter product name";
            txtPrice.Text = "Enter price";
            txtQuantity.Text = "Enter quantity";
            cmbCategory.SelectedIndex = -1;
            cmbUnitPerMeasure.SelectedIndex = -1;
        }
    }
}
