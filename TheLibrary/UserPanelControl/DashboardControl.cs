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
using TheLibrary.HelperLib;
using TheLibrary.Models;

namespace TheLibrary.UserPanelControl
{
    public partial class DashboardControl : UserControl
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private UserInfo currentUser;
        public DashboardControl(UserInfo user)
        {
            InitializeComponent();
            currentUser = user;

            dashtitleuslbl03.Text = currentUser.FullName;
            LoadDashboardReport();

        }


        private void LoadDashboardReport()
        {
            string query = @"
        SELECT

            (SELECT COUNT(*)
             FROM Books)
                AS TotalBooks,

            (SELECT COUNT(*)
             FROM BookCopies)
                AS TotalCopies,

            (SELECT COUNT(*)
             FROM BookCopies
             WHERE Status = 'Available')
                AS AvailableCopies,

            (SELECT COUNT(*)
             FROM BookCopies
             WHERE Status = 'Borrowed')
                AS BorrowedCopies,

            (SELECT COUNT(*)
             FROM Members)
                AS TotalMembers,

            (SELECT COUNT(*)
             FROM Staff)
                AS TotalStaff,

            (SELECT COUNT(*)
             FROM Fines)
                AS TotalFines,

            (SELECT ISNULL(SUM(Amount), 0)
             FROM Fines
             WHERE isPaid = 1)
                AS PaidRevenue,

            (SELECT COUNT(*)
             FROM Fines
             WHERE isPaid = 0)
                AS UnpaidFines,

            (SELECT ISNULL(SUM(Amount), 0)
             FROM Fines
             WHERE isPaid = 0)
                AS OutstandingAmount";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd =
                new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TotalBookLbL.Text =
                                reader["TotalBooks"].ToString();

                            TotalCopiesLbL.Text =
                                reader["TotalCopies"].ToString();

                            AvailableCopyLbL.Text =
                                reader["AvailableCopies"].ToString();

                            BorrowedCopyLbL.Text =
                                reader["BorrowedCopies"].ToString();

                            TotalMemberLbL.Text =
                                reader["TotalMembers"].ToString();

                            TotalStaffLbL.Text =
                                reader["TotalStaff"].ToString();
                            TotalFineTxTLbL.Text = reader["TotalFines"].ToString();

                            TotalRevenueTxTLbL.Text =
                                Convert.ToDecimal(reader["PaidRevenue"])
                                    .ToString("N2") + " BDT";

                            UnpaidFineLbL.Text =
                                reader["UnpaidFines"].ToString();

                            OutstandingLbL.Text =
                                Convert.ToDecimal(reader["OutstandingAmount"])
                                    .ToString("N2") + " BDT";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading dashboard report:\n\n" +
                        ex.Message,
                        "Dashboard Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }






    }
}
