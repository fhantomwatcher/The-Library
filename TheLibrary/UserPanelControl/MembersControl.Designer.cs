namespace TheLibrary.UserPanelControl
{
    partial class MembersControl
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
            this.Membertitlelbl = new System.Windows.Forms.Label();
            this.Searchtitlelbl = new System.Windows.Forms.Label();
            this.SearchTxT = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AddMemberBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.MemberlistDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MemberlistDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Membertitlelbl
            // 
            this.Membertitlelbl.AutoSize = true;
            this.Membertitlelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Membertitlelbl.Location = new System.Drawing.Point(282, 12);
            this.Membertitlelbl.Name = "Membertitlelbl";
            this.Membertitlelbl.Size = new System.Drawing.Size(174, 33);
            this.Membertitlelbl.TabIndex = 0;
            this.Membertitlelbl.Text = "Member List";
            // 
            // Searchtitlelbl
            // 
            this.Searchtitlelbl.AutoSize = true;
            this.Searchtitlelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtitlelbl.Location = new System.Drawing.Point(42, 77);
            this.Searchtitlelbl.Name = "Searchtitlelbl";
            this.Searchtitlelbl.Size = new System.Drawing.Size(68, 19);
            this.Searchtitlelbl.TabIndex = 1;
            this.Searchtitlelbl.Text = "Search :";
            // 
            // SearchTxT
            // 
            this.SearchTxT.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxT.Location = new System.Drawing.Point(117, 75);
            this.SearchTxT.Name = "SearchTxT";
            this.SearchTxT.Size = new System.Drawing.Size(168, 27);
            this.SearchTxT.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.SearchBtn.Location = new System.Drawing.Point(305, 77);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 25);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddMemberBtn
            // 
            this.AddMemberBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.AddMemberBtn.Location = new System.Drawing.Point(631, 17);
            this.AddMemberBtn.Name = "AddMemberBtn";
            this.AddMemberBtn.Size = new System.Drawing.Size(126, 31);
            this.AddMemberBtn.TabIndex = 4;
            this.AddMemberBtn.Text = "Add member";
            this.AddMemberBtn.UseVisualStyleBackColor = true;
            this.AddMemberBtn.Click += new System.EventHandler(this.AddMemberBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.EditBtn.Location = new System.Drawing.Point(631, 54);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(126, 31);
            this.EditBtn.TabIndex = 5;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.Color.Crimson;
            this.RemoveBtn.Location = new System.Drawing.Point(631, 91);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(126, 31);
            this.RemoveBtn.TabIndex = 6;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // MemberlistDGV
            // 
            this.MemberlistDGV.AllowUserToAddRows = false;
            this.MemberlistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberlistDGV.Location = new System.Drawing.Point(23, 145);
            this.MemberlistDGV.MultiSelect = false;
            this.MemberlistDGV.Name = "MemberlistDGV";
            this.MemberlistDGV.ReadOnly = true;
            this.MemberlistDGV.RowHeadersWidth = 51;
            this.MemberlistDGV.RowTemplate.Height = 24;
            this.MemberlistDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberlistDGV.Size = new System.Drawing.Size(734, 276);
            this.MemberlistDGV.TabIndex = 7;
            // 
            // MembersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MemberlistDGV);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddMemberBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxT);
            this.Controls.Add(this.Searchtitlelbl);
            this.Controls.Add(this.Membertitlelbl);
            this.Name = "MembersControl";
            this.Size = new System.Drawing.Size(777, 531);
            ((System.ComponentModel.ISupportInitialize)(this.MemberlistDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Membertitlelbl;
        private System.Windows.Forms.Label Searchtitlelbl;
        private System.Windows.Forms.TextBox SearchTxT;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button AddMemberBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.DataGridView MemberlistDGV;
    }
}
