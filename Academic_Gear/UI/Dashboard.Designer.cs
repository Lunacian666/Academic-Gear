namespace UI
{
    partial class Dashboard
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
            this.lblHome = new System.Windows.Forms.Label();
            this.lblAdminAcc = new System.Windows.Forms.Label();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnInventoryManagement = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnStockAvailability = new System.Windows.Forms.Button();
            this.btnSalesHistory = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Silver;
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.btnArrowDown);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.lblAdministrator);
            this.panelTop.Controls.Add(this.lblHome);
            this.panelTop.Controls.Add(this.lblAdminAcc);
            this.panelTop.Location = new System.Drawing.Point(-2, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(779, 45);
            this.panelTop.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(380, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 19);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnArrowDown
            // 
            this.btnArrowDown.FlatAppearance.BorderSize = 0;
            this.btnArrowDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrowDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrowDown.Location = new System.Drawing.Point(747, 7);
            this.btnArrowDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnArrowDown.Name = "btnArrowDown";
            this.btnArrowDown.Size = new System.Drawing.Size(22, 29);
            this.btnArrowDown.TabIndex = 12;
            this.btnArrowDown.Text = "V";
            this.btnArrowDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArrowDown.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(235, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Text = "Search anything...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Perpetua Titling MT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(659, 24);
            this.lblAdministrator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(92, 12);
            this.lblAdministrator.TabIndex = 3;
            this.lblAdministrator.Text = "Administrator";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(32, 11);
            this.lblHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(67, 25);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            // 
            // lblAdminAcc
            // 
            this.lblAdminAcc.AutoSize = true;
            this.lblAdminAcc.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAcc.Location = new System.Drawing.Point(657, 7);
            this.lblAdminAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminAcc.Name = "lblAdminAcc";
            this.lblAdminAcc.Size = new System.Drawing.Size(93, 17);
            this.lblAdminAcc.TabIndex = 2;
            this.lblAdminAcc.Text = "AdminAcc";
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.FlatAppearance.BorderSize = 0;
            this.btnProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductManagement.Location = new System.Drawing.Point(2, 54);
            this.btnProductManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(196, 25);
            this.btnProductManagement.TabIndex = 4;
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductManagement.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(2, 20);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(196, 29);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnManageAccount);
            this.panelLeft.Controls.Add(this.btnInventoryManagement);
            this.panelLeft.Controls.Add(this.btnSupplier);
            this.panelLeft.Controls.Add(this.btnStockAvailability);
            this.panelLeft.Controls.Add(this.btnSalesHistory);
            this.panelLeft.Controls.Add(this.btnReports);
            this.panelLeft.Controls.Add(this.btnProductManagement);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Location = new System.Drawing.Point(0, 45);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 390);
            this.panelLeft.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "------------------------------";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(9, 356);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 25);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.FlatAppearance.BorderSize = 0;
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.Location = new System.Drawing.Point(2, 289);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(196, 35);
            this.btnManageAccount.TabIndex = 10;
            this.btnManageAccount.Text = "Manage Account";
            this.btnManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAccount.UseVisualStyleBackColor = true;
            // 
            // btnInventoryManagement
            // 
            this.btnInventoryManagement.FlatAppearance.BorderSize = 0;
            this.btnInventoryManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryManagement.Location = new System.Drawing.Point(2, 253);
            this.btnInventoryManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventoryManagement.Name = "btnInventoryManagement";
            this.btnInventoryManagement.Size = new System.Drawing.Size(196, 24);
            this.btnInventoryManagement.TabIndex = 9;
            this.btnInventoryManagement.Text = "Inventory Management";
            this.btnInventoryManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryManagement.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.Location = new System.Drawing.Point(2, 210);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(196, 31);
            this.btnSupplier.TabIndex = 8;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.UseVisualStyleBackColor = true;
            // 
            // btnStockAvailability
            // 
            this.btnStockAvailability.FlatAppearance.BorderSize = 0;
            this.btnStockAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockAvailability.Location = new System.Drawing.Point(4, 174);
            this.btnStockAvailability.Margin = new System.Windows.Forms.Padding(2);
            this.btnStockAvailability.Name = "btnStockAvailability";
            this.btnStockAvailability.Size = new System.Drawing.Size(194, 23);
            this.btnStockAvailability.TabIndex = 7;
            this.btnStockAvailability.Text = "Stock Availability";
            this.btnStockAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockAvailability.UseVisualStyleBackColor = true;
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.FlatAppearance.BorderSize = 0;
            this.btnSalesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesHistory.Location = new System.Drawing.Point(4, 133);
            this.btnSalesHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.Size = new System.Drawing.Size(194, 23);
            this.btnSalesHistory.TabIndex = 6;
            this.btnSalesHistory.Text = "Sales History";
            this.btnSalesHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesHistory.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(2, 94);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(196, 23);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 436);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSalesHistory;
        private System.Windows.Forms.Button btnStockAvailability;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnInventoryManagement;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Label lblAdminAcc;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArrowDown;
        private System.Windows.Forms.Button btnSearch;
    }
}