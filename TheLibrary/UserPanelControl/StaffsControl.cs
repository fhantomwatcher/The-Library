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
    public partial class StaffsControl : UserControl
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        private DataTable headLibrarianTable;
        private DataTable librarianTable;
        public StaffsControl()
        {
            InitializeComponent();

            LoadHeadLibrarians();
            LoadLibrarians();
        }

        private void LoadHeadLibrarians()
        {
            string query = @"
                SELECT
                    u.UserID,
                    u.FullName,
                    u.Email,
                    u.Phone,
                    s.EmployeeCode,
                    s.HireDate,
                    s.Position
                FROM Users u
                INNER JOIN Staff s
                    ON u.UserID = s.UserID
                WHERE u.Role = 'Head Librarian'";

            using (SqlConnection conn = db.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                headLibrarianTable = new DataTable();

                adapter.Fill(headLibrarianTable);

                DgvHL.DataSource = headLibrarianTable;
            }
        }


        private void LoadLibrarians()
        {
            string query = @"
                SELECT
                    u.UserID,
                    u.FullName,
                    u.Email,
                    u.Phone,
                    s.EmployeeCode,
                    s.HireDate,
                    s.Position
                FROM Users u
                INNER JOIN Staff s
                    ON u.UserID = s.UserID
                WHERE u.Role = 'Librarian'";

            using (SqlConnection conn = db.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                librarianTable = new DataTable();

                adapter.Fill(librarianTable);

                DgvL.DataSource = librarianTable;
            }
        }

        private void HLSearchtxt_TextChanged(object sender, EventArgs e)
        {
            string search = HLSearchtxt.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                DgvHL.DataSource = headLibrarianTable;
                return;
            }

            DataView view = headLibrarianTable.DefaultView;

            view.RowFilter =
                $"CONVERT(UserID, 'System.String') LIKE '%{search}%' " +
                $"OR FullName LIKE '%{search}%' " +
                $"OR Email LIKE '%{search}%' " +
                $"OR Phone LIKE '%{search}%' " +
                $"OR EmployeeCode LIKE '%{search}%' " +
                $"OR Position LIKE '%{search}%'";

            DgvHL.DataSource = view;
        }

        private void LSearchtxt_TextChanged(object sender, EventArgs e)
        {
            string search = LSearchtxt.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                DgvL.DataSource = librarianTable;
                return;
            }

            DataView view = librarianTable.DefaultView;

            view.RowFilter =
                $"CONVERT(UserID, 'System.String') LIKE '%{search}%' " +
                $"OR FullName LIKE '%{search}%' " +
                $"OR Email LIKE '%{search}%' " +
                $"OR Phone LIKE '%{search}%' " +
                $"OR EmployeeCode LIKE '%{search}%' " +
                $"OR Position LIKE '%{search}%'";

            DgvL.DataSource = view;
        }

        private void HLSearchbtn_Click(object sender, EventArgs e)
        {
            string search = HLSearchtxt.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                DgvHL.DataSource = headLibrarianTable;
                return;
            }

            DataView view = headLibrarianTable.DefaultView;

            view.RowFilter =
                $"CONVERT(UserID, 'System.String') LIKE '%{search}%' " +
                $"OR FullName LIKE '%{search}%' " +
                $"OR Email LIKE '%{search}%' " +
                $"OR Phone LIKE '%{search}%' " +
                $"OR EmployeeCode LIKE '%{search}%' " +
                $"OR Position LIKE '%{search}%'";

            DgvHL.DataSource = view;
        }

        private void LSearchbtn_Click(object sender, EventArgs e)
        {
            string search = LSearchtxt.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                DgvL.DataSource = librarianTable;
                return;
            }

            DataView view = librarianTable.DefaultView;

            view.RowFilter =
                $"CONVERT(UserID, 'System.String') LIKE '%{search}%' " +
                $"OR FullName LIKE '%{search}%' " +
                $"OR Email LIKE '%{search}%' " +
                $"OR Phone LIKE '%{search}%' " +
                $"OR EmployeeCode LIKE '%{search}%' " +
                $"OR Position LIKE '%{search}%'";

            DgvL.DataSource = view;
        }

        private void HLSearchbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HLSearchbtn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void LSearchbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LSearchbtn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DeleteStaffForm deleteForm = new DeleteStaffForm();

            deleteForm.ShowDialog();

            LoadHeadLibrarians();
            LoadLibrarians();
        }

        private void addstflbl_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffForm = new AddStaffForm();

            addStaffForm.ShowDialog();

            LoadHeadLibrarians();
            LoadLibrarians();
        }











    }
}
