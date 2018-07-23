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
    public partial class frmHastane : Form
    {
        public frmHastane()
        {
            InitializeComponent();
        }
        VtProcess vt = new VtProcess();
        SqlDataReader reader;
        int hastaneid, hastanebolumID, hastaneklinikID,doktorID,saatID;
        string doktorAdSoyad;
        void hastanedekiBolumler()
        {
            lbHastaneBolumleri.Items.Clear();
            reader = vt.prc_TblHastanedekiBolumler_Select();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader[1].ToString()) == hastaneid)
                    lbHastaneBolumleri.Items.Add(reader[3].ToString());
            }

        }
        void DoktorGoster()
        {
            lbDDoktor.Items.Clear();
            reader = vt.prc_tblDoktor_select();
            while (reader.Read())
            {
                if (hastaneklinikID == Convert.ToInt32(reader[5].ToString()) && reader[4].ToString() == cmbDKlinik.SelectedItem.ToString())
                    lbDDoktor.Items.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
        }
        void Saat()
        {
            lbSaat.Items.Clear();
            reader = vt.prc_TblSaatler_Select();
            while (reader.Read())
            {
                if (cmbGun.SelectedItem.ToString() == reader[2].ToString())
                {
                    lbSaat.Items.Add(reader[1]);
                }
            }
        }
        void YoneticiGoster()
        {
            lbYonetici.Items.Clear();
            reader = vt.prc_TblYonetici_Select();
            while (reader.Read())
            {
                lbYonetici.Items.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
        }
        void DoktorPlanGoster()
        {
            listView1.Items.Clear();
            string gunisim = cmbPGun.SelectedItem.ToString();
            columnHeader1.Text = gunisim;
            reader = vt.prc_TblCalismaSaatleri_Select();
            while (reader.Read())
            {
                if (gunisim == reader[5].ToString() && doktorID == Convert.ToInt32(reader[1].ToString()))
                    listView1.Items.Add(reader[4].ToString());
            }
        }
        void HastaneGoster(string kontrol, string il, string ilce)
        {
            reader = vt.prc_TblHastane_selectById(il, ilce);
            if (kontrol == "HastaneKayıt")
            {
                lbHastane.Items.Clear();
                while (reader.Read()) { lbHastane.Items.Add(reader[3].ToString()); }
            }
            else if (kontrol == "KlinikHastane")
            {
                cmbHBHastane.Items.Clear();
                while (reader.Read())
                {
                    cmbHBHastane.Items.Add(reader[3].ToString());
                }
            }
            else if (kontrol == "DoktorHastane")
            {
                cmbDHastane.Items.Clear();
                while (reader.Read()) { cmbDHastane.Items.Add(reader[3].ToString()); }
            }
            else if (kontrol == "DoktorCalismaPlanıHastane")
            {
                cmbPHastane.Items.Clear();
                while (reader.Read()) { cmbPHastane.Items.Add(reader[3].ToString()); }
            }
        }
       private void btnHastaneKaydet_Click(object sender, EventArgs e)
        {
            bool durum = true;
            foreach (Control tb in tabPage1.Controls)
            {
                if ((tb is TextBox || tb is ComboBox || tb is RichTextBox) && tb.Text == String.Empty) { durum = false; break; }
            }
            if (!durum)
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }
            else
            {
                vt.prc_TblHastane_insert(cmbHstSehir.SelectedItem.ToString(), cmbHstIlce.SelectedItem.ToString(), txtHastaneAdi.Text, txtAdres.Text);
                MessageBox.Show("Kaydedildi.");
                HastaneGoster("HastaneKayıt",cmbHstSehir.SelectedItem.ToString(), cmbHstIlce.SelectedItem.ToString());
            }
        }
        private void btnHastaneSil_Click_1(object sender, EventArgs e)
        {
            if (lbHastane.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz hastaneyi seçiniz.");
            }
            else
            {
                vt.prc_TblHastane_Delete(hastaneid);
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti.");
                HastaneGoster("HastaneKayıt",cmbHstSehir.SelectedItem.ToString(), cmbHstIlce.SelectedItem.ToString());
                txtHastaneAdi.Text = "";
                txtAdres.Text = "";
                HastaneGoster("HastaneKayıt", cmbHstSehir.SelectedItem.ToString(),cmbHstIlce.SelectedItem.ToString());
            }
        }
        private void frmHastane_Load(object sender, EventArgs e)
        {
            
            reader = vt.prc_Iller_Select();
            while (reader.Read())
            {
                cmbHstSehir.Items.Add(reader[1].ToString());
                cmbDSehir.Items.Add(reader[1].ToString());
                cmbHBSehir.Items.Add(reader[1].ToString());
                cmbPSehir.Items.Add(reader[1].ToString());
            }
            reader = vt.prc_TblPoliklinik_Select();
            while (reader.Read())
            {
                lbKlinik.Items.Add(reader[1]);
            }
            YoneticiGoster();
        }
        private void cmbHBSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHastaneBolumleri.Items.Clear();
            cmbHBIlce.Items.Clear();
            cmbHBHastane.Items.Clear();
            reader = vt.proc_Ilceler_Select(cmbHBSehir.SelectedItem.ToString());
            while (reader.Read())
            {
                cmbHBIlce.Items.Add(reader[2].ToString());
            }
        }
        private void cmbHstSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHastaneAdi.Text = "";
            txtAdres.Text = "";
            cmbHstIlce.Items.Clear();
            reader = vt.proc_Ilceler_Select(cmbHstSehir.SelectedItem.ToString());
            while (reader.Read())
            {
                cmbHstIlce.Items.Add(reader[2].ToString());
            }
        }
        private void cmbDSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDIlce.Items.Clear();
            cmbDHastane.Items.Clear();
            cmbDKlinik.Items.Clear();
            txtDAd.Text = "";
            txtDSoyad.Text = "";
            txtDTel.Text = "";
            lbDDoktor.Items.Clear();           
            reader = vt.proc_Ilceler_Select(cmbDSehir.SelectedItem.ToString());
            while (reader.Read())
            {
                cmbDIlce.Items.Add(reader[2].ToString());
            }
        }
        private void cmbPSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPIlce.Items.Clear();
            cmbPHastane.Items.Clear();
            cmbPDoktor.Items.Clear();
            cmbPSaat.Items.Clear();
            cmbPGun.Text = null;
            cmbPIlce.Items.Clear();
            reader = vt.proc_Ilceler_Select(cmbPSehir.SelectedItem.ToString());
            while (reader.Read())
            {
                cmbPIlce.Items.Add(reader[2].ToString());
            }
        }
        private void btnDKaydet_Click(object sender, EventArgs e)
        {
            bool durum = true;
            foreach (Control tb in tpDoktor.Controls)
            {
                if ((tb is ComboBox || tb is TextBox || tb is MaskedTextBox) && (tb.Text == String.Empty)) { durum = false; break; }
            }
            if (!durum)
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }
            else
            {
                bool kontrol = true;
                for (int i = 0; i < lbDDoktor.Items.Count; i++)
                {
                    if (txtDAd.Text+" "+txtDSoyad.Text == lbDDoktor.Items[i].ToString())
                    {
                        kontrol = false; break;
                    }
                }
                if (kontrol)
                {
                    vt.prc_tblDoktor_insert(txtDAd.Text, txtDSoyad.Text, txtDTel.Text, cmbDKlinik.SelectedItem.ToString(), cmbDHastane.SelectedItem.ToString());
                    MessageBox.Show("Doktor Kaydedildi.");
                    DoktorGoster();
                }
                else { MessageBox.Show("Aynı doktor zaten var."); }
            }
        }
        private void cmbHstIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHastaneAdi.Text = "";
            txtAdres.Text = "";
            HastaneGoster("HastaneKayıt",cmbHstSehir.SelectedItem.ToString(), cmbHstIlce.SelectedItem.ToString());
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lbHastane.SelectedIndex >= 0)
            {
                reader = vt.prc_TblHastane_selectById(cmbHstSehir.SelectedItem.ToString(), cmbHstIlce.SelectedItem.ToString());
                while (reader.Read())
                {
                    if (lbHastane.SelectedItem.ToString() == reader[3].ToString())
                    {
                        hastaneid = Convert.ToInt32(reader[0].ToString());
                        txtHastaneAdi.Text = reader[3].ToString();
                        txtAdres.Text = reader[4].ToString();
                    }
                }
            }
        }
        private void cmbHBIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHastaneBolumleri.Items.Clear();
            cmbHBHastane.Items.Clear();
            reader = vt.prc_TblHastane_selectById(cmbHBSehir.SelectedItem.ToString(), cmbHBIlce.SelectedItem.ToString());
            while (reader.Read())
            {
                cmbHBHastane.Items.Add(reader[3].ToString());
            }
        }
        private void cmbHBHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            reader = vt.prc_TblHastane_selectById(cmbHBSehir.SelectedItem.ToString(), cmbHBIlce.SelectedItem.ToString());
            while (reader.Read())
            {
                if (cmbHBHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneid = Convert.ToInt32(reader[0].ToString());
            }
            hastanedekiBolumler();
        }
        private void btnHastaneBolumKaydet_Click(object sender, EventArgs e)
        {
            bool durum = true;
            foreach (Control tb in tpKlinik.Controls)
                if (tb is ComboBox && (tb.Text == String.Empty)) durum = false;
            if (durum)
            {
                if (lbKlinik.SelectedIndex < 0) MessageBox.Show("Bölüm seçiniz");
                else
                {
                    bool kontrol = true;
                    for (int i = 0; i < lbHastaneBolumleri.Items.Count; i++)
                    {
                        if (lbKlinik.SelectedItem.ToString() == lbHastaneBolumleri.Items[i].ToString())
                        {
                            kontrol = false; break;
                        }
                    }
                    if (kontrol)
                    {
                        vt.prc_TblHastanedekiBolumler_insert(cmbHBHastane.SelectedItem.ToString(), lbKlinik.SelectedItem.ToString());
                        MessageBox.Show("Hastaneye bölüm eklendi.");
                        hastanedekiBolumler();
                    }
                    else MessageBox.Show("Bu bölüm zaten var");
                }
            }
            else MessageBox.Show("Boş Alan Bırakmayınız");


        }
        private void lbHastaneBolumleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHastaneBolumleri.SelectedIndex >= 0)
            {
                reader = vt.prc_TblHastanedekiBolumler_Select();
                while (reader.Read())
                {
                    if (lbHastaneBolumleri.SelectedItem.ToString() == reader[3].ToString())
                    {
                        hastanebolumID = Convert.ToInt32(reader[0].ToString());
                    }
                }
            }
        }
        private void cmbDIlce_SelectedIndexChanged(object sender, EventArgs e)
        {   
            cmbDHastane.Items.Clear();
            cmbDKlinik.Items.Clear();
            txtDAd.Text = "";
            txtDSoyad.Text = "";
            txtDTel.Text = "";
            lbDDoktor.Items.Clear();
            HastaneGoster("DoktorHastane", cmbDSehir.SelectedItem.ToString(),cmbDIlce.SelectedItem.ToString());
        }
        private void cmbDHastane_SelectedIndexChanged(object sender, EventArgs e)
        { 
            txtDAd.Text = "";
            txtDSoyad.Text = "";
            txtDTel.Text = "";
            lbDDoktor.Items.Clear(); cmbDKlinik.Items.Clear();
            reader = vt.prc_TblHastane_selectById(cmbDSehir.SelectedItem.ToString(),cmbDIlce.SelectedItem.ToString());
            while (reader.Read())
            {
                if (cmbDHastane.SelectedItem.ToString() == reader[3].ToString())
                {
                    hastaneklinikID = Convert.ToInt32(reader[0].ToString());
                    
                }
            }
            reader = vt.prc_TblHastanedekiBolumler_Select();
            while (reader.Read())
            {
                if (hastaneklinikID==Convert.ToInt32(reader[1].ToString()))
                {
                    cmbDKlinik.Items.Add(reader[3].ToString());
                }
            }
        }
        private void btnSKaydet_Click(object sender, EventArgs e)
        {
            if (cmbGun.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir gün seçiniz.");
            }
            else
            {
                bool kontrol = true;
                for (int i = 0; i < lbSaat.Items.Count; i++)
                {
                    if (dtpSaat.Text+":00" == lbSaat.Items[i].ToString())
                    {
                        kontrol = false; break;
                    }
                }
                if (kontrol)
                {
                    vt.prc_TblSaatler_insert(dtpSaat.Text, cmbGun.SelectedItem.ToString());
                    MessageBox.Show("Saat kaydedildi.");
                    Saat();
                }
                else { MessageBox.Show("Bu saat zaten var."); }
            }
        }
        private void btnSSil_Click(object sender, EventArgs e)
        {
            if (lbSaat.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz saati seçiniz.");
            }
            else
            {
                vt.prc_TblSaatler_delete(saatID);
                Saat();
            }
        }
        private void lbSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            reader = vt.prc_TblSaatler_Select();
            while (reader.Read())
            {
                if (lbSaat.SelectedItem.ToString()==reader[1].ToString()&&cmbGun.SelectedItem.ToString()==reader[2].ToString())
                {
                    saatID = Convert.ToInt32(reader[0]);
                }
            }
        }
        private void cmbPIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPDoktor.Items.Clear();
            cmbPSaat.Items.Clear();
            cmbPGun.Text = null;
            HastaneGoster("DoktorCalismaPlanıHastane",cmbPSehir.SelectedItem.ToString(),cmbPIlce.SelectedItem.ToString());
        }
        private void cmbPHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPSaat.Items.Clear();
            cmbPGun.Text = null;
            cmbPDoktor.Items.Clear();
            reader = vt.prc_TblHastane_selectById(cmbPSehir.SelectedItem.ToString(), cmbPIlce.SelectedItem.ToString());
            while (reader.Read())
            {
                if (cmbPHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneid = Convert.ToInt32(reader[0].ToString());
            }
            reader=vt.prc_tblDoktor_select();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader[5].ToString())== hastaneid)
                {
                    cmbPDoktor.Items.Add(reader[1].ToString()+" "+reader[2].ToString());
                }
            }
        }
        private void cmbPDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPSaat.Items.Clear();
            cmbPGun.Text = null;
            listView1.Items.Clear();
            reader = vt.prc_tblDoktor_select();
            while (reader.Read())
            {
                string doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                if (cmbPDoktor.SelectedItem.ToString() == doktorAdSoyad)
                    doktorID = Convert.ToInt32(reader[0].ToString());
            }
        }
        private void btnPKaydet_Click(object sender, EventArgs e)
        {
            bool durum = true;
            foreach (Control tb in tpProgram.Controls)
            {
                if (tb is ComboBox && (tb.Text == String.Empty)) durum = false;
            }
            if (durum)
            {
                bool kontrol = true;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (cmbPSaat.SelectedItem.ToString()== listView1.Items[i].SubItems[0].Text)
                    {
                        kontrol = false; break;
                    }
                }
                if (kontrol)
                {
                    vt.prc_TblCalismaSaatleri_insert(doktorID, cmbPGun.SelectedItem.ToString(), cmbPSaat.SelectedItem.ToString());
                    MessageBox.Show("Eklendi");
                    DoktorPlanGoster();
                }
                else { MessageBox.Show("Bu saat zaten ekli."); }
            }
            else MessageBox.Show("Boş Alan Bırakmayınız");
        }
        private void btnPSil_Click(object sender, EventArgs e)
        {
            try
            {
                string saat = listView1.SelectedItems[0].SubItems[0].Text;
                vt.prc_TblCalismaSaatleri_delete(doktorID, cmbPGun.SelectedItem.ToString(), saat);
                DoktorPlanGoster();
                MessageBox.Show("Silindi");
            }
            catch (Exception) { MessageBox.Show("Bir Satır Seçiniz"); }
        }
        private void cmbPGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPSaat.Items.Clear();
            if (cmbPGun.SelectedIndex >= 0)
            {

                reader = vt.prc_TblSaatler_Select();
                while (reader.Read())
                {
                    if (cmbPGun.SelectedItem.ToString() == reader[2].ToString())
                        cmbPSaat.Items.Add(reader[1].ToString());
                }
                DoktorPlanGoster();
            }
        }
        private void lbDDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDDoktor.SelectedIndex >= 0)
            {
                reader = vt.prc_tblDoktor_select();
                while (reader.Read())
                {
                    string doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                    if (lbDDoktor.SelectedItem.ToString() == doktorAdSoyad)
                    {
                        doktorID = Convert.ToInt32(reader[0].ToString());
                        txtDAd.Text = reader[1].ToString();
                        txtDSoyad.Text = reader[2].ToString();
                        txtDTel.Text = reader[3].ToString();
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            vt.prc_TblHastane_update(hastaneid,cmbHstSehir.SelectedItem.ToString(),cmbHstIlce.SelectedItem.ToString(),txtHastaneAdi.Text,txtAdres.Text);
            MessageBox.Show("Güncellendi.");
        }

        private void btnDGuncelle_Click(object sender, EventArgs e)
        {
            vt.prc_tblDoktor_update(doktorID,txtDAd.Text,txtDSoyad.Text,txtDTel.Text,cmbDKlinik.SelectedItem.ToString(),cmbDHastane.SelectedItem.ToString());
            MessageBox.Show("Güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool durum = true;
            bool kontrol = false;
            foreach (Control tb in YöneticiKayit.Controls)
            {
                if ((tb is TextBox ) && tb.Text == String.Empty) durum = false;
            }
            reader = vt.prc_TblYonetici_Select();
            while (reader.Read())
            {
                if (reader[3].ToString() == txtYTc.Text) { MessageBox.Show("Aynı Kullanıcı adı var"); kontrol = true; break; }
            }
            if (!kontrol)
            {
                if (!durum)
                    MessageBox.Show("Boş Alan Bırakmayınız.");
                else
                {
                    if (txtYSifre.Text == txtYSifreTekrar.Text)
                    {
                       
                        vt.prc_TblYonetici_insert(txtYAd.Text, txtYSoyad.Text, txtYTc.Text, txtYSifre.Text);
                        MessageBox.Show("Başarıyla Kaydedildi.");
                        YoneticiGoster();
                    }
                    else MessageBox.Show("Şifreler eşleşmiyor.");
                }
            }
        }
        string yoneticiadi, yoneticitc;

        private void lbYonetici_SelectedIndexChanged(object sender, EventArgs e)
        {
            reader = vt.prc_TblYonetici_Select();
            while (reader.Read())
            {
                yoneticiadi = lbYonetici.SelectedItem.ToString();
                if (yoneticiadi == reader[1].ToString() + " " + reader[2].ToString())
                {
                    yoneticitc = reader[3].ToString();
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbYonetici.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz yöneticiyi seçiniz.");
            }
            else
            {
                vt.prc_TblYonetici_delete(yoneticitc);
                YoneticiGoster();
            }
        
           
        }

        private void cmbGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            Saat();
        }
        private void btnDSil_Click(object sender, EventArgs e)
        {
            if (lbDDoktor.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz doktoru seçiniz.");
            }
            else
            {
                reader = vt.prc_tblDoktor_select();
                while (reader.Read())
                {
                    doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                    if (lbDDoktor.SelectedItem.ToString()==doktorAdSoyad)
                    {
                         doktorID = Convert.ToInt32(reader[0].ToString());

                    }
                    vt.prc_tblDoktor_delete(doktorID);
                    MessageBox.Show("Doktor başarıyla silindi.");
                    DoktorGoster();
            }
            }
        }
        private void cmbDKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {    
            txtDAd.Text = "";
            txtDSoyad.Text = "";
            txtDTel.Text = "";
            lbDDoktor.Items.Clear(); DoktorGoster();
        }
        private void btnHastaneBolumSil_Click(object sender, EventArgs e)
        {
            if (lbHastaneBolumleri.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz hastaneyi seçiniz.");
            }
            else
            {
                vt.prc_TblHastanedekiBolumler_delete(hastanebolumID);
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti.");
                hastanedekiBolumler();
            }
        }
    }
}
