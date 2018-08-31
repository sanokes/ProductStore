using System;
using System.Web.Caching;

namespace ProductStore
{
    public partial class Login : User//System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Loginbtn(object sender, EventArgs e)
        {
            var user = GetByCredentials(txtUserName.Text, txtPassword.Text);
            if (user != null)
            {
                Response.Redirect;
            }

        }
    }
}



/* SqlConnection con = new SqlConnection("Data Source=UNKNOWN;Initial Catalog=Users;database=MYDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
   SqlCommand cmd = new SqlCommand("select count (*) as cnt from Users where UserName=@usr and Password=@pwd", con);
   cmd.Parameters.Clear();
           cmd.Parameters.AddWithValue("@usr", txtUserName.Text);
           cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
           con.Open();

           if (cmd.ExecuteScalar().ToString() == "1")
           {
               Response.Redirect("~/Home.aspx");
           }
            else
            {
                 lblInvalidCredentials.Visible = true;
                 lblInvalidCredentials.Text = "Invalid User Name or Password";
                txtUserName.Text = "";
                txtPassword.Text = "";
             }
         con.Close();


             */