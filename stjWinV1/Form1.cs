using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//uğur
namespace stjWinV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            frmHastaGirisi yeni = new frmHastaGirisi();
            yeni.Show();
            this.Hide();
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
            frmHastaGirisi yeni = new frmHastaGirisi();
            yeni.Show();
            this.Hide();

        }

        private void lblYonetici_Click(object sender, EventArgs e)
        {
            frmYoneticiGiris yeni = new frmYoneticiGiris();
            yeni.Show();
            this.Hide();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            frmYoneticiGiris yeni = new frmYoneticiGiris();
            yeni.Show();
            this.Hide();
        }
    }
}
