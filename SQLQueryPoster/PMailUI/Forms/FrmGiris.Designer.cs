namespace PMailUI
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(178, 87);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.FontSizeDelta = 5;
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(180, 28);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(178, 121);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.FontSizeDelta = 5;
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(180, 28);
            this.txtSifre.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Appearance.FontSizeDelta = 5;
            this.btnGirisYap.Appearance.Options.UseFont = true;
            this.btnGirisYap.Location = new System.Drawing.Point(124, 182);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(120, 40);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Appearance.FontSizeDelta = 5;
            this.lblKullaniciAdi.Appearance.Options.UseFont = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(77, 90);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(95, 22);
            this.lblKullaniciAdi.TabIndex = 4;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            this.lblSifre.Appearance.FontSizeDelta = 5;
            this.lblSifre.Appearance.Options.UseFont = true;
            this.lblSifre.Location = new System.Drawing.Point(137, 124);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(35, 22);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Şifre";
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.FontSizeDelta = 5;
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.Location = new System.Drawing.Point(250, 182);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(60, 40);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 284);
            this.ControlBox = false;
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmGiris.IconOptions.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}

