namespace PMailUI.Forms
{
    partial class FrmYetki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYetki));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.goster = new DevExpress.XtraGrid.Columns.GridColumn();
            this.degistir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.excel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblSorguAdi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(839, 421);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.adi,
            this.goster,
            this.degistir,
            this.sil,
            this.excel,
            this.mail});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // adi
            // 
            this.adi.Caption = "Kullanıcı Adı";
            this.adi.FieldName = "adi";
            this.adi.Name = "adi";
            this.adi.Visible = true;
            this.adi.VisibleIndex = 0;
            // 
            // goster
            // 
            this.goster.Caption = "Göster";
            this.goster.FieldName = "goster";
            this.goster.Name = "goster";
            this.goster.Visible = true;
            this.goster.VisibleIndex = 1;
            // 
            // degistir
            // 
            this.degistir.Caption = "Düzenle";
            this.degistir.FieldName = "degistir";
            this.degistir.Name = "degistir";
            this.degistir.Visible = true;
            this.degistir.VisibleIndex = 2;
            // 
            // sil
            // 
            this.sil.Caption = "Sil";
            this.sil.FieldName = "sil";
            this.sil.Name = "sil";
            this.sil.Visible = true;
            this.sil.VisibleIndex = 3;
            // 
            // excel
            // 
            this.excel.Caption = "Excel Aktar";
            this.excel.FieldName = "excel";
            this.excel.Name = "excel";
            this.excel.Visible = true;
            this.excel.VisibleIndex = 4;
            // 
            // mail
            // 
            this.mail.Caption = "Mail Gönder";
            this.mail.FieldName = "mail";
            this.mail.Name = "mail";
            this.mail.Visible = true;
            this.mail.VisibleIndex = 5;
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.FontSizeDelta = 3;
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKapat.ImageOptions.SvgImage = global::PMailUI.Properties.Resources.delete;
            this.btnKapat.Location = new System.Drawing.Point(794, 13);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(60, 80);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.FontSizeDelta = 3;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKaydet.ImageOptions.SvgImage = global::PMailUI.Properties.Resources.bo_validation;
            this.btnKaydet.Location = new System.Drawing.Point(726, 13);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(60, 80);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 100);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(843, 446);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Bağlı Sorgu Yetki Listesi";
            // 
            // lblSorguAdi
            // 
            this.lblSorguAdi.Appearance.FontSizeDelta = 3;
            this.lblSorguAdi.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.lblSorguAdi.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.lblSorguAdi.Appearance.Options.UseFont = true;
            this.lblSorguAdi.Appearance.Options.UseForeColor = true;
            this.lblSorguAdi.Location = new System.Drawing.Point(41, 34);
            this.lblSorguAdi.Name = "lblSorguAdi";
            this.lblSorguAdi.Size = new System.Drawing.Size(14, 18);
            this.lblSorguAdi.TabIndex = 3;
            this.lblSorguAdi.Text = "\"\"";
            // 
            // FrmYetki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 558);
            this.Controls.Add(this.lblSorguAdi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmYetki.IconOptions.Icon")));
            this.Name = "FrmYetki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetki Tanıtımı";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn adi;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn goster;
        private DevExpress.XtraGrid.Columns.GridColumn degistir;
        private DevExpress.XtraGrid.Columns.GridColumn sil;
        private DevExpress.XtraGrid.Columns.GridColumn excel;
        private DevExpress.XtraGrid.Columns.GridColumn mail;
        private DevExpress.XtraEditors.LabelControl lblSorguAdi;
    }
}