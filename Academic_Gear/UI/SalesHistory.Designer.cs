namespace UI
{
    partial class SalesHistory
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
            this.dtSalesHistory = new System.Windows.Forms.DateTimePicker();
            this.dgSalesHistory = new System.Windows.Forms.DataGridView();
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
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesHistory)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtSalesHistory
            // 
            this.dtSalesHistory.Location = new System.Drawing.Point(461, 124);
            this.dtSalesHistory.Name = "dtSalesHistory";
            this.dtSalesHistory.Size = new System.Drawing.Size(231, 22);
            this.dtSalesHistory.TabIndex = 64;
            // 
            // dgSalesHistory
            // 
            this.dgSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductName,
            this.clmPrice,
            this.clmQty,
            this.clmTotal,
            this.clmView,
            this.clmDelete});
            this.dgSalesHistory.Location = new System.Drawing.Point(29, 161);
            this.dgSalesHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgSalesHistory.Name = "dgSalesHistory";
            this.dgSalesHistory.RowHeadersWidth = 51;
            this.dgSalesHistory.RowTemplate.Height = 24;
            this.dgSalesHistory.Size = new System.Drawing.Size(931, 558);
            this.dgSalesHistory.TabIndex = 63;
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(793, 122);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(167, 24);
            this.cmbPayment.TabIndex = 62;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(706, 123);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(81, 20);
            this.lblPayment.TabIndex = 61;
            this.lblPayment.Text = "Payment";
            this.lblPayment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(406, 125);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 20);
            this.lblDate.TabIndex = 60;
            this.lblDate.Text = "Date";
            // 
            // btnSearchPN
            // 
            this.btnSearchPN.Location = new System.Drawing.Point(29, 120);
            this.btnSearchPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchPN.Name = "btnSearchPN";
            this.btnSearchPN.Size = new System.Drawing.Size(83, 28);
            this.btnSearchPN.TabIndex = 59;
            this.btnSearchPN.Text = "Search";
            this.btnSearchPN.UseVisualStyleBackColor = true;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchProduct.Location = new System.Drawing.Point(118, 122);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchProduct.Multiline = true;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(231, 23);
            this.txtSearchProduct.TabIndex = 58;
            this.txtSearchProduct.Text = "Search by Product Name....";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.lblSalesHistory);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(963, 61);
            this.panel3.TabIndex = 57;
            // 
            // lblSalesHistory
            // 
            this.lblSalesHistory.AutoSize = true;
            this.lblSalesHistory.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesHistory.Location = new System.Drawing.Point(22, 14);
            this.lblSalesHistory.Name = "lblSalesHistory";
            this.lblSalesHistory.Size = new System.Drawing.Size(175, 31);
            this.lblSalesHistory.TabIndex = 4;
            this.lblSalesHistory.Text = "Sales History";
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 28);
            this.btnBack.TabIndex = 65;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "PRODUCT NAME";
            this.clmProductName.MinimumWidth = 6;
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.Width = 125;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "PRICE";
            this.clmPrice.MinimumWidth = 6;
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Width = 125;
            // 
            // clmQty
            // 
            this.clmQty.HeaderText = "QTY";
            this.clmQty.MinimumWidth = 6;
            this.clmQty.Name = "clmQty";
            this.clmQty.Width = 125;
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "TOTAL";
            this.clmTotal.MinimumWidth = 6;
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.Width = 125;
            // 
            // clmView
            // 
            this.clmView.HeaderText = "VIEW";
            this.clmView.MinimumWidth = 6;
            this.clmView.Name = "clmView";
            this.clmView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmView.Width = 125;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "DELETE";
            this.clmDelete.MinimumWidth = 6;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmDelete.Width = 125;
            // 
            // SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 744);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtSalesHistory);
            this.Controls.Add(this.dgSalesHistory);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSearchPN);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.panel3);
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
        private System.Windows.Forms.DataGridViewButtonColumn clmView;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
    }
}