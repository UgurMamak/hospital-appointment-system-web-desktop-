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
    public partial class frmHastane : Form
    {
        public frmHastane()
        {
            InitializeComponent();
        }
        VtProcess prc = new VtProcess();
        SqlDataReader reader;
        int hastaneId, hastaneBolumId, doktorId, saatId;
        string yoneticiTc;    
        
        void yoneticiListele()
        {
            lbYonetici.Items.Clear();
            reader = prc.prc_TblYonetici_Select();
            while(reader.Read())
            {
                lbYonetici.Items.Add(reader[1].ToString()+" "+reader[2].ToString());
            }
        }
        
              
        void doktorplanGoster()//doktorun 
        {
            lwDoktorSaat.Items.Clear();
            string gunisim = cmbDcpGun.SelectedItem.ToString();
            chGun.Text = gunisim;
            reader = prc.prc_TblCalismaSaatleri_Select();
            while(reader.Read())
            {
                if(gunisim==reader[5].ToString()&&doktorId==Convert.ToInt32(reader[1].ToString()))              
                 lwDoktorSaat.Items.Add(reader[4].ToString());                
            }                           
        }

        void GunSaatGoster()
        {
            lbSaat.Items.Clear();
            reader = prc.prc_TblSaatler_Select();
            while(reader.Read())            
                if (cmbGun.SelectedItem.ToString() == reader[2].ToString())
                    lbSaat.Items.Add(reader[1].ToString());
            
        }
        void DoktorGoster()
        {
            lbDDoktor.Items.Clear();
            reader = prc.prc_tblDoktor_select();
            while (reader.Read())            
                if (Convert.ToInt32(reader[5].ToString()) == hastaneId && cmbDKlinik.SelectedItem.ToString() == reader[4].ToString())
                    lbDDoktor.Items.Add(reader[1].ToString() + " " + reader[2].ToString());            
        }

        void hastanedekiBolumler()
        {
            lbHastaneBolumleri.Items.Clear();
            reader = prc.prc_TblHastanedekiBolumler_Select();
           while(reader.Read())            
                if (Convert.ToInt32(reader[1].ToString()) == hastaneId)
                    lbHastaneBolumleri.Items.Add(reader[3].ToString());                                       
        }

        
                
        void HastaneGoster( string kontrol,string il,string ilce)
        {
            reader = prc.prc_TblHastane_selectById(il, ilce);
            if (kontrol == "HastaneKayıt")
            {
                lbHastane.Items.Clear();                
                while (reader.Read())lbHastane.Items.Add(reader[3].ToString());
            }
            else if(kontrol=="KlinikHastane")
            {
                cmbHbHastane.Items.Clear();               
                while (reader.Read()) cmbHbHastane.Items.Add(reader[3].ToString());                                   
            }
            else if(kontrol=="DoktorHastane")
            {
                cmbDHastane.Items.Clear();                
                while (reader.Read())  cmbDHastane.Items.Add(reader[3].ToString()); 
            }
            else if(kontrol=="DoktorCalismaPlanıHastane")
            {
                cmbPHastane.Items.Clear();
                while (reader.Read())  cmbPHastane.Items.Add(reader[3].ToString()); 
            }
        }
           
        private void btnHastaneKaydet_Click(object sender, EventArgs e)
        {
            bool durum = true;
            foreach (Control tb in tabPage1.Controls)
            {
                if ((tb is TextBox || tb is RichTextBox || tb is ComboBox) && (tb.Text == String.Empty)) durum = false;
            }
            if (durum)
            {
                prc.prc_TblHastane_insert(cmbHstSehir.SelectedItem.ToString(), cmbHstIlce.SelectedItem.ToString(), txtHastaneAdi.Text, txtAdres.Text);
              //  MessageBox.Show("Hastane Kayıt Edildi.");
                HastaneGoster("HastaneKayıt", cmbHstSehir.SelectedItem.ToString(),cmbHstIlce.SelectedItem.ToString());
            }
            
            else MessageBox.Show("Boş Alan Bırakmayınız");                     
        }

        private void btnHastaneSil_Click(object sender, EventArgs e)
        {

            if (lbHastane.SelectedIndex < 0)
                MessageBox.Show("seçili değil");
            else
            {



                prc.prc_TblHastane_Delete(hastaneId);                
                txtAdres.Text = "";
                txtHastaneAdi.Text = "";
                HastaneGoster("HastaneKayıt", cmbHstSehir.SelectedItem.ToString(),cmbHstIlce.SelectedItem.ToString());
                MessageBox.Show("Silindi");
            }          
        }

        private void btnHastaneBolumKaydet_Click(object sender, EventArgs e)
        {
                        
                        
            bool durum = true;
            foreach (Control tb in tpKlinik.Controls)            
                if ( tb is ComboBox && (tb.Text == String.Empty)) durum = false;                      
            if (durum)
            {
                if (lbKliniik.SelectedIndex < 0) MessageBox.Show("Bölüm seçiniz");
                else
                {
                    bool kontrol = true;                    
                    for (int i = 0; i < lbHastaneBolumleri.Items.Count; i++)
                    {
                        if (lbKliniik.SelectedItem.ToString() == lbHastaneBolumleri.Items[i].ToString())
                        { kontrol = false; break; }
                    }
                    if (kontrol)
                    {
                        prc.prc_TblHastanedekiBolumler_insert(cmbHbHastane.SelectedItem.ToString(), lbKliniik.SelectedItem.ToString());
                        MessageBox.Show("Hastaneye bölüm eklendi.");
                        hastanedekiBolumler();
                    }
                    else MessageBox.Show("Bu bölüm zaten var");               
                }
            }
            else MessageBox.Show("Boş Alan Bırakmayınız");

        }

        private void btnHastaneBolumSil_Click(object sender, EventArgs e)
        {
            if (lbHastaneBolumleri.SelectedIndex < 0)
                MessageBox.Show("seçili değil");
            else
            {
                prc.prc_TblHastanedekiBolumler_delete(hastaneBolumId);
                MessageBox.Show("Silindi");
                hastanedekiBolumler();
            }
        }

        private void btnDKaydet_Click(object sender, EventArgs e)
        {
            bool durum = true;
            foreach (Control tb in tpDoktor.Controls)
            {
                if ((tb is ComboBox ||tb is TextBox || tb is MaskedTextBox)&& (tb.Text == String.Empty)) durum = false;
            }
            if (durum)
            {
                bool kontrol = true;
                string doktorAdsoyad = txtDAd.Text + " " + txtDSoyad.Text;
                for (int i = 0; i < lbDDoktor.Items.Count; i++)
                    if (doktorAdsoyad == lbDDoktor.Items[i].ToString())
                    { kontrol = false; break; }
                if (kontrol)
                {
                    prc.prc_tblDoktor_insert(txtDAd.Text, txtDSoyad.Text, txtDTel.Text, cmbDKlinik.SelectedItem.ToString(), cmbDHastane.SelectedItem.ToString());
                    MessageBox.Show("Eklendi");
                    DoktorGoster();
                }
                else MessageBox.Show("Aynı kayıt var.");

            }
            else MessageBox.Show("Boş Alan Bırakmayınız.");
        }

        private void btnDSil_Click(object sender, EventArgs e)
        {

            if (lbDDoktor.SelectedIndex < 0)MessageBox.Show("seçili değil");                
            else
            {
                prc.prc_tblDoktor_delete(doktorId);
                MessageBox.Show("Silindi");
                DoktorGoster();
            }
        }

        private void btnSKaydet_Click(object sender, EventArgs e)
        {
            if (cmbGun.SelectedIndex >= 0)
            {
                bool kontrol = true;
                for (int i = 0; i < lbSaat.Items.Count; i++)
                    if (dtpsaatkayit.Text+":00"== lbSaat.Items[i].ToString())
                    { kontrol = false; break; }
                
                if (kontrol)
                {
                    prc.prc_TblSaatler_insert(dtpsaatkayit.Text, cmbGun.SelectedItem.ToString());
                    MessageBox.Show("Kaydedildi");
                    GunSaatGoster();
                }
                else MessageBox.Show("Aynı saat zaten var.");
            }
            else MessageBox.Show("Boş alan bırakmayın");            
        }

        private void btnSSil_Click(object sender, EventArgs e)
        {
            if(lbSaat.SelectedIndex<0)            
                MessageBox.Show("Silmek istediğiniz saatini seçiniz");           
            else
            {
                prc.prc_TblSaatler_delete(saatId);
                MessageBox.Show("Silindi");
                GunSaatGoster();
            }            
        }

        private void btnPKaydet_Click(object sender, EventArgs e)
        {

            bool durum = true;
            foreach (Control tb in tpProgram.Controls)           
                if ( tb is ComboBox && (tb.Text == String.Empty)) durum = false;
            
            if (durum)
            {
                bool kontrol = true;
                for (int i = 0; i < lwDoktorSaat.Items.Count; i++)
                    if (cmbsaat.SelectedItem.ToString() == lwDoktorSaat.Items[i].SubItems[0].Text)
                    { kontrol = false; break; }
                if (kontrol)
                {
                    prc.prc_TblCalismaSaatleri_insert(doktorId, cmbDcpGun.SelectedItem.ToString(), cmbsaat.SelectedItem.ToString());
                    MessageBox.Show("Eklendi");
                    doktorplanGoster();
                }
                else MessageBox.Show("Aynı Kayıt var");
            }
            else MessageBox.Show("Boş Alan Bırakmayınız");
        }

        private void btnPSil_Click(object sender, EventArgs e)
        {
            try
            {
                string saat = lwDoktorSaat.SelectedItems[0].SubItems[0].Text;
                prc.prc_TblCalismaSaatleri_delete(doktorId, cmbDcpGun.SelectedItem.ToString(), saat);
                doktorplanGoster();
                MessageBox.Show("Silindi");
            }
            catch (Exception) { MessageBox.Show("Bir Satır Seçiniz"); }
        }

        private void frmHastane_Load(object sender, EventArgs e)
        {          
            reader = prc.prc_Iller_Select();
            while(reader.Read())
            {
                cmbHstSehir.Items.Add(reader[1].ToString());
                cmbHBSehir.Items.Add(reader[1].ToString());
                cmbDSehir.Items.Add(reader[1].ToString());
                cmbPSehir.Items.Add(reader[1].ToString());
            }

            reader = prc.prc_TblPoliklinik_Select();
            while(reader.Read()) lbKliniik.Items.Add(reader[1].ToString());

            yoneticiListele();
            

        }

        private void cmbHstSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHstIlce.Items.Clear();
            txtHastaneAdi.Text = "";
            txtAdres.Text = "";
            lbHastane.Items.Clear();
            reader = prc.proc_Ilceler_Select(cmbHstSehir.SelectedItem.ToString());
            while(reader.Read()) cmbHstIlce.Items.Add(reader[2].ToString());
        }

        private void cmbHBSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHBIlce.Items.Clear();
            cmbHbHastane.Items.Clear();
            lbHastaneBolumleri.Items.Clear();

            reader = prc.proc_Ilceler_Select(cmbHBSehir.SelectedItem.ToString());
            while (reader.Read())  cmbHBIlce.Items.Add(reader[2].ToString()); 
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
            reader = prc.proc_Ilceler_Select(cmbDSehir.SelectedItem.ToString());
            while (reader.Read()) cmbDIlce.Items.Add(reader[2].ToString()); 
        }

        private void cmbPSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPIlce.Items.Clear();
            cmbPHastane.Items.Clear();
            cmbPDoktor.Items.Clear();
            cmbsaat.Items.Clear();
            cmbDcpGun.Text = null;
            lwDoktorSaat.Items.Clear();                 
            reader = prc.proc_Ilceler_Select(cmbPSehir.SelectedItem.ToString());
            while (reader.Read())  cmbPIlce.Items.Add(reader[2].ToString()); 
        }

        private void cmbHstIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAdres.Text = "";
            txtHastaneAdi.Text = "";
            lbHastane.Items.Clear();
            HastaneGoster("HastaneKayıt", cmbHstSehir.SelectedItem.ToString(),cmbHstIlce.SelectedItem.ToString());
        }

        private void cmbHBIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHastaneBolumleri.Items.Clear();
            HastaneGoster("KlinikHastane",cmbHBSehir.SelectedItem.ToString(),cmbHBIlce.SelectedItem.ToString());
        }

        private void lbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHastane.SelectedIndex >= 0)
            {
                reader = prc.prc_TblHastane_selectById(cmbHstSehir.SelectedItem.ToString(), cmbHstIlce.SelectedItem.ToString());
                while (reader.Read())
                {
                    if (lbHastane.SelectedItem.ToString() == reader[3].ToString())
                    {
                        hastaneId = Convert.ToInt32(reader[0].ToString());
                        txtHastaneAdi.Text = reader[3].ToString();
                        txtAdres.Text = reader[4].ToString();
                    }
                }
            }
        }

        private void lbHastaneBolumleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHastaneBolumleri.SelectedIndex >= 0)
            {
                reader = prc.prc_TblHastanedekiBolumler_Select();
                while (reader.Read())                
                    if (lbHastaneBolumleri.SelectedItem.ToString() == reader[3].ToString())
                        hastaneBolumId = Convert.ToInt32(reader[0].ToString());
                
            }
        }

        private void cmbDIlce_SelectedIndexChanged(object sender, EventArgs e)
        {           
            cmbDKlinik.Items.Clear();
            txtDAd.Text = "";
            txtDSoyad.Text = "";
            txtDTel.Text = "";
            lbDDoktor.Items.Clear();
            HastaneGoster("DoktorHastane",cmbDSehir.SelectedItem.ToString(),cmbDIlce.SelectedItem.ToString());
        }

        private void cmbDHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDKlinik.Items.Clear();
            txtDAd.Text = "";
            txtDSoyad.Text = "";
            txtDTel.Text = "";
            lbDDoktor.Items.Clear();
            reader = prc.prc_TblHastane_selectById(cmbDSehir.SelectedItem.ToString(), cmbDIlce.SelectedItem.ToString());
            while (reader.Read())            
                if (cmbDHastane.SelectedItem.ToString() == reader[3].ToString())                
                    hastaneId = Convert.ToInt32(reader[0].ToString());                           
            
            reader = prc.prc_TblHastanedekiBolumler_Select();
            while (reader.Read())            
                if(Convert.ToInt32(reader[1].ToString())==hastaneId)               
                cmbDKlinik.Items.Add(reader[3].ToString());            
        }

        private void lbDDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDDoktor.SelectedIndex >= 0)
            {
                reader = prc.prc_tblDoktor_select();
                while (reader.Read())
                {
                    string doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                    if (lbDDoktor.SelectedItem.ToString() == doktorAdSoyad)
                    {
                        doktorId = Convert.ToInt32(reader[0].ToString());
                        txtDAd.Text = reader[1].ToString();
                        txtDSoyad.Text = reader[2].ToString();
                        txtDTel.Text = reader[3].ToString();
                    }

                }
            }
        }

        private void lbSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSaat.SelectedIndex >= 0)
            {
                reader = prc.prc_TblSaatler_Select();
                while (reader.Read())                
                    if (lbSaat.SelectedItem.ToString() == reader[1].ToString() && cmbGun.SelectedItem.ToString() == reader[2].ToString())
                        saatId = Convert.ToInt32(reader[0].ToString());               
            }
        }

        private void cmbPIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPDoktor.Items.Clear();
            cmbsaat.Items.Clear();
            cmbDcpGun.Text = null;
            lwDoktorSaat.Items.Clear();
            HastaneGoster("DoktorCalismaPlanıHastane",cmbPSehir.SelectedItem.ToString(),cmbPIlce.SelectedItem.ToString());
        }

        private void cmbPHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPDoktor.Items.Clear();
            cmbsaat.Items.Clear();
            cmbDcpGun.Text = null;
            lwDoktorSaat.Items.Clear();
            reader = prc.prc_TblHastane_selectById(cmbPSehir.SelectedItem.ToString(), cmbPIlce.SelectedItem.ToString());
            while (reader.Read())            
                if (cmbPHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneId = Convert.ToInt32(reader[0].ToString());
                      
            reader = prc.prc_tblDoktor_select();
            while (reader.Read())            
                if (Convert.ToInt32(reader[5].ToString()) == hastaneId)
                    cmbPDoktor.Items.Add(reader[1].ToString() + " " + reader[2].ToString()); 
        }

        private void cmbPDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDcpGun.Text = null;
            cmbsaat.Items.Clear(); 
            lwDoktorSaat.Items.Clear();
            reader = prc.prc_tblDoktor_select();
            while (reader.Read())
            {
                string doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                if (cmbPDoktor.SelectedItem.ToString() == doktorAdSoyad)
                    doktorId = Convert.ToInt32(reader[0].ToString());
            }
                   
        }

        private void cmbDcpGun_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (cmbDcpGun.SelectedIndex >= 0)
            {
                cmbsaat.Items.Clear();
                reader = prc.prc_TblSaatler_Select();
                while (reader.Read())                
                    if (cmbDcpGun.SelectedItem.ToString() == reader[2].ToString())
                        cmbsaat.Items.Add(reader[1].ToString());              
                doktorplanGoster();
            }
        }

        private void btnHastaneGuncelle_Click(object sender, EventArgs e)
        {                        
            prc.prc_TblHastane_update(hastaneId,cmbHstSehir.SelectedItem.ToString(),cmbHstIlce.SelectedItem.ToString(),txtHastaneAdi.Text,txtAdres.Text);
            MessageBox.Show("Güncellendi");
        }

        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            prc.prc_tblDoktor_update(doktorId, txtDAd.Text, txtDSoyad.Text, txtDTel.Text, cmbDKlinik.SelectedItem.ToString(),cmbDHastane.SelectedItem.ToString());
        }

        private void btnYonKaydet_Click(object sender, EventArgs e)
        {

            bool durum = true;
            bool kontrol = false;
            foreach (Control tb in tpYonetici.Controls)
            {
                if (tb is TextBox  && tb.Text == String.Empty) durum = false;
            }
            reader = prc.prc_TblYonetici_Select();
            while (reader.Read())
            { if (reader[3].ToString() == txtyontc.Text) { MessageBox.Show("Aynı Kullanıcı adı var"); kontrol = true; break; } }
            if (!kontrol)
            {
                if (!durum)
                    MessageBox.Show("Boş Alan Bırakmayınız.");
                else
                {
                    if (txtYonSifre.Text == txtYonSifreTekr.Text)
                    {
                                              
                        prc.prc_TblYonetici_insert(txtYonad.Text, txtYonSoyad.Text, txtyontc.Text, txtYonSifre.Text);
                        MessageBox.Show("Başarıyla Kaydedildi.");
                        yoneticiListele();
                    }
                    else MessageBox.Show("Şifreler eşleşmiyor.");
                }
            }
        }

        private void lbYonetici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbYonetici.SelectedIndex >= 0)
            {
                reader = prc.prc_TblYonetici_Select();
                while (reader.Read())
                {
                    string yonadsoyad = reader[1].ToString() + " " + reader[2].ToString();
                    if (lbYonetici.SelectedItem.ToString() == yonadsoyad)                    
                        yoneticiTc = reader[3].ToString();                    
                }
            }           
        }

        private void btnYonSil_Click(object sender, EventArgs e)
        {
            if (lbYonetici.SelectedIndex< 0) MessageBox.Show("seçili değil");
            else
            {
                prc.prc_TblYonetici_delete(yoneticiTc);
                MessageBox.Show("Silindi");
                yoneticiListele();
            }
        }

        private void cmbsaat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            GunSaatGoster();
        }

        private void cmbDKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDAd.Text = "";
            txtDSoyad.Text = "";
            txtDTel.Text = "";
            lbDDoktor.Items.Clear();
            DoktorGoster();
        }

        private void cmbHbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            reader = prc.prc_TblHastane_selectById(cmbHBSehir.SelectedItem.ToString(), cmbHBIlce.SelectedItem.ToString());
            while (reader.Read())           
                if (cmbHbHastane.SelectedItem.ToString() == reader[3].ToString())                
                    hastaneId = Convert.ToInt32(reader[0].ToString());        
                       hastanedekiBolumler();
        }


    }
}
