
namespace PrisonManagementSystemProjectv0
{
    partial class NewEmployeeForm
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
            this.lblBlock = new System.Windows.Forms.Label();
            this.cmbBlock = new System.Windows.Forms.ComboBox();
            this.cmdYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRegister = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gBoxRole = new System.Windows.Forms.GroupBox();
            this.rBtnDoctor = new System.Windows.Forms.RadioButton();
            this.rBtnReception = new System.Windows.Forms.RadioButton();
            this.rBtnGuard = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gBoxRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBlock
            // 
            this.lblBlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBlock.AutoSize = true;
            this.lblBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblBlock.Location = new System.Drawing.Point(142, 361);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(96, 15);
            this.lblBlock.TabIndex = 18;
            this.lblBlock.Text = "Asssigned Block";
            this.lblBlock.Visible = false;
            // 
            // cmbBlock
            // 
            this.cmbBlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cmbBlock.FormattingEnabled = true;
            this.cmbBlock.Location = new System.Drawing.Point(142, 379);
            this.cmbBlock.Name = "cmbBlock";
            this.cmbBlock.Size = new System.Drawing.Size(121, 21);
            this.cmbBlock.TabIndex = 9;
            this.cmbBlock.Visible = false;
            // 
            // cmdYear
            // 
            this.cmdYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cmdYear.FormattingEnabled = true;
            this.cmdYear.Location = new System.Drawing.Point(209, 279);
            this.cmdYear.Name = "cmdYear";
            this.cmdYear.Size = new System.Drawing.Size(108, 21);
            this.cmdYear.TabIndex = 7;
            this.cmdYear.Text = "Year";
            // 
            // cmbMonth
            // 
            this.cmbMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April ",
            "May",
            "June ",
            "July",
            "August",
            "September ",
            "October ",
            "November ",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(67, 279);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(135, 21);
            this.cmbMonth.TabIndex = 6;
            this.cmbMonth.Text = "Month";
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // cmbDay
            // 
            this.cmbDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDay.Location = new System.Drawing.Point(15, 279);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDay.Size = new System.Drawing.Size(46, 21);
            this.cmbDay.TabIndex = 5;
            this.cmbDay.Text = "Day";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(11, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtAddress.Location = new System.Drawing.Point(14, 238);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(302, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtEmail.Location = new System.Drawing.Point(14, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(302, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtPhoneNo.Location = new System.Drawing.Point(15, 156);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(302, 20);
            this.txtPhoneNo.TabIndex = 2;
            this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtLastName.Location = new System.Drawing.Point(15, 115);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(302, 20);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Leave += new System.EventHandler(this.ValidateAndCaptializeNames);
            // 
            // lblFName
            // 
            this.lblFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblFName.Location = new System.Drawing.Point(12, 56);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(67, 15);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtFirstName.Location = new System.Drawing.Point(15, 74);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(302, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Leave += new System.EventHandler(this.ValidateAndCaptializeNames);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(90, 436);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(148, 35);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label7.Location = new System.Drawing.Point(63, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Employee Registeration";
            // 
            // gBoxRole
            // 
            this.gBoxRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBoxRole.Controls.Add(this.rBtnDoctor);
            this.gBoxRole.Controls.Add(this.rBtnReception);
            this.gBoxRole.Controls.Add(this.rBtnGuard);
            this.gBoxRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.gBoxRole.Location = new System.Drawing.Point(15, 307);
            this.gBoxRole.Name = "gBoxRole";
            this.gBoxRole.Size = new System.Drawing.Size(121, 93);
            this.gBoxRole.TabIndex = 20;
            this.gBoxRole.TabStop = false;
            this.gBoxRole.Text = "Role";
            // 
            // rBtnDoctor
            // 
            this.rBtnDoctor.AutoSize = true;
            this.rBtnDoctor.Location = new System.Drawing.Point(7, 68);
            this.rBtnDoctor.Name = "rBtnDoctor";
            this.rBtnDoctor.Size = new System.Drawing.Size(61, 19);
            this.rBtnDoctor.TabIndex = 2;
            this.rBtnDoctor.TabStop = true;
            this.rBtnDoctor.Text = "Doctor";
            this.rBtnDoctor.UseVisualStyleBackColor = true;
            // 
            // rBtnReception
            // 
            this.rBtnReception.AutoSize = true;
            this.rBtnReception.Location = new System.Drawing.Point(7, 44);
            this.rBtnReception.Name = "rBtnReception";
            this.rBtnReception.Size = new System.Drawing.Size(81, 19);
            this.rBtnReception.TabIndex = 1;
            this.rBtnReception.TabStop = true;
            this.rBtnReception.Text = "Reception";
            this.rBtnReception.UseVisualStyleBackColor = true;
            // 
            // rBtnGuard
            // 
            this.rBtnGuard.AutoSize = true;
            this.rBtnGuard.Location = new System.Drawing.Point(7, 20);
            this.rBtnGuard.Name = "rBtnGuard";
            this.rBtnGuard.Size = new System.Drawing.Size(59, 19);
            this.rBtnGuard.TabIndex = 0;
            this.rBtnGuard.TabStop = true;
            this.rBtnGuard.Text = "Guard";
            this.rBtnGuard.UseVisualStyleBackColor = true;
            this.rBtnGuard.CheckedChanged += new System.EventHandler(this.rBtnGuard_CheckedChanged);
            // 
            // NewEmployeeForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(346, 524);
            this.Controls.Add(this.gBoxRole);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdYear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBlock);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtEmail);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewEmployeeForm";
            this.Text = "NewEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gBoxRole.ResumeLayout(false);
            this.gBoxRole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmdYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.ComboBox cmbBlock;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gBoxRole;
        private System.Windows.Forms.RadioButton rBtnDoctor;
        private System.Windows.Forms.RadioButton rBtnReception;
        private System.Windows.Forms.RadioButton rBtnGuard;
    }
}