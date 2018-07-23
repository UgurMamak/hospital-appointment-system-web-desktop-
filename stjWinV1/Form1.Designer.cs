namespace stjWinV1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblYonetici = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.btnHasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYonetici
            // 
            this.lblYonetici.AutoSize = true;
            this.lblYonetici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYonetici.Location = new System.Drawing.Point(171, 158);
            this.lblYonetici.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYonetici.Name = "lblYonetici";
            this.lblYonetici.Size = new System.Drawing.Size(94, 17);
            this.lblYonetici.TabIndex = 7;
            this.lblYonetici.Text = "Yönetici Girişi";
            this.lblYonetici.Click += new System.EventHandler(this.lblYonetici_Click);
            this.lblYonetici.MouseLeave += new System.EventHandler(this.lblYonetici_MouseLeave);
            this.lblYonetici.MouseHover += new System.EventHandler(this.lblYonetici_MouseHover);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHasta.Location = new System.Drawing.Point(65, 158);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(81, 17);
            this.lblHasta.TabIndex = 6;
            this.lblHasta.Text = "Hasta Girişi";
            this.lblHasta.Click += new System.EventHandler(this.lblHasta_Click);
            this.lblHasta.MouseLeave += new System.EventHandler(this.lblHasta_MouseLeave);
            this.lblHasta.MouseHover += new System.EventHandler(this.lblHasta_MouseHover);
            // 
            // btnYonetici
            // 
            this.btnYonetici.BackColor = System.Drawing.Color.White;
            this.btnYonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYonetici.BackgroundImage")));
            this.btnYonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYonetici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYonetici.Location = new System.Drawing.Point(177, 76);
            this.btnYonetici.Margin = new System.Windows.Forms.Padding(2);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(74, 80);
            this.btnYonetici.TabIndex = 5;
            this.btnYonetici.UseVisualStyleBackColor = false;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // btnHasta
            // 
            this.btnHasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHasta.BackgroundImage")));
            this.btnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHasta.Location = new System.Drawing.Point(66, 76);
            this.btnHasta.Margin = new System.Windows.Forms.Padding(2);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(74, 80);
            this.btnHasta.TabIndex = 4;
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 250);
            this.Controls.Add(this.lblYonetici);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.btnYonetici);
            this.Controls.Add(this.btnHasta);
            this.Name = "Form1";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYonetici;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnHasta;
    }
}

