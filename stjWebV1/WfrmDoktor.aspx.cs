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
    public partial class WfrmDoktor : System.Web.UI.Page
    {
        VtProcess prc = new VtProcess();
        SqlDataReader reader;
        int hastaneId; int hastaneBolumId,doktorId;
        void ilGoster()
        {

            cmbDoktorIlce.Items.Clear();
            cmbDoktorHastane.Items.Clear();
            cmbDoktorKlinik.Items.Clear();
            cmbDoktorKlinik.Items.Add("");
            reader = prc.prc_Iller_Select();
            while (reader.Read()) cmbDoktorIl.Items.Add(reader[1].ToString());

        }
        void ilceGoster()
        {
            cmbDoktorHastane.Items.Clear();
            cmbDoktorHastane.Items.Add("");
            cmbDoktorIlce.Items.Clear();
            cmbDoktorIlce.Items.Add("");
            cmbDoktorKlinik.Items.Clear();
            cmbDoktorKlinik.Items.Add("");
            reader = prc.proc_Ilceler_Select(cmbDoktorIl.SelectedItem.ToString());
            while (reader.Read()) cmbDoktorIlce.Items.Add(reader[2].ToString());
        }
        void HastaneGoster()
        {
            cmbDoktorHastane.Items.Clear();
            cmbDoktorHastane.Items.Add("");
            cmbDoktorKlinik.Items.Clear();
            cmbDoktorKlinik.Items.Add("");
            reader = prc.prc_TblHastane_selectById(cmbDoktorIl.SelectedItem.ToString(), cmbDoktorIlce.SelectedItem.ToString());
            while (reader.Read()) cmbDoktorHastane.Items.Add(reader[3].ToString());
        }
        int FnkHastaneId()
        {

            reader = prc.prc_TblHastane_selectById(cmbDoktorIl.SelectedItem.ToString(), cmbDoktorIlce.SelectedItem.ToString());
            while (reader.Read())
                if (cmbDoktorHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneId = Convert.ToInt32(reader[0].ToString());
            return hastaneId;
        }
        void hastanedekiBolumler()
        {
            int HstId = FnkHastaneId();
           cmbDoktorKlinik.Items.Clear();
            cmbDoktorKlinik.Items.Add("");
            reader = prc.prc_TblHastanedekiBolumler_Select();
            while (reader.Read())
                if (Convert.ToInt32(reader[1].ToString()) == HstId)
                    cmbDoktorKlinik.Items.Add(reader[3].ToString());
        }

        void DoktorGoster()
        {
            int hstId = FnkHastaneId();
            lbHastanedekiDktr.Items.Clear();
            reader = prc.prc_tblDoktor_select();
            while (reader.Read())
                if (Convert.ToInt32(reader[5].ToString()) == hstId && cmbDoktorKlinik.SelectedItem.ToString() == reader[4].ToString())
                    lbHastanedekiDktr.Items.Add(reader[1].ToString() + " " + reader[2].ToString());
        }

        int FnkDoktorId()
        {
            if (lbHastanedekiDktr.SelectedIndex >= 0)
            {
                reader = prc.prc_tblDoktor_select();
                while (reader.Read())
                {
                    string doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                    if (lbHastanedekiDktr.SelectedItem.ToString() == doktorAdSoyad)
                    {
                        doktorId = Convert.ToInt32(reader[0].ToString());
                        
                    }

                }
            }
            return doktorId;
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ilGoster();
               
            }
        }

        protected void cmbDoktorIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceGoster();
        }

        protected void cmbDoktorIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            HastaneGoster();
        }

        protected void cmbDoktorHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            hastanedekiBolumler();
        }

        protected void cmbDoktorKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoktorGoster();
        }

        protected void btnDoktorEkle_Click(object sender, EventArgs e)
        {
           
                if (cmbDoktorIl.SelectedIndex<=0||cmbDoktorIlce.SelectedIndex<=0||cmbDoktorHastane.SelectedIndex<=0||cmbDoktorKlinik.SelectedIndex<=0||txtAdi.Text==""||txtSoyadi.Text==""||txtTel.Text=="") 
            Response.Write("Boş Alan Bırakmayınız.");
            else { 
                bool kontrol = true;
                string doktorAdsoyad = txtAdi.Text + " " + txtSoyadi.Text;
                for (int i = 0; i < lbHastanedekiDktr.Items.Count; i++)
                    if (doktorAdsoyad == lbHastanedekiDktr.Items[i].ToString())
                    { kontrol = false; break; }
                if (kontrol)
                {
                    prc.prc_tblDoktor_insert(txtAdi.Text, txtSoyadi.Text, txtTel.Text, cmbDoktorKlinik.SelectedItem.ToString(), cmbDoktorHastane.SelectedItem.ToString());
                    Response.Write("Eklendi");
                    DoktorGoster();
                }
                else Response.Write("Aynı kayıt var.");

            }
            
        }

        protected void lbHastanedekiDktr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHastanedekiDktr.SelectedIndex >= 0)
            {
                reader = prc.prc_tblDoktor_select();
                while (reader.Read())
                {
                    string doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                    if (lbHastanedekiDktr.SelectedItem.ToString() == doktorAdSoyad)
                    {                       
                        txtAdi.Text = reader[1].ToString();
                        txtSoyadi.Text = reader[2].ToString();
                        txtTel.Text = reader[3].ToString();
                    }

                }
            }
        }

        protected void btnDoktorSil_Click(object sender, EventArgs e)
        {
            if (lbHastanedekiDktr.SelectedIndex < 0) Response.Write("seçili değil");
            else
            {
                prc.prc_tblDoktor_delete(FnkDoktorId());
                Response.Write("Silindi");
                DoktorGoster();
            }
        }

        protected void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {

            if (cmbDoktorIl.SelectedIndex <= 0 || cmbDoktorIlce.SelectedIndex <= 0 || cmbDoktorHastane.SelectedIndex <= 0 || cmbDoktorKlinik.SelectedIndex <= 0 || txtAdi.Text == "" || txtSoyadi.Text == "" || txtTel.Text == "")
                Response.Write("Boş Alan Bırakmayınız.");
            else
            {
                int doktorId = FnkDoktorId();
                prc.prc_tblDoktor_update(doktorId, txtAdi.Text, txtSoyadi.Text, txtTel.Text, cmbDoktorKlinik.SelectedItem.ToString(), cmbDoktorHastane.SelectedItem.ToString());
                Response.Write("Güncellendi");
            }
            }
    }
}