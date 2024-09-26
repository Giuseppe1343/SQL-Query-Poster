namespace PMailUI.Forms
{
    partial class FrmMailGonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMailGonder));
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnMail = new DevExpress.XtraEditors.SimpleButton();
            this.lblMailAlici = new DevExpress.XtraEditors.LabelControl();
            this.lueMailAlici = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.chcHTML = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMailAlici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcHTML.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.FontSizeDelta = 3;
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(325, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(60, 80);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            // 
            // btnMail
            // 
            this.btnMail.Appearance.FontSizeDelta = 3;
            this.btnMail.Appearance.Options.UseFont = true;
            this.btnMail.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnMail.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMail.ImageOptions.SvgImage")));
            this.btnMail.Location = new System.Drawing.Point(257, 0);
            this.btnMail.Margin = new System.Windows.Forms.Padding(4);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(60, 80);
            this.btnMail.TabIndex = 2;
            this.btnMail.Text = "Mail At";
            // 
            // lblMailAlici
            // 
            this.lblMailAlici.Appearance.FontSizeDelta = 3;
            this.lblMailAlici.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.lblMailAlici.Appearance.Options.UseFont = true;
            this.lblMailAlici.Location = new System.Drawing.Point(70, 50);
            this.lblMailAlici.Margin = new System.Windows.Forms.Padding(4);
            this.lblMailAlici.Name = "lblMailAlici";
            this.lblMailAlici.Size = new System.Drawing.Size(100, 18);
            this.lblMailAlici.TabIndex = 4;
            this.lblMailAlici.Text = "Mail Alıcı Seç";
            // 
            // lueMailAlici
            // 
            this.lueMailAlici.Location = new System.Drawing.Point(13, 125);
            this.lueMailAlici.Margin = new System.Windows.Forms.Padding(4);
            this.lueMailAlici.Name = "lueMailAlici";
            this.lueMailAlici.Properties.AllowMultiSelect = true;
            this.lueMailAlici.Properties.Appearance.FontSizeDelta = 3;
            this.lueMailAlici.Properties.Appearance.Options.UseFont = true;
            this.lueMailAlici.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMailAlici.Size = new System.Drawing.Size(372, 24);
            this.lueMailAlici.TabIndex = 0;
            // 
            // chcHTML
            // 
            this.chcHTML.Location = new System.Drawing.Point(277, 92);
            this.chcHTML.Name = "chcHTML";
            this.chcHTML.Properties.Appearance.FontSizeDelta = 3;
            this.chcHTML.Properties.Appearance.Options.UseFont = true;
            this.chcHTML.Properties.Caption = "HTML Tablo";
            this.chcHTML.Size = new System.Drawing.Size(108, 22);
            this.chcHTML.TabIndex = 1;
            // 
            // FrmMailGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 168);
            this.Controls.Add(this.chcHTML);
            this.Controls.Add(this.lblMailAlici);
            this.Controls.Add(this.lueMailAlici);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnMail);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmMailGonder.IconOptions.Icon")));
            this.Name = "FrmMailGonder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönder";
            ((System.ComponentModel.ISupportInitialize)(this.lueMailAlici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcHTML.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnMail;
        private DevExpress.XtraEditors.LabelControl lblMailAlici;
        private DevExpress.XtraEditors.CheckedComboBoxEdit lueMailAlici;
        private DevExpress.XtraEditors.CheckEdit chcHTML;
    }
}