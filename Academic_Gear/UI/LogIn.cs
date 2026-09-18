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
        public LogInAdmin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
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

                // Proceed to main application window
                // MainDashboard dashboard = new MainDashboard();
                // dashboard.Show();
                // this.Hide();
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
    }
    
}
