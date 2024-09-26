using PMailUI.Managers;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PMailUI.Forms
{
    public partial class FrmParametre : DevExpress.XtraEditors.XtraForm
    {
        public string csv { get; set; }
        public FrmParametre(string csv)
        {
            this.csv = csv;
            InitializeComponent();

            gridControl1.DataSource = new ManagerSorgu().ConvertCSVtoDataTable(this.csv);
            btnKaydet.Click += (s, e) =>
            {
                MemoryStream stream = new MemoryStream();
                gridControl1.ExportToCsv(stream);

                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("ISO-8859-9")))
                {
                    string result = reader.ReadToEnd();
                    this.csv = result;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            btnKapat.Click += (s, e) =>
            {
                this.Close();
            };
        }
    }
}