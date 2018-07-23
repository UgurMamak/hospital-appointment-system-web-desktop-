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
    public partial class WfrnHastaneKayit : System.Web.UI.Page
    {
        SqlDataReader reader;
        VtProcess vt = new VtProcess();
        int hastaneID;
        void sehirGoster()
        {
            cmbHastaneSehir.Items.Add("");
            reader = vt.prc_Iller_Select();
            while (reader.Read()) { cmbHastaneSehir.Items.Add(reader[1].ToString()); }

            ilceGoster();
        }
        void ilceGoster()
        {
            cmbHastaneİlce.Enabled = true;
            cmbHastaneİlce.Items.Clear();
            cmbHastaneİlce.Items.Add("");
            reader = vt.proc_Ilceler_Select(cmbHastaneSehir.SelectedItem.ToString());
            while (reader.Read()) { cmbHastaneİlce.Items.Add(reader[2].ToString()); }

            HastaneGoster(cmbHastaneSehir.SelectedItem.ToString(), cmbHastaneİlce.SelectedItem.ToString());
            

        }
        void HastaneGoster( string il, string ilce)
        {
            reader = vt.prc_TblHastane_selectById(il, ilce);
            lbHastane.Items.Clear();
            while (reader.Read()) lbHastane.Items.Add(reader[3].ToString());

            txtAdres.Text = "";
            txtHastaneAdi.Text = "";

        }
        void HastaneKaydet()
        {
            if (cmbHastaneSehir.SelectedIndex<0 || cmbHastaneİlce.SelectedIndex<0 ||txtHastaneAdi.Text==""||txtAdres.Text=="")
            {
                Response.Write("Boş alan bırakmayınız.");
            }
            else
            {
                vt.prc_TblHastane_insert(cmbHastaneSehir.SelectedItem.ToString(), cmbHastaneİlce.SelectedItem.ToString(), txtHastaneAdi.Text, txtAdres.Text);
                Response.Write("Kaydedildi.");
                HastaneGoster( cmbHastaneSehir.SelectedItem.ToString(), cmbHastaneİlce.SelectedItem.ToString());
            }
        }
        int hastaneid()
        {
            if (lbHastane.SelectedIndex >= 0)
            {
                reader = vt.prc_TblHastane_selectById(cmbHastaneSehir.SelectedItem.ToString(), cmbHastaneİlce.SelectedItem.ToString());
                while (reader.Read())
                {
                    if (lbHastane.SelectedItem.ToString() == reader[3].ToString())
                    {
                        hastaneID = Convert.ToInt32(reader[0].ToString());
                    }
                }
            }
            return hastaneID;
        }

        protected void Page_Load(object sender, EventArgs e){

            if (!Page.IsPostBack)
                sehirGoster();


        }
        protected void cmbHastaneSehir_SelectedIndexChanged(object sender, EventArgs e){ilceGoster(); }

        protected void btnHastaneKaydet_Click(object sender, EventArgs e){HastaneKaydet();}

        protected void cmbHastaneİlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAdres.Text = "";
            txtHastaneAdi.Text = "";
            lbHastane.Items.Clear();
            HastaneGoster(cmbHastaneSehir.SelectedItem.ToString(), cmbHastaneİlce.SelectedItem.ToString());
        }
        protected void btnHastaneGüncelle_Click(object sender, EventArgs e)
        {
            if (lbHastane.SelectedIndex <= 0) Response.Write("Lütfen güncellemek istediğiniz öğeyi seçiniz.");
            else
            {
                if (txtHastaneAdi.Text == "" && txtAdres.Text == "") Response.Write("Boş alan bırakmayınız.");

                {
                    vt.prc_TblHastane_update(hastaneid(), cmbHastaneSehir.SelectedItem.ToString(), cmbHastaneİlce.SelectedItem.ToString(), txtHastaneAdi.Text, txtAdres.Text);
                    Response.Write("Güncellendi");
                    HastaneGoster(cmbHastaneSehir.SelectedItem.ToString(), cmbHastaneİlce.SelectedItem.ToString());
                }
            }
            
        }
        protected void lbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHastane.SelectedIndex >= 0)
            {
                reader = vt.prc_TblHastane_selectById(cmbHastaneSehir.SelectedItem.ToString(), cmbHastaneİlce.SelectedItem.ToString());
                while (reader.Read())
                {
                    if (lbHastane.SelectedItem.ToString() == reader[3].ToString())
                    {
                        hastaneID = Convert.ToInt32(reader[0].ToString());
                        txtHastaneAdi.Text = reader[3].ToString();
                        txtAdres.Text = reader[4].ToString();
                    }
                }
            }
        }
        protected void btnHastaneSil_Click(object sender, EventArgs e)
        {
            if (lbHastane.SelectedIndex < 0)
            {
                Response.Write("Lütfen silmek istediğiniz hastaneyi seçiniz.");
            }
            else
            {
                int a = hastaneid();
                vt.prc_TblHastane_Delete(a);
                Response.Write("Silme işlemi başarıyla gerçekleşti.");
                HastaneGoster(cmbHastaneSehir.SelectedItem.ToString(),cmbHastaneİlce.SelectedItem.ToString());
                txtAdres.Text = "";
                txtHastaneAdi.Text = "";
            }
        }
    }
}