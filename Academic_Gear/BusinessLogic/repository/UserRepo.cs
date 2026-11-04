
using System.Configuration;
using System.Data.SqlClient;

namespace BusinessLogic.Repository
{
    public class UserRepo
    {
        private string connectionString =
            ConfigurationManager
            .ConnectionStrings["POSDatabase"]
            .ConnectionString;

        public string Login(string username, string password)
        {
            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                string query = @"SELECT Role FROM tblLogin
                    WHERE Username = @Username
                    AND Password = @Password";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();

                object result = cmd.ExecuteScalar();

                return result == null ? null : result.ToString();
            }
        }
    }
}
