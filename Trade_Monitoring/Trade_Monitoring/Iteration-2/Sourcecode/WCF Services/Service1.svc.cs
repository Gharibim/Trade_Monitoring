using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace StockMonitoringService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
        public DataSet GetUsername()
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_username", con);
            cmd.CommandText = "sp_username";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();

            return ds;
        }


        public int InsertRegistrationDetails(string fname, string lname, string username, string password, string email, string phone, DateTime jdate, string years, string amount)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_regmembers", con);
            cmd.CommandText = "sp_regmembers";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@memshipid", SqlDbType.Int).Direction = ParameterDirection.Output;
            SqlParameter fn1 = cmd.Parameters.Add("@fname", SqlDbType.VarChar, 100);
            SqlParameter ln1 = cmd.Parameters.Add("@lname", SqlDbType.VarChar, 100);
            SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
            SqlParameter pass1 = cmd.Parameters.Add("@password", SqlDbType.VarChar, 100);
            SqlParameter email1 = cmd.Parameters.Add("@email", SqlDbType.VarChar, 100);
            SqlParameter phone1 = cmd.Parameters.Add("@phone", SqlDbType.VarChar, 100);
            SqlParameter jdate1 = cmd.Parameters.Add("@jdate", SqlDbType.DateTime);
            SqlParameter years1 = cmd.Parameters.Add("@years", SqlDbType.VarChar, 100);
            SqlParameter amount1 = cmd.Parameters.Add("@amount", SqlDbType.VarChar, 100);

            fn1.Value = fname;
            ln1.Value = lname;
            username1.Value = username;
            pass1.Value = password;
            email1.Value = email;
            phone1.Value = phone;
            jdate1.Value = jdate;
            years1.Value = years;
            amount1.Value =amount;

            cmd.ExecuteNonQuery();
            string result = cmd.Parameters["@memshipid"].Value.ToString();
            int result1 = Convert.ToInt32(result);
            con.Close();
            return result1;

        }

        public DataSet getdetails(string username)
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_userdetails", con);
            cmd.CommandText = "sp_userdetails";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
            username1.Value = username;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet GetEmailaddress(string memid)
        {
            DataSet ds = new DataSet();

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_emailaddress", con);
            cmd.CommandText = "sp_emailaddress";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter memid1 = cmd.Parameters.Add("@memshipid", SqlDbType.VarChar, 100);
            memid1.Value = memid;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();

            return ds;
        }

      public DataSet GetProfile(string username)
        {
            DataSet ds = new DataSet();

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_profile", con);
            cmd.CommandText = "sp_profile";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
            username1.Value = username;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();

            return ds;
        }

      public void insertstock(string Symbol, string Name, string Bid, string Ask, string Open, string PreviousClose, string Last, DateTime date1)
         {
             con.Open();

             SqlCommand cmd = new SqlCommand("sp_stockdata", con);
             cmd.CommandText = "sp_stockdata";
             cmd.CommandType = CommandType.StoredProcedure;
             SqlParameter Symbol1 = cmd.Parameters.Add("@Symbol", SqlDbType.VarChar, 100);
             SqlParameter Name1 = cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100);
             SqlParameter Bid1 = cmd.Parameters.Add("@Bid", SqlDbType.VarChar, 100);
             SqlParameter Ask1 = cmd.Parameters.Add("@Ask", SqlDbType.VarChar, 100);
             SqlParameter Open1 = cmd.Parameters.Add("@Open", SqlDbType.VarChar, 100);
             SqlParameter PreviousClose1 = cmd.Parameters.Add("@PreviousClose", SqlDbType.VarChar, 100);
             SqlParameter Last1 = cmd.Parameters.Add("@Last", SqlDbType.VarChar, 100);
             SqlParameter date11 = cmd.Parameters.Add("@date1", SqlDbType.VarChar, 100);


             Symbol1.Value = Symbol;
             Name1.Value = Name;
             Bid1.Value = Bid;
             Ask1.Value = Ask;
             Open1.Value = Open;
             PreviousClose1.Value = PreviousClose;
             Last1.Value = Last;
             date11.Value = date1;
            int result = cmd.ExecuteNonQuery();
             
             con.Close();
         }

     public DataSet membershipdetails(string username)
      {
          DataSet ds = new DataSet();

          con.Open();
          SqlCommand cmd = new SqlCommand("sp_memshipdetails", con);
          cmd.CommandText = "sp_memshipdetails";
          cmd.CommandType = CommandType.StoredProcedure;
          SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
          username1.Value = username;
          SqlDataAdapter da = new SqlDataAdapter(cmd);
          da.Fill(ds);
          con.Close();


          return ds;
      }
        public int InsertCashBox(string username, string amount, DateTime tdate)
        {
             con.Open();

            SqlCommand cmd = new SqlCommand("sp_CashBox", con);
            cmd.CommandText = "sp_CashBox";
            cmd.CommandType = CommandType.StoredProcedure;
            
           
            SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
            SqlParameter amount1 = cmd.Parameters.Add("@amount", SqlDbType.VarChar, 100);
            SqlParameter tdate1 = cmd.Parameters.Add("@tdate", SqlDbType.DateTime);
         
            username1.Value = username;
            amount1.Value = amount;
            tdate1.Value = tdate;
            
            int result=cmd.ExecuteNonQuery();
                     
            con.Close();
            return result;
        }

        public double CheckBoxAmount(string username)
        {
            DataSet ds = new DataSet();
            double tamount = 0.0;
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_CashBoxAmount", con);
            cmd.CommandText = "sp_CashBoxAmount";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
            username1.Value = username;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0] != DBNull.Value)
                {
                    tamount = Convert.ToDouble(reader[0]);
                }
                else
                {
                    tamount = 0.0;
                }

            }
            
            con.Close();

            return tamount;
        }


        public DataSet GetShareInformation(string symbol)
        {
            DataSet ds = new DataSet();

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_GetShareInformation", con);
            cmd.CommandText = "sp_GetShareInformation";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter symbol1 = cmd.Parameters.Add("@symbol", SqlDbType.VarChar, 100);
            symbol1.Value = symbol;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();


            return ds;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
