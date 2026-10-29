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
    public partial class CashierDashboard : Form
    {
        public CashierDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to logout?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LogInAdmin loginForm = new LogInAdmin();
                loginForm.Show();

                this.Hide();
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            PointOfSale posForm = new PointOfSale();

            posForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            posForm.Show();
            this.Hide();
        }
    }
}
