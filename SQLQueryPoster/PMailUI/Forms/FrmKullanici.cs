using DevExpress.XtraGrid;
using PMailUI.Managers;
using PMailUI.Modals;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMailUI
{
    public partial class FrmKullanici : DevExpress.XtraEditors.XtraForm
    {
        Kullanici kullanici = new Kullanici();
        public FrmKullanici()
        {
            InitializeComponent();

            #region Combo Doldur
            Dictionary<bool, string> comboSource = new Dictionary<bool, string>();
            comboSource.Add(false, "Pasif");
            comboSource.Add(true, "Aktif");

            lueDurum.Properties.DataSource = comboSource;
            lueDurum.Properties.ValueMember = "Key";
            lueDurum.Properties.DisplayMember = "Value";
            lueDurum.EditValue = true;
            #endregion


            gridView1.FocusedRowChanged += (s, e) =>
            {
                if (gridView1.FocusedRowHandle == GridControl.InvalidRowHandle)
                {
                    //for initialize new empty Kullanici object
                    kullanici = new Kullanici();
                }
                else if (gridView1.GetRow(gridView1.FocusedRowHandle) is Kullanici tk)
                {
                    //for initialize Kullanici object based on focused row
                    kullanici = tk;
                    txtKullaniciAdi.Text = kullanici.adi;
                    txtSifre.Text = kullanici.sifre;
                    lueDurum.EditValue = kullanici.durum;
                }
            };

            btnYeni.Click += (s, e) =>
            {
                //Clean and refresh Form
                gridView1.FocusInvalidRow();
                Temizle();
            };

            btnKaydet.Click += (s, e) =>
            {
                if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtSifre.Text))
                {
                    // Create and save Kullanici object with user input areas
                    kullanici.adi = txtKullaniciAdi.Text;
                    kullanici.sifre = txtSifre.Text;
                    kullanici.durum = Convert.ToBoolean(lueDurum.EditValue);
                    ManagerKullanici manager = new ManagerKullanici();
                    manager.AddOrUpdate(kullanici);

                    //Load Data
                    var Data = manager.GetList();
                    gridControlListe.DataSource = Data;

                    //Clean and refresh Form
                    gridView1.FocusInvalidRow();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Lütfen kullanıcı alanlarını eksiksiz doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            btnSil.Click += (s, e) =>
            {
                if (MessageBox.Show("Kullanıcı silinecektir, Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    ManagerKullanici manager = new ManagerKullanici();
                    //Delete if Kullanici is exist
                    if (kullanici.kullanici_no != 0)
                    {
                        manager.Delete(kullanici);

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
        private void Temizle()
        {

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            lueDurum.EditValue = true;
        }

        public async Task LoadData()
        {
            ManagerKullanici manager = new ManagerKullanici();
            var Data = manager.GetList();
            gridControlListe.DataSource = Data;
            await Task.CompletedTask;
        }
    }
}