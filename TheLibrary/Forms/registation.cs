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
    public partial class registation : Form
    {
        public registation()
        {
            InitializeComponent();
        }

        private void Dobpick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cancelregisbtn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            

        }

        private void Regbacklbl_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
    }
}
