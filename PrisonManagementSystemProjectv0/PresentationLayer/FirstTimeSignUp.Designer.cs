
namespace PrisonManagementSystemProjectv0
{
    partial class FirstTimeSignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTimeSignUpForm));
            this.ilstPwdVisibility = new System.Windows.Forms.ImageList(this.components);
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtCPwd = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SignUpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPMS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlConfirmPwd = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ibtnPwdVisibility = new System.Windows.Forms.Button();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.pnlPwd = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpError)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlConfirmPwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlPwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ilstPwdVisibility
            // 
            this.ilstPwdVisibility.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstPwdVisibility.ImageStream")));
            this.ilstPwdVisibility.TransparentColor = System.Drawing.Color.Transparent;
            this.ilstPwdVisibility.Images.SetKeyName(0, "hide.png");
            this.ilstPwdVisibility.Images.SetKeyName(1, "show.png");
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(136, 377);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(148, 35);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtCPwd
            // 
            this.txtCPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPwd.ForeColor = System.Drawing.Color.Gray;
            this.txtCPwd.Location = new System.Drawing.Point(36, 14);
            this.txtCPwd.Name = "txtCPwd";
            this.txtCPwd.Size = new System.Drawing.Size(329, 19);
            this.txtCPwd.TabIndex = 4;
            this.txtCPwd.Text = "Confirm Password";
            this.txtCPwd.Enter += new System.EventHandler(this.txtCPwd_Enter);
            this.txtCPwd.Leave += new System.EventHandler(this.txtCPwd_Leave);
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.ForeColor = System.Drawing.Color.Gray;
            this.txtPwd.Location = new System.Drawing.Point(36, 13);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(329, 19);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.Text = "Password";
            this.txtPwd.Enter += new System.EventHandler(this.txtPwd_Enter);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(36, 15);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(329, 19);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "Username";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            // 
            // SignUpError
            // 
            this.SignUpError.ContainerControl = this;
            this.SignUpError.Icon = ((System.Drawing.Icon)(resources.GetObject("SignUpError.Icon")));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblPMS);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 491);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "System";
            // 
            // lblPMS
            // 
            this.lblPMS.AutoSize = true;
            this.lblPMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMS.Location = new System.Drawing.Point(58, 237);
            this.lblPMS.Name = "lblPMS";
            this.lblPMS.Size = new System.Drawing.Size(221, 25);
            this.lblPMS.TabIndex = 3;
            this.lblPMS.Text = "Prison Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PrisonManagementSystemProjectv0.Properties.Resources.prison_building_120px;
            this.pictureBox1.Location = new System.Drawing.Point(95, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlConfirmPwd);
            this.panel3.Controls.Add(this.btnSignUp);
            this.panel3.Controls.Add(this.lblSignUp);
            this.panel3.Controls.Add(this.pnlPwd);
            this.panel3.Controls.Add(this.pnlUserName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 491);
            this.panel3.TabIndex = 4;
            // 
            // pnlConfirmPwd
            // 
            this.pnlConfirmPwd.BackColor = System.Drawing.Color.White;
            this.pnlConfirmPwd.Controls.Add(this.pictureBox4);
            this.pnlConfirmPwd.Controls.Add(this.ibtnPwdVisibility);
            this.pnlConfirmPwd.Controls.Add(this.txtCPwd);
            this.pnlConfirmPwd.Location = new System.Drawing.Point(6, 307);
            this.pnlConfirmPwd.Name = "pnlConfirmPwd";
            this.pnlConfirmPwd.Size = new System.Drawing.Size(403, 45);
            this.pnlConfirmPwd.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.checked_24px;
            this.pictureBox4.Location = new System.Drawing.Point(6, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // ibtnPwdVisibility
            // 
            this.ibtnPwdVisibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnPwdVisibility.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnPwdVisibility.FlatAppearance.BorderSize = 0;
            this.ibtnPwdVisibility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ibtnPwdVisibility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ibtnPwdVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnPwdVisibility.ImageIndex = 0;
            this.ibtnPwdVisibility.ImageList = this.ilstPwdVisibility;
            this.ibtnPwdVisibility.Location = new System.Drawing.Point(371, 15);
            this.ibtnPwdVisibility.Name = "ibtnPwdVisibility";
            this.ibtnPwdVisibility.Size = new System.Drawing.Size(25, 20);
            this.ibtnPwdVisibility.TabIndex = 8;
            this.ibtnPwdVisibility.TabStop = false;
            this.ibtnPwdVisibility.UseVisualStyleBackColor = true;
            this.ibtnPwdVisibility.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ibtnPwdVisibility_MouseDown);
            this.ibtnPwdVisibility.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ibtnPwdVisibility_MouseUp);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblSignUp.Location = new System.Drawing.Point(112, 96);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(195, 25);
            this.lblSignUp.TabIndex = 0;
            this.lblSignUp.Text = "First Time Sign Up ";
            // 
            // pnlPwd
            // 
            this.pnlPwd.BackColor = System.Drawing.Color.White;
            this.pnlPwd.Controls.Add(this.pictureBox3);
            this.pnlPwd.Controls.Add(this.txtPwd);
            this.pnlPwd.Location = new System.Drawing.Point(6, 246);
            this.pnlPwd.Name = "pnlPwd";
            this.pnlPwd.Size = new System.Drawing.Size(403, 45);
            this.pnlPwd.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.sign_in_form_password_24px;
            this.pictureBox3.Location = new System.Drawing.Point(6, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pnlUserName
            // 
            this.pnlUserName.BackColor = System.Drawing.Color.White;
            this.pnlUserName.Controls.Add(this.pictureBox2);
            this.pnlUserName.Controls.Add(this.txtUserName);
            this.pnlUserName.Location = new System.Drawing.Point(6, 185);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(403, 45);
            this.pnlUserName.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // FirstTimeSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 491);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstTimeSignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.SignUpError)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlConfirmPwd.ResumeLayout(false);
            this.pnlConfirmPwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlPwd.ResumeLayout(false);
            this.pnlPwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlUserName.ResumeLayout(false);
            this.pnlUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button ibtnPwdVisibility;
        private System.Windows.Forms.ErrorProvider SignUpError;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlPwd;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Panel pnlConfirmPwd;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ImageList ilstPwdVisibility;
    }
}