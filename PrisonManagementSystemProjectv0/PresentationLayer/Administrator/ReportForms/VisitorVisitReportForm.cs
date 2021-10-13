using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystemProjectv0
{
    public partial class VisitorVisitReportForm : Form
    {
        public Visitor VisitorRep { set; get; }
        public DataTable VisitTable { set; get; }
        public VisitorVisitReportForm()
        {
            InitializeComponent();
        }

        private void VisitorVisitReportForm_Shown(object sender, EventArgs e)
        {
            List<Visitor> visitors = new List<Visitor>();
            visitors.Add(VisitorRep);
            PresentationLayer.Administrator.Reports.VisitorVisitReport visitReport = new PresentationLayer.Administrator.Reports.VisitorVisitReport();
            visitReport.Database.Tables["Visitor"].SetDataSource(visitors);
            visitReport.Database.Tables["Visit"].SetDataSource(VisitTable);

            crvVisitReport.ReportSource = null;
            crvVisitReport.ReportSource = visitReport;
        }
    }
}
