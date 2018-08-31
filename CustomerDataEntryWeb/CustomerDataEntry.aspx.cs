using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using DataAccess;
namespace CustomerDataEntryWeb
{
    public partial class CustomerDataEntry : System.Web.UI.Page
    {
        public string oldCustName;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        

        protected void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadCustomer()
        {
            clsSqlServer obj = new clsSqlServer();
            gridCustomers.DataSource = obj.getCustomer();
            gridCustomers.DataBind();
        }

        protected void gridCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string strCustomerName = gridCustomers.Rows[gridCustomers.SelectedIndex].Cells[1].Text;
            
            DisplayCustomer(strCustomerName);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioBtnMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            string hobbies = "";
            if (CheckPainting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }

            string status = "";
            if (radioBtnMarried.Checked)
            {
                status = "1";
            }
            else
            {
                status = "0";
            }

            //clsSqlServer objInsert = new clsSqlServer();
            //objInsert.InsertCustomer(txtCustomerName.Text,
            //                           ddlCountryName.Text,
            //                           gender,
            //                           hobbies,
            //                           status);


            LoadCustomer();
            clearData();
        }
        private void clearData()
        {
            txtCustomerName.Text = "";
            ddlCountryName.SelectedIndex = 0;
            radioBtnMale.Checked = false;
            radioBtnFemale.Checked = false;
            radioBtnMarried.Checked = false;
            radioBtnUnmarried.Checked = false;
            CheckPainting.Checked = false;
            CheckReading.Checked = false;
        }
        
        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            
            string gender = "";
            if (radioBtnMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            string hobbies = "";
            if (CheckPainting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }

            string status = "";
            if (radioBtnMarried.Checked)
            {
                status = "1";
            }
            else
            {
                status = "0";
            }

            clsSqlServer objUpdate = new clsSqlServer();
            
            objUpdate.UpdateCustomer(txtCustomerName.Text.Trim(),
                                                    ddlCountryName.Text,
                                                    gender,
                                                    hobbies,
                                                    status, oldCustName);
            LoadCustomer();
            clearData();

        }
        private void DisplayCustomer(string customerCode)
        {
            
            clsSqlServer obj = new clsSqlServer();
            DataSet objDataSet = obj.getCustomer(customerCode);



            string strCustomerName = objDataSet.Tables[0].Rows[0][0].ToString();
            string strCountryName = objDataSet.Tables[0].Rows[0][1].ToString();
            string strGender = objDataSet.Tables[0].Rows[0][2].ToString();
            string strHobbies = objDataSet.Tables[0].Rows[0][3].ToString();
            bool Married = false;

            txtCustomerName.Text = strCustomerName;

            ddlCountryName.Text = strCountryName;
            if ((strGender.Length == 0) || strGender.Trim() == "Male")
            {
                radioBtnMale.Checked = true;
            }
            else
            {
                radioBtnFemale.Checked = true;
            }
            if (strHobbies == "Painting")
            {
                CheckReading.Checked = false;
                CheckPainting.Checked = true;

            }
            else
            {
                CheckPainting.Checked = false;
                CheckReading.Checked = true;
            }

            if (objDataSet.Tables[0].Rows[0][4] != DBNull.Value)
            {
                Married = Convert.ToBoolean(objDataSet.Tables[0].Rows[0][4]);
            }
            
            if (Married)
            {
                radioBtnMarried.Checked = true;
            }
            else
            {
                radioBtnUnmarried.Checked = true;
            }
            
           oldCustName = strCustomerName;


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            clsSqlServer obj = new clsSqlServer();
            obj.DeleteCustomer(txtCustomerName.Text);
            clearData();
            LoadCustomer();

        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}