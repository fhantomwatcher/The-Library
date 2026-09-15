using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLibrary.HelperLib
{
    public static class ActivityLogHelper
    {
        public static void Log(
            int userID,
            string action,
            string description)
        {
            DatabaseHelper db = new DatabaseHelper();

            string query = @"
                INSERT INTO ActivityLogs
                (
                    UserID,
                    Action,
                    Description
                )
                VALUES
                (
                    @UserID,
                    @Action,
                    @Description
                )";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@Action", action);
                cmd.Parameters.AddWithValue(
                    "@Description",
                    (object)description ?? DBNull.Value
                );

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    // Activity logging should not stop
                    // the main book operation.
                }
            }
        }
    }
}
