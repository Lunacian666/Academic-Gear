
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

            this.FormClosed -= LogIn_FormClosed;
            this.FormClosed += LogIn_FormClosed;
        }

        public LogInAdmin(string role) : this()
        {
            currentRole = role;
        }

        private void btnLogIn_Click(
            object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your username and password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                UserRepo userRepo = new UserRepo();

                string role = userRepo.Login(
                    username, password);

                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                role = role.Trim();

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
                        "Unknown account role.",
                        "Login Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                MessageBox.Show(
                    "Login successful! Welcome " + username + ".",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Session.Username = username;
                Session.Role = role;
                txtPassword.Clear();

                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to connect to the local database.\n\n"
                    + ex.Message,
                    "Database Error",
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
