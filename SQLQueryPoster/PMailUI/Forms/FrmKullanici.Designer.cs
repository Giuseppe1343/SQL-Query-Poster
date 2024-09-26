namespace PMailUI
{
    partial class FrmKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanici));
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();
            this.lblDurum = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlListe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.kullanici_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.durum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lueDurum = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDurum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Appearance.FontSizeDelta = 3;
            this.lblKullaniciAdi.Appearance.Options.UseFont = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(386, 191);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(72, 18);
            this.lblKullaniciAdi.TabIndex = 8;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.FontSizeDelta = 3;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKaydet.ImageOptions.SvgImage = global::PMailUI.Properties.Resources.bo_validation;
            this.btnKaydet.Location = new System.Drawing.Point(539, 0);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(60, 80);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(469, 188);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.FontSizeDelta = 3;
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(223, 24);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(469, 226);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.FontSizeDelta = 3;
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Size = new System.Drawing.Size(223, 24);
            this.txtSifre.TabIndex = 2;
            // 
            // lblSifre
            // 
            this.lblSifre.Appearance.FontSizeDelta = 3;
            this.lblSifre.Appearance.Options.UseFont = true;
            this.lblSifre.Location = new System.Drawing.Point(432, 230);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(28, 18);
            this.lblSifre.TabIndex = 9;
            this.lblSifre.Text = "Şifre";
            // 
            // lblDurum
            // 
            this.lblDurum.Appearance.FontSizeDelta = 3;
            this.lblDurum.Appearance.Options.UseFont = true;
            this.lblDurum.Location = new System.Drawing.Point(415, 263);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(44, 18);
            this.lblDurum.TabIndex = 10;
            this.lblDurum.Text = "Durum";
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.FontSizeDelta = 3;
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKapat.ImageOptions.SvgImage = global::PMailUI.Properties.Resources.delete;
            this.btnKapat.Location = new System.Drawing.Point(675, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(60, 80);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            // 
            // btnYeni
            // 
            this.btnYeni.Appearance.FontSizeDelta = 3;
            this.btnYeni.Appearance.Options.UseFont = true;
            this.btnYeni.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnYeni.ImageOptions.SvgImage = global::PMailUI.Properties.Resources.actions_rollback;
            this.btnYeni.Location = new System.Drawing.Point(471, 0);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(60, 80);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            // 
            // btnSil
            // 
            this.btnSil.Appearance.FontSizeDelta = 3;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSil.ImageOptions.SvgImage = global::PMailUI.Properties.Resources.actions_forbid;
            this.btnSil.Location = new System.Drawing.Point(607, 0);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(60, 80);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            // 
            // gridControlListe
            // 
            this.gridControlListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlListe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gridControlListe.Location = new System.Drawing.Point(2, 23);
            this.gridControlListe.MainView = this.gridView1;
            this.gridControlListe.Name = "gridControlListe";
            this.gridControlListe.Size = new System.Drawing.Size(345, 393);
            this.gridControlListe.TabIndex = 0;
            this.gridControlListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.kullanici_no,
            this.adi,
            this.durum});
            this.gridView1.GridControl = this.gridControlListe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            // 
            // kullanici_no
            // 
            this.kullanici_no.Caption = "Kullanıcı No";
            this.kullanici_no.FieldName = "kullanici_no";
            this.kullanici_no.Name = "kullanici_no";
            this.kullanici_no.Visible = true;
            this.kullanici_no.VisibleIndex = 0;
            this.kullanici_no.Width = 52;
            // 
            // adi
            // 
            this.adi.Caption = "Kullanıcı Adı";
            this.adi.FieldName = "adi";
            this.adi.Name = "adi";
            this.adi.Visible = true;
            this.adi.VisibleIndex = 1;
            this.adi.Width = 223;
            // 
            // durum
            // 
            this.durum.Caption = "Durum";
            this.durum.FieldName = "durum";
            this.durum.Name = "durum";
            this.durum.Visible = true;
            this.durum.VisibleIndex = 2;
            this.durum.Width = 47;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlListe);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(349, 418);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Kullanıcı Listesi";
            // 
            // lueDurum
            // 
            this.lueDurum.Location = new System.Drawing.Point(469, 263);
            this.lueDurum.Margin = new System.Windows.Forms.Padding(4);
            this.lueDurum.Name = "lueDurum";
            this.lueDurum.Properties.Appearance.FontSizeDelta = 3;
            this.lueDurum.Properties.Appearance.Options.UseFont = true;
            this.lueDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDurum.Properties.NullText = "";
            this.lueDurum.Properties.PopupSizeable = false;
            this.lueDurum.Size = new System.Drawing.Size(175, 24);
            this.lueDurum.TabIndex = 3;
            // 
            // FrmKullanici
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 418);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lueDurum);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmKullanici.IconOptions.Icon")));
            this.Name = "FrmKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Tanıtım";
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueDurum.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private DevExpress.XtraEditors.LabelControl lblDurum;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraGrid.GridControl gridControlListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn adi;
        private DevExpress.XtraEditors.LookUpEdit lueDurum;
        private DevExpress.XtraGrid.Columns.GridColumn kullanici_no;
        private DevExpress.XtraGrid.Columns.GridColumn durum;
    }
}