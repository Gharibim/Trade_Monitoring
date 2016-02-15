using System;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using ServiceReference1;
using System.Data.SqlClient;
public partial class UserProfile : System.Web.UI.Page
{
    DataSet ds = new DataSet();

    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    SqlCommand cmd;
    byte[] raw;

    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(IsPostBack))
        {

            displayimage();



        }
        else { }


        string username = Convert.ToString(Session["username"]);
        DataSet ds = new DataSet();
        ds = obj.GetProfile(username);
        string memshipid = string.Empty;
        string fname= string.Empty;
        string lname = string.Empty;
        string username1 = string.Empty;
        string email = string.Empty;
        string phone = string.Empty;
        DateTime jdate = DateTime.MinValue;
        string fullname = string.Empty;
        string joiningdate = string.Empty;
       
        //TreeNode tn= new TreeNode(jdate.ToString("dd-MMM-yyyy"));
        joiningdate = jdate.ToString("dd-MMM-yyyy");
        if (ds != null && ds.Tables[0].Rows.Count > 0)
        {
             memshipid = ds.Tables[0].Rows[0]["memshipid"].ToString();
             fname = ds.Tables[0].Rows[0]["fname"].ToString();
            lname = ds.Tables[0].Rows[0]["lname"].ToString();
            username1 = ds.Tables[0].Rows[0]["username"].ToString();
            email = ds.Tables[0].Rows[0]["email"].ToString();
            phone = ds.Tables[0].Rows[0]["phone"].ToString();
            jdate =Convert.ToDateTime(ds.Tables[0].Rows[0]["jdate"]);
        }
        joiningdate = jdate.ToString("dd-MMM-yyyy");
        fullname = fname + " " + lname;
        Label1.Text = "" + memshipid;
        Label2.Text = "" + fullname;
        Label3.Text = "" + username1;
        Label4.Text = "" + email;
        Label5.Text = "" + phone;
        Label6.Text = "" + joiningdate;

      
        
    }

    protected void change_click(object sender, EventArgs e)
    {

        //Response.Redirect("wait.aspx");
        FileUpload1.Visible = true;
        Button1.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        //try
        //{
        if ((FileUpload1.FileName != ""))
        {
            FileUpload1.Visible = false;
            Button1.Visible = false;
            //to allow only jpg gif and png files to be uploaded.
            string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
            if (((extension == ".jpg") || ((extension == ".gif") || (extension == ".png"))))
            {
                string id = Convert.ToString(Session["username"]);

                string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            
               FileUpload1.PostedFile.SaveAs(Server.MapPath("~/pics/") + fileName);
             
               FileStream fs = new FileStream(Server.MapPath("~/pics/") + fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);

          
                raw = new byte[fs.Length];
                fs.Read(raw, 0, Convert.ToInt32(fs.Length));

                cmd = new SqlCommand("prcInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@photo", raw);
                cmd.Parameters.AddWithValue("@date1",DateTime.Now);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    Label7.Visible = false;
                    displayimage();
                    

                }
                else
                {
                    string script = "<script>alert('Error Adding Data')</script>";
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Error", script);
                }
            }
            else
            {
                Label7.Text = "Only Jpg,gif or Png files are permitted";
                Label7.Visible = true;
            }
        }
        else
        {
            Label7.Text = "Kindly Select a File.....";
            Label7.Visible = true;
        }

        //}
        //catch (Exception e1)
        //{

        //}
    }
    public void displayimage()
    {
        Label7.Visible = false;
        string id = Convert.ToString(Session["username"]);

        con.Open();
        cmd = new SqlCommand("Select img from employeeimage where id=@id", con);
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        if (dr.HasRows)
        {

            Image1.ImageUrl = "~/Handler.ashx?id=" + id;
        }
        con.Close();

    }

}