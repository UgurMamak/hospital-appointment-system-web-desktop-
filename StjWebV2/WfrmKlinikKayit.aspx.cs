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
    public partial class WfrmKlinikKayit : System.Web.UI.Page
    {
        VtProcess vt = new VtProcess();
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cmbKSehir.Items.Add("");
                reader = vt.prc_Iller_Select();
                while (reader.Read())
                {
                    cmbKSehir.Items.Add(reader[1].ToString());

                }
                reader = vt.prc_TblPoliklinik_Select();
                while (reader.Read())
                {
                    lbKlinik.Items.Add(reader[1].ToString());
                }
            }
        }
        

        protected void cmbKSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbKlinikHB.Items.Clear();
            cmbKIlce.Items.Clear();
            cmbKHastane.Items.Clear();
            cmbKIlce.Items.Add("");
            reader = vt.proc_Ilceler_Select(cmbKSehir.SelectedItem.ToString());
            while (reader.Read())
            {
                cmbKIlce.Items.Add(reader[2].ToString());
            }
        }

        protected void cmbKIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lbKlinikHB.Items.Clear();
            cmbKHastane.Items.Clear();
            cmbKHastane.Items.Add("");
            reader = vt.prc_TblHastane_selectById(cmbKSehir.SelectedItem.ToString(), cmbKIlce.SelectedItem.ToString());
            while (reader.Read())
            {
                cmbKHastane.Items.Add(reader[3].ToString());
            }
        }
        void hastanedekiBolumler()
        {
            reader = vt.prc_TblHastane_selectById(cmbKSehir.SelectedItem.ToString(), cmbKIlce.SelectedItem.ToString());
            while (reader.Read())
            {
                if (cmbKHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneid = Convert.ToInt32(reader[0].ToString());
            }
            lbKlinikHB.Items.Clear();
            reader = vt.prc_TblHastanedekiBolumler_Select();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader[1].ToString()) == hastaneid)
                    lbKlinikHB.Items.Add(reader[3].ToString());
            }
        }
        int hastaneid;
      
        protected void cmbKHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            reader = vt.prc_TblHastane_selectById(cmbKSehir.SelectedItem.ToString(), cmbKIlce.SelectedItem.ToString());
            while (reader.Read())
            {
                if (cmbKHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneid = Convert.ToInt32(reader[0].ToString());
            }
            hastanedekiBolumler();
        }

        protected void btnKlinikKaydet_Click(object sender, EventArgs e)
        {
            if (cmbKSehir.SelectedIndex>=0||cmbKIlce.SelectedIndex>=0||cmbKHastane.SelectedIndex>=0)
            {
                if (lbKlinik.SelectedIndex < 0) Response.Write("Bölüm seçiniz");
                else
                {
                    bool kontrol = true;
                    for (int i = 0; i < lbKlinikHB.Items.Count; i++)
                    {
                        if (lbKlinik.SelectedItem.ToString() == lbKlinikHB.Items[i].ToString())
                        {
                            kontrol = false; break;
                        }
                    }
                    if (kontrol)
                    {
                        vt.prc_TblHastanedekiBolumler_insert(cmbKHastane.SelectedItem.ToString(), lbKlinik.SelectedItem.ToString());
                        Response.Write("Hastaneye bölüm eklendi.");
                        hastanedekiBolumler();
                    }
                    else Response.Write("Bu bölüm zaten var");
                }
            }
            else Response.Write("Boş Alan Bırakmayınız");
        }
        int hastanebolumID;
        protected void btnKlinikSil_Click(object sender, EventArgs e)
        {
            reader = vt.prc_TblHastanedekiBolumler_Select();
            while (reader.Read())
            {
                if (lbKlinikHB.SelectedItem.ToString() == reader[3].ToString())
                {
                    hastanebolumID = Convert.ToInt32(reader[0].ToString());
                }
            }
            if (lbKlinikHB.SelectedIndex < 0)
            {
                Response.Write("Lütfen silmek istediğiniz hastaneyi seçiniz.");
            }
            else
            {
                vt.prc_TblHastanedekiBolumler_delete(hastanebolumID);
                Response.Write("Silme işlemi başarıyla gerçekleşti.");
                hastanedekiBolumler();
            }
        }
    }
}