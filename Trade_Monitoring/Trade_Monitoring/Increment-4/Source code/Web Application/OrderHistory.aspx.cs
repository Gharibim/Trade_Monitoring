using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ServiceReference1;
public partial class OrderHistory : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        string username = Convert.ToString(Session["username"]);
        int status = Convert.ToInt32(DropDownList1.SelectedValue);
        if (status == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the Status')</script>", false);
        }
        else if (status == 1)
        {
            ds = obj.GetOpenOrderHistory(username);
            if (ds != null)
            {
                GridView2.DataSource = ds;
                GridView2.DataBind();
                GridView2.Visible = true;
                GridView1.Visible = false;
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('No Data Found')</script>", false);
            }
        }

        else if (status == 2)
        {
            ds1 = obj.GetClosedOrderHistory(username);
            if (ds1 != null)
            {
                GridView1.DataSource = ds1;
                GridView1.DataBind();
                GridView1.Visible = true;
                GridView2.Visible = false;
            }

            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('No Data Found')</script>", false);
            }
        }
        else if (status == 3)
        {

            ds2 = obj.GetFailedOrderHistory(username);
            if (ds2 == null)
            {

                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('No Data Found')</script>", false);
            }
            else
            {
                GridView2.DataSource = ds2;
                GridView2.DataBind();
                GridView2.Visible = true;
                GridView1.Visible = false;
            }
        }
        else
        { }
    }
}