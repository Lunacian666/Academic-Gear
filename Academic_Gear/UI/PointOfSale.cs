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
    }
}
