using System.Data.SqlClient;

namespace TheLibrary.HelperLib
{
    internal class LoginVerificationHelper
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        public bool VerifyLogin(string email, string password)
        {
            string query = @"
                SELECT COUNT(*)
                FROM Users
                WHERE Email = @Email
                AND Password = @Password";

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int result = (int)cmd.ExecuteScalar();

                    return result > 0;
                }
            }
        }
    }
}