namespace UI
{
    partial class Receipt
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPayMethod = new System.Windows.Forms.Label();
            this.lblNumChange = new System.Windows.Forms.Label();
            this.lblNumCash = new System.Windows.Forms.Label();
            this.lblNumDiscount = new System.Windows.Forms.Label();
            this.lblNumTotalAmount = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAcademicGear = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtReceipt = new System.Windows.Forms.DateTimePicker();
            this.lblCashier = new System.Windows.Forms.Label();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(318, 562);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 36);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(112, 562);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(160, 36);
            this.btnPrint.TabIndex = 61;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblPayMethod);
            this.panel1.Controls.Add(this.lblNumChange);
            this.panel1.Controls.Add(this.lblNumCash);
            this.panel1.Controls.Add(this.lblNumDiscount);
            this.panel1.Controls.Add(this.lblNumTotalAmount);
            this.panel1.Controls.Add(this.lblCash);
            this.panel1.Controls.Add(this.lblChange);
            this.panel1.Controls.Add(this.lblPaymentMethod);
            this.panel1.Controls.Add(this.lblDiscount);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(21, 443);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 104);
            this.panel1.TabIndex = 59;
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.AutoSize = true;
            this.lblPayMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMethod.Location = new System.Drawing.Point(197, 76);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(34, 20);
            this.lblPayMethod.TabIndex = 54;
            this.lblPayMethod.Text = ".....";
            // 
            // lblNumChange
            // 
            this.lblNumChange.AutoSize = true;
            this.lblNumChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumChange.Location = new System.Drawing.Point(397, 42);
            this.lblNumChange.Name = "lblNumChange";
            this.lblNumChange.Size = new System.Drawing.Size(54, 20);
            this.lblNumChange.TabIndex = 53;
            this.lblNumChange.Text = "00.00";
            // 
            // lblNumCash
            // 
            this.lblNumCash.AutoSize = true;
            this.lblNumCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCash.Location = new System.Drawing.Point(397, 9);
            this.lblNumCash.Name = "lblNumCash";
            this.lblNumCash.Size = new System.Drawing.Size(54, 20);
            this.lblNumCash.TabIndex = 52;
            this.lblNumCash.Text = "00.00";
            // 
            // lblNumDiscount
            // 
            this.lblNumDiscount.AutoSize = true;
            this.lblNumDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDiscount.Location = new System.Drawing.Point(197, 42);
            this.lblNumDiscount.Name = "lblNumDiscount";
            this.lblNumDiscount.Size = new System.Drawing.Size(54, 20);
            this.lblNumDiscount.TabIndex = 51;
            this.lblNumDiscount.Text = "00.00";
            // 
            // lblNumTotalAmount
            // 
            this.lblNumTotalAmount.AutoSize = true;
            this.lblNumTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTotalAmount.Location = new System.Drawing.Point(197, 9);
            this.lblNumTotalAmount.Name = "lblNumTotalAmount";
            this.lblNumTotalAmount.Size = new System.Drawing.Size(54, 20);
            this.lblNumTotalAmount.TabIndex = 48;
            this.lblNumTotalAmount.Text = "00.00";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(293, 9);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(58, 20);
            this.lblCash.TabIndex = 50;
            this.lblCash.Text = "Cash:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(293, 42);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(78, 20);
            this.lblChange.TabIndex = 49;
            this.lblChange.Text = "Change:";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(20, 76);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(154, 20);
            this.lblPaymentMethod.TabIndex = 49;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(20, 42);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(90, 20);
            this.lblDiscount.TabIndex = 49;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(17, 9);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(126, 20);
            this.lblTotalAmount.TabIndex = 48;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1330, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cashier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1296, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "CASHIERACC";
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductName,
            this.clmQty,
            this.clmPrice,
            this.clmTotal});
            this.dgvReceipt.Location = new System.Drawing.Point(21, 159);
            this.dgvReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.Size = new System.Drawing.Size(554, 280);
            this.dgvReceipt.TabIndex = 60;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "PRODUCT NAME";
            this.clmProductName.MinimumWidth = 6;
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.Width = 125;
            // 
            // clmQty
            // 
            this.clmQty.HeaderText = "QTY";
            this.clmQty.MinimumWidth = 6;
            this.clmQty.Name = "clmQty";
            this.clmQty.Width = 125;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "PRICE";
            this.clmPrice.MinimumWidth = 6;
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Width = 125;
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "TOTAL";
            this.clmTotal.MinimumWidth = 6;
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblAcademicGear);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(21, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 61);
            this.panel3.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1330, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cashier";
            // 
            // lblAcademicGear
            // 
            this.lblAcademicGear.AutoSize = true;
            this.lblAcademicGear.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicGear.Location = new System.Drawing.Point(153, 16);
            this.lblAcademicGear.Name = "lblAcademicGear";
            this.lblAcademicGear.Size = new System.Drawing.Size(252, 31);
            this.lblAcademicGear.TabIndex = 0;
            this.lblAcademicGear.Text = "Academic Gear";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1296, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "CASHIERACC";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.dtReceipt);
            this.panel4.Controls.Add(this.lblCashier);
            this.panel4.Controls.Add(this.lblCashierName);
            this.panel4.Controls.Add(this.lblDateTime);
            this.panel4.Location = new System.Drawing.Point(21, 87);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(554, 88);
            this.panel4.TabIndex = 57;
            // 
            // dtReceipt
            // 
            this.dtReceipt.Location = new System.Drawing.Point(174, 13);
            this.dtReceipt.Name = "dtReceipt";
            this.dtReceipt.Size = new System.Drawing.Size(231, 22);
            this.dtReceipt.TabIndex = 47;
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashier.Location = new System.Drawing.Point(17, 50);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(80, 20);
            this.lblCashier.TabIndex = 46;
            this.lblCashier.Text = "Cashier:";
            // 
            // lblCashierName
            // 
            this.lblCashierName.AutoSize = true;
            this.lblCashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierName.Location = new System.Drawing.Point(170, 50);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(34, 20);
            this.lblCashierName.TabIndex = 45;
            this.lblCashierName.Text = ".....";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(17, 13);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(138, 20);
            this.lblDateTime.TabIndex = 44;
            this.lblDateTime.Text = "Date and Time:";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 624);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvReceipt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPayMethod;
        private System.Windows.Forms.Label lblNumChange;
        private System.Windows.Forms.Label lblNumCash;
        private System.Windows.Forms.Label lblNumDiscount;
        private System.Windows.Forms.Label lblNumTotalAmount;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAcademicGear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtReceipt;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Label lblCashierName;
        private System.Windows.Forms.Label lblDateTime;
    }
}