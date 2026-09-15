
namespace TheLibrary
{
    partial class Fines
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkIsPaid = new System.Windows.Forms.CheckBox();
            this.txtFineID = new System.Windows.Forms.TextBox();
            this.txtLoanID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddFine = new System.Windows.Forms.Button();
            this.btnMarkPaid = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblErrorFineID = new System.Windows.Forms.Label();
            this.lblErrorLoanID = new System.Windows.Forms.Label();
            this.lblErrorAmount = new System.Windows.Forms.Label();
            this.lblErrorReason = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FINE ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOAN ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "AMOUNT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "REASON";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "PAID";
            // 
            // chkIsPaid
            // 
            this.chkIsPaid.AutoSize = true;
            this.chkIsPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsPaid.Location = new System.Drawing.Point(152, 296);
            this.chkIsPaid.Name = "chkIsPaid";
            this.chkIsPaid.Size = new System.Drawing.Size(60, 21);
            this.chkIsPaid.TabIndex = 5;
            this.chkIsPaid.Text = "YES";
            this.chkIsPaid.UseVisualStyleBackColor = true;
            // 
            // txtFineID
            // 
            this.txtFineID.Location = new System.Drawing.Point(152, 50);
            this.txtFineID.Name = "txtFineID";
            this.txtFineID.Size = new System.Drawing.Size(100, 22);
            this.txtFineID.TabIndex = 6;
            // 
            // txtLoanID
            // 
            this.txtLoanID.Location = new System.Drawing.Point(152, 111);
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.Size = new System.Drawing.Size(100, 22);
            this.txtLoanID.TabIndex = 7;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(152, 171);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 8;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(152, 231);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(100, 22);
            this.txtReason.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(455, 274);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAddFine
            // 
            this.btnAddFine.BackColor = System.Drawing.Color.Plum;
            this.btnAddFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFine.Location = new System.Drawing.Point(68, 353);
            this.btnAddFine.Name = "btnAddFine";
            this.btnAddFine.Size = new System.Drawing.Size(107, 41);
            this.btnAddFine.TabIndex = 11;
            this.btnAddFine.Text = "ADD FINE";
            this.btnAddFine.UseVisualStyleBackColor = false;
            this.btnAddFine.Click += new System.EventHandler(this.btnAddFine_Click);
            // 
            // btnMarkPaid
            // 
            this.btnMarkPaid.BackColor = System.Drawing.Color.Aquamarine;
            this.btnMarkPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkPaid.Location = new System.Drawing.Point(206, 353);
            this.btnMarkPaid.Name = "btnMarkPaid";
            this.btnMarkPaid.Size = new System.Drawing.Size(107, 41);
            this.btnMarkPaid.TabIndex = 12;
            this.btnMarkPaid.Text = "PAID";
            this.btnMarkPaid.UseVisualStyleBackColor = false;
            this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.YellowGreen;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(354, 353);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(107, 41);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // lblErrorFineID
            // 
            this.lblErrorFineID.AutoSize = true;
            this.lblErrorFineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFineID.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorFineID.Location = new System.Drawing.Point(65, 84);
            this.lblErrorFineID.Name = "lblErrorFineID";
            this.lblErrorFineID.Size = new System.Drawing.Size(0, 17);
            this.lblErrorFineID.TabIndex = 14;
            // 
            // lblErrorLoanID
            // 
            this.lblErrorLoanID.AutoSize = true;
            this.lblErrorLoanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLoanID.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorLoanID.Location = new System.Drawing.Point(65, 148);
            this.lblErrorLoanID.Name = "lblErrorLoanID";
            this.lblErrorLoanID.Size = new System.Drawing.Size(0, 17);
            this.lblErrorLoanID.TabIndex = 15;
            // 
            // lblErrorAmount
            // 
            this.lblErrorAmount.AutoSize = true;
            this.lblErrorAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorAmount.Location = new System.Drawing.Point(65, 207);
            this.lblErrorAmount.Name = "lblErrorAmount";
            this.lblErrorAmount.Size = new System.Drawing.Size(0, 17);
            this.lblErrorAmount.TabIndex = 16;
            // 
            // lblErrorReason
            // 
            this.lblErrorReason.AutoSize = true;
            this.lblErrorReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorReason.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorReason.Location = new System.Drawing.Point(65, 264);
            this.lblErrorReason.Name = "lblErrorReason";
            this.lblErrorReason.Size = new System.Drawing.Size(0, 17);
            this.lblErrorReason.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Orange;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(488, 353);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 41);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Fines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblErrorReason);
            this.Controls.Add(this.lblErrorAmount);
            this.Controls.Add(this.lblErrorLoanID);
            this.Controls.Add(this.lblErrorFineID);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnMarkPaid);
            this.Controls.Add(this.btnAddFine);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtLoanID);
            this.Controls.Add(this.txtFineID);
            this.Controls.Add(this.chkIsPaid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fines";
            this.Text = "Fines";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkIsPaid;
        private System.Windows.Forms.TextBox txtFineID;
        private System.Windows.Forms.TextBox txtLoanID;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddFine;
        private System.Windows.Forms.Button btnMarkPaid;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblErrorFineID;
        private System.Windows.Forms.Label lblErrorLoanID;
        private System.Windows.Forms.Label lblErrorAmount;
        private System.Windows.Forms.Label lblErrorReason;
        private System.Windows.Forms.Button btnBack;
    }
}