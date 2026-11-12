using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to close the receipt?",
            "Confirm Close",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (PrintDocument document = new PrintDocument())
            {
                document.DocumentName = "Academic Gear Receipt";


                document.DefaultPageSettings.PaperSize =
                    new PaperSize("80mm Receipt", 315, 591);


                document.DefaultPageSettings.Margins =
                    new Margins(10, 10, 10, 10);

                document.PrintPage += PrintReceipt;

                using (PrintPreviewDialog preview = new PrintPreviewDialog())
                {
                    preview.Document = document;
                    preview.WindowState = FormWindowState.Maximized;
                    preview.ShowDialog(this);
                }
            }
        }
        private void PrintReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Font titleFont = new Font("Consolas", 12, FontStyle.Bold))
            using (Font normalFont = new Font("Consolas", 9))
            using (Font boldFont = new Font("Consolas", 9, FontStyle.Bold))
            {
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                float lineHeight = 22;

                g.DrawString("ACADEMIC GEAR", titleFont,
                    Brushes.Black, x, y);
                y += 35;

                g.DrawString("SALES RECEIPT", boldFont,
                    Brushes.Black, x, y);
                y += lineHeight;

                g.DrawString("Date: " +
                    DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"),
                    normalFont, Brushes.Black, x, y);
                y += lineHeight;

                g.DrawString("Cashier: Cashier",
                    normalFont, Brushes.Black, x, y);
                y += 30;

                g.DrawString("--------------------------------",
                    normalFont, Brushes.Black, x, y);
                y += lineHeight;

                g.DrawString("PRODUCT          QTY     PRICE",
                    boldFont, Brushes.Black, x, y);
                y += lineHeight;

                g.DrawString("--------------------------------",
                    normalFont, Brushes.Black, x, y);
                y += lineHeight;



                y += 20;

                g.DrawString("--------------------------------",
                    normalFont, Brushes.Black, x, y);
                y += lineHeight;

                g.DrawString("TOTAL: 0.00",
                    boldFont, Brushes.Black, x, y);
                y += lineHeight;

                g.DrawString("CASH: 0.00",
                    normalFont, Brushes.Black, x, y);
                y += lineHeight;

                g.DrawString("CHANGE: 0.00",
                    normalFont, Brushes.Black, x, y);
                y += 35;

                g.DrawString("Thank you for your purchase!",
                    normalFont, Brushes.Black, x, y);
            }

            e.HasMorePages = false;
        }
    }
}
