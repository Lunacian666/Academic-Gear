namespace UI
{
    partial class PointOfSale
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbGCash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.dgvSalesItem = new System.Windows.Forms.DataGridView();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.udQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalesItems = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCashier = new System.Windows.Forms.Label();
            this.btnSearchPN = new System.Windows.Forms.Button();
            this.lblProducts = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblCashierAcc = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblNumDiscount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblNumSubTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(49, 626);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(85, 20);
            this.lblQuantity.TabIndex = 63;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProcessPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPayment.Location = new System.Drawing.Point(1115, 604);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(375, 57);
            this.btnProcessPayment.TabIndex = 65;
            this.btnProcessPayment.Text = "Process Payment";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.lblPaymentMethod);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(1115, 393);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(375, 63);
            this.panel6.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Perpetua Titling MT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1330, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cashier";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(16, 18);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(155, 22);
            this.lblPaymentMethod.TabIndex = 0;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1296, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "CASHIERACC";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.rbGCash);
            this.panel5.Controls.Add(this.rbCard);
            this.panel5.Controls.Add(this.rbCash);
            this.panel5.Location = new System.Drawing.Point(1115, 454);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 145);
            this.panel5.TabIndex = 64;
            // 
            // rbGCash
            // 
            this.rbGCash.AutoSize = true;
            this.rbGCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGCash.Location = new System.Drawing.Point(141, 82);
            this.rbGCash.Name = "rbGCash";
            this.rbGCash.Size = new System.Drawing.Size(95, 29);
            this.rbGCash.TabIndex = 53;
            this.rbGCash.TabStop = true;
            this.rbGCash.Text = "GCash";
            this.rbGCash.UseVisualStyleBackColor = true;
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCard.Location = new System.Drawing.Point(230, 30);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(76, 29);
            this.rbCard.TabIndex = 52;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Card";
            this.rbCard.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.Location = new System.Drawing.Point(56, 30);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(80, 29);
            this.rbCash.TabIndex = 51;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblPayment);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(684, 393);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 61);
            this.panel3.TabIndex = 61;
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
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(16, 18);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(85, 22);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment";
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
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnCancelSale);
            this.panel2.Controls.Add(this.btnPrintReceipt);
            this.panel2.Controls.Add(this.btnNewSale);
            this.panel2.Location = new System.Drawing.Point(-6, 666);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1496, 65);
            this.panel2.TabIndex = 57;
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSale.Location = new System.Drawing.Point(997, 10);
            this.btnCancelSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(160, 44);
            this.btnCancelSale.TabIndex = 55;
            this.btnCancelSale.Text = "Cancel Sale";
            this.btnCancelSale.UseVisualStyleBackColor = false;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.Location = new System.Drawing.Point(710, 10);
            this.btnPrintReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(160, 44);
            this.btnPrintReceipt.TabIndex = 54;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            // 
            // btnNewSale
            // 
            this.btnNewSale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSale.Location = new System.Drawing.Point(420, 10);
            this.btnNewSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(160, 44);
            this.btnNewSale.TabIndex = 53;
            this.btnNewSale.Text = "New Sale";
            this.btnNewSale.UseVisualStyleBackColor = false;
            // 
            // dgvSalesItem
            // 
            this.dgvSalesItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductName,
            this.clmQty,
            this.clmPrice,
            this.clmTotal,
            this.clmUpdate,
            this.clmDelete});
            this.dgvSalesItem.Location = new System.Drawing.Point(684, 42);
            this.dgvSalesItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSalesItem.Name = "dgvSalesItem";
            this.dgvSalesItem.RowHeadersWidth = 51;
            this.dgvSalesItem.RowTemplate.Height = 24;
            this.dgvSalesItem.Size = new System.Drawing.Size(806, 347);
            this.dgvSalesItem.TabIndex = 60;
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
            // clmUpdate
            // 
            this.clmUpdate.HeaderText = "UPDATE";
            this.clmUpdate.MinimumWidth = 6;
            this.clmUpdate.Name = "clmUpdate";
            this.clmUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmUpdate.Width = 125;
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
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(334, 614);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(160, 44);
            this.btnAddProduct.TabIndex = 54;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // udQuantity
            // 
            this.udQuantity.Location = new System.Drawing.Point(152, 626);
            this.udQuantity.Name = "udQuantity";
            this.udQuantity.Size = new System.Drawing.Size(133, 22);
            this.udQuantity.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSalesItems);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(684, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 61);
            this.panel1.TabIndex = 56;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(681, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 28);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
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
            // lblSalesItems
            // 
            this.lblSalesItems.AutoSize = true;
            this.lblSalesItems.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesItems.Location = new System.Drawing.Point(16, 11);
            this.lblSalesItems.Name = "lblSalesItems";
            this.lblSalesItems.Size = new System.Drawing.Size(111, 22);
            this.lblSalesItems.TabIndex = 0;
            this.lblSalesItems.Text = "Sales Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1296, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "CASHIERACC";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.Category,
            this.Price,
            this.AvailableStock});
            this.dgvProducts.Location = new System.Drawing.Point(0, 85);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(678, 514);
            this.dgvProducts.TabIndex = 53;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "PRODUCT CODE";
            this.ProductCode.MinimumWidth = 6;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "PRODUCT NAME";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "CATEGORY";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "PRICE";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // AvailableStock
            // 
            this.AvailableStock.HeaderText = "AVAILABLE STOCK";
            this.AvailableStock.MinimumWidth = 6;
            this.AvailableStock.Name = "AvailableStock";
            this.AvailableStock.Width = 125;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Silver;
            this.panelTop.Controls.Add(this.lblCashier);
            this.panelTop.Controls.Add(this.btnSearchPN);
            this.panelTop.Controls.Add(this.lblProducts);
            this.panelTop.Controls.Add(this.txtSearchProduct);
            this.panelTop.Controls.Add(this.lblCashierAcc);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(678, 85);
            this.panelTop.TabIndex = 55;
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Font = new System.Drawing.Font("Perpetua Titling MT", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashier.Location = new System.Drawing.Point(1330, 39);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(57, 15);
            this.lblCashier.TabIndex = 3;
            this.lblCashier.Text = "Cashier";
            // 
            // btnSearchPN
            // 
            this.btnSearchPN.Location = new System.Drawing.Point(12, 42);
            this.btnSearchPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchPN.Name = "btnSearchPN";
            this.btnSearchPN.Size = new System.Drawing.Size(83, 28);
            this.btnSearchPN.TabIndex = 34;
            this.btnSearchPN.Text = "Search";
            this.btnSearchPN.UseVisualStyleBackColor = true;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(16, 12);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(90, 22);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "Products";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchProduct.Location = new System.Drawing.Point(101, 46);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(259, 22);
            this.txtSearchProduct.TabIndex = 33;
            this.txtSearchProduct.Text = "Search by product name...";
            // 
            // lblCashierAcc
            // 
            this.lblCashierAcc.AutoSize = true;
            this.lblCashierAcc.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierAcc.Location = new System.Drawing.Point(1296, 19);
            this.lblCashierAcc.Name = "lblCashierAcc";
            this.lblCashierAcc.Size = new System.Drawing.Size(125, 21);
            this.lblCashierAcc.TabIndex = 2;
            this.lblCashierAcc.Text = "CASHIERACC";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.lblNumTotalAmount);
            this.panel4.Controls.Add(this.lblTotalAmount);
            this.panel4.Controls.Add(this.txtDiscount);
            this.panel4.Controls.Add(this.lblNumDiscount);
            this.panel4.Controls.Add(this.lblDiscount);
            this.panel4.Controls.Add(this.lblNumSubTotal);
            this.panel4.Controls.Add(this.lblSubTotal);
            this.panel4.Location = new System.Drawing.Point(684, 454);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 208);
            this.panel4.TabIndex = 59;
            // 
            // lblNumTotalAmount
            // 
            this.lblNumTotalAmount.AutoSize = true;
            this.lblNumTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTotalAmount.Location = new System.Drawing.Point(281, 116);
            this.lblNumTotalAmount.Name = "lblNumTotalAmount";
            this.lblNumTotalAmount.Size = new System.Drawing.Size(76, 29);
            this.lblNumTotalAmount.TabIndex = 50;
            this.lblNumTotalAmount.Text = "00.00";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(64, 116);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(174, 29);
            this.lblTotalAmount.TabIndex = 49;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(170, 71);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 22);
            this.txtDiscount.TabIndex = 48;
            // 
            // lblNumDiscount
            // 
            this.lblNumDiscount.AutoSize = true;
            this.lblNumDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDiscount.Location = new System.Drawing.Point(303, 71);
            this.lblNumDiscount.Name = "lblNumDiscount";
            this.lblNumDiscount.Size = new System.Drawing.Size(54, 20);
            this.lblNumDiscount.TabIndex = 47;
            this.lblNumDiscount.Text = "00.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(65, 71);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(90, 20);
            this.lblDiscount.TabIndex = 46;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblNumSubTotal
            // 
            this.lblNumSubTotal.AutoSize = true;
            this.lblNumSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSubTotal.Location = new System.Drawing.Point(190, 30);
            this.lblNumSubTotal.Name = "lblNumSubTotal";
            this.lblNumSubTotal.Size = new System.Drawing.Size(54, 20);
            this.lblNumSubTotal.TabIndex = 45;
            this.lblNumSubTotal.Text = "00.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(65, 30);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(84, 20);
            this.lblSubTotal.TabIndex = 44;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // PointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 730);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnProcessPayment);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvSalesItem);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.udQuantity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel4);
            this.Name = "PointOfSale";
            this.Text = "PointOfSale";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbGCash;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.DataGridView dgvSalesItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.DataGridViewButtonColumn clmUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.NumericUpDown udQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalesItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableStock;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Button btnSearchPN;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblCashierAcc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblNumDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblNumSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
    }
}