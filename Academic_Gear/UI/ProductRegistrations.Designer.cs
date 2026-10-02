namespace UI
{
    partial class ProductRegistrations
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblValidNum = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblProductCodeUnique = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductRegistration = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Silver;
            this.panel.Controls.Add(this.btnBack);
            this.panel.Controls.Add(this.btnSave);
            this.panel.Controls.Add(this.lblValidNum);
            this.panel.Controls.Add(this.btnCancel);
            this.panel.Controls.Add(this.lblProductCodeUnique);
            this.panel.Controls.Add(this.cmbCategory);
            this.panel.Controls.Add(this.txtQuantity);
            this.panel.Controls.Add(this.lblQuantity);
            this.panel.Controls.Add(this.txtPrice);
            this.panel.Controls.Add(this.lblPrice);
            this.panel.Controls.Add(this.lblCategory);
            this.panel.Controls.Add(this.txtProductName);
            this.panel.Controls.Add(this.lblProductName);
            this.panel.Controls.Add(this.lblProductCode);
            this.panel.Controls.Add(this.txtProductCode);
            this.panel.Controls.Add(this.lblProductRegistration);
            this.panel.Location = new System.Drawing.Point(12, 11);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(724, 442);
            this.panel.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(536, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 30);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblValidNum
            // 
            this.lblValidNum.AutoSize = true;
            this.lblValidNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidNum.ForeColor = System.Drawing.Color.Gray;
            this.lblValidNum.Location = new System.Drawing.Point(419, 184);
            this.lblValidNum.Name = "lblValidNum";
            this.lblValidNum.Size = new System.Drawing.Size(212, 16);
            this.lblValidNum.TabIndex = 15;
            this.lblValidNum.Text = "Must be a valid number (e.g. 50.00)";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(398, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 30);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblProductCodeUnique
            // 
            this.lblProductCodeUnique.AutoSize = true;
            this.lblProductCodeUnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCodeUnique.ForeColor = System.Drawing.Color.Gray;
            this.lblProductCodeUnique.Location = new System.Drawing.Point(88, 184);
            this.lblProductCodeUnique.Name = "lblProductCodeUnique";
            this.lblProductCodeUnique.Size = new System.Drawing.Size(185, 16);
            this.lblProductCodeUnique.TabIndex = 14;
            this.lblProductCodeUnique.Text = "Product Code must be unique.";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.Silver;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(91, 372);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(224, 28);
            this.cmbCategory.TabIndex = 13;
            this.cmbCategory.Text = "Select category";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Silver;
            this.txtQuantity.Location = new System.Drawing.Point(422, 272);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(224, 27);
            this.txtQuantity.TabIndex = 10;
            this.txtQuantity.Text = "Enter quantity";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(393, 235);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(151, 25);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "QUANTITY *";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Silver;
            this.txtPrice.Location = new System.Drawing.Point(422, 154);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(224, 27);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Text = "Enter price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(393, 116);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(103, 25);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "PRICE *";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(64, 335);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(157, 25);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "CATEGORY *";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Silver;
            this.txtProductName.Location = new System.Drawing.Point(91, 272);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(224, 27);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.Text = "Enter product name";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(64, 235);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(223, 25);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "PRODUCT NAME *";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(64, 116);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(219, 25);
            this.lblProductCode.TabIndex = 2;
            this.lblProductCode.Text = "PRODUCT CODE *";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.ForeColor = System.Drawing.Color.Silver;
            this.txtProductCode.Location = new System.Drawing.Point(91, 154);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(224, 27);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.Text = "Enter product code";
            // 
            // lblProductRegistration
            // 
            this.lblProductRegistration.AutoSize = true;
            this.lblProductRegistration.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductRegistration.Location = new System.Drawing.Point(15, 63);
            this.lblProductRegistration.Name = "lblProductRegistration";
            this.lblProductRegistration.Size = new System.Drawing.Size(272, 31);
            this.lblProductRegistration.TabIndex = 0;
            this.lblProductRegistration.Text = "Product Registration";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(21, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 31);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "<-Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // ProductRegistrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 465);
            this.Controls.Add(this.panel);
            this.Name = "ProductRegistrations";
            this.Text = "ProductRegistrations";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblValidNum;
        private System.Windows.Forms.Label lblProductCodeUnique;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductRegistration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
    }
}