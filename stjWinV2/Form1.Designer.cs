namespace stjWinV2
{
    partial class frmSecim
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecim));
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblYonetici = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHasta
            // 
            this.btnHasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHasta.BackgroundImage")));
            this.btnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHasta.Location = new System.Drawing.Point(71, 118);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(99, 98);
            this.btnHasta.TabIndex = 0;
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnYonetici
            // 
            this.btnYonetici.BackColor = System.Drawing.Color.White;
            this.btnYonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYonetici.BackgroundImage")));
            this.btnYonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYonetici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYonetici.Location = new System.Drawing.Point(218, 118);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(99, 98);
            this.btnYonetici.TabIndex = 1;
            this.btnYonetici.UseVisualStyleBackColor = false;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHasta.Location = new System.Drawing.Point(70, 219);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(99, 20);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta Girişi";
            this.lblHasta.Click += new System.EventHandler(this.lblHasta_Click);
            this.lblHasta.MouseLeave += new System.EventHandler(this.lblHasta_MouseLeave);
            this.lblHasta.MouseHover += new System.EventHandler(this.lblHasta_MouseHover);
            // 
            // lblYonetici
            // 
            this.lblYonetici.AutoSize = true;
            this.lblYonetici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYonetici.Location = new System.Drawing.Point(211, 219);
            this.lblYonetici.Name = "lblYonetici";
            this.lblYonetici.Size = new System.Drawing.Size(113, 20);
            this.lblYonetici.TabIndex = 3;
            this.lblYonetici.Text = "Yönetici Girişi";
            this.lblYonetici.MouseLeave += new System.EventHandler(this.lblYonetici_MouseLeave);
            this.lblYonetici.MouseHover += new System.EventHandler(this.lblYonetici_MouseHover);
            // 
            // frmSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(390, 358);
            this.Controls.Add(this.lblYonetici);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.btnYonetici);
            this.Controls.Add(this.btnHasta);
            this.Name = "frmSecim";
            this.Text = "Seçim";
            this.Load += new System.EventHandler(this.frmSecim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblYonetici;
    }
}

