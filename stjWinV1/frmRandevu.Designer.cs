namespace stjWinV1
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
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKlinik = new System.Windows.Forms.ComboBox();
            this.cmbHastane = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGun = new System.Windows.Forms.Button();
            this.btnanasayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(107, 151);
            this.cmbDoktor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(115, 21);
            this.cmbDoktor.TabIndex = 4;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // dtpTarih
            // 
            this.dtpTarih.CustomFormat = "";
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(107, 182);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(115, 20);
            this.dtpTarih.TabIndex = 5;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Doktor:";
            // 
            // cmbKlinik
            // 
            this.cmbKlinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlinik.FormattingEnabled = true;
            this.cmbKlinik.Location = new System.Drawing.Point(107, 119);
            this.cmbKlinik.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKlinik.Name = "cmbKlinik";
            this.cmbKlinik.Size = new System.Drawing.Size(115, 21);
            this.cmbKlinik.TabIndex = 3;
            this.cmbKlinik.SelectedIndexChanged += new System.EventHandler(this.cmbKlinik_SelectedIndexChanged);
            // 
            // cmbHastane
            // 
            this.cmbHastane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHastane.FormattingEnabled = true;
            this.cmbHastane.Location = new System.Drawing.Point(107, 88);
            this.cmbHastane.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHastane.Name = "cmbHastane";
            this.cmbHastane.Size = new System.Drawing.Size(115, 21);
            this.cmbHastane.TabIndex = 2;
            this.cmbHastane.SelectedIndexChanged += new System.EventHandler(this.cmbHastane_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Klinik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(43, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hastane:";
            // 
            // cmbIlce
            // 
            this.cmbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(107, 58);
            this.cmbIlce.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(115, 21);
            this.cmbIlce.TabIndex = 1;
            this.cmbIlce.SelectedIndexChanged += new System.EventHandler(this.cmbIlce_SelectedIndexChanged);
            // 
            // cmbSehir
            // 
            this.cmbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(107, 30);
            this.cmbSehir.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(115, 21);
            this.cmbSehir.TabIndex = 0;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "İlçe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Şehir:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(109, 224);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(117, 79);
            this.txtAciklama.TabIndex = 6;
            this.txtAciklama.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(47, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Açıklama";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 29;
            this.button1.Text = "Randevu Geçmişi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGun
            // 
            this.btnGun.Enabled = false;
            this.btnGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGun.Location = new System.Drawing.Point(244, 7);
            this.btnGun.Name = "btnGun";
            this.btnGun.Size = new System.Drawing.Size(120, 28);
            this.btnGun.TabIndex = 31;
            this.btnGun.Text = "Günler";
            this.btnGun.UseVisualStyleBackColor = true;
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.Location = new System.Drawing.Point(-1, -1);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(102, 28);
            this.btnanasayfa.TabIndex = 32;
            this.btnanasayfa.Text = "AnaSayfayaDön";
            this.btnanasayfa.UseVisualStyleBackColor = true;
            this.btnanasayfa.Click += new System.EventHandler(this.btnanasayfa_Click);
            // 
            // frmRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 367);
            this.Controls.Add(this.btnanasayfa);
            this.Controls.Add(this.btnGun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label7);
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
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.frmRandevu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKlinik;
        private System.Windows.Forms.ComboBox cmbHastane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGun;
        private System.Windows.Forms.Button btnanasayfa;
    }
}