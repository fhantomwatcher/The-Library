using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheLibrary
{
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LMSDb;Integrated Security=True;");
            conn.Open();
            string query = "SELECT * FROM Reservations";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            string bookId = txtBookID.Text;
            string memberId = txtMemberID.Text;
            string expiryDate = dtpExpiryDate.Value.ToShortDateString();

            lblErrorBookID.Text = lblErrorMemberID.Text = "";

            if (txtBookID.Text == "")
                lblErrorBookID.Text = "Please enter Book ID!";
            if (txtMemberID.Text == "")
                lblErrorMemberID.Text = "Please enter Member ID!";

            if (txtBookID.Text != "" && txtMemberID.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LMSDb;Integrated Security=True;");
                conn.Open();

                string query = "insert into Reservations (BookID,MemberID,ReservationDate,ExpiryDate,Status) values('" + bookId + "','" + memberId + "',GETDATE(),'" + expiryDate + "','Pending')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string reservationId = txtReservationID.Text;

            lblErrorReservationID.Text = "";

            if (txtReservationID.Text == "")
                lblErrorReservationID.Text = "Please select a reservation ID!";

            if (txtReservationID.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LMSDb;Integrated Security=True;");
                conn.Open();

                string query = "Update Reservations set Status='Cancelled' where ReservationID=" + reservationId;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                Refresh();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LibrarianDashboard dashboard = new LibrarianDashboard();
            dashboard.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtReservationID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBookID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMemberID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           
        }
    }
}
