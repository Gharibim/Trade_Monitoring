using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        string id = TextBox1.Text;
        string password = TextBox2.Text;

        if (id == "")
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('Please enter the User ID');", true);
        }
        else if (password == "")
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('Please enter Password');", true);
        }
        else if ((id != "589874")&&(password=="P@ssw0rd"))
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('Incorrect User ID ');", true);
        }
        else if ((id == "589874") && (password != "P@ssw0rd"))
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('Incorrect Password ');", true);
        }
        else if ((id != "589874") && (password != "P@ssw0rd"))
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('Incorrect User ID and Password ');", true);
        }
        else
        {
            Response.Redirect("userpage.aspx");
        }

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("register.aspx");
    }
}