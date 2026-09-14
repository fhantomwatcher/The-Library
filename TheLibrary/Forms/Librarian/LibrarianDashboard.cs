using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLibrary
{
    public partial class LibrarianDashboard : Form
    {
        public LibrarianDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIssueReturn_Click(object sender, EventArgs e)
        {
            IssueReturn form = new IssueReturn();
            form.Show();
            this.Hide();
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            Fines form = new Fines();
            form.Show();
            this.Hide();
        }

        private void btnManageMember_Click(object sender, EventArgs e)
        {
            ManageMembers form = new ManageMembers();
            form.Show();
            this.Hide();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            Reservations form = new Reservations();
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();

            this.Close();
        }
    }
}
