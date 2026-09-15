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
    public partial class MyFines : Form
    {
        public MyFines()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=LMSDb;Integrated Security=True;TrustServerCertificate=True");

            string query = "SELECT * FROM Fine";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvFines.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }
    }
} 