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
    public partial class frmRandevu : Form
    {
        public frmRandevu()
        {
            InitializeComponent();
        }
        SqlDataReader reader, reader2;
        VtProcess vt = new VtProcess();

        private void button1_Click(object sender, EventArgs e)
        {

        }
        void butonSil()
        {
            reader = vt.procRandevuTarih(dizi[0], doktorID);
            while (reader.Read())
                this.Controls.Remove(this.Controls["btn" + reader[1].ToString()]);
        }
        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            butonSil();
            cmbIlce.Items.Clear();
            cmbHastane.Items.Clear();
            cmbKlinik.Items.Clear();
            cmbDoktor.Items.Clear();
            reader = vt.proc_Ilceler_Select(cmbSehir.SelectedItem.ToString());
            while (reader.Read())
            {
                cmbIlce.Items.Add(reader[2].ToString());
            }
        }

        private void frmRandevu_Load(object sender, EventArgs e)
        {
            

            dtpTarih.Format = DateTimePickerFormat.Custom;
            dtpTarih.CustomFormat = "yyyy.MM.dd";
            
            int aye, gune, yile;
            gune = DateTime.Now.Day;
            aye = DateTime.Now.Month;
            yile = DateTime.Now.Year;
            if (gune >= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
            {
                gune = gune % DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); aye = aye + 1;
                if (aye > 12) { aye = aye % 12; yile = yile + 1; }
            }
            dtpTarih.MinDate = new DateTime(yile, aye, gune + 1);
            int ay, gun, yil;
            gun = DateTime.Now.Day;
            ay = DateTime.Now.Month;
            yil = DateTime.Now.Year;
            gun = gun + 14;
            if (gun >= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
            {
                gun = gun % DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); ay = ay + 1;
                if (ay > 12) { ay = ay % 12; yil = yil + 1; }
            }
            dtpTarih.MaxDate = new DateTime(yil, ay, gun);
            reader = vt.prc_Iller_Select();
            while (reader.Read())
            {
                cmbSehir.Items.Add(reader[1].ToString());
            }
            if (dtpTarih.Value.DayOfWeek.ToString() == "Sunday") btnGun.Text = "Program";
            else if (dtpTarih.Value.DayOfWeek.ToString() == "Monday") btnGun.Text = "Program";
            else if (dtpTarih.Value.DayOfWeek.ToString() == "Tuesday") btnGun.Text = "Program";
            else if (dtpTarih.Value.DayOfWeek.ToString() == "Wednesday") btnGun.Text = "Program";
            else if (dtpTarih.Value.DayOfWeek.ToString() == "Thursday") btnGun.Text = "Program";
            else if (dtpTarih.Value.DayOfWeek.ToString() == "Friday") btnGun.Text = "Program";
            else btnGun.Text = "Program";
        }
        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            butonSil();
            cmbKlinik.Items.Clear();
            cmbDoktor.Items.Clear(); cmbHastane.Items.Clear();
            reader = vt.prc_TblHastane_selectById(cmbSehir.SelectedItem.ToString(), cmbIlce.SelectedItem.ToString());
            while (reader.Read())
            {
                cmbHastane.Items.Add(reader[3].ToString());
            }
        }
        int hastaneid;
        void hastanedekiBolumler()
        {
            reader = vt.prc_TblHastanedekiBolumler_Select();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader[1].ToString()) == hastaneid)
                    cmbKlinik.Items.Add(reader[3].ToString());
            }
        }
        private void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            butonSil();
            cmbKlinik.Items.Clear();
            cmbDoktor.Items.Clear();
            reader = vt.prc_TblHastane_selectById(cmbSehir.SelectedItem.ToString(), cmbIlce.SelectedItem.ToString());
            while (reader.Read())
            {
                if (cmbHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneid = Convert.ToInt32(reader[0].ToString());
            }
            hastanedekiBolumler();

        }
        int klinikID;
        private void cmbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            butonSil();
                reader = vt.prc_TblPoliklinik_Select(); ;
            while (reader.Read())
            {
                if (cmbKlinik.SelectedItem.ToString() == reader[1].ToString())
                {
                    klinikID = Convert.ToInt32(reader[0].ToString());
                }
            }
            cmbDoktor.Items.Clear(); 
            reader = vt.prc_tblDoktor_select();
            while (reader.Read())
            {
                if (hastaneid == Convert.ToInt32(reader[5].ToString()) && reader[4].ToString() == cmbKlinik.SelectedItem.ToString())
                    cmbDoktor.Items.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
        }
        int doktorID;
        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            butonSil();
            reader = vt.prc_tblDoktor_select();
            while (reader.Read())
            {
                if (cmbDoktor.SelectedItem.ToString() == reader[1] + " " + reader[2])
                {
                    doktorID = Convert.ToInt32(reader[0].ToString());
                }
            }
        }
        int bak = 0;
       
        string[] dizi = new string[2];
        void olustur()
        {
            int sat = 0, x = 244, i = 0;
            reader = vt.procRandevuTarih(dtpTarih.Text, doktorID);
            while (reader.Read())
            {
                if (sat < 5)
                {
                    Button btn = new Button();
                    btn.Location = new System.Drawing.Point(x, i * 30 + 35);
                    btn.Name = "btn" + reader[1].ToString();
                    btn.Size = new System.Drawing.Size(50, 23);//butonun boyutu 
                    btn.Text = reader[1].ToString();
                    btn.Font = new Font(btn.Font, btn.Font.Style ^ FontStyle.Bold);
                 
                    reader2 = vt.prc_tblRandevu_select();
                    while (reader2.Read())
                    {
                        if (reader2[6].ToString() == dtpTarih.Text&& btn.Text==reader2[7].ToString()) { btn.Enabled = false; btn.BackColor = Color.Red;break; }
                        else { btn.Enabled = true; btn.BackColor = Color.Green; }
                    }
                    this.Controls.Add(btn);

                    btn.Click += new EventHandler(dinamikMetod);
                    i++;
                    sat++;
                 
                }
                else
                {
                    Button btn = new Button();
                    btn.Location = new System.Drawing.Point(x, i * 30 + 35);
                    btn.Name = "btn" + reader[1].ToString();
                    btn.Size = new System.Drawing.Size(50, 23);
                    btn.Text = reader[1].ToString();
                    btn.Font = new Font(btn.Font, btn.Font.Style ^ FontStyle.Bold);
                  
                    reader2 = vt.prc_tblRandevu_select();
                    while (reader2.Read())
                    {
                        if (reader2[6].ToString() == dtpTarih.Text && btn.Text+"" == reader2[7].ToString()) { btn.Enabled = false; btn.BackColor = Color.Red;break; }
                        else { btn.Enabled = true; btn.BackColor = Color.Green; }
                    }
                    this.Controls.Add(btn);
                  
                    x = x + 90; i = 0; sat = 0;

                }
            }

        }
        protected void dinamikMetod(object sender, EventArgs e)
        {

            Button dinamikButon = (sender as Button);
      
            bool durum = true;
            foreach (Control tb in this.Controls)
                if ((tb is ComboBox) && (tb.Text == String.Empty)) durum = false;
            if (durum)
            {

                DialogResult dr = MessageBox.Show("Seçili randevuyu almak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    vt.prc_tblRandevu_insert(hastaneid, klinikID, doktorID, dtpTarih.Text, dinamikButon.Text, txtAciklama.Text, frmHastaGirisi.hastaID);
                    MessageBox.Show("Randevu alındı.");
                    cmbIlce.Items.Clear();
                    cmbHastane.Items.Clear();
                    cmbKlinik.Items.Clear();
                    cmbDoktor.Items.Clear();
                    dtpTarih.Text = "";
                    butonSil();
                    txtAciklama.Text = "";
                }
                else MessageBox.Show("İşleminiz iptal edildi.");
            }
            else MessageBox.Show("Boş Alan Bırakmayınız.");



        }
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            if (bak == 0)
            {
                dizi[0] = dtpTarih.Text;
                olustur();
                bak = 1;
            }
            else
            {
                reader = vt.procRandevuTarih(dizi[0], doktorID);
                while (reader.Read())
                    this.Controls.Remove(this.Controls["btn" + reader[1].ToString()]);
                olustur();
                dizi[0] = dtpTarih.Text;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmRandevuBilgi vt = new frmRandevuBilgi();
            vt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSecim vt = new frmSecim();
            vt.Show();
            this.Hide();
        }

        private void dtpTarih_ValueChanged_1(object sender, EventArgs e)
        {
            bool durum = true;
            foreach (Control tb in this.Controls)
                if ((tb is ComboBox) && (tb.Text == String.Empty)) durum = false;
            if (durum)
            {
                if (dtpTarih.Value.DayOfWeek.ToString() == "Sunday") btnGun.Text = "Pazar";
                else if (dtpTarih.Value.DayOfWeek.ToString() == "Monday") btnGun.Text = "Pazartesi";
                else if (dtpTarih.Value.DayOfWeek.ToString() == "Tuesday") btnGun.Text = "Salı";
                else if (dtpTarih.Value.DayOfWeek.ToString() == "Wednesday") btnGun.Text = "Çarşamba";
                else if (dtpTarih.Value.DayOfWeek.ToString() == "Thursday") btnGun.Text = "Perşembe";
                else if (dtpTarih.Value.DayOfWeek.ToString() == "Friday") btnGun.Text = "Cuma";
                else btnGun.Text = "Cumartesi";

                if (bak == 0)
                {
                    dizi[0] = dtpTarih.Text;
                    olustur();
                    bak = 1;
                }

                else
                {
                    butonSil();
                    olustur();
                    dizi[0] = dtpTarih.Text;
                }
            }
            else btnGun.Text = "Program";
            }


        }

        
    }

