using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Member_data
{
    public partial class MyborrowedBooks : Form
    {
        public MyborrowedBooks()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MyborrowedBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnRenewBook_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == "")
            {
                MessageBox.Show("Please enter Book ID first!");
                return;
            }

            string bookID = txtBookID.Text;
            string connectionString =
                @"Data Source=.\SQLEXPRESS;Initial Catalog=LMSDb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);

            string checkQuery = "SELECT COUNT(*) FROM BookCopies WHERE BookID = @BookID AND Status = 'active'";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@BookID", bookID);

            con.Open();
            int count = (int)checkCmd.ExecuteScalar();

            if (count == 0)
            {
                con.Close();
                MessageBox.Show("Book not available for renew.");
                return;
            }

            string query = "UPDATE BookCopies SET DueDate = DATEADD(day, 7, DueDate) WHERE BookID = @BookID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@BookID", bookID);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Book renewed successfully! Due date extended.");

            btnRefresh_Click(sender, e);
        }

        private void dgvBorrowedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connectionString =
                @"Data Source=.\SQLEXPRESS;Initial Catalog=LMSDb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);

            string query = "SELECT * FROM BookCopies WHERE Status = 'active'";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvBorrowedBooks.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }
    }
}