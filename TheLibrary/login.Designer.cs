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
            this.unlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.untxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.gotoregislbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Thelibrarytitle
            // 
            this.Thelibrarytitle.AutoSize = true;
            this.Thelibrarytitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thelibrarytitle.Location = new System.Drawing.Point(161, 40);
            this.Thelibrarytitle.Name = "Thelibrarytitle";
            this.Thelibrarytitle.Size = new System.Drawing.Size(137, 31);
            this.Thelibrarytitle.TabIndex = 0;
            this.Thelibrarytitle.Text = "TheLibrary";
            // 
            // unlbl
            // 
            this.unlbl.AutoSize = true;
            this.unlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlbl.Location = new System.Drawing.Point(51, 166);
            this.unlbl.Name = "unlbl";
            this.unlbl.Size = new System.Drawing.Size(96, 24);
            this.unlbl.TabIndex = 1;
            this.unlbl.Text = "Username";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(51, 220);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(94, 24);
            this.passlbl.TabIndex = 2;
            this.passlbl.Text = "PassWord";
            // 
            // untxt
            // 
            this.untxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.untxt.Location = new System.Drawing.Point(167, 165);
            this.untxt.Name = "untxt";
            this.untxt.Size = new System.Drawing.Size(219, 29);
            this.untxt.TabIndex = 3;
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(167, 218);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(219, 29);
            this.passtxt.TabIndex = 4;
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.loginbtn.Location = new System.Drawing.Point(167, 310);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(117, 33);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // gotoregislbl
            // 
            this.gotoregislbl.AutoSize = true;
            this.gotoregislbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoregislbl.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.gotoregislbl.Location = new System.Drawing.Point(128, 263);
            this.gotoregislbl.Name = "gotoregislbl";
            this.gotoregislbl.Size = new System.Drawing.Size(184, 23);
            this.gotoregislbl.TabIndex = 6;
            this.gotoregislbl.Text = "Click here to Register";
            this.gotoregislbl.Click += new System.EventHandler(this.gotoregislbl_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 469);
            this.Controls.Add(this.gotoregislbl);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.untxt);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.unlbl);
            this.Controls.Add(this.Thelibrarytitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Thelibrarytitle;
        private System.Windows.Forms.Label unlbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.TextBox untxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label gotoregislbl;
    }
}

