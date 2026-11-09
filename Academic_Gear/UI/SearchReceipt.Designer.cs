namespace UI
{
    partial class SearchReceipt
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
            this.dtReceipt = new System.Windows.Forms.DateTimePicker();
            this.dgSearchReceipt = new System.Windows.Forms.DataGridView();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSearchReceipt = new System.Windows.Forms.Button();
            this.txtSearchReceipt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.clmReceiptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPaymentMethid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchReceipt)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 28);
            this.btnBack.TabIndex = 73;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // dtReceipt
            // 
            this.dtReceipt.Location = new System.Drawing.Point(461, 124);
            this.dtReceipt.Name = "dtReceipt";
            this.dtReceipt.Size = new System.Drawing.Size(231, 22);
            this.dtReceipt.TabIndex = 72;
            // 
            // dgSearchReceipt
            // 
            this.dgSearchReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearchReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmReceiptNo,
            this.clmDate,
            this.clmCashier,
            this.clmTotal,
            this.clmPaymentMethid,
            this.clmView,
            this.clmDelete});
            this.dgSearchReceipt.Location = new System.Drawing.Point(29, 161);
            this.dgSearchReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgSearchReceipt.Name = "dgSearchReceipt";
            this.dgSearchReceipt.RowHeadersWidth = 51;
            this.dgSearchReceipt.RowTemplate.Height = 24;
            this.dgSearchReceipt.Size = new System.Drawing.Size(931, 558);
            this.dgSearchReceipt.TabIndex = 71;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(706, 123);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(81, 20);
            this.lblPayment.TabIndex = 70;
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
            this.lblDate.TabIndex = 69;
            this.lblDate.Text = "Date";
            // 
            // btnSearchReceipt
            // 
            this.btnSearchReceipt.Location = new System.Drawing.Point(29, 120);
            this.btnSearchReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchReceipt.Name = "btnSearchReceipt";
            this.btnSearchReceipt.Size = new System.Drawing.Size(83, 28);
            this.btnSearchReceipt.TabIndex = 68;
            this.btnSearchReceipt.Text = "Search";
            this.btnSearchReceipt.UseVisualStyleBackColor = true;
            // 
            // txtSearchReceipt
            // 
            this.txtSearchReceipt.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchReceipt.Location = new System.Drawing.Point(118, 122);
            this.txtSearchReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchReceipt.Multiline = true;
            this.txtSearchReceipt.Name = "txtSearchReceipt";
            this.txtSearchReceipt.Size = new System.Drawing.Size(231, 23);
            this.txtSearchReceipt.TabIndex = 67;
            this.txtSearchReceipt.Text = "Search by Receipt Number....";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.lblReceipt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(963, 61);
            this.panel3.TabIndex = 66;
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceipt.Location = new System.Drawing.Point(22, 14);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(106, 31);
            this.lblReceipt.TabIndex = 4;
            this.lblReceipt.Text = "Receipt";
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
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(793, 121);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(167, 24);
            this.cmbPayment.TabIndex = 74;
            // 
            // clmReceiptNo
            // 
            this.clmReceiptNo.HeaderText = "RECEIPT NO.";
            this.clmReceiptNo.MinimumWidth = 6;
            this.clmReceiptNo.Name = "clmReceiptNo";
            this.clmReceiptNo.Width = 125;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "DATE";
            this.clmDate.MinimumWidth = 6;
            this.clmDate.Name = "clmDate";
            this.clmDate.Width = 125;
            // 
            // clmCashier
            // 
            this.clmCashier.HeaderText = "CASHIER";
            this.clmCashier.MinimumWidth = 6;
            this.clmCashier.Name = "clmCashier";
            this.clmCashier.Width = 125;
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "TOTAL";
            this.clmTotal.MinimumWidth = 6;
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.Width = 125;
            // 
            // clmPaymentMethid
            // 
            this.clmPaymentMethid.HeaderText = "PAYMENT METHOD";
            this.clmPaymentMethid.MinimumWidth = 6;
            this.clmPaymentMethid.Name = "clmPaymentMethid";
            this.clmPaymentMethid.Width = 125;
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
            // SearchReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 736);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtReceipt);
            this.Controls.Add(this.dgSearchReceipt);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSearchReceipt);
            this.Controls.Add(this.txtSearchReceipt);
            this.Controls.Add(this.panel3);
            this.Name = "SearchReceipt";
            this.Text = "SearchReceipt";
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchReceipt)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtReceipt;
        private System.Windows.Forms.DataGridView dgSearchReceipt;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSearchReceipt;
        private System.Windows.Forms.TextBox txtSearchReceipt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceiptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPaymentMethid;
        private System.Windows.Forms.DataGridViewButtonColumn clmView;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        public System.Windows.Forms.ComboBox cmbPayment;
    }
}