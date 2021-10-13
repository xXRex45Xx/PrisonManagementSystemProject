
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEmployeeForm));
            this.lblBlock = new System.Windows.Forms.Label();
            this.cmbBlock = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.errEmptyField = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRegister = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gBoxRole = new System.Windows.Forms.GroupBox();
            this.rBtnDoctor = new System.Windows.Forms.RadioButton();
            this.rBtnReception = new System.Windows.Forms.RadioButton();
            this.rBtnGuard = new System.Windows.Forms.RadioButton();
            this.pnlFirstName = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.pnlLastName = new System.Windows.Forms.Panel();
            this.pnlPhoneNo = new System.Windows.Forms.Panel();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errEmptyField)).BeginInit();
            this.gBoxRole.SuspendLayout();
            this.pnlFirstName.SuspendLayout();
            this.pnlLastName.SuspendLayout();
            this.pnlPhoneNo.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBlock
            // 
            this.lblBlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBlock.AutoSize = true;
            this.lblBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblBlock.Location = new System.Drawing.Point(179, 518);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(96, 15);
            this.lblBlock.TabIndex = 18;
            this.lblBlock.Text = "Asssigned Block";
            this.lblBlock.Visible = false;
            // 
            // cmbBlock
            // 
            this.cmbBlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cmbBlock.FormattingEnabled = true;
            this.cmbBlock.Location = new System.Drawing.Point(182, 536);
            this.cmbBlock.Name = "cmbBlock";
            this.cmbBlock.Size = new System.Drawing.Size(192, 26);
            this.cmbBlock.TabIndex = 9;
            this.cmbBlock.Visible = false;
            // 
            // cmbYear
            // 
            this.cmbYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(43, 419);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbYear.Size = new System.Drawing.Size(94, 26);
            this.cmbYear.TabIndex = 7;
            this.cmbYear.Text = "Year";
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbMonth.Location = new System.Drawing.Point(143, 419);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(135, 26);
            this.cmbMonth.TabIndex = 6;
            this.cmbMonth.Text = "Month";
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(40, 401);
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
            this.label4.Location = new System.Drawing.Point(40, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address(Optional)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(375, 121);
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
            this.label2.Location = new System.Drawing.Point(40, 158);
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
            this.label1.Location = new System.Drawing.Point(40, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtAddress.Location = new System.Drawing.Point(3, 8);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(637, 17);
            this.txtAddress.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtEmail.Location = new System.Drawing.Point(3, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(637, 17);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtPhoneNo.Location = new System.Drawing.Point(3, 8);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(636, 17);
            this.txtPhoneNo.TabIndex = 2;
            this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
            // 
            // lblFName
            // 
            this.lblFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblFName.Location = new System.Drawing.Point(40, 121);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(67, 15);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtFirstName.Location = new System.Drawing.Point(3, 8);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(304, 17);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Leave += new System.EventHandler(this.ValidateAndCaptializeNames);
            // 
            // errEmptyField
            // 
            this.errEmptyField.ContainerControl = this;
            this.errEmptyField.Icon = ((System.Drawing.Icon)(resources.GetObject("errEmptyField.Icon")));
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(194, 598);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(280, 38);
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
            this.label7.Location = new System.Drawing.Point(242, 23);
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
            this.gBoxRole.Location = new System.Drawing.Point(43, 463);
            this.gBoxRole.Name = "gBoxRole";
            this.gBoxRole.Size = new System.Drawing.Size(116, 99);
            this.gBoxRole.TabIndex = 20;
            this.gBoxRole.TabStop = false;
            this.gBoxRole.Text = "Role";
            // 
            // rBtnDoctor
            // 
            this.rBtnDoctor.AutoSize = true;
            this.rBtnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnDoctor.Location = new System.Drawing.Point(7, 68);
            this.rBtnDoctor.Name = "rBtnDoctor";
            this.rBtnDoctor.Size = new System.Drawing.Size(72, 22);
            this.rBtnDoctor.TabIndex = 2;
            this.rBtnDoctor.TabStop = true;
            this.rBtnDoctor.Text = "Doctor";
            this.rBtnDoctor.UseVisualStyleBackColor = true;
            // 
            // rBtnReception
            // 
            this.rBtnReception.AutoSize = true;
            this.rBtnReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnReception.Location = new System.Drawing.Point(7, 44);
            this.rBtnReception.Name = "rBtnReception";
            this.rBtnReception.Size = new System.Drawing.Size(93, 22);
            this.rBtnReception.TabIndex = 1;
            this.rBtnReception.TabStop = true;
            this.rBtnReception.Text = "Reception";
            this.rBtnReception.UseVisualStyleBackColor = true;
            // 
            // rBtnGuard
            // 
            this.rBtnGuard.AutoSize = true;
            this.rBtnGuard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnGuard.Location = new System.Drawing.Point(7, 20);
            this.rBtnGuard.Name = "rBtnGuard";
            this.rBtnGuard.Size = new System.Drawing.Size(67, 22);
            this.rBtnGuard.TabIndex = 0;
            this.rBtnGuard.TabStop = true;
            this.rBtnGuard.Text = "Guard";
            this.rBtnGuard.UseVisualStyleBackColor = true;
            this.rBtnGuard.CheckedChanged += new System.EventHandler(this.rBtnGuard_CheckedChanged);
            // 
            // pnlFirstName
            // 
            this.pnlFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFirstName.BackColor = System.Drawing.Color.White;
            this.pnlFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFirstName.Controls.Add(this.txtFirstName);
            this.pnlFirstName.Location = new System.Drawing.Point(43, 80);
            this.pnlFirstName.Name = "pnlFirstName";
            this.pnlFirstName.Size = new System.Drawing.Size(314, 38);
            this.pnlFirstName.TabIndex = 21;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtLastName.Location = new System.Drawing.Point(3, 8);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(302, 17);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Leave += new System.EventHandler(this.ValidateAndCaptializeNames);
            // 
            // pnlLastName
            // 
            this.pnlLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLastName.BackColor = System.Drawing.Color.White;
            this.pnlLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLastName.Controls.Add(this.txtLastName);
            this.pnlLastName.Location = new System.Drawing.Point(378, 80);
            this.pnlLastName.Name = "pnlLastName";
            this.pnlLastName.Size = new System.Drawing.Size(314, 38);
            this.pnlLastName.TabIndex = 22;
            // 
            // pnlPhoneNo
            // 
            this.pnlPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPhoneNo.BackColor = System.Drawing.Color.White;
            this.pnlPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPhoneNo.Controls.Add(this.txtPhoneNo);
            this.pnlPhoneNo.Location = new System.Drawing.Point(44, 176);
            this.pnlPhoneNo.Name = "pnlPhoneNo";
            this.pnlPhoneNo.Size = new System.Drawing.Size(649, 38);
            this.pnlPhoneNo.TabIndex = 23;
            // 
            // pnlEmail
            // 
            this.pnlEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEmail.BackColor = System.Drawing.Color.White;
            this.pnlEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Location = new System.Drawing.Point(44, 264);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(649, 38);
            this.pnlEmail.TabIndex = 24;
            // 
            // pnlAddress
            // 
            this.pnlAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAddress.BackColor = System.Drawing.Color.White;
            this.pnlAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddress.Controls.Add(this.txtAddress);
            this.pnlAddress.Location = new System.Drawing.Point(43, 348);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(649, 38);
            this.pnlAddress.TabIndex = 25;
            // 
            // cmbDay
            // 
            this.cmbDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDay.DropDownHeight = 200;
            this.cmbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.IntegralHeight = false;
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
            this.cmbDay.Location = new System.Drawing.Point(284, 419);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDay.Size = new System.Drawing.Size(73, 26);
            this.cmbDay.TabIndex = 5;
            this.cmbDay.Text = "Day";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Employee Name";
            // 
            // NewEmployeeForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(714, 673);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.pnlAddress);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.pnlPhoneNo);
            this.Controls.Add(this.pnlLastName);
            this.Controls.Add(this.pnlFirstName);
            this.Controls.Add(this.gBoxRole);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBlock);
            this.Controls.Add(this.cmbMonth);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewEmployeeForm";
            this.Text = "NewEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.errEmptyField)).EndInit();
            this.gBoxRole.ResumeLayout(false);
            this.gBoxRole.PerformLayout();
            this.pnlFirstName.ResumeLayout(false);
            this.pnlFirstName.PerformLayout();
            this.pnlLastName.ResumeLayout(false);
            this.pnlLastName.PerformLayout();
            this.pnlPhoneNo.ResumeLayout(false);
            this.pnlPhoneNo.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
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
        private System.Windows.Forms.ErrorProvider errEmptyField;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.ComboBox cmbBlock;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gBoxRole;
        private System.Windows.Forms.RadioButton rBtnDoctor;
        private System.Windows.Forms.RadioButton rBtnReception;
        private System.Windows.Forms.RadioButton rBtnGuard;
        private System.Windows.Forms.Panel pnlFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Panel pnlLastName;
        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Panel pnlPhoneNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDay;
    }
}