using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace ProductStore
{
  public class User
  {
       private string connectionString;
        public Guid Id { get; }
        public string UserName { get; }
        public string Password { get; }
        public static User GetByCredentials(string password, string userName)
        {
          //connectionString = WebConfigurationManager.ConnectionStrings["MYDB"].ConnectionString;
          SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MYDB"].ConnectionString);
          SqlCommand cmd = new SqlCommand("GetByCredentials", con);
          cmd.CommandType = CommandType.StoredProcedure;

            /* cmd.Parameters.Clear();
             cmd.Parameters.AddWithValue("@usr", UserName);
             cmd.Parameters.AddWithValue("@pwd", Password);
             con.Open();
             Response.
               con.Close();
               
             
            else
            {
                 lblInvalidCredentials.Visible = true;
                 lblInvalidCredentials.Text = "Invalid User Name or Password";
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
             */
            return;
        }
  }
}
//select count (*) as cnt from Users where UserName=@usr and Password=@pwd
//"Data Source=UNKNOWN;Initial Catalog=Users;database=MYDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"