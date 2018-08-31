using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MiddileTier;
namespace Customer_Data
{
    public partial class Form1 : Form
    {
        public string oldCustName;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            Customer objCustomer = new Customer();
            objCustomer.CustomerName = txtCustomerName.Text;
            objCustomer.CountryName = comboCountryName.Text;
            string gender = "";
            if (radioMale.Checked)
            {
                gender = "Male";
            }else
            {
                gender = "Female";
            }

            objCustomer.Gender = gender;

            string hobbies = "";
            if (checkPainting.Checked)
            {
                hobbies = "Painting";
            }else
            {
                hobbies = "Reading";
            }

            objCustomer.Hobbies = hobbies;
            objCustomer.IsMarried = radioMarried.Checked;

            objCustomer.save();
            LoadCustomer();
            clearData();    
        }

        private void dtgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomer();

        }
        private void LoadCustomer()
        {

            Customer obj = new Customer();
            dtgCustomer.DataSource = obj.loadCustomer();
           

        }

        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strSelectedCustomer = dtgCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            DisplayCustomer(strSelectedCustomer);
            
        }
        private void DisplayCustomer(string customerCode)
        {
            //clsSqlServer obj = new clsSqlServer();
            //DataSet objDataSet = obj.getCustomer(customerCode);

            

            //string strCustomerName = objDataSet.Tables[0].Rows[0][0].ToString();
            //string strCountryName = objDataSet.Tables[0].Rows[0][1].ToString();
            //string strGender = objDataSet.Tables[0].Rows[0][2].ToString();
            //string strHobbies = objDataSet.Tables[0].Rows[0][3].ToString();
            //bool Married = false;

            //if (objDataSet.Tables[0].Rows[0][4] != DBNull.Value)
            //{
            //    Married = Convert.ToBoolean(objDataSet.Tables[0].Rows[0][4]);
            //}
            //txtCustomerName.Text= strCustomerName;
            //comboCountryName.Text = strCountryName;

            //if((strGender.Length == 0) || strGender.Trim()=="Male")
            //{
            //    radioMale.Checked = true;
            //}
            //else
            //{
            //    radioFemale.Checked = true;
            //}
            //if (Married)
            //{
            //    radioMarried.Checked = true;
            //}else
            //{
            //    radioUnmarried.Checked = true;
            //}
            //if (strHobbies == "Reading")
            //{
            //    checkReading.Checked = true;
            //}
            //else
            //{
            //    checkPainting.Checked = true;
            //}

            //oldCustName = strCustomerName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.delete();
            LoadCustomer();
            clearData();
        }
        private void clearData()
        {
            txtCustomerName.Text = "";
            comboCountryName.SelectedIndex= 0;
            radioMale.Checked = false;
            radioFemale.Checked = false;
            radioMarried.Checked = false;
            radioUnmarried.Checked = false;
            checkPainting.Checked = false;
            checkReading.Checked = false;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Customer obj = new Customer();
            obj.CustomerName = txtCustomerName.Text;
            obj.CountryName = comboCountryName.Text;

            string gender = "";
            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            obj.Gender = gender;
            string hobbies = "";
            if (checkPainting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }
            obj.Hobbies = hobbies;
            obj.IsMarried = radioMarried.Checked;

            obj.update();
            LoadCustomer();
            clearData();
        }
    }
}
