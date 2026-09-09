using System.Data.SqlClient;

namespace TheLibrary.HelperLib
{
    public class DatabaseHelper
    {
        private readonly string connectionString =
            @"Data Source=FHANTOM\SQLEXPRESS;Initial Catalog=TheLibraryDB;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}