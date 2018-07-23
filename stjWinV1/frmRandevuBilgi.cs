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
    public partial class frmRandevuBilgi : Form
    {
        public frmRandevuBilgi()
        {
            InitializeComponent();
        }

        VtProcess prc = new VtProcess();
        SqlDataReader reader;

        void randevulistele()
        {
            reader = prc.prc_tblRandevu_select();
            while(reader.Read())
            {
                if (Convert.ToInt32(reader[11].ToString()) == frmHastaGirisi.hastaNo)
                {
                    string doktor = reader[2].ToString() + " " + reader[3].ToString();
                    string hasta = reader[4].ToString() + " " + reader[5].ToString();
                    string[] bilgiler = { reader[1].ToString(), reader[9].ToString(), doktor, hasta, reader[6].ToString(), reader[7].ToString() };
                    lwBilgi.Items.Add(new ListViewItem(bilgiler));
                }
            }
        }


        private void frmRandevuBilgi_Load(object sender, EventArgs e)
        {
            randevulistele();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmRandevu yeni = new frmRandevu();
            yeni.Show();
            this.Close();
        }
    }
}
