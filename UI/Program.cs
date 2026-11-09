
using System;
using System.Windows.Forms;
using BusinessLogic.Database;

namespace UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                LocalDatabase.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Local database setup failed.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            Application.Run(new LogInAdmin());
        }
    }
}
