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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheLibrary.Forms.Books
{
    public partial class EditBookCopyForm : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        private int copyID;
        private int bookID;

        public EditBookCopyForm(int selectedCopyID)
        {
            InitializeComponent();
            StatusCB.Items.Add("Available");
            StatusCB.Items.Add("Borrowed");
            StatusCB.Items.Add("Reserved");
            StatusCB.Items.Add("Lost");
            StatusCB.Items.Add("Damaged");
            StatusCB.SelectedIndex = 0;

            copyID = selectedCopyID;

            LoadCopy();
        }

        private void LoadCopy()
        {
            string query = @"
        SELECT
            bc.CopyID,
            bc.BookID,
            b.Title,
            bc.Status,
            bc.AcquisitionDate
        FROM BookCopies bc
        INNER JOIN Books b
            ON bc.BookID = b.BookID
        WHERE bc.CopyID = @CopyID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CopyID", copyID);

                try
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bookID =
                                Convert.ToInt32(reader["BookID"]);

                            BookCopyID.Text =
                                "Copy ID: " + copyID;

                            BookIDlbl.Text =
                                "Book ID: " + bookID;

                            BookNamelbl.Text =
                                "Book: " + reader["Title"].ToString();

                            StatusCB.SelectedItem =
                                reader["Status"].ToString();

                            if (reader["AcquisitionDate"] != DBNull.Value)
                            {
                                AcquisitionDatepicker.Value =
                                    Convert.ToDateTime(
                                        reader["AcquisitionDate"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading copy:\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StatusCB.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a status.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string status =
                StatusCB.SelectedItem.ToString();

            DateTime acquisitionDate =
                AcquisitionDatepicker.Value.Date;

            string query = @"
        UPDATE BookCopies
        SET
            Status = @Status,
            AcquisitionDate = @AcquisitionDate
        WHERE CopyID = @CopyID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue(
                    "@AcquisitionDate",
                    acquisitionDate);
                cmd.Parameters.AddWithValue("@CopyID", copyID);

                try
                {
                    conn.Open();

                    int rowsAffected =
                        cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(
                            "Book copy updated successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error updating book copy:\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
