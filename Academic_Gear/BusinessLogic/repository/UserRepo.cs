using System;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Database;

namespace BusinessLogic.Repository
{
    public sealed class UserProfile
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string EmployeeId { get; set; }
    }

    public class UserRepo
    {
        public string Login(string username, string password)
        {
            using (var con = LocalDatabase.CreateConnection())
            using (var cmd = new SqlCommand("SELECT Role FROM dbo.tblLogin WHERE Username=@username AND [Password]=@password", con))
            {
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = (username ?? "").Trim();
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password ?? "";
                con.Open();
                object result = cmd.ExecuteScalar();
                return result == null || result == DBNull.Value ? null : Convert.ToString(result);
            }
        }

        public UserProfile GetProfile(string username)
        {
            using (var con = LocalDatabase.CreateConnection())
            using (var cmd = new SqlCommand("SELECT Username, Role, FullName, Email, EmployeeId FROM dbo.tblLogin WHERE Username=@username", con))
            {
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username ?? "";
                con.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;
                    return new UserProfile
                    {
                        Username = r.GetString(0),
                        Role = r.GetString(1),
                        FullName = r.IsDBNull(2) ? "" : r.GetString(2),
                        Email = r.IsDBNull(3) ? "" : r.GetString(3),
                        EmployeeId = r.IsDBNull(4) ? "" : r.GetString(4)
                    };
                }
            }
        }

        public void UpdateProfile(string username, string fullName, string email, string employeeId, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(username)) throw new ArgumentException("Account is not selected.");
            if ((fullName ?? "").Length > 100 || (email ?? "").Length > 120 || (employeeId ?? "").Length > 30)
                throw new ArgumentException("One of the profile fields is too long.");
            if (!string.IsNullOrEmpty(newPassword) && (newPassword.Length < 8 || newPassword.Length > 50))
                throw new ArgumentException("New password must be 8 to 50 characters.");
            using (var con = LocalDatabase.CreateConnection())
            using (var cmd = new SqlCommand(@"UPDATE dbo.tblLogin SET FullName=@name, Email=@email, EmployeeId=@employee,
[Password]=CASE WHEN @password='' THEN [Password] ELSE @password END
WHERE Username=@username;", con))
            {
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = (fullName ?? "").Trim();
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 120).Value = (email ?? "").Trim();
                cmd.Parameters.Add("@employee", SqlDbType.NVarChar, 30).Value = (employeeId ?? "").Trim();
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = newPassword ?? "";
                con.Open();
                if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("Account not found.");
            }
        }
    }
}
