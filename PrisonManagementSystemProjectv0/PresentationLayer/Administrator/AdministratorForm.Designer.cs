
namespace PrisonManagementSystemProjectv0
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlReportSubMenu = new System.Windows.Forms.Panel();
            this.btnVisitorReports = new System.Windows.Forms.Button();
            this.btnDoctorReports = new System.Windows.Forms.Button();
            this.btnPrisonerReports = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlUserSubMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangeCredentials = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.pnlVisitorSubMenu = new System.Windows.Forms.Panel();
            this.btnAllVisitors = new System.Windows.Forms.Button();
            this.btnSearchVisitor = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.pnlPrisonerSubMenu = new System.Windows.Forms.Panel();
            this.btnAllPrisoner = new System.Windows.Forms.Button();
            this.btnSearchPrisoner = new System.Windows.Forms.Button();
            this.btnPrisoner = new System.Windows.Forms.Button();
            this.pnlEMSubMenu = new System.Windows.Forms.Panel();
            this.btnAllEmployee = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlReportSubMenu.SuspendLayout();
            this.pnlUserSubMenu.SuspendLayout();
            this.pnlVisitorSubMenu.SuspendLayout();
            this.pnlPrisonerSubMenu.SuspendLayout();
            this.pnlEMSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlBorder.Controls.Add(this.btnHomePage);
            this.pnlBorder.Controls.Add(this.lblFormName);
            this.pnlBorder.Controls.Add(this.btnMinimize);
            this.pnlBorder.Controls.Add(this.btnMaxMin);
            this.pnlBorder.Controls.Add(this.btnExit);
            this.pnlBorder.Controls.Add(this.lblAdmin);
            this.pnlBorder.Controls.Add(this.pictureBox1);
            this.pnlBorder.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.ForeColor = System.Drawing.Color.White;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1295, 75);
            this.pnlBorder.TabIndex = 1;
            this.pnlBorder.DoubleClick += new System.EventHandler(this.pnlBorder_DoubleClick);
            this.pnlBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnHomePage
            // 
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.home_page_30px;
            this.btnHomePage.Location = new System.Drawing.Point(220, 30);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(89, 45);
            this.btnHomePage.TabIndex = 12;
            this.btnHomePage.Text = "Home";
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // lblFormName
            // 
            this.lblFormName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.Location = new System.Drawing.Point(611, 23);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(72, 25);
            this.lblFormName.TabIndex = 5;
            this.lblFormName.Text = "Home";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.minimize_24px;
            this.btnMinimize.Location = new System.Drawing.Point(1190, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.maximize_button_19px;
            this.btnMaxMin.Location = new System.Drawing.Point(1227, 3);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(25, 25);
            this.btnMaxMin.TabIndex = 3;
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.exit_24px;
            this.btnExit.Location = new System.Drawing.Point(1264, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(82, 23);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(138, 25);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Administrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.admin_75px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlControls.Controls.Add(this.pnlReportSubMenu);
            this.pnlControls.Controls.Add(this.btnReport);
            this.pnlControls.Controls.Add(this.pnlUserSubMenu);
            this.pnlControls.Controls.Add(this.btnUser);
            this.pnlControls.Controls.Add(this.pnlVisitorSubMenu);
            this.pnlControls.Controls.Add(this.btnVisitor);
            this.pnlControls.Controls.Add(this.pnlPrisonerSubMenu);
            this.pnlControls.Controls.Add(this.btnPrisoner);
            this.pnlControls.Controls.Add(this.pnlEMSubMenu);
            this.pnlControls.Controls.Add(this.btnEmployee);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 75);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(220, 864);
            this.pnlControls.TabIndex = 0;
            this.pnlControls.MouseEnter += new System.EventHandler(this.pnlControls_MouseEnter);
            // 
            // pnlReportSubMenu
            // 
            this.pnlReportSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlReportSubMenu.Controls.Add(this.btnVisitorReports);
            this.pnlReportSubMenu.Controls.Add(this.btnDoctorReports);
            this.pnlReportSubMenu.Controls.Add(this.btnPrisonerReports);
            this.pnlReportSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportSubMenu.Location = new System.Drawing.Point(0, 555);
            this.pnlReportSubMenu.Name = "pnlReportSubMenu";
            this.pnlReportSubMenu.Size = new System.Drawing.Size(220, 135);
            this.pnlReportSubMenu.TabIndex = 14;
            this.pnlReportSubMenu.Visible = false;
            // 
            // btnVisitorReports
            // 
            this.btnVisitorReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisitorReports.FlatAppearance.BorderSize = 0;
            this.btnVisitorReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitorReports.ForeColor = System.Drawing.Color.White;
            this.btnVisitorReports.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.visitor_30px;
            this.btnVisitorReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitorReports.Location = new System.Drawing.Point(0, 90);
            this.btnVisitorReports.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnVisitorReports.Name = "btnVisitorReports";
            this.btnVisitorReports.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVisitorReports.Size = new System.Drawing.Size(220, 45);
            this.btnVisitorReports.TabIndex = 2;
            this.btnVisitorReports.Text = "     Visitor Report";
            this.btnVisitorReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitorReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisitorReports.UseVisualStyleBackColor = true;
            this.btnVisitorReports.Click += new System.EventHandler(this.btnVisitorReports_Click);
            // 
            // btnDoctorReports
            // 
            this.btnDoctorReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorReports.FlatAppearance.BorderSize = 0;
            this.btnDoctorReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorReports.ForeColor = System.Drawing.Color.White;
            this.btnDoctorReports.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.doctor_30px;
            this.btnDoctorReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorReports.Location = new System.Drawing.Point(0, 45);
            this.btnDoctorReports.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnDoctorReports.Name = "btnDoctorReports";
            this.btnDoctorReports.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDoctorReports.Size = new System.Drawing.Size(220, 45);
            this.btnDoctorReports.TabIndex = 1;
            this.btnDoctorReports.Text = "     Doctor Report";
            this.btnDoctorReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoctorReports.UseVisualStyleBackColor = true;
            this.btnDoctorReports.Click += new System.EventHandler(this.btnDoctorReports_Click);
            // 
            // btnPrisonerReports
            // 
            this.btnPrisonerReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrisonerReports.FlatAppearance.BorderSize = 0;
            this.btnPrisonerReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrisonerReports.ForeColor = System.Drawing.Color.White;
            this.btnPrisonerReports.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.prisoner_30px;
            this.btnPrisonerReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrisonerReports.Location = new System.Drawing.Point(0, 0);
            this.btnPrisonerReports.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnPrisonerReports.Name = "btnPrisonerReports";
            this.btnPrisonerReports.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPrisonerReports.Size = new System.Drawing.Size(220, 45);
            this.btnPrisonerReports.TabIndex = 0;
            this.btnPrisonerReports.Text = "     Prisoner Reports";
            this.btnPrisonerReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrisonerReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrisonerReports.UseVisualStyleBackColor = true;
            this.btnPrisonerReports.Click += new System.EventHandler(this.btnPrisonerReports_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.report_35px;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 495);
            this.btnReport.MinimumSize = new System.Drawing.Size(220, 60);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(220, 60);
            this.btnReport.TabIndex = 13;
            this.btnReport.Text = "   Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pnlUserSubMenu
            // 
            this.pnlUserSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlUserSubMenu.Controls.Add(this.btnLogout);
            this.pnlUserSubMenu.Controls.Add(this.btnChangeCredentials);
            this.pnlUserSubMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUserSubMenu.Location = new System.Drawing.Point(0, 714);
            this.pnlUserSubMenu.MinimumSize = new System.Drawing.Size(220, 90);
            this.pnlUserSubMenu.Name = "pnlUserSubMenu";
            this.pnlUserSubMenu.Size = new System.Drawing.Size(220, 90);
            this.pnlUserSubMenu.TabIndex = 12;
            this.pnlUserSubMenu.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.logout_30px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 45);
            this.btnLogout.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 45);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "     Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangeCredentials
            // 
            this.btnChangeCredentials.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeCredentials.FlatAppearance.BorderSize = 0;
            this.btnChangeCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeCredentials.ForeColor = System.Drawing.Color.White;
            this.btnChangeCredentials.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.change_credentials_30px;
            this.btnChangeCredentials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeCredentials.Location = new System.Drawing.Point(0, 0);
            this.btnChangeCredentials.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnChangeCredentials.Name = "btnChangeCredentials";
            this.btnChangeCredentials.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnChangeCredentials.Size = new System.Drawing.Size(220, 45);
            this.btnChangeCredentials.TabIndex = 2;
            this.btnChangeCredentials.Text = "     Change Credentials";
            this.btnChangeCredentials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeCredentials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeCredentials.UseVisualStyleBackColor = true;
            this.btnChangeCredentials.Click += new System.EventHandler(this.btnChangeCredentials_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.male_user_50px;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 804);
            this.btnUser.MinimumSize = new System.Drawing.Size(220, 60);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(220, 60);
            this.btnUser.TabIndex = 11;
            this.btnUser.Text = "   User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pnlVisitorSubMenu
            // 
            this.pnlVisitorSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlVisitorSubMenu.Controls.Add(this.btnAllVisitors);
            this.pnlVisitorSubMenu.Controls.Add(this.btnSearchVisitor);
            this.pnlVisitorSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVisitorSubMenu.Location = new System.Drawing.Point(0, 405);
            this.pnlVisitorSubMenu.Name = "pnlVisitorSubMenu";
            this.pnlVisitorSubMenu.Size = new System.Drawing.Size(220, 90);
            this.pnlVisitorSubMenu.TabIndex = 9;
            this.pnlVisitorSubMenu.Visible = false;
            // 
            // btnAllVisitors
            // 
            this.btnAllVisitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllVisitors.FlatAppearance.BorderSize = 0;
            this.btnAllVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllVisitors.ForeColor = System.Drawing.Color.White;
            this.btnAllVisitors.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.view_all_30px;
            this.btnAllVisitors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllVisitors.Location = new System.Drawing.Point(0, 45);
            this.btnAllVisitors.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnAllVisitors.Name = "btnAllVisitors";
            this.btnAllVisitors.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAllVisitors.Size = new System.Drawing.Size(220, 45);
            this.btnAllVisitors.TabIndex = 4;
            this.btnAllVisitors.Text = "     View All";
            this.btnAllVisitors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllVisitors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllVisitors.UseVisualStyleBackColor = true;
            this.btnAllVisitors.Click += new System.EventHandler(this.btnAllVisitors_Click);
            // 
            // btnSearchVisitor
            // 
            this.btnSearchVisitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchVisitor.FlatAppearance.BorderSize = 0;
            this.btnSearchVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchVisitor.ForeColor = System.Drawing.Color.White;
            this.btnSearchVisitor.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.search_30px;
            this.btnSearchVisitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchVisitor.Location = new System.Drawing.Point(0, 0);
            this.btnSearchVisitor.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnSearchVisitor.Name = "btnSearchVisitor";
            this.btnSearchVisitor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSearchVisitor.Size = new System.Drawing.Size(220, 45);
            this.btnSearchVisitor.TabIndex = 3;
            this.btnSearchVisitor.Text = "     Search";
            this.btnSearchVisitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchVisitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchVisitor.UseVisualStyleBackColor = true;
            this.btnSearchVisitor.Click += new System.EventHandler(this.btnSearchVisitor_Click);
            // 
            // btnVisitor
            // 
            this.btnVisitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisitor.FlatAppearance.BorderSize = 0;
            this.btnVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitor.ForeColor = System.Drawing.Color.White;
            this.btnVisitor.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.waiting_room_35px;
            this.btnVisitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitor.Location = new System.Drawing.Point(0, 345);
            this.btnVisitor.MinimumSize = new System.Drawing.Size(220, 60);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVisitor.Size = new System.Drawing.Size(220, 60);
            this.btnVisitor.TabIndex = 8;
            this.btnVisitor.Text = "   Visitor";
            this.btnVisitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisitor.UseVisualStyleBackColor = true;
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            // 
            // pnlPrisonerSubMenu
            // 
            this.pnlPrisonerSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlPrisonerSubMenu.Controls.Add(this.btnAllPrisoner);
            this.pnlPrisonerSubMenu.Controls.Add(this.btnSearchPrisoner);
            this.pnlPrisonerSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrisonerSubMenu.Location = new System.Drawing.Point(0, 255);
            this.pnlPrisonerSubMenu.MinimumSize = new System.Drawing.Size(220, 90);
            this.pnlPrisonerSubMenu.Name = "pnlPrisonerSubMenu";
            this.pnlPrisonerSubMenu.Size = new System.Drawing.Size(220, 90);
            this.pnlPrisonerSubMenu.TabIndex = 7;
            this.pnlPrisonerSubMenu.Visible = false;
            // 
            // btnAllPrisoner
            // 
            this.btnAllPrisoner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllPrisoner.FlatAppearance.BorderSize = 0;
            this.btnAllPrisoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllPrisoner.ForeColor = System.Drawing.Color.White;
            this.btnAllPrisoner.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.view_all_30px;
            this.btnAllPrisoner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllPrisoner.Location = new System.Drawing.Point(0, 45);
            this.btnAllPrisoner.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnAllPrisoner.Name = "btnAllPrisoner";
            this.btnAllPrisoner.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAllPrisoner.Size = new System.Drawing.Size(220, 45);
            this.btnAllPrisoner.TabIndex = 3;
            this.btnAllPrisoner.Text = "     View All";
            this.btnAllPrisoner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllPrisoner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllPrisoner.UseVisualStyleBackColor = true;
            this.btnAllPrisoner.Click += new System.EventHandler(this.btnAllPrisoner_Click);
            // 
            // btnSearchPrisoner
            // 
            this.btnSearchPrisoner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchPrisoner.FlatAppearance.BorderSize = 0;
            this.btnSearchPrisoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPrisoner.ForeColor = System.Drawing.Color.White;
            this.btnSearchPrisoner.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.search_30px;
            this.btnSearchPrisoner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPrisoner.Location = new System.Drawing.Point(0, 0);
            this.btnSearchPrisoner.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnSearchPrisoner.Name = "btnSearchPrisoner";
            this.btnSearchPrisoner.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSearchPrisoner.Size = new System.Drawing.Size(220, 45);
            this.btnSearchPrisoner.TabIndex = 2;
            this.btnSearchPrisoner.Text = "     Search";
            this.btnSearchPrisoner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPrisoner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchPrisoner.UseVisualStyleBackColor = true;
            this.btnSearchPrisoner.Click += new System.EventHandler(this.btnSearchPrisoner_Click);
            // 
            // btnPrisoner
            // 
            this.btnPrisoner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrisoner.FlatAppearance.BorderSize = 0;
            this.btnPrisoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrisoner.ForeColor = System.Drawing.Color.White;
            this.btnPrisoner.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.prisoner_35px;
            this.btnPrisoner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrisoner.Location = new System.Drawing.Point(0, 195);
            this.btnPrisoner.MinimumSize = new System.Drawing.Size(220, 60);
            this.btnPrisoner.Name = "btnPrisoner";
            this.btnPrisoner.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrisoner.Size = new System.Drawing.Size(220, 60);
            this.btnPrisoner.TabIndex = 6;
            this.btnPrisoner.Text = "   Prisoner";
            this.btnPrisoner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrisoner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrisoner.UseVisualStyleBackColor = true;
            this.btnPrisoner.Click += new System.EventHandler(this.btnPrisoner_Click);
            // 
            // pnlEMSubMenu
            // 
            this.pnlEMSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlEMSubMenu.Controls.Add(this.btnAllEmployee);
            this.pnlEMSubMenu.Controls.Add(this.btnSearchEmployee);
            this.pnlEMSubMenu.Controls.Add(this.btnNewEmployee);
            this.pnlEMSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEMSubMenu.Location = new System.Drawing.Point(0, 60);
            this.pnlEMSubMenu.Name = "pnlEMSubMenu";
            this.pnlEMSubMenu.Size = new System.Drawing.Size(220, 135);
            this.pnlEMSubMenu.TabIndex = 5;
            this.pnlEMSubMenu.Visible = false;
            // 
            // btnAllEmployee
            // 
            this.btnAllEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllEmployee.FlatAppearance.BorderSize = 0;
            this.btnAllEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAllEmployee.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.view_all_30px;
            this.btnAllEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllEmployee.Location = new System.Drawing.Point(0, 90);
            this.btnAllEmployee.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnAllEmployee.Name = "btnAllEmployee";
            this.btnAllEmployee.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAllEmployee.Size = new System.Drawing.Size(220, 45);
            this.btnAllEmployee.TabIndex = 2;
            this.btnAllEmployee.Text = "     View All";
            this.btnAllEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllEmployee.UseVisualStyleBackColor = true;
            this.btnAllEmployee.Click += new System.EventHandler(this.btnAllEmployee_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchEmployee.FlatAppearance.BorderSize = 0;
            this.btnSearchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmployee.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.search_30px;
            this.btnSearchEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchEmployee.Location = new System.Drawing.Point(0, 45);
            this.btnSearchEmployee.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSearchEmployee.Size = new System.Drawing.Size(220, 45);
            this.btnSearchEmployee.TabIndex = 1;
            this.btnSearchEmployee.Text = "     Search";
            this.btnSearchEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewEmployee.FlatAppearance.BorderSize = 0;
            this.btnNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEmployee.ForeColor = System.Drawing.Color.White;
            this.btnNewEmployee.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.add_30px;
            this.btnNewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnNewEmployee.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNewEmployee.Size = new System.Drawing.Size(220, 45);
            this.btnNewEmployee.TabIndex = 0;
            this.btnNewEmployee.Text = "     Add";
            this.btnNewEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.name_tag_35px;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnEmployee.MinimumSize = new System.Drawing.Size(220, 60);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(220, 60);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "   Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.AutoScroll = true;
            this.pnlMainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPanel.Location = new System.Drawing.Point(220, 75);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(1075, 864);
            this.pnlMainPanel.TabIndex = 2;
            this.pnlMainPanel.MouseEnter += new System.EventHandler(this.pnlMainPanel_MouseEnter);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 939);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMainPanel);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlBorder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.AdministratorForm_Shown);
            this.MouseHover += new System.EventHandler(this.pnlControls_MouseEnter);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlReportSubMenu.ResumeLayout(false);
            this.pnlUserSubMenu.ResumeLayout(false);
            this.pnlVisitorSubMenu.ResumeLayout(false);
            this.pnlPrisonerSubMenu.ResumeLayout(false);
            this.pnlEMSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnlEMSubMenu;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnAllEmployee;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnPrisoner;
        private System.Windows.Forms.Panel pnlPrisonerSubMenu;
        private System.Windows.Forms.Button btnAllPrisoner;
        private System.Windows.Forms.Button btnSearchPrisoner;
        private System.Windows.Forms.Button btnVisitor;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlVisitorSubMenu;
        private System.Windows.Forms.Button btnAllVisitors;
        private System.Windows.Forms.Button btnSearchVisitor;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel pnlMainPanel;
        private System.Windows.Forms.Panel pnlUserSubMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangeCredentials;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel pnlReportSubMenu;
        private System.Windows.Forms.Button btnVisitorReports;
        private System.Windows.Forms.Button btnDoctorReports;
        private System.Windows.Forms.Button btnPrisonerReports;
    }
}