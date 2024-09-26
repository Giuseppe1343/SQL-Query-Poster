using Microsoft.Win32;
using PMailUI.Forms;
using PMailUI.Managers;
using System;
using System.Windows.Forms;

namespace PMailUI
{
    public partial class FrmGiris : DevExpress.XtraEditors.XtraForm
    {
        public FrmGiris()
        {
            InitializeComponent();

            txtKullaniciAdi.Text = Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("PMail").CreateSubKey("CurrUser").GetValue("User").ToString();

            btnGirisYap.Click += async (s, e) =>
            {
                if (GirisKontrol(txtKullaniciAdi.Text, txtSifre.Text))
                {
                    if (!S.AktifKullanici.durum)
                    {
                        MessageBox.Show("Girilen kullanıcı pasif durumdadır, Lütfen yöneticinizden yetki isteyin!", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    this.Hide();

                    Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("PMail").CreateSubKey("CurrUser").SetValue("User", txtKullaniciAdi.Text);

                    S.AktifKullanici.son_giris = DateTime.Now;
                    new ManagerKullanici().AddOrUpdate(S.AktifKullanici);

                    //var appFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    //var setFile = appFile.AppSettings.Settings;

                    //if (setFile["kullanici"] == null)
                    //    setFile.Add("kullanici", S.AktifKullanici.adi);
                    //else
                    //    setFile["kullanici"].Value = S.AktifKullanici.adi;

                    //appFile.Save(ConfigurationSaveMode.Modified);
                    //ConfigurationManager.RefreshSection(appFile.AppSettings.SectionInformation.Name);

                    FrmSorgu frmSorgu = new FrmSorgu();
                    frmSorgu.Show(this);
                    await frmSorgu.LoadData();
                    frmSorgu.FormClosed += (sss, eee) => { this.Show(); };

                }
                else MessageBox.Show("Girilen kullanıcı adı veya şifre hatalıdır !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            btnKapat.Click += (s, e) => { this.Close(); };

            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnGirisYap.PerformClick();
                }
                if (e.KeyCode == Keys.Escape)
                {
                    btnKapat.PerformClick();
                }
            };
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //Görünürken çalışacak kodlar 
            txtKullaniciAdi.SelectAll();
        }

        bool GirisKontrol(string text1, string text2)
        {
            S.AktifKullanici = new ManagerKullanici().GetSatir(text1, text2);

            if (S.AktifKullanici == null)
            {
                //MessageBox.Show("Giriş yapmaya çalışırken bir sorun oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
