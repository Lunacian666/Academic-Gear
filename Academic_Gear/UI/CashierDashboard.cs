
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class CashierDashboard : Form
    {
        private bool isLoggingOut = false;

        public CashierDashboard()
        {
            InitializeComponent();

            this.FormClosed += CashierDashboard_FormClosed;
        }

        private void btnLogout_Click(
            object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogInAdmin login =
                    Application.OpenForms
                    .OfType<LogInAdmin>()
                    .FirstOrDefault();

                if (login != null)
                {
                    isLoggingOut = true;
                    login.Show();
                    this.Close();
                }
            }
        }

        private void btnPOS_Click(
            object sender, EventArgs e)
        {
            PointOfSale posForm = new PointOfSale();

            posForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            posForm.Show();
            this.Hide();
        }

        private void CashierDashboard_FormClosed(
            object sender, FormClosedEventArgs e)
        {
            if (!isLoggingOut)
            {
                Application.Exit();
            }
        }
    }
}
