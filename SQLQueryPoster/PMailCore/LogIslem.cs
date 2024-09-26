using System;

namespace PMailCore
{
    public static class LogIslem
    {

        public const string MAIL = "mail";
        public const string PROGRAM = "program";

        public static string LogKlasorYolu = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Logs\\";
        public static string LogDosyaYolu(string logAdi = MAIL)
        {
            return (LogKlasorYolu + "%1_" + DateTime.Today.ToString("yyMMdd") + ".txt").Replace("%1", logAdi);
        }
        public static string ToLogString(this object obj)
        {
            return DateTime.Now.ToString() + " - " + obj.ToString() + Environment.NewLine;
        }


        public static string ExcelKlasorYolu = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Excels\\";
        public static string ExcelDosyaKlasorYolu(string excelAdi)
        {
            return (ExcelKlasorYolu + "%1").Replace("%1", excelAdi);
        }

        public static string ExcelDosyaYolu(string excelAdi)
        {
            return (ExcelDosyaKlasorYolu(excelAdi) + "\\%1_" + DateTime.Now.ToString("yyyy-MM-dd-HHmm") + ".xlsx").Replace("%1", excelAdi);
        }

    }
}
