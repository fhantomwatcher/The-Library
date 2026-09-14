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

namespace TheLibrary.Forms
{
    public partial class AddStaffForm : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        public AddStaffForm()
        {
            InitializeComponent();


            positioncb.Items.Add("Head Librarian");
            positioncb.Items.Add("Librarian");
            positioncb.Items.Add("Assistant Librarian");
            positioncb.Items.Add("Senior Librarian");
            positioncb.Items.Add("Library Manager");

            positioncb.SelectedIndex = 1;
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string fullName = FnTxt.Text.Trim();
            string email = Emailtxt.Text.Trim();
            string password = Passtxt.Text;
            string phone = Phonetxt.Text.Trim();
            string address = addressrtxt.Text.Trim();
            string position = positioncb.Text.Trim();
            string employeeCode = Empcodetxt.Text.Trim();
            DateTime hireDate = hdpicker.Value;
            DateTime DateOfBirth = sdobpicker.Value;
            string Gender = "";

            if (MaleRB.Checked)
            {
                Gender = "Male";
            }
            else if (FemaleRB.Checked)
            {
                Gender = "Female";
            }


            // Validation
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show(
                    "Please enter the full name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                FnTxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Please enter the email.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Emailtxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter the password.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Passtxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show(
                    "Please enter the phone number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Phonetxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show(
                    "Please enter the address.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                addressrtxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(position))
            {
                MessageBox.Show(
                    "Please select a position.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                positioncb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(employeeCode))
            {
                MessageBox.Show(
                    "Please enter the employee code.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Empcodetxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Gender))
            {
                MessageBox.Show(
                    "Please select a gender.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            string role;

            if (position == "Head Librarian")
            {
                role = "Head Librarian";
            }
            else
            {
                role = "Librarian";
            }

            RegisterStaff(
                fullName,
                email,
                password,
                phone,
                address,
                role,
                employeeCode,
                hireDate,
                DateOfBirth,
                Gender,
                position
            );
        }


        private void RegisterStaff(
            string fullName,
            string email,
            string password,
            string phone,
            string address,
            string role,
            string employeeCode,
            DateTime hireDate,
            DateTime dateOfBirth,
            string gender,
            string position)
        {


            string insertUserQuery = @"
                INSERT INTO Users
                (
                    FullName,
                    Email,
                    Password,
                    Phone,
                    Address,
                    Role,
                    DateOfBirth,
                    Gender,
                    CreatedAt
                )
                VALUES
                (
                    @FullName,
                    @Email,
                    @Password,
                    @Phone,
                    @Address,
                    @Role,
                    @DateOfBirth,
                    @Gender,
                    GETDATE()
                );

                SELECT SCOPE_IDENTITY();
            ";



            string insertStaffQuery = @"
                INSERT INTO Staff
                (
                    UserID,
                    EmployeeCode,
                    HireDate,
                    Position
                )
                VALUES
                (
                    @UserID,
                    @EmployeeCode,
                    @HireDate,
                    @Position
                );
            ";



            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int userID;


                    using (SqlCommand userCommand =
                        new SqlCommand(
                            insertUserQuery,
                            conn,
                            transaction))
                    {

                        userCommand.Parameters.AddWithValue(
                            "@FullName",
                            fullName
                        );

                        userCommand.Parameters.AddWithValue(
                            "@Email",
                            email
                        );

                        userCommand.Parameters.AddWithValue(
                            "@Password",
                            password
                        );

                        userCommand.Parameters.AddWithValue(
                            "@Phone",
                            phone
                        );

                        userCommand.Parameters.AddWithValue(
                            "@Address",
                            address
                        );

                        userCommand.Parameters.AddWithValue(
                            "@Role",
                            role
                        );

                        userCommand.Parameters.AddWithValue(
                            "@DateOfBirth",
                            dateOfBirth
                        );

                        userCommand.Parameters.AddWithValue(
                            "@Gender",
                            gender
                        );


                        
                        userID = Convert.ToInt32(
                            userCommand.ExecuteScalar()
                        );
                    }


                    using (SqlCommand staffCommand =
                        new SqlCommand(
                            insertStaffQuery,
                            conn,
                            transaction))
                    {

                        staffCommand.Parameters.AddWithValue(
                            "@UserID",
                            userID
                        );

                        staffCommand.Parameters.AddWithValue(
                            "@EmployeeCode",
                            employeeCode
                        );

                        staffCommand.Parameters.AddWithValue(
                            "@HireDate",
                            hireDate
                        );

                        staffCommand.Parameters.AddWithValue(
                            "@Position",
                            position
                        );


                        staffCommand.ExecuteNonQuery();
                    }



                    transaction.Commit();



                    MessageBox.Show(
                        "Staff registered successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.Close();
                }
                catch (Exception ex)
                {
                   
                    transaction.Rollback();


                    MessageBox.Show(
                        "Error registering staff:\n\n" + ex.Message,
                        "Registration Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }


        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
