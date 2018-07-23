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
    public partial class WfrmYoneticiEkle : System.Web.UI.Page
    {
        VtProcess prc = new VtProcess();
        SqlDataReader reader;
        string yoneticiTc="";
        void yoneticiListele()
        {
            lbYonlist.Items.Clear();
            reader = prc.prc_TblYonetici_Select();
            while (reader.Read())
            {
                lbYonlist.Items.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            yoneticiListele();
        }

        protected void btnYonEkle_Click(object sender, EventArgs e)
        {
            
            bool kontrol = false;         
            reader = prc.prc_TblYonetici_Select();
            while (reader.Read())
            { if (reader[3].ToString() == txtYonTc.Text) { Response.Write("Aynı Kullanıcı adı var"); kontrol = true; break; } }
            if (!kontrol)
            {
                if (txtYonAd.Text==""||txtYonSoyad.Text==""||txtYonTc.Text==""||txtYonsifre.Text==""||txtYonSifreTekrar.Text=="")
                    Response.Write("Boş Alan Bırakmayınız.");
                else
                {
                    if (txtYonsifre.Text == txtYonSifreTekrar.Text)
                    {

                        prc.prc_TblYonetici_insert(txtYonAd.Text, txtYonSoyad.Text, txtYonTc.Text, txtYonsifre.Text);
                        Response.Write("Başarıyla Kaydedildi.");
                        yoneticiListele();
                    }
                    else Response.Write("Şifreler eşleşmiyor.");
                }
            }
        }

        protected void btnYonSil_Click(object sender, EventArgs e)
        {
            if (lbYonlist.SelectedIndex >= 0)
            {
                reader = prc.prc_TblYonetici_Select();
                while (reader.Read())
                {
                    string yonadsoyad = reader[1].ToString() + " " + reader[2].ToString();
                    if (lbYonlist.SelectedItem.ToString() == yonadsoyad)
                        yoneticiTc = reader[3].ToString();
                }
            }
            if (lbYonlist.SelectedIndex < 0) Response.Write("seçili değil");
           else
            {
                prc.prc_TblYonetici_delete(yoneticiTc);
                Response.Write("Silindi");
                yoneticiListele();
            }

        }
    }
}