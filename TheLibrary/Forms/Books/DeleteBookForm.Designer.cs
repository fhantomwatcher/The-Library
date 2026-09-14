namespace TheLibrary.Forms.Books
{
    partial class DeleteBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBookForm));
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.DeleteBookdgv = new System.Windows.Forms.DataGridView();
            this.searchbtndsf = new System.Windows.Forms.Button();
            this.searchboxtxt = new System.Windows.Forms.TextBox();
            this.searchBooklbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBookdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.ForeColor = System.Drawing.Color.Purple;
            this.Cancelbtn.Location = new System.Drawing.Point(423, 269);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 26);
            this.Cancelbtn.TabIndex = 14;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.Crimson;
            this.Deletebtn.Location = new System.Drawing.Point(271, 270);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 26);
            this.Deletebtn.TabIndex = 13;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // DeleteBookdgv
            // 
            this.DeleteBookdgv.AllowUserToAddRows = false;
            this.DeleteBookdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteBookdgv.Location = new System.Drawing.Point(54, 63);
            this.DeleteBookdgv.MultiSelect = false;
            this.DeleteBookdgv.Name = "DeleteBookdgv";
            this.DeleteBookdgv.ReadOnly = true;
            this.DeleteBookdgv.RowHeadersWidth = 51;
            this.DeleteBookdgv.RowTemplate.Height = 24;
            this.DeleteBookdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeleteBookdgv.Size = new System.Drawing.Size(693, 177);
            this.DeleteBookdgv.TabIndex = 12;
            // 
            // searchbtndsf
            // 
            this.searchbtndsf.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtndsf.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.searchbtndsf.Location = new System.Drawing.Point(527, 16);
            this.searchbtndsf.Name = "searchbtndsf";
            this.searchbtndsf.Size = new System.Drawing.Size(75, 28);
            this.searchbtndsf.TabIndex = 11;
            this.searchbtndsf.Text = "Search";
            this.searchbtndsf.UseVisualStyleBackColor = true;
            this.searchbtndsf.Click += new System.EventHandler(this.searchbtndsf_Click);
            // 
            // searchboxtxt
            // 
            this.searchboxtxt.Location = new System.Drawing.Point(318, 18);
            this.searchboxtxt.Name = "searchboxtxt";
            this.searchboxtxt.Size = new System.Drawing.Size(203, 22);
            this.searchboxtxt.TabIndex = 10;
            // 
            // searchBooklbl
            // 
            this.searchBooklbl.AutoSize = true;
            this.searchBooklbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBooklbl.Location = new System.Drawing.Point(189, 21);
            this.searchBooklbl.Name = "searchBooklbl";
            this.searchBooklbl.Size = new System.Drawing.Size(119, 19);
            this.searchBooklbl.TabIndex = 9;
            this.searchBooklbl.Text = "Serach Book ID :";
            // 
            // DeleteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.DeleteBookdgv);
            this.Controls.Add(this.searchbtndsf);
            this.Controls.Add(this.searchboxtxt);
            this.Controls.Add(this.searchBooklbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Book";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBookdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.DataGridView DeleteBookdgv;
        private System.Windows.Forms.Button searchbtndsf;
        private System.Windows.Forms.TextBox searchboxtxt;
        private System.Windows.Forms.Label searchBooklbl;
    }
}