using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MiddileTier;
using System.Web.Security;
namespace CustomerDataEntryWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtLogin_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.UserName = txtCustomerName.Text;
            obj.Password = txtPassword.Text;
            if (obj.isValid())
            {
                FormsAuthentication.RedirectFromLoginPage(obj.UserName, true);
            }
            
        }
    }
}