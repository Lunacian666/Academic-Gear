namespace UI
{
    partial class SalesHistory
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
            this.dtSalesHistory = new System.Windows.Forms.DateTimePicker();
            this.dgSalesHistory = new System.Windows.Forms.DataGridView();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSearchPN = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSalesHistory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesHistory)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtSalesHistory
            // 
            this.dtSalesHistory.Location = new System.Drawing.Point(346, 101);
            this.dtSalesHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dtSalesHistory.Name = "dtSalesHistory";
            this.dtSalesHistory.Size = new System.Drawing.Size(201, 20);
            this.dtSalesHistory.TabIndex = 64;
            // 
            // dgSalesHistory
            // 
            this.dgSalesHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductName,
            this.clmPrice,
            this.clmQty,
            this.clmTotal,
            this.clmDate,
            this.clmPaymentMethod});
            this.dgSalesHistory.Location = new System.Drawing.Point(22, 131);
            this.dgSalesHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dgSalesHistory.Name = "dgSalesHistory";
            this.dgSalesHistory.RowHeadersVisible = false;
            this.dgSalesHistory.RowHeadersWidth = 51;
            this.dgSalesHistory.RowTemplate.Height = 24;
            this.dgSalesHistory.Size = new System.Drawing.Size(805, 453);
            this.dgSalesHistory.TabIndex = 63;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "PRODUCT NAME";
            this.clmProductName.MinimumWidth = 6;
            this.clmProductName.Name = "clmProductName";
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "PRICE";
            this.clmPrice.MinimumWidth = 6;
            this.clmPrice.Name = "clmPrice";
            // 
            // clmQty
            // 
            this.clmQty.HeaderText = "QTY";
            this.clmQty.MinimumWidth = 6;
            this.clmQty.Name = "clmQty";
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "TOTAL";
            this.clmTotal.MinimumWidth = 6;
            this.clmTotal.Name = "clmTotal";
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "DATE";
            this.clmDate.MinimumWidth = 6;
            this.clmDate.Name = "clmDate";
            // 
            // clmPaymentMethod
            // 
            this.clmPaymentMethod.HeaderText = "PAYMENT METHOD";
            this.clmPaymentMethod.MinimumWidth = 6;
            this.clmPaymentMethod.Name = "clmPaymentMethod";
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(701, 99);
            this.cmbPayment.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(126, 21);
            this.cmbPayment.TabIndex = 62;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(627, 101);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(70, 17);
            this.lblPayment.TabIndex = 61;
            this.lblPayment.Text = "Payment";
            this.lblPayment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(300, 104);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 60;
            this.lblDate.Text = "Date";
            // 
            // btnSearchPN
            // 
            this.btnSearchPN.Location = new System.Drawing.Point(22, 98);
            this.btnSearchPN.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPN.Name = "btnSearchPN";
            this.btnSearchPN.Size = new System.Drawing.Size(62, 23);
            this.btnSearchPN.TabIndex = 59;
            this.btnSearchPN.Text = "Search";
            this.btnSearchPN.UseVisualStyleBackColor = true;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Black;
            this.txtSearchProduct.Location = new System.Drawing.Point(88, 98);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchProduct.Multiline = true;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(179, 23);
            this.txtSearchProduct.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.lblSalesHistory);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(22, 32);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 50);
            this.panel3.TabIndex = 57;
            // 
            // lblSalesHistory
            // 
            this.lblSalesHistory.AutoSize = true;
            this.lblSalesHistory.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesHistory.Location = new System.Drawing.Point(16, 11);
            this.lblSalesHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesHistory.Name = "lblSalesHistory";
            this.lblSalesHistory.Size = new System.Drawing.Size(138, 25);
            this.lblSalesHistory.TabIndex = 4;
            this.lblSalesHistory.Text = "Sales History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(998, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cashier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(972, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "CASHIERACC";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 23);
            this.btnBack.TabIndex = 65;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 648);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtSalesHistory);
            this.Controls.Add(this.dgSalesHistory);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSearchPN);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalesHistory";
            this.Text = "SalesHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesHistory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtSalesHistory;
        private System.Windows.Forms.DataGridView dgSalesHistory;
        public System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSearchPN;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSalesHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPaymentMethod;
    }
}
