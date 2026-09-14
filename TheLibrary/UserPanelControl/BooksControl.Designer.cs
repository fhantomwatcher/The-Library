namespace TheLibrary.UserPanelControl
{
    partial class BooksControl
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
            this.titleBookslbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxT = new System.Windows.Forms.TextBox();
            this.Searchtitlelbl = new System.Windows.Forms.Label();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.ManageBookCopyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBookslbl
            // 
            this.titleBookslbl.AutoSize = true;
            this.titleBookslbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBookslbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.titleBookslbl.Location = new System.Drawing.Point(15, 13);
            this.titleBookslbl.Name = "titleBookslbl";
            this.titleBookslbl.Size = new System.Drawing.Size(141, 33);
            this.titleBookslbl.TabIndex = 0;
            this.titleBookslbl.Text = "Books List";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.SearchBtn.Location = new System.Drawing.Point(493, 22);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 25);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTxT
            // 
            this.SearchTxT.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxT.Location = new System.Drawing.Point(305, 20);
            this.SearchTxT.Name = "SearchTxT";
            this.SearchTxT.Size = new System.Drawing.Size(168, 27);
            this.SearchTxT.TabIndex = 5;
            // 
            // Searchtitlelbl
            // 
            this.Searchtitlelbl.AutoSize = true;
            this.Searchtitlelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtitlelbl.Location = new System.Drawing.Point(230, 22);
            this.Searchtitlelbl.Name = "Searchtitlelbl";
            this.Searchtitlelbl.Size = new System.Drawing.Size(68, 19);
            this.Searchtitlelbl.TabIndex = 4;
            this.Searchtitlelbl.Text = "Search :";
            // 
            // DgvBooks
            // 
            this.DgvBooks.AllowUserToAddRows = false;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBooks.Location = new System.Drawing.Point(28, 60);
            this.DgvBooks.MultiSelect = false;
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.ReadOnly = true;
            this.DgvBooks.RowHeadersWidth = 51;
            this.DgvBooks.RowTemplate.Height = 24;
            this.DgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBooks.Size = new System.Drawing.Size(720, 300);
            this.DgvBooks.TabIndex = 7;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.Color.Crimson;
            this.RemoveBtn.Location = new System.Drawing.Point(582, 379);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(126, 35);
            this.RemoveBtn.TabIndex = 10;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.EditBtn.Location = new System.Drawing.Point(234, 379);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(126, 35);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.AddBookBtn.Location = new System.Drawing.Point(78, 379);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(126, 35);
            this.AddBookBtn.TabIndex = 8;
            this.AddBookBtn.Text = "Add Book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // ManageBookCopyBtn
            // 
            this.ManageBookCopyBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBookCopyBtn.ForeColor = System.Drawing.Color.Indigo;
            this.ManageBookCopyBtn.Location = new System.Drawing.Point(399, 379);
            this.ManageBookCopyBtn.Name = "ManageBookCopyBtn";
            this.ManageBookCopyBtn.Size = new System.Drawing.Size(126, 35);
            this.ManageBookCopyBtn.TabIndex = 11;
            this.ManageBookCopyBtn.Text = "Manage";
            this.ManageBookCopyBtn.UseVisualStyleBackColor = true;
            // 
            // BooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ManageBookCopyBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.DgvBooks);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxT);
            this.Controls.Add(this.Searchtitlelbl);
            this.Controls.Add(this.titleBookslbl);
            this.Name = "BooksControl";
            this.Size = new System.Drawing.Size(777, 531);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleBookslbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTxT;
        private System.Windows.Forms.Label Searchtitlelbl;
        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Button ManageBookCopyBtn;
    }
}
