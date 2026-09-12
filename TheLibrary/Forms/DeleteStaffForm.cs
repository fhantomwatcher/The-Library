using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLibrary.HelperLib;
using System.Data.SqlClient;


namespace TheLibrary.Forms
{
    public partial class DeleteStaffForm : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        private DataTable staffTable;

        public DeleteStaffForm()
        {
            InitializeComponent();

            LoadStaff();
        }

        private void LoadStaff()
        {
            string query = @"
                SELECT
                    u.UserID,
                    u.FullName,
                    u.Email,
                    u.Phone,
                    u.Role,
                    s.EmployeeCode,
                    s.HireDate,
                    s.Position
                FROM Users u
                INNER JOIN Staff s
                    ON u.UserID = s.UserID
                WHERE u.Role IN ('Head Librarian', 'Librarian')
                ORDER BY u.UserID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                staffTable = new DataTable();

                adapter.Fill(staffTable);

                deletedgv.DataSource = staffTable;
            }
        }

        private void SearchStaff()
        {
            string search = searchboxtxt.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                deletedgv.DataSource = staffTable;
                return;
            }

            // Escape single quotes
            search = search.Replace("'", "''");

            DataView view = staffTable.DefaultView;

            view.RowFilter =
                $"CONVERT(UserID, 'System.String') LIKE '%{search}%' " +
                $"OR FullName LIKE '%{search}%' " +
                $"OR Email LIKE '%{search}%' " +
                $"OR Phone LIKE '%{search}%' " +
                $"OR Role LIKE '%{search}%' " +
                $"OR EmployeeCode LIKE '%{search}%' " +
                $"OR Position LIKE '%{search}%'";

            deletedgv.DataSource = view;
        }

        private void searchbtndsf_Click(object sender, EventArgs e)
        {
            SearchStaff();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchStaff();

                e.SuppressKeyPress = true;
            }
        }


        private void DeleteStaff(int userID)
        {
            string deleteStaffQuery = @"
                DELETE FROM Staff
                WHERE UserID = @UserID";

            string deleteUserQuery = @"
                DELETE FROM Users
                WHERE UserID = @UserID";


            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {

                    using (SqlCommand staffCommand =
                        new SqlCommand(deleteStaffQuery, conn, transaction))
                    {
                        staffCommand.Parameters.AddWithValue(
                            "@UserID",
                            userID
                        );

                        staffCommand.ExecuteNonQuery();
                    }


                    using (SqlCommand userCommand =
                        new SqlCommand(deleteUserQuery, conn, transaction))
                    {
                        userCommand.Parameters.AddWithValue(
                            "@UserID",
                            userID
                        );

                        userCommand.ExecuteNonQuery();
                    }


                    // Everything succeeded
                    transaction.Commit();


                    MessageBox.Show(
                        "Staff member deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );


                    // Refresh DataGridView
                    LoadStaff();
                }
                catch (Exception ex)
                {
                    // Something failed
                    transaction.Rollback();

                    MessageBox.Show(
                        "Error deleting staff member:\n\n" + ex.Message,
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }






        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (deletedgv.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a staff member first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Get UserID from selected row
            int userID = Convert.ToInt32(
                deletedgv.SelectedRows[0].Cells["UserID"].Value
            );

            string fullName =
                deletedgv.SelectedRows[0].Cells["FullName"].Value.ToString();
            string role =
                deletedgv.SelectedRows[0].Cells["Role"].Value.ToString();


            // Confirmation
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete this staff member?\n\n" +
                $"Name: {fullName}\n" +
                $"Role: {role}\n" +
                $"User ID: {userID}",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            DeleteStaff(userID);
        }



        
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
