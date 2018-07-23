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
    public partial class WfrmDoktorKayit : System.Web.UI.Page
    {
        VtProcess vt = new VtProcess();
        SqlDataReader reader; int doktorid;
        void sehirGoster()
        {
            reader = vt.prc_Iller_Select();
            cmbDSehir.Items.Add("");
            while (reader.Read()) { cmbDSehir.Items.Add(reader[1].ToString()); }
            ilceGoster();
        }
        void HastaneGoster(string il, string ilce)
        {
            reader = vt.prc_TblHastane_selectById(il, ilce);
            
            cmbDHastane.Items.Clear(); cmbDHastane.Items.Add("");
            while (reader.Read()) cmbDHastane.Items.Add(reader[3].ToString());
        }
        void ilceGoster()
        {
            cmbDIlce.Enabled = true;
            cmbDIlce.Items.Clear();
            cmbDIlce.Items.Add("");
            reader = vt.proc_Ilceler_Select(cmbDSehir.SelectedItem.ToString());
            while (reader.Read()) { cmbDIlce.Items.Add(reader[2].ToString()); }


        }

        int hastaneklinikID;
        void KlinikGoster()
        {
            txtDAd.Text = "";
            txtDSoyad.Text = "";
            txtDTel.Text = "";
            lbDoktor.Items.Clear(); cmbDKlinik.Items.Clear();
            reader = vt.prc_TblHastane_selectById(cmbDSehir.SelectedItem.ToString(), cmbDIlce.SelectedItem.ToString());
            while (reader.Read())
            {
                if (cmbDHastane.SelectedItem.ToString() == reader[3].ToString())
                {
                    hastaneklinikID = Convert.ToInt32(reader[0].ToString());

                }
            }
            reader = vt.prc_TblHastanedekiBolumler_Select();
            cmbDKlinik.Items.Add("");
            while (reader.Read())
            {
                if (hastaneklinikID == Convert.ToInt32(reader[1].ToString()))
                {
                    cmbDKlinik.Items.Add(reader[3].ToString());
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                sehirGoster();

            }
        }

        protected void cmbDSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ilceGoster();
        }

        protected void cmbDIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDHastane.Items.Add("");
            HastaneGoster(cmbDSehir.SelectedItem.ToString(), cmbDIlce.SelectedItem.ToString());
        }

        protected void cmbDHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDKlinik.Items.Add("");
            KlinikGoster();
        }
        void DoktorGoster()
        {
            reader = vt.prc_TblHastane_selectById(cmbDSehir.SelectedItem.ToString(), cmbDIlce.SelectedItem.ToString());
            while (reader.Read())
            {
                if (cmbDHastane.SelectedItem.ToString() == reader[3].ToString())
                {
                    hastaneklinikID = Convert.ToInt32(reader[0].ToString());
                }
            }
            lbDoktor.Items.Clear();
            reader = vt.prc_tblDoktor_select();
            while (reader.Read())
            {
                if (hastaneklinikID == Convert.ToInt32(reader[5].ToString()) && reader[4].ToString() == cmbDKlinik.SelectedItem.ToString())
                    lbDoktor.Items.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
        }
        protected void cmbDKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDAd.Text = "";
            txtDSoyad.Text = "";
            txtDTel.Text = "";
            lbDoktor.Items.Clear(); DoktorGoster();

        }

        protected void btnDKaydet_Click(object sender, EventArgs e)
        {

            if (cmbDSehir.SelectedIndex < 0 || cmbDIlce.SelectedIndex < 0 || cmbDHastane.SelectedIndex < 0 || cmbDKlinik.SelectedIndex < 0 || txtDAd.Text == "" || txtDSoyad.Text == "" || txtDTel.Text == "")
            {
                Response.Write("Boş alan bırakmayınız.");
            }
            else
            {
                bool kontrol = true;
                for (int i = 0; i < lbDoktor.Items.Count; i++)
                {
                    if (txtDAd.Text + " " + txtDSoyad.Text == lbDoktor.Items[i].ToString())
                    {
                        kontrol = false; break;
                    }
                }
                if (kontrol)
                {
                    vt.prc_tblDoktor_insert(txtDAd.Text, txtDSoyad.Text, txtDTel.Text, cmbDKlinik.SelectedItem.ToString(), cmbDHastane.SelectedItem.ToString());
                    Response.Write("Doktor Kaydedildi.");
                    DoktorGoster();
                }
                else { Response.Write("Aynı doktor zaten var."); }
            }
        }
        int doktorID()
        {

            reader = vt.prc_tblDoktor_select();
            while (reader.Read())
            {
                string doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                if (lbDoktor.SelectedItem.ToString() == doktorAdSoyad)
                {
                    doktorid = Convert.ToInt32(reader[0].ToString());

                }
            }

            return doktorid;
        }
        protected void btnDGuncelle_Click(object sender, EventArgs e)
        {
            vt.prc_tblDoktor_update(doktorID(), txtDAd.Text, txtDSoyad.Text, txtDTel.Text, cmbDKlinik.SelectedItem.ToString(), cmbDHastane.SelectedItem.ToString());
            Response.Write("Güncellendi");
        }

        protected void lbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDoktor.SelectedIndex >= 0)
            {
                reader = vt.prc_tblDoktor_select();
                while (reader.Read())
                {
                    string doktorAdSoyad = reader[1].ToString() + " " + reader[2].ToString();
                    if (lbDoktor.SelectedItem.ToString() == doktorAdSoyad)
                    {
                        doktorid = Convert.ToInt32(reader[0].ToString());
                        txtDAd.Text = reader[1].ToString();
                        txtDSoyad.Text = reader[2].ToString();
                        txtDTel.Text = reader[3].ToString();
                    }
                }
            }
        }
 
        protected void btnDSil_Click(object sender, EventArgs e)
        {
            if (lbDoktor.SelectedIndex < 0)
            {
                Response.Write("Lütfen silmek istediğiniz doktoru seçiniz.");
            }
            else
            {
                    vt.prc_tblDoktor_delete(doktorID());
                    Response.Write("Doktor başarıyla silindi.");
                    DoktorGoster();
                }
            }
        }
    }
