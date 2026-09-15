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
    public partial class SystemSettingsControl : UserControl
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private int currentUserID;
        public SystemSettingsControl(UserInfo user)
        {
            InitializeComponent();
            currentUserID = user.UserID;
            BorrowSettings();
        }



        private void BorrowSettings()
        {
            string query = @"
                SELECT TOP 1
                    FineRate,
                    BorrowDurationDays
                FROM SystemSettings
                ORDER BY SettingID DESC";

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
                            FineRateTxt.Text =
                                reader["FineRate"].ToString();

                            BorrowDurationTxt.Text =
                                reader["BorrowDurationDays"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading system settings:\n\n" +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void SaveSetbtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(
                FineRateTxt.Text.Trim(),
                out decimal fineRate))
            {
                MessageBox.Show(
                    "Please enter a valid fine rate.",
                    "Invalid Fine Rate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                FineRateTxt.Focus();
                return;
            }

            if (fineRate < 0)
            {
                MessageBox.Show(
                    "Fine rate cannot be negative.",
                    "Invalid Fine Rate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                FineRateTxt.Focus();
                return;
            }

            if (!int.TryParse(
                BorrowDurationTxt.Text.Trim(),
                out int BorrowDuration))
            {
                MessageBox.Show(
                    "Please enter a valid Borrow duration.",
                    "Invalid Borrow Duration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                BorrowDurationTxt.Focus();
                return;
            }

            if (BorrowDuration <= 0)
            {
                MessageBox.Show(
                    "Borrow duration must be greater than 0.",
                    "Invalid Borrow Duration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                BorrowDurationTxt.Focus();
                return;
            }

            string query = @"
                UPDATE SystemSettings
                SET
                    FineRate = @FineRate,
                    BorrowDurationDays = @BorrowDurationDays,
                    UpdatedAt = GETDATE()
                WHERE SettingID =
                (
                    SELECT MAX(SettingID)
                    FROM SystemSettings
                )";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd =
                new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue(
                        "@FineRate",
                        fineRate);

                    cmd.Parameters.AddWithValue(
                        "@BorrowDurationDays",
                        BorrowDuration);

                    conn.Open();

                    int rowsAffected =
                        cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(
                            "System settings updated successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error saving system settings:\n\n" +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            BorrowSettings();
        }


        private void ChangePassword()
        {
            string currentPassword =
                CurrentPassTitleTxT.Text.Trim();

            string newPassword =
                NewPassTitleTxt.Text.Trim();

            string confirmPassword =
                ConfirmPassTitleTxt.Text.Trim();

            if (string.IsNullOrEmpty(currentPassword))
            {
                MessageBox.Show(
                    "Please enter your current password.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CurrentPassTitleTxT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show(
                    "Please enter a new password.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                NewPassTitleTxt.Focus();
                return;
            }

            if (newPassword.Length < 3)
            {
                MessageBox.Show(
                    "New password must contain at least 6 characters.",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                ConfirmPassTitleTxt.Focus();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show(
                    "New password and confirmation password do not match.",
                    "Password Mismatch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                ConfirmPassTitleTxt.Focus();
                return;
            }

            if (currentPassword == newPassword)
            {
                MessageBox.Show(
                    "New password must be different from your current password.",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                NewPassTitleTxt.Focus();
                return;
            }

            string checkQuery = @"
        SELECT COUNT(*)
        FROM Users
        WHERE UserID = @UserID
        AND Password = @CurrentPassword";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd =
                new SqlCommand(checkQuery, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue(
                        "@UserID",
                        currentUserID);

                    cmd.Parameters.AddWithValue(
                        "@CurrentPassword",
                        currentPassword);

                    conn.Open();

                    int count =
                        Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show(
                            "Current password is incorrect.",
                            "Incorrect Password",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        CurrentPassTitleTxT.Clear();
                        CurrentPassTitleTxT.Focus();

                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error verifying current password:\n\n" +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }
            }

            string updateQuery = @"
        UPDATE Users
        SET Password = @NewPassword
        WHERE UserID = @UserID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd =
                new SqlCommand(updateQuery, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue(
                        "@NewPassword",
                        newPassword);

                    cmd.Parameters.AddWithValue(
                        "@UserID",
                        currentUserID);

                    conn.Open();

                    int rowsAffected =
                        cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(
                            "Password changed successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        CurrentPassTitleTxT.Clear();
                        NewPassTitleTxt.Clear();
                        ConfirmPassTitleTxt.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error changing password:\n\n" +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }
    }
}
