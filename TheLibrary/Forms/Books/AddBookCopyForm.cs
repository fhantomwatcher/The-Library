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
    public partial class AddBookCopyForm : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private int bookID;
        private string bookName;
        public AddBookCopyForm(int selectedBookID, string selectedBookName)
        {
            InitializeComponent();

            bookID = selectedBookID;
            bookName = selectedBookName;

            BookIDlbl.Text = "Book ID: " + bookID;
            BookNamelbl.Text = "Book: " + bookName;

            StatusCB.Items.Add("Available");
            StatusCB.Items.Add("Borrowed");
            StatusCB.Items.Add("Reserved");
            StatusCB.Items.Add("Lost");
            StatusCB.Items.Add("Damaged");
            StatusCB.SelectedIndex = 0;
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

            string status = StatusCB.SelectedItem.ToString();

            DateTime acquisitionDate = AcquisitionDatepicker.Value.Date;

            string query = @"
        INSERT INTO BookCopies
        (
            BookID,
            Status,
            AcquisitionDate
        )
        VALUES
        (
            @BookID,
            @Status,
            @AcquisitionDate
        )";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@AcquisitionDate", acquisitionDate);

                try
                {
                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(
                            "Book copy added successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error adding book copy:\n\n" + ex.Message,
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
