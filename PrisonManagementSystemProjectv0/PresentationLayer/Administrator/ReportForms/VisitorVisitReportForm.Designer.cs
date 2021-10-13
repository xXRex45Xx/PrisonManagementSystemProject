
namespace PrisonManagementSystemProjectv0
{
    partial class VisitorVisitReportForm
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
            this.crvVisitReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVisitReport
            // 
            this.crvVisitReport.ActiveViewIndex = -1;
            this.crvVisitReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisitReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisitReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVisitReport.Location = new System.Drawing.Point(0, 0);
            this.crvVisitReport.Name = "crvVisitReport";
            this.crvVisitReport.Size = new System.Drawing.Size(800, 450);
            this.crvVisitReport.TabIndex = 0;
            this.crvVisitReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisitorVisitReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvVisitReport);
            this.Name = "VisitorVisitReportForm";
            this.Text = "VisitorVisitReportForm";
            this.Shown += new System.EventHandler(this.VisitorVisitReportForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisitReport;
    }
}