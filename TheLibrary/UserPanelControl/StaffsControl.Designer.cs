namespace TheLibrary.UserPanelControl
{
    partial class StaffsControl
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
            this.components = new System.ComponentModel.Container();
            this.Stafftitle = new System.Windows.Forms.Label();
            this.HLtitlelbl = new System.Windows.Forms.Label();
            this.addstflbl = new System.Windows.Forms.Button();
            this.DgvHL = new System.Windows.Forms.DataGridView();
            this.theLibraryDBDataSet = new TheLibrary.TheLibraryDBDataSet();
            this.theLibraryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ltitlelbl = new System.Windows.Forms.Label();
            this.DgvL = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.HLSearchtxt = new System.Windows.Forms.TextBox();
            this.HLSearchbtn = new System.Windows.Forms.Button();
            this.LSearchbtn = new System.Windows.Forms.Button();
            this.LSearchtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLibraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLibraryDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvL)).BeginInit();
            this.SuspendLayout();
            // 
            // Stafftitle
            // 
            this.Stafftitle.AutoSize = true;
            this.Stafftitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stafftitle.Location = new System.Drawing.Point(40, 35);
            this.Stafftitle.Name = "Stafftitle";
            this.Stafftitle.Size = new System.Drawing.Size(74, 33);
            this.Stafftitle.TabIndex = 0;
            this.Stafftitle.Text = "Staff";
            // 
            // HLtitlelbl
            // 
            this.HLtitlelbl.AutoSize = true;
            this.HLtitlelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HLtitlelbl.Location = new System.Drawing.Point(71, 71);
            this.HLtitlelbl.Name = "HLtitlelbl";
            this.HLtitlelbl.Size = new System.Drawing.Size(135, 24);
            this.HLtitlelbl.TabIndex = 1;
            this.HLtitlelbl.Text = "Head Librarian";
            // 
            // addstflbl
            // 
            this.addstflbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstflbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.addstflbl.Location = new System.Drawing.Point(489, 51);
            this.addstflbl.Name = "addstflbl";
            this.addstflbl.Size = new System.Drawing.Size(109, 34);
            this.addstflbl.TabIndex = 2;
            this.addstflbl.Text = "Add Staff";
            this.addstflbl.UseVisualStyleBackColor = true;
            // 
            // DgvHL
            // 
            this.DgvHL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHL.Location = new System.Drawing.Point(61, 103);
            this.DgvHL.Name = "DgvHL";
            this.DgvHL.RowHeadersWidth = 51;
            this.DgvHL.RowTemplate.Height = 24;
            this.DgvHL.Size = new System.Drawing.Size(636, 121);
            this.DgvHL.TabIndex = 3;
            // 
            // theLibraryDBDataSet
            // 
            this.theLibraryDBDataSet.DataSetName = "TheLibraryDBDataSet";
            this.theLibraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // theLibraryDBDataSetBindingSource
            // 
            this.theLibraryDBDataSetBindingSource.DataSource = this.theLibraryDBDataSet;
            this.theLibraryDBDataSetBindingSource.Position = 0;
            // 
            // Ltitlelbl
            // 
            this.Ltitlelbl.AutoSize = true;
            this.Ltitlelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltitlelbl.Location = new System.Drawing.Point(71, 240);
            this.Ltitlelbl.Name = "Ltitlelbl";
            this.Ltitlelbl.Size = new System.Drawing.Size(85, 24);
            this.Ltitlelbl.TabIndex = 4;
            this.Ltitlelbl.Text = "Librarian";
            // 
            // DgvL
            // 
            this.DgvL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvL.Location = new System.Drawing.Point(61, 276);
            this.DgvL.Name = "DgvL";
            this.DgvL.RowHeadersWidth = 51;
            this.DgvL.RowTemplate.Height = 24;
            this.DgvL.Size = new System.Drawing.Size(636, 139);
            this.DgvL.TabIndex = 5;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.Crimson;
            this.Deletebtn.Location = new System.Drawing.Point(604, 51);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(109, 34);
            this.Deletebtn.TabIndex = 6;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // HLSearchtxt
            // 
            this.HLSearchtxt.Location = new System.Drawing.Point(226, 72);
            this.HLSearchtxt.Name = "HLSearchtxt";
            this.HLSearchtxt.Size = new System.Drawing.Size(163, 22);
            this.HLSearchtxt.TabIndex = 7;
            this.HLSearchtxt.TextChanged += new System.EventHandler(this.HLSearchtxt_TextChanged);
            // 
            // HLSearchbtn
            // 
            this.HLSearchbtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.HLSearchbtn.Location = new System.Drawing.Point(394, 72);
            this.HLSearchbtn.Name = "HLSearchbtn";
            this.HLSearchbtn.Size = new System.Drawing.Size(75, 23);
            this.HLSearchbtn.TabIndex = 8;
            this.HLSearchbtn.Text = "Search";
            this.HLSearchbtn.UseVisualStyleBackColor = true;
            this.HLSearchbtn.Click += new System.EventHandler(this.HLSearchbtn_Click);
            this.HLSearchbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HLSearchbtn_KeyDown);
            // 
            // LSearchbtn
            // 
            this.LSearchbtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.LSearchbtn.Location = new System.Drawing.Point(394, 242);
            this.LSearchbtn.Name = "LSearchbtn";
            this.LSearchbtn.Size = new System.Drawing.Size(75, 23);
            this.LSearchbtn.TabIndex = 10;
            this.LSearchbtn.Text = "Search";
            this.LSearchbtn.UseVisualStyleBackColor = true;
            this.LSearchbtn.Click += new System.EventHandler(this.LSearchbtn_Click);
            this.LSearchbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LSearchbtn_KeyDown);
            // 
            // LSearchtxt
            // 
            this.LSearchtxt.Location = new System.Drawing.Point(226, 242);
            this.LSearchtxt.Name = "LSearchtxt";
            this.LSearchtxt.Size = new System.Drawing.Size(163, 22);
            this.LSearchtxt.TabIndex = 9;
            this.LSearchtxt.TextChanged += new System.EventHandler(this.LSearchtxt_TextChanged);
            // 
            // StaffsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LSearchbtn);
            this.Controls.Add(this.LSearchtxt);
            this.Controls.Add(this.HLSearchbtn);
            this.Controls.Add(this.HLSearchtxt);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.DgvL);
            this.Controls.Add(this.Ltitlelbl);
            this.Controls.Add(this.DgvHL);
            this.Controls.Add(this.addstflbl);
            this.Controls.Add(this.HLtitlelbl);
            this.Controls.Add(this.Stafftitle);
            this.Name = "StaffsControl";
            this.Size = new System.Drawing.Size(777, 531);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLibraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLibraryDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Stafftitle;
        private System.Windows.Forms.Label HLtitlelbl;
        private System.Windows.Forms.Button addstflbl;
        private System.Windows.Forms.DataGridView DgvHL;
        private System.Windows.Forms.BindingSource theLibraryDBDataSetBindingSource;
        private TheLibraryDBDataSet theLibraryDBDataSet;
        private System.Windows.Forms.Label Ltitlelbl;
        private System.Windows.Forms.DataGridView DgvL;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox HLSearchtxt;
        private System.Windows.Forms.Button HLSearchbtn;
        private System.Windows.Forms.Button LSearchbtn;
        private System.Windows.Forms.TextBox LSearchtxt;
    }
}
