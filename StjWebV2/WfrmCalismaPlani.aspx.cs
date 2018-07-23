using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataLayer;
namespace StjWebV2
{
    public partial class WfrmCalismaPlani : System.Web.UI.Page
    {
        VtProcess vt = new VtProcess();
        SqlDataReader reader;
        void sehirGoster()
        {
            reader = vt.prc_Iller_Select();
            while (reader.Read()) { cmbPSehir.Items.Add(reader[1].ToString()); }
            ilceGoster();
        }
        void HastaneGoster(string il, string ilce)
        {
            reader = vt.prc_TblHastane_selectById(il, ilce);
            cmbPHastane.Items.Clear();
            cmbPHastane.Items.Add("");
            while (reader.Read()) cmbPHastane.Items.Add(reader[3].ToString());
        }
        void ilceGoster()
        {
            cmbPIlce.Items.Clear();
            cmbPIlce.Items.Add("");
            reader = vt.proc_Ilceler_Select(cmbPSehir.SelectedItem.ToString());
            while (reader.Read()) { cmbPIlce.Items.Add(reader[2].ToString()); }
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                sehirGoster();
                
            }

        }

        protected void cmbPSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ilceGoster();
          
        }
        int hastaneid;
        protected void cmbPHastane_SelectedIndexChanged(object sender, EventArgs e)
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
            reader = vt.prc_tblDoktor_select();
            cmbPDoktor.Items.Add("");
            while (reader.Read())
            {
                if (Convert.ToInt32(reader[5].ToString()) == hastaneid)
                {
                    cmbPDoktor.Items.Add(reader[1].ToString() + " " + reader[2].ToString());
                }
            }
        }

        protected void cmbPIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            HastaneGoster(cmbPSehir.SelectedItem.ToString(), cmbPIlce.SelectedItem.ToString());
        }
        int doktorID;
        void DoktorPlanGoster()
        {
            lbPProgram.Items.Clear(); reader = vt.prc_tblDoktor_select();
            while (reader.Read())
            {
                string doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                if (cmbPDoktor.SelectedItem.ToString() == doktorAdSoyad)
                    doktorID = Convert.ToInt32(reader[0].ToString());
            }
            string gunisim = cmbPGun.SelectedItem.ToString();
            
            reader = vt.prc_TblCalismaSaatleri_Select();
            while (reader.Read())
            {
                if (gunisim == reader[5].ToString() && doktorID == Convert.ToInt32(reader[1].ToString()))
                    lbPProgram.Items.Add(reader[4].ToString());
            }
        }
        protected void cmbPGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPSaat.Items.Clear();
            if (cmbPGun.SelectedIndex >= 0)
            {

                reader = vt.prc_TblSaatler_Select();
                cmbPSaat.Items.Add("");
                while (reader.Read())
                {
                    if (cmbPGun.SelectedItem.ToString() == reader[2].ToString())
                        cmbPSaat.Items.Add(reader[1].ToString());
                }
                DoktorPlanGoster();
            }
        }

        protected void BtnHPKaydet_Click(object sender, EventArgs e)
        {
            
            if (cmbPSehir.SelectedIndex>=0||cmbPIlce.SelectedIndex>=0||cmbPHastane.SelectedIndex >= 0 || cmbPDoktor.SelectedIndex >= 0 || cmbPGun.SelectedIndex >= 0 || cmbPSaat.SelectedIndex >= 0)
            {
                bool kontrol = true;
                for (int i = 0; i < lbPProgram.Items.Count; i++)
                {
                    if (cmbPSaat.SelectedItem.ToString() == lbPProgram.Items[i].Text)
                    {
                        kontrol = false; break;
                    }
                }
                if (kontrol)
                {
                    lbPProgram.Items.Clear(); reader = vt.prc_tblDoktor_select();
                    while (reader.Read())
                    {
                        string doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                        if (cmbPDoktor.SelectedItem.ToString() == doktorAdSoyad)
                            doktorID = Convert.ToInt32(reader[0].ToString());
                    }
                    vt.prc_TblCalismaSaatleri_insert(doktorID, cmbPGun.SelectedItem.ToString(), cmbPSaat.SelectedItem.ToString());
                    Response.Write("Eklendi");
                    DoktorPlanGoster();
                }
                else { Response.Write("Bu saat zaten ekli."); }
            }
            else Response.Write("Boş Alan Bırakmayınız");
        }

        protected void btnHPSil_Click(object sender, EventArgs e)
        {
            try
            {
                reader = vt.prc_tblDoktor_select();
                while (reader.Read())
                {
                    string doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                    if (cmbPDoktor.SelectedItem.ToString() == doktorAdSoyad)
                        doktorID = Convert.ToInt32(reader[0].ToString());
                }
                string saat = lbPProgram.SelectedItem.ToString();
                vt.prc_TblCalismaSaatleri_delete(doktorID, cmbPGun.SelectedItem.ToString(), saat);
                DoktorPlanGoster();
                Response.Write("Silindi");
            }
            catch (Exception) { Response.Write("Bir Satır Seçiniz"); }
        }
    }
}