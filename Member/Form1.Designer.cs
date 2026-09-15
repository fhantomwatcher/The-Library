namespace Member_data
{
    partial class Form1
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
            this.btnbooks = new System.Windows.Forms.Button();
            this.btnloans = new System.Windows.Forms.Button();
            this.btnfines = new System.Windows.Forms.Button();
            this.btnreserve = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnbooks
            // 
            this.btnbooks.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooks.Location = new System.Drawing.Point(12, 76);
            this.btnbooks.Name = "btnbooks";
            this.btnbooks.Size = new System.Drawing.Size(213, 34);
            this.btnbooks.TabIndex = 1;
            this.btnbooks.Text = "Browse Books";
            this.btnbooks.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnbooks.UseVisualStyleBackColor = true;
            this.btnbooks.Click += new System.EventHandler(this.btnbooks_Click);
            // 
            // btnloans
            // 
            this.btnloans.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloans.Location = new System.Drawing.Point(12, 128);
            this.btnloans.Name = "btnloans";
            this.btnloans.Size = new System.Drawing.Size(213, 35);
            this.btnloans.TabIndex = 2;
            this.btnloans.Text = "My borrowed Books";
            this.btnloans.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnloans.UseVisualStyleBackColor = true;
            this.btnloans.Click += new System.EventHandler(this.btnloans_Click);
            // 
            // btnfines
            // 
            this.btnfines.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfines.Location = new System.Drawing.Point(12, 180);
            this.btnfines.Name = "btnfines";
            this.btnfines.Size = new System.Drawing.Size(213, 32);
            this.btnfines.TabIndex = 3;
            this.btnfines.Text = "My Fines";
            this.btnfines.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnfines.UseVisualStyleBackColor = true;
            this.btnfines.Click += new System.EventHandler(this.btnfines_Click);
            // 
            // btnreserve
            // 
            this.btnreserve.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreserve.Location = new System.Drawing.Point(12, 233);
            this.btnreserve.Name = "btnreserve";
            this.btnreserve.Size = new System.Drawing.Size(213, 39);
            this.btnreserve.TabIndex = 4;
            this.btnreserve.Text = "Reservations ";
            this.btnreserve.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnreserve.UseVisualStyleBackColor = true;
            this.btnreserve.Click += new System.EventHandler(this.btnreserve_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(302, 322);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(123, 49);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnreserve);
            this.Controls.Add(this.btnfines);
            this.Controls.Add(this.btnloans);
            this.Controls.Add(this.btnbooks);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbooks;
        private System.Windows.Forms.Button btnloans;
        private System.Windows.Forms.Button btnfines;
        private System.Windows.Forms.Button btnreserve;
        private System.Windows.Forms.Button btnlogout;
    }
}

