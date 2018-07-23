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
    public partial class WfrmYoneticiKayit : System.Web.UI.Page
    {
        SqlDataReader reader;
        VtProcess vt = new VtProcess();
        void YoneticiGoster()
        {
            lbYonetici.Items.Clear();
            reader = vt.prc_TblYonetici_Select();
            while (reader.Read())
            {
                lbYonetici.Items.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           if( !Page.IsPostBack)
            YoneticiGoster();
        }

        protected void btnYKaydet_Click(object sender, EventArgs e)
        {
         
            bool kontrol = false;
           
            reader = vt.prc_TblYonetici_Select();
            while (reader.Read())
            {
                if (reader[3].ToString() == txtYTC.Text) { Response.Write("Aynı Kullanıcı adı var"); kontrol = true; break; }
            }
            if (!kontrol)
            {
                if (txtYTC.Text==""||txtYSoyad.Text==""||txtYAd.Text==""||txtSifreTekrar.Text==""||txtSifre.Text=="")
                    Response.Write("Boş Alan Bırakmayınız.");
                else
                {
                    if (txtSifre.Text == txtSifreTekrar.Text)
                    {

                        vt.prc_TblYonetici_insert(txtYAd.Text, txtYSoyad.Text, txtYTC.Text, txtSifre.Text);
                        Response.Write("Başarıyla Kaydedildi.");
                        YoneticiGoster();
                    }
                    else Response.Write("Şifreler eşleşmiyor.");
                }
            }
        }

        protected void btnYSil_Click(object sender, EventArgs e)
        {
            reader = vt.prc_TblYonetici_Select();
            while (reader.Read())
            {
                yoneticiadi = lbYonetici.SelectedItem.ToString();
                if (yoneticiadi == reader[1].ToString() + " " + reader[2].ToString())
                {
                    yoneticitc = reader[3].ToString();
                }
            }
            if (lbYonetici.SelectedIndex < 0)
            {
                Response.Write("Lütfen silmek istediğiniz yöneticiyi seçiniz.");
            }
            else
            {
                vt.prc_TblYonetici_delete(yoneticitc);
                YoneticiGoster();
            }
        }
        string yoneticiadi, yoneticitc;
        protected void lbYonetici_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}