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

namespace TheLibrary.UserPanelControl
{
    public partial class DashboardControl : UserControl
    {
        private UserInfo currentUser;
        public DashboardControl(UserInfo user)
        {
            InitializeComponent();
            currentUser = user;

            dashtitleuslbl03.Text = currentUser.FullName;

        }
    }
}
