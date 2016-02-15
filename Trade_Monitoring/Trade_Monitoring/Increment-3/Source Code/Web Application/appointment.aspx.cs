using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
public partial class appointment : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();

    protected void Page_Load(object sender, EventArgs e)
    {


        if (Page.IsPostBack == false)
        {
            Calendar.ShowDayHeader = true;
            Calendar.ShowGridLines = true;
            Calendar.ShowTitle = true;

        }
        if (IsPostBack)
        {
            binddata();
        }
    }


    protected void Calendar_SelectionChanged(object sender, EventArgs e)
    {
        DateTime date1 = Calendar.SelectedDate;
        string date123 = date1.ToString("MM/dd/yyyy");

        TextBox1.Text = date123;
        binddata();


    }

    public void binddata()
    {
        try
        {
            DateTime selecteddate = Convert.ToDateTime(TextBox1.Text);
            DateTime today = DateTime.Now;
            string slotdate = TextBox1.Text;

            String Time3 = today.ToString("HH:mm");
            string tym_two = "09:30";
            string tym_three = "10:00";
            string tym_four = "10:30";
            string tym_five = "11:00";
            string tym_six = "11:30";
            string tym_seven = "12:00";
            string tym_twlve = "14:30";
            string tym_thirteen = "15:00";
            string tym_fourteen = "15:30";
            string tym_fifteen = "16:00";
            string tym_sixteen = "16:30";
            string tym_seventeen = "17:00";

            TimeSpan first = TimeSpan.Parse(Time3);
            TimeSpan second = TimeSpan.Parse(tym_two);
            TimeSpan three = TimeSpan.Parse(tym_three);
            TimeSpan four = TimeSpan.Parse(tym_four);
            TimeSpan five = TimeSpan.Parse(tym_five);
            TimeSpan six = TimeSpan.Parse(tym_six);
            TimeSpan seven = TimeSpan.Parse(tym_seven);
            TimeSpan twelve = TimeSpan.Parse(tym_twlve);
            TimeSpan thirteen = TimeSpan.Parse(tym_thirteen);
            TimeSpan fourteen = TimeSpan.Parse(tym_fourteen);
            TimeSpan fifteen = TimeSpan.Parse(tym_fifteen);
            TimeSpan sixteen = TimeSpan.Parse(tym_sixteen);
            TimeSpan seventeen = TimeSpan.Parse(tym_seventeen);

            DataSet ds = new DataSet();
            ds = obj.GetAppointmentDetails(slotdate);
            //string slottime11 = string.Empty;
            string slotdate11 = string.Empty;

            List<string> slottime11 = new List<string>();


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                slottime11.Add(ds.Tables[0].Rows[i][0].ToString());

                slotdate11 = ds.Tables[0].Rows[i][1].ToString();

            }
            if (slotdate.Equals(slotdate11))
            {

                if (slottime11.Contains("09:00-09:30"))
                {

                    Button2.Style.Add("background-color", "red");
                    Button2.Visible = true;
                    Button2.Enabled = false;

                }
                else
                {
                    Button2.Style.Add("background-color", "green");
                    Button2.Visible = true;
                }

                if (slottime11.Contains("09:30-10:00"))
                {
                    Button3.Style.Add("background-color", "red");
                    Button3.Visible = true;
                    Button3.Enabled = false;
                }
                else
                {
                    Button3.Style.Add("background-color", "green");
                    Button3.Visible = true;
                }

                if (slottime11.Contains("10:00-10:30"))
                {
                    Button4.Style.Add("background-color", "red");
                    Button4.Visible = true;
                    Button4.Enabled = false;
                }
                else
                {
                    Button4.Style.Add("background-color", "green");
                    Button4.Visible = true;
                }

                if (slottime11.Contains("10:30-11:00"))
                {
                    Button5.Style.Add("background-color", "red");
                    Button5.Visible = true;
                    Button5.Enabled = false;
                }
                else
                {
                    Button5.Style.Add("background-color", "green");
                    Button5.Visible = true;
                }


                if (slottime11.Contains("11:00-11:30"))
                {
                    Button6.Style.Add("background-color", "red");
                    Button6.Visible = true;
                    Button6.Enabled = false;
                }
                else
                {
                    Button6.Style.Add("background-color", "green");
                    Button6.Visible = true;
                }

                if (slottime11.Contains("11:30-12:00"))
                {
                    Button7.Style.Add("background-color", "red");
                    Button7.Visible = true;
                    Button7.Enabled = false;
                }
                else
                {
                    Button7.Style.Add("background-color", "green");
                    Button7.Visible = true;
                }

                if (slottime11.Contains("14:00-14:30"))
                {
                    Button12.Style.Add("background-color", "red");
                    Button12.Visible = true;
                    Button12.Enabled = false;
                }
                else
                {
                    Button12.Style.Add("background-color", "green");
                    Button12.Visible = true;
                }

                if (slottime11.Contains("14:30-15:00"))
                {
                    Button13.Style.Add("background-color", "red");
                    Button13.Visible = true;
                    Button13.Enabled = false;
                }
                else
                {
                    Button13.Style.Add("background-color", "green");
                    Button13.Visible = true;
                }

                if (slottime11.Contains("15:00-15:30"))
                {
                    Button14.Style.Add("background-color", "red");
                    Button14.Visible = true;
                    Button14.Enabled = false;
                }
                else
                {
                    Button14.Style.Add("background-color", "green");
                    Button14.Visible = true;
                }

                if (slottime11.Contains("15:30-16:00"))
                {
                    Button15.Style.Add("background-color", "red");
                    Button15.Visible = true;
                    Button15.Enabled = false;
                }
                else
                {
                    Button15.Style.Add("background-color", "green");
                    Button15.Visible = true;
                }

                if (slottime11.Contains("16:00-16:30"))
                {
                    Button16.Style.Add("background-color", "red");
                    Button16.Visible = true;
                    Button16.Enabled = false;
                }
                else
                {
                    Button16.Style.Add("background-color", "green");
                    Button16.Visible = true;
                }

                if (slottime11.Contains("16:30-17:00"))
                {
                    Button17.Style.Add("background-color", "red");
                    Button17.Visible = true;
                    Button17.Enabled = false;
                }
                else
                {

                    Button17.Style.Add("background-color", "green");
                    Button17.Visible = true;
                }


            }

            else
            {
                Button2.Style.Add("background-color", "green");
                Button3.Style.Add("background-color", "green");
                Button4.Style.Add("background-color", "green");
                Button5.Style.Add("background-color", "green");
                Button6.Style.Add("background-color", "green");
                Button7.Style.Add("background-color", "green");
                Button12.Style.Add("background-color", "green");
                Button13.Style.Add("background-color", "green");
                Button14.Style.Add("background-color", "green");
                Button15.Style.Add("background-color", "green");
                Button16.Style.Add("background-color", "green");
                Button17.Style.Add("background-color", "green");
                Button2.Visible = true;
                Button3.Visible = true;
                Button4.Visible = true;
                Button5.Visible = true;
                Button6.Visible = true;
                Button7.Visible = true;
                Button12.Visible = true;
                Button13.Visible = true;
                Button14.Visible = true;
                Button15.Visible = true;
                Button16.Visible = true;
                Button17.Visible = true;

                Button2.Enabled = true;
                Button3.Enabled = true;
                Button4.Enabled = true;
                Button5.Enabled = true;
                Button6.Enabled = true;
                Button7.Enabled = true;
                Button12.Enabled = true;
                Button13.Enabled = true;
                Button14.Enabled = true;
                Button15.Enabled = true;
                Button16.Enabled = true;
                Button17.Enabled = true;

            }

            DateTime dt1 = DateTime.Parse(slotdate);
            if (DateTime.Now >= dt1)
            {
                if (first.CompareTo(second) == 1)
                {
                    Button2.Style.Add("background-color", "orange");
                    Button2.Visible = true;
                    Button2.Enabled = false;
                }

                if (first.CompareTo(three) == 1)
                {
                    Button3.Style.Add("background-color", "orange");
                    Button3.Visible = true;
                    Button3.Enabled = false;
                }

                if (first.CompareTo(four) == 1)
                {
                    Button4.Style.Add("background-color", "orange");
                    Button4.Visible = true;
                    Button4.Enabled = false;
                }

                if (first.CompareTo(five) == 1)
                {
                    Button5.Style.Add("background-color", "orange");
                    Button5.Visible = true;
                    Button5.Enabled = false;
                }

                if (first.CompareTo(six) == 1)
                {
                    Button6.Style.Add("background-color", "orange");
                    Button6.Visible = true;
                    Button6.Enabled = false;
                }

                if (first.CompareTo(seven) == 1)
                {
                    Button7.Style.Add("background-color", "orange");
                    Button7.Visible = true;
                    Button7.Enabled = false;
                }

                if (first.CompareTo(twelve) == 1)
                {
                    Button12.Style.Add("background-color", "orange");
                    Button12.Visible = true;
                    Button12.Enabled = false;
                }

                if (first.CompareTo(thirteen) == 1)
                {
                    Button13.Style.Add("background-color", "orange");
                    Button13.Visible = true;
                    Button13.Enabled = false;
                }

                if (first.CompareTo(fourteen) == 1)
                {
                    Button14.Style.Add("background-color", "orange");
                    Button14.Visible = true;
                    Button14.Enabled = false;
                }

                if (first.CompareTo(fifteen) == 1)
                {
                    Button15.Style.Add("background-color", "orange");
                    Button15.Visible = true;
                    Button15.Enabled = false;
                }

                if (first.CompareTo(sixteen) == 1)
                {
                    Button16.Style.Add("background-color", "orange");
                    Button16.Visible = true;
                    Button16.Enabled = false;
                }

                if (first.CompareTo(seventeen) == 1)
                {
                    Button17.Style.Add("background-color", "orange");
                    Button17.Visible = true;
                    Button17.Enabled = false;
                }

            }

            Label1.Visible = true;
            Label2.Visible = true;
            //Button2.Visible = false;
            //Button3.Visible = false;
            //Button4.Visible = false;
            //Button5.Visible = false;
            //Button6.Visible = false;
            //Button7.Visible = false;
            //Button12.Visible = false;
            //Button13.Visible = false;
            //Button14.Visible = false;
            //Button15.Visible = false;
            //Button16.Visible = false;
            //Button17.Visible = false;
        }
        catch (Exception e)
        {
        }

    }

    protected void Calendar_DayRender(object sender, DayRenderEventArgs e)
    {

        if (e.Day.Date.CompareTo(DateTime.Today) < 0)
        {
            e.Day.IsSelectable = false;
        }

        if (e.Day.Date.ToLongDateString().Contains("Sunday") || e.Day.Date.ToLongDateString().Contains("Saturday"))
        {
            e.Cell.Font.Italic = true;
            e.Cell.Font.Size = FontUnit.Large;
            e.Day.IsSelectable = false;
            e.Cell.BackColor = System.Drawing.Color.DarkKhaki;
            e.Cell.BorderColor = System.Drawing.Color.Khaki;
            e.Cell.ForeColor = System.Drawing.Color.Khaki;
            e.Cell.Font.Name = "Times New Roman";
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string slotdate = TextBox1.Text;
        string slottime = "09:00-09:30";
        string username = Convert.ToString(Session["username"]);

        int result = obj.BookAppointment(username, slottime, slotdate);

        if (result == 0)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Appointment Failed')</script>", false);
            Response.Redirect(ResolveUrl("appointment.aspx"));

        }
        else
        {

            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your appointment has been Scheduled');window.location='appointment.aspx';", true);

        }

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string slotdate = TextBox1.Text;
        string slottime = "09:30-10:00";
        string username = Convert.ToString(Session["username"]);

        int result = obj.BookAppointment(username, slottime, slotdate);

        if (result == 0)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Appointment Failed')</script>", false);
            Response.Redirect(ResolveUrl("appointment.aspx"));

        }
        else
        {

            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your appointment has been Scheduled');window.location='appointment.aspx';", true);

        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string slotdate = TextBox1.Text;
        string slottime = "10:00-10:30";
        string username = Convert.ToString(Session["username"]);

        int result = obj.BookAppointment(username, slottime, slotdate);

        if (result == 0)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Appointment Failed')</script>", false);
            Response.Redirect(ResolveUrl("appointment.aspx"));

        }
        else
        {

            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your appointment has been Scheduled');window.location='appointment.aspx';", true);

        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        string slotdate = TextBox1.Text;
        string slottime = "10:30-11:00";
        string username = Convert.ToString(Session["username"]);

        int result = obj.BookAppointment(username, slottime, slotdate);

        if (result == 0)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Appointment Failed')</script>", false);
            Response.Redirect(ResolveUrl("appointment.aspx"));

        }
        else
        {

            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your appointment has been Scheduled');window.location='appointment.aspx';", true);

        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        string slotdate = TextBox1.Text;
        string slottime = "11:00-11:30";
        string username = Convert.ToString(Session["username"]);

        int result = obj.BookAppointment(username, slottime, slotdate);

        if (result == 0)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Appointment Failed')</script>", false);
            Response.Redirect(ResolveUrl("appointment.aspx"));

        }
        else
        {

            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your appointment has been Scheduled');window.location='appointment.aspx';", true);

        }
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        string slotdate = TextBox1.Text;
        string slottime = "11:30-12:00";
        string username = Convert.ToString(Session["username"]);

        int result = obj.BookAppointment(username, slottime, slotdate);

        if (result == 0)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Appointment Failed')</script>", false);
            Response.Redirect(ResolveUrl("appointment.aspx"));

        }
        else
        {

            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your appointment has been Scheduled');window.location='appointment.aspx';", true);

        }
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        string slotdate = TextBox1.Text;
        string slottime = "14:00-14:30";
        string username = Convert.ToString(Session["username"]);

        int result = obj.BookAppointment(username, slottime, slotdate);

        if (result == 0)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Appointment Failed')</script>", false);
            Response.Redirect(ResolveUrl("appointment.aspx"));

        }
        else
        {

            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your appointment has been Scheduled');window.location='appointment.aspx';", true);

        }
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        string slotdate = TextBox1.Text;
        string slottime = "14:30-15:00";
        string username = Convert.ToString(Session["username"]);

        int result = obj.BookAppointment(username, slottime, slotdate);

        if (result == 0)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Appointment Failed')</script>", false);
            Response.Redirect(ResolveUrl("appointment.aspx"));

        }
        else
        {

            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your appointment has been Scheduled');window.location='appointment.aspx';", true);

        }
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        string slotdate = TextBox1.Text;
        string slottime = "15:00-15:30";
        string username = Convert.ToString(Session["username"]);

        int result = obj.BookAppointment(username, slottime, slotdate);

        if (result == 0)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Appointment Failed')</script>", false);
            Response.Redirect(ResolveUrl("appointment.aspx"));

        }
        else
        {

            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your appointment has been Scheduled');window.location='appointment.aspx';", true);

        }
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        string slotdate = TextBox1.Text;
        string slottime = "15:30-16:00";
        string username = Convert.ToString(Session["username"]);

        int result = obj.BookAppointment(username, slottime, slotdate);

        if (result == 0)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Appointment Failed')</script>", false);
            Response.Redirect(ResolveUrl("appointment.aspx"));

        }
        else
        {

            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your appointment has been Scheduled');window.location='appointment.aspx';", true);

        }
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        string slotdate = TextBox1.Text;
        string slottime = "16:00-16:30";
        string username = Convert.ToString(Session["username"]);

        int result = obj.BookAppointment(username, slottime, slotdate);

        if (result == 0)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Appointment Failed')</script>", false);
            Response.Redirect(ResolveUrl("appointment.aspx"));

        }
        else
        {

            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your appointment has been Scheduled');window.location='appointment.aspx';", true);

        }
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        string slotdate = TextBox1.Text;
        string slottime = "16:30-17:00";
        string username = Convert.ToString(Session["username"]);

        int result = obj.BookAppointment(username, slottime, slotdate);

        if (result == 0)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Your Appointment Failed')</script>", false);
            Response.Redirect(ResolveUrl("appointment.aspx"));

        }
        else
        {

            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your appointment has been Scheduled');window.location='appointment.aspx';", true);

        }
    }



}
