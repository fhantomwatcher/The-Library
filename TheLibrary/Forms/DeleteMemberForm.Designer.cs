namespace TheLibrary.Forms
{
    partial class DeleteMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMemberForm));
            this.searchbtndsf = new System.Windows.Forms.Button();
            this.searchboxtxt = new System.Windows.Forms.TextBox();
            this.searchMemberlbl = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.DeleteMemberdgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteMemberdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbtndsf
            // 
            this.searchbtndsf.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtndsf.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.searchbtndsf.Location = new System.Drawing.Point(530, 19);
            this.searchbtndsf.Name = "searchbtndsf";
            this.searchbtndsf.Size = new System.Drawing.Size(75, 23);
            this.searchbtndsf.TabIndex = 5;
            this.searchbtndsf.Text = "Search";
            this.searchbtndsf.UseVisualStyleBackColor = true;
            this.searchbtndsf.Click += new System.EventHandler(this.searchbtndsf_Click);
            // 
            // searchboxtxt
            // 
            this.searchboxtxt.Location = new System.Drawing.Point(319, 20);
            this.searchboxtxt.Name = "searchboxtxt";
            this.searchboxtxt.Size = new System.Drawing.Size(203, 22);
            this.searchboxtxt.TabIndex = 4;
            // 
            // searchMemberlbl
            // 
            this.searchMemberlbl.AutoSize = true;
            this.searchMemberlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberlbl.Location = new System.Drawing.Point(190, 23);
            this.searchMemberlbl.Name = "searchMemberlbl";
            this.searchMemberlbl.Size = new System.Drawing.Size(123, 19);
            this.searchMemberlbl.TabIndex = 3;
            this.searchMemberlbl.Text = "Serach Member :";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.Purple;
            this.cancelbtn.Location = new System.Drawing.Point(424, 271);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 26);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.Crimson;
            this.deletebtn.Location = new System.Drawing.Point(272, 272);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 26);
            this.deletebtn.TabIndex = 7;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // DeleteMemberdgv
            // 
            this.DeleteMemberdgv.AllowUserToAddRows = false;
            this.DeleteMemberdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteMemberdgv.Location = new System.Drawing.Point(55, 65);
            this.DeleteMemberdgv.MultiSelect = false;
            this.DeleteMemberdgv.Name = "DeleteMemberdgv";
            this.DeleteMemberdgv.ReadOnly = true;
            this.DeleteMemberdgv.RowHeadersWidth = 51;
            this.DeleteMemberdgv.RowTemplate.Height = 24;
            this.DeleteMemberdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeleteMemberdgv.Size = new System.Drawing.Size(693, 177);
            this.DeleteMemberdgv.TabIndex = 6;
            // 
            // DeleteMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 329);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.DeleteMemberdgv);
            this.Controls.Add(this.searchbtndsf);
            this.Controls.Add(this.searchboxtxt);
            this.Controls.Add(this.searchMemberlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteMemberForm";
            this.Text = "Delete Member";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteMemberdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbtndsf;
        private System.Windows.Forms.TextBox searchboxtxt;
        private System.Windows.Forms.Label searchMemberlbl;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridView DeleteMemberdgv;
    }
}