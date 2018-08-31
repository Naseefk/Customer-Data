using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DataAccess
{
    public class clsSqlServer
    {
        public DataSet getCustomer()
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objconnection = new SqlConnection(Connectionstring);
            objconnection.Open();

            SqlCommand objcommand = new SqlCommand("select * from CustomerTable", objconnection);
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objcommand);
            objAdapter.Fill(objDataSet);
            
            objconnection.Close();
            return objDataSet;
        }
        public DataSet getCustomer(string CustomerCode)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objconnection = new SqlConnection(Connectionstring);
            objconnection.Open();

            SqlCommand objcommand = new SqlCommand("select * from CustomerTable where CustomerName = '" + CustomerCode + "'", objconnection);
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objcommand);
            objAdapter.Fill(objDataSet);

            objconnection.Close();
            return objDataSet;
        }
        public bool InsertCustomer(string strCustomerName,
                                    string Country,
                                    string Gender,
                                    string Hobbies,
                                    bool Status)
        {

            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            try
            {
                string strInsertCommand = "Insert into CustomerTable values('" + strCustomerName.Trim() + "','"
                                                                              + Country + "','"
                                                                              + Gender + "','"
                                                                              + Hobbies + "',"
                                                                              + Convert.ToInt16(Status) + ")";
                SqlCommand objCommand = new SqlCommand(strInsertCommand, objConnection);
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                objConnection.Close();
            }
        }
        public bool UpdateCustomer(string CustomerName,
                                    string Country,
                                    string Gender,
                                    string Hobbies,
                                    bool Status)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            string strUpdateCommand = "Update CustomerTable set CustomerName='" + CustomerName + "',Country='"
                                                                                + Country + "',gender='"
                                                                                + Gender + "',hobbies='"
                                                                                + Hobbies + "',status="
                                                                                + Convert.ToInt16(Status)+ " where CustomerName='"
                                                                                + CustomerName + "'";
            SqlCommand objCommand = new SqlCommand(strUpdateCommand, objConnection);
              objCommand.ExecuteNonQuery();
            objConnection.Close();
            return true;
        }
        public bool DeleteCustomer(string strCustomerName)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objconnection = new SqlConnection(Connectionstring);
            objconnection.Open();

            SqlCommand objcommand = new SqlCommand("delete from CustomerTable where CustomerName = '" + strCustomerName + "'", objconnection);

            objcommand.ExecuteNonQuery();
            objconnection.Close();
            return true;
        }
    }
}
