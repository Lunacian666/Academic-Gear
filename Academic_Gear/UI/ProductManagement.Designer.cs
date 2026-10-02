namespace UI
{
    partial class ProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnArrowDown = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.lblProductManagement = new System.Windows.Forms.Label();
            this.lblAdminAcc = new System.Windows.Forms.Label();
            this.dgvProductManagement = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearchPN = new System.Windows.Forms.Button();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Silver;
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.btnArrowDown);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.lblAdministrator);
            this.panelTop.Controls.Add(this.lblProductManagement);
            this.panelTop.Controls.Add(this.lblAdminAcc);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(806, 41);
            this.panelTop.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(395, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 20);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnArrowDown
            // 
            this.btnArrowDown.FlatAppearance.BorderSize = 0;
            this.btnArrowDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrowDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrowDown.Location = new System.Drawing.Point(775, 7);
            this.btnArrowDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnArrowDown.Name = "btnArrowDown";
            this.btnArrowDown.Size = new System.Drawing.Size(27, 24);
            this.btnArrowDown.TabIndex = 12;
            this.btnArrowDown.Text = "V";
            this.btnArrowDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArrowDown.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(279, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Text = "Search anything...";
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Perpetua Titling MT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(688, 20);
            this.lblAdministrator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(92, 12);
            this.lblAdministrator.TabIndex = 3;
            this.lblAdministrator.Text = "Administrator";
            // 
            // lblProductManagement
            // 
            this.lblProductManagement.AutoSize = true;
            this.lblProductManagement.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductManagement.Location = new System.Drawing.Point(24, 9);
            this.lblProductManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductManagement.Name = "lblProductManagement";
            this.lblProductManagement.Size = new System.Drawing.Size(218, 25);
            this.lblProductManagement.TabIndex = 0;
            this.lblProductManagement.Text = "Product Management";
            // 
            // lblAdminAcc
            // 
            this.lblAdminAcc.AutoSize = true;
            this.lblAdminAcc.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAcc.Location = new System.Drawing.Point(687, 5);
            this.lblAdminAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminAcc.Name = "lblAdminAcc";
            this.lblAdminAcc.Size = new System.Drawing.Size(93, 17);
            this.lblAdminAcc.TabIndex = 2;
            this.lblAdminAcc.Text = "AdminAcc";
            // 
            // dgvProductManagement
            // 
            this.dgvProductManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.Category,
            this.Price,
            this.AvailableStock,
            this.View,
            this.Edit,
            this.Delete});
            this.dgvProductManagement.Location = new System.Drawing.Point(0, 80);
            this.dgvProductManagement.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductManagement.Name = "dgvProductManagement";
            this.dgvProductManagement.RowHeadersWidth = 51;
            this.dgvProductManagement.RowTemplate.Height = 24;
            this.dgvProductManagement.Size = new System.Drawing.Size(802, 377);
            this.dgvProductManagement.TabIndex = 18;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "PRODUCT CODE";
            this.ProductCode.MinimumWidth = 6;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "PRODUCT NAME";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "CATEGORY";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "PRICE";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // AvailableStock
            // 
            this.AvailableStock.HeaderText = "AVAILABLE STOCK";
            this.AvailableStock.MinimumWidth = 6;
            this.AvailableStock.Name = "AvailableStock";
            this.AvailableStock.Width = 125;
            // 
            // View
            // 
            this.View.HeaderText = "VIEW";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "EDIT";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "DELETE";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchProduct.Location = new System.Drawing.Point(144, 53);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(126, 20);
            this.txtSearchProduct.TabIndex = 19;
            this.txtSearchProduct.Text = "Search by product name...";
            // 
            // btnSearchPN
            // 
            this.btnSearchPN.Location = new System.Drawing.Point(274, 52);
            this.btnSearchPN.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPN.Name = "btnSearchPN";
            this.btnSearchPN.Size = new System.Drawing.Size(62, 23);
            this.btnSearchPN.TabIndex = 20;
            this.btnSearchPN.Text = "Search";
            this.btnSearchPN.UseVisualStyleBackColor = true;
            // 
            // cmbCategories
            // 
            this.cmbCategories.ForeColor = System.Drawing.Color.Silver;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(566, 50);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(102, 21);
            this.cmbCategories.TabIndex = 21;
            this.cmbCategories.Text = "Select Category";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(672, 49);
            this.btnAddNewProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(122, 26);
            this.btnAddNewProduct.TabIndex = 22;
            this.btnAddNewProduct.Text = "+ Add New Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 393);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 23;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 50);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 25);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "<-Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 479);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.btnSearchPN);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.dgvProductManagement);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnArrowDown;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Label lblProductManagement;
        private System.Windows.Forms.Label lblAdminAcc;
        private System.Windows.Forms.DataGridView dgvProductManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableStock;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnSearchPN;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}