using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLibrary.HelperLib;
using TheLibrary.Models;

namespace TheLibrary.UserPanelControl
{
    public partial class PersonalActivityControl : UserControl
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private UserInfo currentUser;
        public PersonalActivityControl(UserInfo user)
        {
            InitializeComponent();
            currentUser = user;

            LoadActivityLogs();
        }

        private void LoadActivityLogs()
        {
            string query = @"
        SELECT
            ActivityDate AS [Date & Time],
            Action AS [Activity],
            Description
        FROM ActivityLogs
        WHERE UserID = @UserID
        ORDER BY ActivityDate DESC";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue(
                    "@UserID",
                    currentUser.UserID);

                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    DgvActivityLogs.DataSource = table;
                }
            }

            if (DgvActivityLogs.Columns.Contains("Date & Time"))
            {
                DgvActivityLogs.Columns["Date & Time"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
            }
        }


        private void SearchActivityLogs()
        {
            string search = txtSearchActivity.Text.Trim();

            string query = @"
        SELECT
            ActivityDate AS [Date & Time],
            Action AS [Activity],
            Description
        FROM ActivityLogs
        WHERE UserID = @UserID
        AND
        (
            Action LIKE @Search
            OR Description LIKE @Search
        )
        ORDER BY ActivityDate DESC";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue(
                    "@UserID",
                    currentUser.UserID);

                cmd.Parameters.AddWithValue(
                    "@Search",
                    "%" + search + "%");

                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    DgvActivityLogs.DataSource = table;
                }
            }

            if (DgvActivityLogs.Columns.Contains("Date & Time"))
            {
                DgvActivityLogs.Columns["Date & Time"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
            }
        }

        private void btnSearchActivity_Click(object sender, EventArgs e)
        {
            SearchActivityLogs();
        }

        private void btnRefreshActivity_Click(object sender, EventArgs e)
        {
            txtSearchActivity.Clear();

            LoadActivityLogs();
        }
    }
}
