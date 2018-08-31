using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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
        public void save()
        {
            clsSqlServer objSave = new clsSqlServer();
            objSave.InsertCustomer(_CustomerName,
                                   _CountryName,
                                   _Gender,
                                   _Hobbies,
                                   _IsMarried);
        }
        public void delete()
        {
            clsSqlServer objDelete = new clsSqlServer();
            objDelete.DeleteCustomer(_CountryName);
        }
        public void update()
        {
            clsSqlServer objUpdate = new clsSqlServer();
            objUpdate.UpdateCustomer(_CustomerName,
                                     _CountryName,
                                     _Gender,
                                     _Hobbies,
                                     _IsMarried);
        }
        public DataSet loadCustomer()
        {
            clsSqlServer objSql = new clsSqlServer();
            return objSql.getCustomer();
        }
    }
}
