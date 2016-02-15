using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net;
using System.Net;
using System.Net.Mail;
using ServiceReference1;
public partial class UserHome : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        checkuserstocstatus();
        DownloadData();
        

    }

    public void checkuserstocstatus()
    {
        string username = Convert.ToString(Session["username"]);
        DataSet ds11 = new DataSet();
        int orderid = 0;
        string symbol = string.Empty;
        int quantity = 0;
        double fromprice = 0.0;
        double toprice = 0.0;
        DateTime orderdate = DateTime.MinValue;
        DateTime rdate = DateTime.MinValue;
        double marketprice = 0.0;
        DateTime today = DateTime.Now;
        int ashares = 0;
        ds11 = obj.getopenstocdetails(username);

        double cashbox = obj.CheckBoxAmount(username);
        double amount = quantity * marketprice;
        if (ds11 != null)
        {
         for (int i = 0; i < ds11.Tables[0].Rows.Count; i++)
         {
             orderid = Convert.ToInt32(ds11.Tables[0].Rows[i]["orderid"]);
            symbol = ds11.Tables[0].Rows[i]["symbol"].ToString();
            quantity = Convert.ToInt32(ds11.Tables[0].Rows[i]["quantity"]);
            fromprice = Convert.ToDouble(ds11.Tables[0].Rows[i]["fromprice"]);
            toprice = Convert.ToDouble(ds11.Tables[0].Rows[i]["toprice"]);
            orderdate = Convert.ToDateTime(ds11.Tables[0].Rows[i]["orderdate"]);
            rdate = Convert.ToDateTime(ds11.Tables[0].Rows[i]["rdate"]);
            marketprice = Convert.ToDouble(ds11.Tables[0].Rows[i]["Open1"]);
            ashares = Convert.ToInt32(ds11.Tables[0].Rows[i]["shares"]);

            if ((fromprice <= marketprice) && (marketprice <= toprice) && (rdate > today) && (ashares > quantity) && (cashbox > amount))
            {
                string status = "closed";
                int rshares = ashares - quantity;
                obj.InsertUserHoldStockDetails(orderid,username, symbol, quantity, marketprice,status, today, rshares);
                double amount11 = -marketprice;
                string amount1 = Convert.ToString(amount11);
                int result111 = obj.InsertCashBox(username, amount1, today);

                string emailid = obj.GetEmail(username);
                string to123 = emailid;
                string from123 = "ashok.yaganti68@gmail.com";
                string subject = "TrdeMonitoring Notification on Bought Shares";
                string body = "Your hold Shares have been Bought and details are : " + quantity + " Shares of : " + symbol + " on " + DateTime.Now + " Order ID is :" + orderid;
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
            }
            else if (rdate < today)
            {
                string status = "failed";
                obj.UpdateHoldDetails(orderid, status);

                string emailid = obj.GetEmail(username);
                string to123 = emailid;
                string from123 = "ashok.yaganti68@gmail.com";
                string subject = "TrdeMonitoring Notification on Order Failed";
                string body = "Your hold Shares order has been failed and details are : " + quantity + " Shares of : " + symbol + " on " + DateTime.Now + " and Order ID is " + orderid;
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
            }
            else
            {
            }
         }
          
          

        }
        else
        {
        }
       

    }

    public void DownloadData()
    {



        string Symbol;
        string Name;
        string Bid;
        string Ask;
        string Open;
        string PreviousClose;
        string Last;
        DateTime date1;
        using (WebClient web = new WebClient())
        {
            string csvData = web.DownloadString(string.Format("http://finance.yahoo.com/d/quotes.csv?s=AAPL+ACH+BAB+DAL+DWSN+EXPE+FCF+GYRO+HFWA+INFY+LAKE+NATI+OFC+PCTY+SAND+VTA+WPPGY+XLV+YHOO+YUM&f=snbaopl1"));

            string[] rows = csvData.Replace("\r", "").Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row)) continue;

                string[] cols = row.Split(',');

                Symbol = Convert.ToString(cols[0]);
                Name = Convert.ToString(cols[1]);
                Bid = Convert.ToString(cols[2]);
                Ask = Convert.ToString(cols[3]);
                Open = Convert.ToString(cols[4]);
                PreviousClose = Convert.ToString(cols[5]);
                Last = Convert.ToString(cols[6]);
                date1 = DateTime.Now;
                string symbol1 = Symbol.Replace("\"", "");
                obj.insertstock(symbol1, Name, Bid, Ask, Open, PreviousClose, Last, date1);
            }
        }
    }
}