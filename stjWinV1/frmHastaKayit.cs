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
//uğur
namespace stjWinV1
{
    public partial class frmHastaKayit : Form
    {
        public frmHastaKayit()
        {
            InitializeComponent();
        }
        VtProcess prc = new VtProcess();
        SqlDataReader reader;
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
                    
         bool durum = true;
         bool kontrol = false;
            foreach (Control tb in this.Controls)
         {
             if ((tb is TextBox|| tb is DateTimePicker || tb is MaskedTextBox)&& tb.Text == String.Empty) durum =false;            
         }                                          
            reader = prc.prc_TblHasta_select();
            while (reader.Read())
            { if (reader[3].ToString() == txtTc.Text) { MessageBox.Show("Aynı Kullanıcı adı var"); kontrol = true; break; } }                    
            if (!kontrol)
            {
                if (!durum)
                    MessageBox.Show("Boş Alan Bırakmayınız.");
                else
                {
                    if (txtSıfre.Text == txtSıfreTekrar.Text)
                    {
                        string cins;
                        if (rbErkek.Checked == true) cins = "E"; else cins = "K";
                        prc.prc_TblHasta_insert(txtAd.Text, txtSoyad.Text, txtTc.Text, txtTelefon.Text, DogumTarihi.Text.ToString(), cins, txtSıfre.Text);
                        MessageBox.Show("Başarıyla Kaydedildi.");
                    }
                    else MessageBox.Show("Şifreler eşleşmiyor.");
                }
            }
            
        }
     
    }
}
