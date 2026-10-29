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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Closes the background process completely
        }
        private void Dashboard_Shown(object sender, EventArgs e)
        {
            // Focus a label or panel instead so no text box is highlighted
            lblHome.Focus();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            // 1. Show confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // 2. If user clicks Yes, navigate directly to LogIn UI
            if (result == DialogResult.Yes)
            {
                // Open the Login form
                LogInAdmin loginForm = new LogInAdmin();
                loginForm.Show();

                // Close the current Dashboard form completely
                this.Close();
            }
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            InventoryManagement productForm = new InventoryManagement();

            productForm.Show();

            this.Hide();
        }

        private void lblInventory_Click(object sender, EventArgs e)
        {
            InventoryManagement inventoryForm = new InventoryManagement();

            inventoryForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            inventoryForm.Show();
            this.Hide();
        }
    }
    
}
