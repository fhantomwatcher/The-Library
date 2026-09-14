namespace TheLibrary
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.Thelibrarytitle = new System.Windows.Forms.Label();
            this.unemlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.unemtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.gotoregislbl = new System.Windows.Forms.Label();
            this.lblerrorEmail = new System.Windows.Forms.Label();
            this.lblerrorpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Thelibrarytitle
            // 
            this.Thelibrarytitle.AutoSize = true;
            this.Thelibrarytitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thelibrarytitle.Location = new System.Drawing.Point(161, 64);
            this.Thelibrarytitle.Name = "Thelibrarytitle";
            this.Thelibrarytitle.Size = new System.Drawing.Size(143, 31);
            this.Thelibrarytitle.TabIndex = 0;
            this.Thelibrarytitle.Text = "TheLibrary";
            // 
            // unemlbl
            // 
            this.unemlbl.AutoSize = true;
            this.unemlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unemlbl.Location = new System.Drawing.Point(51, 191);
            this.unemlbl.Name = "unemlbl";
            this.unemlbl.Size = new System.Drawing.Size(57, 24);
            this.unemlbl.TabIndex = 1;
            this.unemlbl.Text = "Email";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(51, 256);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(94, 24);
            this.passlbl.TabIndex = 2;
            this.passlbl.Text = "PassWord";
            // 
            // unemtxt
            // 
            this.unemtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unemtxt.Location = new System.Drawing.Point(167, 190);
            this.unemtxt.Name = "unemtxt";
            this.unemtxt.Size = new System.Drawing.Size(219, 29);
            this.unemtxt.TabIndex = 3;
            this.unemtxt.TextChanged += new System.EventHandler(this.unemtxt_TextChanged);
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(167, 254);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(219, 29);
            this.passtxt.TabIndex = 4;
            this.passtxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.loginbtn.Location = new System.Drawing.Point(167, 382);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(117, 33);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            this.loginbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginbtn_KeyDown);
            // 
            // gotoregislbl
            // 
            this.gotoregislbl.AutoSize = true;
            this.gotoregislbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gotoregislbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoregislbl.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.gotoregislbl.Location = new System.Drawing.Point(137, 341);
            this.gotoregislbl.Name = "gotoregislbl";
            this.gotoregislbl.Size = new System.Drawing.Size(184, 23);
            this.gotoregislbl.TabIndex = 6;
            this.gotoregislbl.Text = "Click here to Register";
            this.gotoregislbl.Click += new System.EventHandler(this.gotoregislbl_Click);
            // 
            // lblerrorEmail
            // 
            this.lblerrorEmail.AutoSize = true;
            this.lblerrorEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorEmail.ForeColor = System.Drawing.Color.IndianRed;
            this.lblerrorEmail.Location = new System.Drawing.Point(174, 226);
            this.lblerrorEmail.Name = "lblerrorEmail";
            this.lblerrorEmail.Size = new System.Drawing.Size(115, 19);
            this.lblerrorEmail.TabIndex = 7;
            this.lblerrorEmail.Text = "labelemailerror";
            this.lblerrorEmail.Visible = false;
            this.lblerrorEmail.Click += new System.EventHandler(this.lblerrorEmail_Click);
            // 
            // lblerrorpass
            // 
            this.lblerrorpass.AutoSize = true;
            this.lblerrorpass.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorpass.ForeColor = System.Drawing.Color.IndianRed;
            this.lblerrorpass.Location = new System.Drawing.Point(174, 298);
            this.lblerrorpass.Name = "lblerrorpass";
            this.lblerrorpass.Size = new System.Drawing.Size(108, 19);
            this.lblerrorpass.TabIndex = 8;
            this.lblerrorpass.Text = "labelpasserror";
            this.lblerrorpass.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 469);
            this.Controls.Add(this.lblerrorpass);
            this.Controls.Add(this.lblerrorEmail);
            this.Controls.Add(this.gotoregislbl);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.unemtxt);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.unemlbl);
            this.Controls.Add(this.Thelibrarytitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Thelibrarytitle;
        private System.Windows.Forms.Label unemlbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.TextBox unemtxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label gotoregislbl;
        private System.Windows.Forms.Label lblerrorEmail;
        private System.Windows.Forms.Label lblerrorpass;
    }
}

