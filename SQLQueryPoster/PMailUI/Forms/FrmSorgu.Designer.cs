namespace PMailUI.Forms
{
    partial class FrmSorgu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSorgu));
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.mleSorgu = new DevExpress.XtraEditors.MemoEdit();
            this.lblSorguAdi = new DevExpress.XtraEditors.LabelControl();
            this.txtSorguAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOnizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnMail = new DevExpress.XtraEditors.SimpleButton();
            this.btnYetki = new DevExpress.XtraEditors.SimpleButton();
            this.btnPlanla = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlListe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sorgu_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sorgu_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.durum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnKullanici = new DevExpress.XtraEditors.SimpleButton();
            this.btnAliciEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblTabloTipi = new DevExpress.XtraEditors.LabelControl();
            this.lueTabloTipi = new DevExpress.XtraEditors.LookUpEdit();
            this.lblDurum = new DevExpress.XtraEditors.LabelControl();
            this.lueDurum = new DevExpress.XtraEditors.LookUpEdit();
            this.mleParametre = new DevExpress.XtraEditors.MemoEdit();
            this.btnParametre = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mleSorgu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSorguAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTabloTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mleParametre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Appearance.FontSizeDelta = 3;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(1057, 0);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(60, 80);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            // 
            // btnYeni
            // 
            this.btnYeni.Appearance.FontSizeDelta = 3;
            this.btnYeni.Appearance.Options.UseFont = true;
            this.btnYeni.Enabled = false;
            this.btnYeni.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnYeni.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYeni.ImageOptions.SvgImage")));
            this.btnYeni.Location = new System.Drawing.Point(717, 0);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(60, 80);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.FontSizeDelta = 3;
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(1125, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(60, 80);
            this.btnKapat.TabIndex = 15;
            this.btnKapat.Text = "Kapat";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.FontSizeDelta = 3;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(989, 0);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(60, 80);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            // 
            // mleSorgu
            // 
            this.mleSorgu.Location = new System.Drawing.Point(354, 213);
            this.mleSorgu.Name = "mleSorgu";
            this.mleSorgu.Size = new System.Drawing.Size(685, 443);
            this.mleSorgu.TabIndex = 2;
            // 
            // lblSorguAdi
            // 
            this.lblSorguAdi.Appearance.FontSizeDelta = 3;
            this.lblSorguAdi.Appearance.Options.UseFont = true;
            this.lblSorguAdi.Location = new System.Drawing.Point(359, 112);
            this.lblSorguAdi.Margin = new System.Windows.Forms.Padding(4);
            this.lblSorguAdi.Name = "lblSorguAdi";
            this.lblSorguAdi.Size = new System.Drawing.Size(61, 18);
            this.lblSorguAdi.TabIndex = 17;
            this.lblSorguAdi.Text = "Sorgu Adı";
            // 
            // txtSorguAdi
            // 
            this.txtSorguAdi.Location = new System.Drawing.Point(354, 138);
            this.txtSorguAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSorguAdi.Name = "txtSorguAdi";
            this.txtSorguAdi.Properties.Appearance.FontSizeDelta = 3;
            this.txtSorguAdi.Properties.Appearance.Options.UseFont = true;
            this.txtSorguAdi.Size = new System.Drawing.Size(418, 24);
            this.txtSorguAdi.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.FontSizeDelta = 3;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(360, 188);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 18);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Sorgu";
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.FontSizeDelta = 3;
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExcel.ImageOptions.SvgImage")));
            this.btnExcel.Location = new System.Drawing.Point(853, 0);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(60, 80);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.Text = "Excel";
            // 
            // btnOnizle
            // 
            this.btnOnizle.Appearance.FontSizeDelta = 3;
            this.btnOnizle.Appearance.Options.UseFont = true;
            this.btnOnizle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnOnizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOnizle.ImageOptions.SvgImage")));
            this.btnOnizle.Location = new System.Drawing.Point(785, 0);
            this.btnOnizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnizle.Name = "btnOnizle";
            this.btnOnizle.Size = new System.Drawing.Size(60, 80);
            this.btnOnizle.TabIndex = 8;
            this.btnOnizle.Text = "Önizle";
            // 
            // btnMail
            // 
            this.btnMail.Appearance.FontSizeDelta = 3;
            this.btnMail.Appearance.Options.UseFont = true;
            this.btnMail.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnMail.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMail.ImageOptions.SvgImage")));
            this.btnMail.Location = new System.Drawing.Point(921, 0);
            this.btnMail.Margin = new System.Windows.Forms.Padding(4);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(60, 80);
            this.btnMail.TabIndex = 10;
            this.btnMail.Text = "Mail At";
            // 
            // btnYetki
            // 
            this.btnYetki.Appearance.FontSizeDelta = 3;
            this.btnYetki.Appearance.Options.UseFont = true;
            this.btnYetki.Enabled = false;
            this.btnYetki.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnYetki.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYetki.ImageOptions.SvgImage")));
            this.btnYetki.Location = new System.Drawing.Point(649, 0);
            this.btnYetki.Margin = new System.Windows.Forms.Padding(4);
            this.btnYetki.Name = "btnYetki";
            this.btnYetki.Size = new System.Drawing.Size(60, 80);
            this.btnYetki.TabIndex = 14;
            this.btnYetki.Text = "Yetki";
            this.btnYetki.Visible = false;
            // 
            // btnPlanla
            // 
            this.btnPlanla.Appearance.FontSizeDelta = 3;
            this.btnPlanla.Appearance.Options.UseFont = true;
            this.btnPlanla.Enabled = false;
            this.btnPlanla.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnPlanla.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPlanla.ImageOptions.SvgImage")));
            this.btnPlanla.Location = new System.Drawing.Point(422, 0);
            this.btnPlanla.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlanla.Name = "btnPlanla";
            this.btnPlanla.Size = new System.Drawing.Size(60, 80);
            this.btnPlanla.TabIndex = 12;
            this.btnPlanla.Text = "Planla";
            this.btnPlanla.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlListe);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(347, 668);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Sorgu Listesi";
            // 
            // gridControlListe
            // 
            this.gridControlListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlListe.Location = new System.Drawing.Point(2, 23);
            this.gridControlListe.MainView = this.gridView1;
            this.gridControlListe.Name = "gridControlListe";
            this.gridControlListe.Size = new System.Drawing.Size(343, 643);
            this.gridControlListe.TabIndex = 0;
            this.gridControlListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.sorgu_no,
            this.sorgu_adi,
            this.durum});
            this.gridView1.GridControl = this.gridControlListe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // sorgu_no
            // 
            this.sorgu_no.Caption = "Sorgu No";
            this.sorgu_no.FieldName = "sorgu_no";
            this.sorgu_no.Name = "sorgu_no";
            this.sorgu_no.Visible = true;
            this.sorgu_no.VisibleIndex = 0;
            this.sorgu_no.Width = 59;
            // 
            // sorgu_adi
            // 
            this.sorgu_adi.Caption = "Sorgu Adı";
            this.sorgu_adi.FieldName = "sorgu_adi";
            this.sorgu_adi.Name = "sorgu_adi";
            this.sorgu_adi.Visible = true;
            this.sorgu_adi.VisibleIndex = 1;
            this.sorgu_adi.Width = 217;
            // 
            // durum
            // 
            this.durum.Caption = "Durum";
            this.durum.FieldName = "durum";
            this.durum.Name = "durum";
            this.durum.Width = 40;
            // 
            // btnKullanici
            // 
            this.btnKullanici.Appearance.FontSizeDelta = 3;
            this.btnKullanici.Appearance.Options.UseFont = true;
            this.btnKullanici.Enabled = false;
            this.btnKullanici.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKullanici.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKullanici.ImageOptions.SvgImage")));
            this.btnKullanici.Location = new System.Drawing.Point(354, 0);
            this.btnKullanici.Margin = new System.Windows.Forms.Padding(4);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(60, 80);
            this.btnKullanici.TabIndex = 11;
            this.btnKullanici.Text = "Kullanıcı";
            this.btnKullanici.Visible = false;
            // 
            // btnAliciEkle
            // 
            this.btnAliciEkle.Appearance.FontSizeDelta = 3;
            this.btnAliciEkle.Appearance.Options.UseFont = true;
            this.btnAliciEkle.Enabled = false;
            this.btnAliciEkle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAliciEkle.ImageOptions.SvgImage = global::PMailUI.Properties.Resources.groupbydate;
            this.btnAliciEkle.Location = new System.Drawing.Point(490, 0);
            this.btnAliciEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAliciEkle.Name = "btnAliciEkle";
            this.btnAliciEkle.Size = new System.Drawing.Size(60, 80);
            this.btnAliciEkle.TabIndex = 13;
            this.btnAliciEkle.Text = "Alıcı Ekle";
            this.btnAliciEkle.Visible = false;
            // 
            // lblTabloTipi
            // 
            this.lblTabloTipi.Appearance.FontSizeDelta = 3;
            this.lblTabloTipi.Appearance.Options.UseFont = true;
            this.lblTabloTipi.Location = new System.Drawing.Point(921, 178);
            this.lblTabloTipi.Margin = new System.Windows.Forms.Padding(4);
            this.lblTabloTipi.Name = "lblTabloTipi";
            this.lblTabloTipi.Size = new System.Drawing.Size(60, 18);
            this.lblTabloTipi.TabIndex = 19;
            this.lblTabloTipi.Text = "Tablo Stili";
            // 
            // lueTabloTipi
            // 
            this.lueTabloTipi.Location = new System.Drawing.Point(989, 175);
            this.lueTabloTipi.Margin = new System.Windows.Forms.Padding(4);
            this.lueTabloTipi.Name = "lueTabloTipi";
            this.lueTabloTipi.Properties.Appearance.FontSizeDelta = 3;
            this.lueTabloTipi.Properties.Appearance.Options.UseFont = true;
            this.lueTabloTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTabloTipi.Properties.NullText = "";
            this.lueTabloTipi.Properties.PopupSizeable = false;
            this.lueTabloTipi.Size = new System.Drawing.Size(196, 24);
            this.lueTabloTipi.TabIndex = 3;
            // 
            // lblDurum
            // 
            this.lblDurum.Appearance.FontSizeDelta = 3;
            this.lblDurum.Appearance.Options.UseFont = true;
            this.lblDurum.Location = new System.Drawing.Point(1005, 141);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(44, 18);
            this.lblDurum.TabIndex = 20;
            this.lblDurum.Text = "Durum";
            this.lblDurum.Visible = false;
            // 
            // lueDurum
            // 
            this.lueDurum.Enabled = false;
            this.lueDurum.Location = new System.Drawing.Point(1057, 138);
            this.lueDurum.Margin = new System.Windows.Forms.Padding(4);
            this.lueDurum.Name = "lueDurum";
            this.lueDurum.Properties.Appearance.FontSizeDelta = 3;
            this.lueDurum.Properties.Appearance.Options.UseFont = true;
            this.lueDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDurum.Properties.NullText = "";
            this.lueDurum.Properties.PopupSizeable = false;
            this.lueDurum.Size = new System.Drawing.Size(128, 24);
            this.lueDurum.TabIndex = 5;
            this.lueDurum.Visible = false;
            // 
            // mleParametre
            // 
            this.mleParametre.Location = new System.Drawing.Point(1046, 279);
            this.mleParametre.Name = "mleParametre";
            this.mleParametre.Properties.ReadOnly = true;
            this.mleParametre.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mleParametre.Properties.WordWrap = false;
            this.mleParametre.Size = new System.Drawing.Size(140, 377);
            this.mleParametre.TabIndex = 21;
            // 
            // btnParametre
            // 
            this.btnParametre.Appearance.FontSizeDelta = 3;
            this.btnParametre.Appearance.Options.UseFont = true;
            this.btnParametre.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnParametre.ImageOptions.SvgImage = global::PMailUI.Properties.Resources.propertiespanel;
            this.btnParametre.Location = new System.Drawing.Point(1046, 214);
            this.btnParametre.Margin = new System.Windows.Forms.Padding(4);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(140, 60);
            this.btnParametre.TabIndex = 4;
            this.btnParametre.Text = "Parametre";
            // 
            // FrmSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 668);
            this.Controls.Add(this.btnParametre);
            this.Controls.Add(this.mleParametre);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lueDurum);
            this.Controls.Add(this.lblTabloTipi);
            this.Controls.Add(this.lueTabloTipi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblSorguAdi);
            this.Controls.Add(this.txtSorguAdi);
            this.Controls.Add(this.mleSorgu);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYetki);
            this.Controls.Add(this.btnOnizle);
            this.Controls.Add(this.btnKullanici);
            this.Controls.Add(this.btnAliciEkle);
            this.Controls.Add(this.btnPlanla);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmSorgu.IconOptions.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmSorgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorgu Tanıtım";
            ((System.ComponentModel.ISupportInitialize)(this.mleSorgu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSorguAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTabloTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mleParametre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.MemoEdit mleSorgu;
        private DevExpress.XtraEditors.LabelControl lblSorguAdi;
        private DevExpress.XtraEditors.TextEdit txtSorguAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnOnizle;
        private DevExpress.XtraEditors.SimpleButton btnMail;
        private DevExpress.XtraEditors.SimpleButton btnYetki;
        private DevExpress.XtraEditors.SimpleButton btnPlanla;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn sorgu_no;
        private DevExpress.XtraGrid.Columns.GridColumn sorgu_adi;
        private DevExpress.XtraEditors.SimpleButton btnKullanici;
        private DevExpress.XtraEditors.SimpleButton btnAliciEkle;
        private DevExpress.XtraEditors.LabelControl lblTabloTipi;
        private DevExpress.XtraEditors.LookUpEdit lueTabloTipi;
        private DevExpress.XtraEditors.LabelControl lblDurum;
        private DevExpress.XtraEditors.LookUpEdit lueDurum;
        private DevExpress.XtraGrid.Columns.GridColumn durum;
        private DevExpress.XtraEditors.MemoEdit mleParametre;
        private DevExpress.XtraEditors.SimpleButton btnParametre;
    }
}