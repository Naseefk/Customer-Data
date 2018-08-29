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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsSqlServer objSql = new clsSqlServer();
            DataSet objDataSet = objSql.getCustomer();
            dataGridView1.DataSource = objDataSet.Tables[0];

            //CommonCode obj = new CommonCode();
            //if (obj.checkValidation(txtSearchCustomer.Text) == false)
            //{
            //    MessageBox.Show("Customer name is compulsory");
            //    return;
            //}

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
