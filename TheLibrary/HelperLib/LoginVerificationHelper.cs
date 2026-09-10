using System.Data.SqlClient;
using System.Reflection;
using TheLibrary.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System;

namespace TheLibrary.HelperLib
{
    internal class LoginVerificationHelper
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        public UserInfo VerifyLogin(string email, string password)
        {
            string query = @"SELECT
        u.UserID,
        u.FullName,
        u.Email,
        u.Role,
        u.Phone,
        u.Address,
        u.CreatedAt,
        s.EmployeeCode,
        s.HireDate,
        s.Position
        FROM Users u
         INNER JOIN Staff s ON u.UserID = s.UserID
             WHERE u.Email = @Email
                 AND u.Password = @Password";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new UserInfo
                        {
                            FullName = reader["FullName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Role = reader["Role"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Address = reader["Address"].ToString(),
                            EmployeeCode = reader["EmployeeCode"].ToString(),
                            HireDate = reader["HireDate"] != DBNull.Value ? Convert.ToDateTime(reader["HireDate"]) : DateTime.MinValue,
                            Position = reader["Position"].ToString(),
                            UserID = Convert.ToInt32(reader["UserID"]),
                            CreatedAt = reader["CreatedAt"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedAt"]) : DateTime.MinValue
                        };
                    }
                }
            }

            return null;
        }
    }
}