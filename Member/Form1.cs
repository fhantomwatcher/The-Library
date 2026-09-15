using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Member_data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnloans_Click(object sender, EventArgs e)
        {
            MyborrowedBooks form = new MyborrowedBooks();
            form.Show();
            this.Hide();
        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            BrowseBooks form = new BrowseBooks();
            form.Show();
            this.Hide();

        }

        private void btnfines_Click(object sender, EventArgs e)
        {
            MyFines form = new MyFines();
            form.Show();
            this.Hide();
        }

        private void btnreserve_Click(object sender, EventArgs e)
        {
            Reservations form = new Reservations();
            form.Show();
            this.Hide();
        }
    }
}
