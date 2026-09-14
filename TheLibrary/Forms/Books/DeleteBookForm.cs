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
    public partial class DeleteBookForm : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        public DeleteBookForm()
        {
            InitializeComponent();
        }




        private void SearchBook()
        {
            string bookIDText = searchboxtxt.Text.Trim();

            if (!int.TryParse(bookIDText, out int bookID))
            {
                MessageBox.Show(
                    "Please enter a valid Book ID.",
                    "Invalid Book ID",
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
                WHERE b.BookID = @BookID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BookID", bookID);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "No book found with this Book ID.",
                            "Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        DeleteBookdgv.DataSource = null;
                        return;
                    }

                    DeleteBookdgv.DataSource = table;
                }
            }
        }

        private void searchbtndsf_Click(object sender, EventArgs e)
        {
            SearchBook();
        }



        private void DeleteBook(int bookID)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                // Check whether this book has copies
                string checkQuery = @"
                    SELECT COUNT(*)
                    FROM BookCopies
                    WHERE BookID = @BookID";

                using (SqlCommand checkCmd =
                    new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@BookID", bookID);

                    int copyCount = Convert.ToInt32(
                        checkCmd.ExecuteScalar());

                    if (copyCount > 0)
                    {
                        MessageBox.Show(
                            "This book cannot be deleted because it has " +
                            "book copies associated with it.\n\n" +
                            "Remove/manage the copies first.",
                            "Cannot Delete Book",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }
                }

                string deleteQuery = @"
                    DELETE FROM Books
                    WHERE BookID = @BookID";

                using (SqlCommand deleteCmd =
                    new SqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@BookID", bookID);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(
                            "Book deleted successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        DeleteBookdgv.DataSource = null;
                        searchboxtxt.Clear();
                    }
                }
            }
        }
















        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (DeleteBookdgv.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please search and select a book first.",
                    "No Book Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int bookID = Convert.ToInt32(
                DeleteBookdgv.SelectedRows[0].Cells["BookID"].Value);

            string title =
                DeleteBookdgv.SelectedRows[0].Cells["Title"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete this book?\n\n" +
                $"Book ID: {bookID}\n" +
                $"Title: {title}",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            DeleteBook(bookID);
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
