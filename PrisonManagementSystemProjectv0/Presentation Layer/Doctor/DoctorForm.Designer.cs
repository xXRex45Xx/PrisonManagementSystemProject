
namespace PrisonManagementSystemProjectv0
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlPrisonerSubMenu = new System.Windows.Forms.Panel();
            this.btnAllPrisoner = new System.Windows.Forms.Button();
            this.btnSearchPrisoner = new System.Windows.Forms.Button();
            this.btnPrisoner = new System.Windows.Forms.Button();
            this.pnlTreatmentSubMenu = new System.Windows.Forms.Panel();
            this.btnAllTreatments = new System.Windows.Forms.Button();
            this.btnSearchTreatment = new System.Windows.Forms.Button();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlPrisonerSubMenu.SuspendLayout();
            this.pnlTreatmentSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlBorder.Controls.Add(this.btnMinimize);
            this.pnlBorder.Controls.Add(this.btnMaxMin);
            this.pnlBorder.Controls.Add(this.btnExit);
            this.pnlBorder.Controls.Add(this.lblFormName);
            this.pnlBorder.Controls.Add(this.lblDoctor);
            this.pnlBorder.Controls.Add(this.pictureBox1);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.ForeColor = System.Drawing.Color.White;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1295, 75);
            this.pnlBorder.TabIndex = 0;
            this.pnlBorder.DoubleClick += new System.EventHandler(this.pnlBorder_DoubleClick);
            this.pnlBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseDown);
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
            this.btnMinimize.TabIndex = 9;
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
            this.btnMaxMin.TabIndex = 8;
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
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // lblFormName
            // 
            this.lblFormName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.Location = new System.Drawing.Point(611, 25);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(72, 25);
            this.lblFormName.TabIndex = 6;
            this.lblFormName.Text = "Home";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.Color.White;
            this.lblDoctor.Location = new System.Drawing.Point(81, 25);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(75, 25);
            this.lblDoctor.TabIndex = 2;
            this.lblDoctor.Text = "Doctor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.doctor_male_75px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlControls.Controls.Add(this.button1);
            this.pnlControls.Controls.Add(this.pnlPrisonerSubMenu);
            this.pnlControls.Controls.Add(this.btnPrisoner);
            this.pnlControls.Controls.Add(this.pnlTreatmentSubMenu);
            this.pnlControls.Controls.Add(this.btnTreatment);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 75);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(220, 724);
            this.pnlControls.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.male_user_50px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 664);
            this.button1.MinimumSize = new System.Drawing.Size(220, 60);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(220, 60);
            this.button1.TabIndex = 12;
            this.button1.Text = "   User";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
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
            this.pnlPrisonerSubMenu.TabIndex = 10;
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
            this.btnPrisoner.Location = new System.Drawing.Point(0, 150);
            this.btnPrisoner.MinimumSize = new System.Drawing.Size(220, 60);
            this.btnPrisoner.Name = "btnPrisoner";
            this.btnPrisoner.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrisoner.Size = new System.Drawing.Size(220, 60);
            this.btnPrisoner.TabIndex = 9;
            this.btnPrisoner.Text = "   Prisoner";
            this.btnPrisoner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrisoner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrisoner.UseVisualStyleBackColor = true;
            this.btnPrisoner.Click += new System.EventHandler(this.btnPrisoner_Click);
            // 
            // pnlTreatmentSubMenu
            // 
            this.pnlTreatmentSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlTreatmentSubMenu.Controls.Add(this.btnAllTreatments);
            this.pnlTreatmentSubMenu.Controls.Add(this.btnSearchTreatment);
            this.pnlTreatmentSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTreatmentSubMenu.Location = new System.Drawing.Point(0, 60);
            this.pnlTreatmentSubMenu.MinimumSize = new System.Drawing.Size(220, 90);
            this.pnlTreatmentSubMenu.Name = "pnlTreatmentSubMenu";
            this.pnlTreatmentSubMenu.Size = new System.Drawing.Size(220, 90);
            this.pnlTreatmentSubMenu.TabIndex = 8;
            this.pnlTreatmentSubMenu.Visible = false;
            // 
            // btnAllTreatments
            // 
            this.btnAllTreatments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllTreatments.FlatAppearance.BorderSize = 0;
            this.btnAllTreatments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllTreatments.ForeColor = System.Drawing.Color.White;
            this.btnAllTreatments.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.view_all_30px;
            this.btnAllTreatments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllTreatments.Location = new System.Drawing.Point(0, 45);
            this.btnAllTreatments.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnAllTreatments.Name = "btnAllTreatments";
            this.btnAllTreatments.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAllTreatments.Size = new System.Drawing.Size(220, 45);
            this.btnAllTreatments.TabIndex = 4;
            this.btnAllTreatments.Text = "     View All";
            this.btnAllTreatments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllTreatments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllTreatments.UseVisualStyleBackColor = true;
            this.btnAllTreatments.Click += new System.EventHandler(this.btnAllTreatments_Click);
            // 
            // btnSearchTreatment
            // 
            this.btnSearchTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchTreatment.FlatAppearance.BorderSize = 0;
            this.btnSearchTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTreatment.ForeColor = System.Drawing.Color.White;
            this.btnSearchTreatment.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.search_30px;
            this.btnSearchTreatment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchTreatment.Location = new System.Drawing.Point(0, 0);
            this.btnSearchTreatment.MinimumSize = new System.Drawing.Size(220, 45);
            this.btnSearchTreatment.Name = "btnSearchTreatment";
            this.btnSearchTreatment.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSearchTreatment.Size = new System.Drawing.Size(220, 45);
            this.btnSearchTreatment.TabIndex = 3;
            this.btnSearchTreatment.Text = "     Search";
            this.btnSearchTreatment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchTreatment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchTreatment.UseVisualStyleBackColor = true;
            this.btnSearchTreatment.Click += new System.EventHandler(this.btnSearchTreatment_Click);
            // 
            // btnTreatment
            // 
            this.btnTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTreatment.FlatAppearance.BorderSize = 0;
            this.btnTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreatment.ForeColor = System.Drawing.Color.White;
            this.btnTreatment.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.treatment_30px;
            this.btnTreatment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTreatment.Location = new System.Drawing.Point(0, 0);
            this.btnTreatment.MinimumSize = new System.Drawing.Size(220, 60);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTreatment.Size = new System.Drawing.Size(220, 60);
            this.btnTreatment.TabIndex = 7;
            this.btnTreatment.Text = "   Treatment";
            this.btnTreatment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTreatment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTreatment.UseVisualStyleBackColor = true;
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPanel.Location = new System.Drawing.Point(220, 75);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(1075, 724);
            this.pnlMainPanel.TabIndex = 2;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 799);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMainPanel);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlBorder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorForm";
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlPrisonerSubMenu.ResumeLayout(false);
            this.pnlTreatmentSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlMainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTreatment;
        private System.Windows.Forms.Panel pnlTreatmentSubMenu;
        private System.Windows.Forms.Button btnAllTreatments;
        private System.Windows.Forms.Button btnSearchTreatment;
        private System.Windows.Forms.Button btnPrisoner;
        private System.Windows.Forms.Panel pnlPrisonerSubMenu;
        private System.Windows.Forms.Button btnAllPrisoner;
        private System.Windows.Forms.Button btnSearchPrisoner;
        private System.Windows.Forms.Button button1;
    }
}