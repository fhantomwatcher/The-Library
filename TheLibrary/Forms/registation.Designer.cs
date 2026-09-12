namespace TheLibrary
{
    partial class registation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registation));
            this.Thelibrarytitle = new System.Windows.Forms.Label();
            this.registationlbl = new System.Windows.Forms.Label();
            this.fnlbl = new System.Windows.Forms.Label();
            this.fntxt = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.doblbl = new System.Windows.Forms.Label();
            this.Dobpick = new System.Windows.Forms.DateTimePicker();
            this.passlbl = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.addrslbl = new System.Windows.Forms.Label();
            this.addrsrtxt = new System.Windows.Forms.RichTextBox();
            this.Genderlbl = new System.Windows.Forms.Label();
            this.genderMalerb = new System.Windows.Forms.RadioButton();
            this.genderFemalerb = new System.Windows.Forms.RadioButton();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.cancelregisbtn = new System.Windows.Forms.Button();
            this.lblerrorinput = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.Regbacklbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Thelibrarytitle
            // 
            this.Thelibrarytitle.AutoSize = true;
            this.Thelibrarytitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thelibrarytitle.Location = new System.Drawing.Point(358, 9);
            this.Thelibrarytitle.Name = "Thelibrarytitle";
            this.Thelibrarytitle.Size = new System.Drawing.Size(137, 31);
            this.Thelibrarytitle.TabIndex = 1;
            this.Thelibrarytitle.Text = "TheLibrary";
            // 
            // registationlbl
            // 
            this.registationlbl.AutoSize = true;
            this.registationlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registationlbl.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.registationlbl.Location = new System.Drawing.Point(373, 53);
            this.registationlbl.Name = "registationlbl";
            this.registationlbl.Size = new System.Drawing.Size(107, 24);
            this.registationlbl.TabIndex = 2;
            this.registationlbl.Text = "Registation";
            // 
            // fnlbl
            // 
            this.fnlbl.AutoSize = true;
            this.fnlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlbl.Location = new System.Drawing.Point(74, 98);
            this.fnlbl.Name = "fnlbl";
            this.fnlbl.Size = new System.Drawing.Size(85, 19);
            this.fnlbl.TabIndex = 3;
            this.fnlbl.Text = "Full Name";
            // 
            // fntxt
            // 
            this.fntxt.Location = new System.Drawing.Point(170, 98);
            this.fntxt.Name = "fntxt";
            this.fntxt.Size = new System.Drawing.Size(207, 22);
            this.fntxt.TabIndex = 4;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(107, 134);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(50, 19);
            this.emaillbl.TabIndex = 7;
            this.emaillbl.Text = "Email";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(169, 135);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(207, 22);
            this.emailtxt.TabIndex = 8;
            // 
            // doblbl
            // 
            this.doblbl.AutoSize = true;
            this.doblbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doblbl.Location = new System.Drawing.Point(452, 138);
            this.doblbl.Name = "doblbl";
            this.doblbl.Size = new System.Drawing.Size(43, 19);
            this.doblbl.TabIndex = 9;
            this.doblbl.Text = "DOB";
            // 
            // Dobpick
            // 
            this.Dobpick.CustomFormat = "dd/MM/yyyy";
            this.Dobpick.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dobpick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dobpick.Location = new System.Drawing.Point(525, 134);
            this.Dobpick.Name = "Dobpick";
            this.Dobpick.Size = new System.Drawing.Size(204, 27);
            this.Dobpick.TabIndex = 10;
            this.Dobpick.ValueChanged += new System.EventHandler(this.Dobpick_ValueChanged);
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(74, 170);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(84, 19);
            this.passlbl.TabIndex = 11;
            this.passlbl.Text = "PassWord";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(169, 171);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(207, 22);
            this.passtxt.TabIndex = 12;
            // 
            // addrslbl
            // 
            this.addrslbl.AutoSize = true;
            this.addrslbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrslbl.Location = new System.Drawing.Point(74, 202);
            this.addrslbl.Name = "addrslbl";
            this.addrslbl.Size = new System.Drawing.Size(69, 19);
            this.addrslbl.TabIndex = 13;
            this.addrslbl.Text = "Address";
            // 
            // addrsrtxt
            // 
            this.addrsrtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrsrtxt.Location = new System.Drawing.Point(78, 226);
            this.addrsrtxt.Name = "addrsrtxt";
            this.addrsrtxt.Size = new System.Drawing.Size(299, 154);
            this.addrsrtxt.TabIndex = 14;
            this.addrsrtxt.Text = "";
            // 
            // Genderlbl
            // 
            this.Genderlbl.AutoSize = true;
            this.Genderlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlbl.Location = new System.Drawing.Point(432, 174);
            this.Genderlbl.Name = "Genderlbl";
            this.Genderlbl.Size = new System.Drawing.Size(64, 19);
            this.Genderlbl.TabIndex = 15;
            this.Genderlbl.Text = "Gender";
            // 
            // genderMalerb
            // 
            this.genderMalerb.AutoSize = true;
            this.genderMalerb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderMalerb.Location = new System.Drawing.Point(529, 174);
            this.genderMalerb.Name = "genderMalerb";
            this.genderMalerb.Size = new System.Drawing.Size(67, 23);
            this.genderMalerb.TabIndex = 16;
            this.genderMalerb.TabStop = true;
            this.genderMalerb.Text = "Male";
            this.genderMalerb.UseVisualStyleBackColor = true;
            // 
            // genderFemalerb
            // 
            this.genderFemalerb.AutoSize = true;
            this.genderFemalerb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderFemalerb.Location = new System.Drawing.Point(639, 174);
            this.genderFemalerb.Name = "genderFemalerb";
            this.genderFemalerb.Size = new System.Drawing.Size(84, 23);
            this.genderFemalerb.TabIndex = 17;
            this.genderFemalerb.TabStop = true;
            this.genderFemalerb.Text = "Female";
            this.genderFemalerb.UseVisualStyleBackColor = true;
            // 
            // Registerbtn
            // 
            this.Registerbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Registerbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Registerbtn.Location = new System.Drawing.Point(522, 333);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(163, 47);
            this.Registerbtn.TabIndex = 18;
            this.Registerbtn.Text = "Register";
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // cancelregisbtn
            // 
            this.cancelregisbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cancelregisbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelregisbtn.ForeColor = System.Drawing.Color.Red;
            this.cancelregisbtn.Location = new System.Drawing.Point(526, 386);
            this.cancelregisbtn.Name = "cancelregisbtn";
            this.cancelregisbtn.Size = new System.Drawing.Size(158, 28);
            this.cancelregisbtn.TabIndex = 19;
            this.cancelregisbtn.Text = "Cancel Registation";
            this.cancelregisbtn.UseVisualStyleBackColor = false;
            this.cancelregisbtn.Click += new System.EventHandler(this.cancelregisbtn_Click);
            // 
            // lblerrorinput
            // 
            this.lblerrorinput.AutoSize = true;
            this.lblerrorinput.Location = new System.Drawing.Point(450, 216);
            this.lblerrorinput.Name = "lblerrorinput";
            this.lblerrorinput.Size = new System.Drawing.Size(0, 16);
            this.lblerrorinput.TabIndex = 20;
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelbl.Location = new System.Drawing.Point(436, 98);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(58, 19);
            this.phonelbl.TabIndex = 21;
            this.phonelbl.Text = "Phone";
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(525, 95);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(207, 22);
            this.phonetxt.TabIndex = 22;
            // 
            // Regbacklbl
            // 
            this.Regbacklbl.AutoSize = true;
            this.Regbacklbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regbacklbl.Location = new System.Drawing.Point(12, 9);
            this.Regbacklbl.Name = "Regbacklbl";
            this.Regbacklbl.Size = new System.Drawing.Size(126, 19);
            this.Regbacklbl.TabIndex = 23;
            this.Regbacklbl.Text = "< Back to Login";
            this.Regbacklbl.Click += new System.EventHandler(this.Regbacklbl_Click);
            // 
            // registation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 461);
            this.Controls.Add(this.Regbacklbl);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.lblerrorinput);
            this.Controls.Add(this.cancelregisbtn);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.genderFemalerb);
            this.Controls.Add(this.genderMalerb);
            this.Controls.Add(this.Genderlbl);
            this.Controls.Add(this.addrsrtxt);
            this.Controls.Add(this.addrslbl);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.Dobpick);
            this.Controls.Add(this.doblbl);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.fntxt);
            this.Controls.Add(this.fnlbl);
            this.Controls.Add(this.registationlbl);
            this.Controls.Add(this.Thelibrarytitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "registation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Thelibrarytitle;
        private System.Windows.Forms.Label registationlbl;
        private System.Windows.Forms.Label fnlbl;
        private System.Windows.Forms.TextBox fntxt;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label doblbl;
        private System.Windows.Forms.DateTimePicker Dobpick;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label addrslbl;
        private System.Windows.Forms.RichTextBox addrsrtxt;
        private System.Windows.Forms.Label Genderlbl;
        private System.Windows.Forms.RadioButton genderMalerb;
        private System.Windows.Forms.RadioButton genderFemalerb;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.Button cancelregisbtn;
        private System.Windows.Forms.Label lblerrorinput;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label Regbacklbl;
    }
}