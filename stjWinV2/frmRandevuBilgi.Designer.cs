namespace stjWinV2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.chHastaneAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDoktorAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHastaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChRandevuTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRandevuSaati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKlinikAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chHastaneAdi,
            this.chKlinikAdi,
            this.chDoktorAdi,
            this.chHastaAdi,
            this.ChRandevuTarihi,
            this.chRandevuSaati});
            this.listView1.Location = new System.Drawing.Point(1, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(799, 393);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chHastaneAdi
            // 
            this.chHastaneAdi.Text = "Hastane Adı";
            this.chHastaneAdi.Width = 93;
            // 
            // chDoktorAdi
            // 
            this.chDoktorAdi.DisplayIndex = 1;
            this.chDoktorAdi.Text = "Doktor Adı";
            this.chDoktorAdi.Width = 91;
            // 
            // chHastaAdi
            // 
            this.chHastaAdi.DisplayIndex = 2;
            this.chHastaAdi.Text = "Hasta Adı";
            this.chHastaAdi.Width = 84;
            // 
            // ChRandevuTarihi
            // 
            this.ChRandevuTarihi.DisplayIndex = 3;
            this.ChRandevuTarihi.Text = "Randevu Tarihi";
            this.ChRandevuTarihi.Width = 111;
            // 
            // chRandevuSaati
            // 
            this.chRandevuSaati.DisplayIndex = 4;
            this.chRandevuSaati.Text = "Randevu Saati";
            this.chRandevuSaati.Width = 106;
            // 
            // chKlinikAdi
            // 
            this.chKlinikAdi.DisplayIndex = 5;
            this.chKlinikAdi.Text = "Klinik Adı";
            this.chKlinikAdi.Width = 91;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(129, 47);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmRandevuBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.listView1);
            this.Name = "frmRandevuBilgi";
            this.Text = "frmRandevuBilgi";
            this.Load += new System.EventHandler(this.frmRandevuBilgi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chHastaneAdi;
        private System.Windows.Forms.ColumnHeader chKlinikAdi;
        private System.Windows.Forms.ColumnHeader chDoktorAdi;
        private System.Windows.Forms.ColumnHeader chHastaAdi;
        private System.Windows.Forms.ColumnHeader ChRandevuTarihi;
        private System.Windows.Forms.ColumnHeader chRandevuSaati;
        private System.Windows.Forms.Button btnGeri;
    }
}