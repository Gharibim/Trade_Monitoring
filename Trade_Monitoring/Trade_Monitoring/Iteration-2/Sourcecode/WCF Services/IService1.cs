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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
       DataSet GetUsername();

        [OperationContract]

       int InsertRegistrationDetails(string fname, string lname, string username, string password, string email, string phone, DateTime jdate, string years, string amount);

        [OperationContract]
        DataSet getdetails(string username);
         
        [OperationContract]
       DataSet GetEmailaddress(string memid);

        [OperationContract]
        DataSet GetProfile(string username);

         [OperationContract]
       void insertstock(string Symbol,string Name,string Bid,string Ask,string Open,string PreviousClose,string Last,DateTime date1);

        [OperationContract]
        DataSet membershipdetails(string username);

         [OperationContract]
        int InsertCashBox(string username, string amount, DateTime tdate);

         [OperationContract]
         double CheckBoxAmount(string username);
         [OperationContract]
         DataSet GetShareInformation(string symbol);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

     [DataContract]
    public class registration
    {
        string fname=string.Empty;
        string lname=string.Empty;
        string username=string.Empty;
        string password=string.Empty;
        string email=string.Empty;
        string phone=string.Empty;
        DateTime jdate = DateTime.MinValue;
        string years=string.Empty;
        string amount = string.Empty;

        [DataMember]
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        [DataMember]
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        [DataMember]
        public DateTime Jdate
        {
            get { return jdate; }
            set { jdate = value; }
        }
        [DataMember]
        public string Years
        {
            get { return years; }
            set { years = value; }
        }
        [DataMember]
        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }
}
