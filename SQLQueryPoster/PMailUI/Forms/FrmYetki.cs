using PMailUI.Managers;
using PMailUI.Modals;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMailUI.Forms
{
    public partial class FrmYetki : DevExpress.XtraEditors.XtraForm
    {
        List<Yetki> yetkiler;
        private int SorguNo { get; set; }
        public FrmYetki(int SorguNo, string SorguAdi)
        {
            this.SorguNo = SorguNo;

            InitializeComponent();
            lblSorguAdi.Text = "\"" + SorguAdi + "\"   Sorgusu için Yetkilendirme İşlemi";

            btnKaydet.Click += (s, e) =>
            {
                //Save List
                ManagerSorgu manager = new ManagerSorgu();
                yetkiler = gridControl1.DataSource as List<Yetki>;
                yetkiler.ForEach(x => x.bag_sorgu = SorguNo);
                manager.AddOrUpdate(yetkiler);

                if (MessageBox.Show("Yetki listesi başarıyla kaydedildi, Sorgu ekranına yönlendirilmek ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
                //Refresh List
                yetkiler = manager.GetSorguKullanici(this.SorguNo);
                gridControl1.DataSource = yetkiler;



            };
            btnKapat.Click += (s, e) =>
            {
                this.Close();
            };
        }
        public async Task LoadData()
        {
            ManagerSorgu manager = new ManagerSorgu();
            yetkiler = manager.GetSorguKullanici(this.SorguNo);
            gridControl1.DataSource = yetkiler;
            await Task.CompletedTask;
        }
    }
}