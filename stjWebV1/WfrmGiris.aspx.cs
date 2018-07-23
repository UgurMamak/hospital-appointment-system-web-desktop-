using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using DataLayer;
using System.Web.UI.WebControls;

namespace stjWebV1
{
    public partial class WfrmGiris : System.Web.UI.Page
    {
        SqlDataReader reader;
        VtProcess prc = new VtProcess();
        void butonolustur()
        {
          
                Button btn = new Button();
                btn.ID = "btn" + Session["num"].ToString();
                btn.Text = "btn" + Session["num"].ToString(); ;
                btn.Attributes.Add("class", "btnSaatBos");
                btn.Attributes.Add("style", new Location(Convert.ToInt32(Session["a"].ToString()), Convert.ToInt32(Session["u"].ToString()) * 40 + 120).ToString());
                p1.Controls.Add(btn);
                btn.Click += new EventHandler(deneme);
                Session["u"] = Convert.ToInt32(Session["u"]) + 1;
                Session["num"] = Convert.ToInt32(Session["num"]) + 1;           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["num"] = 0;          
            Session["a"] = 770;
            Session["u"] = 0;
            for (int i = 0; i < 5; i++)
            {
                //butonolustur();

            }
        }
        protected void deneme(object sender, EventArgs e)
        {
            Button dinamikButon = (sender as Button);
            Response.Write(dinamikButon.Text + " isimli butona tıkladınız");
            Response.Write("\n\ndeneme");
        }

    }
}