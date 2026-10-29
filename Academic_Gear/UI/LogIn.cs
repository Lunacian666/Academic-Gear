
using System;
using System.Windows.Forms;
using BusinessLogic.Repository;

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
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Please fill in both Username and Password fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserRepo userRepository = new UserRepo();

                // Authenticate using Azure SQL database
                string role = userRepository.Login(username, password);

                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show(
                        "Invalid Username or Password. Please try again.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                role = role.Trim();

                // Verify selected role
                if (!string.IsNullOrEmpty(currentRole) &&
                    !role.Equals(currentRole,
                        StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "This account does not match the selected role.",
                        "Wrong Role",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Form dashboard;

                // Redirect based on database role
                if (role.Equals("Admin",
                    StringComparison.OrdinalIgnoreCase))
                {
                    dashboard = new Dashboard();
                }
                else if (role.Equals("Cashier",
                    StringComparison.OrdinalIgnoreCase))
                {
                    dashboard = new CashierDashboard();
                }
                else
                {
                    MessageBox.Show(
                        "Unknown account role: " + role,
                        "Login Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(
                    $"Login successful! Welcome {username}.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to complete login.\n\n" + ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LogIn_FormClosed(
            object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
