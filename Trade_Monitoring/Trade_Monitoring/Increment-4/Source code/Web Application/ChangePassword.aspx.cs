using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ServiceReference1;
public partial class ChangePassword : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        string id = string.Empty;
        string oldpassword = string.Empty;
        string newpassword=string.Empty;
        string confirmpassword = string.Empty;
        string username=string.Empty;
        string id11 = string.Empty;
        string password11 = string.Empty;
        id = TextBox1.Text;
        oldpassword = TextBox2.Text;
        newpassword = TextBox3.Text;
        confirmpassword = TextBox4.Text;
        username=Convert.ToString(Session["username"]);
       
        bool pass = newpassword.Equals(confirmpassword);

         if (id.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Membership ID')</script>", false);
        }
         else if (oldpassword.Length == 0)
         {
             ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Old Password')</script>", false);
         }
         else if (newpassword.Length == 0)
         {
             ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter new Password')</script>", false);
         }
         else if ((newpassword.Length < 6) || (newpassword.Length > 15))
         {
             ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Password Range should be 6-15 characters' )</script>", false);

         }
         else if (confirmpassword.Length == 0)
         {
             ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Confirm password Password')</script>", false);
         }
         else if (pass.Equals(false))
         {
             ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Check Confirm Password' )</script>", false);

         }
         else
         {

             ds = obj.changepassworddet(username);

             if (ds != null && ds.Tables[0].Rows.Count > 0)
             {
                 id11 = ds.Tables[0].Rows[0]["memshipid"].ToString();
                 password11 = ds.Tables[0].Rows[0]["password"].ToString();
             }
             bool passcheck = password11.Equals(newpassword);
            if (passcheck.Equals(true))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('New password and Old passwords are Same' )</script>", false);
            }

             else if ((id11 == id) && (password11 == oldpassword))
             {
                 int result = obj.updatepassword(username, newpassword);

                 if (result > 0)
                 {
                     ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Password has been Updated Successfully');window.location='UserHome.aspx';", true);
                 }
                 else
                 {
                     ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Password was not updated' )</script>", false);
                 }
             }
             else
             {
                 ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Membership ID or Password Entered Incorrect' )</script>", false);
             }

         }
    }
}