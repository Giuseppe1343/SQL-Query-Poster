namespace PMailUI.Forms
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlListe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mail_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mail_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mail_adres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblMailAdi = new DevExpress.XtraEditors.LabelControl();
            this.txtMailAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtMailAdres = new DevExpress.XtraEditors.TextEdit();
            this.lblMailAdres = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdres.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Appearance.FontSizeDelta = 3;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(607, 0);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(60, 80);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            // 
            // btnYeni
            // 
            this.btnYeni.Appearance.FontSizeDelta = 3;
            this.btnYeni.Appearance.Options.UseFont = true;
            this.btnYeni.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnYeni.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYeni.ImageOptions.SvgImage")));
            this.btnYeni.Location = new System.Drawing.Point(471, 0);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(60, 80);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.FontSizeDelta = 3;
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(675, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(60, 80);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "Kapat";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.FontSizeDelta = 3;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(539, 0);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(60, 80);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlListe);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(424, 368);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Mail Listesi";
            // 
            // gridControlListe
            // 
            this.gridControlListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlListe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gridControlListe.Location = new System.Drawing.Point(2, 23);
            this.gridControlListe.MainView = this.gridView1;
            this.gridControlListe.Name = "gridControlListe";
            this.gridControlListe.Size = new System.Drawing.Size(420, 343);
            this.gridControlListe.TabIndex = 0;
            this.gridControlListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mail_no,
            this.mail_adi,
            this.mail_adres});
            this.gridView1.GridControl = this.gridControlListe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            // 
            // mail_no
            // 
            this.mail_no.Caption = "Mail No";
            this.mail_no.FieldName = "mail_no";
            this.mail_no.Name = "mail_no";
            this.mail_no.Visible = true;
            this.mail_no.VisibleIndex = 0;
            this.mail_no.Width = 56;
            // 
            // mail_adi
            // 
            this.mail_adi.Caption = "Mail Adı";
            this.mail_adi.FieldName = "mail_adi";
            this.mail_adi.Name = "mail_adi";
            this.mail_adi.Visible = true;
            this.mail_adi.VisibleIndex = 1;
            this.mail_adi.Width = 99;
            // 
            // mail_adres
            // 
            this.mail_adres.Caption = "Mail Adresi";
            this.mail_adres.FieldName = "mail_adres";
            this.mail_adres.Name = "mail_adres";
            this.mail_adres.Visible = true;
            this.mail_adres.VisibleIndex = 2;
            this.mail_adres.Width = 242;
            // 
            // lblMailAdi
            // 
            this.lblMailAdi.Appearance.FontSizeDelta = 3;
            this.lblMailAdi.Appearance.Options.UseFont = true;
            this.lblMailAdi.Location = new System.Drawing.Point(451, 187);
            this.lblMailAdi.Margin = new System.Windows.Forms.Padding(4);
            this.lblMailAdi.Name = "lblMailAdi";
            this.lblMailAdi.Size = new System.Drawing.Size(48, 18);
            this.lblMailAdi.TabIndex = 7;
            this.lblMailAdi.Text = "Mail Adı";
            // 
            // txtMailAdi
            // 
            this.txtMailAdi.Location = new System.Drawing.Point(507, 184);
            this.txtMailAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailAdi.Name = "txtMailAdi";
            this.txtMailAdi.Properties.Appearance.FontSizeDelta = 3;
            this.txtMailAdi.Properties.Appearance.Options.UseFont = true;
            this.txtMailAdi.Size = new System.Drawing.Size(228, 24);
            this.txtMailAdi.TabIndex = 1;
            // 
            // txtMailAdres
            // 
            this.txtMailAdres.Location = new System.Drawing.Point(507, 229);
            this.txtMailAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailAdres.Name = "txtMailAdres";
            this.txtMailAdres.Properties.Appearance.FontSizeDelta = 3;
            this.txtMailAdres.Properties.Appearance.Options.UseFont = true;
            this.txtMailAdres.Size = new System.Drawing.Size(228, 24);
            this.txtMailAdres.TabIndex = 2;
            // 
            // lblMailAdres
            // 
            this.lblMailAdres.Appearance.FontSizeDelta = 3;
            this.lblMailAdres.Appearance.Options.UseFont = true;
            this.lblMailAdres.Location = new System.Drawing.Point(431, 232);
            this.lblMailAdres.Margin = new System.Windows.Forms.Padding(4);
            this.lblMailAdres.Name = "lblMailAdres";
            this.lblMailAdres.Size = new System.Drawing.Size(68, 18);
            this.lblMailAdres.TabIndex = 8;
            this.lblMailAdres.Text = "Mail Adresi";
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 368);
            this.Controls.Add(this.lblMailAdres);
            this.Controls.Add(this.lblMailAdi);
            this.Controls.Add(this.txtMailAdres);
            this.Controls.Add(this.txtMailAdi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmMail.IconOptions.Icon")));
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Tanıtımı";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdres.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn mail_no;
        private DevExpress.XtraGrid.Columns.GridColumn mail_adi;
        private DevExpress.XtraGrid.Columns.GridColumn mail_adres;
        private DevExpress.XtraEditors.LabelControl lblMailAdi;
        private DevExpress.XtraEditors.TextEdit txtMailAdi;
        private DevExpress.XtraEditors.TextEdit txtMailAdres;
        private DevExpress.XtraEditors.LabelControl lblMailAdres;
    }
}