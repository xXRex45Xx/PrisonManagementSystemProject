
namespace PrisonManagementSystemProjectv0
{
    partial class NewPrisonerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPrisonerForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbCell = new System.Windows.Forms.ComboBox();
            this.lblBlock = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbCases = new System.Windows.Forms.GroupBox();
            this.btnRegisterCase = new System.Windows.Forms.Button();
            this.chkMultipleCase = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYearDecided = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDateOfVerdict = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDateOfCrime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCrimeType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCaseNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbCases.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(431, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 34);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(266, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 34);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Register";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbCell
            // 
            this.cmbCell.FormattingEnabled = true;
            this.cmbCell.Location = new System.Drawing.Point(9, 334);
            this.cmbCell.Name = "cmbCell";
            this.cmbCell.Size = new System.Drawing.Size(138, 21);
            this.cmbCell.TabIndex = 31;
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock.Location = new System.Drawing.Point(6, 316);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(81, 15);
            this.lblBlock.TabIndex = 30;
            this.lblBlock.Text = "Assigned Cell";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Date of Birth";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(9, 291);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2021, 8, 22, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 28;
            this.dtpDateOfBirth.Value = new System.DateTime(2021, 8, 22, 0, 0, 0, 0);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(9, 232);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(457, 22);
            this.txtAddress.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(9, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(457, 22);
            this.txtEmail.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(9, 106);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(457, 22);
            this.txtPhoneNumber.TabIndex = 23;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(254, 33);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(212, 22);
            this.txtLastName.TabIndex = 19;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(9, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 22);
            this.txtFirstName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Prisoner Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCell);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblBlock);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDateOfBirth);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 361);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prisoner Information";
            // 
            // gbCases
            // 
            this.gbCases.Controls.Add(this.btnRegisterCase);
            this.gbCases.Controls.Add(this.chkMultipleCase);
            this.gbCases.Controls.Add(this.label12);
            this.gbCases.Controls.Add(this.txtYearDecided);
            this.gbCases.Controls.Add(this.label11);
            this.gbCases.Controls.Add(this.dtpDateOfVerdict);
            this.gbCases.Controls.Add(this.label10);
            this.gbCases.Controls.Add(this.dtpDateOfCrime);
            this.gbCases.Controls.Add(this.label9);
            this.gbCases.Controls.Add(this.txtCrimeType);
            this.gbCases.Controls.Add(this.label8);
            this.gbCases.Controls.Add(this.txtCaseNumber);
            this.gbCases.Location = new System.Drawing.Point(492, 12);
            this.gbCases.Name = "gbCases";
            this.gbCases.Size = new System.Drawing.Size(402, 361);
            this.gbCases.TabIndex = 35;
            this.gbCases.TabStop = false;
            this.gbCases.Text = "Case";
            // 
            // btnRegisterCase
            // 
            this.btnRegisterCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRegisterCase.FlatAppearance.BorderSize = 0;
            this.btnRegisterCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCase.ForeColor = System.Drawing.Color.White;
            this.btnRegisterCase.Location = new System.Drawing.Point(160, 321);
            this.btnRegisterCase.Name = "btnRegisterCase";
            this.btnRegisterCase.Size = new System.Drawing.Size(121, 34);
            this.btnRegisterCase.TabIndex = 36;
            this.btnRegisterCase.Text = "Register Case";
            this.btnRegisterCase.UseVisualStyleBackColor = false;
            this.btnRegisterCase.Visible = false;
            this.btnRegisterCase.Click += new System.EventHandler(this.btnRegisterCase_Click);
            // 
            // chkMultipleCase
            // 
            this.chkMultipleCase.AutoSize = true;
            this.chkMultipleCase.Location = new System.Drawing.Point(202, 294);
            this.chkMultipleCase.Name = "chkMultipleCase";
            this.chkMultipleCase.Size = new System.Drawing.Size(89, 17);
            this.chkMultipleCase.TabIndex = 36;
            this.chkMultipleCase.Text = "Multiple Case";
            this.chkMultipleCase.UseVisualStyleBackColor = true;
            this.chkMultipleCase.CheckedChanged += new System.EventHandler(this.chkMultipleCase_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Years Decided";
            // 
            // txtYearDecided
            // 
            this.txtYearDecided.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearDecided.Location = new System.Drawing.Point(9, 290);
            this.txtYearDecided.Name = "txtYearDecided";
            this.txtYearDecided.Size = new System.Drawing.Size(159, 22);
            this.txtYearDecided.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "Date of Verdict";
            // 
            // dtpDateOfVerdict
            // 
            this.dtpDateOfVerdict.Location = new System.Drawing.Point(9, 231);
            this.dtpDateOfVerdict.MaxDate = new System.DateTime(2021, 8, 26, 0, 0, 0, 0);
            this.dtpDateOfVerdict.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfVerdict.Name = "dtpDateOfVerdict";
            this.dtpDateOfVerdict.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfVerdict.TabIndex = 32;
            this.dtpDateOfVerdict.Value = new System.DateTime(2021, 8, 22, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Date of Crime";
            // 
            // dtpDateOfCrime
            // 
            this.dtpDateOfCrime.Location = new System.Drawing.Point(9, 171);
            this.dtpDateOfCrime.MaxDate = new System.DateTime(2021, 9, 12, 0, 0, 0, 0);
            this.dtpDateOfCrime.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfCrime.Name = "dtpDateOfCrime";
            this.dtpDateOfCrime.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfCrime.TabIndex = 30;
            this.dtpDateOfCrime.Value = new System.DateTime(2021, 8, 22, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Crime Type";
            // 
            // txtCrimeType
            // 
            this.txtCrimeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrimeType.Location = new System.Drawing.Point(9, 105);
            this.txtCrimeType.Name = "txtCrimeType";
            this.txtCrimeType.Size = new System.Drawing.Size(363, 22);
            this.txtCrimeType.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Case Number";
            // 
            // txtCaseNumber
            // 
            this.txtCaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaseNumber.Location = new System.Drawing.Point(13, 33);
            this.txtCaseNumber.Name = "txtCaseNumber";
            this.txtCaseNumber.Size = new System.Drawing.Size(159, 22);
            this.txtCaseNumber.TabIndex = 20;
            this.txtCaseNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaseNumber_KeyPress);
            // 
            // NewPrisonerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 441);
            this.Controls.Add(this.gbCases);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPrisonerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Prisoner";
            this.Shown += new System.EventHandler(this.NewPrisonerForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCases.ResumeLayout(false);
            this.gbCases.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbCell;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbCases;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtYearDecided;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDateOfVerdict;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDateOfCrime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCrimeType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCaseNumber;
        private System.Windows.Forms.CheckBox chkMultipleCase;
        private System.Windows.Forms.Button btnRegisterCase;
    }
}