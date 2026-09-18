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

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            {
                // Check using the actual control name (e.g., textBox1 or txtSearch)
                TextBox txt = sender as TextBox;
                if (txt != null && txt.Text == "Search anything...")
                {
                    txt.Text = "";
                    txt.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

            private void txtSearch_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = "Search anything...";
                txt.ForeColor = System.Drawing.Color.Gray;
            }
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


    }
    
}
