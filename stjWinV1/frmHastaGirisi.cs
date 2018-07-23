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
    public partial class frmHastaGirisi : Form
    {
        public frmHastaGirisi()
        {
            InitializeComponent();
        }

        VtProcess prc = new VtProcess();
        SqlDataReader reader;
        public static int hastaNo;

        private void lblKayit_Click(object sender, EventArgs e)
        {
            frmHastaKayit yeni = new frmHastaKayit();
            yeni.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool durum = true;
            bool kontrol = false;
            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox  && tb.Text == String.Empty) durum = false;
            }
            if (!durum) MessageBox.Show("Boş Alan Bırakmayınız.");
            else
            {
                reader = prc.prc_TblHasta_select();
                while (reader.Read())
                {
                    if (reader[3].ToString() == txtKullaniciAdi.Text && reader[7].ToString() == txtParola.Text)
                    { kontrol = true; hastaNo = Convert.ToInt32(reader[0].ToString()); break; }
                }
                if (kontrol)
                {
                    frmRandevu randevu = new frmRandevu();
                    randevu.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");

            }



        }
    }
}
