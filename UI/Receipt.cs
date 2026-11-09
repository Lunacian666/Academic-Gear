using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class Receipt : Form
    {
        private readonly int? saleId;
        private SaleInfo sale;
        private readonly PrintDocument document = new PrintDocument();
        private int printIndex;

        public Receipt() : this(null) { }
        public Receipt(int id) : this((int?)id) { }

        private Receipt(int? id)
        {
            saleId = id;
            InitializeComponent();
            dgvReceipt.ReadOnly = true;
            dgvReceipt.AllowUserToAddRows = false;
            btnPrint.Click += btnPrint_Click;
            Shown += Receipt_Shown;
            document.PrintPage += Document_PrintPage;
        }

        private void Receipt_Shown(object sender, EventArgs e)
        {
            if (!saleId.HasValue)
            {
                btnPrint.Enabled = false;
                MessageBox.Show("Open a completed sale to display its receipt.");
                return;
            }
            try
            {
                sale = new SalesRepo().GetSale(saleId.Value);
                if (sale == null)
                {
                    MessageBox.Show("Receipt not found for this sale.");
                    btnPrint.Enabled = false;
                    return;
                }
                Text = "Receipt #" + sale.Id;
                dtReceipt.Value = sale.Date;
                lblCashierName.Text = sale.Cashier;
                lblPayMethod.Text = sale.PaymentMethod;
                lblNumTotalAmount.Text = sale.Total.ToString("N2");
                lblNumDiscount.Text = sale.Discount.ToString("N2");
                lblNumCash.Text = sale.Received.ToString("N2");
                lblNumChange.Text = sale.Change.ToString("N2");
                dgvReceipt.Rows.Clear();
                foreach (SaleLine line in sale.Items)
                    dgvReceipt.Rows.Add(line.ProductName, line.Quantity,
                        line.UnitPrice.ToString("N2"), line.LineTotal.ToString("N2"));
            }
            catch (Exception ex)
            {
                btnPrint.Enabled = false;
                MessageBox.Show("Unable to load receipt.\n" + ex.Message,
                    "Receipt Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (sale == null) return;
            try
            {
                printIndex = 0;
                using (var preview = new PrintPreviewDialog())
                {
                    preview.Document = document;
                    preview.Width = 850;
                    preview.Height = 700;
                    preview.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing failed: " + ex.Message,
                    "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (sale == null) return;
            using (var font = new Font("Consolas", 9f))
            using (var bold = new Font("Consolas", 12f, FontStyle.Bold))
            {
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                const float step = 19f;
                e.Graphics.DrawString("ACADEMIC GEAR", bold, Brushes.Black, x, y); y += 31;
                e.Graphics.DrawString("Receipt #" + sale.Id + "  " + sale.Date.ToString("yyyy-MM-dd HH:mm"), font, Brushes.Black, x, y); y += step;
                e.Graphics.DrawString("Cashier: " + sale.Cashier + "  Payment: " + sale.PaymentMethod, font, Brushes.Black, x, y); y += 2 * step;
                if (printIndex == 0)
                    e.Graphics.DrawString("Item                         Qty       Price        Total", font, Brushes.Black, x, y);
                y += step;
                while (printIndex < sale.Items.Count && y + 6 * step < e.MarginBounds.Bottom)
                {
                    SaleLine line = sale.Items[printIndex];
                    string name = line.ProductName.Length > 24 ? line.ProductName.Substring(0, 24) : line.ProductName;
                    e.Graphics.DrawString(string.Format("{0,-24} {1,4} {2,11:N2} {3,12:N2}",
                        name, line.Quantity, line.UnitPrice, line.LineTotal), font, Brushes.Black, x, y);
                    y += step;
                    printIndex++;
                }
                if (printIndex < sale.Items.Count)
                {
                    e.HasMorePages = true;
                    return;
                }
                y += step;
                e.Graphics.DrawString("Subtotal: " + sale.Subtotal.ToString("N2"), font, Brushes.Black, x, y); y += step;
                e.Graphics.DrawString("Discount: " + sale.Discount.ToString("N2"), font, Brushes.Black, x, y); y += step;
                e.Graphics.DrawString("TOTAL:    " + sale.Total.ToString("N2"), bold, Brushes.Black, x, y); y += step + 6;
                e.Graphics.DrawString("Received: " + sale.Received.ToString("N2") + "   Change: " + sale.Change.ToString("N2"),
                    font, Brushes.Black, x, y); y += step;
                e.Graphics.DrawString("Thank you for shopping!", font, Brushes.Black, x, y);
                e.HasMorePages = false;
                printIndex = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close the receipt?", "Confirm Close",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }
    }
}
