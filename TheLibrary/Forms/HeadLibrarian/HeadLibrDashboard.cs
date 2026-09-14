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
using TheLibrary.UserPanelControl;

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
            ShowDashboard();
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

        private void ShowDashboard()
        {
            DashboardControl dashboard = new DashboardControl(currentUser);

            panelContant.Controls.Clear();

            dashboard.Dock = DockStyle.Fill;

            panelContant.Controls.Add(dashboard);
        }

        private void pbtnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }


        private void ShowStaff()
        {
            StaffsControl staff = new StaffsControl();

            panelContant.Controls.Clear();

            staff.Dock = DockStyle.Fill;

            panelContant.Controls.Add(staff);
        }

        private void ShowMembers()
        {
            MembersControl members = new MembersControl();

            panelContant.Controls.Clear();
            members.Dock = DockStyle.Fill;
            panelContant.Controls.Add(members);
        }

        private void pbtnStaff_Click(object sender, EventArgs e)
        {
            ShowStaff();
        }

        private void pmembersbtn_Click(object sender, EventArgs e)
        {
            ShowMembers();
        }


        private void ShowBooks()
        {
            BooksControl books = new BooksControl();

            panelContant.Controls.Clear();

            books.Dock = DockStyle.Fill;

            panelContant.Controls.Add(books);
        }



        private void pbtnBooks_Click(object sender, EventArgs e)
        {
            ShowBooks();
        }
    }
}
