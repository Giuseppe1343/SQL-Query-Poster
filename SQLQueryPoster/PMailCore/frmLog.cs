using PMailCore.Managers;
using PMailCore.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using lg = PMailCore.LogIslem;

namespace PMailCore
{
    public partial class FrmLog : DevExpress.XtraEditors.XtraForm
    {

        DateTime lastReadTime = File.GetLastWriteTime(LogIslem.LogDosyaYolu(lg.MAIL));
        public FrmLog()
        {
            InitializeComponent();
            notifyIcon1.MouseClick += NotifyIcon1_MouseClick;
            barBtnShowLog.ItemClick += BarBtnShowLog_ItemClick;
            barBtnHideLog.ItemClick += BarBtnHideLog_ItemClick;
            barBtnStartApp.ItemClick += BarBtnStartApp_ItemClick;
            this.FormClosing += FrmLog_Hide;
            this.VisibleChanged += frmLog_VisibleChanged;
            //this.MinimizeBox = false;
            //DateTime next = new ManagerPlan().GecerliTarihSaat().AddHours(1);
            //timer1.Interval = (int)(next - DateTime.Now).TotalMilliseconds;
            timer1.Interval = (1000 * 60 * 1); // 1 min
            timer1.Tick += Timer_Tick;
            timer1.Start();

            if (File.Exists(lg.LogDosyaYolu(lg.MAIL)))
            {
                lblLog.Text = "";
                lastReadTime = File.GetLastWriteTime(lg.LogDosyaYolu(lg.MAIL));
                string[] lines = File.ReadAllLines(lg.LogDosyaYolu(lg.MAIL));
                foreach (string line in lines)
                {
                    if (line.Contains("Uyarı("))
                    {
                        lblLog.Text += "<color=#0000FF>" + line + "</color><br>";
                    }
                    else if (line.Contains("Hata("))
                    {
                        lblLog.Text += "<color=#FF0000>" + line + "</color><br>";
                    }
                    else
                    {
                        lblLog.Text += line + "<br>";
                    }
                }
                xtraScrollableControl1.VerticalScroll.Value = xtraScrollableControl1.VerticalScroll.Maximum;
            }
        }


        class PlanResultCollection
        {
            private List<PlanResult> _planResults = new List<PlanResult>();
            public bool IsNotEmpty { get => PlanResults.Any(); }
            public IEnumerable<PlanResult> PlanResults
            {
                get
                {
                    foreach (var planResult in _planResults)
                        if (!planResult.Processed) yield return planResult;
                }
            }

            public void Fill(List<Plan> plans)
            {
                if (plans is null) return;
                foreach (Plan plan in plans)
                {
                    _planResults.Add(new PlanResult { Plan = plan });
                }
            }

        }
        class PlanResult
        {
            public Plan Plan { get; set; }
            public List<string> Logs { get; set; } = new List<string>();
            public bool Result { get; set; } = false;
            public bool Processed { get; set; } = false;
        }

        private void CreateMailSenderTasks()
        {
            int tryCount = 0;
            bool isFail = false;
            ManagerPlan manager = new ManagerPlan();
            var planlar = new PlanResultCollection();
            do
            {
                planlar.Fill(manager.GetList());
                isFail = !manager.IsSuccess;
            } while (tryCount++ < 3 && isFail);

            if (isFail)
            {
                File.AppendAllText(lg.LogDosyaYolu(lg.MAIL), "Hata(ManagerPlan): Planlar Alınırken Bir Sorun Oluştu (3 Deneme Yapıldı).".ToLogString());
            }
            else if (planlar.IsNotEmpty)
            {
                List<Task> tasks = new List<Task>();

                foreach (var planResult in planlar.PlanResults)
                {
                    var plan = planResult.Plan;
                    if ((plan.bas_saat <= (byte)DateTime.Now.Hour && plan.bit_saat >= (byte)DateTime.Now.Hour) && (plan.son_tarih == GecerliTarihSaatDakika()))
                    {
                        var receivers = manager.GetMailAdresList(plan.bag_mail);

                        string queryBody = plan.sorgu_icerik;
                        DataTable dt = ConvertCSVtoDataTable(plan.sorgu_parametre);
                        foreach (DataRow row in dt.Rows)
                        {
                            string strOld = row[0].ToString();
                            string strNew = row[1].ToString();
                            queryBody = queryBody.Replace(strOld, strNew);
                        }

                        var sqlResult = manager.GetQueryResult(queryBody);
                        if (manager.IsSuccess)
                        {
                            (bool boolVal, string stringVal) statePath = new ExcelGenerator().MainGenerate(sqlResult, plan.mail_html, plan.tablo_tipi, plan.plan_adi);
                            if (statePath.boolVal)
                            {
                                try
                                {
                                    tasks.Add(Task.Run(() =>
                                    {
                                        var mailResult = MailSender(statePath.stringVal, receivers, plan.mail_html, plan.sorgu_adi, plan.plan_adi);
                                        planResult.Result = !mailResult.Contains("Hata(");
                                        planResult.Logs.Add(mailResult);
                                    }));
                                }
                                catch (Exception ex)
                                {
                                    planResult.Logs.Add(("Hata(Task): " + ex).ToLogString());
                                }
                            }
                            else
                            {
                                planResult.Logs.Add(statePath.stringVal);
                            }
                        }
                        else
                        {
                            planResult.Logs.Add(("Hata(Query): " + manager.Message).ToLogString());
                        }
                        plan.ilk_tarih = plan.son_tarih;
                    }
                    else planResult.Result = true;
                }
                Task.WaitAll(tasks.ToArray());
                foreach (var planResult in planlar.PlanResults)
                {
                    if (planResult.Result)
                    {
                        planResult.Processed = true;
                        var plan = planResult.Plan;

                        while (plan.son_tarih <= GecerliTarihSaatDakika())
                            plan.son_tarih = plan.son_tarih.AddMinutes(plan.dakika).AddHours(plan.saat).AddDays(plan.gun).AddDays(plan.hafta * 7).AddMonths(plan.ay);
                        manager.Update(plan);

                        foreach (string log in planResult.Logs) File.AppendAllText(lg.LogDosyaYolu(lg.MAIL), log);
                    }
                }
                tryCount = 0;
                while (planlar.IsNotEmpty && tryCount++ < 3)
                {
                    tasks.Clear();

                    foreach (var planResult in planlar.PlanResults)
                    {
                        var plan = planResult.Plan;

                        var receivers = manager.GetMailAdresList(plan.bag_mail);

                        string queryBody = plan.sorgu_icerik;
                        DataTable dt = ConvertCSVtoDataTable(plan.sorgu_parametre);
                        foreach (DataRow row in dt.Rows)
                        {
                            string strOld = row[0].ToString();
                            string strNew = row[1].ToString();
                            queryBody = queryBody.Replace(strOld, strNew);
                        }

                        var sqlResult = manager.GetQueryResult(queryBody);
                        if (manager.IsSuccess)
                        {
                            (bool boolVal, string stringVal) statePath = new ExcelGenerator().MainGenerate(sqlResult, plan.mail_html, plan.tablo_tipi, plan.plan_adi);
                            if (statePath.boolVal)
                            {
                                try
                                {
                                    tasks.Add(Task.Run(() =>
                                    {
                                        var mailResult = MailSender(statePath.stringVal, receivers, plan.mail_html, plan.sorgu_adi, plan.plan_adi);
                                        planResult.Result = !mailResult.Contains("Hata(");
                                        planResult.Logs.Add(mailResult.Replace(Environment.NewLine, $"({tryCount}. Yeniden Deneme) {Environment.NewLine}"));
                                    }));
                                }
                                catch (Exception ex)
                                {
                                    planResult.Logs.Add(("Hata(Task): " + ex.ToString() + "(" + tryCount + ". Yeniden Deneme)").ToLogString());
                                }
                            }
                            else
                            {
                                planResult.Logs.Add(statePath.stringVal.Replace(Environment.NewLine, $"({tryCount}. Yeniden Deneme) {Environment.NewLine}"));
                            }
                        }
                        else
                        {
                            planResult.Logs.Add(("Hata(Query): " + manager.Message + "(" + tryCount + ". Yeniden Deneme)").ToLogString());
                        }
                    }
                    Task.WaitAll(tasks.ToArray());
                    foreach (var planResult in planlar.PlanResults)
                    {
                        if (planResult.Result)
                        {
                            planResult.Processed = true;
                            var plan = planResult.Plan;

                            while (plan.son_tarih <= GecerliTarihSaatDakika())
                                plan.son_tarih = plan.son_tarih.AddMinutes(plan.dakika).AddHours(plan.saat).AddDays(plan.gun).AddDays(plan.hafta * 7).AddMonths(plan.ay);
                            manager.Update(plan);

                            foreach (string log in planResult.Logs) File.AppendAllText(lg.LogDosyaYolu(lg.MAIL), log);
                        }
                    }
                }
                foreach (var planResult in planlar.PlanResults)
                {
                    planResult.Processed = true;
                    var plan = planResult.Plan;

                    while (plan.son_tarih <= GecerliTarihSaatDakika())
                        plan.son_tarih = plan.son_tarih.AddMinutes(plan.dakika).AddHours(plan.saat).AddDays(plan.gun).AddDays(plan.hafta * 7).AddMonths(plan.ay);
                    manager.Update(plan);

                    foreach (string log in planResult.Logs) File.AppendAllText(lg.LogDosyaYolu(lg.MAIL), log);
                    File.AppendAllText(lg.LogDosyaYolu(lg.MAIL), ("Plan Adı: " + plan.plan_adi + " Uyarı(Sonuç) Gönderim Başarısız.").ToLogString());
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //timer1.Interval = (1000 * 60 * 60);
            timer1.Stop();
            CreateMailSenderTasks();

            if (lastReadTime < File.GetLastWriteTime(lg.LogDosyaYolu(lg.MAIL)) && this.Visible)
            {
                lblLog.Text = "";
                lastReadTime = File.GetLastWriteTime(lg.LogDosyaYolu(lg.MAIL));
                string[] lines = File.ReadAllLines(lg.LogDosyaYolu(lg.MAIL));
                foreach (string line in lines)
                {
                    if (line.Contains("Uyarı("))
                    {
                        lblLog.Text += "<color=#0000FF>" + line + "</color><br>";
                    }
                    else if (line.Contains("Hata("))
                    {
                        lblLog.Text += "<color=#FF0000>" + line + "</color><br>";
                    }
                    else
                    {
                        lblLog.Text += line + "<br>";
                    }
                }
                xtraScrollableControl1.VerticalScroll.Value = xtraScrollableControl1.VerticalScroll.Maximum;
                //memoEdit1.Text = File.ReadAllText(lg.LogDosyaYolu(lg.MAIL));
            }
            timer1.Start();
        }

        public DataTable ConvertCSVtoDataTable(string strCSV)
        {
            if (string.IsNullOrEmpty(strCSV)) strCSV = "Param;Value";
            string[] Lines = strCSV.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            string[] Fields;
            Fields = Lines[0].Split(new char[] { ';' });
            int Cols = Fields.GetLength(0);
            DataTable dt = new DataTable();
            //1st row must be column names; force lower case to ensure matching later on.
            for (int i = 0; i < Cols; i++)
                dt.Columns.Add(Fields[i].ToLower(), typeof(string));
            DataRow Row;
            for (int i = 1; i < Lines.GetLength(0); i++)
            {
                Fields = Lines[i].Split(new char[] { ';' });
                bool noEmpty = true;
                foreach (string field in Fields)
                {
                    if (string.IsNullOrEmpty(field)) noEmpty = false;
                }
                if (noEmpty && Fields.Length > 0)
                {
                    Row = dt.NewRow();
                    for (int f = 0; f < Cols; f++)
                        Row[f] = Fields[f];
                    dt.Rows.Add(Row);
                }
            }
            return dt;
        }

        private string MailSender(string excelFilePath, IEnumerable<string> receivers, bool isBodyHTML, string sorgu_adi, string plan_adi)
        {
            try
            {
                string sender = ConfigurationManager.AppSettings.Get("kullanici");
                string password = ConfigurationManager.AppSettings.Get("sifre");

                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress(sender);
                foreach (string receiver in receivers) ePosta.To.Add(receiver);
                ePosta.Subject = /*sorgu_adi + ", Gönderici Plan Adı: " + */plan_adi;
                if (!isBodyHTML)
                {
                    ePosta.Body = "";
                    ePosta.Attachments.Add(new Attachment(excelFilePath));
                    ePosta.IsBodyHtml = false;
                }
                else
                {
                    ePosta.Body = File.ReadAllText(excelFilePath);
                    ePosta.IsBodyHtml = true;
                    File.Delete(excelFilePath);
                }
                SmtpClient smtp = new SmtpClient
                {
                    Credentials = new System.Net.NetworkCredential(sender, password),
                    Port = 587,
                    Host = "smtp.gmail.com",
                    EnableSsl = true
                };
                smtp.Send(ePosta);
                return ("Plan Adı: " + plan_adi + " Başarılı.").ToLogString();
            }
            catch (Exception ex)
            {
                return ("Plan Adı: " + plan_adi + " Hata(MailGönder): " + ex).ToLogString();
            }
        }
        public DateTime GecerliTarihSaatDakika()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0, DateTime.Now.Kind);
        }
        private void frmLog_VisibleChanged(object sender, EventArgs e)
        {
            if (lastReadTime < File.GetLastWriteTime(lg.LogDosyaYolu(lg.MAIL)) && this.Visible)
            {
                lblLog.Text = "";
                lastReadTime = File.GetLastWriteTime(lg.LogDosyaYolu(lg.MAIL));
                string[] lines = File.ReadAllLines(lg.LogDosyaYolu(lg.MAIL));
                foreach (string line in lines)
                {
                    if (line.Contains("Uyarı("))
                    {
                        lblLog.Text += "<color=#0000FF>" + line + "</color><br>";
                    }
                    else if (line.Contains("Hata("))
                    {
                        lblLog.Text += "<color=#FF0000>" + line + "</color><br>";
                    }
                    else
                    {
                        lblLog.Text += line + "<br>";
                    }
                }
                xtraScrollableControl1.VerticalScroll.Value = xtraScrollableControl1.VerticalScroll.Maximum;
            }
        }
        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right && IsHandleCreated)
            popupMenu1.ShowPopup(MousePosition);
        }
        private void FrmLog_Hide(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        private void BarBtnShowLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Show();
            this.Focus();
        }
        private void BarBtnHideLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }
        [DllImport("User32.dll")]
        private static extern Int32 SetForegroundWindow(IntPtr hWnd);
        private void BarBtnStartApp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("PMailUI");
            if (processes.Length == 0)
            {
                //ProcessStartInfo start = new ProcessStartInfo();
                //start.FileName = @"C:\Users\Yusuf\source\repos\BeyazelProje\DXMail\bin\Debug\DXMail.exe";
                try
                {
                    string parentPath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
                    Process.Start(parentPath + "\\PMailUI\\PMailUI.exe");
                }
                catch (Exception ex)
                {
                    File.AppendAllText(lg.LogDosyaYolu(lg.PROGRAM), ex.ToLogString());
                }

            }
            else
            {
                SetForegroundWindow(processes[0].MainWindowHandle);
            }
        }
    }
}