using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using System.Data.SqlClient;


namespace stjWinV2
{
    public partial class frmHastaKayit : Form
    {
        public frmHastaKayit()
        {
            InitializeComponent();
        }

        SqlDataReader reader;
        VtProcess vt = new VtProcess();
      

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            bool durum = true;
            bool kontrol = false;
            foreach (Control tb in this.Controls)
            {
                if ((tb is TextBox || tb is DateTimePicker || tb is MaskedTextBox) && tb.Text == String.Empty) durum = false;
            }
            reader = vt.prc_TblHasta_select();
            while (reader.Read())
            {
                if (reader[3].ToString() == txtTc.Text) { MessageBox.Show("Aynı Kullanıcı adı var"); kontrol = true; break; }
            }
            if (!kontrol)
            {
                if (!durum)
                    MessageBox.Show("Boş Alan Bırakmayınız.");
                else
                {
                    if (txtSifre.Text == txtSifreTekrar.Text)
                    {
                        string cins;
                        if (rbErkek.Checked == true) cins = "E"; else cins = "K";
                        vt.prc_TblHasta_insert(txtAd.Text, txtSoyad.Text, txtTc.Text, txtTelefon.Text, DogumTarihi.Text.ToString(), cins, txtSifre.Text);
                        MessageBox.Show("Başarıyla Kaydedildi.");
                    }
                    else MessageBox.Show("Şifreler eşleşmiyor.");
                }
            }
        }
    }
    }
    
