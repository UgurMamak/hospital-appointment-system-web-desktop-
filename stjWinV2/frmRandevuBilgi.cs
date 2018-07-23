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
    public partial class frmRandevuBilgi : Form
    {
        public frmRandevuBilgi()
        {
            InitializeComponent();
        }
        SqlDataReader reader;
        VtProcess vt = new VtProcess();
        void RandevuGoster()
        {
            reader = vt.prc_tblRandevu_select();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader[11].ToString()) == frmHastaGirisi.hastaID)
                {
                    string doktor = reader[2].ToString() + " " + reader[3].ToString();
                    string hasta = reader[4].ToString() + " " + reader[5].ToString();
                    string[] bilgiler = { reader[1].ToString(), reader[9].ToString(), doktor, hasta, reader[6].ToString(), reader[7].ToString() };
                    listView1.Items.Add(new ListViewItem(bilgiler));
                }
            }
            
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmRandevu vt = new frmRandevu();
            vt.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRandevuBilgi_Load(object sender, EventArgs e)
        {
            RandevuGoster();
        }
    }
}
