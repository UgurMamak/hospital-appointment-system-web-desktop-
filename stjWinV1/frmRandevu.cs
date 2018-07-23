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
    public partial class frmRandevu : Form
    {
        public frmRandevu()
        {
            InitializeComponent();
        }
        VtProcess prc = new VtProcess();
        SqlDataReader reader,reader2;
        int hastaneId,doktorId,polId;
        int bak = 0;
        
        string[] dizi = new string[2];   

        void olustur()
        {
            
            int sat = 0,x = 244, i = 0;
                reader = prc.procRandevuTarih(dtpTarih.Text, doktorId);          
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
                    btn.BackColor = Color.Azure;
                    this.Controls.Add(btn);               
                    reader2 = prc.prc_tblRandevu_select();
                    while (reader2.Read())
                    {                      
                        if (reader2[6].ToString() == dtpTarih.Text && btn.Text==reader2[7].ToString() )
                        { btn.Enabled = false; btn.BackColor = Color.Red; break; }
                        else { btn.Enabled = true; }
                    }

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
                    btn.BackColor = Color.Azure;
                    this.Controls.Add(btn);
                    reader2 = prc.prc_tblRandevu_select();
                    while (reader2.Read())
                    {
                        if (reader2[6].ToString() == dtpTarih.Text && btn.Text == reader2[7].ToString())
                        { btn.Enabled = false; btn.BackColor = Color.Red; break; }
                        else { btn.Enabled = true;  }
                    }                                       
                    btn.Click += new EventHandler(dinamikMetod);
                    btn.Click += new EventHandler(dinamikMetod);
                    x = x + 62;  i = 0;sat = 0;
                
                }                     
                }                                   
        }

        void butonSil()
        {
            reader = prc.procRandevuTarih(dizi[0], doktorId);
            while (reader.Read())
                this.Controls.Remove(this.Controls["btn" + reader[1].ToString()]);
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
            reader =prc.prc_Iller_Select();
            while (reader.Read())
                cmbSehir.Items.Add(reader[1].ToString());                        
          
        }
        

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            butonSil();
            cmbIlce.Items.Clear();
            cmbKlinik.Items.Clear();
            cmbHastane.Items.Clear();
            cmbDoktor.Items.Clear();
            reader = prc.proc_Ilceler_Select(cmbSehir.SelectedItem.ToString());
            while (reader.Read()) cmbIlce.Items.Add(reader[2].ToString());
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            butonSil();
            cmbKlinik.Items.Clear();
            cmbHastane.Items.Clear();
            cmbDoktor.Items.Clear();
            reader = prc.prc_TblHastane_selectById(cmbSehir.SelectedItem.ToString(),cmbIlce.SelectedItem.ToString());                           
                while (reader.Read()) cmbHastane.Items.Add(reader[3].ToString());
            
        }

        private void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            butonSil();
            cmbKlinik.Items.Clear();
            cmbDoktor.Items.Clear();
            reader = prc.prc_TblHastane_selectById(cmbSehir.SelectedItem.ToString(), cmbIlce.SelectedItem.ToString());
            while (reader.Read())
                if (cmbHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneId = Convert.ToInt32(reader[0].ToString());

            reader = prc.prc_TblHastanedekiBolumler_Select();
            while (reader.Read())
                if (Convert.ToInt32(reader[1].ToString()) == hastaneId)
                    cmbKlinik.Items.Add(reader[3].ToString());
        } 
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            bool durum = true;
            foreach (Control tb in this.Controls)
                if (tb is ComboBox && (tb.Text == String.Empty)) durum = false;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRandevuBilgi yeni = new frmRandevuBilgi();
            yeni.Show();
            this.Hide();
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Close();
        }

        private void cmbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            butonSil();
            reader = prc.prc_TblPoliklinik_Select();
            while (reader.Read())
                if (reader[1].ToString() == cmbKlinik.SelectedItem.ToString())
                    polId = Convert.ToInt32(reader[0].ToString());

            cmbDoktor.Items.Clear();
            reader = prc.prc_tblDoktor_select();
            while (reader.Read())
                if (Convert.ToInt32(reader[5].ToString()) == hastaneId && cmbKlinik.SelectedItem.ToString() == reader[4].ToString())
                    cmbDoktor.Items.Add(reader[1].ToString() + " " + reader[2].ToString());
        
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            butonSil();
            reader=prc.prc_tblDoktor_select();
            while(reader.Read())
                if(cmbDoktor.SelectedItem.ToString()==reader[1].ToString()+" "+reader[2].ToString())
                    doktorId=Convert.ToInt32(reader[0].ToString());        
        }

        protected void dinamikMetod(object sender, EventArgs e)
        {

            Button dinamikButon = (sender as Button);
          //  MessageBox.Show(dinamikButon.Text + " isimli butona tıkladınız");
            bool durum = true;
            foreach (Control tb in this.Controls)            
            if (tb is ComboBox && (tb.Text == String.Empty)) durum = false;
                if (durum)
                {
                
                DialogResult dr = MessageBox.Show("Bu saate randevu almak istediğinize emin misiniz","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                    prc.prc_tblRandevu_insert(hastaneId,polId,doktorId,dtpTarih.Text,dinamikButon.Text,txtAciklama.Text,frmHastaGirisi.hastaNo);                 
                    MessageBox.Show("Randevu alındı.");                    
                    cmbSehir.Text ="";
                    cmbIlce.Items.Clear();
                    cmbHastane.Items.Clear();
                    cmbDoktor.Items.Clear();
                    cmbKlinik.Items.Clear();
                    txtAciklama.Text = "";
                    dtpTarih.Text = "";
                    butonSil();
                }
                    else MessageBox.Show("İşleminiz iptal edildi.");     
                }
                else MessageBox.Show("Boş Alan Bırakmayınız.");              
        }





    }
}
