using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Id : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        string fname = string.Empty;
        string lname = string.Empty;
        string id = string.Empty;
        string phone = string.Empty;
        string username = Convert.ToString(Session["username"]);

            ds = obj.membershipdetails(username);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                fname = ds.Tables[0].Rows[0]["fname"].ToString();
                lname = ds.Tables[0].Rows[0]["lname"].ToString();
                id = ds.Tables[0].Rows[0]["memshipid"].ToString();
                phone=ds.Tables[0].Rows[0]["phone"].ToString();
            }

            string name=fname+ " " +lname;
            Label2.Text = name;
            Label3.Text = id;
            Label4.Text = phone;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserHome.aspx");
    }
}