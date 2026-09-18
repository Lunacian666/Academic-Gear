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
    public partial class LogInAdmin : Form
    {
        private string currentRole;
        public LogInAdmin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }
        public LogInAdmin(string role) : this()
        {
            currentRole = role;

            // Optional: Update title label dynamically if you have one
            // lblTitle.Text = $"Log in as {currentRole}";
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // 1. Check for empty fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both Username and Password fields.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2. Validate Credentials
            if (username == "AdminHanna" && password == "AcademicGear")
            {
                MessageBox.Show("Login successful! Welcome AdminHanna.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Open Dashboard and hide current login form
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                // 3. Show failure message box on wrong credentials
                MessageBox.Show("Invalid Username or Password. Please try again.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create and show RoleSelection
            RoleSelection roleForm = new RoleSelection();
            roleForm.Show();

            // Close current LogInAdmin form cleanly
            this.Close();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
