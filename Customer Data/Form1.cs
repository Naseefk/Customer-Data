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
using DataAccess;
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
            string gender = "";
            if (radioMale.Checked)
            {
                gender = "Male";
            }else
            {
                gender = "Female";
            }

            string hobbies = "";
            if (checkPainting.Checked)
            {
                hobbies = "Painting";
            }else
            {
                hobbies = "Reading";
            }

            string status = "";
            if (radioMarried.Checked)
            {
                status = "1";
            }else
            {
                status = "0";
            }

            clsSqlServer objInsert = new clsSqlServer();
            objInsert.InsertCustomer(txtCustomerName.Text,
                                       comboCountryName.Text,
                                       gender,
                                       hobbies,
                                       status);


            LoadCustomer();
            clearData();
            //Form2 obj = new Form2();
            //obj.SetValues(txtCustomerName.Text, comboCountryName.Text.ToString(), gender, hobbies, status);
            //obj.ShowDialog();
            
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

            clsSqlServer objSql = new clsSqlServer();
            DataSet objDataSet = objSql.getCustomer();
            dtgCustomer.DataSource = objDataSet.Tables[0];
            
        }

        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strSelectedCustomer = dtgCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            DisplayCustomer(strSelectedCustomer);
            
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

            if (objDataSet.Tables[0].Rows[0][4] != DBNull.Value)
            {
                Married = Convert.ToBoolean(objDataSet.Tables[0].Rows[0][4]);
            }
            txtCustomerName.Text= strCustomerName;
            comboCountryName.Text = strCountryName;

            if((strGender.Length == 0) || strGender.Trim()=="Male")
            {
                radioMale.Checked = true;
            }
            else
            {
                radioFemale.Checked = true;
            }
            if (Married)
            {
                radioMarried.Checked = true;
            }else
            {
                radioUnmarried.Checked = true;
            }
            if (strHobbies == "Reading")
            {
                checkReading.Checked = true;
            }
            else
            {
                checkPainting.Checked = true;
            }

            oldCustName = strCustomerName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsSqlServer objDelete = new clsSqlServer();
            objDelete.DeleteCustomer(txtCustomerName.Text);

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
            string gender = "";
            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            string hobbies = "";
            if (checkPainting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }

            string status = "";
            if (radioMarried.Checked)
            {
                status = "1";
            }
            else
            {
                status = "0";
            }

            clsSqlServer objUpdate = new clsSqlServer();
            objUpdate.UpdateCustomer(txtCustomerName.Text.Trim(),
                                                    comboCountryName.Text,
                                                    gender,
                                                    hobbies,
                                                    status,oldCustName);
            
            LoadCustomer();
            clearData();
        }
    }
}
