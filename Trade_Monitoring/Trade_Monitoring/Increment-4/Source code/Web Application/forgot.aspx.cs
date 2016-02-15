using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Data;
using ServiceReference1;
public partial class forgot : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        DataSet ds = new DataSet();
        string Memid = TextBox1.Text;
        string email = TextBox2.Text;
        string memshipid11 = string.Empty;
        string pass11 = string.Empty;
        string email11 = string.Empty;

        if (Memid.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Membership ID')</script>", false);
        }
        else if (email.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Email Address')</script>", false);
        }

        else
        {
            ds = obj.GetEmailaddress(Memid);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                memshipid11 = ds.Tables[0].Rows[0]["memshipid"].ToString();
                email11 = ds.Tables[0].Rows[0]["email"].ToString();
                pass11 = ds.Tables[0].Rows[0]["password"].ToString();
            }


            if ((Memid == memshipid11) && (email == email11))
            {
                string to = email11;
                string from = "ashok.yaganti68@gmail.com";
                string subject = "Recovery Password";
                string body = "Your Recovery Password for Trade Monitoring is :" + pass11;
                using (MailMessage mm = new MailMessage(from, to))
                {
                    mm.Subject = subject;
                    mm.Body = body;
                    mm.IsBodyHtml = false;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential(from, "Ysatyam1991");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Recovery Password has been sent to your email.');", true);
                }

            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Membership ID and Email Address Incorrect')</script>", false);
                //Response.Redirect(ResolveUrl("login.aspx"));
            }
        }
    }
}
           
              
               
 
                


        
    
   

