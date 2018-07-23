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
    public partial class WfrmKlinik : System.Web.UI.Page
    {
        VtProcess prc = new VtProcess();
        SqlDataReader reader;
        int hastaneId;int hastaneBolumId;

        void ilGoster()
        {
            
            cmbKlinikIlce.Items.Clear();
            CmbKlinikHastane.Items.Clear();
            LbHastanediKlinikler.Items.Clear();
            reader = prc.prc_Iller_Select();
            while (reader.Read()) cmbKlinikIl.Items.Add(reader[1].ToString());

        }
        void ilceGoster()
        {
            CmbKlinikHastane.Items.Clear();
            CmbKlinikHastane.Items.Add("");                  
            cmbKlinikIlce.Items.Clear();
            cmbKlinikIlce.Items.Add("");
            reader = prc.proc_Ilceler_Select(cmbKlinikIl.SelectedItem.ToString());
            while (reader.Read()) cmbKlinikIlce.Items.Add(reader[2].ToString());
        }
        void HastaneGoster()
        {
            CmbKlinikHastane.Items.Clear();
            CmbKlinikHastane.Items.Add("");
            reader = prc.prc_TblHastane_selectById(cmbKlinikIl.SelectedItem.ToString(), cmbKlinikIlce.SelectedItem.ToString());           
            while (reader.Read()) CmbKlinikHastane.Items.Add(reader[3].ToString());
        }
        int FnkHastaneId()
        {
            
            reader = prc.prc_TblHastane_selectById(cmbKlinikIl.SelectedItem.ToString(), cmbKlinikIlce.SelectedItem.ToString());
            while (reader.Read())
                if (CmbKlinikHastane.SelectedItem.ToString() == reader[3].ToString())
                     hastaneId = Convert.ToInt32(reader[0].ToString());
            return hastaneId;
        }
        void hastanedekiBolumler()
        {
            int HstId = FnkHastaneId();
            LbHastanediKlinikler.Items.Clear();
            reader = prc.prc_TblHastanedekiBolumler_Select();
            while (reader.Read())
                if (Convert.ToInt32(reader[1].ToString()) ==HstId)
                    LbHastanediKlinikler.Items.Add(reader[3].ToString());
        }
        void bolumler()
        {
            reader = prc.prc_TblPoliklinik_Select();
            while (reader.Read()) lbKlinik.Items.Add(reader[1].ToString());
        }


       int FnkHastanedekiKlinikId()
        {
            
                reader = prc.prc_TblHastanedekiBolumler_Select();
                while (reader.Read())
                    if (LbHastanediKlinikler.SelectedItem.ToString() == reader[3].ToString())
                        hastaneBolumId = Convert.ToInt32(reader[0].ToString());

            return hastaneBolumId;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ilGoster();
                bolumler();
            }
        }

        protected void cmbKlinikIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceGoster();
            
        }

        protected void CmbKlinikHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            hastanedekiBolumler();
        }

        protected void cmbKlinikIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            HastaneGoster();
        }

        protected void LbHastanediKlinikler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbHastanediKlinikler.SelectedIndex >= 0)
                FnkHastanedekiKlinikId();
        }

        protected void btnKlinikKaydet_Click(object sender, EventArgs e)
        {
            bool durum = true;
            foreach (Control tb in this.Controls)
                if (cmbKlinikIl.SelectedIndex <= 0 || cmbKlinikIlce.SelectedIndex <= 0 || CmbKlinikHastane.SelectedIndex <= 0 || lbKlinik.SelectedIndex < 0)
                    Response.Write("Boş Alan Bırakmayınız");
                else
                {
                    if (lbKlinik.SelectedIndex < 0) Response.Write("Bölüm seçiniz");
                    else
                    {
                        bool kontrol = true;
                        for (int i = 0; i < LbHastanediKlinikler.Items.Count; i++)
                        {
                            if (lbKlinik.SelectedItem.ToString() == LbHastanediKlinikler.Items[i].ToString())
                            { kontrol = false; break; }
                        }
                        if (kontrol)
                        {
                            prc.prc_TblHastanedekiBolumler_insert(CmbKlinikHastane.SelectedItem.ToString(), lbKlinik.SelectedItem.ToString());
                            Response.Write("Hastaneye bölüm eklendi.");
                            hastanedekiBolumler();
                        }
                        else Response.Write("Bu bölüm zaten var");
                    }
                }
            
        }

        protected void btnKlinikSil_Click(object sender, EventArgs e)
        {
            if (LbHastanediKlinikler.SelectedIndex < 0)
                Response.Write("seçili değil");
            else
            {
                prc.prc_TblHastanedekiBolumler_delete(FnkHastanedekiKlinikId());
                Response.Write("Silindi");
                hastanedekiBolumler();
            }
        }
    }
}