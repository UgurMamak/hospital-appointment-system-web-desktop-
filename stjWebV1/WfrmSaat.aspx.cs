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
    public partial class WfrmSaat : System.Web.UI.Page
    {
        VtProcess prc = new VtProcess();
        SqlDataReader reader; int saatId;
        void GunSaatGoster()
        {
            lbSaatListe.Items.Clear();
            reader = prc.prc_TblSaatler_Select();
            while (reader.Read())
                if (cmbSaatGun.SelectedItem.ToString() == reader[2].ToString())
                    lbSaatListe.Items.Add(reader[1].ToString());
        }

        





        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmbSaatGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            GunSaatGoster();
        }

        protected void btnSaatEkle_Click(object sender, EventArgs e)
        {
            if (cmbSaatGun.SelectedIndex >= 0)
            {
                bool kontrol = true;
                for (int i = 0; i < lbSaatListe.Items.Count; i++)
                    if (txtSaat.Text + ":00" == lbSaatListe.Items[i].ToString())
                    { kontrol = false; break; }

                if (kontrol)
                {
                    prc.prc_TblSaatler_insert(txtSaat.Text, cmbSaatGun.SelectedItem.ToString());
                    Response.Write("Kaydedildi");
                    GunSaatGoster();
                }
                else Response.Write("Aynı saat zaten var.");
            }
            else Response.Write("Boş alan bırakmayın");
        }

        protected void btnSaatSil_Click(object sender, EventArgs e)
        {
            
            if (lbSaatListe.SelectedIndex >= 0)
            {
                reader = prc.prc_TblSaatler_Select();
                while (reader.Read())
                    if (lbSaatListe.SelectedItem.ToString() == reader[1].ToString() && cmbSaatGun.SelectedItem.ToString() == reader[2].ToString())
                        saatId = Convert.ToInt32(reader[0].ToString());
            }
            if (lbSaatListe.SelectedIndex < 0)
                Response.Write("Silmek istediğiniz saatini seçiniz");
            else
            {
                prc.prc_TblSaatler_delete(saatId);
                Response.Write("Silindi");
                GunSaatGoster();
            }
        }
    }
}