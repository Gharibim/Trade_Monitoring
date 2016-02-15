using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ServiceReference1;

public partial class Portfolio : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddata();
            bindsumdetails();
        }

    }

     public void binddata()
    {
        string username = Convert.ToString(Session["username"]);
        ds = obj.GetPortfolio(username);
        if (ds != null)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else
        {
        }
    }
    

    public void bindsumdetails()
    {
        try
        {
        string username1 = Convert.ToString(Session["username"]);
        double totaluserprice = 0.0;
        double totalmarketprice = 0.0;
        ds1 = obj.GetSumDetails(username1);
        if (ds1 != null)
        {
            totaluserprice = Convert.ToDouble(ds1.Tables[0].Rows[0]["totuserprice"]);
            totalmarketprice = Convert.ToDouble(ds1.Tables[0].Rows[0]["totmarketprice"]);

            double profitloss = totalmarketprice - totaluserprice;

            Label1.Text = Convert.ToString(totaluserprice);
            Label2.Text = Convert.ToString(totalmarketprice);

            Label3.Text = Convert.ToString(Math.Round(profitloss, 2));
        }
        else
        {
        }

        }
        catch (Exception e)
        {
        }
    }


    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {


        GridViewRow gvr = (GridViewRow)((Control)e.CommandSource).NamingContainer;
        int rowIndex = gvr.RowIndex;

        if (e.CommandName == "sell")
        {
        // string orderdate =GridView1.Rows[rowIndex].Cells[0].Text;
        //string symbol = GridView1.Rows[rowIndex].Cells[1].Text;
        //string qunatity = GridView1.Rows[rowIndex].Cells[2].Text;
        //string marketprice = GridView1.Rows[rowIndex].Cells[4].Text;

            Label orderdate1 = GridView1.Rows[rowIndex].FindControl("ID2") as Label;
            Label symbol1 = GridView1.Rows[rowIndex].FindControl("ID3") as Label;
            Label qunatity1 = GridView1.Rows[rowIndex].FindControl("ID4") as Label;
            Label marketprice1 = GridView1.Rows[rowIndex].FindControl("ID6") as Label;

            string orderdate = orderdate1.Text;
            string symbol = symbol1.Text;
            string qunatity = qunatity1.Text;
            string marketprice = marketprice1.Text;
            
            Session["orderdate1"] = orderdate;
        Session["symbol1"] = symbol;
        Session["quantity1"] = qunatity;
        Session["marketprice1"] = marketprice;
        Response.Redirect("SellStock.aspx");
        }
    }
}
 

 
