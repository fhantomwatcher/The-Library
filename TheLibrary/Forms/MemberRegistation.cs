using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TheLibrary.HelperLib;

namespace TheLibrary
{
    public partial class MemberRegistation : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private bool openedFromMemberPanel = false;

        public MemberRegistation(bool fromMemberPanel = false)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            openedFromMemberPanel = fromMemberPanel;
        }

        private void Dobpick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cancelregisbtn_Click(object sender, EventArgs e)
        {
            if (openedFromMemberPanel)
            {
                this.Close();
            }
            else
            {
                login login = new login();
                login.Show();
                this.Hide();
            }
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            // Get values from form
            string fullName = fntxt.Text.Trim();
            string email = emailtxt.Text.Trim();
            string password = passtxt.Text;
            string phone = phonetxt.Text.Trim();
            string address = addrsrtxt.Text.Trim();

            DateTime dateOfBirth = Dobpick.Value;

            // Get gender
            string gender = "";

            if (genderMalerb.Checked)
            {
                gender = "Male";
            }
            else if (genderFemalerb.Checked)
            {
                gender = "Female";
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show(
                    "Please enter your full name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                fntxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Please enter your email.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                emailtxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                passtxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show(
                    "Please enter your phone number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                phonetxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show(
                    "Please enter your address.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                addrsrtxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show(
                    "Please select your gender.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            RegisterMember(
                fullName,
                email,
                password,
                phone,
                address,
                dateOfBirth,
                gender
            );
        }

        private void RegisterMember(
            string fullName,
            string email,
            string password,
            string phone,
            string address,
            DateTime dateOfBirth,
            string gender)
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
                    'Member',
                    @DateOfBirth,
                    @Gender,
                    GETDATE()
                );

                SELECT SCOPE_IDENTITY();
            ";

            string insertMemberQuery = @"
                INSERT INTO Members
                (
                    UserID,
                    MembershipDate,
                    MaxBooksAllowed,
                    MembershipStatus
                )
                VALUES
                (
                    @UserID,
                    @MembershipDate,
                    @MaxBooksAllowed,
                    @MembershipStatus
                );
            ";

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int userID;

                    // Insert into Users
                    using (SqlCommand userCommand =
                        new SqlCommand(insertUserQuery, conn, transaction))
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
                            "@DateOfBirth",
                            dateOfBirth.Date
                        );

                        userCommand.Parameters.AddWithValue(
                            "@Gender",
                            gender
                        );

                        userID = Convert.ToInt32(
                            userCommand.ExecuteScalar()
                        );
                    }

                    // Insert into Members
                    using (SqlCommand memberCommand =
                        new SqlCommand(insertMemberQuery, conn, transaction))
                    {
                        memberCommand.Parameters.AddWithValue(
                            "@UserID",
                            userID
                        );

                        memberCommand.Parameters.AddWithValue(
                            "@MembershipDate",
                            DateTime.Today
                        );

                        memberCommand.Parameters.AddWithValue(
                            "@MaxBooksAllowed",
                            5
                        );

                        memberCommand.Parameters.AddWithValue(
                            "@MembershipStatus",
                            "Active"
                        );

                        memberCommand.ExecuteNonQuery();
                    }

                    // Everything succeeded
                    transaction.Commit();

                    MessageBox.Show(
                        "Registration successful!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    if (openedFromMemberPanel)
                    {
                        this.Close();
                    }
                    else
                    {
                        login login = new login();
                        login.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    MessageBox.Show(
                        "Registration failed.\n\n" + ex.Message,
                        "Registration Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }


        




    private void Regbacklbl_Click(object sender, EventArgs e)
        {
            if (openedFromMemberPanel)
            {
                this.Close();
            }
            else
            {
                login login = new login();
                login.Show();
                this.Hide();
            }
        }
    }
}