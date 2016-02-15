using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ServiceReference1;
using System.Text.RegularExpressions;
public partial class UpdateProfile : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindprofiledetails();
        }
    }

    public void bindprofiledetails()
    {
        string username = Convert.ToString(Session["username"]);
        DataSet ds = new DataSet();
        ds = obj.GetProfile(username);
        string memshipid = string.Empty;
        string fname = string.Empty;
        string lname = string.Empty;
        string username1 = string.Empty;
        string email = string.Empty;
        string phone = string.Empty;
        DateTime jdate = DateTime.MinValue;
        string fullname = string.Empty;
        string joiningdate = string.Empty;

        //TreeNode tn= new TreeNode(jdate.ToString("dd-MMM-yyyy"));
        joiningdate = jdate.ToString("dd-MMM-yyyy");
        if (ds != null && ds.Tables[0].Rows.Count > 0)
        {
            memshipid = ds.Tables[0].Rows[0]["memshipid"].ToString();
            fname = ds.Tables[0].Rows[0]["fname"].ToString();
            lname = ds.Tables[0].Rows[0]["lname"].ToString();
            username1 = ds.Tables[0].Rows[0]["username"].ToString();
            email = ds.Tables[0].Rows[0]["email"].ToString();
            phone = ds.Tables[0].Rows[0]["phone"].ToString();
            jdate = Convert.ToDateTime(ds.Tables[0].Rows[0]["jdate"]);
        }
        joiningdate = jdate.ToString("dd-MMM-yyyy");
        fullname = fname + " " + lname;
        Label1.Text = "" + memshipid;
        Label2.Text = "" + fullname;
        Label3.Text = "" + username1;
        TextBox1.Text = "" + email;
        TextBox2.Text = "" + phone;
        Label6.Text = "" + joiningdate;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string email11 = TextBox1.Text;
        string phone11 = TextBox2.Text;
        string username123=Convert.ToString(Session["username"]);
        var regexItem = new Regex("^[0-9 ]*$");
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(email11);

        if (email11.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Email ID' )</script>", false);
        }
        else if (!(match.Success))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Email Address was not in correct Format' )</script>", false);
        }
        else if (phone11.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Phone number' )</script>", false);
        }
        else if (!(regexItem.IsMatch(phone11)))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Numeric Values' )</script>", false);
        }
        else if ((phone11.Length < 10) || (phone11.Length > 10))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter 10 digit Mobile Number' )</script>", false);
        }
        else
        {
            int result = obj.updateprofile(username123, email11, phone11);

            if (result > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Profile has been Updated Successfully');window.location='UserHome.aspx';", true);
            }

            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Profile Details Was not Updated' )</script>", false);
            }
        }


    }
}