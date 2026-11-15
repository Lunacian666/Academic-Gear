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
            Shown += Receipt_Shown;
            document.PrintPage += Document_PrintPage;

            document.DefaultPageSettings.PaperSize =
                new PaperSize("80mm Receipt", 315, 550);

            document.DefaultPageSettings.Margins =
                new Margins(12, 30, 30, 12);

            document.OriginAtMargins = true;
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

            using (Font titleFont = new Font("Arial", 14, FontStyle.Bold))
            using (Font normalFont = new Font("Arial", 10))
            using (Font boldFont = new Font("Arial", 10, FontStyle.Bold))
            {
                Graphics g = e.Graphics;

                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                float width = e.MarginBounds.Width;
                float right = x + width;

                float lineHeight = 22f;

                StringFormat center = new StringFormat
                {
                    Alignment = StringAlignment.Center
                };

                StringFormat rightAlign = new StringFormat
                {
                    Alignment = StringAlignment.Far
                };

                // Store name
                g.DrawString("ACADEMIC GEAR", titleFont, Brushes.Black,
                    new RectangleF(x, y, width, 28), center);
                y += 30;

                g.DrawString("SALES RECEIPT", normalFont, Brushes.Black,
                    new RectangleF(x, y, width, 22), center);
                y += 32;

                // Receipt information
                g.DrawString("Receipt #: " + sale.Id, normalFont,
                    Brushes.Black, x, y);
                y += lineHeight;

                g.DrawString("Date: " + sale.Date.ToString("yyyy-MM-dd HH:mm"),
                    normalFont, Brushes.Black, x, y);
                y += lineHeight;

                g.DrawString("Cashier: " + sale.Cashier,
                    normalFont, Brushes.Black, x, y);
                y += lineHeight;

                g.DrawString("Payment: " + sale.PaymentMethod,
                    normalFont, Brushes.Black, x, y);
                y += 30;

                // Separator
                g.DrawLine(Pens.Black, x, y, right, y);
                y += 12;

                // Products
                foreach (SaleLine line in sale.Items)
                {
                    g.DrawString(line.ProductName, boldFont,
                        Brushes.Black, new RectangleF(x, y, width, 40));
                    y += lineHeight;

                    string details = line.Quantity + " x " +
                        line.UnitPrice.ToString("N2");

                    g.DrawString(details, normalFont,
                        Brushes.Black, x + 5, y);

                    g.DrawString(line.LineTotal.ToString("N2"),
                        normalFont, Brushes.Black,
                        new RectangleF(x, y, width, lineHeight),
                        rightAlign);

                    y += 32;
                }

                // Separator
                g.DrawLine(Pens.Black, x, y, right, y);
                y += 15;

                // Subtotal
                g.DrawString("Subtotal:", normalFont, Brushes.Black, x, y);
                g.DrawString(sale.Subtotal.ToString("N2"),
                    normalFont, Brushes.Black,
                    new RectangleF(x, y, width, lineHeight), rightAlign);
                y += lineHeight;

                // Discount
                g.DrawString("Discount:", normalFont, Brushes.Black, x, y);
                g.DrawString(sale.Discount.ToString("N2"),
                    normalFont, Brushes.Black,
                    new RectangleF(x, y, width, lineHeight), rightAlign);
                y += 28;

                // Total
                g.DrawLine(Pens.Black, x, y, right, y);
                y += 12;

                g.DrawString("TOTAL:", boldFont, Brushes.Black, x, y);
                g.DrawString(sale.Total.ToString("N2"),
                    boldFont, Brushes.Black,
                    new RectangleF(x, y, width, lineHeight), rightAlign);
                y += 32;

                // Received
                g.DrawString("Received:", normalFont, Brushes.Black, x, y);
                g.DrawString(sale.Received.ToString("N2"),
                    normalFont, Brushes.Black,
                    new RectangleF(x, y, width, lineHeight), rightAlign);
                y += lineHeight;

                // Change
                g.DrawString("Change:", normalFont, Brushes.Black, x, y);
                g.DrawString(sale.Change.ToString("N2"),
                    normalFont, Brushes.Black,
                    new RectangleF(x, y, width, lineHeight), rightAlign);
                y += 32;

                g.DrawLine(Pens.Black, x, y, right, y);
                y += 25;

                // Footer
                g.DrawString("Thank you for shopping!",
                    normalFont, Brushes.Black,
                    new RectangleF(x, y, width, 30), center);

                e.HasMorePages = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close the receipt?", "Confirm Close",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }
    }
}
