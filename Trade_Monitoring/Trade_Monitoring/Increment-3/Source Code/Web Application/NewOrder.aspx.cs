using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ServiceReference1;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
public partial class NewOrder : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        string symbol = DropDownList1.SelectedValue;

        if (symbol == "AAPL")
        {
            Label1.Text = "APPLE COMPUTER INC";        
          
           ds= obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
          
        }
        else if (symbol == "ACH")
        {
            Label1.Text = "ALUMINUM CP CHIN ADS";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "BAB")
        {
            Label1.Text = "BRITISH AIRWAYS PLC ";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "DAL")
        {
            Label1.Text = "DELTA AIR LINES INC";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "DWSN")
        {
            Label1.Text = "DAWSON GEOPHYSICAL COMPANY";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "EXPE")
        {
            Label1.Text = "EXPEDIA INC";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "FCF")
        {
            Label1.Text = "FIRST COMMONWLTH FINANCIAL";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "GYRO")
        {
            Label1.Text = "GYRODYNE COMPANY OF AMERICA IN";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "HFWA")
        {
            Label1.Text = "HERITAGE FINANCIAL CORPORATION";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "INFY")
        {
            Label1.Text = "INFOSYS TECHNOLOGIES LIMITED";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "LAKE")
        {
            Label1.Text = "LAKELAND INDUSTRIES INC";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "NATI")
        {
            Label1.Text = "NATIONAL INSTRUMENTS CORPORATI";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }

        else if (symbol == "OFC")
        {
            Label1.Text = "CORP OFFICE PPTY TR";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "PCTY")
        {
            Label1.Text = "PARTY CITY CORPORATION";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "SAND")
        {
            Label1.Text = "SANDATA TECHNOLOGIES INC";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "VTA")
        {
            Label1.Text = "VESTA INSURANCE GRP";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "WPPGY")
        {
            Label1.Text = "WPP GROUP PLC - AMER DEP SHRS";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "XLV")
        {
            Label1.Text = "HEALTHCARE SS SPDR F";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "YHOO")
        {
            Label1.Text = "YAHOO! INC.";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
        else if (symbol == "YUM")
        {
            Label1.Text = "YUM BRANDS INC ";
            ds = obj.GetShareInformation(symbol);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string cprice = ds.Tables[0].Rows[0]["Open1"].ToString();
                string shares = ds.Tables[0].Rows[0]["shares"].ToString();
                Label2.Text = cprice;
                Label3.Text = shares;
            }
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int ordertype = Convert.ToInt32(DropDownList2.SelectedValue);

        if (ordertype == 2)
        {
            string price = Label2.Text;
            Label4.Text = price;
            Label4.Visible = true;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            DropDownList3.Visible = false;
          
        }
        else
        {
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            DropDownList3.Visible = true;
            Label4.Visible = false;
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            string ashares = string.Empty;
            string quantity = string.Empty;
            string username = Convert.ToString(Session["username"]);
            string symbol = DropDownList1.SelectedValue;
            string company = Label1.Text;
            ashares = Label3.Text;
            quantity = TextBox1.Text;
            double cashbox = obj.CheckBoxAmount(username);

            string price = Label4.Text;

            string price1 = Label2.Text;
            string from = TextBox2.Text;
            string to = TextBox3.Text;
            double price11 = 0.0;
            int validity = Convert.ToInt32(DropDownList3.SelectedValue);
            int ordertype = Convert.ToInt32(DropDownList2.SelectedValue);
            int ashares11 = 0;
            int quantity11 = 0;
            if (quantity.Length != 0)
            {
                ashares11 = Convert.ToInt32(ashares);
                quantity11 = Convert.ToInt32(quantity);
                price11 = Convert.ToDouble(Label2.Text);

            }
            var regexItem = new Regex("^[0-9 ]*$");
            if (symbol == "0")
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select Company symbol' )</script>", false);

            }
            else if (quantity.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter quntity' )</script>", false);
            }


            else if (quantity11 > ashares11)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Quantity should be less than Available shares' )</script>", false);
            }
            else if (!(regexItem.IsMatch(quantity)))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Quantity shuld be Numeric value' )</script>", false);
               
            }
            else if ((price11 * quantity11) > cashbox)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('You Don't have enough Money on CashBOX' )</script>", false);
                
            }
            else if (ordertype == 0)
            {
               
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select Order Type' )</script>", false);
            }
            else
            {
               
                if (ordertype == 2)
                {
                    DateTime odate = DateTime.Now;
                    string status = "closed";
                    int ashares1 = Convert.ToInt32(Label3.Text);
                    int quantity1 = Convert.ToInt32(TextBox1.Text);
                    string rshares = Convert.ToString(ashares1 - quantity1);
                    int result = obj.InsertUserStockDetails(username, symbol, quantity, price, status, odate, rshares);
                    if (result == 0)
                    {

                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Order has been failed')</script>", false);
                        Response.Redirect(ResolveUrl("NewOrder.aspx"));

                    }
                    else
                    {
                        double price123 = Convert.ToDouble(price);
                        double amount = -price123;
                        string amount1 = Convert.ToString(amount);
                        DateTime tdate = DateTime.Now;
                        int result11 = obj.InsertCashBox(username, amount1, tdate);

                        string emailid = obj.GetEmail(username);
                        string to123 = emailid;
                        string from123 = "yagantiashok@gmail.com";
                        string subject = "TrdeMonitoring Notification on Bought Shares";
                        string body = "You have Bought : " + quantity + " Shares on : " + DateTime.Now + " from : " + symbol;
                        using (MailMessage mm = new MailMessage(from123, to123))
                        {
                            mm.Subject = subject;
                            mm.Body = body;
                            mm.IsBodyHtml = false;
                            SmtpClient smtp = new SmtpClient();
                            smtp.Host = "smtp.gmail.com";
                            smtp.EnableSsl = true;
                            NetworkCredential NetworkCred = new NetworkCredential(from123, "srilakshmi123");
                            smtp.UseDefaultCredentials = true;
                            smtp.Credentials = NetworkCred;
                            smtp.Port = 587;
                            smtp.Send(mm);

                        }
                        //ClientScript.RegisterStartupScript(GetType(), "alert", "alert('You have successfully Bought the shares');", true);
                        ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('You have successfully Bought the shares');window.location='NewOrder.aspx';", true);

                    }
                }
                else
                {
                   
                    string status = "open";
                    DateTime orderdate = DateTime.Now;
                    DateTime rdate = DateTime.MinValue;
                    if (from.Length == 0)
                    {
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter start Price' )</script>", false);
                    }
                    else if (!(regexItem.IsMatch(from)))
                    {
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('start Price should be numeric Values' )</script>", false);
                    }
                    else if (to.Length == 0)
                    {
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter End Price' )</script>", false);
                    }
                    else if (!(regexItem.IsMatch(to)))
                    {
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('End Price should be numeric Values' )</script>", false);
                    }
                    else if (validity == 0)
                    {
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select Validity' )</script>", false);
                    }
                    else
                    {
                        if (validity == 1)
                        {

                            rdate = orderdate.AddDays(1);
                        }
                        else
                        {

                            rdate = orderdate.AddDays(5);
                        }

                        int result = obj.InsertUserOpenStock(username, symbol, quantity, price1, from, to, status, orderdate, rdate);

                        if (result == 0)
                        {

                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Placing Order has been failed')</script>", false);
                            Response.Redirect(ResolveUrl("NewOrder.aspx"));

                        }
                        else
                        {

                            string emailid = obj.GetEmail(username);
                            string to123 = emailid;
                            string from123 = "yagantiashok@gmail.com";
                            string subject = "TrdeMonitoring Notification on Hold Shares";
                            string body = "You have Placed the order of: " + quantity + " Shares on : " + DateTime.Now + " from : " + symbol + " and Order ID is : " + result + ". The Order is open till :" + rdate;
                            using (MailMessage mm = new MailMessage(from123, to123))
                            {
                                mm.Subject = subject;
                                mm.Body = body;
                                mm.IsBodyHtml = false;
                                SmtpClient smtp = new SmtpClient();
                                smtp.Host = "smtp.gmail.com";
                                smtp.EnableSsl = true;
                                NetworkCredential NetworkCred = new NetworkCredential(from123, "srilakshmi123");
                                smtp.UseDefaultCredentials = true;
                                smtp.Credentials = NetworkCred;
                                smtp.Port = 587;
                                smtp.Send(mm);

                            }

                            //ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Your shares are in hold.');", true);
                            //ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your shares are in hold');window.location='NewOrder.aspx';", true);
                            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your shares are in hold'),alert('Your Order ID is :" + result + "');window.location='NewOrder.aspx';", true);
                        }
                    }
                }
            }
        }
        catch (Exception e11)
        {
        }

    }
}
     
  
