namespace TheLibrary.Forms
{
    partial class AddBookForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.TITLElbl = new System.Windows.Forms.Label();
            this.TitleTxT = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AuthorTxT = new System.Windows.Forms.TextBox();
            this.Authorlbl = new System.Windows.Forms.Label();
            this.ISBNtxt = new System.Windows.Forms.TextBox();
            this.ISBNlbl = new System.Windows.Forms.Label();
            this.Categorylbl = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.Publisherlbl = new System.Windows.Forms.Label();
            this.Publishertxt = new System.Windows.Forms.TextBox();
            this.PublishYearlbl = new System.Windows.Forms.Label();
            this.PublishYearPick = new System.Windows.Forms.DateTimePicker();
            this.ShelfLocationTxT = new System.Windows.Forms.TextBox();
            this.ShelfLoclbl = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TITLElbl
            // 
            this.TITLElbl.AutoSize = true;
            this.TITLElbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLElbl.Location = new System.Drawing.Point(79, 27);
            this.TITLElbl.Name = "TITLElbl";
            this.TITLElbl.Size = new System.Drawing.Size(50, 19);
            this.TITLElbl.TabIndex = 0;
            this.TITLElbl.Text = "Title : ";
            // 
            // TitleTxT
            // 
            this.TitleTxT.Location = new System.Drawing.Point(133, 26);
            this.TitleTxT.Name = "TitleTxT";
            this.TitleTxT.Size = new System.Drawing.Size(188, 22);
            this.TitleTxT.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AuthorTxT
            // 
            this.AuthorTxT.Location = new System.Drawing.Point(133, 65);
            this.AuthorTxT.Name = "AuthorTxT";
            this.AuthorTxT.Size = new System.Drawing.Size(188, 22);
            this.AuthorTxT.TabIndex = 4;
            // 
            // Authorlbl
            // 
            this.Authorlbl.AutoSize = true;
            this.Authorlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authorlbl.Location = new System.Drawing.Point(66, 66);
            this.Authorlbl.Name = "Authorlbl";
            this.Authorlbl.Size = new System.Drawing.Size(67, 19);
            this.Authorlbl.TabIndex = 3;
            this.Authorlbl.Text = "Author : ";
            // 
            // ISBNtxt
            // 
            this.ISBNtxt.Location = new System.Drawing.Point(133, 105);
            this.ISBNtxt.Name = "ISBNtxt";
            this.ISBNtxt.Size = new System.Drawing.Size(188, 22);
            this.ISBNtxt.TabIndex = 6;
            // 
            // ISBNlbl
            // 
            this.ISBNlbl.AutoSize = true;
            this.ISBNlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNlbl.Location = new System.Drawing.Point(76, 106);
            this.ISBNlbl.Name = "ISBNlbl";
            this.ISBNlbl.Size = new System.Drawing.Size(49, 19);
            this.ISBNlbl.TabIndex = 5;
            this.ISBNlbl.Text = "ISBN :";
            // 
            // Categorylbl
            // 
            this.Categorylbl.AutoSize = true;
            this.Categorylbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylbl.Location = new System.Drawing.Point(48, 146);
            this.Categorylbl.Name = "Categorylbl";
            this.Categorylbl.Size = new System.Drawing.Size(78, 19);
            this.Categorylbl.TabIndex = 7;
            this.Categorylbl.Text = "Category :";
            // 
            // CategoryCB
            // 
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(133, 146);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(188, 24);
            this.CategoryCB.TabIndex = 8;
            // 
            // Publisherlbl
            // 
            this.Publisherlbl.AutoSize = true;
            this.Publisherlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisherlbl.Location = new System.Drawing.Point(46, 196);
            this.Publisherlbl.Name = "Publisherlbl";
            this.Publisherlbl.Size = new System.Drawing.Size(79, 19);
            this.Publisherlbl.TabIndex = 9;
            this.Publisherlbl.Text = "Publisher :";
            // 
            // Publishertxt
            // 
            this.Publishertxt.Location = new System.Drawing.Point(133, 196);
            this.Publishertxt.Name = "Publishertxt";
            this.Publishertxt.Size = new System.Drawing.Size(188, 22);
            this.Publishertxt.TabIndex = 10;
            // 
            // PublishYearlbl
            // 
            this.PublishYearlbl.AutoSize = true;
            this.PublishYearlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishYearlbl.Location = new System.Drawing.Point(30, 229);
            this.PublishYearlbl.Name = "PublishYearlbl";
            this.PublishYearlbl.Size = new System.Drawing.Size(95, 19);
            this.PublishYearlbl.TabIndex = 11;
            this.PublishYearlbl.Text = "Publish Year:";
            // 
            // PublishYearPick
            // 
            this.PublishYearPick.CustomFormat = "  yyyy";
            this.PublishYearPick.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishYearPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PublishYearPick.Location = new System.Drawing.Point(133, 229);
            this.PublishYearPick.Name = "PublishYearPick";
            this.PublishYearPick.ShowUpDown = true;
            this.PublishYearPick.Size = new System.Drawing.Size(77, 24);
            this.PublishYearPick.TabIndex = 12;
            // 
            // ShelfLocationTxT
            // 
            this.ShelfLocationTxT.Location = new System.Drawing.Point(133, 267);
            this.ShelfLocationTxT.Name = "ShelfLocationTxT";
            this.ShelfLocationTxT.Size = new System.Drawing.Size(188, 22);
            this.ShelfLocationTxT.TabIndex = 14;
            // 
            // ShelfLoclbl
            // 
            this.ShelfLoclbl.AutoSize = true;
            this.ShelfLoclbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShelfLoclbl.Location = new System.Drawing.Point(14, 267);
            this.ShelfLoclbl.Name = "ShelfLoclbl";
            this.ShelfLoclbl.Size = new System.Drawing.Size(111, 19);
            this.ShelfLoclbl.TabIndex = 13;
            this.ShelfLoclbl.Text = "Shelf Location :";
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.Addbtn.Location = new System.Drawing.Point(156, 325);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(87, 31);
            this.Addbtn.TabIndex = 15;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Crimson;
            this.CancelBtn.Location = new System.Drawing.Point(156, 377);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(87, 31);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.Addbtn);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITLElbl;
        private System.Windows.Forms.TextBox TitleTxT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox AuthorTxT;
        private System.Windows.Forms.Label Authorlbl;
        private System.Windows.Forms.TextBox ISBNtxt;
        private System.Windows.Forms.Label ISBNlbl;
        private System.Windows.Forms.Label Categorylbl;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Label Publisherlbl;
        private System.Windows.Forms.TextBox Publishertxt;
        private System.Windows.Forms.Label PublishYearlbl;
        private System.Windows.Forms.DateTimePicker PublishYearPick;
        private System.Windows.Forms.TextBox ShelfLocationTxT;
        private System.Windows.Forms.Label ShelfLoclbl;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}