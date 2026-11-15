using System;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class ManageAccountCashier : Form
    {
        private readonly UserRepo users = new UserRepo();
        private UserProfile profile;

        public ManageAccountCashier()
        {
            InitializeComponent();
            btnBack.Click += (s, e) => Close();
            btnEditProfile.Click += EditProfile;
            Shown += (s, e) => LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                profile = users.GetProfile(Session.Username);
                if (profile == null) { MessageBox.Show("Current account not found."); Close(); return; }
                lblCashierName.Text = string.IsNullOrWhiteSpace(profile.FullName) ? profile.Username : profile.FullName;
                lblCashier.Text = profile.Role;
                lblInputUsername.Text = profile.Username;
                lblInputEmployeeID.Text = string.IsNullOrWhiteSpace(profile.EmployeeId) ? "Not set" : profile.EmployeeId;
                lblInputEmail.Text = string.IsNullOrWhiteSpace(profile.Email) ? "Not set" : profile.Email;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Account Error"); }
        }

        private void EditProfile(object sender, EventArgs e)
        {
            if (profile == null) return;
            using (var form = new ProfileEditor(profile))
                if (form.ShowDialog(this) == DialogResult.OK) LoadProfile();
        }
    }
}
