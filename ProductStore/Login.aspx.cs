using System;
using System.Configuration;
using System.Data;
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
            // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                string dbConnection = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
                SqlConnection con = new SqlConnection(dbConnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Users where UserName=@username and Password =@password", con);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                 {
                         Response.Redirect("~/Home.aspx");
                 }
                else
                {
                     lblERROR.Visible = true;
                     lblERROR.Text = "Invalid User Name or Password";   
                }
        }
           

       
    }
}