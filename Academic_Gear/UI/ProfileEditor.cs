using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public sealed class ProfileEditor : Form
    {
        private readonly UserProfile profile;
        private readonly TextBox fullName = new TextBox();
        private readonly TextBox email = new TextBox();
        private readonly TextBox employee = new TextBox();
        private readonly TextBox password = new TextBox();

        public ProfileEditor(UserProfile account)
        {
            profile = account;
            Text = "Edit Account - " + account.Username;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(435, 275);
            var labels = new[] { "Full Name", "Email", "Employee ID", "New Password (optional)" };
            var controls = new[] { fullName, email, employee, password };
            for (int i = 0; i < controls.Length; i++)
            {
                Controls.Add(new Label { Text = labels[i], Location = new Point(20, 18 + i * 49), Width = 155 });
                controls[i].Location = new Point(177, 15 + i * 49);
                controls[i].Width = 230;
                Controls.Add(controls[i]);
            }
            fullName.Text = account.FullName;
            email.Text = account.Email;
            employee.Text = account.EmployeeId;
            password.UseSystemPasswordChar = true;
            var save = new Button { Text = "Save Changes", Location = new Point(170, 225), Width = 115 };
            var cancel = new Button { Text = "Cancel", Location = new Point(296, 225), Width = 110 };
            save.Click += Save;
            cancel.Click += (s, e) => Close();
            Controls.Add(save);
            Controls.Add(cancel);
            AcceptButton = save;
        }

        private void Save(object sender, EventArgs e)
        {
            try
            {
                new UserRepo().UpdateProfile(profile.Username, fullName.Text, email.Text, employee.Text, password.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Profile Error"); }
        }
    }
}
