using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using ServiceReference1;
using System.Net;
using System.Net.Mail;
public partial class SellStock : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();

    protected void Page_Load(object sender, EventArgs e)
    {
        string symbol = Convert.ToString(Session["symbol1"]);
        string qunatity = Convert.ToString(Session["quantity1"]);
        string marketprice = Convert.ToString(Session["marketprice1"]);
    
      Label1.Text = symbol;
      Label2.Text = qunatity;
      Label3.Text = marketprice;
     
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        string orderdate = Convert.ToString(Session["orderdate1"]);
        DateTime orderdate11 = Convert.ToDateTime(orderdate);
        string symbol11 = Label1.Text;
       
        int quantity11 =Convert.ToInt32(Label2.Text);
        string marketprice11 = Label3.Text;
        double marketprice123 = Convert.ToDouble(marketprice11);
        int sellquantity = Convert.ToInt32(TextBox1.Text);
        string sellquantity123 = TextBox1.Text;
        var regexItem = new Regex("^[0-9 ]*$");
        string username=Convert.ToString(Session["username"]);
        int rshares=quantity11-sellquantity;
        DateTime tdate = DateTime.Now;
        double amount11 = sellquantity * marketprice123;
        string amount = Convert.ToString(amount11);

        int availableshares = obj.getshares(symbol11);

        int totalshares = availableshares + sellquantity;

        if (sellquantity123.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Number of shares you want to Sell' )</script>", false);
        }
        else if (!(regexItem.IsMatch(sellquantity123)))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Sell Quantity should be numeric Values' )</script>", false);
        }

        else if (sellquantity > quantity11)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Sell Quantity should be less or equal to Quantity' )</script>", false);
        }
        else
        {
            int result = obj.selldetails(username, orderdate11, symbol11, marketprice11,sellquantity,totalshares, rshares, tdate);
            int result11 = obj.InsertCashBox(username, amount, tdate);

            if (result > 0)
            {
                string emailid = obj.GetEmail(username);
                string to123 = emailid;
                string from123 = "ashok.yaganti68@gmail.com";
                string subject = "TrdeMonitoring Notification on Sold Shares";
                string body = "You have Sold : " + sellquantity + " Shares of : " + symbol11 + " on " + DateTime.Now+". Now you have :" +rshares+" to Sell";
                using (MailMessage mm = new MailMessage(from123, to123))
                {
                    mm.Subject = subject;
                    mm.Body = body;
                    mm.IsBodyHtml = false;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential(from123, "Ysatyam1991");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);

                }
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('You have successfully sold the shares');window.location='Portfolio.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Transaction Failed')</script>", false);
                Response.Redirect(ResolveUrl("Portfolio.aspx"));
            }
        }

    }
}