using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class Dashboard : Form
    {
        private bool loggingOut;

        public Dashboard()
        {
            InitializeComponent();
            FormClosed -= Dashboard_FormClosed;
            FormClosed += Dashboard_FormClosed;
            btnSupplier.Click += (s, e) => OpenChild(new SupplierManagement());
            btnStockAvailability.Click += (s, e) => OpenChild(new StockAvailability());
            btnReports.Click += (s, e) => OpenChild(new ReportsForm());
            btnManageAcc.Click += (s, e) => OpenChild(new ManageAccountCashier());
            btnHome.Click += (s, e) => { Show(); lblHome.Focus(); };
            Shown += (s, e) =>
            {
                lblAdminAcc.Text = Session.Username ?? "Admin";
                lblWelcomeAdmin.Text = "Welcome, " + (Session.Username ?? "Admin");
            };
        }

        private void OpenChild(Form child)
        {
            child.FormClosed += (s, e) => { if (!IsDisposed) Show(); };
            child.Show();
            Hide();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loggingOut) Application.Exit();
        }

        private void Dashboard_Shown(object sender, EventArgs e) { lblHome.Focus(); }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Log out?", "Confirm Logout", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes) return;
            LogInAdmin login = Application.OpenForms.OfType<LogInAdmin>().FirstOrDefault();
            if (login == null) { Application.Exit(); return; }
            loggingOut = true;
            Session.Clear();
            login.Show();
            Close();
        }

        private void btnSalesHistory_Click(object sender, EventArgs e) { OpenChild(new SalesHistory()); }
        private void btnProductManagement_Click(object sender, EventArgs e) { OpenChild(new InventoryManagement()); }
        private void lblInventory_Click(object sender, EventArgs e) { OpenChild(new InventoryManagement()); }
    }
}
