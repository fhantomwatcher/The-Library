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
    public partial class HeadLibrDashboard : Form
    {
        public HeadLibrDashboard()
        {
            InitializeComponent();
        }

        private void plogoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                login login = new login();
                login.Show();

                this.Close();
            }
        }
    }
}
