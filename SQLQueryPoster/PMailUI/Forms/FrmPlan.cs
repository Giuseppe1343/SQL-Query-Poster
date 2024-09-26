using DevExpress.XtraGrid;
using PMailUI.Managers;
using PMailUI.Modals;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMailUI.Forms
{
    public partial class FrmPlan : DevExpress.XtraEditors.XtraForm
    {
        Plan plan = new Plan();
        public FrmPlan()
        {
            InitializeComponent();

            #region Combo Doldur
            //Min DateTime is currHours+1
            dtePlan.Properties.MinValue = GecerliTarihSaat();

            //Fill and Initialize Combo
            Dictionary<bool, string> durumSource = new Dictionary<bool, string>();
            durumSource.Add(false, "Pasif");
            durumSource.Add(true, "Aktif");

            lueBasSaat.Properties.DataSource = ComboDoldur(24);
            lueBasSaat.Properties.ValueMember = "Key";
            lueBasSaat.Properties.DisplayMember = "Value";
            lueBasSaat.EditValue = 0;

            lueBitSaat.Properties.DataSource = ComboDoldur(24);
            lueBitSaat.Properties.ValueMember = "Key";
            lueBitSaat.Properties.DisplayMember = "Value";
            lueBitSaat.EditValue = 23;

            lueDakika.Properties.DataSource = ComboDoldur(60);
            lueDakika.Properties.ValueMember = "Key";
            lueDakika.Properties.DisplayMember = "Value";
            lueDakika.EditValue = 0;

            lueSaat.Properties.DataSource = ComboDoldur(24);
            lueSaat.Properties.ValueMember = "Key";
            lueSaat.Properties.DisplayMember = "Value";
            lueSaat.EditValue = 0;

            lueGun.Properties.DataSource = ComboDoldur(7);
            lueGun.Properties.ValueMember = "Key";
            lueGun.Properties.DisplayMember = "Value";
            lueGun.EditValue = 0;

            lueHafta.Properties.DataSource = ComboDoldur(4);
            lueHafta.Properties.ValueMember = "Key";
            lueHafta.Properties.DisplayMember = "Value";
            lueHafta.EditValue = 0;

            lueAy.Properties.DataSource = ComboDoldur(12);
            lueAy.Properties.ValueMember = "Key";
            lueAy.Properties.DisplayMember = "Value";
            lueAy.EditValue = 0;

            lueDurum.Properties.DataSource = durumSource;
            lueDurum.Properties.ValueMember = "Key";
            lueDurum.Properties.DisplayMember = "Value";
            lueDurum.EditValue = 1;

            lueSorgu.Properties.DataSource = new ManagerPlan().GetComboSource();
            lueSorgu.Properties.ValueMember = "Key";
            lueSorgu.Properties.DisplayMember = "Value";

            lueMailAlici.Properties.DataSource = new ManagerMail().GetComboSource();
            lueMailAlici.Properties.ValueMember = "Key";
            lueMailAlici.Properties.DisplayMember = "Value";
            #endregion

            gridView1.FocusedRowChanged += (s, e) =>
            {
                if (gridView1.FocusedRowHandle == GridControl.InvalidRowHandle)
                {
                    //for initialize new empty Plan object
                    plan = new Plan();
                }
                else if (gridView1.GetRow(gridView1.FocusedRowHandle) is Plan tp)
                {
                    //for initialize Kullanici object based on focused row
                    plan = tp;
                    txtPlanAdi.Text = plan.plan_adi;
                    lueSorgu.EditValue = plan.bag_sorgu;
                    //lueMailAlici.EditValue = plan.bag_mail;
                    lueMailAlici.SetEditValue(plan.bag_mail);
                    lueDurum.EditValue = plan.durum;
                    chcHTML.EditValue = plan.mail_html;
                    dtePlan.EditValue = plan.son_tarih;
                    lueBasSaat.EditValue = plan.bas_saat;
                    lueBitSaat.EditValue = plan.bit_saat;
                    lueDakika.EditValue = plan.dakika;
                    lueSaat.EditValue = plan.saat;
                    lueGun.EditValue = plan.gun;
                    lueHafta.EditValue = plan.hafta;
                    lueAy.EditValue = plan.ay;
                }
            };

            btnCogalt.Click += (s, e) =>
            {
                gridView1.FocusInvalidRow();
                Temizle(false);
            };

            btnYeni.Click += (s, e) =>
            {
                gridView1.FocusInvalidRow();
                Temizle();
            };

            btnMail.Click += (s, e) =>
            {
                if (string.IsNullOrEmpty(txtPlanAdi.Text) || txtPlanAdi.Text.Length > 50)
                {
                    MessageBox.Show("Plan Adı boş veya 50 karakterden fazla olamaz!", "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    return;
                }
                if (!(Convert.ToBoolean(lueDurum.EditValue)) || (lueSorgu.EditValue != null && !string.IsNullOrEmpty(lueMailAlici.EditValue.ToString())))
                {
                    ManagerSorgu manager = new ManagerSorgu();
                    Sorgu sorgu = manager.GetSorgu((int)lueSorgu.EditValue);
                    string queryBody = sorgu.sorgu_icerik;
                    DataTable dt = manager.ConvertCSVtoDataTable(sorgu.parametre);
                    foreach (DataRow row in dt.Rows)
                    {
                        DataRow dr = row;
                        string strOld = dr[0].ToString();
                        string strNew = dr[1].ToString();
                        queryBody = queryBody.Replace(strOld, strNew);
                    }
                    string path = new ExcelGenerator().MainGenerate(manager.GetQueryResult(queryBody), Convert.ToBoolean(chcHTML.EditValue) ? 4 : 3, sorgu.tablo_tipi, txtPlanAdi.Text);
                    if (path != "")
                    {
                        List<string> receivers = new ManagerMail().GetMailList(lueMailAlici.EditValue.ToString());
                        MailSender(path, receivers, Convert.ToBoolean(chcHTML.EditValue), txtPlanAdi.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen plan alanlarını eksiksiz doldurun ve planlanan tarihlerin doğru olduğuna emin olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            btnKaydet.Click += (s, e) =>
            {
                if (string.IsNullOrEmpty(txtPlanAdi.Text) || txtPlanAdi.Text.Length > 50)
                {
                    MessageBox.Show("Plan Adı boş veya 50 karakterden fazla olamaz!", "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToDateTime(dtePlan.EditValue) < GecerliTarihSaat())
                {
                    DialogResult dg = MessageBox.Show("Plan tarihi eski güncellemek ister misiniz?!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dg == DialogResult.Yes)
                        dtePlan.EditValue = GecerliTarihSaat();
                    else
                        return;
                }
                if (!(Convert.ToBoolean(lueDurum.EditValue)) || (lueSorgu.EditValue != null && !string.IsNullOrEmpty(lueMailAlici.EditValue.ToString()) && Convert.ToByte(lueBasSaat.EditValue) <= Convert.ToByte(lueBitSaat.EditValue) && Convert.ToDateTime(dtePlan.EditValue) >= GecerliTarihSaat() && (Convert.ToByte(lueDakika.EditValue) != (byte)0 || Convert.ToByte(lueSaat.EditValue) != (byte)0 || Convert.ToByte(lueGun.EditValue) != (byte)0 || Convert.ToByte(lueHafta.EditValue) != (byte)0 || Convert.ToByte(lueAy.EditValue) != (byte)0)))
                {
                    // Create and save Plan object with user input areas
                    plan.bag_mail = lueMailAlici.EditValue.ToString();
                    plan.bag_sorgu = Convert.ToInt32(lueSorgu.EditValue);
                    plan.plan_adi = txtPlanAdi.Text;
                    plan.durum = Convert.ToBoolean(lueDurum.EditValue);
                    plan.mail_html = Convert.ToBoolean(chcHTML.EditValue);
                    plan.ilk_tarih = GecerliTarihSaat();
                    plan.son_tarih = Convert.ToDateTime(dtePlan.EditValue);
                    plan.bas_saat = Convert.ToByte(lueBasSaat.EditValue);
                    plan.bit_saat = Convert.ToByte(lueBitSaat.EditValue);
                    plan.dakika = Convert.ToByte(lueDakika.EditValue);
                    plan.saat = Convert.ToByte(lueSaat.EditValue);
                    plan.gun = Convert.ToByte(lueGun.EditValue);
                    plan.hafta = Convert.ToByte(lueHafta.EditValue);
                    plan.ay = Convert.ToByte(lueAy.EditValue);
                    ManagerPlan manager = new ManagerPlan();
                    manager.AddOrUpdate(plan);

                    //Load Data
                    var Data = manager.GetList();
                    gridControlListe.DataSource = Data;

                    //Clean and refresh Form
                    gridView1.FocusInvalidRow();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Lütfen plan alanlarını eksiksiz doldurun ve planlanan tarihlerin doğru olduğuna emin olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            };

            btnSil.Click += (s, e) =>
            {
                if (MessageBox.Show("Plan silinecektir, Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    ManagerPlan manager = new ManagerPlan();
                    //Delete if Plan is exist
                    if (plan.plan_no != 0)
                    {
                        manager.Delete(plan);
                    }
                    //Load Data
                    var Data = manager.GetList();
                    gridControlListe.DataSource = Data;

                    //Clean and refresh Form
                    gridView1.FocusInvalidRow();
                    Temizle();
                }
            };

            btnKapat.Click += (s, e) =>
            {
                this.Close();
            };
        }

        private void Temizle(bool deepClean = true)
        {
            lueSorgu.EditValue = DBNull.Value;
            txtPlanAdi.Text = "";
            if (deepClean)
            {
                dtePlan.EditValue = GecerliTarihSaat();
                lueMailAlici.SetEditValue(DBNull.Value);
                lueDurum.EditValue = true;
                chcHTML.EditValue = false;
                lueBasSaat.EditValue = (byte)0;
                lueBitSaat.EditValue = (byte)23;
                lueSaat.EditValue = (byte)0;
                lueGun.EditValue = (byte)0;
                lueHafta.EditValue = (byte)0;
                lueAy.EditValue = (byte)0;
                lueDakika.EditValue = (byte)0;
            }
        }
        public async Task LoadData()
        {
            ManagerPlan manager = new ManagerPlan();
            var Data = manager.GetList();
            gridControlListe.DataSource = Data;
            await Task.CompletedTask;
        }

        private Dictionary<byte, string> ComboDoldur(byte sayi)
        {
            Dictionary<byte, string> intSrc = new Dictionary<byte, string>();
            for (byte i = 0; i < sayi; i++)
            {
                intSrc.Add(i, i.ToString());
            }
            return intSrc;
        }

        private void MailSender(string excelFilePath, List<string> receivers, bool isBodyHTML, string plan_adi)
        {
            try
            {
                string sender = ConfigurationManager.AppSettings.Get("kullanici");
                string password = ConfigurationManager.AppSettings.Get("sifre");

                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress(sender);
                foreach (string receiver in receivers) ePosta.To.Add(receiver);
                ePosta.Subject = plan_adi;
                ePosta.IsBodyHtml = true;
                if (!isBodyHTML)
                {
                    ePosta.Body = "";
                    ePosta.Attachments.Add(new Attachment(excelFilePath));
                }
                else
                {
                    ePosta.Body = File.ReadAllText(excelFilePath);
                }
                SmtpClient smtp = new SmtpClient
                {
                    Credentials = new System.Net.NetworkCredential(sender, password),
                    Port = 587,
                    Host = "smtp.gmail.com",
                    EnableSsl = true
                };
                smtp.Send(ePosta);
                foreach (var item in ePosta.Attachments)
                {
                    item.Dispose();
                }
                smtp.Dispose();
                File.Delete(excelFilePath);
                MessageBox.Show("Mail Gönderimi Başarılı! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail Gönderimi Başarısız! " + Environment.NewLine + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private DateTime GecerliTarihSaat()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0, DateTime.Now.Kind);
        }
    }
}