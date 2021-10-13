
namespace PrisonManagementSystemProjectv0
{
    partial class SearchEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchEmployeeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResetCreds = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReception = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnGuard = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEmployee);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 675);
            this.panel1.TabIndex = 0;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToOrderColumns = true;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 45);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1259, 630);
            this.dgvEmployee.TabIndex = 2;
            this.dgvEmployee.SelectionChanged += new System.EventHandler(this.dgvEmployee_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.btnResetCreds);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnReception);
            this.panel2.Controls.Add(this.btnDoctor);
            this.panel2.Controls.Add(this.btnGuard);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbSearchBy);
            this.panel2.Controls.Add(this.txtSearchValue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1259, 45);
            this.panel2.TabIndex = 0;
            // 
            // btnResetCreds
            // 
            this.btnResetCreds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetCreds.FlatAppearance.BorderSize = 0;
            this.btnResetCreds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetCreds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetCreds.ForeColor = System.Drawing.Color.White;
            this.btnResetCreds.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.reset_creds_25px;
            this.btnResetCreds.Location = new System.Drawing.Point(925, 6);
            this.btnResetCreds.Name = "btnResetCreds";
            this.btnResetCreds.Size = new System.Drawing.Size(153, 42);
            this.btnResetCreds.TabIndex = 11;
            this.btnResetCreds.Text = "  Reset Credentials";
            this.btnResetCreds.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetCreds.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.delete_25px;
            this.btnDelete.Location = new System.Drawing.Point(1173, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 42);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.update_25px;
            this.btnUpdate.Location = new System.Drawing.Point(1084, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 42);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReception
            // 
            this.btnReception.FlatAppearance.BorderSize = 0;
            this.btnReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReception.ForeColor = System.Drawing.Color.White;
            this.btnReception.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.reception_25px;
            this.btnReception.Location = new System.Drawing.Point(173, 2);
            this.btnReception.Name = "btnReception";
            this.btnReception.Size = new System.Drawing.Size(105, 42);
            this.btnReception.TabIndex = 5;
            this.btnReception.Text = "  Reception";
            this.btnReception.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReception.UseVisualStyleBackColor = true;
            this.btnReception.Click += new System.EventHandler(this.btnReception_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.FlatAppearance.BorderSize = 0;
            this.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.Color.White;
            this.btnDoctor.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.doctor_25px;
            this.btnDoctor.Location = new System.Drawing.Point(84, 4);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(83, 42);
            this.btnDoctor.TabIndex = 4;
            this.btnDoctor.Text = "  Doctor";
            this.btnDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnGuard
            // 
            this.btnGuard.FlatAppearance.BorderSize = 0;
            this.btnGuard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuard.ForeColor = System.Drawing.Color.White;
            this.btnGuard.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.guard_25px;
            this.btnGuard.Location = new System.Drawing.Point(3, 2);
            this.btnGuard.Name = "btnGuard";
            this.btnGuard.Size = new System.Drawing.Size(75, 43);
            this.btnGuard.TabIndex = 4;
            this.btnGuard.Text = "Guard";
            this.btnGuard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuard.UseVisualStyleBackColor = true;
            this.btnGuard.Click += new System.EventHandler(this.btnGuard_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.search_25px1;
            this.btnSearch.Location = new System.Drawing.Point(839, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 42);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(408, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By:";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Employee Number",
            "First Name",
            "Last Name",
            "Phone Number",
            "Email"});
            this.cmbSearchBy.Location = new System.Drawing.Point(487, 17);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(121, 23);
            this.cmbSearchBy.TabIndex = 1;
            this.cmbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbSearchBy_SelectedIndexChanged);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtSearchValue.Location = new System.Drawing.Point(614, 17);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(219, 21);
            this.txtSearchValue.TabIndex = 0;
            // 
            // SearchEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 699);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchEmployeeForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "SearchEmployeeForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnGuard;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnResetCreds;
    }
}