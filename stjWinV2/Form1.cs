using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stjWinV2
{
    public partial class frmSecim : Form
    {
        public frmSecim()
        {
            InitializeComponent();
        }

        private void lblHasta_MouseHover(object sender, EventArgs e)
        {
            lblHasta.ForeColor = Color.Blue;
            
                
        }

        private void lblYonetici_MouseHover(object sender, EventArgs e)
        {

            lblYonetici.ForeColor = Color.Blue;

        }

        private void lblHasta_MouseLeave(object sender, EventArgs e)
        {
            lblHasta.ForeColor = Color.Black;
        }

        private void lblYonetici_MouseLeave(object sender, EventArgs e)
        {
            lblYonetici.ForeColor = Color.Black;
        }

        private void lblHasta_Click(object sender, EventArgs e)
        {
            frmHastaGirisi lblGiris = new frmHastaGirisi();
            lblGiris.Show();
            this.Hide();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            frmHastaGirisi btnGiris = new frmHastaGirisi();
            btnGiris.Show();
            this.Hide();
        }

        private void frmSecim_Load(object sender, EventArgs e)
        {

        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            frmYoneticiGiris yg = new frmYoneticiGiris();
            yg.Show();
            this.Hide();
        }
    }
}
