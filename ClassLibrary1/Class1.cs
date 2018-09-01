using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using DataAccess;
namespace MiddileTier
{
    public class Customer
    {
        private string _CustomerName = "";
        private string _CountryName = "";
        private string _Gender = "";
        private string _Hobbies = "";
        private bool _IsMarried = false;
        private string _Email = "";
        
        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }

            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Customer Name is required");
                }
                if (value.Length > 20)
                {
                    throw new Exception("Value can not be greater than 20 characters");
                }
                _CustomerName = value;
            }
        }
        public string CountryName
        {
            get
            {
                return _CountryName;
            }

            set
            {
                _CountryName = value;
            }
        }
        public string Gender
        {
            get
            {
                return _Gender;
            }

            set
            {
                _Gender = value;
            }
        }
        public string Hobbies
        {
            get
            {
                return _Hobbies;
            }

            set
            {
                _Hobbies = value;
            }
        }
        public bool IsMarried
        {
            get
            {
                return _IsMarried;
            }

            set
            {
                _IsMarried = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                
                if (value.Length == 0)
                {
                    throw new Exception("Email is required");
                }
                Regex o = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
                if (!o.IsMatch(value))
                {
                    throw new Exception("Email address is not a proper format");
                }
                _Email = value;
            }
        }

        public void save()
        {
            clsSqlServer objSave = new clsSqlServer();
            objSave.InsertCustomer(_CustomerName,
                                   _CountryName,
                                   _Gender,
                                   _Hobbies,
                                   _IsMarried,
                                   _Email);
        }
        public void delete(string strCustomerName)
        {
            clsSqlServer objDelete = new clsSqlServer();
            objDelete.DeleteCustomer(strCustomerName);
        }
        public void update()
        {
            clsSqlServer objUpdate = new clsSqlServer();
            objUpdate.UpdateCustomer(_CustomerName,
                                     _CountryName,
                                     _Gender,
                                     _Hobbies,
                                     _IsMarried,
                                     _Email);
        }
        public DataSet loadCustomer()
        {
            clsSqlServer objSql = new clsSqlServer();
            return objSql.getCustomer();
        }
        public DataSet loadCustomer(string strCustomerName)
        {
            clsSqlServer objSql = new clsSqlServer();
            return objSql.getCustomer(strCustomerName);
        }
    }
}
