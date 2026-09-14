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
    public partial class EditBookForm : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        private DataTable bookTable;

        private int selectedBookID = 0;
        public EditBookForm()
        {
            InitializeComponent();

            

            LoadCategories();
            LoadBooks();
        }

        private void LoadCategories()
        {
            string query = @"
                SELECT CategoryID, CategoryName
                FROM Categories
                ORDER BY CategoryName";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        CategoryCB.Items.Clear();

                        while (reader.Read())
                        {
                            CategoryCB.Items.Add(
                                new CategoryItem
                                {
                                    CategoryID =
                                        Convert.ToInt32(reader["CategoryID"]),

                                    CategoryName =
                                        reader["CategoryName"].ToString()
                                });
                        }
                    }

                    CategoryCB.DisplayMember = "CategoryName";
                    CategoryCB.ValueMember = "CategoryID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading categories:\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
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
                    b.ShelfLocation
                FROM Books b
                INNER JOIN Categories c
                    ON b.CategoryID = c.CategoryID
                ORDER BY b.BookID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlDataAdapter adapter =
                new SqlDataAdapter(query, conn))
            {
                bookTable = new DataTable();

                adapter.Fill(bookTable);

                DGVEidtBook.DataSource = bookTable;
            }
        }


        private void SearchBooks()
        {
            string search = SearchTxT.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                DGVEidtBook.DataSource = bookTable;
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

            DGVEidtBook.DataSource = view;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }

        private void DGVEidtBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = DGVEidtBook.Rows[e.RowIndex];

            selectedBookID =
                Convert.ToInt32(row.Cells["BookID"].Value);

            TitleTxT.Text =
                row.Cells["Title"].Value.ToString();

            AuthorTxT.Text =
                row.Cells["Author"].Value.ToString();

            ISBNtxt.Text =
                row.Cells["ISBN"].Value.ToString();

            Publishertxt.Text =
                row.Cells["Publisher"].Value == DBNull.Value
                ? ""
                : row.Cells["Publisher"].Value.ToString();

            ShelfLocationTxT.Text =
                row.Cells["ShelfLocation"].Value == DBNull.Value
                ? ""
                : row.Cells["ShelfLocation"].Value.ToString();

            int publishedYear = PublishYearPick.Value.Year;

            string categoryName =
                row.Cells["CategoryName"].Value.ToString();

            for (int i = 0; i < CategoryCB.Items.Count; i++)
            {
                CategoryItem item =
                    (CategoryItem)CategoryCB.Items[i];

                if (item.CategoryName == categoryName)
                {
                    CategoryCB.SelectedIndex = i;
                    break;
                }
            }
        }



        private void UpdateBook(
           string title,
           string author,
           string isbn,
           int categoryID,
           string publisher,
           int publishedYear,
           string shelfLocation)
        {
            string query = @"
                UPDATE Books
                SET
                    CategoryID = @CategoryID,
                    Title = @Title,
                    Author = @Author,
                    ISBN = @ISBN,
                    Publisher = @Publisher,
                    PublishedYear = @PublishedYear,
                    ShelfLocation = @ShelfLocation
                WHERE BookID = @BookID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand command =
                new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    command.Parameters.AddWithValue(
                        "@CategoryID", categoryID);

                    command.Parameters.AddWithValue(
                        "@Title", title);

                    command.Parameters.AddWithValue(
                        "@Author", author);

                    command.Parameters.AddWithValue(
                        "@ISBN", isbn);

                    command.Parameters.AddWithValue(
                        "@Publisher",
                        string.IsNullOrEmpty(publisher)
                        ? (object)DBNull.Value
                        : publisher);

                    command.Parameters.AddWithValue(
                        "@PublishedYear", publishedYear);

                    command.Parameters.AddWithValue(
                        "@ShelfLocation",
                        string.IsNullOrEmpty(shelfLocation)
                        ? (object)DBNull.Value
                        : shelfLocation);

                    command.Parameters.AddWithValue(
                        "@BookID", selectedBookID);

                    command.ExecuteNonQuery();

                    MessageBox.Show(
                        "Book updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        "Error updating book:\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error:\n\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }





        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (selectedBookID == 0)
            {
                MessageBox.Show(
                    "Please select a book first.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string title = TitleTxT.Text.Trim();
            string author = AuthorTxT.Text.Trim();
            string isbn = ISBNtxt.Text.Trim();
            string publisher = Publishertxt.Text.Trim();
            string shelfLocation = ShelfLocationTxT.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter the book title.");
                TitleTxT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(author))
            {
                MessageBox.Show("Please enter the author.");
                AuthorTxT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Please enter the ISBN.");
                ISBNtxt.Focus();
                return;
            }

            if (CategoryCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
                CategoryCB.Focus();
                return;
            }

            int publishedYear = PublishYearPick.Value.Year;

            CategoryItem selectedCategory =
                (CategoryItem)CategoryCB.SelectedItem;

            UpdateBook(
                title,
                author,
                isbn,
                selectedCategory.CategoryID,
                publisher,
                publishedYear,
                shelfLocation);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
