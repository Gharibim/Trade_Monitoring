using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
public partial class stockdatatest : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    DataSet ds = new DataSet();
    List<string> list1 = new List<string>();

    protected void Page_Load(object sender, EventArgs e)
    {
       
       
            DownloadData();
       
     
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

            string[] rows = csvData.Replace("\r","").Split('\n');

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