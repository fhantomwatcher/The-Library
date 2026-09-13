namespace TheLibrary.Forms
{
    partial class DeleteStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStaffForm));
            this.searchstafflbl = new System.Windows.Forms.Label();
            this.searchboxtxt = new System.Windows.Forms.TextBox();
            this.searchbtndsf = new System.Windows.Forms.Button();
            this.deletedgv = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deletedgv)).BeginInit();
            this.SuspendLayout();
            // 
            // searchstafflbl
            // 
            this.searchstafflbl.AutoSize = true;
            this.searchstafflbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchstafflbl.Location = new System.Drawing.Point(11, 13);
            this.searchstafflbl.Name = "searchstafflbl";
            this.searchstafflbl.Size = new System.Drawing.Size(97, 19);
            this.searchstafflbl.TabIndex = 0;
            this.searchstafflbl.Text = "Serach Staff :";
            // 
            // searchboxtxt
            // 
            this.searchboxtxt.Location = new System.Drawing.Point(114, 13);
            this.searchboxtxt.Name = "searchboxtxt";
            this.searchboxtxt.Size = new System.Drawing.Size(203, 22);
            this.searchboxtxt.TabIndex = 1;
            // 
            // searchbtndsf
            // 
            this.searchbtndsf.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtndsf.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.searchbtndsf.Location = new System.Drawing.Point(323, 12);
            this.searchbtndsf.Name = "searchbtndsf";
            this.searchbtndsf.Size = new System.Drawing.Size(75, 23);
            this.searchbtndsf.TabIndex = 2;
            this.searchbtndsf.Text = "Search";
            this.searchbtndsf.UseVisualStyleBackColor = true;
            this.searchbtndsf.Click += new System.EventHandler(this.searchbtndsf_Click);
            // 
            // deletedgv
            // 
            this.deletedgv.AllowUserToAddRows = false;
            this.deletedgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletedgv.Location = new System.Drawing.Point(30, 57);
            this.deletedgv.MultiSelect = false;
            this.deletedgv.Name = "deletedgv";
            this.deletedgv.ReadOnly = true;
            this.deletedgv.RowHeadersWidth = 51;
            this.deletedgv.RowTemplate.Height = 24;
            this.deletedgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deletedgv.Size = new System.Drawing.Size(587, 177);
            this.deletedgv.TabIndex = 3;
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.Crimson;
            this.deletebtn.Location = new System.Drawing.Point(195, 272);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 26);
            this.deletebtn.TabIndex = 4;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.Purple;
            this.cancelbtn.Location = new System.Drawing.Point(347, 271);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 26);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // DeleteStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 331);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.deletedgv);
            this.Controls.Add(this.searchbtndsf);
            this.Controls.Add(this.searchboxtxt);
            this.Controls.Add(this.searchstafflbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Staff";
            ((System.ComponentModel.ISupportInitialize)(this.deletedgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchstafflbl;
        private System.Windows.Forms.TextBox searchboxtxt;
        private System.Windows.Forms.Button searchbtndsf;
        private System.Windows.Forms.DataGridView deletedgv;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}