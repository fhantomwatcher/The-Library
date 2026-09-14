
namespace TheLibrary
{
    partial class LibrarianDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssueReturn = new System.Windows.Forms.Button();
            this.btnManageMember = new System.Windows.Forms.Button();
            this.btnFines = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(283, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIssueReturn
            // 
            this.btnIssueReturn.BackColor = System.Drawing.SystemColors.Info;
            this.btnIssueReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReturn.Location = new System.Drawing.Point(89, 103);
            this.btnIssueReturn.Name = "btnIssueReturn";
            this.btnIssueReturn.Size = new System.Drawing.Size(207, 39);
            this.btnIssueReturn.TabIndex = 1;
            this.btnIssueReturn.Text = "ISSUE/RETURN BOOK";
            this.btnIssueReturn.UseVisualStyleBackColor = false;
            this.btnIssueReturn.Click += new System.EventHandler(this.btnIssueReturn_Click);
            // 
            // btnManageMember
            // 
            this.btnManageMember.BackColor = System.Drawing.SystemColors.Info;
            this.btnManageMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMember.Location = new System.Drawing.Point(89, 169);
            this.btnManageMember.Name = "btnManageMember";
            this.btnManageMember.Size = new System.Drawing.Size(207, 39);
            this.btnManageMember.TabIndex = 2;
            this.btnManageMember.Text = "MANAGE MEMBERS";
            this.btnManageMember.UseVisualStyleBackColor = false;
            this.btnManageMember.Click += new System.EventHandler(this.btnManageMember_Click);
            // 
            // btnFines
            // 
            this.btnFines.BackColor = System.Drawing.SystemColors.Info;
            this.btnFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFines.Location = new System.Drawing.Point(89, 231);
            this.btnFines.Name = "btnFines";
            this.btnFines.Size = new System.Drawing.Size(207, 40);
            this.btnFines.TabIndex = 3;
            this.btnFines.Text = "FINES";
            this.btnFines.UseVisualStyleBackColor = false;
            this.btnFines.Click += new System.EventHandler(this.btnFines_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.SystemColors.Info;
            this.btnReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.Location = new System.Drawing.Point(89, 309);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(207, 39);
            this.btnReservations.TabIndex = 4;
            this.btnReservations.Text = "RESERVATIONS";
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // LibrarianDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnFines);
            this.Controls.Add(this.btnManageMember);
            this.Controls.Add(this.btnIssueReturn);
            this.Controls.Add(this.label1);
            this.Name = "LibrarianDashboard";
            this.Text = "LibrarianDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIssueReturn;
        private System.Windows.Forms.Button btnManageMember;
        private System.Windows.Forms.Button btnFines;
        private System.Windows.Forms.Button btnReservations;
    }
}