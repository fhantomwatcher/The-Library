using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLibrary.Models;

namespace TheLibrary
{
    public partial class HeadLibrDashboard : Form
    {
        private login loginForm;
        private UserInfo currentUser;
        public HeadLibrDashboard(UserInfo user, login loginForm)
        {
            InitializeComponent();
            this.currentUser = user;
            this.loginForm = loginForm;

            this.Text = $"Dashboard | {currentUser.FullName} | {currentUser.Role}";
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

        private void pbtnProfile_Click(object sender, EventArgs e)
        {
            ProfileControl profile = new ProfileControl(currentUser);

            panelContant.Controls.Clear();

            profile.Dock = DockStyle.Fill;

            panelContant.Controls.Add(profile);
        }
    }
}
