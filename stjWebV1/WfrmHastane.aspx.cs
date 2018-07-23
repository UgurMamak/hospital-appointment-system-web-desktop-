using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;
using System.Data.SqlClient;

namespace stjWebV1
{
    public partial class WfrmHastane : System.Web.UI.Page
    {

        VtProcess prc = new VtProcess();
        SqlDataReader reader;
        int hastaneId;


        void ilGoster()
        {
            
            reader = prc.prc_Iller_Select();
           while (reader.Read())  cmbHastaneIl.Items.Add(reader[1].ToString());
            
        }
        void ilceGoster()
        {
            txtHastaneAd.Text = "";
            txtHastaneAdres.Text = "";         
            cmbHastaneIlce.Items.Clear();
            cmbHastaneIlce.Items.Add("");
            reader = prc.proc_Ilceler_Select(cmbHastaneIl.SelectedItem.ToString());
            while (reader.Read()) cmbHastaneIlce.Items.Add(reader[2].ToString()); 
        }  
        void HastaneGoster()
        {
            reader = prc.prc_TblHastane_selectById(cmbHastaneIl.SelectedItem.ToString(),cmbHastaneIlce.SelectedItem.ToString());           
                LbHastane.Items.Clear();
                while (reader.Read()) LbHastane.Items.Add(reader[3].ToString());          
        }
        void HastaneKaydet()
        {
            prc.prc_TblHastane_insert(cmbHastaneIl.SelectedItem.ToString(), cmbHastaneIlce.SelectedItem.ToString(), txtHastaneAd.Text, txtHastaneAdres.Text);           
        }
        void HastaneSil()
        {            
            if (LbHastane.SelectedIndex < 0) Response.Write("seçili değil");
            else
            {
                int hstnId = FnkHastaneId();
                prc.prc_TblHastane_Delete(hstnId);
                Response.Write("Silindi");
                txtHastaneAdres.Text = "";
                txtHastaneAd.Text = "";                
            }
        }

        int FnkHastaneId()
        {   
                reader = prc.prc_TblHastane_selectById(cmbHastaneIl.SelectedItem.ToString(), cmbHastaneIlce.SelectedItem.ToString());
                while (reader.Read())               
                    if (LbHastane.SelectedItem.ToString() == reader[3].ToString())                    
                        hastaneId = Convert.ToInt32(reader[0].ToString());                                                                  
            return hastaneId;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            ilGoster();
        }

        protected void cmbHastaneIl_SelectedIndexChanged(object sender, EventArgs e){ ilceGoster();}

        protected void cmbHastaneIlce_SelectedIndexChanged(object sender, EventArgs e){HastaneGoster();}

        protected void btnHastaneKaydet_Click(object sender, EventArgs e)
        {
            bool durum = true;
            if(cmbHastaneIl.SelectedIndex<=0 ||cmbHastaneIlce.SelectedIndex<=0||txtHastaneAd.Text==""||txtHastaneAdres.Text=="")
                Response.Write("Boş alan bırakmayın");
            else { HastaneKaydet(); Response.Write("kaydedildi");HastaneGoster(); txtHastaneAd.Text = "";txtHastaneAdres.Text = ""; }                    
        }

        protected void LbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbHastane.SelectedIndex >= 0)
            {
                reader = prc.prc_TblHastane_selectById(cmbHastaneIl.SelectedItem.ToString(), cmbHastaneIlce.SelectedItem.ToString());
                while (reader.Read())                
                    if (LbHastane.SelectedItem.ToString() == reader[3].ToString())
                    {
                        txtHastaneAd.Text = reader[3].ToString();
                        txtHastaneAdres.Text = reader[4].ToString();
                    }               
            }
        }

        protected void btnHastaneSil_Click(object sender, EventArgs e){HastaneSil();HastaneGoster();}

        protected void btnHastaneGuncelle_Click(object sender, EventArgs e)
        {
            if (LbHastane.SelectedIndex < 0) Response.Write("Seçili değil");
            else
            {
                prc.prc_TblHastane_update(FnkHastaneId(),cmbHastaneIl.SelectedItem.ToString(), cmbHastaneIlce.SelectedItem.ToString(), txtHastaneAd.Text, txtHastaneAdres.Text);
                Response.Write("Güncellendi");HastaneGoster();
            }
        }
    }
}