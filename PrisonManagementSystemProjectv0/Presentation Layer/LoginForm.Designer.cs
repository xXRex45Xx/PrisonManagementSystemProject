
namespace PrisonManagementSystemProjectv0
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ilstPwdVisibility = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPrisonPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPwdVisibility = new System.Windows.Forms.Button();
            this.errEmptyFields = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAuthenticationError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrisonPicture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEmptyFields)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserName.Location = new System.Drawing.Point(37, 11);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPwd.Location = new System.Drawing.Point(37, 61);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 13);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(40, 27);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(181, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(40, 77);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(181, 20);
            this.txtPwd.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(87, 118);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 29);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ilstPwdVisibility
            // 
            this.ilstPwdVisibility.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstPwdVisibility.ImageStream")));
            this.ilstPwdVisibility.TransparentColor = System.Drawing.Color.Transparent;
            this.ilstPwdVisibility.Images.SetKeyName(0, "hide.png");
            this.ilstPwdVisibility.Images.SetKeyName(1, "show.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.pbPrisonPicture);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 363);
            this.panel1.TabIndex = 9;
            // 
            // pbPrisonPicture
            // 
            this.pbPrisonPicture.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.prison_building_100px;
            this.pbPrisonPicture.Location = new System.Drawing.Point(98, 35);
            this.pbPrisonPicture.Name = "pbPrisonPicture";
            this.pbPrisonPicture.Size = new System.Drawing.Size(100, 113);
            this.pbPrisonPicture.TabIndex = 3;
            this.pbPrisonPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login Page ";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(23, 151);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(275, 24);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Prison Management System ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.btnPwdVisibility);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.lblPwd);
            this.panel2.Controls.Add(this.txtPwd);
            this.panel2.Location = new System.Drawing.Point(320, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 174);
            this.panel2.TabIndex = 10;
            // 
            // btnPwdVisibility
            // 
            this.btnPwdVisibility.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPwdVisibility.FlatAppearance.BorderSize = 0;
            this.btnPwdVisibility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPwdVisibility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPwdVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPwdVisibility.ImageIndex = 0;
            this.btnPwdVisibility.ImageList = this.ilstPwdVisibility;
            this.btnPwdVisibility.Location = new System.Drawing.Point(236, 76);
            this.btnPwdVisibility.Name = "btnPwdVisibility";
            this.btnPwdVisibility.Size = new System.Drawing.Size(26, 21);
            this.btnPwdVisibility.TabIndex = 7;
            this.btnPwdVisibility.TabStop = false;
            this.btnPwdVisibility.UseVisualStyleBackColor = true;
            this.btnPwdVisibility.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ibtnPwdVisibility_MouseDown);
            this.btnPwdVisibility.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ibtnPwdVisibility_MouseUp);
            // 
            // errEmptyFields
            // 
            this.errEmptyFields.ContainerControl = this;
            this.errEmptyFields.Icon = ((System.Drawing.Icon)(resources.GetObject("errEmptyFields.Icon")));
            // 
            // lblAuthenticationError
            // 
            this.lblAuthenticationError.AutoSize = true;
            this.lblAuthenticationError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthenticationError.Location = new System.Drawing.Point(317, 35);
            this.lblAuthenticationError.Name = "lblAuthenticationError";
            this.lblAuthenticationError.Size = new System.Drawing.Size(299, 13);
            this.lblAuthenticationError.TabIndex = 11;
            this.lblAuthenticationError.Text = "Incorrect Username or Password! Please Try Again.";
            this.lblAuthenticationError.Visible = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(670, 363);
            this.Controls.Add(this.lblAuthenticationError);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrisonPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEmptyFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ImageList ilstPwdVisibility;
        private System.Windows.Forms.Button btnPwdVisibility;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errEmptyFields;
        private System.Windows.Forms.Label lblAuthenticationError;
        private System.Windows.Forms.PictureBox pbPrisonPicture;
        private System.Windows.Forms.Label label1;
    }
}

