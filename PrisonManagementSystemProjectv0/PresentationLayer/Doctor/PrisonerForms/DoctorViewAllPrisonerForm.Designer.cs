
namespace PrisonManagementSystemProjectv0
{
    partial class DoctorViewAllPrisonerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorViewAllPrisonerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPrisoner = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNewTreatment = new System.Windows.Forms.Button();
            this.btnPrisoner = new System.Windows.Forms.Button();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisoner)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPrisoner);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 514);
            this.panel1.TabIndex = 1;
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
            this.dgvPrisoner.Location = new System.Drawing.Point(0, 45);
            this.dgvPrisoner.Name = "dgvPrisoner";
            this.dgvPrisoner.ReadOnly = true;
            this.dgvPrisoner.RowHeadersVisible = false;
            this.dgvPrisoner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrisoner.Size = new System.Drawing.Size(1010, 469);
            this.dgvPrisoner.TabIndex = 2;
            this.dgvPrisoner.SelectionChanged += new System.EventHandler(this.dgvPrisoner_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnNewTreatment);
            this.panel2.Controls.Add(this.btnPrisoner);
            this.panel2.Controls.Add(this.btnTreatment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 45);
            this.panel2.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.update_25px;
            this.btnUpdate.Location = new System.Drawing.Point(918, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 42);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "  Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNewTreatment
            // 
            this.btnNewTreatment.FlatAppearance.BorderSize = 0;
            this.btnNewTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTreatment.ForeColor = System.Drawing.Color.White;
            this.btnNewTreatment.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.treatment_25px;
            this.btnNewTreatment.Location = new System.Drawing.Point(219, 3);
            this.btnNewTreatment.Name = "btnNewTreatment";
            this.btnNewTreatment.Size = new System.Drawing.Size(133, 42);
            this.btnNewTreatment.TabIndex = 14;
            this.btnNewTreatment.Text = "  New Treatment";
            this.btnNewTreatment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewTreatment.UseVisualStyleBackColor = true;
            this.btnNewTreatment.Click += new System.EventHandler(this.btnNewTreatment_Click);
            // 
            // btnPrisoner
            // 
            this.btnPrisoner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(5)))), ((int)(((byte)(76)))));
            this.btnPrisoner.FlatAppearance.BorderSize = 0;
            this.btnPrisoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrisoner.ForeColor = System.Drawing.Color.White;
            this.btnPrisoner.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.prisoner_25px;
            this.btnPrisoner.Location = new System.Drawing.Point(3, 3);
            this.btnPrisoner.Name = "btnPrisoner";
            this.btnPrisoner.Size = new System.Drawing.Size(102, 42);
            this.btnPrisoner.TabIndex = 13;
            this.btnPrisoner.Text = "  Prisoner";
            this.btnPrisoner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrisoner.UseVisualStyleBackColor = false;
            this.btnPrisoner.Click += new System.EventHandler(this.btnPrisoner_Click);
            // 
            // btnTreatment
            // 
            this.btnTreatment.FlatAppearance.BorderSize = 0;
            this.btnTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreatment.ForeColor = System.Drawing.Color.White;
            this.btnTreatment.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.treatment_25px;
            this.btnTreatment.Location = new System.Drawing.Point(111, 3);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(102, 42);
            this.btnTreatment.TabIndex = 11;
            this.btnTreatment.Text = "  Treatment";
            this.btnTreatment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTreatment.UseVisualStyleBackColor = true;
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // DoctorViewAllPrisonerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 538);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorViewAllPrisonerForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "ViewAllPrisonerForm";
            this.Shown += new System.EventHandler(this.DoctorViewAllPrisonerForm_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisoner)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPrisoner;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrisoner;
        private System.Windows.Forms.Button btnTreatment;
        private System.Windows.Forms.Button btnNewTreatment;
        private System.Windows.Forms.Button btnUpdate;
    }
}