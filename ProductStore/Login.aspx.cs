using System;
using System.Data.SqlClient;

namespace ProductStore
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=UNKNOWN;Initial Catalog=Users;database=MYDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from Users where UserName=@usr and Password=@pwd", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", txtUserName.Text);
            scmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
            scn.Open();

            if (scmd.ExecuteScalar().ToString() == "1")
            {
                Response.Redirect("~/Home.aspx");
            }
            else
             {
                lblERROR.Visible = true;
                lblERROR.Text = "Invalid User Name or Password";
                txtUserName.Text = "";
                txtPassword.Text = "";
             }
            scn.Close();

        }
    }
    
}