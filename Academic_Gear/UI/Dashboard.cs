
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class Dashboard : Form
    {
        private bool isLoggingOut = false;

        public Dashboard()
        {
            InitializeComponent();

            this.FormClosed -= Dashboard_FormClosed;
            this.FormClosed += Dashboard_FormClosed;
        }

        private void Dashboard_FormClosed(
            object sender, FormClosedEventArgs e)
        {
            if (!isLoggingOut)
            {
                Application.Exit();
            }
        }

        private void Dashboard_Shown(
            object sender, EventArgs e)
        {
            lblHome.Focus();
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

        private void OpenInventory()
        {
            InventoryManagement inventoryForm =
                new InventoryManagement();

            inventoryForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            inventoryForm.Show();
            this.Hide();
        }

        private void btnProductManagement_Click(
            object sender, EventArgs e)
        {
            OpenInventory();
        }

        private void lblInventory_Click(
            object sender, EventArgs e)
        {
            OpenInventory();
        }
    }
}
