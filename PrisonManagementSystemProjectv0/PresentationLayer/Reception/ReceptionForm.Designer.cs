
namespace PrisonManagementSystemProjectv0
{
    partial class ReceptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionForm));
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblReception = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlUserSubMenu = new System.Windows.Forms.Panel();
            this.pnlVisitSubMenu = new System.Windows.Forms.Panel();
            this.pnlPrisonerSubMenu = new System.Windows.Forms.Panel();
            this.pnlVisitorSubMenu = new System.Windows.Forms.Panel();
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangeCredentials = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAllVisits = new System.Windows.Forms.Button();
            this.btnSearchVisit = new System.Windows.Forms.Button();
            this.btnVisit = new System.Windows.Forms.Button();
            this.btnAllPrisoner = new System.Windows.Forms.Button();
            this.btnSearchPrisoner = new System.Windows.Forms.Button();
            this.btnPrisoner = new System.Windows.Forms.Button();
            this.btnAllVisitors = new System.Windows.Forms.Button();
            this.btnSearchVisitor = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.pnlBorder.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlUserSubMenu.SuspendLayout();
            this.pnlVisitSubMenu.SuspendLayout();
            this.pnlPrisonerSubMenu.SuspendLayout();
            this.pnlVisitorSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlBorder.Controls.Add(this.btnHomePage);
            this.pnlBorder.Controls.Add(this.btnMinimize);
            this.pnlBorder.Controls.Add(this.btnMaxMin);
            this.pnlBorder.Controls.Add(this.btnExit);
            this.pnlBorder.Controls.Add(this.lblFormName);
            this.pnlBorder.Controls.Add(this.lblReception);
            this.pnlBorder.Controls.Add(this.pictureBox1);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.ForeColor = System.Drawing.Color.White;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1295, 75);
            this.pnlBorder.TabIndex = 0;
            this.pnlBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseDown);
            // 
            // lblFormName
            // 
            this.lblFormName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.Location = new System.Drawing.Point(611, 25);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(72, 25);
            this.lblFormName.TabIndex = 7;
            this.lblFormName.Text = "Home";
            // 
            // lblReception
            // 
            this.lblReception.AutoSize = true;
            this.lblReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReception.ForeColor = System.Drawing.Color.White;
            this.lblReception.Location = new System.Drawing.Point(81, 26);
            this.lblReception.Name = "lblReception";
            this.lblReception.Size = new System.Drawing.Size(109, 25);
            this.lblReception.TabIndex = 3;
            this.lblReception.Text = "Reception";
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlControls.Controls.Add(this.pnlUserSubMenu);
            this.pnlControls.Controls.Add(this.btnUser);
            this.pnlControls.Controls.Add(this.pnlVisitSubMenu);
            this.pnlControls.Controls.Add(this.btnVisit);
            this.pnlControls.Controls.Add(this.pnlPrisonerSubMenu);
            this.pnlControls.Controls.Add(this.btnPrisoner);
            this.pnlControls.Controls.Add(this.pnlVisitorSubMenu);
            this.pnlControls.Controls.Add(this.btnVisitor);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 75);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(220, 724);
            this.pnlControls.TabIndex = 1;
            // 
            // pnlUserSubMenu
            // 
            this.pnlUserSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlUserSubMenu.Controls.Add(this.btnLogout);
            this.pnlUserSubMenu.Controls.Add(this.btnChangeCredentials);
            this.pnlUserSubMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUserSubMenu.Location = new System.Drawing.Point(0, 574);
            this.pnlUserSubMenu.MinimumSize = new System.Drawing.Size(220, 90);
            this.pnlUserSubMenu.Name = "pnlUserSubMenu";
            this.pnlUserSubMenu.Size = new System.Drawing.Size(220, 90);
            this.pnlUserSubMenu.TabIndex = 18;
            this.pnlUserSubMenu.Visible = false;
            // 
            // pnlVisitSubMenu
            // 
            this.pnlVisitSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlVisitSubMenu.Controls.Add(this.btnAllVisits);
            this.pnlVisitSubMenu.Controls.Add(this.btnSearchVisit);
            this.pnlVisitSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVisitSubMenu.Location = new System.Drawing.Point(0, 360);
            this.pnlVisitSubMenu.MinimumSize = new System.Drawing.Size(220, 90);
            this.pnlVisitSubMenu.Name = "pnlVisitSubMenu";
            this.pnlVisitSubMenu.Size = new System.Drawing.Size(220, 90);
            this.pnlVisitSubMenu.TabIndex = 16;
            this.pnlVisitSubMenu.Visible = false;
            // 
            // pnlPrisonerSubMenu
            // 
            this.pnlPrisonerSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlPrisonerSubMenu.Controls.Add(this.btnAllPrisoner);
            this.pnlPrisonerSubMenu.Controls.Add(this.btnSearchPrisoner);
            this.pnlPrisonerSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrisonerSubMenu.Location = new System.Drawing.Point(0, 210);
            this.pnlPrisonerSubMenu.MinimumSize = new System.Drawing.Size(220, 90);
            this.pnlPrisonerSubMenu.Name = "pnlPrisonerSubMenu";
            this.pnlPrisonerSubMenu.Size = new System.Drawing.Size(220, 90);
            this.pnlPrisonerSubMenu.TabIndex = 14;
            this.pnlPrisonerSubMenu.Visible = false;
            // 
            // pnlVisitorSubMenu
            // 
            this.pnlVisitorSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlVisitorSubMenu.Controls.Add(this.btnAllVisitors);
            this.pnlVisitorSubMenu.Controls.Add(this.btnSearchVisitor);
            this.pnlVisitorSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVisitorSubMenu.Location = new System.Drawing.Point(0, 60);
            this.pnlVisitorSubMenu.MinimumSize = new System.Drawing.Size(220, 90);
            this.pnlVisitorSubMenu.Name = "pnlVisitorSubMenu";
            this.pnlVisitorSubMenu.Size = new System.Drawing.Size(220, 90);
            this.pnlVisitorSubMenu.TabIndex = 12;
            this.pnlVisitorSubMenu.Visible = false;
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPanel.Location = new System.Drawing.Point(220, 75);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(1075, 724);
            this.pnlMainPanel.TabIndex = 2;
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
            this.btnUser.Location = new System.Drawing.Point(0, 664);
            this.btnUser.MinimumSize = new System.Drawing.Size(220, 60);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(220, 60);
            this.btnUser.TabIndex = 17;
            this.btnUser.Text = "   User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAllVisits
            // 
            this.btnAllVisits.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllVisits.FlatAppearance.BorderSize = 0;
            this.btnAllVisits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllVisits.ForeColor = System.Drawing.Color.White;
            this.btnAllVisits.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.view_all_30px;
            this.btnAllVisits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllVisits.Location = new System.Drawing.Point(0, 45);
            this.btnAllVisits.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnAllVisits.Name = "btnAllVisits";
            this.btnAllVisits.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAllVisits.Size = new System.Drawing.Size(220, 45);
            this.btnAllVisits.TabIndex = 3;
            this.btnAllVisits.Text = "     View All";
            this.btnAllVisits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllVisits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllVisits.UseVisualStyleBackColor = true;
            this.btnAllVisits.Click += new System.EventHandler(this.btnAllVisits_Click);
            // 
            // btnSearchVisit
            // 
            this.btnSearchVisit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchVisit.FlatAppearance.BorderSize = 0;
            this.btnSearchVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchVisit.ForeColor = System.Drawing.Color.White;
            this.btnSearchVisit.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.search_30px;
            this.btnSearchVisit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchVisit.Location = new System.Drawing.Point(0, 0);
            this.btnSearchVisit.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnSearchVisit.Name = "btnSearchVisit";
            this.btnSearchVisit.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSearchVisit.Size = new System.Drawing.Size(220, 45);
            this.btnSearchVisit.TabIndex = 2;
            this.btnSearchVisit.Text = "     Search";
            this.btnSearchVisit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchVisit.UseVisualStyleBackColor = true;
            this.btnSearchVisit.Click += new System.EventHandler(this.btnSearchVisit_Click);
            // 
            // btnVisit
            // 
            this.btnVisit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisit.FlatAppearance.BorderSize = 0;
            this.btnVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisit.ForeColor = System.Drawing.Color.White;
            this.btnVisit.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.visit_30px;
            this.btnVisit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisit.Location = new System.Drawing.Point(0, 300);
            this.btnVisit.MinimumSize = new System.Drawing.Size(220, 60);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVisit.Size = new System.Drawing.Size(220, 60);
            this.btnVisit.TabIndex = 15;
            this.btnVisit.Text = "   Visit";
            this.btnVisit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisit.UseVisualStyleBackColor = true;
            this.btnVisit.Click += new System.EventHandler(this.btnVisit_Click);
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
            this.btnPrisoner.Location = new System.Drawing.Point(0, 150);
            this.btnPrisoner.MinimumSize = new System.Drawing.Size(220, 60);
            this.btnPrisoner.Name = "btnPrisoner";
            this.btnPrisoner.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrisoner.Size = new System.Drawing.Size(220, 60);
            this.btnPrisoner.TabIndex = 13;
            this.btnPrisoner.Text = "   Prisoner";
            this.btnPrisoner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrisoner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrisoner.UseVisualStyleBackColor = true;
            this.btnPrisoner.Click += new System.EventHandler(this.btnPrisoner_Click);
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
            this.btnVisitor.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.visitor_30px;
            this.btnVisitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitor.Location = new System.Drawing.Point(0, 0);
            this.btnVisitor.MinimumSize = new System.Drawing.Size(220, 60);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVisitor.Size = new System.Drawing.Size(220, 60);
            this.btnVisitor.TabIndex = 11;
            this.btnVisitor.Text = "   Visitor";
            this.btnVisitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisitor.UseVisualStyleBackColor = true;
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.minimize_24px;
            this.btnMinimize.Location = new System.Drawing.Point(1193, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 12;
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
            this.btnMaxMin.Location = new System.Drawing.Point(1230, 3);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(25, 25);
            this.btnMaxMin.TabIndex = 11;
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
            this.btnExit.Location = new System.Drawing.Point(1267, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.reception_75px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.btnHomePage.TabIndex = 13;
            this.btnHomePage.Text = "Home";
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // ReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 799);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMainPanel);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlBorder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceptionForm";
            this.Shown += new System.EventHandler(this.ReceptionForm_Shown);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlUserSubMenu.ResumeLayout(false);
            this.pnlVisitSubMenu.ResumeLayout(false);
            this.pnlPrisonerSubMenu.ResumeLayout(false);
            this.pnlVisitorSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlMainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReception;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnVisitor;
        private System.Windows.Forms.Panel pnlVisitorSubMenu;
        private System.Windows.Forms.Button btnAllVisitors;
        private System.Windows.Forms.Button btnSearchVisitor;
        private System.Windows.Forms.Button btnPrisoner;
        private System.Windows.Forms.Panel pnlPrisonerSubMenu;
        private System.Windows.Forms.Button btnAllPrisoner;
        private System.Windows.Forms.Button btnSearchPrisoner;
        private System.Windows.Forms.Panel pnlVisitSubMenu;
        private System.Windows.Forms.Button btnAllVisits;
        private System.Windows.Forms.Button btnSearchVisit;
        private System.Windows.Forms.Button btnVisit;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel pnlUserSubMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangeCredentials;
        private System.Windows.Forms.Button btnHomePage;
    }
}