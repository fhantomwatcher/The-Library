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

namespace Member_data
{
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=LMSDb;Integrated Security=True;TrustServerCertificate=True");

            string query = "SELECT * FROM BookCopies WHERE Status = 'available'";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvReservations.DataSource = dt;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == "")
            {
                MessageBox.Show("Please enter Book ID first!");
                return;
            }

            string bookID = txtBookID.Text;

            SqlConnection con = new SqlConnection(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=LMSDb;Integrated Security=True;TrustServerCertificate=True");

            string checkQuery = "SELECT COUNT(*) FROM BookCopies WHERE BookID = @BookID AND Status = 'available'";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@BookID", bookID);

            con.Open();
            int count = (int)checkCmd.ExecuteScalar();

            if (count == 0)
            {
                con.Close();
                MessageBox.Show("Book not available for reservation.");
                return;
            }

            string insertQuery = "INSERT INTO Reservations (BookID, ReservationDate, ExpiryDate, Status) " +
                                  "VALUES (@BookID, GETDATE(), DATEADD(day, 7, GETDATE()), 'Pending')";
            SqlCommand insertCmd = new SqlCommand(insertQuery, con);
            insertCmd.Parameters.AddWithValue("@BookID", bookID);
            insertCmd.ExecuteNonQuery();

            string updateQuery = "UPDATE BookCopies SET Status = 'reserved' WHERE BookID = @BookID";
            SqlCommand updateCmd = new SqlCommand(updateQuery, con);
            updateCmd.Parameters.AddWithValue("@BookID", bookID);
            updateCmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Book reserved successfully!");

            btnRefresh_Click(sender, e);
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == "")
            {
                MessageBox.Show("Please enter Book ID first!");
                return;
            }

            string bookID = txtBookID.Text;

            SqlConnection con = new SqlConnection(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=LMSDb;Integrated Security=True;TrustServerCertificate=True");

            string deleteQuery = "DELETE FROM Reservations WHERE BookID = @BookID";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
            deleteCmd.Parameters.AddWithValue("@BookID", bookID);

            con.Open();
            deleteCmd.ExecuteNonQuery();

            string updateQuery = "UPDATE BookCopies SET Status = 'available' WHERE BookID = @BookID";
            SqlCommand updateCmd = new SqlCommand(updateQuery, con);
            updateCmd.Parameters.AddWithValue("@BookID", bookID);
            updateCmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Reservation cancelled successfully!");

            btnRefresh_Click(sender, e);
        }
    }
}