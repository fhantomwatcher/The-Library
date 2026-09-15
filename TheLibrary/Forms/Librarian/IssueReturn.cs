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
    public partial class IssueReturn : Form
    {
        public IssueReturn()
        {
            InitializeComponent();
        }

        private void IssueReturn_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FHANTOM\SQLEXPRESS;Initial Catalog=TheLibraryDB;Integrated Security=True;");
            conn.Open();
            string query = "SELECT * FROM Loans";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

            string copyId = txtCopyID.Text;
            string memberId = txtMemberID.Text;
            string issuedBy = txtIssuedBy.Text;
            string dueDate = dtpDueDate.Value.ToShortDateString();

            lblErrorCopyID.Text = lblErrorMemberID.Text = lblErrorIssuedBy.Text = "";

            if (txtCopyID.Text == "")
                lblErrorCopyID.Text = "Please enter Copy ID!";
            if (txtMemberID.Text == "")
                lblErrorMemberID.Text = "Please enter Member ID!";
            if (txtIssuedBy.Text == "")
                lblErrorIssuedBy.Text = "Please enter Staff ID!";

            if (txtCopyID.Text != "" && txtMemberID.Text != "" && txtIssuedBy.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=FHANTOM\SQLEXPRESS;Initial Catalog=TheLibraryDB;Integrated Security=True;");
                conn.Open();

                string query = "insert into Loans (CopyID,MemberID,IssuedBy,IssueDate,DueDate,Status) values('" + copyId + "','" + memberId + "','" + issuedBy + "',GETDATE(),'" + dueDate + "','Active')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                string query2 = "Update BookCopies set Status='Loaned' where CopyID=" + copyId;
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.ExecuteNonQuery();


                Refresh();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string copyId = txtCopyID.Text;
            lblErrorCopyID.Text = "";

            if (txtCopyID.Text == "")
                lblErrorCopyID.Text = "Please enter Copy ID!";
            if (txtCopyID.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=FHANTOM\SQLEXPRESS;Initial Catalog=TheLibraryDB;Integrated Security=True;");
                conn.Open();

                string query = "Update Loans set ReturnDate=GETDATE(), Status='Returned' where CopyID=" + copyId + " and Status='Active'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                string query2 = "Update BookCopies set Status='Available' where CopyID=" + copyId;
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.ExecuteNonQuery();


                Refresh();
            }
        }

        private void lblErrorCopyID_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LibrarianDashboard dashboard = new LibrarianDashboard();
            dashboard.Show();
            this.Close();
        }

        private void txtCopyID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCopyID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMemberID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtIssuedBy.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }
    }
}
