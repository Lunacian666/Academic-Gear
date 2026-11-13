using System;
using System.Windows.Forms;

namespace UI
{
    public partial class SalesHistory : Form
    {
        public SalesHistory()
        {
            InitializeComponent();

            dgSalesHistory.Columns.Clear();
            dgSalesHistory.AutoGenerateColumns = true;
            dgSalesHistory.DataSource = SalesData.SalesHistory;

            dgSalesHistory.ReadOnly = true;
            dgSalesHistory.AllowUserToAddRows = false;
            dgSalesHistory.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }
    }
}