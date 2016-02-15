using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using ServiceReference1;
using System.IO;
using System.Text;
using System.Drawing;

public partial class tradehistory : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    DataSet ds=new DataSet();
    List<string> list1 = new List<string>();
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
       
        //DownloadData();
       
    }

    public void DownloadData()
    {
        try
        {

            string ticker = Convert.ToString(Session["ticker"]);


            string year = "1962";

            string symbol = string.Empty;
            string Date = string.Empty;
            string Open = string.Empty;
            string High = string.Empty;
            string Low = string.Empty;
            string Close = string.Empty;
            string Volume = string.Empty;
            string AdjClose = string.Empty;

            DataTable history = ds.Tables.Add();
            history.Columns.Add("Symbol");
            history.Columns.Add("Date");
            history.Columns.Add("Open");
            history.Columns.Add("High");
            history.Columns.Add("Low");
            history.Columns.Add("Close");
            history.Columns.Add("Volume");
            history.Columns.Add("AdjClose");

            using (WebClient web = new WebClient())
            {
                string data = web.DownloadString(string.Format("http://ichart.finance.yahoo.com/table.csv?s={0}&c={1}", ticker, year));

                data = data.Replace("r", "");

                string[] rows = data.Split('\n');

                //First row is headers so Ignore it
                for (int i = 1; i < rows.Length; i++)
                {
                    if (rows[i].Replace("n", "").Trim() == "") continue;

                    string[] cols = rows[i].Split(',');
                    symbol = Convert.ToString(ticker);
                    Date = Convert.ToString(cols[0]);
                    Open = Convert.ToString(cols[1]);
                   string Open1=string.Format("{0:#.##}", Open);
                    High = Convert.ToString(cols[2]);
                    string High1 = string.Format("{0:#.##}", High);
                    Low = Convert.ToString(cols[3]);
                    string Low1 = string.Format("{0:#.##}", Low);
                    Close = Convert.ToString(cols[4]);
                    string Close1 = string.Format("{0:#.##}", Close);
                    Volume = Convert.ToString(cols[5]);
                    string Volume1 = string.Format("{0:#.##}", Volume);
                    AdjClose = Convert.ToString(cols[6]);
                    string AdjClose1 = string.Format("{0:#.##}", AdjClose);
                    history.Rows.Add(symbol,Date, Open1, High1, Low1, Close1, Volume1, AdjClose1);
                }


                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
        }
        catch (Exception e)
        {
        }
        
    }
    
   
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
        DownloadData();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Clear();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment;filename=TradeHistory.xls");
        Response.Charset = "";
        Response.ContentType = "application/vnd.ms-excel";
        using (StringWriter sw = new StringWriter())
        {
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            //To Export all pages
            GridView1.AllowPaging = false;
            this.DownloadData();

            GridView1.HeaderRow.BackColor = Color.White;
            foreach (TableCell cell in GridView1.HeaderRow.Cells)
            {
                cell.BackColor = GridView1.HeaderStyle.BackColor;
            }
            foreach (GridViewRow row in GridView1.Rows)
            {
                row.BackColor = Color.White;
                foreach (TableCell cell in row.Cells)
                {
                    if (row.RowIndex % 2 == 0)
                    {
                        cell.BackColor = GridView1.AlternatingRowStyle.BackColor;
                    }
                    else
                    {
                        cell.BackColor = GridView1.RowStyle.BackColor;
                    }
                    cell.CssClass = "textmode";
                }
            }

            GridView1.RenderControl(hw);

            //style to format numbers to string
            string style = @"<style> .textmode { } </style>";
            Response.Write(style);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Verifies that the control is rendered */
    }

   
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string ticker = DropDownList1.SelectedValue;

        Session["ticker"] = ticker;

        DownloadData();
        Button2.Visible = true;
    }
}