using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ServiceReference1;
public partial class AppointmentDetails : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddata();

        }

    }

    public void binddata()
    {
        try
        {
            string username = Convert.ToString(Session["username"]);
            DateTime today = DateTime.Now;

            ds = obj.GetAppointment(username);
            if (ds != null)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
            }
        }
        catch (Exception e)
        {
        }
    }


    protected void lnkdelete_Click(object sender, EventArgs e)
    {
       
       
        LinkButton lnkbtndel = sender as LinkButton;
        GridViewRow gdrow = lnkbtndel.NamingContainer as GridViewRow;
        int rowIndex = gdrow.RowIndex;
        Label appointmentid = GridView1.Rows[rowIndex].FindControl("ID2") as Label;
        string appointmentid1 = appointmentid.Text;
        int appointmentid2 = Convert.ToInt32(appointmentid1);
       // int appointmentid = Convert.ToInt32(GridView1.DataKeys[gdrow.RowIndex].Value.ToString());
        int result = obj.CancelAppointment(appointmentid2);
        if (result > 0)
        {
            binddata();
        }
        else
        {
        }
       
    }
}

   
    
   
