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
    public partial class ProfileControl : UserControl
    {
        private UserInfo currentUser;
        public ProfileControl(UserInfo user)
        {
            InitializeComponent();

            currentUser = user;

            fullnametxtlbl.Text = currentUser.FullName;
            Emailtxtlbl.Text = currentUser.Email;
            Positiontxtlbl.Text = currentUser.Position;
            Phonetxtlbl.Text = currentUser.Phone;
            Addresstxtlbl.Text = currentUser.Address;
            UserIDtxtlbl.Text = currentUser.UserID.ToString();
            Hiredatetxtlbl.Text = currentUser.HireDate != DateTime.MinValue ? currentUser.HireDate.ToString("yyyy-MM-dd") : "N/A";
            Createdattxtlbl.Text = currentUser.CreatedAt != DateTime.MinValue ? currentUser.CreatedAt.ToString("yyyy-MM-dd") : "N/A";
            EmpCodetxtlbl.Text = currentUser.EmployeeCode;
        }
    }
}
