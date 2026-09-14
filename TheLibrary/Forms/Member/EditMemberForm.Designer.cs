namespace TheLibrary.Forms
{
    partial class EditMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMemberForm));
            this.searchbtndsf = new System.Windows.Forms.Button();
            this.searchboxtxt = new System.Windows.Forms.TextBox();
            this.searchMemberlbl = new System.Windows.Forms.Label();
            this.EditMemberdgv = new System.Windows.Forms.DataGridView();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.phonelbl = new System.Windows.Forms.Label();
            this.genderFemalerb = new System.Windows.Forms.RadioButton();
            this.genderMalerb = new System.Windows.Forms.RadioButton();
            this.Genderlbl = new System.Windows.Forms.Label();
            this.addrsrtxt = new System.Windows.Forms.RichTextBox();
            this.addrslbl = new System.Windows.Forms.Label();
            this.Dobpick = new System.Windows.Forms.DateTimePicker();
            this.doblbl = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.fntxt = new System.Windows.Forms.TextBox();
            this.fnlbl = new System.Windows.Forms.Label();
            this.CngSavebtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditMemberdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbtndsf
            // 
            this.searchbtndsf.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtndsf.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.searchbtndsf.Location = new System.Drawing.Point(509, 11);
            this.searchbtndsf.Name = "searchbtndsf";
            this.searchbtndsf.Size = new System.Drawing.Size(75, 23);
            this.searchbtndsf.TabIndex = 5;
            this.searchbtndsf.Text = "Search";
            this.searchbtndsf.UseVisualStyleBackColor = true;
            this.searchbtndsf.Click += new System.EventHandler(this.searchbtndsf_Click);
            // 
            // searchboxtxt
            // 
            this.searchboxtxt.Location = new System.Drawing.Point(300, 12);
            this.searchboxtxt.Name = "searchboxtxt";
            this.searchboxtxt.Size = new System.Drawing.Size(203, 22);
            this.searchboxtxt.TabIndex = 4;
            // 
            // searchMemberlbl
            // 
            this.searchMemberlbl.AutoSize = true;
            this.searchMemberlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberlbl.Location = new System.Drawing.Point(171, 15);
            this.searchMemberlbl.Name = "searchMemberlbl";
            this.searchMemberlbl.Size = new System.Drawing.Size(123, 19);
            this.searchMemberlbl.TabIndex = 3;
            this.searchMemberlbl.Text = "Serach Member :";
            // 
            // EditMemberdgv
            // 
            this.EditMemberdgv.AllowUserToAddRows = false;
            this.EditMemberdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditMemberdgv.Location = new System.Drawing.Point(59, 47);
            this.EditMemberdgv.MultiSelect = false;
            this.EditMemberdgv.Name = "EditMemberdgv";
            this.EditMemberdgv.ReadOnly = true;
            this.EditMemberdgv.RowHeadersWidth = 51;
            this.EditMemberdgv.RowTemplate.Height = 24;
            this.EditMemberdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EditMemberdgv.Size = new System.Drawing.Size(693, 131);
            this.EditMemberdgv.TabIndex = 7;
            this.EditMemberdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditMemberdgv_CellClick);
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(522, 193);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(207, 22);
            this.phonetxt.TabIndex = 35;
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelbl.Location = new System.Drawing.Point(433, 196);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(58, 19);
            this.phonelbl.TabIndex = 34;
            this.phonelbl.Text = "Phone";
            // 
            // genderFemalerb
            // 
            this.genderFemalerb.AutoSize = true;
            this.genderFemalerb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderFemalerb.Location = new System.Drawing.Point(636, 272);
            this.genderFemalerb.Name = "genderFemalerb";
            this.genderFemalerb.Size = new System.Drawing.Size(84, 23);
            this.genderFemalerb.TabIndex = 33;
            this.genderFemalerb.TabStop = true;
            this.genderFemalerb.Text = "Female";
            this.genderFemalerb.UseVisualStyleBackColor = true;
            // 
            // genderMalerb
            // 
            this.genderMalerb.AutoSize = true;
            this.genderMalerb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderMalerb.Location = new System.Drawing.Point(526, 272);
            this.genderMalerb.Name = "genderMalerb";
            this.genderMalerb.Size = new System.Drawing.Size(67, 23);
            this.genderMalerb.TabIndex = 32;
            this.genderMalerb.TabStop = true;
            this.genderMalerb.Text = "Male";
            this.genderMalerb.UseVisualStyleBackColor = true;
            // 
            // Genderlbl
            // 
            this.Genderlbl.AutoSize = true;
            this.Genderlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlbl.Location = new System.Drawing.Point(429, 272);
            this.Genderlbl.Name = "Genderlbl";
            this.Genderlbl.Size = new System.Drawing.Size(64, 19);
            this.Genderlbl.TabIndex = 31;
            this.Genderlbl.Text = "Gender";
            // 
            // addrsrtxt
            // 
            this.addrsrtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrsrtxt.Location = new System.Drawing.Point(75, 278);
            this.addrsrtxt.Name = "addrsrtxt";
            this.addrsrtxt.Size = new System.Drawing.Size(299, 90);
            this.addrsrtxt.TabIndex = 30;
            this.addrsrtxt.Text = "";
            // 
            // addrslbl
            // 
            this.addrslbl.AutoSize = true;
            this.addrslbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrslbl.Location = new System.Drawing.Point(71, 254);
            this.addrslbl.Name = "addrslbl";
            this.addrslbl.Size = new System.Drawing.Size(69, 19);
            this.addrslbl.TabIndex = 29;
            this.addrslbl.Text = "Address";
            // 
            // Dobpick
            // 
            this.Dobpick.CustomFormat = "dd/MM/yyyy";
            this.Dobpick.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dobpick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dobpick.Location = new System.Drawing.Point(522, 232);
            this.Dobpick.Name = "Dobpick";
            this.Dobpick.Size = new System.Drawing.Size(204, 27);
            this.Dobpick.TabIndex = 28;
            // 
            // doblbl
            // 
            this.doblbl.AutoSize = true;
            this.doblbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doblbl.Location = new System.Drawing.Point(449, 236);
            this.doblbl.Name = "doblbl";
            this.doblbl.Size = new System.Drawing.Size(43, 19);
            this.doblbl.TabIndex = 27;
            this.doblbl.Text = "DOB";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(166, 233);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(207, 22);
            this.emailtxt.TabIndex = 26;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(104, 232);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(50, 19);
            this.emaillbl.TabIndex = 25;
            this.emaillbl.Text = "Email";
            // 
            // fntxt
            // 
            this.fntxt.Location = new System.Drawing.Point(167, 196);
            this.fntxt.Name = "fntxt";
            this.fntxt.Size = new System.Drawing.Size(207, 22);
            this.fntxt.TabIndex = 24;
            // 
            // fnlbl
            // 
            this.fnlbl.AutoSize = true;
            this.fnlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlbl.Location = new System.Drawing.Point(71, 196);
            this.fnlbl.Name = "fnlbl";
            this.fnlbl.Size = new System.Drawing.Size(85, 19);
            this.fnlbl.TabIndex = 23;
            this.fnlbl.Text = "Full Name";
            // 
            // CngSavebtn
            // 
            this.CngSavebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CngSavebtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.CngSavebtn.Location = new System.Drawing.Point(465, 341);
            this.CngSavebtn.Name = "CngSavebtn";
            this.CngSavebtn.Size = new System.Drawing.Size(75, 27);
            this.CngSavebtn.TabIndex = 36;
            this.CngSavebtn.Text = "Save";
            this.CngSavebtn.UseVisualStyleBackColor = true;
            this.CngSavebtn.Click += new System.EventHandler(this.CngSavebtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.ForeColor = System.Drawing.Color.Crimson;
            this.Cancelbtn.Location = new System.Drawing.Point(595, 341);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 27);
            this.Cancelbtn.TabIndex = 37;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // EditMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.CngSavebtn);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.genderFemalerb);
            this.Controls.Add(this.genderMalerb);
            this.Controls.Add(this.Genderlbl);
            this.Controls.Add(this.addrsrtxt);
            this.Controls.Add(this.addrslbl);
            this.Controls.Add(this.Dobpick);
            this.Controls.Add(this.doblbl);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.fntxt);
            this.Controls.Add(this.fnlbl);
            this.Controls.Add(this.EditMemberdgv);
            this.Controls.Add(this.searchbtndsf);
            this.Controls.Add(this.searchboxtxt);
            this.Controls.Add(this.searchMemberlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Member";
            ((System.ComponentModel.ISupportInitialize)(this.EditMemberdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbtndsf;
        private System.Windows.Forms.TextBox searchboxtxt;
        private System.Windows.Forms.Label searchMemberlbl;
        private System.Windows.Forms.DataGridView EditMemberdgv;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.RadioButton genderFemalerb;
        private System.Windows.Forms.RadioButton genderMalerb;
        private System.Windows.Forms.Label Genderlbl;
        private System.Windows.Forms.RichTextBox addrsrtxt;
        private System.Windows.Forms.Label addrslbl;
        private System.Windows.Forms.DateTimePicker Dobpick;
        private System.Windows.Forms.Label doblbl;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox fntxt;
        private System.Windows.Forms.Label fnlbl;
        private System.Windows.Forms.Button CngSavebtn;
        private System.Windows.Forms.Button Cancelbtn;
    }
}