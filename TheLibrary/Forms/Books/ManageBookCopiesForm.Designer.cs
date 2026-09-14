namespace TheLibrary.Forms.Books
{
    partial class ManageBookCopiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBookCopiesForm));
            this.SearchBooklbl = new System.Windows.Forms.Label();
            this.SearchBookTxT = new System.Windows.Forms.TextBox();
            this.SearchBookbtn = new System.Windows.Forms.Button();
            this.BooKListDGV = new System.Windows.Forms.DataGridView();
            this.SelectedBooklbl = new System.Windows.Forms.Label();
            this.BookIDlbl = new System.Windows.Forms.Label();
            this.CopyBookDGV = new System.Windows.Forms.DataGridView();
            this.TitleAvailCopylbl = new System.Windows.Forms.Label();
            this.ADDCopybtn = new System.Windows.Forms.Button();
            this.EditCopybtn = new System.Windows.Forms.Button();
            this.RemoveCopybtn = new System.Windows.Forms.Button();
            this.CloseMBbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BooKListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyBookDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBooklbl
            // 
            this.SearchBooklbl.AutoSize = true;
            this.SearchBooklbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBooklbl.Location = new System.Drawing.Point(51, 13);
            this.SearchBooklbl.Name = "SearchBooklbl";
            this.SearchBooklbl.Size = new System.Drawing.Size(101, 19);
            this.SearchBooklbl.TabIndex = 0;
            this.SearchBooklbl.Text = "Search Book :";
            // 
            // SearchBookTxT
            // 
            this.SearchBookTxT.Location = new System.Drawing.Point(159, 13);
            this.SearchBookTxT.Name = "SearchBookTxT";
            this.SearchBookTxT.Size = new System.Drawing.Size(183, 22);
            this.SearchBookTxT.TabIndex = 1;
            // 
            // SearchBookbtn
            // 
            this.SearchBookbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBookbtn.Location = new System.Drawing.Point(348, 12);
            this.SearchBookbtn.Name = "SearchBookbtn";
            this.SearchBookbtn.Size = new System.Drawing.Size(75, 29);
            this.SearchBookbtn.TabIndex = 2;
            this.SearchBookbtn.Text = "Search";
            this.SearchBookbtn.UseVisualStyleBackColor = true;
            this.SearchBookbtn.Click += new System.EventHandler(this.SearchBookbtn_Click);
            // 
            // BooKListDGV
            // 
            this.BooKListDGV.AllowUserToAddRows = false;
            this.BooKListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooKListDGV.Location = new System.Drawing.Point(31, 50);
            this.BooKListDGV.MultiSelect = false;
            this.BooKListDGV.Name = "BooKListDGV";
            this.BooKListDGV.ReadOnly = true;
            this.BooKListDGV.RowHeadersWidth = 51;
            this.BooKListDGV.RowTemplate.Height = 24;
            this.BooKListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooKListDGV.Size = new System.Drawing.Size(444, 365);
            this.BooKListDGV.TabIndex = 3;
            this.BooKListDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooKListDGV_CellClick);
            // 
            // SelectedBooklbl
            // 
            this.SelectedBooklbl.AutoSize = true;
            this.SelectedBooklbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedBooklbl.Location = new System.Drawing.Point(526, 17);
            this.SelectedBooklbl.Name = "SelectedBooklbl";
            this.SelectedBooklbl.Size = new System.Drawing.Size(113, 19);
            this.SelectedBooklbl.TabIndex = 4;
            this.SelectedBooklbl.Text = "Selected Book :";
            // 
            // BookIDlbl
            // 
            this.BookIDlbl.AutoSize = true;
            this.BookIDlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDlbl.Location = new System.Drawing.Point(569, 44);
            this.BookIDlbl.Name = "BookIDlbl";
            this.BookIDlbl.Size = new System.Drawing.Size(70, 19);
            this.BookIDlbl.TabIndex = 6;
            this.BookIDlbl.Text = "Book ID :";
            // 
            // CopyBookDGV
            // 
            this.CopyBookDGV.AllowUserToAddRows = false;
            this.CopyBookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CopyBookDGV.Location = new System.Drawing.Point(530, 101);
            this.CopyBookDGV.MultiSelect = false;
            this.CopyBookDGV.Name = "CopyBookDGV";
            this.CopyBookDGV.ReadOnly = true;
            this.CopyBookDGV.RowHeadersWidth = 51;
            this.CopyBookDGV.RowTemplate.Height = 24;
            this.CopyBookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CopyBookDGV.Size = new System.Drawing.Size(402, 314);
            this.CopyBookDGV.TabIndex = 8;
            // 
            // TitleAvailCopylbl
            // 
            this.TitleAvailCopylbl.AutoSize = true;
            this.TitleAvailCopylbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleAvailCopylbl.Location = new System.Drawing.Point(526, 78);
            this.TitleAvailCopylbl.Name = "TitleAvailCopylbl";
            this.TitleAvailCopylbl.Size = new System.Drawing.Size(129, 19);
            this.TitleAvailCopylbl.TabIndex = 9;
            this.TitleAvailCopylbl.Text = "Available Copies :";
            // 
            // ADDCopybtn
            // 
            this.ADDCopybtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDCopybtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ADDCopybtn.Location = new System.Drawing.Point(991, 50);
            this.ADDCopybtn.Name = "ADDCopybtn";
            this.ADDCopybtn.Size = new System.Drawing.Size(107, 29);
            this.ADDCopybtn.TabIndex = 10;
            this.ADDCopybtn.Text = "Add Copy";
            this.ADDCopybtn.UseVisualStyleBackColor = true;
            this.ADDCopybtn.Click += new System.EventHandler(this.ADDCopybtn_Click);
            // 
            // EditCopybtn
            // 
            this.EditCopybtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCopybtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.EditCopybtn.Location = new System.Drawing.Point(991, 91);
            this.EditCopybtn.Name = "EditCopybtn";
            this.EditCopybtn.Size = new System.Drawing.Size(107, 29);
            this.EditCopybtn.TabIndex = 11;
            this.EditCopybtn.Text = "Edit";
            this.EditCopybtn.UseVisualStyleBackColor = true;
            this.EditCopybtn.Click += new System.EventHandler(this.EditCopybtn_Click);
            // 
            // RemoveCopybtn
            // 
            this.RemoveCopybtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCopybtn.ForeColor = System.Drawing.Color.Crimson;
            this.RemoveCopybtn.Location = new System.Drawing.Point(991, 135);
            this.RemoveCopybtn.Name = "RemoveCopybtn";
            this.RemoveCopybtn.Size = new System.Drawing.Size(107, 29);
            this.RemoveCopybtn.TabIndex = 12;
            this.RemoveCopybtn.Text = "Remove";
            this.RemoveCopybtn.UseVisualStyleBackColor = true;
            this.RemoveCopybtn.Click += new System.EventHandler(this.RemoveCopybtn_Click);
            // 
            // CloseMBbtn
            // 
            this.CloseMBbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseMBbtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.CloseMBbtn.Location = new System.Drawing.Point(991, 178);
            this.CloseMBbtn.Name = "CloseMBbtn";
            this.CloseMBbtn.Size = new System.Drawing.Size(107, 29);
            this.CloseMBbtn.TabIndex = 13;
            this.CloseMBbtn.Text = "Close";
            this.CloseMBbtn.UseVisualStyleBackColor = true;
            this.CloseMBbtn.Click += new System.EventHandler(this.CloseMBbtn_Click);
            // 
            // ManageBookCopiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 450);
            this.Controls.Add(this.CloseMBbtn);
            this.Controls.Add(this.RemoveCopybtn);
            this.Controls.Add(this.EditCopybtn);
            this.Controls.Add(this.ADDCopybtn);
            this.Controls.Add(this.TitleAvailCopylbl);
            this.Controls.Add(this.CopyBookDGV);
            this.Controls.Add(this.BookIDlbl);
            this.Controls.Add(this.SelectedBooklbl);
            this.Controls.Add(this.BooKListDGV);
            this.Controls.Add(this.SearchBookbtn);
            this.Controls.Add(this.SearchBookTxT);
            this.Controls.Add(this.SearchBooklbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageBookCopiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Book Copies";
            ((System.ComponentModel.ISupportInitialize)(this.BooKListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyBookDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchBooklbl;
        private System.Windows.Forms.TextBox SearchBookTxT;
        private System.Windows.Forms.Button SearchBookbtn;
        private System.Windows.Forms.DataGridView BooKListDGV;
        private System.Windows.Forms.Label SelectedBooklbl;
        private System.Windows.Forms.Label BookIDlbl;
        private System.Windows.Forms.DataGridView CopyBookDGV;
        private System.Windows.Forms.Label TitleAvailCopylbl;
        private System.Windows.Forms.Button ADDCopybtn;
        private System.Windows.Forms.Button EditCopybtn;
        private System.Windows.Forms.Button RemoveCopybtn;
        private System.Windows.Forms.Button CloseMBbtn;
    }
}