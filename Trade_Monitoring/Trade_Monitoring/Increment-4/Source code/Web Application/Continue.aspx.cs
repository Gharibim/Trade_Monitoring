using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using ServiceReference1;
public partial class Continue : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int year = Convert.ToInt32(DropDownList1.SelectedValue);

        TextBox1.Text = Convert.ToString(year * 200);
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int month = Convert.ToInt32(DropDownList2.SelectedValue);

         if((month==1)||(month==3)||(month==5)||(month==7)||(month==8)||(month==10)||(month==12))
         {
             DropDownList3.Items.Add(new ListItem("Select day", "0"));
             DropDownList3.Items.Add(new ListItem("1", "1"));
             DropDownList3.Items.Add(new ListItem("2", "2"));
             DropDownList3.Items.Add(new ListItem("3", "3"));
             DropDownList3.Items.Add(new ListItem("4", "4"));
             DropDownList3.Items.Add(new ListItem("5", "5"));
             DropDownList3.Items.Add(new ListItem("6", "6"));
             DropDownList3.Items.Add(new ListItem("7", "7"));
             DropDownList3.Items.Add(new ListItem("8", "8"));
             DropDownList3.Items.Add(new ListItem("9", "9"));
             DropDownList3.Items.Add(new ListItem("10", "10"));
             DropDownList3.Items.Add(new ListItem("11", "11"));
             DropDownList3.Items.Add(new ListItem("12", "12"));
             DropDownList3.Items.Add(new ListItem("13", "13"));
             DropDownList3.Items.Add(new ListItem("14", "14"));
             DropDownList3.Items.Add(new ListItem("15", "15"));
             DropDownList3.Items.Add(new ListItem("16", "16")); 
             DropDownList3.Items.Add(new ListItem("17", "17"));
             DropDownList3.Items.Add(new ListItem("18", "18"));
             DropDownList3.Items.Add(new ListItem("19", "19"));
             DropDownList3.Items.Add(new ListItem("20", "20"));
             DropDownList3.Items.Add(new ListItem("21", "21"));
             DropDownList3.Items.Add(new ListItem("22", "22"));
             DropDownList3.Items.Add(new ListItem("23", "23"));
             DropDownList3.Items.Add(new ListItem("24", "24"));
             DropDownList3.Items.Add(new ListItem("25", "25"));
             DropDownList3.Items.Add(new ListItem("26", "26"));
             DropDownList3.Items.Add(new ListItem("27", "27"));
             DropDownList3.Items.Add(new ListItem("28", "28"));
             DropDownList3.Items.Add(new ListItem("29", "29"));
             DropDownList3.Items.Add(new ListItem("30", "30"));
             DropDownList3.Items.Add(new ListItem("31", "31"));
             
         }
         else if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
         {
             DropDownList3.Items.Add(new ListItem("Select day", "0"));
             DropDownList3.Items.Add(new ListItem("1", "1"));
             DropDownList3.Items.Add(new ListItem("2", "2"));
             DropDownList3.Items.Add(new ListItem("3", "3"));
             DropDownList3.Items.Add(new ListItem("4", "4"));
             DropDownList3.Items.Add(new ListItem("5", "5"));
             DropDownList3.Items.Add(new ListItem("6", "6"));
             DropDownList3.Items.Add(new ListItem("7", "7"));
             DropDownList3.Items.Add(new ListItem("8", "8"));
             DropDownList3.Items.Add(new ListItem("9", "9"));
             DropDownList3.Items.Add(new ListItem("10", "10"));
             DropDownList3.Items.Add(new ListItem("11", "11"));
             DropDownList3.Items.Add(new ListItem("12", "12"));
             DropDownList3.Items.Add(new ListItem("13", "13"));
             DropDownList3.Items.Add(new ListItem("14", "14"));
             DropDownList3.Items.Add(new ListItem("15", "15"));
             DropDownList3.Items.Add(new ListItem("16", "16"));
             DropDownList3.Items.Add(new ListItem("17", "17"));
             DropDownList3.Items.Add(new ListItem("18", "18"));
             DropDownList3.Items.Add(new ListItem("19", "19"));
             DropDownList3.Items.Add(new ListItem("20", "20"));
             DropDownList3.Items.Add(new ListItem("21", "21"));
             DropDownList3.Items.Add(new ListItem("22", "22"));
             DropDownList3.Items.Add(new ListItem("23", "23"));
             DropDownList3.Items.Add(new ListItem("24", "24"));
             DropDownList3.Items.Add(new ListItem("25", "25"));
             DropDownList3.Items.Add(new ListItem("26", "26"));
             DropDownList3.Items.Add(new ListItem("27", "27"));
             DropDownList3.Items.Add(new ListItem("28", "28"));
             DropDownList3.Items.Add(new ListItem("29", "29"));
             DropDownList3.Items.Add(new ListItem("30", "30"));
         }

         else
         {
             DropDownList3.Items.Add(new ListItem("Select day", "0"));
             DropDownList3.Items.Add(new ListItem("1", "1"));
             DropDownList3.Items.Add(new ListItem("2", "2"));
             DropDownList3.Items.Add(new ListItem("3", "3"));
             DropDownList3.Items.Add(new ListItem("4", "4"));
             DropDownList3.Items.Add(new ListItem("5", "5"));
             DropDownList3.Items.Add(new ListItem("6", "6"));
             DropDownList3.Items.Add(new ListItem("7", "7"));
             DropDownList3.Items.Add(new ListItem("8", "8"));
             DropDownList3.Items.Add(new ListItem("9", "9"));
             DropDownList3.Items.Add(new ListItem("10", "10"));
             DropDownList3.Items.Add(new ListItem("11", "11"));
             DropDownList3.Items.Add(new ListItem("12", "12"));
             DropDownList3.Items.Add(new ListItem("13", "13"));
             DropDownList3.Items.Add(new ListItem("14", "14"));
             DropDownList3.Items.Add(new ListItem("15", "15"));
             DropDownList3.Items.Add(new ListItem("16", "16"));
             DropDownList3.Items.Add(new ListItem("17", "17"));
             DropDownList3.Items.Add(new ListItem("18", "18"));
             DropDownList3.Items.Add(new ListItem("19", "19"));
             DropDownList3.Items.Add(new ListItem("20", "20"));
             DropDownList3.Items.Add(new ListItem("21", "21"));
             DropDownList3.Items.Add(new ListItem("22", "22"));
             DropDownList3.Items.Add(new ListItem("23", "23"));
             DropDownList3.Items.Add(new ListItem("24", "24"));
             DropDownList3.Items.Add(new ListItem("25", "25"));
             DropDownList3.Items.Add(new ListItem("26", "26"));
             DropDownList3.Items.Add(new ListItem("27", "27"));
             DropDownList3.Items.Add(new ListItem("28", "28"));
         }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string fname = Convert.ToString(Session["fname"]);
        string lname = Convert.ToString(Session["lname"]);
        string username = Convert.ToString(Session["username"]);
        string password = Convert.ToString(Session["password"]);
        string email = Convert.ToString(Session["email"]);
        string phone = Convert.ToString(Session["phone"]);
        DateTime jdate = DateTime.Now;
        string years = DropDownList1.SelectedValue;
        string amount = TextBox1.Text;
        string cardnum = TextBox2.Text;
        string month = DropDownList2.SelectedValue;
        string day = DropDownList3.SelectedValue;
        string year = DropDownList4.SelectedValue;
        string expirydate = month + "-" + day +"-" + year;
        string cardtype = DropDownList5.SelectedValue;
        string securitynum = TextBox3.Text;
        var regexItem = new Regex("^[0-9 ]*$");
        if (years == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select membership years' )</script>", false);

        }
         else if (cardnum.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Last Name' )</script>", false);

        }

        else if (!(regexItem.IsMatch(cardnum)))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('card number should be numeric Values' )</script>", false);
        }
        else if ((cardnum.Length < 16) || (cardnum.Length > 16))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Card number should be 16 digits only' )</script>", false);
        }
        else if (month== "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the Month' )</script>", false);

        }

        else if (day=="0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the Day' )</script>", false);

        }
        else if (year == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the Year' )</script>", false);
        }

        else if (cardtype == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the card Type' )</script>", false);

        }

        else if (securitynum.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter 3 digit Security Number' )</script>", false);
        }
        else if (!(regexItem.IsMatch(securitynum)))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Numeric Values' )</script>", false);
        }
        else if ((securitynum.Length < 3) || (securitynum.Length > 3))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter 3 digit security number' )</script>", false);
        }

        else
        {
        
          
            int result = obj.InsertRegistrationDetails(fname, lname, username, password, email, phone, jdate, years, amount);

            if (result == 0)
            {

                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Registration Failure')</script>", false);
                Response.Redirect(ResolveUrl("register.aspx"));

            }
            else
            {
               
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your Payment Successfull'),alert('Your Membership ID is :" + result + "');window.location='LoginPage.aspx';", true);
                
            }



        }

    }
}