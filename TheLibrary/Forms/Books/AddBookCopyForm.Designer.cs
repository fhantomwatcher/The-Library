namespace TheLibrary.Forms.Books
{
    partial class AddBookCopyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookCopyForm));
            this.BookIDlbl = new System.Windows.Forms.Label();
            this.BookNamelbl = new System.Windows.Forms.Label();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.AcquisitionDatelbl = new System.Windows.Forms.Label();
            this.AcquisitionDatepicker = new System.Windows.Forms.DateTimePicker();
            this.StatusCB = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookIDlbl
            // 
            this.BookIDlbl.AutoSize = true;
            this.BookIDlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDlbl.Location = new System.Drawing.Point(61, 39);
            this.BookIDlbl.Name = "BookIDlbl";
            this.BookIDlbl.Size = new System.Drawing.Size(70, 19);
            this.BookIDlbl.TabIndex = 0;
            this.BookIDlbl.Text = "Book ID :";
            // 
            // BookNamelbl
            // 
            this.BookNamelbl.AutoSize = true;
            this.BookNamelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNamelbl.Location = new System.Drawing.Point(61, 68);
            this.BookNamelbl.Name = "BookNamelbl";
            this.BookNamelbl.Size = new System.Drawing.Size(52, 19);
            this.BookNamelbl.TabIndex = 1;
            this.BookNamelbl.Text = "Book :";
            // 
            // Statuslbl
            // 
            this.Statuslbl.AutoSize = true;
            this.Statuslbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslbl.Location = new System.Drawing.Point(61, 105);
            this.Statuslbl.Name = "Statuslbl";
            this.Statuslbl.Size = new System.Drawing.Size(57, 19);
            this.Statuslbl.TabIndex = 2;
            this.Statuslbl.Text = "Status :";
            // 
            // AcquisitionDatelbl
            // 
            this.AcquisitionDatelbl.AutoSize = true;
            this.AcquisitionDatelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcquisitionDatelbl.Location = new System.Drawing.Point(61, 144);
            this.AcquisitionDatelbl.Name = "AcquisitionDatelbl";
            this.AcquisitionDatelbl.Size = new System.Drawing.Size(126, 19);
            this.AcquisitionDatelbl.TabIndex = 3;
            this.AcquisitionDatelbl.Text = "Acquisition Date :";
            // 
            // AcquisitionDatepicker
            // 
            this.AcquisitionDatepicker.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcquisitionDatepicker.CustomFormat = "  dd/MM/yyyy";
            this.AcquisitionDatepicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcquisitionDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AcquisitionDatepicker.Location = new System.Drawing.Point(194, 144);
            this.AcquisitionDatepicker.Name = "AcquisitionDatepicker";
            this.AcquisitionDatepicker.Size = new System.Drawing.Size(109, 24);
            this.AcquisitionDatepicker.TabIndex = 4;
            // 
            // StatusCB
            // 
            this.StatusCB.FormattingEnabled = true;
            this.StatusCB.Location = new System.Drawing.Point(125, 105);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(178, 24);
            this.StatusCB.TabIndex = 5;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.SaveBtn.Location = new System.Drawing.Point(80, 211);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 33);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Crimson;
            this.CancelBtn.Location = new System.Drawing.Point(184, 211);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 33);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBookCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 275);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.StatusCB);
            this.Controls.Add(this.AcquisitionDatepicker);
            this.Controls.Add(this.AcquisitionDatelbl);
            this.Controls.Add(this.Statuslbl);
            this.Controls.Add(this.BookNamelbl);
            this.Controls.Add(this.BookIDlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBookCopyForm";
            this.Text = "Add A Book Copy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookIDlbl;
        private System.Windows.Forms.Label BookNamelbl;
        private System.Windows.Forms.Label Statuslbl;
        private System.Windows.Forms.Label AcquisitionDatelbl;
        private System.Windows.Forms.DateTimePicker AcquisitionDatepicker;
        private System.Windows.Forms.ComboBox StatusCB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}