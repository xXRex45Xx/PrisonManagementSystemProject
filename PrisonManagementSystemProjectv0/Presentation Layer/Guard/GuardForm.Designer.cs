
namespace PrisonManagementSystemProjectv0
{
    partial class GuardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuardForm));
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblGuard = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewCases = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnSearchPrisoner = new System.Windows.Forms.Button();
            this.btnAllPrisoners = new System.Windows.Forms.Button();
            this.btnAddPrisoner = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPrisoner = new System.Windows.Forms.DataGridView();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisoner)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlBorder.Controls.Add(this.btnMinimize);
            this.pnlBorder.Controls.Add(this.btnMaxMin);
            this.pnlBorder.Controls.Add(this.btnExit);
            this.pnlBorder.Controls.Add(this.lblFormName);
            this.pnlBorder.Controls.Add(this.lblGuard);
            this.pnlBorder.Controls.Add(this.pictureBox1);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.ForeColor = System.Drawing.Color.White;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1284, 75);
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
            this.btnMinimize.Location = new System.Drawing.Point(1182, 3);
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
            this.btnMaxMin.Location = new System.Drawing.Point(1219, 3);
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
            this.btnExit.Location = new System.Drawing.Point(1256, 3);
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
            this.lblFormName.Location = new System.Drawing.Point(606, 23);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(72, 25);
            this.lblFormName.TabIndex = 6;
            this.lblFormName.Text = "Home";
            // 
            // lblGuard
            // 
            this.lblGuard.AutoSize = true;
            this.lblGuard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuard.Location = new System.Drawing.Point(81, 23);
            this.lblGuard.Name = "lblGuard";
            this.lblGuard.Size = new System.Drawing.Size(71, 25);
            this.lblGuard.TabIndex = 2;
            this.lblGuard.Text = "Guard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.security_guard_75px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.btnViewCases);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbSearchBy);
            this.panel2.Controls.Add(this.txtSearchValue);
            this.panel2.Controls.Add(this.btnSearchPrisoner);
            this.panel2.Controls.Add(this.btnAllPrisoners);
            this.panel2.Controls.Add(this.btnAddPrisoner);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 55);
            this.panel2.TabIndex = 1;
            // 
            // btnViewCases
            // 
            this.btnViewCases.FlatAppearance.BorderSize = 0;
            this.btnViewCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCases.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.case_30px;
            this.btnViewCases.Location = new System.Drawing.Point(162, 0);
            this.btnViewCases.Name = "btnViewCases";
            this.btnViewCases.Size = new System.Drawing.Size(75, 55);
            this.btnViewCases.TabIndex = 6;
            this.btnViewCases.Text = "Cases";
            this.btnViewCases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewCases.UseVisualStyleBackColor = true;
            this.btnViewCases.Click += new System.EventHandler(this.btnViewCases_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(776, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search By:";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Prisoner Number",
            "First Name",
            "Last Name",
            "Phone Number",
            "Email"});
            this.cmbSearchBy.Location = new System.Drawing.Point(855, 16);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(121, 23);
            this.cmbSearchBy.TabIndex = 4;
            this.cmbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbSearchBy_SelectedIndexChanged);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtSearchValue.Location = new System.Drawing.Point(982, 16);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(219, 21);
            this.txtSearchValue.TabIndex = 3;
            // 
            // btnSearchPrisoner
            // 
            this.btnSearchPrisoner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPrisoner.FlatAppearance.BorderSize = 0;
            this.btnSearchPrisoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPrisoner.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.search_30px;
            this.btnSearchPrisoner.Location = new System.Drawing.Point(1207, 0);
            this.btnSearchPrisoner.Name = "btnSearchPrisoner";
            this.btnSearchPrisoner.Size = new System.Drawing.Size(75, 55);
            this.btnSearchPrisoner.TabIndex = 2;
            this.btnSearchPrisoner.Text = "Search";
            this.btnSearchPrisoner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearchPrisoner.UseVisualStyleBackColor = true;
            this.btnSearchPrisoner.Click += new System.EventHandler(this.btnSearchPrisoner_Click);
            // 
            // btnAllPrisoners
            // 
            this.btnAllPrisoners.FlatAppearance.BorderSize = 0;
            this.btnAllPrisoners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllPrisoners.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.view_all_30px;
            this.btnAllPrisoners.Location = new System.Drawing.Point(81, 0);
            this.btnAllPrisoners.Name = "btnAllPrisoners";
            this.btnAllPrisoners.Size = new System.Drawing.Size(75, 55);
            this.btnAllPrisoners.TabIndex = 1;
            this.btnAllPrisoners.Text = "View All ";
            this.btnAllPrisoners.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAllPrisoners.UseVisualStyleBackColor = true;
            this.btnAllPrisoners.Click += new System.EventHandler(this.btnAllPrisoners_Click);
            // 
            // btnAddPrisoner
            // 
            this.btnAddPrisoner.FlatAppearance.BorderSize = 0;
            this.btnAddPrisoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPrisoner.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.add_30px;
            this.btnAddPrisoner.Location = new System.Drawing.Point(0, 0);
            this.btnAddPrisoner.Name = "btnAddPrisoner";
            this.btnAddPrisoner.Size = new System.Drawing.Size(75, 55);
            this.btnAddPrisoner.TabIndex = 0;
            this.btnAddPrisoner.Text = "Add Prisoner";
            this.btnAddPrisoner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddPrisoner.UseVisualStyleBackColor = true;
            this.btnAddPrisoner.Click += new System.EventHandler(this.btnAddPrisoner_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPrisoner);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1284, 649);
            this.panel3.TabIndex = 2;
            // 
            // dgvPrisoner
            // 
            this.dgvPrisoner.AllowUserToAddRows = false;
            this.dgvPrisoner.AllowUserToDeleteRows = false;
            this.dgvPrisoner.AllowUserToOrderColumns = true;
            this.dgvPrisoner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrisoner.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrisoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrisoner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrisoner.Location = new System.Drawing.Point(0, 55);
            this.dgvPrisoner.Name = "dgvPrisoner";
            this.dgvPrisoner.ReadOnly = true;
            this.dgvPrisoner.RowHeadersVisible = false;
            this.dgvPrisoner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrisoner.Size = new System.Drawing.Size(1284, 594);
            this.dgvPrisoner.TabIndex = 3;
            this.dgvPrisoner.SelectionChanged += new System.EventHandler(this.dgvPrisoner_SelectionChanged);
            // 
            // GuardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 724);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlBorder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuardForm";
            this.Shown += new System.EventHandler(this.GuardForm_Shown);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisoner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGuard;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddPrisoner;
        private System.Windows.Forms.Button btnSearchPrisoner;
        private System.Windows.Forms.Button btnAllPrisoners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnViewCases;
        private System.Windows.Forms.DataGridView dgvPrisoner;
    }
}