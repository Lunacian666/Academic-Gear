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

            // Check empty fields
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

                // Check username and password from Azure SQL
                string role = userRepository.Login(username, password);

                if (role == null)
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

                // Check if user selected the correct role
                if (!string.IsNullOrEmpty(currentRole) &&
                    !role.Equals(currentRole, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "This account does not match the selected role.",
                        "Wrong Role",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    $"Login successful! Welcome {username}.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Open Dashboard
                Dashboard dashboard = new Dashboard();
                dashboard.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to connect to the database.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RoleSelection roleForm = new RoleSelection();
            roleForm.Show();

            this.Hide();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}