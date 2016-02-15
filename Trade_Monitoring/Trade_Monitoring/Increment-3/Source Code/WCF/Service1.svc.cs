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

       public int InsertUserStockDetails(string username,string symbol,string quantity, string price, string status,DateTime odate,string rshares)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_stockcloseddata", con);
            cmd.CommandText = "sp_stockcloseddata";
            cmd.CommandType = CommandType.StoredProcedure;
           
            SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
            SqlParameter symbol1 = cmd.Parameters.Add("@symbol", SqlDbType.VarChar, 100);
            SqlParameter quantity1 = cmd.Parameters.Add("@quantity", SqlDbType.Float);
            SqlParameter price1 = cmd.Parameters.Add("@price", SqlDbType.Float);
            SqlParameter status1 = cmd.Parameters.Add("@status", SqlDbType.VarChar, 100);
            SqlParameter odate1 = cmd.Parameters.Add("@odate", SqlDbType.VarChar,100);
            SqlParameter rshares1 = cmd.Parameters.Add("@rshares", SqlDbType.VarChar,100);



            username1.Value = username;
            symbol1.Value = symbol;
            quantity1.Value = quantity;
            price1.Value = price;
            status1.Value = status;
            odate1.Value = odate;
            rshares1.Value = rshares;
           int result= cmd.ExecuteNonQuery();
            
           
            con.Close();
            return result;
        }

     public int InsertUserOpenStock(string username, string symbol, string quantity,string price, string from, string to, string status, DateTime orderdate, DateTime rdate)
       {
           con.Open();

           SqlCommand cmd = new SqlCommand("sp_stockopendata", con);
           cmd.CommandText = "sp_stockopendata";
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@orderid", SqlDbType.Int).Direction = ParameterDirection.Output;
           SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
           SqlParameter symbol1 = cmd.Parameters.Add("@symbol", SqlDbType.VarChar, 100);
           SqlParameter quantity1 = cmd.Parameters.Add("@quantity", SqlDbType.Float);
           SqlParameter price1 = cmd.Parameters.Add("@price", SqlDbType.Float);
           SqlParameter from1 = cmd.Parameters.Add("@from", SqlDbType.Float);
           SqlParameter to1 = cmd.Parameters.Add("@to", SqlDbType.Float);
           SqlParameter status1 = cmd.Parameters.Add("@status", SqlDbType.VarChar, 100);
           SqlParameter orderdate1 = cmd.Parameters.Add("@orderdate", SqlDbType.DateTime);
           SqlParameter rdate1 = cmd.Parameters.Add("@rdate", SqlDbType.DateTime);
         
         
           username1.Value = username;
           symbol1.Value = symbol;
           quantity1.Value = quantity;
           price1.Value = price;
           from1.Value = from;
           to1.Value = to;
           status1.Value = status;
           orderdate1.Value = orderdate;
           rdate1.Value = rdate;

           cmd.ExecuteNonQuery();
           string result = cmd.Parameters["@orderid"].Value.ToString();
           int result1 = Convert.ToInt32(result);
           con.Close();
           return result1;
       }

    public DataSet GetPortfolio(string username)
     {
         DataSet ds = new DataSet();
         con.Open();
         SqlCommand cmd = new SqlCommand("sp_portfolio", con);
         cmd.CommandText = "sp_portfolio";
         cmd.CommandType = CommandType.StoredProcedure;
         SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
         username1.Value = username;
         SqlDataAdapter da = new SqlDataAdapter(cmd);
         da.Fill(ds);
         con.Close();


         return ds;
     }

    public DataSet GetSumDetails(string username)
    {
        DataSet ds = new DataSet();
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_sumstock", con);
        cmd.CommandText = "sp_sumstock";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
        username1.Value = username;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();


        return ds;
    }
    public DataSet GetOpenOrderHistory(string username)
    {
        DataSet ds = new DataSet();
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_openorderhistory", con);
        cmd.CommandText = "sp_openorderhistory";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
        username1.Value = username;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();


        return ds;
    }
    public DataSet GetClosedOrderHistory(string username)
    {

        DataSet ds = new DataSet();
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_closedorderhistory", con);
        cmd.CommandText = "sp_closedorderhistory";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
        username1.Value = username;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();


        return ds;
    }

    public DataSet GetFailedOrderHistory(string username)
    {
        DataSet ds = new DataSet();
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_failedorderhistory", con);
        cmd.CommandText = "sp_failedorderhistory";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
        username1.Value = username;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();


        return ds;
    }

   public DataSet getopenstocdetails(string username)
    {
        DataSet ds = new DataSet();
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_getopenstocdata", con);
        cmd.CommandText = "sp_getopenstocdata";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
        username1.Value = username;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();


        return ds;
    }

   public void InsertUserHoldStockDetails(int orderid, string username, string symbol, int quantity, double marketprice,string status, DateTime today, int rshares)
   {
       con.Open();

       SqlCommand cmd = new SqlCommand("sp_holdstocktoclose", con);
       cmd.CommandText = "sp_holdstocktoclose";
       cmd.CommandType = CommandType.StoredProcedure;
       SqlParameter orderid1 = cmd.Parameters.Add("@orderid", SqlDbType.VarChar, 100);
       SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
       SqlParameter symbol1 = cmd.Parameters.Add("@symbol", SqlDbType.VarChar, 100);
       SqlParameter quantity1 = cmd.Parameters.Add("@quantity", SqlDbType.Float);
       SqlParameter price1 = cmd.Parameters.Add("@price", SqlDbType.Float);
       SqlParameter status1 = cmd.Parameters.Add("@status", SqlDbType.VarChar, 100);
       SqlParameter odate1 = cmd.Parameters.Add("@odate", SqlDbType.DateTime);
       SqlParameter rshares1 = cmd.Parameters.Add("@rshares", SqlDbType.VarChar, 100);


       orderid1.Value = orderid;
       username1.Value = username;
       symbol1.Value = symbol;
       quantity1.Value = quantity;
       price1.Value = marketprice;
       status1.Value = status;
       odate1.Value = today;
       rshares1.Value = rshares;
       int result=cmd.ExecuteNonQuery();
      
       
       con.Close();
      
   }

   public void UpdateHoldDetails(int orderid, string status)
   {
       con.Open();

       SqlCommand cmd = new SqlCommand("sp_updateholdstatus", con);
       cmd.CommandText = "sp_updateholdstatus";
       cmd.CommandType = CommandType.StoredProcedure;
       SqlParameter orderid1 = cmd.Parameters.Add("@orderid", SqlDbType.VarChar, 100);
       SqlParameter status1 = cmd.Parameters.Add("@status", SqlDbType.VarChar, 100);
  
       orderid1.Value = orderid;
       status1.Value = status;
     
       int result = cmd.ExecuteNonQuery();


       con.Close();
   }
   public DataSet changepassworddet(string username)
   {

       DataSet ds = new DataSet();
       con.Open();
       SqlCommand cmd = new SqlCommand("sp_changepassworddet", con);
       cmd.CommandText = "sp_changepassworddet";
       cmd.CommandType = CommandType.StoredProcedure;
       SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
       username1.Value = username;
       SqlDataAdapter da = new SqlDataAdapter(cmd);
       da.Fill(ds);
       con.Close();


       return ds;
   }

  public int updatepassword(string username, string newpassword)
   {
       con.Open();

       SqlCommand cmd = new SqlCommand("sp_updatepassword", con);
       cmd.CommandText = "sp_updatepassword";
       cmd.CommandType = CommandType.StoredProcedure;
       SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
       SqlParameter newpassword1 = cmd.Parameters.Add("@newpassword", SqlDbType.VarChar, 100);

       username1.Value = username;
       newpassword1.Value = newpassword;

       int result = cmd.ExecuteNonQuery();


       con.Close();
       return result;
   }
  public int updateprofile(string username, string email, string phone)
  {
      con.Open();

      SqlCommand cmd = new SqlCommand("sp_updateprofile", con);
      cmd.CommandText = "sp_updateprofile";
      cmd.CommandType = CommandType.StoredProcedure;
      SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
      SqlParameter email1 = cmd.Parameters.Add("@email", SqlDbType.VarChar, 100);
      SqlParameter phone1 = cmd.Parameters.Add("@phone", SqlDbType.VarChar, 100);

      username1.Value = username;
      email1.Value = email;
      phone1.Value = phone;

      int result = cmd.ExecuteNonQuery();


      con.Close();
      return result;
  }
  public int getshares(string symbol)
  {
      
      int ashares = 0;
      con.Open();
      SqlCommand cmd = new SqlCommand("sp_ashares", con);
      cmd.CommandText = "sp_ashares";
      cmd.CommandType = CommandType.StoredProcedure;
      SqlParameter symbol1 = cmd.Parameters.Add("@symbol", SqlDbType.VarChar, 100);
      symbol1.Value = symbol;
      SqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
          if (reader[0] != DBNull.Value)
          {
              ashares = Convert.ToInt32(reader[0]);
          }
          else
          {
              ashares = 0;
          }

      }

      con.Close();

      return ashares;
  }
  public int selldetails(string username, DateTime orderdate, string symbol, string marketprice,int sellquantity, int totalshares, int rshares, DateTime tdate)
  {
      con.Open();

      SqlCommand cmd = new SqlCommand("sp_sellstockdata", con);
      cmd.CommandText = "sp_sellstockdata";
      cmd.CommandType = CommandType.StoredProcedure;

      SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
      SqlParameter orderdate1 = cmd.Parameters.Add("@orderdate", SqlDbType.VarChar,50);
      SqlParameter symbol1 = cmd.Parameters.Add("@symbol", SqlDbType.VarChar, 100);
      SqlParameter marketprice1 = cmd.Parameters.Add("@marketprice", SqlDbType.Float);
      SqlParameter sellquantity1 = cmd.Parameters.Add("@sellquantity", SqlDbType.VarChar, 100);
      SqlParameter totalshares1 = cmd.Parameters.Add("@totalshares", SqlDbType.VarChar,100);
      SqlParameter rshares1 = cmd.Parameters.Add("@rshares", SqlDbType.Float);
      SqlParameter tdate1 = cmd.Parameters.Add("@tdate", SqlDbType.DateTime);
     
      username1.Value = username;
      orderdate1.Value = orderdate;
      symbol1.Value = symbol;
      marketprice1.Value = marketprice;
      sellquantity1.Value = sellquantity;
      totalshares1.Value = totalshares;
      rshares1.Value = rshares;
      tdate1.Value = tdate;
      int result = cmd.ExecuteNonQuery();


      con.Close();
      return result;
  }
 public string GetEmail(string username)
  {
      string email = string.Empty;
      con.Open();
      SqlCommand cmd = new SqlCommand("sp_GetEmail", con);
      cmd.CommandText = "sp_GetEmail";
      cmd.CommandType = CommandType.StoredProcedure;
      SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
      username1.Value = username;
      SqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
          if (reader[0] != DBNull.Value)
          {
              email = Convert.ToString(reader[0]);
          }
          else
          {
              email = string.Empty;
          }

      }

      con.Close();

      return email;
  }

 public int BookAppointment(string username, string slottime, string slotdate)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("sp_BookAppointment", con);
        cmd.CommandText = "sp_BookAppointment";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@appointmentid", SqlDbType.Int).Direction = ParameterDirection.Output;
        SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);
        SqlParameter slottime1 = cmd.Parameters.Add("@slottime", SqlDbType.VarChar, 50);
        SqlParameter slotdate1 = cmd.Parameters.Add("@slotdate", SqlDbType.VarChar, 100);
       

        username1.Value = username;
        slottime1.Value = slottime;
        slotdate1.Value = slotdate;
        cmd.ExecuteNonQuery();
        string result = cmd.Parameters["@appointmentid"].Value.ToString();
        int result1 = Convert.ToInt32(result);
        con.Close();
        return result1;
        
    }
 public DataSet GetAppointmentDetails(string slotdate)
 {
     DataSet ds = new DataSet();
     con.Open();
     SqlCommand cmd = new SqlCommand("sp_GetAppointmentDetails", con);
     cmd.CommandText = "sp_GetAppointmentDetails";
     cmd.CommandType = CommandType.StoredProcedure;
     SqlParameter slotdate1 = cmd.Parameters.Add("@slotdate", SqlDbType.VarChar, 100);

     slotdate1.Value = slotdate;

      SqlDataAdapter da = new SqlDataAdapter(cmd);
     da.Fill(ds);
     con.Close();


     return ds;
 }
 public DataSet GetAppointment(string username)
 {
 
     DataSet ds = new DataSet();
     con.Open();
     SqlCommand cmd = new SqlCommand("sp_GetAppointment", con);
     cmd.CommandText = "sp_GetAppointment";
     cmd.CommandType = CommandType.StoredProcedure;
     SqlParameter username1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 100);

     username1.Value = username;

      SqlDataAdapter da = new SqlDataAdapter(cmd);
     da.Fill(ds);
     con.Close();


     return ds;
 }

 public int CancelAppointment(int appointmentid)
 {
     con.Open();

     SqlCommand cmd = new SqlCommand("sp_CancelAppointment", con);
     cmd.CommandText = "sp_CancelAppointment";
     cmd.CommandType = CommandType.StoredProcedure;

     SqlParameter appointmentid1 = cmd.Parameters.Add("@appointmentid", SqlDbType.Int);



     appointmentid1.Value = appointmentid;
    

     int result = cmd.ExecuteNonQuery();


     con.Close();
     return result;
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
