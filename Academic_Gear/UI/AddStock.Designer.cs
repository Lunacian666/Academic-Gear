namespace UI
{
    partial class AddStock
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
            this.lblTopLabel = new System.Windows.Forms.Label();
            this.lblProductInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStockAddition = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numAdditionalQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAdditionalQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopLabel
            // 
            this.lblTopLabel.AutoSize = true;
            this.lblTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopLabel.Location = new System.Drawing.Point(22, 18);
            this.lblTopLabel.Name = "lblTopLabel";
            this.lblTopLabel.Size = new System.Drawing.Size(327, 29);
            this.lblTopLabel.TabIndex = 0;
            this.lblTopLabel.Text = "Add Existing Product Stock";
            // 
            // lblProductInfo
            // 
            this.lblProductInfo.AutoSize = true;
            this.lblProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductInfo.Location = new System.Drawing.Point(41, 88);
            this.lblProductInfo.Name = "lblProductInfo";
            this.lblProductInfo.Size = new System.Drawing.Size(199, 25);
            this.lblProductInfo.TabIndex = 1;
            this.lblProductInfo.Text = "Product Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Current Stock";
            // 
            // lblStockAddition
            // 
            this.lblStockAddition.AutoSize = true;
            this.lblStockAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAddition.Location = new System.Drawing.Point(42, 329);
            this.lblStockAddition.Name = "lblStockAddition";
            this.lblStockAddition.Size = new System.Drawing.Size(125, 22);
            this.lblStockAddition.TabIndex = 6;
            this.lblStockAddition.Text = "Stock Addition";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(60, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Additional Quantity";
            // 
            // numAdditionalQuantity
            // 
            this.numAdditionalQuantity.Location = new System.Drawing.Point(82, 374);
            this.numAdditionalQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAdditionalQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdditionalQuantity.Name = "numAdditionalQuantity";
            this.numAdditionalQuantity.Size = new System.Drawing.Size(183, 22);
            this.numAdditionalQuantity.TabIndex = 8;
            this.numAdditionalQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(327, 409);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Location = new System.Drawing.Point(422, 409);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(122, 23);
            this.btnConfirmAdd.TabIndex = 10;
            this.btnConfirmAdd.Text = "Confirm Add";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(113, 165);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(106, 20);
            this.lblProductCode.TabIndex = 11;
            this.lblProductCode.Text = "ProductCode";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(113, 255);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(111, 20);
            this.lblProductName.TabIndex = 12;
            this.lblProductName.Text = "ProductName";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(362, 165);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(76, 20);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Category";
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStock.Location = new System.Drawing.Point(362, 255);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(107, 20);
            this.lblCurrentStock.TabIndex = 14;
            this.lblCurrentStock.Text = "CurrentStock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "---------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "---------------------------";
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentStock);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.btnConfirmAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numAdditionalQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblStockAddition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProductInfo);
            this.Controls.Add(this.lblTopLabel);
            this.Name = "AddStock";
            this.Text = "AddStock";
            ((System.ComponentModel.ISupportInitialize)(this.numAdditionalQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopLabel;
        private System.Windows.Forms.Label lblProductInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStockAddition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numAdditionalQuantity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}