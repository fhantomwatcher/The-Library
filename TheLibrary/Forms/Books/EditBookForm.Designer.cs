namespace TheLibrary.Forms
{
    partial class EditBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBookForm));
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxT = new System.Windows.Forms.TextBox();
            this.Searchtitlelbl = new System.Windows.Forms.Label();
            this.DGVEidtBook = new System.Windows.Forms.DataGridView();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.ShelfLocationTxT = new System.Windows.Forms.TextBox();
            this.ShelfLoclbl = new System.Windows.Forms.Label();
            this.PublishYearPick = new System.Windows.Forms.DateTimePicker();
            this.PublishYearlbl = new System.Windows.Forms.Label();
            this.Publishertxt = new System.Windows.Forms.TextBox();
            this.Publisherlbl = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.Categorylbl = new System.Windows.Forms.Label();
            this.ISBNtxt = new System.Windows.Forms.TextBox();
            this.ISBNlbl = new System.Windows.Forms.Label();
            this.AuthorTxT = new System.Windows.Forms.TextBox();
            this.Authorlbl = new System.Windows.Forms.Label();
            this.TitleTxT = new System.Windows.Forms.TextBox();
            this.TITLElbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEidtBook)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.SearchBtn.Location = new System.Drawing.Point(283, 20);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 25);
            this.SearchBtn.TabIndex = 9;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTxT
            // 
            this.SearchTxT.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxT.Location = new System.Drawing.Point(95, 18);
            this.SearchTxT.Name = "SearchTxT";
            this.SearchTxT.Size = new System.Drawing.Size(168, 27);
            this.SearchTxT.TabIndex = 8;
            // 
            // Searchtitlelbl
            // 
            this.Searchtitlelbl.AutoSize = true;
            this.Searchtitlelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtitlelbl.Location = new System.Drawing.Point(20, 20);
            this.Searchtitlelbl.Name = "Searchtitlelbl";
            this.Searchtitlelbl.Size = new System.Drawing.Size(68, 19);
            this.Searchtitlelbl.TabIndex = 7;
            this.Searchtitlelbl.Text = "Search :";
            // 
            // DGVEidtBook
            // 
            this.DGVEidtBook.AllowUserToAddRows = false;
            this.DGVEidtBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEidtBook.Location = new System.Drawing.Point(24, 58);
            this.DGVEidtBook.MultiSelect = false;
            this.DGVEidtBook.Name = "DGVEidtBook";
            this.DGVEidtBook.ReadOnly = true;
            this.DGVEidtBook.RowHeadersWidth = 51;
            this.DGVEidtBook.RowTemplate.Height = 24;
            this.DGVEidtBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVEidtBook.Size = new System.Drawing.Size(363, 380);
            this.DGVEidtBook.TabIndex = 10;
            this.DGVEidtBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEidtBook_CellClick);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Crimson;
            this.CancelBtn.Location = new System.Drawing.Point(574, 385);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(87, 31);
            this.CancelBtn.TabIndex = 32;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.Savebtn.Location = new System.Drawing.Point(574, 333);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(87, 31);
            this.Savebtn.TabIndex = 31;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // ShelfLocationTxT
            // 
            this.ShelfLocationTxT.Location = new System.Drawing.Point(551, 275);
            this.ShelfLocationTxT.Name = "ShelfLocationTxT";
            this.ShelfLocationTxT.Size = new System.Drawing.Size(188, 22);
            this.ShelfLocationTxT.TabIndex = 30;
            // 
            // ShelfLoclbl
            // 
            this.ShelfLoclbl.AutoSize = true;
            this.ShelfLoclbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShelfLoclbl.Location = new System.Drawing.Point(432, 275);
            this.ShelfLoclbl.Name = "ShelfLoclbl";
            this.ShelfLoclbl.Size = new System.Drawing.Size(111, 19);
            this.ShelfLoclbl.TabIndex = 29;
            this.ShelfLoclbl.Text = "Shelf Location :";
            // 
            // PublishYearPick
            // 
            this.PublishYearPick.CustomFormat = "  yyyy";
            this.PublishYearPick.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishYearPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PublishYearPick.Location = new System.Drawing.Point(551, 237);
            this.PublishYearPick.Name = "PublishYearPick";
            this.PublishYearPick.ShowUpDown = true;
            this.PublishYearPick.Size = new System.Drawing.Size(77, 24);
            this.PublishYearPick.TabIndex = 28;
            // 
            // PublishYearlbl
            // 
            this.PublishYearlbl.AutoSize = true;
            this.PublishYearlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishYearlbl.Location = new System.Drawing.Point(448, 237);
            this.PublishYearlbl.Name = "PublishYearlbl";
            this.PublishYearlbl.Size = new System.Drawing.Size(95, 19);
            this.PublishYearlbl.TabIndex = 27;
            this.PublishYearlbl.Text = "Publish Year:";
            // 
            // Publishertxt
            // 
            this.Publishertxt.Location = new System.Drawing.Point(551, 204);
            this.Publishertxt.Name = "Publishertxt";
            this.Publishertxt.Size = new System.Drawing.Size(188, 22);
            this.Publishertxt.TabIndex = 26;
            // 
            // Publisherlbl
            // 
            this.Publisherlbl.AutoSize = true;
            this.Publisherlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisherlbl.Location = new System.Drawing.Point(464, 204);
            this.Publisherlbl.Name = "Publisherlbl";
            this.Publisherlbl.Size = new System.Drawing.Size(79, 19);
            this.Publisherlbl.TabIndex = 25;
            this.Publisherlbl.Text = "Publisher :";
            // 
            // CategoryCB
            // 
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(551, 154);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(188, 24);
            this.CategoryCB.TabIndex = 24;
            // 
            // Categorylbl
            // 
            this.Categorylbl.AutoSize = true;
            this.Categorylbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylbl.Location = new System.Drawing.Point(466, 154);
            this.Categorylbl.Name = "Categorylbl";
            this.Categorylbl.Size = new System.Drawing.Size(78, 19);
            this.Categorylbl.TabIndex = 23;
            this.Categorylbl.Text = "Category :";
            // 
            // ISBNtxt
            // 
            this.ISBNtxt.Location = new System.Drawing.Point(551, 113);
            this.ISBNtxt.Name = "ISBNtxt";
            this.ISBNtxt.Size = new System.Drawing.Size(188, 22);
            this.ISBNtxt.TabIndex = 22;
            // 
            // ISBNlbl
            // 
            this.ISBNlbl.AutoSize = true;
            this.ISBNlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNlbl.Location = new System.Drawing.Point(494, 114);
            this.ISBNlbl.Name = "ISBNlbl";
            this.ISBNlbl.Size = new System.Drawing.Size(49, 19);
            this.ISBNlbl.TabIndex = 21;
            this.ISBNlbl.Text = "ISBN :";
            // 
            // AuthorTxT
            // 
            this.AuthorTxT.Location = new System.Drawing.Point(551, 73);
            this.AuthorTxT.Name = "AuthorTxT";
            this.AuthorTxT.Size = new System.Drawing.Size(188, 22);
            this.AuthorTxT.TabIndex = 20;
            // 
            // Authorlbl
            // 
            this.Authorlbl.AutoSize = true;
            this.Authorlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authorlbl.Location = new System.Drawing.Point(484, 74);
            this.Authorlbl.Name = "Authorlbl";
            this.Authorlbl.Size = new System.Drawing.Size(67, 19);
            this.Authorlbl.TabIndex = 19;
            this.Authorlbl.Text = "Author : ";
            // 
            // TitleTxT
            // 
            this.TitleTxT.Location = new System.Drawing.Point(551, 34);
            this.TitleTxT.Name = "TitleTxT";
            this.TitleTxT.Size = new System.Drawing.Size(188, 22);
            this.TitleTxT.TabIndex = 18;
            // 
            // TITLElbl
            // 
            this.TITLElbl.AutoSize = true;
            this.TITLElbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLElbl.Location = new System.Drawing.Point(497, 35);
            this.TITLElbl.Name = "TITLElbl";
            this.TITLElbl.Size = new System.Drawing.Size(50, 19);
            this.TITLElbl.TabIndex = 17;
            this.TITLElbl.Text = "Title : ";
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.ShelfLocationTxT);
            this.Controls.Add(this.ShelfLoclbl);
            this.Controls.Add(this.PublishYearPick);
            this.Controls.Add(this.PublishYearlbl);
            this.Controls.Add(this.Publishertxt);
            this.Controls.Add(this.Publisherlbl);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.Categorylbl);
            this.Controls.Add(this.ISBNtxt);
            this.Controls.Add(this.ISBNlbl);
            this.Controls.Add(this.AuthorTxT);
            this.Controls.Add(this.Authorlbl);
            this.Controls.Add(this.TitleTxT);
            this.Controls.Add(this.TITLElbl);
            this.Controls.Add(this.DGVEidtBook);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxT);
            this.Controls.Add(this.Searchtitlelbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditBookForm";
            this.Text = "Edit Book";
            ((System.ComponentModel.ISupportInitialize)(this.DGVEidtBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTxT;
        private System.Windows.Forms.Label Searchtitlelbl;
        private System.Windows.Forms.DataGridView DGVEidtBook;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox ShelfLocationTxT;
        private System.Windows.Forms.Label ShelfLoclbl;
        private System.Windows.Forms.DateTimePicker PublishYearPick;
        private System.Windows.Forms.Label PublishYearlbl;
        private System.Windows.Forms.TextBox Publishertxt;
        private System.Windows.Forms.Label Publisherlbl;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Label Categorylbl;
        private System.Windows.Forms.TextBox ISBNtxt;
        private System.Windows.Forms.Label ISBNlbl;
        private System.Windows.Forms.TextBox AuthorTxT;
        private System.Windows.Forms.Label Authorlbl;
        private System.Windows.Forms.TextBox TitleTxT;
        private System.Windows.Forms.Label TITLElbl;
    }
}