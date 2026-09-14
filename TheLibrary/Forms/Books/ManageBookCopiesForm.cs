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

namespace TheLibrary.Forms.Books
{
    public partial class ManageBookCopiesForm : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        private int selectedBookID = 0;
        public ManageBookCopiesForm()
        {
            InitializeComponent();
        }


        private void SearchBooks()
        {
            string search = SearchBookTxT.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show(
                    "Please enter Book ID, title, ISBN, or author.",
                    "Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string query = @"
        SELECT
            b.BookID,
            b.ISBN,
            b.Title,
            b.Author,
            c.CategoryName,
            b.Publisher,
            b.PublishedYear,
            b.ShelfLocation
        FROM Books b
        INNER JOIN Categories c
            ON b.CategoryID = c.CategoryID
        WHERE
            CONVERT(VARCHAR, b.BookID) LIKE @Search
            OR b.ISBN LIKE @Search
            OR b.Title LIKE @Search
            OR b.Author LIKE @Search
        ORDER BY b.BookID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Search", "%" + search + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    BooKListDGV.DataSource = table;
                }
            }
        }

        private void SearchBookbtn_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }


        private void LoadCopies(int bookID)
        {
            string query = @"
        SELECT
            CopyID,
            Status,
            AcquisitionDate
        FROM BookCopies
        WHERE BookID = @BookID
        ORDER BY CopyID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BookID", bookID);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    CopyBookDGV.DataSource = table;
                }
            }
        }





        private void BooKListDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = BooKListDGV.Rows[e.RowIndex];

            selectedBookID = Convert.ToInt32(row.Cells["BookID"].Value);

            BookIDlbl.Text = "Book ID: " + selectedBookID;

            SelectedBooklbl.Text =
                "Book: " + row.Cells["Title"].Value.ToString();

            LoadCopies(selectedBookID);
        }

        private void ADDCopybtn_Click(object sender, EventArgs e)
        {
            if (selectedBookID == 0)
            {
                MessageBox.Show(
                    "Please select a book first.",
                    "No Book Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string bookName =
                BooKListDGV.SelectedRows[0].Cells["Title"].Value.ToString();

            AddBookCopyForm form =
                new AddBookCopyForm(selectedBookID, bookName);

            form.ShowDialog();

            LoadCopies(selectedBookID);
        }

        private void CloseMBbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCopybtn_Click(object sender, EventArgs e)
        {
            if (CopyBookDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a copy first.",
                    "No Copy Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int copyID = Convert.ToInt32(
                CopyBookDGV.SelectedRows[0].Cells["CopyID"].Value);

            EditBookCopyForm form =
                new EditBookCopyForm(copyID);

            form.ShowDialog();

            LoadCopies(selectedBookID);
        }


        private void DeleteBookCopy(int copyID)
        {
            string query = @"
        DELETE FROM BookCopies
        WHERE CopyID = @CopyID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CopyID", copyID);

                try
                {
                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(
                            "Book copy removed successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Refresh the copy list
                        LoadCopies(selectedBookID);
                    }
                    else
                    {
                        MessageBox.Show(
                            "The book copy could not be found.",
                            "Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        "This book copy cannot be removed because it is " +
                        "being used by another record.\n\n" +
                        ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error removing book copy:\n\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }


        private void RemoveCopybtn_Click(object sender, EventArgs e)
        {
            if (CopyBookDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a copy first.",
                    "No Copy Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Get CopyID
            int copyID = Convert.ToInt32(
                CopyBookDGV.SelectedRows[0].Cells["CopyID"].Value);

            // Get current status
            string status =
                CopyBookDGV.SelectedRows[0].Cells["Status"].Value.ToString();

            // Don't delete a borrowed copy
            if (status == "Borrowed")
            {
                MessageBox.Show(
                    "A borrowed copy cannot be removed.",
                    "Cannot Remove Copy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Get book name for confirmation
            string bookName = SelectedBooklbl.Text;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to remove this book copy?\n\n" +
                $"Copy ID: {copyID}\n" +
                $"{bookName}\n" +
                $"Status: {status}",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            DeleteBookCopy(copyID);
        }
    }
}
