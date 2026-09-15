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
    public partial class ManageMembers : Form
    {
        
        public ManageMembers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFullName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FHANTOM\SQLEXPRESS;Initial Catalog=TheLibraryDB;Integrated Security=True;");
            conn.Open();
            string query = "SELECT * FROM [USERS]; ";
 
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;

            txtFullName.Text = txtEmail.Text = txtPassword.Text =txtPhone.Text= "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblErrorFullName.Text = lblErrorEmail.Text = lblErrorPassword.Text = lblErrorPhone.Text = "";

            if (txtFullName.Text == "")
                lblErrorFullName.Text = "Please enter full name!";
            if (txtEmail.Text == "")
                lblErrorEmail.Text = "Please enter email!";
            if (txtPassword.Text == "")
                lblErrorPassword.Text = "Please enter password!";
            if (txtPhone.Text == "")
                lblErrorPhone.Text = "Please enter phone!";

            if (txtFullName.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtPhone.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=FHANTOM\SQLEXPRESS;Initial Catalog=TheLibraryDB;Integrated Security=True;");
                conn.Open();
                string query = "Update [Users] set FullName='" + txtFullName.Text + "', Email='" + txtEmail.Text + "', Password='" + txtPassword.Text + "' where UserID=" + txtID.Text;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Refresh();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
            string email = txtEmail.Text;
            string pass = txtPassword.Text;
            string phone = txtPhone.Text;
            lblErrorFullName.Text = lblErrorEmail.Text = lblErrorPassword.Text = lblErrorPhone.Text = "";

            if (txtFullName.Text == "")
                lblErrorFullName.Text = "Please enter full name!";
            if (txtEmail.Text == "")
                lblErrorEmail.Text = "Please enter email!";
            if (txtPassword.Text == "")
                lblErrorPassword.Text = "Please enter password!";
            if (txtPhone.Text == "")
                lblErrorPhone.Text = "Please enter phone!";
            if (txtFullName.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtPhone.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=FHANTOM\SQLEXPRESS;Initial Catalog=TheLibraryDB;Integrated Security=True;");
                conn.Open();
                string query = "insert into [Users] (FullName,Email,Password,Phone,Role,CreatedAt) values('" + name + "','" + email + "','" + pass + "','" + phone + "','Member',GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Refresh();
            }
            }

            private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FHANTOM\SQLEXPRESS;Initial Catalog=TheLibraryDB;Integrated Security=True;");
            conn.Open();
           string query1 = "Delete from Members where UserID=" + txtID.Text;
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.ExecuteNonQuery();

           string query2 = "Delete from [Users] where UserID=" + txtID.Text;
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.ExecuteNonQuery();

    
            Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LibrarianDashboard dashboard = new LibrarianDashboard();
            dashboard.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
