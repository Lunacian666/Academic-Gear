namespace UI
{
    partial class InventoryManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.lblInventoryManagement = new System.Windows.Forms.Label();
            this.lblAdminAcc = new System.Windows.Forms.Label();
            this.dgvProductManagement = new System.Windows.Forms.DataGridView();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearchPN = new System.Windows.Forms.Button();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlTP = new System.Windows.Forms.Panel();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.lblOutputTP = new System.Windows.Forms.Label();
            this.lblLowStockProducts = new System.Windows.Forms.Label();
            this.pnlLSP = new System.Windows.Forms.Panel();
            this.lblOutputLSP = new System.Windows.Forms.Label();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkLowStock = new System.Windows.Forms.CheckBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductManagement)).BeginInit();
            this.pnlTP.SuspendLayout();
            this.pnlLSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Navy;
            this.panelTop.Controls.Add(this.lblInventoryManagement);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1232, 50);
            this.panelTop.TabIndex = 4;
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.BackColor = System.Drawing.Color.Navy;
            this.lblAdministrator.Font = new System.Drawing.Font("Perpetua Titling MT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.ForeColor = System.Drawing.Color.White;
            this.lblAdministrator.Location = new System.Drawing.Point(1088, 27);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(108, 15);
            this.lblAdministrator.TabIndex = 3;
            this.lblAdministrator.Text = "Administrator";
            // 
            // lblInventoryManagement
            // 
            this.lblInventoryManagement.AutoSize = true;
            this.lblInventoryManagement.BackColor = System.Drawing.Color.Navy;
            this.lblInventoryManagement.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryManagement.ForeColor = System.Drawing.Color.White;
            this.lblInventoryManagement.Location = new System.Drawing.Point(32, 11);
            this.lblInventoryManagement.Name = "lblInventoryManagement";
            this.lblInventoryManagement.Size = new System.Drawing.Size(296, 31);
            this.lblInventoryManagement.TabIndex = 0;
            this.lblInventoryManagement.Text = "Inventory Management";
            // 
            // lblAdminAcc
            // 
            this.lblAdminAcc.AutoSize = true;
            this.lblAdminAcc.BackColor = System.Drawing.Color.Navy;
            this.lblAdminAcc.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAcc.ForeColor = System.Drawing.Color.White;
            this.lblAdminAcc.Location = new System.Drawing.Point(1087, 9);
            this.lblAdminAcc.Name = "lblAdminAcc";
            this.lblAdminAcc.Size = new System.Drawing.Size(112, 21);
            this.lblAdminAcc.TabIndex = 2;
            this.lblAdminAcc.Text = "AdminAcc";
            // 
            // dgvProductManagement
            // 
            this.dgvProductManagement.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.clmSupplier,
            this.Category,
            this.Price,
            this.AvailableStock});
            this.dgvProductManagement.Location = new System.Drawing.Point(38, 375);
            this.dgvProductManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductManagement.Name = "dgvProductManagement";
            this.dgvProductManagement.RowHeadersWidth = 51;
            this.dgvProductManagement.RowTemplate.Height = 24;
            this.dgvProductManagement.Size = new System.Drawing.Size(1158, 424);
            this.dgvProductManagement.TabIndex = 18;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Black;
            this.txtSearchProduct.Location = new System.Drawing.Point(217, 269);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(195, 22);
            this.txtSearchProduct.TabIndex = 19;
            this.txtSearchProduct.Text = "Search by product name...";
            // 
            // btnSearchPN
            // 
            this.btnSearchPN.Location = new System.Drawing.Point(431, 266);
            this.btnSearchPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchPN.Name = "btnSearchPN";
            this.btnSearchPN.Size = new System.Drawing.Size(83, 28);
            this.btnSearchPN.TabIndex = 20;
            this.btnSearchPN.Text = "Search";
            this.btnSearchPN.UseVisualStyleBackColor = true;
            // 
            // cmbCategories
            // 
            this.cmbCategories.ForeColor = System.Drawing.Color.Black;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(35, 269);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(160, 24);
            this.cmbCategories.TabIndex = 21;
            this.cmbCategories.Text = "Select Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 23;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(15, 62);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 31);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "<-Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Blue;
            this.btnView.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(294, 322);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(183, 36);
            this.btnView.TabIndex = 25;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(537, 322);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(183, 36);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(774, 322);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(183, 36);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // pnlTP
            // 
            this.pnlTP.BackColor = System.Drawing.Color.White;
            this.pnlTP.Controls.Add(this.lblOutputTP);
            this.pnlTP.Controls.Add(this.lblTotalProducts);
            this.pnlTP.Location = new System.Drawing.Point(255, 115);
            this.pnlTP.Name = "pnlTP";
            this.pnlTP.Size = new System.Drawing.Size(347, 119);
            this.pnlTP.TabIndex = 29;
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.Location = new System.Drawing.Point(12, 10);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(120, 22);
            this.lblTotalProducts.TabIndex = 0;
            this.lblTotalProducts.Text = "Total Products";
            // 
            // lblOutputTP
            // 
            this.lblOutputTP.AutoSize = true;
            this.lblOutputTP.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTP.Location = new System.Drawing.Point(147, 58);
            this.lblOutputTP.Name = "lblOutputTP";
            this.lblOutputTP.Size = new System.Drawing.Size(31, 24);
            this.lblOutputTP.TabIndex = 31;
            this.lblOutputTP.Text = "---";
            // 
            // lblLowStockProducts
            // 
            this.lblLowStockProducts.AutoSize = true;
            this.lblLowStockProducts.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockProducts.Location = new System.Drawing.Point(16, 10);
            this.lblLowStockProducts.Name = "lblLowStockProducts";
            this.lblLowStockProducts.Size = new System.Drawing.Size(162, 22);
            this.lblLowStockProducts.TabIndex = 1;
            this.lblLowStockProducts.Text = "Low Stock Products";
            // 
            // pnlLSP
            // 
            this.pnlLSP.BackColor = System.Drawing.Color.White;
            this.pnlLSP.Controls.Add(this.lblLowStockProducts);
            this.pnlLSP.Controls.Add(this.lblOutputLSP);
            this.pnlLSP.Location = new System.Drawing.Point(686, 115);
            this.pnlLSP.Name = "pnlLSP";
            this.pnlLSP.Size = new System.Drawing.Size(347, 119);
            this.pnlLSP.TabIndex = 32;
            // 
            // lblOutputLSP
            // 
            this.lblOutputLSP.AutoSize = true;
            this.lblOutputLSP.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputLSP.Location = new System.Drawing.Point(173, 58);
            this.lblOutputLSP.Name = "lblOutputLSP";
            this.lblOutputLSP.Size = new System.Drawing.Size(31, 24);
            this.lblOutputLSP.TabIndex = 31;
            this.lblOutputLSP.Text = "---";
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "PRODUCT CODE";
            this.ProductCode.MinimumWidth = 6;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "PRODUCT NAME";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // clmSupplier
            // 
            this.clmSupplier.HeaderText = "SUPPLIER";
            this.clmSupplier.MinimumWidth = 6;
            this.clmSupplier.Name = "clmSupplier";
            this.clmSupplier.Width = 125;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "CATEGORY";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "PRICE";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // AvailableStock
            // 
            this.AvailableStock.DataPropertyName = "Quantity";
            this.AvailableStock.HeaderText = "AVAILABLE STOCK";
            this.AvailableStock.MinimumWidth = 6;
            this.AvailableStock.Name = "AvailableStock";
            this.AvailableStock.Width = 125;
            // 
            // chkLowStock
            // 
            this.chkLowStock.AutoSize = true;
            this.chkLowStock.Location = new System.Drawing.Point(959, 266);
            this.chkLowStock.Name = "chkLowStock";
            this.chkLowStock.Size = new System.Drawing.Size(240, 20);
            this.chkLowStock.TabIndex = 33;
            this.chkLowStock.Text = "Show Low Stock Products (Below 5)";
            this.chkLowStock.UseVisualStyleBackColor = true;
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1230, 810);
            this.Controls.Add(this.chkLowStock);
            this.Controls.Add(this.pnlLSP);
            this.Controls.Add(this.pnlTP);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblAdministrator);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdminAcc);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.btnSearchPN);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.dgvProductManagement);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InventoryManagement";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductManagement)).EndInit();
            this.pnlTP.ResumeLayout(false);
            this.pnlTP.PerformLayout();
            this.pnlLSP.ResumeLayout(false);
            this.pnlLSP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Label lblInventoryManagement;
        private System.Windows.Forms.Label lblAdminAcc;
        private System.Windows.Forms.DataGridView dgvProductManagement;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnSearchPN;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlTP;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblOutputTP;
        private System.Windows.Forms.Label lblLowStockProducts;
        private System.Windows.Forms.Panel pnlLSP;
        private System.Windows.Forms.Label lblOutputLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableStock;
        private System.Windows.Forms.CheckBox chkLowStock;
    }
}
