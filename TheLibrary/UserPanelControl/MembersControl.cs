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
using TheLibrary.Forms;
using TheLibrary.HelperLib;

namespace TheLibrary.UserPanelControl
{
    public partial class MembersControl : UserControl
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        private DataTable memberTable;



        public MembersControl()
        {
            InitializeComponent();

            LoadMembers();
        }


        private void LoadMembers()
        {
            string query = @"
                SELECT
                    u.UserID,
                    u.FullName,
                    u.Email,
                    u.Phone,
                    u.DateOfBirth,
                    u.Gender,
                    u.Address,
                    u.CreatedAt,
                    m.MembershipDate,
                    m.MaxBooksAllowed,
                    m.MembershipStatus
                FROM Users u
                INNER JOIN Members m
                    ON u.UserID = m.UserID
                WHERE u.Role = 'Member'
                ORDER BY u.UserID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                memberTable = new DataTable();

                adapter.Fill(memberTable);

                MemberlistDGV.DataSource = memberTable;
            }
        }


        private void SearchMembers()
        {
            string search = SearchTxT.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                MemberlistDGV.DataSource = memberTable;
                return;
            }

            search = search.Replace("'", "''");

            DataView view = memberTable.DefaultView;

            view.RowFilter =
                $"CONVERT(UserID, 'System.String') LIKE '%{search}%' " +
                $"OR FullName LIKE '%{search}%' " +
                $"OR Email LIKE '%{search}%' " +
                $"OR Phone LIKE '%{search}%' " +
                $"OR Gender LIKE '%{search}%' " +
                $"OR Address LIKE '%{search}%' " +
                $"OR MembershipStatus LIKE '%{search}%'";

            MemberlistDGV.DataSource = view;
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchMembers();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            MemberRegistation registrationForm = new MemberRegistation(true);

            registrationForm.ShowDialog();

            LoadMembers();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            DeleteMemberForm deleteForm = new DeleteMemberForm();

            deleteForm.ShowDialog();

            LoadMembers();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditMemberForm editForm = new EditMemberForm();

            editForm.ShowDialog();

            LoadMembers();
        }
    }
}
