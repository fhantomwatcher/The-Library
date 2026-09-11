namespace TheLibrary.UserPanelControl
{
    partial class DashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashtitlelbl01 = new System.Windows.Forms.Label();
            this.dashtitlelbl02 = new System.Windows.Forms.Label();
            this.dashtitleuslbl03 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dashtitlelbl01
            // 
            this.dashtitlelbl01.AutoSize = true;
            this.dashtitlelbl01.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashtitlelbl01.Location = new System.Drawing.Point(27, 24);
            this.dashtitlelbl01.Name = "dashtitlelbl01";
            this.dashtitlelbl01.Size = new System.Drawing.Size(172, 33);
            this.dashtitlelbl01.TabIndex = 0;
            this.dashtitlelbl01.Text = "Welcome To";
            // 
            // dashtitlelbl02
            // 
            this.dashtitlelbl02.AutoSize = true;
            this.dashtitlelbl02.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashtitlelbl02.Location = new System.Drawing.Point(27, 53);
            this.dashtitlelbl02.Name = "dashtitlelbl02";
            this.dashtitlelbl02.Size = new System.Drawing.Size(206, 33);
            this.dashtitlelbl02.TabIndex = 1;
            this.dashtitlelbl02.Text = "The Dashboard";
            // 
            // dashtitleuslbl03
            // 
            this.dashtitleuslbl03.AutoSize = true;
            this.dashtitleuslbl03.BackColor = System.Drawing.Color.Transparent;
            this.dashtitleuslbl03.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashtitleuslbl03.ForeColor = System.Drawing.Color.DarkCyan;
            this.dashtitleuslbl03.Location = new System.Drawing.Point(28, 83);
            this.dashtitleuslbl03.Name = "dashtitleuslbl03";
            this.dashtitleuslbl03.Size = new System.Drawing.Size(97, 45);
            this.dashtitleuslbl03.TabIndex = 2;
            this.dashtitleuslbl03.Text = "User";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dashtitleuslbl03);
            this.Controls.Add(this.dashtitlelbl02);
            this.Controls.Add(this.dashtitlelbl01);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(777, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashtitlelbl01;
        private System.Windows.Forms.Label dashtitlelbl02;
        private System.Windows.Forms.Label dashtitleuslbl03;
    }
}
