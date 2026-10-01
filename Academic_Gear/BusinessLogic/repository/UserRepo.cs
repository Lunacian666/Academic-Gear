using System.Configuration;
using System.Data.SqlClient;

namespace BusinessLogic.Repository
{
    public class UserRepo
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["AcademicGearDB"].ConnectionString;

        public string Login(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT Role 
                                 FROM Users 
                                 WHERE Username = @Username
                                 AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();

                    return result == null ? null : result.ToString();
                }
            }
        }
    }
}