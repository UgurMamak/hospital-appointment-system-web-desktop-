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
    public partial class WfrmSaatKayit : System.Web.UI.Page
    {
        SqlDataReader reader;
        VtProcess vt = new VtProcess();
        int saatID;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void Saat()
        {
            lbSaat.Items.Clear();
            reader = vt.prc_TblSaatler_Select();
            while (reader.Read())
            {
                if (cmbGun.SelectedItem.ToString() == reader[2].ToString())
                {
                    lbSaat.Items.Add(reader[1].ToString());
                }
            }
        }

        protected void cmbGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            Saat();
        }

        protected void btnSKaydet_Click(object sender, EventArgs e)
        {
            if (cmbGun.SelectedIndex < 0)
            {
                Response.Write("Lütfen bir gün seçiniz.");
            }
            else if (cmbGun.SelectedItem.ToString() == "") Response.Write("Farklı bir seçim yapınız");

            else
            {
                bool kontrol = true;
                for (int i = 0; i < lbSaat.Items.Count; i++)
                {
                    if (txtSSaat.Text + ":00" == lbSaat.Items[i].ToString())
                    {
                        kontrol = false; break;
                    }
                }
                if (kontrol)
                {
                    vt.prc_TblSaatler_insert(txtSSaat.Text, cmbGun.SelectedItem.ToString());
                    Response.Write("Saat kaydedildi.");
                    Saat();
                }
                else { Response.Write("Bu saat zaten var."); }
            }
        }

        protected void btnSSİl_Click(object sender, EventArgs e)
        {
            reader = vt.prc_TblSaatler_Select();
            while (reader.Read())
            {
                if (lbSaat.SelectedItem.ToString() == reader[1].ToString() && cmbGun.SelectedItem.ToString() == reader[2].ToString())
                {
                    saatID = Convert.ToInt32(reader[0]);
                }
            }
            if (lbSaat.SelectedIndex < 0)
            {
                Response.Write("Lütfen silmek istediğiniz saati seçiniz.");
            }
            else
            {
                vt.prc_TblSaatler_delete(saatID);
                Saat();
            }

        }
    }
}