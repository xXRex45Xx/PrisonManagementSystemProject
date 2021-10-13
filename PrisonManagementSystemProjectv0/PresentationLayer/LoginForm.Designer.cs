
namespace PrisonManagementSystemProjectv0
{
    partial class NewLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPMS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlPwd = new System.Windows.Forms.Panel();
            this.btnPwdVisibility = new System.Windows.Forms.Button();
            this.ilstPwdVisibility = new System.Windows.Forms.ImageList(this.components);
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.errEmptyFields = new System.Windows.Forms.ErrorProvider(this.components);
            this.errIncorrectCred = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlPwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmptyFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIncorrectCred)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPMS);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 491);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(300, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 45);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "System";
            // 
            // lblPMS
            // 
            this.lblPMS.AutoSize = true;
            this.lblPMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMS.Location = new System.Drawing.Point(58, 237);
            this.lblPMS.Name = "lblPMS";
            this.lblPMS.Size = new System.Drawing.Size(221, 25);
            this.lblPMS.TabIndex = 1;
            this.lblPMS.Text = "Prison Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PrisonManagementSystemProjectv0.Properties.Resources.prison_building_120px;
            this.pictureBox1.Location = new System.Drawing.Point(95, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.pnlPwd);
            this.panel2.Controls.Add(this.pnlUserName);
            this.panel2.Controls.Add(this.lblLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 491);
            this.panel2.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(145, 315);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(148, 35);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlPwd
            // 
            this.pnlPwd.BackColor = System.Drawing.Color.White;
            this.pnlPwd.Controls.Add(this.btnPwdVisibility);
            this.pnlPwd.Controls.Add(this.txtPwd);
            this.pnlPwd.Controls.Add(this.pictureBox3);
            this.pnlPwd.Location = new System.Drawing.Point(6, 246);
            this.pnlPwd.Name = "pnlPwd";
            this.pnlPwd.Size = new System.Drawing.Size(403, 45);
            this.pnlPwd.TabIndex = 2;
            // 
            // btnPwdVisibility
            // 
            this.btnPwdVisibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPwdVisibility.FlatAppearance.BorderSize = 0;
            this.btnPwdVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPwdVisibility.ImageIndex = 0;
            this.btnPwdVisibility.ImageList = this.ilstPwdVisibility;
            this.btnPwdVisibility.Location = new System.Drawing.Point(375, 10);
            this.btnPwdVisibility.Name = "btnPwdVisibility";
            this.btnPwdVisibility.Size = new System.Drawing.Size(25, 25);
            this.btnPwdVisibility.TabIndex = 4;
            this.btnPwdVisibility.TabStop = false;
            this.btnPwdVisibility.UseVisualStyleBackColor = true;
            this.btnPwdVisibility.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPwdVisibility_MouseDown);
            this.btnPwdVisibility.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPwdVisibility_MouseUp);
            // 
            // ilstPwdVisibility
            // 
            this.ilstPwdVisibility.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstPwdVisibility.ImageStream")));
            this.ilstPwdVisibility.TransparentColor = System.Drawing.Color.Transparent;
            this.ilstPwdVisibility.Images.SetKeyName(0, "hide_24px.png");
            this.ilstPwdVisibility.Images.SetKeyName(1, "show_24px.png");
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.ForeColor = System.Drawing.Color.Gray;
            this.txtPwd.Location = new System.Drawing.Point(40, 15);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(329, 19);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.Text = "Password";
            this.txtPwd.Enter += new System.EventHandler(this.txtPwd_Enter);
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
            this.pnlUserName.Controls.Add(this.txtUserName);
            this.pnlUserName.Controls.Add(this.pictureBox2);
            this.pnlUserName.Location = new System.Drawing.Point(6, 185);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(403, 45);
            this.pnlUserName.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(40, 15);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(329, 19);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "Username";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
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
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblLogin.Location = new System.Drawing.Point(157, 101);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(121, 25);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login Page";
            // 
            // errEmptyFields
            // 
            this.errEmptyFields.ContainerControl = this;
            this.errEmptyFields.Icon = ((System.Drawing.Icon)(resources.GetObject("errEmptyFields.Icon")));
            // 
            // errIncorrectCred
            // 
            this.errIncorrectCred.ContainerControl = this;
            this.errIncorrectCred.Icon = ((System.Drawing.Icon)(resources.GetObject("errIncorrectCred.Icon")));
            // 
            // NewLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPwd.ResumeLayout(false);
            this.pnlPwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlUserName.ResumeLayout(false);
            this.pnlUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmptyFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIncorrectCred)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPMS;
        private System.Windows.Forms.Panel pnlUserName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel pnlPwd;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ImageList ilstPwdVisibility;
        private System.Windows.Forms.Button btnPwdVisibility;
        private System.Windows.Forms.ErrorProvider errEmptyFields;
        private System.Windows.Forms.ErrorProvider errIncorrectCred;
    }
}