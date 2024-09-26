using DevExpress.XtraGrid;
using PMailUI.Managers;
using PMailUI.Modals;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMailUI.Forms
{
    public partial class FrmMail : DevExpress.XtraEditors.XtraForm
    {
        Mail mail = new Mail();
        public FrmMail()
        {
            InitializeComponent();

            gridView1.FocusedRowChanged += (s, e) =>
            {
                if (gridView1.FocusedRowHandle == GridControl.InvalidRowHandle)
                {
                    //for initialize new empty Plan object
                    mail = new Mail();
                }
                else if (gridView1.GetRow(gridView1.FocusedRowHandle) is Mail tm)
                {
                    //for initialize Kullanici object based on focused row
                    mail = tm;
                    txtMailAdi.Text = mail.mail_adi;
                    txtMailAdres.Text = mail.mail_adres;
                }
            };


            btnYeni.Click += (s, e) =>
            {
                gridView1.FocusInvalidRow();
                Temizle();
            };

            btnKaydet.Click += (s, e) =>
            {
                if (!string.IsNullOrEmpty(txtMailAdi.Text) && !string.IsNullOrEmpty(txtMailAdres.Text))
                {
                    // Create and save Mail object with user input areas
                    mail.mail_adi = txtMailAdi.Text;
                    mail.mail_adres = txtMailAdres.Text;
                    ManagerMail manager = new ManagerMail();
                    manager.AddOrUpdate(mail);

                    //Load Data
                    var Data = manager.GetList();
                    gridControlListe.DataSource = Data;

                    //Clean and refresh Form
                    gridView1.FocusInvalidRow();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Lütfen mail alanlarını eksiksiz doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            btnSil.Click += (s, e) =>
            {
                if (MessageBox.Show("Mail silinecektir, Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    ManagerMail manager = new ManagerMail();
                    //Delete if Mail is exist
                    if (mail.mail_no != 0)
                    {
                        manager.Delete(mail);
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
            txtMailAdi.Text = "";
            txtMailAdres.Text = "";
        }
        public async Task LoadData()
        {
            ManagerMail manager = new ManagerMail();
            var Data = manager.GetList();
            gridControlListe.DataSource = Data;
            await Task.CompletedTask;
        }
    }
}