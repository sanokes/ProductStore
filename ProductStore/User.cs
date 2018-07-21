using System.Configuration;
using System.Data.SqlClient;

namespace ProductStore
{
    public class User
  {
       private string connectionString;
        // public Guid Id { get; }
        public string UserName { get; }
        public string Password { get; }

    public static void  GetByCredentials(string password, string userName)
    {
            //connectionString = WebConfigurationManager.ConnectionStrings["MYDB"].ConnectionString;
      SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MYDB"].ConnectionString);
      SqlCommand cmd =new SqlCommand("GetByCredentials",con) ;
    }
  }
}
//select count (*) as cnt from Users where UserName=@usr and Password=@pwd
//"Data Source=UNKNOWN;Initial Catalog=Users;database=MYDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"