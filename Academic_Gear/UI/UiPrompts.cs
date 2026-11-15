using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    internal static class UiPrompts
    {
        public static int? AskQuantity(string product, int current, int max)
        {
            if (max < 1) return null;
            NumericUpDown value;
            using (var window = MakeDialog("Update Quantity", "Quantity for " + product, out value))
            {
                value.Minimum = 1;
                value.Maximum = max;
                value.Value = Math.Min(Math.Max(1, current), max);
                return window.ShowDialog() == DialogResult.OK ? (int?)value.Value : null;
            }
        }

        public static decimal? AskPayment(decimal total)
        {
            NumericUpDown value;
            using (var window = MakeDialog("Cash Payment", "Enter amount received (total: " + total.ToString("N2") + ")", out value))
            {
                value.DecimalPlaces = 2;
                value.Increment = 1m;
                value.Minimum = total;
                value.Maximum = 9999999999999999m;
                value.Value = total;
                return window.ShowDialog() == DialogResult.OK ? (decimal?)value.Value : null;
            }
        }

        private static Form MakeDialog(string title, string caption, out NumericUpDown value)
        {
            var form = new Form
            {
                Text = title,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = new Size(390, 135)
            };
            var label = new Label { Text = caption, Location = new Point(15, 12), AutoSize = false, Size = new Size(365, 30) };
            value = new NumericUpDown { Location = new Point(15, 45), Width = 355, DecimalPlaces = 0, ThousandsSeparator = true };
            var ok = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new Point(202, 88), Width = 80 };
            var cancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Location = new Point(290, 88), Width = 80 };
            form.Controls.AddRange(new Control[] { label, value, ok, cancel });
            form.AcceptButton = ok;
            form.CancelButton = cancel;
            return form;
        }
    }
}
