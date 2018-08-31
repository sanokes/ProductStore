using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace ProductStore
{
  public class User
  {
      public Guid Id { get;}
      public string UserName { get;}
      public string Password { get;}

         public static User GetByCredentials(string password, string userName)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("GetByCredentials", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            return null;
        }
  }
}

/*
        
    select count (*) as cnt from Users where UserName=@usr and Password=@pwd
        
    "Data Source=UNKNOWN;Initial Catalog=Users;database=MYDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
       
    cmd.Parameters.Clear();
             cmd.Parameters.AddWithValue("@usr", UserName);
             cmd.Parameters.AddWithValue("@pwd", Password);
             con.Open();
             Response.Redirect("Home.aspx")
               con.Close();
               
             
            else
            {
                 lblInvalidCredentials.Visible = true;
                 lblInvalidCredentials.Text = "Invalid User Name or Password";
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            
 
     */
