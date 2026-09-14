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
using TheLibrary.Forms;
using TheLibrary.Forms.Books;
using TheLibrary.HelperLib;

namespace TheLibrary.UserPanelControl
{
    public partial class BooksControl : UserControl
    {

        private readonly DatabaseHelper db = new DatabaseHelper();

        private DataTable bookTable;
        public BooksControl()
        {
            InitializeComponent();

            LoadBooks();
        }

        private void LoadBooks()
        {
            string query = @"
        SELECT
            b.BookID,
            b.ISBN,
            b.Title,
            b.Author,
            c.CategoryName,
            b.Publisher,
            b.PublishedYear,
            b.ShelfLocation,

            COUNT(bc.CopyID) AS [Total Copies],

            SUM(CASE
                WHEN bc.Status = 'Available' THEN 1
                ELSE 0
            END) AS [Available],

            SUM(CASE
                WHEN bc.Status = 'Borrowed' THEN 1
                ELSE 0
            END) AS [Borrowed]

        FROM Books b

        INNER JOIN Categories c
            ON b.CategoryID = c.CategoryID

        LEFT JOIN BookCopies bc
            ON b.BookID = bc.BookID

        GROUP BY
            b.BookID,
            b.ISBN,
            b.Title,
            b.Author,
            c.CategoryName,
            b.Publisher,
            b.PublishedYear,
            b.ShelfLocation

        ORDER BY b.BookID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlDataAdapter adapter =
                new SqlDataAdapter(query, conn))
            {
                bookTable = new DataTable();

                adapter.Fill(bookTable);

                DgvBooks.DataSource = bookTable;
            }
        }


        private void SearchBooks()
        {
            string search = SearchTxT.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                DgvBooks.DataSource = bookTable;
                return;
            }

            search = search.Replace("'", "''");

            DataView view = bookTable.DefaultView;

            view.RowFilter =
                $"CONVERT(BookID, 'System.String') LIKE '%{search}%' " +
                $"OR ISBN LIKE '%{search}%' " +
                $"OR Title LIKE '%{search}%' " +
                $"OR Author LIKE '%{search}%' " +
                $"OR CategoryName LIKE '%{search}%' " +
                $"OR Publisher LIKE '%{search}%' " +
                $"OR CONVERT(PublishedYear, 'System.String') LIKE '%{search}%' " +
                $"OR ShelfLocation LIKE '%{search}%'";

            DgvBooks.DataSource = view;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();

            addBookForm.ShowDialog();

            LoadBooks();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditBookForm editBookForm = new EditBookForm();

            editBookForm.ShowDialog();

            LoadBooks();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            DeleteBookForm deleteBookForm = new DeleteBookForm();

            deleteBookForm.ShowDialog();

            LoadBooks();
        }

        private void ManageBookCopyBtn_Click(object sender, EventArgs e)
        {
            ManageBookCopiesForm form = new ManageBookCopiesForm();

            form.ShowDialog();

            LoadBooks();
        }
    }
}
