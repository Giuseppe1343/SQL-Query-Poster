using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PMailUI
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
            //Control.CheckForIllegalCrossThreadCalls = false;
            if (Process.GetProcessesByName("PMailUI").Length > 1)
            {
                MessageBox.Show("Petek Mail Programı Zaten Çalışıyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
                return;
            }

            if (Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("PMail").CreateSubKey("FilePath").ValueCount == 0)
            {
                Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("PMail").CreateSubKey("FilePath").SetValue("Path", "");
                Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("PMail").CreateSubKey("CurrUser").SetValue("User", "");
            }
            Application.Run(new FrmGiris());
        }
    }
}
