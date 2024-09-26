using DevExpress.XtraGrid;
using PMailUI.Managers;
using PMailUI.Modals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMailUI.Forms
{
    public partial class FrmSorgu : DevExpress.XtraEditors.XtraForm
    {
        bool isAdmin = S.AktifKullanici.kullanici_no == 1;
        Sorgu sorgu = new Sorgu();
        public FrmSorgu()
        {
            InitializeComponent();

            #region ComboDoldur
            //Fill and Initialize Combo

            Dictionary<int, string> temaSource = new Dictionary<int, string>
            {
                { 0, "Stil Yok" },
                { 1, "Siyah, Açık 1" },
                { 2, "Mavi, Açık 1" },
                { 3, "Kırmızı, Açık 1" },
                { 4, "Yeşil, Açık 1" },
                { 5, "Mor, Açık 1" },
                { 6, "Cyan, Açık 1" },
                { 7, "Turuncu, Açık 1" },
                { 8, "Siyah, Açık 2" },
                { 9, "Mavi, Açık 2" },
                { 10, "Kırmızı, Açık 2" },
                { 11, "Yeşil, Açık 2" },
                { 12, "Mor, Açık 2" },
                { 13, "Cyan, Açık 2" },
                { 14, "Turuncu, Açık 2" },
                { 15, "Siyah, Açık NH" },
                { 16, "Mavi, Açık NH" },
                { 17, "Kırmızı, Açık NH" },
                { 18, "Yeşil, Açık NH" },
                { 19, "Mor, Açık NH" },
                { 20, "Cyan, Açık NH" },
                { 21, "Turuncu, Açık NH" },
                { 22, "Siyah, Orta 1" },
                { 23, "Mavi, Orta 1" },
                { 24, "Kırmızı, Orta 1" },
                { 25, "Yeşil, Orta 1" },
                { 26, "Mor, Orta 1" },
                { 27, "Cyan, Orta 1" },
                { 28, "Turuncu, Orta 1" },
                { 29, "Siyah, Orta 2" },
                { 30, "Mavi, Orta 2" },
                { 31, "Kırmızı, Orta 2" },
                { 32, "Yeşil, Orta 2" },
                { 33, "Mor, Orta 2" },
                { 34, "Cyan, Orta 2" },
                { 35, "Turuncu, Orta 2" },
                { 36, "Siyah, Orta 3" },
                { 37, "Mavi, Orta 3" },
                { 38, "Kırmızı, Orta 3" },
                { 39, "Yeşil, Orta 3" },
                { 40, "Mor, Orta 3" },
                { 41, "Cyan, Orta 3" },
                { 42, "Turuncu, Orta 3" },
                { 43, "Siyah, Orta NH" },
                { 44, "Mavi, Orta NH" },
                { 45, "Kırmızı, Orta NH" },
                { 46, "Yeşil, Orta NH" },
                { 47, "Mor, Orta NH" },
                { 48, "Cyan, Orta NH" },
                { 49, "Turuncu, Orta NH" },
            };

            lueTabloTipi.Properties.DataSource = temaSource;
            lueTabloTipi.Properties.ValueMember = "Key";
            lueTabloTipi.Properties.DisplayMember = "Value";
            lueTabloTipi.EditValue = 0;
            #endregion
            ////for Stop table dependency
            //this.FormClosing += FrmSorgu_FormClosing;

            //Check AktifKullanici is admin
            if (isAdmin)
            {
                Dictionary<bool, string> comboSource = new Dictionary<bool, string>
                {
                    { false, "Pasif" },
                    { true, "Aktif" }
                };
                lueDurum.Properties.DataSource = comboSource;
                lueDurum.Properties.ValueMember = "Key";
                lueDurum.Properties.DisplayMember = "Value";
                lueDurum.EditValue = true;
                lueDurum.Visible = true;
                lueDurum.Enabled = true;
                lblDurum.Visible = true;
                gridView1.Columns["sorgu_adi"].VisibleIndex = 1;
                gridView1.Columns["durum"].VisibleIndex = 2;
                gridView1.Columns["durum"].Visible = true;

                btnKullanici.Visible = true;
                btnKullanici.Enabled = true;
                btnPlanla.Visible = true;
                btnPlanla.Enabled = true;
                btnAliciEkle.Visible = true;
                btnAliciEkle.Enabled = true;
                btnYetki.Visible = true;
                btnYetki.Enabled = true;
                btnYeni.Visible = true;
                btnYeni.Enabled = true;

                btnKullanici.Click += async (s, e) =>
                {
                    //Open frmKullanici for manage users
                    this.Hide();
                    FrmKullanici frmKullanici = new FrmKullanici();
                    frmKullanici.Show(this);
                    await frmKullanici.LoadData();
                    frmKullanici.FormClosed += (ss, ee) => { this.Show(); };
                };

                btnPlanla.Click += async (s, e) =>
                {
                    //Open frmPlan for sheduling mail
                    this.Hide();
                    FrmPlan frmPlan = new FrmPlan();
                    frmPlan.Show(this);
                    await frmPlan.LoadData();
                    frmPlan.FormClosed += (ss, ee) => { this.Show(); };
                };

                btnAliciEkle.Click += async (s, e) =>
                {
                    //Open frmMail for add receiver mails
                    this.Hide();
                    FrmMail frmMail = new FrmMail();
                    frmMail.Show(this);
                    await frmMail.LoadData();
                    frmMail.FormClosed += (ss, ee) => { this.Show(); };
                };

                btnYetki.Click += async (s, e) =>
                {
                    //Create List<Yetki> based on current Sorgu
                    this.Hide();
                    FrmYetki frmYetki = new FrmYetki(sorgu.sorgu_no, sorgu.sorgu_adi);
                    await frmYetki.LoadData();
                    frmYetki.Show();
                    frmYetki.FormClosed += (ss, ee) => { this.Show(); };
                };

                btnYeni.Click += (s, e) =>
                {
                    gridView1.FocusInvalidRow();
                    Temizle();
                };
            }


            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F5)
                {
                    btnYeni.PerformClick();
                }
                if (e.KeyCode == Keys.Escape)
                {
                    btnKapat.PerformClick();
                }
            };


            gridView1.FocusedRowChanged += (s, e) =>
            {
                if (gridView1.FocusedRowHandle == GridControl.InvalidRowHandle)
                {
                    //for initialize new empty Sorgu object
                    sorgu = new Sorgu();
                }
                else if (gridView1.GetRow(gridView1.FocusedRowHandle) is Sorgu ts)
                {
                    //for initialize Kullanici object based on focused row
                    sorgu = ts;
                    txtSorguAdi.Text = sorgu.sorgu_adi;
                    mleSorgu.Text = sorgu.sorgu_icerik;
                    lueTabloTipi.EditValue = sorgu.tablo_tipi;
                    mleParametre.Text = sorgu.parametre;
                    if (isAdmin) lueDurum.EditValue = sorgu.durum;
                }
                //if User is not Admin check authority
                if (!isAdmin)
                {
                    if (sorgu.degistir)
                    {
                        txtSorguAdi.ReadOnly = false;
                        mleSorgu.ReadOnly = false;
                        btnKaydet.Enabled = true;
                    }
                    else
                    {
                        txtSorguAdi.ReadOnly = true;
                        mleSorgu.ReadOnly = true;
                        btnKaydet.Enabled = false;
                    }
                    if (sorgu.sil) btnSil.Enabled = true;
                    else btnSil.Enabled = false;
                    if (sorgu.mail) btnMail.Enabled = true;
                    else btnMail.Enabled = false;
                    if (sorgu.excel)
                    {
                        btnOnizle.Enabled = true;
                        btnExcel.Enabled = true;
                    }
                    else
                    {
                        btnOnizle.Enabled = false;
                        btnExcel.Enabled = false;
                    }
                }
            };

            btnOnizle.Click += (s, e) =>
            {
                //KayitYap if current input areas differ from Sorgu areas
                string query = SorguHazirla();

                //Create excel report and open it
                var myReport = new ManagerSorgu().GetQueryResult(query);
                new ExcelGenerator().MainGenerate(myReport, 1, sorgu.tablo_tipi);

                //Load Data
                var Data = new ManagerSorgu().GetList();
                gridControlListe.DataSource = Data;

                //Clean and refresh Form
                gridView1.FocusInvalidRow();
                Temizle();

            };

            btnExcel.Click += (s, e) =>
            {
                //KayitYap if current input areas differ from Sorgu areas
                string query = SorguHazirla();

                //Create excel report and save it selected directory
                var myReport = new ManagerSorgu().GetQueryResult(query);
                new ExcelGenerator().MainGenerate(myReport, 2, sorgu.tablo_tipi, sorgu.sorgu_adi);

                //Load Data
                var Data = new ManagerSorgu().GetList();
                gridControlListe.DataSource = Data;

                //Clean and refresh Form
                gridView1.FocusInvalidRow();
                Temizle();

            };

            btnMail.Click += (s, e) =>
            {
                //KayitYap if current input areas differ from Sorgu areas
                string query = SorguHazirla();

                //Create excel report and save it selected directory
                var myReport = new ManagerSorgu().GetQueryResult(query);
                if (myReport != null && myReport.Count > 0)
                {
                    FrmMailGonder frmMailGonder = new FrmMailGonder(myReport, sorgu.sorgu_adi, sorgu.tablo_tipi);
                    this.Hide();
                    frmMailGonder.Show(this);
                    frmMailGonder.FormClosed += (ss, ee) => { this.Show(); };
                }
                else
                {
                    MessageBox.Show("Girilen sorgu hatalı veya boş tablo döndürüyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Load Data
                var Data = new ManagerSorgu().GetList();
                gridControlListe.DataSource = Data;

                //Clean and refresh Form
                gridView1.FocusInvalidRow();
                Temizle();
            };

            btnParametre.Click += (s, e) =>
            {
                FrmParametre frmParametre = new FrmParametre(mleParametre.Text);
                var result = frmParametre.ShowDialog();
                if (result == DialogResult.OK) mleParametre.Text = frmParametre.csv;
            };

            btnKaydet.Click += (s, e) =>
            {
                if (KayitYap(true))
                {
                    //if KayitYap return true and then Refresh and Clean Form 
                    var Data = new ManagerSorgu().GetList();
                    gridControlListe.DataSource = Data;
                    gridView1.FocusInvalidRow();
                    Temizle();
                }
            };

            btnSil.Click += (s, e) =>
            {
                if (MessageBox.Show("Sorgu silinecektir, Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    ManagerSorgu manager = new ManagerSorgu();
                    //Delete if Sorgu is exist
                    if (sorgu.sorgu_no != 0 && isAdmin)
                    {
                        manager.Delete(sorgu);
                    }
                    else if (sorgu.sorgu_no != 0)
                    {
                        sorgu.durum = false;
                        manager.AddOrUpdate(sorgu);
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

            ////Try until TableDependency starts
            //while (!StartSorguTableDependency()) ;
        }

        private string SorguHazirla()
        {
            if ((sorgu.sorgu_adi != txtSorguAdi.Text || sorgu.sorgu_icerik != mleSorgu.Text || sorgu.tablo_tipi != Convert.ToInt32(lueTabloTipi.EditValue)) && !((sorgu.sorgu_adi == null && txtSorguAdi.Text == "") || (sorgu.sorgu_icerik == null && mleSorgu.Text == "")))
            {
                if (sorgu.degistir || isAdmin)
                {
                    KayitYap();
                }
                else MessageBox.Show("Kayıt yetkisi bulunmadığından sorgu kaydedilmeden devam edilecektir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string queryBody = sorgu.sorgu_icerik;
            DataTable dt = new ManagerSorgu().ConvertCSVtoDataTable(mleParametre.Text);
            foreach (DataRow row in dt.Rows)
            {
                DataRow dr = row;
                string strOld = dr[0].ToString();
                string strNew = dr[1].ToString();
                queryBody = queryBody.Replace(strOld, strNew);
            }
            return queryBody;
        }


        private bool KayitYap(bool kaydet = false)
        {
            if (!string.IsNullOrEmpty(txtSorguAdi.Text) && !string.IsNullOrEmpty(mleSorgu.Text) && !ContainsDangerousQuery(mleSorgu.Text))
            {
                if (isAdmin) sorgu.durum = Convert.ToBoolean(lueDurum.EditValue);
                sorgu.sorgu_adi = txtSorguAdi.Text;
                sorgu.sorgu_icerik = mleSorgu.Text;
                if (isAdmin && kaydet) sorgu.parametre = mleParametre.Text;
                if (sorgu.parametre == "Param;Value") sorgu.parametre = null;
                sorgu.tablo_tipi = Convert.ToInt32(lueTabloTipi.EditValue);
                sorgu.duzelten = S.AktifKullanici.kullanici_no;
                sorgu.duzeltme_tarih = DateTime.Now;

                new ManagerSorgu().AddOrUpdate(sorgu);
                return true;
            }
            else if (ContainsDangerousQuery(mleSorgu.Text))
            {
                MessageBox.Show("Lütfen izin verilmeyen sorgu tiplerini kullanmayın! \n ( UPDATE, DELETE, INSERT INTO, CREATE DATABASE, ALTER DATABASE, CREATE TABLE, ALTER TABLE, DROP TABLE, CREATE INDEX, DROP INDEX )", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show("Lütfen sorgu alanlarını eksiksiz doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void Temizle()
        {
            txtSorguAdi.Text = "";
            mleSorgu.Text = "";
            mleParametre.Text = "";
            lueTabloTipi.EditValue = 0;
            lueDurum.EditValue = 1;
        }

        public async Task LoadData()
        {
            ManagerSorgu manager = new ManagerSorgu();
            var Data = manager.GetList();
            gridControlListe.DataSource = Data;
            await Task.CompletedTask;
        }

        public bool ContainsDangerousQuery(string str)
        {
            if (str == null) return false;
            IList<string> DangerousQuery = new List<string> { "UPDATE", "DELETE", "INSERT INTO", "CREATE DATABASE", "ALTER DATABASE", "CREATE TABLE", "ALTER TABLE", "DROP TABLE", "CREATE INDEX", "DROP INDEX" };
            foreach (string str2 in DangerousQuery)
            {
                if (str.IndexOf(str2, StringComparison.OrdinalIgnoreCase) >= 0)
                    return true;
            }
            return false;
        }

        #region SQLTableDependency
        //public SqlTableDependency<Sorgu> SorguTableDependency;

        //private bool StartSorguTableDependency()
        //{
        //    try
        //    {
        //        SorguTableDependency = new SqlTableDependency<Sorgu>(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString,"tb_sorgu");
        //        SorguTableDependency.OnChanged += SorguTableDependency_Changed;
        //        SorguTableDependency.OnError += SorguTableDependency_OnError;
        //        SorguTableDependency.Start();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("SqlTableDependency başlatılırken hata oluştu: \n" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return false;
        //}

        //private bool StopSorguTableDependency()
        //{
        //    try
        //    {
        //        if (SorguTableDependency != null)
        //        {
        //            SorguTableDependency.Stop();

        //            return true;
        //        }
        //    }
        //    catch (Exception ex) 
        //    { 
        //        MessageBox.Show("SqlTableDependency sonlandırılırken hata oluştu: \n" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        //    }
        //    return false;
        //}

        //private void SorguTableDependency_OnError(object sender, ErrorEventArgs e)
        //{
        //    MessageBox.Show("SqlTableDependency bir hata oluşturdu: \n" + e.Error.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        //private void SorguTableDependency_Changed(object sender, RecordChangedEventArgs<Sorgu> e)
        //{
        //    //GetList if there is any change
        //    gridControlListe.DataSource = new ManagerSorgu().GetList();
        //}

        //private void FrmSorgu_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    //Try until TableDependency stops
        //    while (!StopSorguTableDependency()) ;
        //}
        #endregion
    }
}