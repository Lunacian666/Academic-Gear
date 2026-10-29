namespace UI
{
    partial class CashierDashboard
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
            this.lblWelcomeCashier = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCashier = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblCashierAcc = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSalesHistory = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeCashier
            // 
            this.lblWelcomeCashier.AutoSize = true;
            this.lblWelcomeCashier.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeCashier.Location = new System.Drawing.Point(469, 100);
            this.lblWelcomeCashier.Name = "lblWelcomeCashier";
            this.lblWelcomeCashier.Size = new System.Drawing.Size(266, 41);
            this.lblWelcomeCashier.TabIndex = 5;
            this.lblWelcomeCashier.Text = "Welcome Cashier";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Silver;
            this.panelTop.Controls.Add(this.lblCashier);
            this.panelTop.Controls.Add(this.lblHome);
            this.panelTop.Controls.Add(this.lblCashierAcc);
            this.panelTop.Location = new System.Drawing.Point(-1, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(945, 58);
            this.panelTop.TabIndex = 3;
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Font = new System.Drawing.Font("Perpetua Titling MT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashier.Location = new System.Drawing.Point(855, 31);
            this.lblCashier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(47, 12);
            this.lblCashier.TabIndex = 3;
            this.lblCashier.Text = "Cashier";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(47, 13);
            this.lblHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(81, 30);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            // 
            // lblCashierAcc
            // 
            this.lblCashierAcc.AutoSize = true;
            this.lblCashierAcc.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierAcc.Location = new System.Drawing.Point(829, 13);
            this.lblCashierAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCashierAcc.Name = "lblCashierAcc";
            this.lblCashierAcc.Size = new System.Drawing.Size(103, 17);
            this.lblCashierAcc.TabIndex = 2;
            this.lblCashierAcc.Text = "CashierAcc";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLeft.Controls.Add(this.btnManageAccount);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnReceipt);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.btnSalesHistory);
            this.panelLeft.Controls.Add(this.btnPOS);
            this.panelLeft.Controls.Add(this.btnProduct);
            this.panelLeft.Location = new System.Drawing.Point(1, 58);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 518);
            this.panelLeft.TabIndex = 4;
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.FlatAppearance.BorderSize = 0;
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.Location = new System.Drawing.Point(4, 359);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(196, 35);
            this.btnManageAccount.TabIndex = 17;
            this.btnManageAccount.Text = "Manage Account";
            this.btnManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAccount.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 411);
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
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(8, 464);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 25);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.Location = new System.Drawing.Point(2, 296);
            this.btnReceipt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(194, 27);
            this.btnReceipt.TabIndex = 15;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(3, 41);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(196, 29);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.FlatAppearance.BorderSize = 0;
            this.btnSalesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesHistory.Location = new System.Drawing.Point(2, 230);
            this.btnSalesHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.Size = new System.Drawing.Size(194, 30);
            this.btnSalesHistory.TabIndex = 14;
            this.btnSalesHistory.Text = "Sales History";
            this.btnSalesHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesHistory.UseVisualStyleBackColor = true;
            // 
            // btnPOS
            // 
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.Location = new System.Drawing.Point(2, 100);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(196, 32);
            this.btnPOS.TabIndex = 12;
            this.btnPOS.Text = "Point of Sale";
            this.btnPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(3, 164);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(196, 30);
            this.btnProduct.TabIndex = 13;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // CashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 576);
            this.Controls.Add(this.lblWelcomeCashier);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CashierDashboard";
            this.Text = "CashierDashboard";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeCashier;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblCashierAcc;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSalesHistory;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnProduct;
    }
}