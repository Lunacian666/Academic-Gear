using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PointOfSale : Form
    {
        public PointOfSale()
        {
            InitializeComponent();

        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel the sale?",
                "Cancel Sale",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            Receipt receiptForm = new Receipt();

            receiptForm.ShowDialog();
        }

        private void TransferSalesToHistory() { 
        
            foreach(DataGridViewRow row in dgvSalesItem.Rows)
            {
                if (row.IsNewRow)
                    continue;

                SalesItem sale = new SalesItem
                {
                    ProductName = Convert.ToString(row.Cells[0].Value),
                    Quantity = Convert.ToInt32(row.Cells[1].Value),
                    Price = Convert.ToDecimal(row.Cells[2].Value),
                    Total = Convert.ToDecimal(row.Cells[3].Value),
                    Date = DateTime.Now,
                    PaymentMethod = GetSelectedPaymentMethod()
                };
                SalesData.SalesHistory.Add(sale);
            }
        }
        //getting the selected payment method
        private string GetSelectedPaymentMethod()
        {
            if (rbCash.Checked) return "Cash";
            if (rbCard.Checked) return "Card";
            if (rbGCash.Checked) return "GCash";
            return "Not Specified";
        }

        //Process Payment Button
        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            if (dgvSalesItem.Rows.Count <= 1 ||
                (dgvSalesItem.Rows.Count ==1 &&
                dgvSalesItem.Rows[0].IsNewRow))
            {
                MessageBox.Show("Please add products first.");
                    return;
            }

            //pag transfer ng products sa shared sales history
            TransferSalesToHistory();
            MessageBox.Show(
                "Paymnet processed asuccesfully! \nSales transferred to Admin Sales History.",
                "Payment Successful",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //PAG CLEAR NG POS AFTER NG SUCCESSFUL NA TRANSACTION
            dgvSalesItem.Rows.Clear();
        }
    }
}
