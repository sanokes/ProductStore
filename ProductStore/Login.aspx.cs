using System;
using System.Web.Caching;
using System.Web.Security;
using System.Web.UI;

namespace ProductStore
{
    public partial class Login : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void Loginbtn(object sender, EventArgs e)
        {
            var user = ProductStore.Core.User.GetByCredentials(txtUserName.Text, txtPassword.Text);
            if (user != null)
            {
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
            }
        }
    }
}
