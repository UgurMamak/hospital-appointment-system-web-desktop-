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

    public partial class WfrmRandevu : System.Web.UI.Page
    {
        
        private List<Button> _butonListesi = new List<Button>();
        SqlDataReader reader,reader2;
        VtProcess prc = new VtProcess();
        int hastaneId, PolId, doktorId;
     public   string[] dizi = new string[2];
        public int bak = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("hastaIDDDDDD:"+ Session["hastaNo"]);

            if (!Page.IsPostBack)
            {

                reader = prc.prc_Iller_Select();
                while (reader.Read())
                    cmbSehir.Items.Add(reader[1].ToString());
                DateTime dtmin = DateTime.MinValue;
                dtmin = DateTime.Today.AddDays(1);
                string mindate = dtmin.ToString("yyyy-MM-dd");
                txtTarih.Attributes["min"] = mindate;

                DateTime dtmax = DateTime.Today.AddDays(15);
                string maxdate = dtmax.ToString("yyyy-MM-dd");
                txtTarih.Attributes["max"] = maxdate;
                Session["Butonlar"] = null;

               

            }
            if (Session["Butonlar"] != null) _butonListesi = (List<Button>)Session["Butonlar"];
            p1.Controls.Clear();
            ButonEkle();
            


        }

        protected void btnRandevual_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
       
        protected void btnRandevuGoruntule_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            //butonSil();
            cmbIlce.Items.Clear();
            cmbIlce.Items.Add("");

            cmbKlinik.Items.Clear();
            cmbKlinik.Items.Add("");

            cmbHastane.Items.Clear();
            cmbHastane.Items.Add("");

            cmbDoktor.Items.Clear();
            cmbDoktor.Items.Add("");

            reader = prc.proc_Ilceler_Select(cmbSehir.SelectedItem.ToString());
            while (reader.Read()) cmbIlce.Items.Add(reader[2].ToString());
        }

        protected void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            //butonSil();
            cmbKlinik.Items.Clear();
            cmbKlinik.Items.Add("");

            cmbHastane.Items.Clear();
            cmbHastane.Items.Add("");

            cmbDoktor.Items.Clear();
            cmbDoktor.Items.Add("");

            reader = prc.prc_TblHastane_selectById(cmbSehir.SelectedItem.ToString(), cmbIlce.SelectedItem.ToString());
            while (reader.Read()) cmbHastane.Items.Add(reader[3].ToString());
        }

        protected void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            //butonSil();
            
            cmbKlinik.Items.Clear();
            cmbKlinik.Items.Add("");
            cmbDoktor.Items.Clear();
            cmbDoktor.Items.Add("");
            int hstId = FnkHastaneId();
            reader = prc.prc_TblHastanedekiBolumler_Select();
            while (reader.Read())
                if (Convert.ToInt32(reader[1].ToString()) == hstId)
                    cmbKlinik.Items.Add(reader[3].ToString());
        }
        int FnkHastaneId()
        {

            reader = prc.prc_TblHastane_selectById(cmbSehir.SelectedItem.ToString(), cmbIlce.SelectedItem.ToString());
            while (reader.Read())
                if (cmbHastane.SelectedItem.ToString() == reader[3].ToString())
                    hastaneId = Convert.ToInt32(reader[0].ToString());
            return hastaneId;
        }

        int FnkKlinikId()
        {
            reader = prc.prc_TblPoliklinik_Select();
            while (reader.Read())
                if (reader[1].ToString() == cmbKlinik.SelectedItem.ToString())
                    PolId = Convert.ToInt32(reader[0].ToString());
            return PolId;
        }

        int FnkDoktorId()
        {
            reader = prc.prc_tblDoktor_select();
            while (reader.Read())
                if (cmbDoktor.SelectedItem.ToString() == reader[1].ToString() + " " + reader[2].ToString())
                    doktorId = Convert.ToInt32(reader[0].ToString());
            return doktorId;
        }

        protected void txtTarih_TextChanged(object sender, EventArgs e)
        {

            try
            {
                foreach (Button button in _butonListesi)
                {
                    if (button is Button)
                    {
                        p1.Controls.Remove(button);
                    }
                }
                _butonListesi.Clear();

                string t = txtTarih.Text.Replace("-", ".");
                Session["bak"] = 0;
                Session["u"] = 0;//i
                Session["a"] = 775;//x
                Session["sat"] = 0;
                int drId = FnkDoktorId();
                reader = prc.procRandevuTarih(txtTarih.Text, drId);
                while (reader.Read())
                {
                    var Buton2 = new Button();
                    Buton2.EnableViewState = true;
                    Buton2.Text = reader[1].ToString();
                    //Buton2.ID = "btn" + reader[1].ToString().Replace(":", "");
                    Buton2.Attributes.Add("style", new Location(Convert.ToInt32(Session["a"].ToString()), Convert.ToInt32(Session["u"].ToString()) * 40 + 120).ToString()); _butonListesi.Add(Buton2);
                    Session["Butonlar"] = _butonListesi;
                    if (Convert.ToInt32(Session["sat"]) < 5)
                    {
                        reader2 = prc.prc_tblRandevu_select();
                        while (reader2.Read())
                        {
                            if (reader2[6].ToString() == t && Buton2.Text == reader2[7].ToString())
                            { Buton2.Attributes.Add("class", "btnDolu"); _butonListesi.Add(Buton2); break; }
                            else { Buton2.Attributes.Add("class", "btnSaatBos"); _butonListesi.Add(Buton2); }
                        }
                        Session["u"] = Convert.ToInt32(Session["u"]) + 1;
                        Session["sat"] = Convert.ToInt32(Session["sat"]) + 1;
                        Buton2.Click += Buton2_Click;
                        ButonEkle();
                    }   //if


                    else
                    {
                        reader2 = prc.prc_tblRandevu_select();
                        while (reader2.Read())
                        {
                            if (reader2[6].ToString() == t && Buton2.Text == reader2[7].ToString())
                            { Buton2.Attributes.Add("class", "btnDolu"); _butonListesi.Add(Buton2); break; }
                            else { Buton2.Attributes.Add("class", "btnSaatBos"); _butonListesi.Add(Buton2); }
                        }
                        Session["sat"] = 0;
                        Session["u"] = 0;
                        Session["a"] = Convert.ToInt32(Session["a"]) + 70;

                        ButonEkle();
                        Buton2.Click += Buton2_Click;
                    }
                }//while
            }
            catch (Exception) { Response.Write("Eksik bilgiler var"); }
        }//txt


        protected void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {


            //butonSil();

        }

      

        protected void cmbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            //butonSil();         
            cmbDoktor.Items.Clear();
            cmbDoktor.Items.Add("");
            int hstId = FnkHastaneId();
            reader = prc.prc_tblDoktor_select();

            while (reader.Read())
                if (Convert.ToInt32(reader[5].ToString()) == hstId && cmbKlinik.SelectedItem.ToString() == reader[4].ToString())
                    cmbDoktor.Items.Add(reader[1].ToString() + " " + reader[2].ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
        }

                public bool kontrol = true;


        


        private void Buton2_Click(object sender, EventArgs e)
        {
            

                if (kontrol)
                {
                    int sayac = 0;
                    Button dinamikButon = (sender as Button);
                    string t = txtTarih.Text.Replace("-", ".");
                    reader2 = prc.prc_tblRandevu_select();
                    while (reader2.Read())
                    {
                        if (reader2[6].ToString() == t && dinamikButon.Text == reader2[7].ToString())
                        { sayac++; break; }
                    }
                    if (sayac == 1) { Response.Write("Bu Saat Dolu"); }
                    else if (sayac == 0)
                    {

                        int hstnId = FnkHastaneId();
                        int polId = FnkKlinikId();
                        int drId = FnkDoktorId();
                        int hastaId = Convert.ToInt32(Session["hastaNo"]);
                        string trh = txtTarih.Text.Replace("-", ".");
                        prc.prc_tblRandevu_insert(hstnId, polId, doktorId, trh, dinamikButon.Text, txtAciklama.Text, hastaId);
                        Response.Write("Randevu alındı.");
                        cmbSehir.Text = "";
                        cmbIlce.Items.Clear();
                        cmbHastane.Items.Clear();
                        cmbDoktor.Items.Clear();
                        cmbKlinik.Items.Clear();
                        txtAciklama.Text = "";
                        foreach (Button button in _butonListesi)
                        {
                            if (button is Button)
                            {
                                p1.Controls.Remove(button);
                            }
                        }
                        _butonListesi.Clear();
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

        

    }
}