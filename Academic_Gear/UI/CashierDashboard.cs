using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class CashierDashboard : Form
    {
        private bool loggingOut;

        public CashierDashboard()
        {
            InitializeComponent();
            FormClosed += CashierDashboard_FormClosed;
            btnProduct.Click += (s, e) => OpenChild(new StockAvailability());
            btnReceipt.Click += (s, e) => OpenChild(new SearchReceipt());
            btnSalesHistory.Click += (s, e) => OpenChild(new SalesHistory());
            btnManageAccount.Click += (s, e) => OpenChild(new ManageAccountCashier());
            btnHome.Click += (s, e) => { Show(); lblHome.Focus(); };
            Shown += (s, e) =>
            {
                lblCashierAcc.Text = Session.Username ?? "Cashier";
                lblWelcomeCashier.Text = "Welcome, " + (Session.Username ?? "Cashier");
            };
        }

        private void OpenChild(Form child)
        {
            child.FormClosed += (s, e) => { if (!IsDisposed) Show(); };
            child.Show();
            Hide();
        }

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

        private void btnPOS_Click(object sender, EventArgs e) { OpenChild(new PointOfSale()); }

        private void CashierDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loggingOut) Application.Exit();
        }
    }
}
