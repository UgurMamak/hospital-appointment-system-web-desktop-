namespace stjWinV2
{
    partial class frmRandevu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.cmbKlinik = new System.Windows.Forms.ComboBox();
            this.cmbHastane = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlçe:";
            // 
            // cmbSehir
            // 
            this.cmbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(114, 41);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(152, 24);
            this.cmbSehir.TabIndex = 1;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // cmbIlce
            // 
            this.cmbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(114, 75);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(152, 24);
            this.cmbIlce.TabIndex = 2;
            this.cmbIlce.SelectedIndexChanged += new System.EventHandler(this.cmbIlce_SelectedIndexChanged);
            // 
            // cmbKlinik
            // 
            this.cmbKlinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlinik.FormattingEnabled = true;
            this.cmbKlinik.Location = new System.Drawing.Point(114, 150);
            this.cmbKlinik.Name = "cmbKlinik";
            this.cmbKlinik.Size = new System.Drawing.Size(152, 24);
            this.cmbKlinik.TabIndex = 4;
            this.cmbKlinik.SelectedIndexChanged += new System.EventHandler(this.cmbKlinik_SelectedIndexChanged);
            // 
            // cmbHastane
            // 
            this.cmbHastane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHastane.FormattingEnabled = true;
            this.cmbHastane.Location = new System.Drawing.Point(114, 112);
            this.cmbHastane.Name = "cmbHastane";
            this.cmbHastane.Size = new System.Drawing.Size(152, 24);
            this.cmbHastane.TabIndex = 3;
            this.cmbHastane.SelectedIndexChanged += new System.EventHandler(this.cmbHastane_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Klinik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hastane:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tarih:";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(114, 186);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(152, 24);
            this.cmbDoktor.TabIndex = 5;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(114, 260);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(152, 110);
            this.txtAciklama.TabIndex = 7;
            this.txtAciklama.Text = "";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(114, 224);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(152, 22);
            this.dtpTarih.TabIndex = 6;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 36);
            this.label7.TabIndex = 18;
            this.label7.Text = "Randevu \r\nAçıklama:\r\n";
            // 
            // btnGun
            // 
            this.btnGun.BackColor = System.Drawing.Color.White;
            this.btnGun.Enabled = false;
            this.btnGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGun.Location = new System.Drawing.Point(324, 4);
            this.btnGun.Name = "btnGun";
            this.btnGun.Size = new System.Drawing.Size(108, 28);
            this.btnGun.TabIndex = 31;
            this.btnGun.Text = "Program";
            this.btnGun.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(114, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 59);
            this.button1.TabIndex = 32;
            this.button1.Text = "Randevu Geçmişi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 59);
            this.button2.TabIndex = 33;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbKlinik);
            this.Controls.Add(this.cmbHastane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIlce);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRandevu";
            this.Text = "Randevu Ekranı";
            this.Load += new System.EventHandler(this.frmRandevu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.ComboBox cmbKlinik;
        private System.Windows.Forms.ComboBox cmbHastane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}