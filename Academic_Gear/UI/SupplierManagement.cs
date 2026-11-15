using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public sealed class SupplierManagement : Form
    {
        private readonly SupplierRepo suppliers = new SupplierRepo();
        private readonly DataGridView grid = new DataGridView();
        private readonly TextBox name = new TextBox();
        private readonly TextBox contact = new TextBox();
        private readonly TextBox phone = new TextBox();
        private int selectedId;

        public SupplierManagement()
        {
            Text = "Supplier Management";
            Size = new Size(930, 615);
            StartPosition = FormStartPosition.CenterScreen;
            var inputs = new Panel { Dock = DockStyle.Top, Height = 112, Padding = new Padding(10) };
            var labels = new[] { "Supplier Name", "Contact Person", "Contact Number" };
            var fields = new[] { name, contact, phone };
            for (int i = 0; i < fields.Length; i++)
            {
                int x = 15 + i * 290;
                inputs.Controls.Add(new Label { Text = labels[i], Location = new Point(x, 8), Width = 210 });
                fields[i].Location = new Point(x, 30);
                fields[i].Width = 270;
                inputs.Controls.Add(fields[i]);
            }
            var save = new Button { Text = "Save / Update", Location = new Point(15, 68), Width = 130 };
            var clear = new Button { Text = "New Supplier", Location = new Point(155, 68), Width = 120 };
            var delete = new Button { Text = "Delete Selected", Location = new Point(285, 68), Width = 130 };
            var refresh = new Button { Text = "Refresh", Location = new Point(425, 68), Width = 100 };
            var back = new Button { Text = "Back", Location = new Point(535, 68), Width = 100 };
            inputs.Controls.AddRange(new Control[] { save, clear, delete, refresh, back });
            save.Click += Save;
            clear.Click += (s, e) => Reset();
            delete.Click += Delete;
            refresh.Click += (s, e) => Reload();
            back.Click += (s, e) => Close();
            grid.Dock = DockStyle.Fill;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionChanged += (s, e) => SelectRow();
            Controls.Add(grid);
            Controls.Add(inputs);
            Shown += (s, e) => Reload();
        }

        private void Reload()
        {
            try { grid.DataSource = suppliers.GetSuppliers(); Reset(); }
            catch (Exception ex) { Error(ex); }
        }

        private void SelectRow()
        {
            DataRowView row = grid.CurrentRow?.DataBoundItem as DataRowView;
            if (row == null) return;
            selectedId = Convert.ToInt32(row["Id"]);
            name.Text = Convert.ToString(row["SupplierName"]);
            contact.Text = Convert.ToString(row["ContactPerson"]);
            phone.Text = Convert.ToString(row["ContactNumber"]);
        }

        private void Reset()
        {
            grid.ClearSelection();
            grid.CurrentCell = null;
            selectedId = 0;
            name.Clear();
            contact.Clear();
            phone.Clear();
        }

        private void Save(object sender, EventArgs e)
        {
            try { suppliers.Save(selectedId, name.Text, contact.Text, phone.Text); Reload(); }
            catch (Exception ex) { Error(ex); }
        }

        private void Delete(object sender, EventArgs e)
        {
            if (selectedId <= 0) { MessageBox.Show("Select a supplier."); return; }
            if (MessageBox.Show("Delete selected supplier?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try { suppliers.Delete(selectedId); Reload(); }
            catch (Exception ex) { Error(ex); }
        }

        private static void Error(Exception ex)
        {
            MessageBox.Show(ex.Message, "Supplier Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
