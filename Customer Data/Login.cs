using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiddileTier;

namespace Customer_Data
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.UserName = txtCustomerName.Text;
            obj.Password = txtPassword.Text;
            if (obj.isValid())
            {
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }
    }
}
