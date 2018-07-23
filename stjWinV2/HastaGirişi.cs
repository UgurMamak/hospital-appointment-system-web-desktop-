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
    public partial class frmHastaGirisi : Form
    {
        public frmHastaGirisi()
        {
            InitializeComponent();
        }
        SqlDataReader reader;
        VtProcess vt = new VtProcess();
        public static int hastaID;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool durum = true;
            bool kontrol = false;
            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox && tb.Text == String.Empty) { durum = false; break; }
            }
            if (!durum)
                MessageBox.Show("Boş Alan Bırakmayınız.");
            else
            {
                reader = vt.prc_TblHasta_select();
                while (reader.Read())
                {
                    if (reader[3].ToString() == txtKullaniciAdi.Text && reader[7].ToString() == txtParola.Text)
                    { kontrol = true; hastaID = Convert.ToInt32(reader[0].ToString()); break; }
                }
                if (kontrol)
                {
                    frmRandevu rnd = new frmRandevu();
                    rnd.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya parola hatalı.");
                }
            }
        }

        private void lblKayit_Click_1(object sender, EventArgs e)
        {
            frmHastaKayit lblHastaKayıt = new frmHastaKayit();
            lblHastaKayıt.Show();
            this.Hide();
        }
    }
}
