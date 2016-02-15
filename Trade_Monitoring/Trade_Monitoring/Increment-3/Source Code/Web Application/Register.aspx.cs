using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using ServiceReference1;
public partial class Register : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string username11 = string.Empty;

           ds= obj.GetUsername();

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {

            username11 = ds.Tables[0].Rows[i][0].ToString();
        }

        string fname = Request["firstname"];
        string lname = Request["lastname"];
        string uname = Request["username"];
        string password = Request["password"];
        string cpass = Request["cpass"];
        string phone = Request["phone"];
        string email = Request["email"];
        bool uname123 = uname.Equals(username11);
        var regexItem = new Regex("^[0-9 ]*$");
        bool pass = password.Equals(cpass);

        if (fname.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter First Name' )</script>", false);

        }
        else if (regexItem.IsMatch(fname))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Alphabets only' )</script>", false);
        }
        else if (lname.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Last Name' )</script>", false);

        }
        else if (regexItem.IsMatch(lname))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Alphabets only' )</script>", false);
        }
        else if (uname.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter User name' )</script>", false);

        }

        else if (uname123.Equals(true))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Userid Already Exists' )</script>", false);

        }
        else if (password.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Password' )</script>", false);

        }
        //else if ((password.Length < 6) || (password.Length > 10))
        //{
        //    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Password Range should be 6-10 characters' )</script>", false);

        //}
        else if (cpass.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter confirm Password' )</script>", false);

        }

        else if (pass.Equals(false))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Check Confirm Password' )</script>", false);

        }
        else if (email.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter email address' )</script>", false);
        }
       
        else if (phone.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Phone Number' )</script>", false);
        }
        else if (!(regexItem.IsMatch(phone)))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Numeric Values' )</script>", false);
        }
        else if ((phone.Length < 10) || (phone.Length > 10))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter 10 digit Ph.no' )</script>", false);
        }

        else
        {
            Session["fname"] = fname;
            Session["lname"] = lname;
            Session["username"] = uname;
            Session["password"] = password;
            Session["email"] = email;
            Session["phone"] = phone;

            Response.Redirect("Continue.aspx");
        }
    }
}