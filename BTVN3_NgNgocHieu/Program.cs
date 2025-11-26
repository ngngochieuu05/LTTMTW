using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN3_NgNgocHieu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += (s, e) =>
            {
                try { MessageBox.Show(e.Exception.ToString(), "Unhandled UI Thread Exception", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch { }
            };

            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                try { MessageBox.Show(e.ExceptionObject?.ToString() ?? "Unknown exception", "Unhandled Domain Exception", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch { }
            };

            try
            {
                Application.Run(new frmQuanLiSinhVien());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Startup Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
