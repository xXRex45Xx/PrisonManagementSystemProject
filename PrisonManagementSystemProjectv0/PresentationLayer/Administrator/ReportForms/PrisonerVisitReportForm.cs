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
    public partial class PrisonerVisitReportForm : Form
    {
        public Prisoner PrisonerRep { set; get; }
        public DataTable VisitTable { set; get; }
        public PrisonerVisitReportForm()
        {
            InitializeComponent();
        }

        private void PrisonerVisitReportForm_Shown(object sender, EventArgs e)
        {
            List<Prisoner> prisoners = new List<Prisoner>();
            prisoners.Add(PrisonerRep);

            PresentationLayer.Administrator.Reports.PrisonerVisitReport visitReport = new PresentationLayer.Administrator.Reports.PrisonerVisitReport();
            visitReport.Database.Tables["Prisoner"].SetDataSource(prisoners);
            visitReport.Database.Tables["Visit"].SetDataSource(VisitTable);

            crvVisitReport.ReportSource = null;
            crvVisitReport.ReportSource = visitReport;
        }
    }
}
