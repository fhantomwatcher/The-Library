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
    public partial class AddBookForm : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        public AddBookForm()
        {
            InitializeComponent();
            LoadCategories();
        }


        private void LoadCategories()
        {
            string query = @"
                SELECT CategoryID, CategoryName
                FROM Categories
                ORDER BY CategoryName";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand command =
                new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        CategoryCB.Items.Clear();

                        while (reader.Read())
                        {
                            CategoryCB.Items.Add(
                                new CategoryItem
                                {
                                    CategoryID =
                                        Convert.ToInt32(
                                            reader["CategoryID"]),

                                    CategoryName =
                                        reader["CategoryName"]
                                        .ToString()
                                });
                        }
                    }

                    CategoryCB.DisplayMember = "CategoryName";
                    CategoryCB.ValueMember = "CategoryID";

                    if (CategoryCB.Items.Count > 0)
                    {
                        CategoryCB.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading categories:\n\n" +
                        ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string title = TitleTxT.Text.Trim();
            string author = AuthorTxT.Text.Trim();
            string isbn = ISBNtxt.Text.Trim();
            string publisher = Publishertxt.Text.Trim();
            string shelfLocation = ShelfLocationTxT.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show(
                    "Please enter the book title.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                TitleTxT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(author))
            {
                MessageBox.Show(
                    "Please enter the author name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                AuthorTxT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show(
                    "Please enter the ISBN.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                ISBNtxt.Focus();
                return;
            }

            if (CategoryCB.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a category.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                CategoryCB.Focus();
                return;
            }

            int publishedYear = PublishYearPick.Value.Year;

            CategoryItem selectedCategory =
                (CategoryItem)CategoryCB.SelectedItem;

            AddBook(
                title,
                author,
                isbn,
                selectedCategory.CategoryID,
                publisher,
                publishedYear,
                shelfLocation
            );
        }

        private void AddBook(
            string title,
            string author,
            string isbn,
            int categoryID,
            string publisher,
            int publishedYear,
            string shelfLocation)
        {
            string query = @"
                INSERT INTO Books
                (
                    CategoryID,
                    Title,
                    Author,
                    ISBN,
                    Publisher,
                    PublishedYear,
                    ShelfLocation
                )
                VALUES
                (
                    @CategoryID,
                    @Title,
                    @Author,
                    @ISBN,
                    @Publisher,
                    @PublishedYear,
                    @ShelfLocation
                )";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand command =
                new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    command.Parameters.AddWithValue(
                        "@CategoryID",
                        categoryID);

                    command.Parameters.AddWithValue(
                        "@Title",
                        title);

                    command.Parameters.AddWithValue(
                        "@Author",
                        author);

                    command.Parameters.AddWithValue(
                        "@ISBN",
                        isbn);

                    if (string.IsNullOrEmpty(publisher))
                    {
                        command.Parameters.AddWithValue(
                            "@Publisher",
                            DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue(
                            "@Publisher",
                            publisher);
                    }

                    if (publishedYear == 0)
                    {
                        command.Parameters.AddWithValue(
                            "@PublishedYear",
                            DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue(
                            "@PublishedYear",
                            publishedYear);
                    }

                    if (string.IsNullOrEmpty(shelfLocation))
                    {
                        command.Parameters.AddWithValue(
                            "@ShelfLocation",
                            DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue(
                            "@ShelfLocation",
                            shelfLocation);
                    }

                    command.ExecuteNonQuery();

                    MessageBox.Show(
                        "Book added successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        "Error adding book:\n\n" +
                        ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error:\n\n" +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class CategoryItem
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public override string ToString()
        {
            return CategoryName;
        }
    }


}
