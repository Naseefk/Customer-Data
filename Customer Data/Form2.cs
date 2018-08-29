using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Data
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblSexData_Click(object sender, EventArgs e)
        {

        }
        public void SetValues(string CustomerName, string CounrtyName, string Sex, string hobbies, string Status)
        {
            lblCustomerNameData.Text = CustomerName;
            lblCountryNameData.Text = CounrtyName;
            lblSexData.Text = Sex;
            lblHobbiesData.Text = hobbies;
            lblStatusData.Text = Status;
        }
    }
}
