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
namespace stjWinV2
{
    public partial class frmYoneticiGiris : Form
    {
        public frmYoneticiGiris()
        {
            InitializeComponent();
        }
        VtProcess vt = new VtProcess();
        SqlDataReader reader;
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
                reader = vt.prc_TblYonetici_Select();
                while (reader.Read())
                {
                    if (reader[3].ToString() == txtKullaniciAdi.Text && reader[4].ToString() == txtParola.Text) { kontrol = true; break; }
                }
                if (kontrol)
                {
                    frmHastane rnd = new frmHastane();
                    rnd.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya parola hatalı.");
                }

            }
        }
    }
}
