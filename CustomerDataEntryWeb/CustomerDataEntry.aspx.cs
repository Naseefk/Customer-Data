using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using MiddileTier;
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
            Customer obj = new Customer();

            gridCustomers.DataSource = obj.loadCustomer();
            gridCustomers.DataBind();
        }

        protected void gridCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearData();
            string strCustomerName = gridCustomers.Rows[gridCustomers.SelectedIndex].Cells[1].Text;
            
            DisplayCustomer(strCustomerName);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.CustomerName = txtCustomerName.Text;
            obj.CountryName = ddlCountryName.Text;
            obj.Email = txtEmail.Text;
            string gender = "";
            if (radioBtnMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            obj.Gender = gender;
            string hobbies = "";
            if (CheckPainting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }
            obj.Hobbies = hobbies;
            obj.IsMarried = radioBtnMarried.Checked;
            obj.save();
            LoadCustomer();
            clearData();
        }
        private void clearData()
        {
            txtCustomerName.Text = "";
            ddlCountryName.SelectedIndex = 0;
            txtEmail.Text = "";
            radioBtnMale.Checked = false;
            radioBtnFemale.Checked = false;
            radioBtnMarried.Checked = false;
            radioBtnUnmarried.Checked = false;
            CheckPainting.Checked = false;
            CheckReading.Checked = false;
            
        }
        
        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            Customer obj = new Customer();
            obj.CustomerName = txtCustomerName.Text;
            obj.CountryName = ddlCountryName.Text;
            obj.Email = txtEmail.Text;
            string gender = "";
            if (radioBtnMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            obj.Gender = gender;
            string hobbies = "";
            if (CheckPainting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }
            obj.Hobbies = hobbies;
            obj.IsMarried = radioBtnMarried.Checked;
            obj.update();
            LoadCustomer();
            clearData();

        }
        private void DisplayCustomer(string customerCode)
        {

            Customer obj = new Customer();
            DataSet objDataSet = obj.loadCustomer(customerCode);



            string strCustomerName = objDataSet.Tables[0].Rows[0][0].ToString();
            string strCountryName = objDataSet.Tables[0].Rows[0][1].ToString();
            string strGender = objDataSet.Tables[0].Rows[0][2].ToString();
            string strHobbies = objDataSet.Tables[0].Rows[0][3].ToString();
            string strEmail = objDataSet.Tables[0].Rows[0][5].ToString();
            bool Married = false;

            txtCustomerName.Text = strCustomerName;

            ddlCountryName.Text= strCountryName.Trim();
            txtEmail.Text = strEmail;
            if ((strGender.Length == 0) || strGender.Trim() == "Male")
            {
                radioBtnMale.Checked = true;
            }
            else
            {
                radioBtnFemale.Checked = true;
            }
            if (strHobbies.Trim() == "Painting") 
            {
                CheckPainting.Checked = true;
            }
            else
            {
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
            Customer obj = new Customer();
            obj.delete(txtCustomerName.Text);
            clearData();
            LoadCustomer();

        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckReading_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckPainting_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}