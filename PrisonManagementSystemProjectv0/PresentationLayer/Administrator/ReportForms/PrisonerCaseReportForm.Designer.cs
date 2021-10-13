
namespace PrisonManagementSystemProjectv0
{
    partial class PrisonerCaseReportForm
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
            this.crvCaseReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCaseReport
            // 
            this.crvCaseReport.ActiveViewIndex = -1;
            this.crvCaseReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCaseReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCaseReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCaseReport.Location = new System.Drawing.Point(0, 0);
            this.crvCaseReport.Name = "crvCaseReport";
            this.crvCaseReport.Size = new System.Drawing.Size(800, 450);
            this.crvCaseReport.TabIndex = 0;
            this.crvCaseReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // PrisonerCaseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvCaseReport);
            this.Name = "PrisonerCaseReportForm";
            this.Text = "PrisonerCaseReportForm";
            this.Shown += new System.EventHandler(this.PrisonerCaseReportForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCaseReport;
    }
}