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
    public partial class BrowseBooks : Form
    {
        public BrowseBooks()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string search = txtSearch.Text;

            if (search == "")
            {
                lblError.Text = "Please enter a Book ID !";
                return;
            }

            SqlConnection con = new SqlConnection(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=LMSDb;Integrated Security=True;TrustServerCertificate=True");

            string query = "SELECT * FROM Books WHERE Title LIKE @search OR Author LIKE @search";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvBooks.DataSource = dt;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}