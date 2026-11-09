
using System;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Database;

namespace BusinessLogic.Repository
{
    public class UserRepo
    {
        public string Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrEmpty(password))
            {
                return null;
            }

            string query = @"
                SELECT Role
                FROM dbo.tblLogin
                WHERE Username = @Username
                  AND [Password] = @Password";

            using (SqlConnection connection =
                new SqlConnection(
                    LocalDatabase.ConnectionString))
            {
                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@Username",
                        SqlDbType.VarChar, 50).Value =
                        username.Trim();

                    command.Parameters.Add(
                        "@Password",
                        SqlDbType.VarChar, 50).Value =
                        password;

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result == null ||
                        result == DBNull.Value)
                    {
                        return null;
                    }

                    return result.ToString();
                }
            }
        }
    }
}
