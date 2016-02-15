using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;  
public partial class Reports : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bindchart();
            Bindchart1();
            Bindchart2();
            Bindchart3();

            Chart1.Visible = false;
            Chart2.Visible = false;
            Chart3.Visible = false;

        }    
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string option = DropDownList1.SelectedValue;
        if (option == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select Option for the shares Statistics' )</script>", false);

        }
        else if (option == "1")
        {
            Bindchart();
        }
        else if (option == "2")
        {
            Bindchart1();
        }

        else if (option == "3")
        {
            Bindchart2();
        }
        else if (option == "4")
        {
            Bindchart3();
        }
    }


    public void Bindchart()
    {
        DataSet ds = new DataSet();
        string username = Convert.ToString(Session["username"]);

        ds = obj.AvailableSharesStatistics();

      
        List<string> symbol = new List<string>();
        List<string> count = new List<string>();


        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {

            symbol.Add(ds.Tables[0].Rows[i][0].ToString());
            count.Add(ds.Tables[0].Rows[i][1].ToString());
        }



        Chart2.Series["Series1"].Points.DataBindXY(symbol, count);
        
        Chart2.ChartAreas[0].AxisX.Interval = 1;

        Chart2.Series[0].Points[0].Color = Color.Azure;
        Chart2.Series[0].Points[1].Color = Color.Blue;
        Chart2.Series[0].Points[2].Color = Color.Chocolate;
        Chart2.Series[0].Points[3].Color = Color.DarkCyan;
        Chart2.Series[0].Points[4].Color = Color.DimGray;
        Chart2.Series[0].Points[5].Color = Color.Firebrick;
        Chart2.Series[0].Points[6].Color = Color.Gold;
        Chart2.Series[0].Points[7].Color = Color.IndianRed;
        Chart2.Series[0].Points[8].Color = Color.Khaki;
        Chart2.Series[0].Points[9].Color = Color.LavenderBlush;
        Chart2.Series[0].Points[10].Color = Color.Magenta;
        Chart2.Series[0].Points[11].Color = Color.Navy;
        Chart2.Series[0].Points[12].Color = Color.Olive;
        Chart2.Series[0].Points[13].Color = Color.PaleGreen;
        Chart2.Series[0].Points[14].Color = Color.Purple;
        Chart2.Series[0].Points[15].Color = Color.RosyBrown;
        Chart2.Series[0].Points[16].Color = Color.SandyBrown;
        Chart2.Series[0].Points[17].Color = Color.Teal;
        Chart2.Series[0].Points[18].Color = Color.Violet;
        Chart2.Series[0].Points[19].Color = Color.YellowGreen;
        Chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.Interval = 50;

        Chart2.Visible = true;
        Chart1.Visible = false;
        Chart3.Visible = false;
       

    }


    public void Bindchart1()
    {
        DataSet ds = new DataSet();
        string username = Convert.ToString(Session["username"]);

        ds = obj.BuySharesStatistics(username);

        DataTable ChartData = ds.Tables[0];

        //storing total rows count to loop on each Record  
        string[] XPointMember = new string[ChartData.Rows.Count];
        int[] YPointMember = new int[ChartData.Rows.Count];

        for (int count = 0; count < ChartData.Rows.Count; count++)
        {
            //storing Values for X axis  
            XPointMember[count] = ChartData.Rows[count]["symbol"].ToString();
            //storing values for Y Axis  
            YPointMember[count] = Convert.ToInt32(ChartData.Rows[count]["quantity"]);

        }
        //binding chart control  
        Chart1.Series[0].Points.DataBindXY(XPointMember, YPointMember);

        //Setting width of line  
        Chart1.Series[0].BorderWidth = 10;
        //setting Chart type   
        Chart1.Series[0].ChartType = SeriesChartType.Pie;


        foreach (Series charts in Chart1.Series)
        {
            foreach (DataPoint point in charts.Points)
            {
                switch (point.AxisLabel)
                {
                    case "AAPL": point.Color = Color.RoyalBlue; break;
                    case "ACH": point.Color = Color.SaddleBrown; break;
                    case "BAB": point.Color = Color.SpringGreen; break;
                    case "DAL": point.Color = Color.AliceBlue; break;
                    case "DWSN": point.Color = Color.Aqua; break;
                    case "EXPE": point.Color = Color.Beige; break;
                    case "FCF": point.Color = Color.Bisque; break;
                    case "GYRO": point.Color = Color.BlanchedAlmond; break;
                    case "HFWA": point.Color = Color.BlueViolet; break;
                    case "INFY": point.Color = Color.Brown; break;
                    case "LAKE": point.Color = Color.BurlyWood; break;
                    case "NATI": point.Color = Color.CadetBlue; break;
                    case "OFC": point.Color = Color.Chocolate; break;
                    case "PCTY": point.Color = Color.Cornsilk; break;
                    case "SAND": point.Color = Color.DarkGoldenrod; break;
                    case "VTA": point.Color = Color.DarkKhaki; break;
                    case "WPPGY": point.Color = Color.DarkOrchid; break;
                    case "XLY": point.Color = Color.DeepPink; break;
                    case "YHOO": point.Color = Color.DarkOrchid; break;
                    case "YUM": point.Color = Color.DeepPink; break;


                }
                point.Label = string.Format("{0:0} - {1}", point.YValues[0], point.AxisLabel);

            }
        }


        //Enabled 3D  
        Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
        Chart1.Visible = true;
        Chart2.Visible = false;
        Chart3.Visible = false;
     

    }

    public void Bindchart2()
    {
        DataSet ds = new DataSet();
        string username = Convert.ToString(Session["username"]);

        ds = obj.SellSharesStatistics(username);

        DataTable ChartData = ds.Tables[0];

        //storing total rows count to loop on each Record  
        string[] XPointMember = new string[ChartData.Rows.Count];
        int[] YPointMember = new int[ChartData.Rows.Count];

        for (int count = 0; count < ChartData.Rows.Count; count++)
        {
            //storing Values for X axis  
            XPointMember[count] = ChartData.Rows[count]["symbol"].ToString();
            //storing values for Y Axis  
            YPointMember[count] = Convert.ToInt32(ChartData.Rows[count]["quantity"]);

        }
        //binding chart control  
        Chart1.Series[0].Points.DataBindXY(XPointMember, YPointMember);

        //Setting width of line  
        Chart1.Series[0].BorderWidth = 10;
        //setting Chart type   
        Chart1.Series[0].ChartType = SeriesChartType.Pie;


        foreach (Series charts in Chart1.Series)
        {
            foreach (DataPoint point in charts.Points)
            {
                switch (point.AxisLabel)
                {
                    case "AAPL": point.Color = Color.RoyalBlue; break;
                    case "ACH": point.Color = Color.SaddleBrown; break;
                    case "BAB": point.Color = Color.SpringGreen; break;
                    case "DAL": point.Color = Color.AliceBlue; break;
                    case "DWSN": point.Color = Color.Aqua; break;
                    case "EXPE": point.Color = Color.Beige; break;
                    case "FCF": point.Color = Color.Bisque; break;
                    case "GYRO": point.Color = Color.BlanchedAlmond; break;
                    case "HFWA": point.Color = Color.BlueViolet; break;
                    case "INFY": point.Color = Color.Brown; break;
                    case "LAKE": point.Color = Color.BurlyWood; break;
                    case "NATI": point.Color = Color.CadetBlue; break;
                    case "OFC": point.Color = Color.Chocolate; break;
                    case "PCTY": point.Color = Color.Cornsilk; break;
                    case "SAND": point.Color = Color.DarkGoldenrod; break;
                    case "VTA": point.Color = Color.DarkKhaki; break;
                    case "WPPGY": point.Color = Color.DarkOrchid; break;
                    case "XLY": point.Color = Color.DeepPink; break;
                    case "YHOO": point.Color = Color.DarkOrchid; break;
                    case "YUM": point.Color = Color.DeepPink; break;

                }
                point.Label = string.Format("{0:0} - {1}", point.YValues[0], point.AxisLabel);

            }
        }


        //Enabled 3D  
        Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;

        Chart1.Visible = true;
        Chart2.Visible = false;
        Chart3.Visible = false;
    }

    public void Bindchart3()
    {
        DataSet ds = new DataSet();
        string username = Convert.ToString(Session["username"]);

        List<string> shares = new List<string>();
        List<string> count = new List<string>();

        ds = obj.SharesStatistics(username);

        string count1 = ds.Tables[0].Rows[0][0].ToString();

        string count2 = ds.Tables[1].Rows[0][0].ToString();

        string count3 = ds.Tables[2].Rows[0][0].ToString();
       

        shares.Add("Total Shares");
        shares.Add("Bought Shares");
        shares.Add("Sold Shares");

        count.Add("100");
        count.Add(count2);
        count.Add(count3);

        Chart3.Series["Series2"].ChartType = SeriesChartType.Pyramid;

        Chart3.Series["Series2"].Points.DataBindXY(shares, count);

      
        Chart2.Visible = false;
        Chart1.Visible = false;
        Chart3.Visible = true;


    }  
}