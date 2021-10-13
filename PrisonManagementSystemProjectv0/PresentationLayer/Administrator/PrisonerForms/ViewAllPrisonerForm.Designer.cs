
namespace PrisonManagementSystemProjectv0
{
    partial class ViewAllPrisonerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllPrisonerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPrisoner = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrisoner = new System.Windows.Forms.Button();
            this.btnVisit = new System.Windows.Forms.Button();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 0;
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
            this.panel2.Controls.Add(this.btnPrisoner);
            this.panel2.Controls.Add(this.btnVisit);
            this.panel2.Controls.Add(this.btnTreatment);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 45);
            this.panel2.TabIndex = 0;
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
            // btnVisit
            // 
            this.btnVisit.FlatAppearance.BorderSize = 0;
            this.btnVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisit.ForeColor = System.Drawing.Color.White;
            this.btnVisit.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.visit_25px;
            this.btnVisit.Location = new System.Drawing.Point(111, 3);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(89, 42);
            this.btnVisit.TabIndex = 12;
            this.btnVisit.Text = "  Visit";
            this.btnVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisit.UseVisualStyleBackColor = true;
            this.btnVisit.Click += new System.EventHandler(this.btnVisit_Click);
            // 
            // btnTreatment
            // 
            this.btnTreatment.FlatAppearance.BorderSize = 0;
            this.btnTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreatment.ForeColor = System.Drawing.Color.White;
            this.btnTreatment.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.treatment_25px;
            this.btnTreatment.Location = new System.Drawing.Point(206, 3);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(102, 42);
            this.btnTreatment.TabIndex = 11;
            this.btnTreatment.Text = "  Treatment";
            this.btnTreatment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTreatment.UseVisualStyleBackColor = true;
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.delete_25px;
            this.btnDelete.Location = new System.Drawing.Point(919, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 42);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "  Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ViewAllPrisonerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 538);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllPrisonerForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "ViewAllPrisonerForm";
            this.Shown += new System.EventHandler(this.ViewAllPrisonerForm_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisoner)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTreatment;
        private System.Windows.Forms.DataGridView dgvPrisoner;
        private System.Windows.Forms.Button btnPrisoner;
        private System.Windows.Forms.Button btnVisit;
        private System.Windows.Forms.Button btnDelete;
    }
}