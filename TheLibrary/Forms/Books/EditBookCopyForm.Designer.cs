namespace TheLibrary.Forms.Books
{
    partial class EditBookCopyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBookCopyForm));
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.StatusCB = new System.Windows.Forms.ComboBox();
            this.AcquisitionDatepicker = new System.Windows.Forms.DateTimePicker();
            this.AcquisitionDatelbl = new System.Windows.Forms.Label();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.BookNamelbl = new System.Windows.Forms.Label();
            this.BookIDlbl = new System.Windows.Forms.Label();
            this.BookCopyID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Crimson;
            this.CancelBtn.Location = new System.Drawing.Point(184, 214);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 33);
            this.CancelBtn.TabIndex = 15;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.SaveBtn.Location = new System.Drawing.Point(80, 214);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 33);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // StatusCB
            // 
            this.StatusCB.FormattingEnabled = true;
            this.StatusCB.Location = new System.Drawing.Point(106, 108);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(178, 24);
            this.StatusCB.TabIndex = 13;
            // 
            // AcquisitionDatepicker
            // 
            this.AcquisitionDatepicker.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcquisitionDatepicker.CustomFormat = "  dd/MM/yyyy";
            this.AcquisitionDatepicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcquisitionDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AcquisitionDatepicker.Location = new System.Drawing.Point(175, 147);
            this.AcquisitionDatepicker.Name = "AcquisitionDatepicker";
            this.AcquisitionDatepicker.Size = new System.Drawing.Size(109, 24);
            this.AcquisitionDatepicker.TabIndex = 12;
            // 
            // AcquisitionDatelbl
            // 
            this.AcquisitionDatelbl.AutoSize = true;
            this.AcquisitionDatelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcquisitionDatelbl.Location = new System.Drawing.Point(42, 147);
            this.AcquisitionDatelbl.Name = "AcquisitionDatelbl";
            this.AcquisitionDatelbl.Size = new System.Drawing.Size(126, 19);
            this.AcquisitionDatelbl.TabIndex = 11;
            this.AcquisitionDatelbl.Text = "Acquisition Date :";
            // 
            // Statuslbl
            // 
            this.Statuslbl.AutoSize = true;
            this.Statuslbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslbl.Location = new System.Drawing.Point(42, 108);
            this.Statuslbl.Name = "Statuslbl";
            this.Statuslbl.Size = new System.Drawing.Size(57, 19);
            this.Statuslbl.TabIndex = 10;
            this.Statuslbl.Text = "Status :";
            // 
            // BookNamelbl
            // 
            this.BookNamelbl.AutoSize = true;
            this.BookNamelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNamelbl.Location = new System.Drawing.Point(42, 71);
            this.BookNamelbl.Name = "BookNamelbl";
            this.BookNamelbl.Size = new System.Drawing.Size(52, 19);
            this.BookNamelbl.TabIndex = 9;
            this.BookNamelbl.Text = "Book :";
            // 
            // BookIDlbl
            // 
            this.BookIDlbl.AutoSize = true;
            this.BookIDlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDlbl.Location = new System.Drawing.Point(42, 42);
            this.BookIDlbl.Name = "BookIDlbl";
            this.BookIDlbl.Size = new System.Drawing.Size(70, 19);
            this.BookIDlbl.TabIndex = 8;
            this.BookIDlbl.Text = "Book ID :";
            // 
            // BookCopyID
            // 
            this.BookCopyID.AutoSize = true;
            this.BookCopyID.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCopyID.Location = new System.Drawing.Point(42, 21);
            this.BookCopyID.Name = "BookCopyID";
            this.BookCopyID.Size = new System.Drawing.Size(108, 19);
            this.BookCopyID.TabIndex = 16;
            this.BookCopyID.Text = "Book Copy ID :";
            // 
            // EditBookCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 275);
            this.Controls.Add(this.BookCopyID);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.StatusCB);
            this.Controls.Add(this.AcquisitionDatepicker);
            this.Controls.Add(this.AcquisitionDatelbl);
            this.Controls.Add(this.Statuslbl);
            this.Controls.Add(this.BookNamelbl);
            this.Controls.Add(this.BookIDlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditBookCopyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Book Copy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox StatusCB;
        private System.Windows.Forms.DateTimePicker AcquisitionDatepicker;
        private System.Windows.Forms.Label AcquisitionDatelbl;
        private System.Windows.Forms.Label Statuslbl;
        private System.Windows.Forms.Label BookNamelbl;
        private System.Windows.Forms.Label BookIDlbl;
        private System.Windows.Forms.Label BookCopyID;
    }
}