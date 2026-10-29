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
            this.btnBack = new System.Windows.Forms.Button();
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
            this.lblUnitPerMeasure = new System.Windows.Forms.Label();
            this.cmbUnitPerMeasure = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 25);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "<-Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(495, 489);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblValidNum
            // 
            this.lblValidNum.AutoSize = true;
            this.lblValidNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidNum.ForeColor = System.Drawing.Color.Gray;
            this.lblValidNum.Location = new System.Drawing.Point(593, 232);
            this.lblValidNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidNum.Name = "lblValidNum";
            this.lblValidNum.Size = new System.Drawing.Size(174, 13);
            this.lblValidNum.TabIndex = 38;
            this.lblValidNum.Text = "Must be a valid number (e.g. 50.00)";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(352, 489);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 36);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblProductCodeUnique
            // 
            this.lblProductCodeUnique.AutoSize = true;
            this.lblProductCodeUnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCodeUnique.ForeColor = System.Drawing.Color.Gray;
            this.lblProductCodeUnique.Location = new System.Drawing.Point(160, 337);
            this.lblProductCodeUnique.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductCodeUnique.Name = "lblProductCodeUnique";
            this.lblProductCodeUnique.Size = new System.Drawing.Size(149, 13);
            this.lblProductCodeUnique.TabIndex = 37;
            this.lblProductCodeUnique.Text = "Product Code must be unique.";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(146, 206);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(239, 25);
            this.cmbCategory.TabIndex = 36;
            this.cmbCategory.Text = "Select Category";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(578, 416);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(236, 23);
            this.txtQuantity.TabIndex = 35;
            this.txtQuantity.Text = "Enter quantity";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(574, 386);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(125, 22);
            this.lblQuantity.TabIndex = 34;
            this.lblQuantity.Text = "QUANTITY *";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(578, 207);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(236, 23);
            this.txtPrice.TabIndex = 33;
            this.txtPrice.Text = "Enter price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(574, 176);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(85, 22);
            this.lblPrice.TabIndex = 32;
            this.lblPrice.Text = "PRICE *";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(142, 176);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(132, 22);
            this.lblCategory.TabIndex = 31;
            this.lblCategory.Text = "CATEGORY *";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.Location = new System.Drawing.Point(578, 311);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(236, 23);
            this.txtProductName.TabIndex = 30;
            this.txtProductName.Text = "Enter product name";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(574, 281);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(183, 22);
            this.lblProductName.TabIndex = 29;
            this.lblProductName.Text = "PRODUCT NAME *";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(142, 281);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(181, 22);
            this.lblProductCode.TabIndex = 28;
            this.lblProductCode.Text = "PRODUCT CODE *";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.ForeColor = System.Drawing.Color.Black;
            this.txtProductCode.Location = new System.Drawing.Point(146, 312);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(239, 23);
            this.txtProductCode.TabIndex = 27;
            this.txtProductCode.Text = "Enter product code";
            // 
            // lblProductRegistration
            // 
            this.lblProductRegistration.AutoSize = true;
            this.lblProductRegistration.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductRegistration.Location = new System.Drawing.Point(347, 109);
            this.lblProductRegistration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductRegistration.Name = "lblProductRegistration";
            this.lblProductRegistration.Size = new System.Drawing.Size(234, 27);
            this.lblProductRegistration.TabIndex = 26;
            this.lblProductRegistration.Text = "Product Registration";
            // 
            // lblUnitPerMeasure
            // 
            this.lblUnitPerMeasure.AutoSize = true;
            this.lblUnitPerMeasure.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPerMeasure.Location = new System.Drawing.Point(142, 386);
            this.lblUnitPerMeasure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitPerMeasure.Name = "lblUnitPerMeasure";
            this.lblUnitPerMeasure.Size = new System.Drawing.Size(216, 22);
            this.lblUnitPerMeasure.TabIndex = 42;
            this.lblUnitPerMeasure.Text = "UNIT PER MEASURE *";
            // 
            // cmbUnitPerMeasure
            // 
            this.cmbUnitPerMeasure.AccessibleDescription = "";
            this.cmbUnitPerMeasure.AccessibleName = "";
            this.cmbUnitPerMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitPerMeasure.FormattingEnabled = true;
            this.cmbUnitPerMeasure.Location = new System.Drawing.Point(146, 419);
            this.cmbUnitPerMeasure.Name = "cmbUnitPerMeasure";
            this.cmbUnitPerMeasure.Size = new System.Drawing.Size(239, 24);
            this.cmbUnitPerMeasure.TabIndex = 44;
            this.cmbUnitPerMeasure.Text = "Select Category";
            // 
            // ProductRegistrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 738);
            this.Controls.Add(this.cmbUnitPerMeasure);
            this.Controls.Add(this.lblUnitPerMeasure);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblValidNum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblProductCodeUnique);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblProductRegistration);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductRegistrations";
            this.Text = "ProductRegistrations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblValidNum;
        private System.Windows.Forms.Button btnCancel;
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
        private System.Windows.Forms.Label lblUnitPerMeasure;
        private System.Windows.Forms.ComboBox cmbUnitPerMeasure;
    }
}