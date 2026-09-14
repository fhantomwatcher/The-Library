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
    public partial class EditMemberForm : Form
    {

        private readonly DatabaseHelper db = new DatabaseHelper();
        private DataTable memberTable;

        private int selectedUserID = 0;


        public EditMemberForm()
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

                EditMemberdgv.DataSource = memberTable;
            }
        }

        private void SearchMembers()
        {
            string search = searchboxtxt.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                EditMemberdgv.DataSource = memberTable;
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

            EditMemberdgv.DataSource = view;
        }

        private void searchbtndsf_Click(object sender, EventArgs e)
        {
            SearchMembers();
        }

        private void EditMemberdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = EditMemberdgv.Rows[e.RowIndex];

            selectedUserID = Convert.ToInt32(
                row.Cells["UserID"].Value
            );

            fntxt.Text = row.Cells["FullName"].Value?.ToString();
            emailtxt.Text = row.Cells["Email"].Value?.ToString();
            phonetxt.Text = row.Cells["Phone"].Value?.ToString();
            addrsrtxt.Text = row.Cells["Address"].Value?.ToString();

            if (row.Cells["DateOfBirth"].Value != DBNull.Value)
            {
                Dobpick.Value = Convert.ToDateTime(
                    row.Cells["DateOfBirth"].Value
                );
            }

            string gender = row.Cells["Gender"].Value?.ToString();

            genderMalerb.Checked = gender == "Male";
            genderFemalerb.Checked = gender == "Female";
        }


        private void UpdateMember(
    int userID,
    string fullName,
    string email,
    string phone,
    string address,
    DateTime dateOfBirth,
    string gender)
        {
            string query = @"
        UPDATE Users
        SET
            FullName = @FullName,
            Email = @Email,
            Phone = @Phone,
            Address = @Address,
            DateOfBirth = @DateOfBirth,
            Gender = @Gender
        WHERE UserID = @UserID
          AND Role = 'Member'";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    conn.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(
                            "Member information updated successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadMembers();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        "Error updating member:\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error:\n\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }









        private void CngSavebtn_Click(object sender, EventArgs e)
        {
            if (selectedUserID == 0)
            {
                MessageBox.Show(
                    "Please select a member first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string fullName = fntxt.Text.Trim();
            string email = emailtxt.Text.Trim();
            string phone = phonetxt.Text.Trim();
            string address = addrsrtxt.Text.Trim();

            string gender = "";

            if (genderMalerb.Checked)
            {
                gender = "Male";
            }
            else if (genderFemalerb.Checked)
            {
                gender = "Female";
            }

            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show(
                    "Please enter the member's full name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show(
                    "Please enter the member's email.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show(
                    "Please select gender.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            UpdateMember(
                selectedUserID,
                fullName,
                email,
                phone,
                address,
                Dobpick.Value,
                gender
            );
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
