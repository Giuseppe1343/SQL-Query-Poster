using PMailUI.Managers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace PMailUI.Forms
{
    public partial class FrmMailGonder : DevExpress.XtraEditors.XtraForm
    {
        public FrmMailGonder(IEnumerable<dynamic> data, string sorgu_adi, int tablo_tipi)
        {
            InitializeComponent();
            lueMailAlici.Properties.DataSource = new ManagerMail().GetComboSource();
            lueMailAlici.Properties.ValueMember = "Key";
            lueMailAlici.Properties.DisplayMember = "Value";


            btnMail.Click += (s, e) =>
            {
                bool isBodyHTML = Convert.ToBoolean(chcHTML.EditValue);
                List<string> receivers = new ManagerMail().GetMailList(lueMailAlici.EditValue.ToString());
                string path = new ExcelGenerator().MainGenerate(data, isBodyHTML == true ? 4 : 3, tablo_tipi, sorgu_adi);
                MailSender(path, receivers, isBodyHTML, sorgu_adi);
                Close();
            };
            btnKapat.Click += (s, e) =>
            {
                Close();
            };
        }
        private void MailSender(string excelFilePath, List<string> receivers, bool isBodyHTML, string sorgu_adi)
        {
            try
            {
                string sender = ConfigurationManager.AppSettings.Get("kullanici");
                string password = ConfigurationManager.AppSettings.Get("sifre");

                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress(sender);
                foreach (string receiver in receivers) ePosta.To.Add(receiver);
                ePosta.Subject = sorgu_adi + ",  Gönderici: " + S.AktifKullanici.adi;
                ePosta.IsBodyHtml = true;
                if (!isBodyHTML)
                {
                    ePosta.Body = "";
                    ePosta.Attachments.Add(new Attachment(excelFilePath));
                    //ePosta.IsBodyHtml = false;
                }
                else
                {
                    ePosta.Body = File.ReadAllText(excelFilePath);
                }
                //AlternateView alternate = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html);
                //ePosta.AlternateViews.Add(alternate);
                SmtpClient smtp = new SmtpClient
                {
                    Credentials = new System.Net.NetworkCredential(sender, password),
                    Port = 587,
                    Host = "smtp.gmail.com",
                    EnableSsl = true
                };
                smtp.Send(ePosta);
                MessageBox.Show("Mail Gönderimi Başarılı! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                smtp.Dispose();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail Gönderimi Başarısız! " + Environment.NewLine + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}