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
            this.dgvSalesHistory = new System.Windows.Forms.DataGridView();
            this.clmTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSearchTransaction = new System.Windows.Forms.Button();
            this.txtSearchTransactionID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSalesHistory = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtySold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.txtSearchProductID = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtSalesHistory
            // 
            this.dtSalesHistory.Location = new System.Drawing.Point(444, 175);
            this.dtSalesHistory.Name = "dtSalesHistory";
            this.dtSalesHistory.Size = new System.Drawing.Size(231, 22);
            this.dtSalesHistory.TabIndex = 64;
            // 
            // dgvSalesHistory
            // 
            this.dgvSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTransactionID,
            this.clmDateTime,
            this.clmItems,
            this.clmTotal,
            this.clmPayment,
            this.clmView,
            this.clmDelete});
            this.dgvSalesHistory.Location = new System.Drawing.Point(12, 202);
            this.dgvSalesHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSalesHistory.Name = "dgvSalesHistory";
            this.dgvSalesHistory.RowHeadersWidth = 51;
            this.dgvSalesHistory.RowTemplate.Height = 24;
            this.dgvSalesHistory.Size = new System.Drawing.Size(931, 526);
            this.dgvSalesHistory.TabIndex = 63;
            // 
            // clmTransactionID
            // 
            this.clmTransactionID.HeaderText = "TRANSACTION ID";
            this.clmTransactionID.MinimumWidth = 6;
            this.clmTransactionID.Name = "clmTransactionID";
            this.clmTransactionID.Width = 125;
            // 
            // clmDateTime
            // 
            this.clmDateTime.HeaderText = "DATE & TIME";
            this.clmDateTime.MinimumWidth = 6;
            this.clmDateTime.Name = "clmDateTime";
            this.clmDateTime.Width = 125;
            // 
            // clmItems
            // 
            this.clmItems.HeaderText = "ITEMS";
            this.clmItems.MinimumWidth = 6;
            this.clmItems.Name = "clmItems";
            this.clmItems.Width = 125;
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "TOTAL";
            this.clmTotal.MinimumWidth = 6;
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.Width = 125;
            // 
            // clmPayment
            // 
            this.clmPayment.HeaderText = "PAYMENT";
            this.clmPayment.MinimumWidth = 6;
            this.clmPayment.Name = "clmPayment";
            this.clmPayment.Width = 125;
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
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(776, 173);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(167, 24);
            this.cmbPayment.TabIndex = 62;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(689, 174);
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
            this.lblDate.Location = new System.Drawing.Point(389, 176);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 20);
            this.lblDate.TabIndex = 60;
            this.lblDate.Text = "Date";
            // 
            // btnSearchTransaction
            // 
            this.btnSearchTransaction.Location = new System.Drawing.Point(12, 171);
            this.btnSearchTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchTransaction.Name = "btnSearchTransaction";
            this.btnSearchTransaction.Size = new System.Drawing.Size(83, 26);
            this.btnSearchTransaction.TabIndex = 59;
            this.btnSearchTransaction.Text = "Search";
            this.btnSearchTransaction.UseVisualStyleBackColor = true;
            // 
            // txtSearchTransactionID
            // 
            this.txtSearchTransactionID.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchTransactionID.Location = new System.Drawing.Point(101, 173);
            this.txtSearchTransactionID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchTransactionID.Multiline = true;
            this.txtSearchTransactionID.Name = "txtSearchTransactionID";
            this.txtSearchTransactionID.Size = new System.Drawing.Size(231, 24);
            this.txtSearchTransactionID.TabIndex = 58;
            this.txtSearchTransactionID.Text = "Search by Transaction ID....";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.lblSalesHistory);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1548, 61);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductID,
            this.clmProductName,
            this.clmQtySold,
            this.clmTotalSales});
            this.dataGridView1.Location = new System.Drawing.Point(981, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 526);
            this.dataGridView1.TabIndex = 65;
            // 
            // clmProductID
            // 
            this.clmProductID.HeaderText = "PRODUCT ID";
            this.clmProductID.MinimumWidth = 6;
            this.clmProductID.Name = "clmProductID";
            this.clmProductID.Width = 125;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "PRODUCT NAME";
            this.clmProductName.MinimumWidth = 6;
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.Width = 125;
            // 
            // clmQtySold
            // 
            this.clmQtySold.HeaderText = "QTY SOLD";
            this.clmQtySold.MinimumWidth = 6;
            this.clmQtySold.Name = "clmQtySold";
            this.clmQtySold.Width = 125;
            // 
            // clmTotalSales
            // 
            this.clmTotalSales.HeaderText = "TOTAL SALES";
            this.clmTotalSales.MinimumWidth = 6;
            this.clmTotalSales.Name = "clmTotalSales";
            this.clmTotalSales.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTransaction);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 53);
            this.panel1.TabIndex = 66;
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
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.Location = new System.Drawing.Point(345, 15);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(176, 25);
            this.lblTransaction.TabIndex = 0;
            this.lblTransaction.Text = "Transaction";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(981, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 54);
            this.panel2.TabIndex = 67;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item per sold";
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
            // btnSearchItem
            // 
            this.btnSearchItem.Location = new System.Drawing.Point(1009, 167);
            this.btnSearchItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(83, 28);
            this.btnSearchItem.TabIndex = 69;
            this.btnSearchItem.Text = "Search";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            // 
            // txtSearchProductID
            // 
            this.txtSearchProductID.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchProductID.Location = new System.Drawing.Point(1098, 169);
            this.txtSearchProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchProductID.Multiline = true;
            this.txtSearchProductID.Name = "txtSearchProductID";
            this.txtSearchProductID.Size = new System.Drawing.Size(231, 23);
            this.txtSearchProductID.TabIndex = 68;
            this.txtSearchProductID.Text = "Search by Product ID....";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(28, 68);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 31);
            this.btnBack.TabIndex = 70;
            this.btnBack.Text = "<-Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 741);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchItem);
            this.Controls.Add(this.txtSearchProductID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtSalesHistory);
            this.Controls.Add(this.dgvSalesHistory);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSearchTransaction);
            this.Controls.Add(this.txtSearchTransactionID);
            this.Controls.Add(this.panel3);
            this.Name = "SalesHistory";
            this.Text = "SalesHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtSalesHistory;
        private System.Windows.Forms.DataGridView dgvSalesHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPayment;
        private System.Windows.Forms.DataGridViewButtonColumn clmView;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSearchTransaction;
        private System.Windows.Forms.TextBox txtSearchTransactionID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSalesHistory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtySold;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.TextBox txtSearchProductID;
        private System.Windows.Forms.Button btnBack;
    }
}