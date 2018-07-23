using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataLayer;
namespace stjWebV1
{
    public partial class WfrmDoktorCP : System.Web.UI.Page
    {
        VtProcess prc = new VtProcess();
        SqlDataReader reader;
        int hastaneId; int hastaneBolumId, doktorId;
        void ilGoster()
        {

            cmbCpİlce.Items.Clear();
            cmbCpHastane.Items.Clear();
            cmbCpKlinik.Items.Clear();
            cmbCpKlinik.Items.Add("");
            cmbCpSaat.Items.Clear();
            cmbCpSaat.Items.Add("");
            cmbCpDoktor.Items.Clear();
            cmbCpDoktor.Items.Add("");
            reader = prc.prc_Iller_Select();
            while (reader.Read()) cmbCpIl.Items.Add(reader[1].ToString());

        }
        void ilceGoster()
        {
            cmbCpHastane.Items.Clear();
            cmbCpHastane.Items.Add("");
            cmbCpİlce.Items.Clear();
            cmbCpİlce.Items.Add("");
            cmbCpKlinik.Items.Clear();
            cmbCpKlinik.Items.Add("");
            cmbCpDoktor.Items.Clear();
            cmbCpDoktor.Items.Add("");
            reader = prc.proc_Ilceler_Select(cmbCpIl.SelectedItem.ToString());
            while (reader.Read()) cmbCpİlce.Items.Add(reader[2].ToString());
        }
        void HastaneGoster()
        {
            cmbCpHastane.Items.Clear();
            cmbCpHastane.Items.Add("");
            cmbCpKlinik.Items.Clear();
            cmbCpKlinik.Items.Add("");
            cmbCpDoktor.Items.Clear();
            cmbCpDoktor.Items.Add("");
            reader = prc.prc_TblHastane_selectById(cmbCpIl.SelectedItem.ToString(), cmbCpİlce.SelectedItem.ToString());
            while (reader.Read()) cmbCpHastane.Items.Add(reader[3].ToString());
        }
        int FnkHastaneId()
        {

            reader = prc.prc_TblHastane_selectById(cmbCpIl.SelectedItem.ToString(), cmbCpİlce.SelectedItem.ToString());
            while (reader.Read())
                if (cmbCpHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneId = Convert.ToInt32(reader[0].ToString());
            return hastaneId;
        }

        void hastanedekiBolumler()
        {
            int HstId = FnkHastaneId();
            cmbCpKlinik.Items.Clear();
            cmbCpKlinik.Items.Add("");
            cmbCpDoktor.Items.Clear();
            cmbCpDoktor.Items.Add("");
            reader = prc.prc_TblHastanedekiBolumler_Select();
            while (reader.Read())
                if (Convert.ToInt32(reader[1].ToString()) == HstId)
                    cmbCpKlinik.Items.Add(reader[3].ToString());
        }
        void DoktorGoster()
        {
            int hstId = FnkHastaneId();
            cmbCpDoktor.Items.Clear();
            cmbCpDoktor.Items.Add("");
            reader = prc.prc_tblDoktor_select();
            while (reader.Read())
                if (Convert.ToInt32(reader[5].ToString()) == hstId && cmbCpKlinik.SelectedItem.ToString() == reader[4].ToString())
                    cmbCpDoktor.Items.Add(reader[1].ToString() + " " + reader[2].ToString());
        }


        int FnkDoktorId()
        {
            if (cmbCpDoktor.SelectedIndex > 0)
            {
                reader = prc.prc_tblDoktor_select();
                while (reader.Read())
                {
                    string doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                    if (cmbCpDoktor.SelectedItem.ToString() == doktorAdSoyad)
                        doktorId = Convert.ToInt32(reader[0].ToString());
                }
            }
            return doktorId;
        }

        void doktorplanGoster()//doktorun 
        {           
            cmbCpSaat.Items.Add("");
            lbCpProgram.Items.Clear();
            int drId = FnkDoktorId();                 
            reader = prc.prc_TblCalismaSaatleri_Select();
            while (reader.Read())
            {
                if (cmbCpGun.SelectedItem.ToString() == reader[5].ToString() &&drId == Convert.ToInt32(reader[1].ToString()))
                    lbCpProgram.Items.Add(reader[4].ToString());
            }
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)           
                ilGoster();
              
            
        }

        protected void cmbCpİlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            HastaneGoster();
        }

        protected void cmbCpIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceGoster();
        }

        protected void cmbCpHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            hastanedekiBolumler();
        }

        protected void cmbCpKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoktorGoster();
        }

        protected void cmbCpGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCpGun.SelectedIndex > 0)
            {                
                cmbCpSaat.Items.Clear();
                cmbCpSaat.Items.Add("");
                reader = prc.prc_TblSaatler_Select();
                while (reader.Read())
                    if (cmbCpGun.SelectedItem.ToString() == reader[2].ToString())
                        cmbCpSaat.Items.Add(reader[1].ToString());
                doktorplanGoster();
            }
        }

        protected void btnCpEkle_Click(object sender, EventArgs e)
        {
            if(cmbCpIl.SelectedIndex<=0||cmbCpİlce.SelectedIndex<=0||cmbCpHastane.SelectedIndex<=0||cmbCpKlinik.SelectedIndex<=0||cmbCpDoktor.SelectedIndex<=0||cmbCpGun.SelectedIndex<=0||cmbCpSaat.SelectedIndex<=0)
                Response.Write("Boş Alan Bırakmayınız");
            else
            {
                bool kontrol = true;
                for (int i = 0; i < lbCpProgram.Items.Count; i++)
                    if (cmbCpSaat.SelectedItem.ToString() == lbCpProgram.Items[i].Text)
                    { kontrol = false; break; }
                if (kontrol)
                {
                    int drId = FnkDoktorId();
                    prc.prc_TblCalismaSaatleri_insert(drId, cmbCpGun.SelectedItem.ToString(), cmbCpSaat.SelectedItem.ToString());
                    Response.Write("Eklendi");
                    doktorplanGoster();
                }
                else Response.Write("Aynı Kayıt var");
            }
        
        }

        protected void btnCpSil_Click(object sender, EventArgs e)
        {
            try
            {
                string saat = lbCpProgram.SelectedItem.ToString();
                int drId = FnkDoktorId();
                prc.prc_TblCalismaSaatleri_delete(drId, cmbCpGun.SelectedItem.ToString(), saat);
                doktorplanGoster();
                Response.Write("Silindi");
            }
            catch (Exception) { Response.Write("Bir Satır Seçiniz"); }

        }

        protected void cmbCpDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}