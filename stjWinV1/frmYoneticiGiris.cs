using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataLayer;

namespace stjWinV1
{
    public partial class frmYoneticiGiris : Form
    {
        public frmYoneticiGiris()
        {
            InitializeComponent();
        }
        SqlDataReader reader;
        VtProcess prc = new VtProcess();

        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool durum = true;
            bool kontrol = false;
            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox && tb.Text == String.Empty) durum = false;
            }
            if (!durum) MessageBox.Show("Boş Alan Bırakmayınız.");
            else
            {
                reader = prc.prc_TblYonetici_Select();
                while (reader.Read())
                {
                    if (reader[3].ToString() == txtKullaniciAdi.Text && reader[4].ToString() == txtParola.Text)
                    { kontrol = true; break; }

                }
                if (kontrol)
                {
                    frmHastane yeni = new frmHastane();
                    yeni.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");

            }




        }






    }
}
