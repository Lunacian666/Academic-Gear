using System;
using System.Globalization;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class ProductRegistrations : Form
    {
        private readonly ProductRepo products = new ProductRepo();
        private readonly int editingId;
        private bool loading;
        private readonly string[] units = { "Piece (pc)", "Pack", "Ream", "Box", "Set", "Pad", "Roll", "Bottle", "Tube", "Sheet", "Bundle", "Pair" };

        public ProductRegistrations() : this(0) { }

        public ProductRegistrations(int productId)
        {
            editingId = productId;
            InitializeComponent();
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnitPerMeasure.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnitPerMeasure.Items.Clear();
            cmbUnitPerMeasure.Items.AddRange(units);
            cmbUnitPerMeasure.SelectedIndex = 0;
            txtProductCode.ReadOnly = true;
            cmbCategory.SelectedIndexChanged += (s, e) => { if (!loading && editingId == 0) GenerateCode(); };
            Shown += (s, e) => LoadRegistration();
        }

        private void LoadRegistration()
        {
            try
            {
                loading = true;
                cmbCategory.Items.Clear();
                foreach (CategoryInfo category in products.GetCategories()) cmbCategory.Items.Add(category);
                cmbCategory.SelectedIndex = -1;
                if (editingId > 0)
                {
                    ProductInfo product = products.GetProduct(editingId);
                    if (product == null) { MessageBox.Show("Product no longer exists."); Close(); return; }
                    txtProductCode.Text = product.ProductCode;
                    txtProductName.Text = product.ProductName;
                    txtPrice.Text = product.Price.ToString("0.00");
                    txtQuantity.Text = product.Quantity.ToString();
                    for (int i = 0; i < cmbCategory.Items.Count; i++)
                        if (((CategoryInfo)cmbCategory.Items[i]).Id == product.CategoryId) cmbCategory.SelectedIndex = i;
                    if (!cmbUnitPerMeasure.Items.Contains(product.UnitOfMeasure))
                        cmbUnitPerMeasure.Items.Add(product.UnitOfMeasure);
                    cmbUnitPerMeasure.SelectedItem = product.UnitOfMeasure;
                    lblProductRegistration.Text = "Edit Product";
                    btnSave.Text = "Update";
                }
                else
                {
                    txtProductName.Clear();
                    txtPrice.Clear();
                    txtQuantity.Clear();
                    txtProductCode.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Database Error"); }
            finally { loading = false; }
        }

        private void GenerateCode()
        {
            CategoryInfo category = cmbCategory.SelectedItem as CategoryInfo;
            if (category == null) { txtProductCode.Clear(); return; }
            string name = category.Name;
            string prefix = name == "Writing Materials" ? "WRT" :
                name == "Art Materials" ? "ART" : name == "Folders and Envelopes" ? "FDE" :
                name == "School Supplies" ? "SCH" : name == "Office Supplies" ? "OFF" : "PPR";
            txtProductCode.Text = prefix + "-" + DateTime.Now.ToString("yyyyMMdd") + Guid.NewGuid().ToString("N").Substring(0, 8).ToUpperInvariant();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CategoryInfo category = cmbCategory.SelectedItem as CategoryInfo;
            string unit = cmbUnitPerMeasure.SelectedItem as string;
            string name = txtProductName.Text.Trim();
            decimal price;
            int stock;
            if (category == null || string.IsNullOrWhiteSpace(name) || name.Length > 100 ||
                string.IsNullOrEmpty(unit) || string.IsNullOrWhiteSpace(txtProductCode.Text) ||
                !decimal.TryParse(txtPrice.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out price) ||
                price < 0 || price > 9999999999999999m ||
                !int.TryParse(txtQuantity.Text.Trim(), out stock) || stock < 0)
            {
                MessageBox.Show("Enter valid product name, category, unit, price and stock.", "Product Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                products.SaveProduct(new ProductInfo
                {
                    Id = editingId,
                    ProductCode = txtProductCode.Text.Trim(),
                    ProductName = name,
                    CategoryId = category.Id,
                    UnitOfMeasure = unit,
                    Price = price,
                    Quantity = stock
                });
                MessageBox.Show(editingId > 0 ? "Product updated." : "Product registered.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Number == 2601 || ex.Number == 2627 ? "Product code already exists." : ex.Message,
                    "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnBack_Click(object sender, EventArgs e) { Close(); }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset the fields?", "Reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoadRegistration();
                if (editingId == 0 && cmbCategory.SelectedItem != null) GenerateCode();
            }
        }
    }
}
