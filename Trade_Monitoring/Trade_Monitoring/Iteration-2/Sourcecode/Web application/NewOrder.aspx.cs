using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ServiceReference1;
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
        string symbol = DropDownList1.SelectedValue;
        string company = Label1.Text;
        string ashares = Label3.Text;
        string quantity = TextBox1.Text;
        string price = Label4.Text;
        string from = TextBox2.Text;
        string to = TextBox3.Text;
        string validity = DropDownList3.SelectedValue;
        int ordertype = Convert.ToInt32(DropDownList2.SelectedValue);
        if (ordertype == 2)
        {
         // string status="closed";
          //obj.InsertUserStockDetails(symbol, quantity, price, status);
        }
        if (ordertype == 1)
        {
           
        }

    }
}
     
  
