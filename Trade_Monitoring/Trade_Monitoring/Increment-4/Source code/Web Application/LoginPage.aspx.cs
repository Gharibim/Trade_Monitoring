using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ServiceReference1;
public partial class LoginPage : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string username = TextBox1.Text;
        string password = TextBox2.Text;

        string username11 = string.Empty;
        string password11 = string.Empty;

     

        if (username.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter User Name')</script>", false);
        }
        else if (password.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Password')</script>", false);
        }
        else
        {
            ds1 = obj.getdetails(username);


            if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
            {
                username11 = ds1.Tables[0].Rows[0]["username"].ToString();
                password11 = ds1.Tables[0].Rows[0]["password"].ToString();
            }


            if ((username == username11) && (password == password11))
            {
                Session["username"] = username;
                Session["loggedin"] = "created";
                Response.Redirect("userhome.aspx");
            }
            else if ((username == "admin123") && (password == "P@ssw0rd"))
            {
                Session["adminname"] = username;
                Session["loggedin"] = "created";
                Response.Redirect("Home.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('User Name or Password incorrect')</script>", false);
                //Response.Redirect(ResolveUrl("login.aspx"));
            }
        }


    }
}