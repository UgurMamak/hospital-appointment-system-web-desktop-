namespace stjWinV1
{
    partial class frmRandevuBilgi
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
            this.lwBilgi = new System.Windows.Forms.ListView();
            this.chHastaneAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDoktorAdsoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHastaAdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRandevuTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lwBilgi
            // 
            this.lwBilgi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chHastaneAdi,
            this.chPol,
            this.chDoktorAdsoyad,
            this.chHastaAdSoyad,
            this.chRandevuTarih,
            this.chSaat});
            this.lwBilgi.Location = new System.Drawing.Point(12, 33);
            this.lwBilgi.Name = "lwBilgi";
            this.lwBilgi.Size = new System.Drawing.Size(632, 276);
            this.lwBilgi.TabIndex = 0;
            this.lwBilgi.UseCompatibleStateImageBehavior = false;
            this.lwBilgi.View = System.Windows.Forms.View.Details;
            // 
            // chHastaneAdi
            // 
            this.chHastaneAdi.Text = "Hastane";
            this.chHastaneAdi.Width = 145;
            // 
            // chDoktorAdsoyad
            // 
            this.chDoktorAdsoyad.DisplayIndex = 1;
            this.chDoktorAdsoyad.Text = "Doktor Adı Soyadı";
            this.chDoktorAdsoyad.Width = 100;
            // 
            // chHastaAdSoyad
            // 
            this.chHastaAdSoyad.DisplayIndex = 2;
            this.chHastaAdSoyad.Text = "Hasta Adı Soyadı";
            this.chHastaAdSoyad.Width = 100;
            // 
            // chRandevuTarih
            // 
            this.chRandevuTarih.DisplayIndex = 3;
            this.chRandevuTarih.Text = "RandevuTarihi";
            this.chRandevuTarih.Width = 100;
            // 
            // chSaat
            // 
            this.chSaat.DisplayIndex = 4;
            this.chSaat.Text = "Randevu Saati";
            this.chSaat.Width = 100;
            // 
            // chPol
            // 
            this.chPol.DisplayIndex = 5;
            this.chPol.Text = "Klinik";
            this.chPol.Width = 70;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(12, 4);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 23);
            this.btnGeriDon.TabIndex = 1;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // frmRandevuBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 321);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lwBilgi);
            this.Name = "frmRandevuBilgi";
            this.Text = "frmRandevuBilgi";
            this.Load += new System.EventHandler(this.frmRandevuBilgi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwBilgi;
        private System.Windows.Forms.ColumnHeader chHastaneAdi;
        private System.Windows.Forms.ColumnHeader chDoktorAdsoyad;
        private System.Windows.Forms.ColumnHeader chHastaAdSoyad;
        private System.Windows.Forms.ColumnHeader chRandevuTarih;
        private System.Windows.Forms.ColumnHeader chSaat;
        private System.Windows.Forms.ColumnHeader chPol;
        private System.Windows.Forms.Button btnGeriDon;
    }
}