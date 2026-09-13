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

namespace TheLibrary.Forms
{
    public partial class DeleteMemberForm : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private DataTable memberTable;


        public DeleteMemberForm()
        {
            InitializeComponent();

            LoadMembers();
        }


        private void LoadMembers()
        {
            string query = @"
        SELECT
            u.UserID,
            u.FullName,
            u.Email,
            u.Phone,
            u.DateOfBirth,
            u.Gender,
            u.Address,
            m.MembershipDate,
            m.MaxBooksAllowed,
            m.MembershipStatus
        FROM Users u
        INNER JOIN Members m
            ON u.UserID = m.UserID
        WHERE u.Role = 'Member'
        ORDER BY u.UserID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                memberTable = new DataTable();

                adapter.Fill(memberTable);

                DeleteMemberdgv.DataSource = memberTable;
            }
        }


        private void SearchMembers()
        {
            string search = searchboxtxt.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                DeleteMemberdgv.DataSource = memberTable;
                return;
            }

            search = search.Replace("'", "''");

            DataView view = memberTable.DefaultView;

            view.RowFilter =
                $"CONVERT(UserID, 'System.String') LIKE '%{search}%' " +
                $"OR FullName LIKE '%{search}%' " +
                $"OR Email LIKE '%{search}%' " +
                $"OR Phone LIKE '%{search}%' " +
                $"OR Gender LIKE '%{search}%' " +
                $"OR Address LIKE '%{search}%' " +
                $"OR MembershipStatus LIKE '%{search}%'";

            DeleteMemberdgv.DataSource = view;
        }








        private void searchbtndsf_Click(object sender, EventArgs e)
        {
            SearchMembers();
        }


        private void DeleteMember(int userID)
        {
            string deleteMemberQuery = @"
        DELETE FROM Members
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
                    // Delete Members record first
                    using (SqlCommand command =
                        new SqlCommand(deleteMemberQuery, conn, transaction))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);

                        command.ExecuteNonQuery();
                    }

                    // Then delete Users record
                    using (SqlCommand command =
                        new SqlCommand(deleteUserQuery, conn, transaction))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show(
                        "Member deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadMembers();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    MessageBox.Show(
                        "Error deleting member:\n\n" + ex.Message,
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }





        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DeleteMemberdgv.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a member first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int userID = Convert.ToInt32(
                DeleteMemberdgv.SelectedRows[0].Cells["UserID"].Value
            );

            string fullName =
                DeleteMemberdgv.SelectedRows[0].Cells["FullName"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete this member?\n\n" +
                $"Name: {fullName}\n" +
                $"User ID: {userID}",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                DeleteMember(userID);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
