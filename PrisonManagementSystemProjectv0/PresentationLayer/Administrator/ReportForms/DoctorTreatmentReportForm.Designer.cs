
namespace PrisonManagementSystemProjectv0
{
    partial class DoctorTreatmentReportForm
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
            this.crvTreatmentReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvTreatmentReport
            // 
            this.crvTreatmentReport.ActiveViewIndex = -1;
            this.crvTreatmentReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTreatmentReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTreatmentReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvTreatmentReport.Location = new System.Drawing.Point(0, 0);
            this.crvTreatmentReport.Name = "crvTreatmentReport";
            this.crvTreatmentReport.Size = new System.Drawing.Size(800, 450);
            this.crvTreatmentReport.TabIndex = 0;
            this.crvTreatmentReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // DoctorTreatmentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvTreatmentReport);
            this.Name = "DoctorTreatmentReportForm";
            this.Text = "DoctorTreatmentReportForm";
            this.Shown += new System.EventHandler(this.DoctorTreatmentReportForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvTreatmentReport;
    }
}