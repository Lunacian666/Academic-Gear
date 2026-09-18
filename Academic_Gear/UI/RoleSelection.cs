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
    public partial class RoleSelection : Form
    {
        private string selectedRole = "";
        public RoleSelection()
        {

            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a role first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Instantiate the Login form
            LogInAdmin loginForm = new LogInAdmin(selectedRole);

            // 2. Hide the current RoleSelection form
            this.Hide();

            // 3. Show the login form normally (do NOT use ShowDialog here)
            loginForm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin";

            // Visual feedback: Highlight Admin button
            btnAdmin.BackColor = Color.LightBlue;
            btnCashier.BackColor = Color.LightGray;
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            selectedRole = "Cashier";

            // Visual feedback: Highlight Cashier button
            btnCashier.BackColor = Color.LightBlue;
            btnAdmin.BackColor = Color.LightGray;
        }


    }
}
