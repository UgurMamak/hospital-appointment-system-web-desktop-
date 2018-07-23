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
    public class Location
    {
        private int x, y;
        
        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format("position: absolute; left: {0}px; top: {1}px; ", x, y);
        }
    }
    public partial class WfrmRandevu1 : System.Web.UI.Page
    {
        string[] dizi = new string[2];
        private List<Button> _butonListesi = new List<Button>();
        int hastaneid; int klinikID; int doktorID;
        SqlDataReader reader, reader2;
        VtProcess vt = new VtProcess();
        void SehirGoster()
        {
            reader = vt.prc_Iller_Select();
            cmbSehir.Items.Add("");
            while (reader.Read())
            {
                cmbSehir.Items.Add(reader[1].ToString());
            }
        }
		protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
            Label1.Visible = false;

            DateTime dtmin = DateTime.MinValue;
            dtmin = DateTime.Today.AddDays(1);
            string mindate = dtmin.ToString("yyyy-MM-dd");
            txtTarih.Attributes["min"] = mindate;
            DateTime dtmax = DateTime.Today.AddDays(15);
            string maxdate = dtmax.ToString("yyyy-MM-dd");
            txtTarih.Attributes["max"] = maxdate;
            if (!Page.IsPostBack)
            {
                Session["Butonlar"] = null;
                
                SehirGoster();
                
            }
            if (Session["Butonlar"] != null) _butonListesi = (List<Button>)Session["Butonlar"];
            p1.Controls.Clear();
            ButonEkle();
            int hastaid = Convert.ToInt32(Session["hastaID"]);
            Label2.Text = hastaid.ToString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
            Label1.Visible = true;

        }
        protected void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Items.Clear();
            cmbHastane.Items.Clear();
            cmbKlinik.Items.Clear();
            cmbDoktor.Items.Clear();
            reader = vt.proc_Ilceler_Select(cmbSehir.SelectedItem.ToString());
            cmbIlce.Items.Add("");
            while (reader.Read())
            {
                cmbIlce.Items.Add(reader[2].ToString());
            }
        }
        protected void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKlinik.Items.Clear();
            cmbDoktor.Items.Clear(); cmbHastane.Items.Clear();
            reader = vt.prc_TblHastane_selectById(cmbSehir.SelectedItem.ToString(), cmbIlce.SelectedItem.ToString());
            cmbHastane.Items.Add("");
            while (reader.Read())
            {
                cmbHastane.Items.Add(reader[3].ToString());
            }
        }
        protected void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKlinik.Items.Clear();
            cmbDoktor.Items.Clear();
            reader = vt.prc_TblHastane_selectById(cmbSehir.SelectedItem.ToString(), cmbIlce.SelectedItem.ToString());
            
            while (reader.Read())
            {
                if (cmbHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneid = Convert.ToInt32(reader[0].ToString());
            }
            reader = vt.prc_TblHastanedekiBolumler_Select();
            cmbKlinik.Items.Add("");
            while (reader.Read())
            {
                if (Convert.ToInt32(reader[1].ToString()) == hastaneid)
                    cmbKlinik.Items.Add(reader[3].ToString());
            }
        }
        int klinikID2()
        {
            reader = vt.prc_TblPoliklinik_Select(); ;
            while (reader.Read())
            {
                if (cmbKlinik.SelectedItem.ToString() == reader[1].ToString())
                {
                    klinikID = Convert.ToInt32(reader[0].ToString());
                }
}return klinikID;
        }
        protected void cmbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            reader = vt.prc_TblPoliklinik_Select(); ;
            while (reader.Read())
            {
                if (cmbKlinik.SelectedItem.ToString() == reader[1].ToString())
                {
                    klinikID = Convert.ToInt32(reader[0].ToString());
                }
            }
            cmbDoktor.Items.Clear();
            reader = vt.prc_TblHastane_selectById(cmbSehir.SelectedItem.ToString(), cmbIlce.SelectedItem.ToString());

            while (reader.Read())
            {
                if (cmbHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneid = Convert.ToInt32(reader[0].ToString());
            }
            reader = vt.prc_tblDoktor_select();
            cmbDoktor.Items.Add("");

            while (reader.Read())
            {
                if (hastaneid == Convert.ToInt32(reader[5].ToString()) && reader[4].ToString() == cmbKlinik.SelectedItem.ToString())
                    cmbDoktor.Items.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
        }
        int hastaneid2()
        {
            reader = vt.prc_TblHastane_selectById(cmbSehir.SelectedItem.ToString(), cmbIlce.SelectedItem.ToString());

            while (reader.Read())
            {
                if (cmbHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneid = Convert.ToInt32(reader[0].ToString());
            }
            return hastaneid;
        }
        protected void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            reader = vt.prc_tblDoktor_select();
            while (reader.Read())
            {
                if (cmbDoktor.SelectedItem.ToString() == reader[1] + " " + reader[2])
                {
                    doktorID = Convert.ToInt32(reader[0].ToString());
                }
            }
        }

        public bool kontrol = true;
        private void Buton2_Click(object sender, EventArgs e)
        {
            int hastaid = Convert.ToInt32(Session["hastaID"]);
            if (kontrol)
            {
                int sayac = 0;
                Button dinamikButon = (sender as Button);
                string t = txtTarih.Text.Replace("-", ".");
                reader2 = vt.prc_tblRandevu_select();
                while (reader2.Read())
                {
                    if (reader2[6].ToString() == t && dinamikButon.Text == reader2[7].ToString())
                    {
                        sayac++; break;
                    }
                }
                if (sayac == 1) { Response.Write("Bu randevu saati dolu."); }
                else if (sayac == 0)
                {
                    try
                    {
                        string t2 = txtTarih.Text.Replace("-", ".");
                        vt.prc_tblRandevu_insert(hastaneid2(), klinikID2(), FnkDoktorId(), t2, dinamikButon.Text, txtAciklama.Text, hastaid);
                        Response.Write("Randevu alındı.");
                        foreach (Button button in _butonListesi)
                        {
                            if (button is Button)
                            {
                                p1.Controls.Remove(button);
                            }
                        }
                        _butonListesi.Clear();
                        cmbIlce.Items.Clear();
                        cmbHastane.Items.Clear();
                        cmbKlinik.Items.Clear();
                        cmbDoktor.Items.Clear();
                        txtTarih.Text = "";

                        txtAciklama.Text = "";
                    }
                    catch (Exception)
                    {
                        Response.Write("Boş kısımları doldurmalısınız!");
                    }
                }

                kontrol = false;
            }
        }
                public void ButonEkle()
        {
            if (Session["Butonlar"] != null)
            {
                foreach (Button button in _butonListesi)
                {
                    button.Click += Buton2_Click;
                    p1.Controls.Add(button);
                }
            }
        }
        int FnkDoktorId()
        {
            reader = vt.prc_tblDoktor_select();
            while (reader.Read())
                if (cmbDoktor.SelectedItem.ToString() == reader[1].ToString() + " " + reader[2].ToString())
                    doktorID = Convert.ToInt32(reader[0].ToString());
            return doktorID;
        }
        public int bak;
        void butonsil()
        {
            foreach (Button button in _butonListesi)
            {
                if (button is Button)
                {
                    p1.Controls.Remove(button);
                }
            }
            _butonListesi.Clear();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
            Label1.Visible = false;
        }

        protected void txtTarih_TextChanged(object sender, EventArgs e)
        {
            try {
                string t = txtTarih.Text.Replace("-", ".");
                butonsil();
                Session["bak"] = 0;
                Session["u"] = 0;//i
                Session["a"] = 815;//x
                Session["sat"] = 0;
                int drId = FnkDoktorId();
                reader = vt.procRandevuTarih(txtTarih.Text, drId);
                while (reader.Read())
                {
                    var Buton2 = new Button();
                    Buton2.EnableViewState = true;
                    Buton2.Text = reader[1].ToString();
                    //Buton2.ID = "btn" + reader[1].ToString().Replace(":", "");
                    Buton2.Attributes.Add("style", new Location(Convert.ToInt32(Session["a"].ToString()), Convert.ToInt32(Session["u"].ToString()) * 40 + 470).ToString()); _butonListesi.Add(Buton2);
                    Session["Butonlar"] = _butonListesi;
                    if (Convert.ToInt32(Session["sat"]) < 5)
                    {
                        reader2 = vt.prc_tblRandevu_select();
                        while (reader2.Read())
                        {
                            if (reader2[6].ToString() == t && Buton2.Text == reader2[7].ToString())
                            {
                                Buton2.Attributes.Add("class", "redbutton"); _butonListesi.Add(Buton2); break;
                            }
                            else { Buton2.Attributes.Add("class", "greenbutton"); _butonListesi.Add(Buton2); }
                        }
                        Session["u"] = Convert.ToInt32(Session["u"]) + 1;
                        Session["sat"] = Convert.ToInt32(Session["sat"]) + 1;
                        Buton2.Click += Buton2_Click;
                        ButonEkle();
                    }   //if
                    else
                    {
                        reader2 = vt.prc_tblRandevu_select();
                        while (reader2.Read())
                        {
                            if (reader2[6].ToString() == t && Buton2.Text == reader2[7].ToString())
                            {
                                Buton2.Attributes.Add("class", "redbutton"); _butonListesi.Add(Buton2); break;
                            }
                            else { Buton2.Attributes.Add("class", "greenbutton"); _butonListesi.Add(Buton2); }
                        }
                        Session["sat"] = 0;
                        Session["u"] = 0;
                        Session["a"] = Convert.ToInt32(Session["a"]) + 85;
                        Buton2.Click += Buton2_Click;
                        ButonEkle();
                    } }
            }catch (Exception)
            {
                Response.Write("Eksik kısımları doldurmalısınız!!!");
            }
}

      
    }
}