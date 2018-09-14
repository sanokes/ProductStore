using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace ProductStore.Core
{
  public class User
  {
      public Guid Id { get;}
      public string UserName { get; protected set; }
      public string Password { get; protected set; }

      private static string ConnectionString
        {

            get
            {
                return WebConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString;
            }
        }

         public static User GetByCredentials(string userName, string password)
        {
            using (var con = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("dbo.GetByCredentials", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                using (var reader = cmd.ExecuteReader())
                {
                    return ReaderUser(reader);
                }
            }
        }

        public static User GetByUserName(string userName)
        {
            using (var con = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("dbo.GetByUserName", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", userName);
                using (var reader = cmd.ExecuteReader())
                {
                    return ReaderUser(reader);
                }
            }
        }

        private static User ReaderUser(SqlDataReader reader)
        {
            if (reader.Read())
            {
                return new User()
                {
                    UserName = (string)reader["UserName"],
                    Password = (string)reader["Password"],
                };
            }
            return null;
        }
  }
}
