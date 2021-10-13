
namespace PrisonManagementSystemProjectv0
{
    partial class ViewAllVisitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllVisitorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvVisitor = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.btnVisit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitor)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvVisitor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 507);
            this.panel1.TabIndex = 0;
            // 
            // dgvVisitor
            // 
            this.dgvVisitor.AllowUserToAddRows = false;
            this.dgvVisitor.AllowUserToDeleteRows = false;
            this.dgvVisitor.AllowUserToOrderColumns = true;
            this.dgvVisitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisitor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisitor.Location = new System.Drawing.Point(0, 45);
            this.dgvVisitor.Name = "dgvVisitor";
            this.dgvVisitor.ReadOnly = true;
            this.dgvVisitor.RowHeadersVisible = false;
            this.dgvVisitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitor.Size = new System.Drawing.Size(1058, 462);
            this.dgvVisitor.TabIndex = 3;
            this.dgvVisitor.SelectionChanged += new System.EventHandler(this.dgvVisitor_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnVisitor);
            this.panel2.Controls.Add(this.btnVisit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 45);
            this.panel2.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.delete_25px;
            this.btnDelete.Location = new System.Drawing.Point(970, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 42);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "  Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnVisitor
            // 
            this.btnVisitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(5)))), ((int)(((byte)(76)))));
            this.btnVisitor.FlatAppearance.BorderSize = 0;
            this.btnVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitor.ForeColor = System.Drawing.Color.White;
            this.btnVisitor.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.visitor_25px;
            this.btnVisitor.Location = new System.Drawing.Point(3, 3);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Size = new System.Drawing.Size(88, 42);
            this.btnVisitor.TabIndex = 23;
            this.btnVisitor.Text = "  Visitor";
            this.btnVisitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisitor.UseVisualStyleBackColor = false;
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            // 
            // btnVisit
            // 
            this.btnVisit.FlatAppearance.BorderSize = 0;
            this.btnVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisit.ForeColor = System.Drawing.Color.White;
            this.btnVisit.Image = global::PrisonManagementSystemProjectv0.Properties.Resources.visit_25px;
            this.btnVisit.Location = new System.Drawing.Point(97, 3);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(89, 42);
            this.btnVisit.TabIndex = 14;
            this.btnVisit.Text = "  Visit";
            this.btnVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisit.UseVisualStyleBackColor = true;
            this.btnVisit.Click += new System.EventHandler(this.btnVisit_Click);
            // 
            // ViewAllVisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 531);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllVisitorForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "ViewAllVisitorForm";
            this.Shown += new System.EventHandler(this.ViewAllVisitorForm_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVisit;
        private System.Windows.Forms.Button btnVisitor;
        private System.Windows.Forms.DataGridView dgvVisitor;
        private System.Windows.Forms.Button btnDelete;
    }
}