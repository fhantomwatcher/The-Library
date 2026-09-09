using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLibrary.HelperLib;

namespace TheLibrary
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Check email
            if (InputValidationHelper.IsEmpty(unemtxt.Text))
            {
                lblerrorEmail.Text = "Please enter email.";
                lblerrorEmail.Visible = true;
                isValid = false;
            }
            else if (!InputValidationHelper.IsValidEmail(unemtxt.Text.Trim()))
            {
                lblerrorEmail.Text = "Please enter a valid email.";
                lblerrorEmail.Visible = true;
                isValid = false;
            }
            else
            {
                lblerrorEmail.Visible = false;
            }


            // Check password
            if (InputValidationHelper.IsEmpty(passtxt.Text))
            {
                lblerrorpass.Text = "Please enter password.";
                lblerrorpass.Visible = true;
                isValid = false;
            }
            else
            {
                lblerrorpass.Visible = false;
            }


            // Stop here if validation failed
            if (!isValid)
            {
                return;
            }


            // Validation passed
            // Now check email and password in database
            LoginVerificationHelper loginHelper = new LoginVerificationHelper();

            bool loginSuccess = loginHelper.VerifyLogin(
                unemtxt.Text.Trim(),
                passtxt.Text
            );

            if (loginSuccess)
            {
                HeadLibrDashboard dashboard = new HeadLibrDashboard();
                dashboard.Show();

                this.Hide();

                MessageBox.Show("Login successful!");

            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private void gotoregislbl_Click(object sender, EventArgs e)
        {
            registation registation = new registation();
            registation.Show();

            this.Hide();
        }

        private void unemtxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(unemtxt.Text))
            {
                lblerrorEmail.Visible = false;
            }
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(passtxt.Text))
            {
                lblerrorpass.Visible = false;
            }
        }
    }
}
