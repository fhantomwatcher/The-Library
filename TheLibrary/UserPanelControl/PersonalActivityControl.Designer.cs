namespace TheLibrary.UserPanelControl
{
    partial class PersonalActivityControl
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
            this.DgvActivityLogs = new System.Windows.Forms.DataGridView();
            this.lblSearchActivity = new System.Windows.Forms.Label();
            this.txtSearchActivity = new System.Windows.Forms.TextBox();
            this.btnSearchActivity = new System.Windows.Forms.Button();
            this.btnRefreshActivity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActivityLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvActivityLogs
            // 
            this.DgvActivityLogs.AllowUserToAddRows = false;
            this.DgvActivityLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvActivityLogs.Location = new System.Drawing.Point(151, 78);
            this.DgvActivityLogs.MultiSelect = false;
            this.DgvActivityLogs.Name = "DgvActivityLogs";
            this.DgvActivityLogs.ReadOnly = true;
            this.DgvActivityLogs.RowHeadersWidth = 51;
            this.DgvActivityLogs.RowTemplate.Height = 24;
            this.DgvActivityLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvActivityLogs.Size = new System.Drawing.Size(473, 295);
            this.DgvActivityLogs.TabIndex = 0;
            // 
            // lblSearchActivity
            // 
            this.lblSearchActivity.AutoSize = true;
            this.lblSearchActivity.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchActivity.Location = new System.Drawing.Point(146, 37);
            this.lblSearchActivity.Name = "lblSearchActivity";
            this.lblSearchActivity.Size = new System.Drawing.Size(112, 19);
            this.lblSearchActivity.TabIndex = 1;
            this.lblSearchActivity.Text = "SearchActivity :";
            // 
            // txtSearchActivity
            // 
            this.txtSearchActivity.Location = new System.Drawing.Point(264, 35);
            this.txtSearchActivity.Name = "txtSearchActivity";
            this.txtSearchActivity.Size = new System.Drawing.Size(184, 22);
            this.txtSearchActivity.TabIndex = 2;
            // 
            // btnSearchActivity
            // 
            this.btnSearchActivity.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchActivity.Location = new System.Drawing.Point(455, 30);
            this.btnSearchActivity.Name = "btnSearchActivity";
            this.btnSearchActivity.Size = new System.Drawing.Size(75, 33);
            this.btnSearchActivity.TabIndex = 3;
            this.btnSearchActivity.Text = "Search";
            this.btnSearchActivity.UseVisualStyleBackColor = true;
            this.btnSearchActivity.Click += new System.EventHandler(this.btnSearchActivity_Click);
            // 
            // btnRefreshActivity
            // 
            this.btnRefreshActivity.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshActivity.Location = new System.Drawing.Point(536, 31);
            this.btnRefreshActivity.Name = "btnRefreshActivity";
            this.btnRefreshActivity.Size = new System.Drawing.Size(85, 32);
            this.btnRefreshActivity.TabIndex = 5;
            this.btnRefreshActivity.Text = "Refresh";
            this.btnRefreshActivity.UseVisualStyleBackColor = true;
            this.btnRefreshActivity.Click += new System.EventHandler(this.btnRefreshActivity_Click);
            // 
            // PersonalActivityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefreshActivity);
            this.Controls.Add(this.btnSearchActivity);
            this.Controls.Add(this.txtSearchActivity);
            this.Controls.Add(this.lblSearchActivity);
            this.Controls.Add(this.DgvActivityLogs);
            this.Name = "PersonalActivityControl";
            this.Size = new System.Drawing.Size(777, 531);
            ((System.ComponentModel.ISupportInitialize)(this.DgvActivityLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvActivityLogs;
        private System.Windows.Forms.Label lblSearchActivity;
        private System.Windows.Forms.TextBox txtSearchActivity;
        private System.Windows.Forms.Button btnSearchActivity;
        private System.Windows.Forms.Button btnRefreshActivity;
    }
}
