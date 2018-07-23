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

    public partial class WfrmGiris : System.Web.UI.Page
    {
        VtProcess vt = new VtProcess();
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
        }
        
        protected void btnHGiris_Click(object sender, EventArgs e)
        {

            bool kontrol = false;

            if (txtHTc.Text == "" || txtHParola.Text == "")
                Response.Write("Boş Alan Bırakmayınız.");
            else
            {
                reader = vt.prc_TblHasta_select();
                while (reader.Read())
                {
                    if (reader[3].ToString() == txtHTc.Text && reader[7].ToString() == txtHParola.Text)
                    {
                        kontrol = true; Session["hastaID"] = Convert.ToInt32(reader[0].ToString()); break;
                    }
                }
                if (kontrol)
                {
                    Response.Redirect("WfrmRandevu.aspx");

                }
                else
                {
                    Response.Write("Kullanıcı adı veya parola hatalı.");
                }
            }
        }

        protected void btnYGiris_Click(object sender, EventArgs e)
        {

            bool kontrol = false;

            if (txtYTc.Text == "" || txtYParola.Text == "")
                Response.Write("Boş Alan Bırakmayınız.");
            else
            {
                reader = vt.prc_TblYonetici_Select();
                while (reader.Read())
                {
                    if (reader[3].ToString() == txtYTc.Text && reader[4].ToString() == txtYParola.Text) { kontrol = true; break; }
                }
                if (kontrol)
                {
                    Response.Redirect("WfrmAnaSayfa.aspx");

                }
                else
                {
                    Response.Write("Kullanıcı adı veya parola hatalı.");
                }
            }
        }

        protected void btnHKaydet_Click(object sender, EventArgs e)
        {
          
            bool kontrol = false;
            
            reader = vt.prc_TblHasta_select();
            while (reader.Read())
            {
                if (reader[3].ToString() == txtHKTc.Text) { Response.Write("Aynı Kullanıcı adı var"); kontrol = true; break; }
            }
            if (!kontrol)
            {
                if (txtHKTc.Text == "" || txtHKParola.Text == "" || txtHKParolaTekrar.Text == "" || txtHKAd.Text == "" || txtHKSoyad.Text == "" || txtHKTel.Text == "" || txtHKDogumTarihi.Text == "")
                    Response.Write("Boş Alan Bırakmayınız.");
                else
                {
                    if (txtHKParola.Text == txtHKParola.Text)
                    {
                        string cins;
                        if (rbErkek.Checked == true) cins = "E"; else cins = "K";
                        vt.prc_TblHasta_insert(txtHKAd.Text, txtHKSoyad.Text, txtHKTc.Text, txtHKTel.Text, txtHKDogumTarihi.Text.ToString(), cins, txtHKParola.Text);
                        Response.Write("Başarıyla Kaydedildi.");
                    }
                    else Response.Write("Şifreler eşleşmiyor.");
                }
            }
        }
    }
    }
