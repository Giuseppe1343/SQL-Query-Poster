using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using lg = PMailCore.LogIslem;


namespace PMailCore
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(lg.LogKlasorYolu))
            {
                Directory.CreateDirectory(lg.LogKlasorYolu);
            }

            if (Process.GetProcessesByName("PMailCore").Length > 1)
            {
                File.AppendAllText(lg.LogDosyaYolu(lg.PROGRAM), "Programın 2. örneği çalıştırılamaz.".ToLogString());
                Application.Exit();
                return;
            }

            if (!Directory.Exists(lg.ExcelKlasorYolu))
            {
                Directory.CreateDirectory(lg.ExcelKlasorYolu);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLog());
        }
    }
}
