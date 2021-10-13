
namespace PrisonManagementSystemProjectv0
{
    partial class UpdateTreatmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTreatmentForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbDateTime = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDoctorLastName = new System.Windows.Forms.Label();
            this.lblDoctorFirstName = new System.Windows.Forms.Label();
            this.lblDoctorNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbPrisonerInfo = new System.Windows.Forms.GroupBox();
            this.lblPrisonerLastName = new System.Windows.Forms.Label();
            this.lblPrisosnerFirstName = new System.Windows.Forms.Label();
            this.lblPrisonerNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDateTime.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbPrisonerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(389, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 34);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(222, 305);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 34);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbDateTime
            // 
            this.gbDateTime.Controls.Add(this.dtpTime);
            this.gbDateTime.Controls.Add(this.dtpDate);
            this.gbDateTime.Controls.Add(this.label12);
            this.gbDateTime.Controls.Add(this.label11);
            this.gbDateTime.Enabled = false;
            this.gbDateTime.Location = new System.Drawing.Point(11, 168);
            this.gbDateTime.Name = "gbDateTime";
            this.gbDateTime.Size = new System.Drawing.Size(360, 131);
            this.gbDateTime.TabIndex = 40;
            this.gbDateTime.TabStop = false;
            this.gbDateTime.Text = "Date and Time";
            // 
            // dtpTime
            // 
            this.dtpTime.Enabled = false;
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(9, 93);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(86, 20);
            this.dtpTime.TabIndex = 3;
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(9, 44);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(389, 181);
            this.txtDiagnosis.MaxLength = 100;
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(357, 118);
            this.txtDiagnosis.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Diagnosis";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDoctorLastName);
            this.groupBox1.Controls.Add(this.lblDoctorFirstName);
            this.groupBox1.Controls.Add(this.lblDoctorNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(389, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 150);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // lblDoctorLastName
            // 
            this.lblDoctorLastName.AutoSize = true;
            this.lblDoctorLastName.Location = new System.Drawing.Point(150, 89);
            this.lblDoctorLastName.Name = "lblDoctorLastName";
            this.lblDoctorLastName.Size = new System.Drawing.Size(0, 13);
            this.lblDoctorLastName.TabIndex = 5;
            // 
            // lblDoctorFirstName
            // 
            this.lblDoctorFirstName.AutoSize = true;
            this.lblDoctorFirstName.Location = new System.Drawing.Point(150, 62);
            this.lblDoctorFirstName.Name = "lblDoctorFirstName";
            this.lblDoctorFirstName.Size = new System.Drawing.Size(0, 13);
            this.lblDoctorFirstName.TabIndex = 4;
            // 
            // lblDoctorNumber
            // 
            this.lblDoctorNumber.AutoSize = true;
            this.lblDoctorNumber.Location = new System.Drawing.Point(150, 34);
            this.lblDoctorNumber.Name = "lblDoctorNumber";
            this.lblDoctorNumber.Size = new System.Drawing.Size(0, 13);
            this.lblDoctorNumber.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Doctor Number:";
            // 
            // gbPrisonerInfo
            // 
            this.gbPrisonerInfo.Controls.Add(this.lblPrisonerLastName);
            this.gbPrisonerInfo.Controls.Add(this.lblPrisosnerFirstName);
            this.gbPrisonerInfo.Controls.Add(this.lblPrisonerNumber);
            this.gbPrisonerInfo.Controls.Add(this.label3);
            this.gbPrisonerInfo.Controls.Add(this.label2);
            this.gbPrisonerInfo.Controls.Add(this.label1);
            this.gbPrisonerInfo.Location = new System.Drawing.Point(12, 12);
            this.gbPrisonerInfo.Name = "gbPrisonerInfo";
            this.gbPrisonerInfo.Size = new System.Drawing.Size(360, 150);
            this.gbPrisonerInfo.TabIndex = 36;
            this.gbPrisonerInfo.TabStop = false;
            this.gbPrisonerInfo.Text = "Prisoner Information";
            // 
            // lblPrisonerLastName
            // 
            this.lblPrisonerLastName.AutoSize = true;
            this.lblPrisonerLastName.Location = new System.Drawing.Point(150, 89);
            this.lblPrisonerLastName.Name = "lblPrisonerLastName";
            this.lblPrisonerLastName.Size = new System.Drawing.Size(0, 13);
            this.lblPrisonerLastName.TabIndex = 5;
            // 
            // lblPrisosnerFirstName
            // 
            this.lblPrisosnerFirstName.AutoSize = true;
            this.lblPrisosnerFirstName.Location = new System.Drawing.Point(150, 62);
            this.lblPrisosnerFirstName.Name = "lblPrisosnerFirstName";
            this.lblPrisosnerFirstName.Size = new System.Drawing.Size(0, 13);
            this.lblPrisosnerFirstName.TabIndex = 4;
            // 
            // lblPrisonerNumber
            // 
            this.lblPrisonerNumber.AutoSize = true;
            this.lblPrisonerNumber.Location = new System.Drawing.Point(150, 34);
            this.lblPrisonerNumber.Name = "lblPrisonerNumber";
            this.lblPrisonerNumber.Size = new System.Drawing.Size(0, 13);
            this.lblPrisonerNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prisoner Number:";
            // 
            // UpdateTreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 355);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbDateTime);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPrisonerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateTreatmentForm";
            this.Text = "UpdateTreatmentForm";
            this.Shown += new System.EventHandler(this.UpdateTreatmentForm_Shown);
            this.gbDateTime.ResumeLayout(false);
            this.gbDateTime.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPrisonerInfo.ResumeLayout(false);
            this.gbPrisonerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbDateTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDoctorLastName;
        private System.Windows.Forms.Label lblDoctorFirstName;
        private System.Windows.Forms.Label lblDoctorNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbPrisonerInfo;
        private System.Windows.Forms.Label lblPrisonerLastName;
        private System.Windows.Forms.Label lblPrisosnerFirstName;
        private System.Windows.Forms.Label lblPrisonerNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}