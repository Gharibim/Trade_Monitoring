using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using ServiceReference1;
public partial class tradehistory : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    DataSet ds=new DataSet();
    List<string> list1 = new List<string>();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    DownloadData();
        //}
    }

    public void DownloadData()
    {
       
            string ticker= Convert.ToString(Session["ticker"]);

        
        string year = "1962";

        string Date = string.Empty;
        string Open = string.Empty;
        string High = string.Empty;
        string Low = string.Empty;
        string Close = string.Empty;
        string Volume = string.Empty;
        string AdjClose = string.Empty;

        DataTable history = ds.Tables.Add();

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

                Date = Convert.ToString(cols[0]);
                Open = Convert.ToString(cols[1]);
                High = Convert.ToString(cols[2]);
                Low = Convert.ToString(cols[3]);
                Close = Convert.ToString(cols[4]);
               Volume = Convert.ToString(cols[5]);
               AdjClose = Convert.ToString(cols[6]);
               history.Rows.Add(Date,Open,High, Low, Close, Volume, AdjClose);
            }
                

            GridView1.DataSource = ds;
            GridView1.DataBind();
            
        }
        
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ticker = TextBox1.Text;

        Session["ticker"] = ticker;

         DownloadData();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
        DownloadData();
    }
}