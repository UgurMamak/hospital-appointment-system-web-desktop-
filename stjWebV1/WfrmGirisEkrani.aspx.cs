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
    public partial class WfrmGirisEkrani : System.Web.UI.Page
    {
        VtProcess prc = new VtProcess();
        SqlDataReader reader;
        public static int hastaNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void btnHastaGiris_Click(object sender, EventArgs e)
        {
            
            bool kontrol = false;
          
            if (txtHastaGirisTc.Text==""||TxtHastaGirisSifre.Text=="") Response.Write("Boş Alan Bırakmayınız.");
            else
            {
                reader = prc.prc_TblHasta_select();
                while (reader.Read())
                {
                    if (reader[3].ToString() == txtHastaGirisTc.Text && reader[7].ToString() == TxtHastaGirisSifre.Text)
                    { kontrol = true; Session["hastaNo"] = Convert.ToInt32(reader[0].ToString()); break; }
                }
                if (kontrol)
                {                    
                    Response.Redirect("WfrmRandevu.aspx");
                }
                else
                    Response.Write("Kullanıcı adı veya şifre hatalı");

            }

        }

        protected void btnYonGiris_Click(object sender, EventArgs e)
        {

          
            bool kontrol = false;
          
            if (TxtYonTc.Text==""||TxtYonSifre.Text=="") Response.Write("Boş Alan Bırakmayınız.");
            else
            {
                reader = prc.prc_TblYonetici_Select();
                while (reader.Read())
                {
                    if (reader[3].ToString() == TxtYonTc.Text && reader[4].ToString() == TxtYonSifre.Text)
                    { kontrol = true; break; }

                }
                if (kontrol)
                {
                    Response.Redirect("WfrmAnaSayfa.aspx");
                }
                else
                    Response.Write("Kullanıcı adı veya şifre hatalı");

            }
        }

        protected void BtnHastaKayit_Click(object sender, EventArgs e)
        {
           
            bool kontrol = false;
           
            reader = prc.prc_TblHasta_select();
            while (reader.Read())
            { if (reader[3].ToString() == txtHastakytTc.Text) { Response.Write("Aynı Kullanıcı adı var"); kontrol = true; break; } }
            if (!kontrol)
            {
                if (txtHastakytTc.Text==""||TxtHKytSifre.Text==""||TxtHsKytSifreTekrar.Text==""||TxtHastaAd.Text==""||TxtHastaSoyad.Text==""||TxtHastaTel.Text==""||TxtHastDogumTar.Text=="")
                    Response.Write("Boş Alan Bırakmayınız.");
                else
                {
                    if (TxtHKytSifre.Text == TxtHsKytSifreTekrar.Text)
                    {
                        string cins;
                        if (RbErkek.Checked == true) cins = "E"; else cins = "K";
                        prc.prc_TblHasta_insert(TxtHastaAd.Text, TxtHastaSoyad.Text, txtHastakytTc.Text, TxtHastaTel.Text, TxtHastDogumTar.Text, cins, TxtHKytSifre.Text);
                        Response.Write("Başarıyla Kaydedildi.");
                    }
                    else Response.Write("Şifreler eşleşmiyor.");
                }
            }
        }

        protected void RbKadin_CheckedChanged(object sender, EventArgs e)
        {
           
          
            
        }

        protected void RbErkek_CheckedChanged(object sender, EventArgs e)
        {
            

        }
    }
}