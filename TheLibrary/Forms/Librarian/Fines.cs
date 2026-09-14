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
    public partial class Fines : Form
    {
        public Fines()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LMSDb;Integrated Security=True;");
            conn.Open();
            string query = "SELECT * FROM Fines";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void btnAddFine_Click(object sender, EventArgs e)
        {
            string loanId = txtLoanID.Text;
            string amount = txtAmount.Text;
            string reason = txtReason.Text;

            lblErrorLoanID.Text = lblErrorAmount.Text = lblErrorReason.Text = "";

            if (txtLoanID.Text == "")
                lblErrorLoanID.Text = "Please enter Loan ID!";
            if (txtAmount.Text == "")
                lblErrorAmount.Text = "Please enter amount!";
            if (txtReason.Text == "")
                lblErrorReason.Text = "Please enter reason!";

            if (txtLoanID.Text != "" && txtAmount.Text != "" && txtReason.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LMSDb;Integrated Security=True;");
                conn.Open();

                string query = "insert into Fines (LoanID,Amount,Reason,IsPaid) values('" + loanId + "','" + amount + "','" + reason + "','0')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                Refresh();
            }
            }

            private void btnMarkPaid_Click(object sender, EventArgs e)
       {
            string fineId = txtFineID.Text;
            lblErrorFineID.Text = "";

            if (txtFineID.Text == "")
                lblErrorFineID.Text = "Please select a fine ID!";

            if (txtFineID.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LMSDb;Integrated Security=True;");
                conn.Open();

                string query = "Update Fines set IsPaid='1', PaidDate=GETDATE() where FineID=" + fineId;
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
    }
}
