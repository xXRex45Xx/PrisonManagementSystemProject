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
    public partial class PrisonerTreatmentReportForm : Form
    {
        //public Administrator CurrentUser { set; get; }
        public Prisoner PrisonerRep { set; get; }
        public DataTable TreatmentTable { set; get; }
        public PrisonerTreatmentReportForm()
        {
            InitializeComponent();
        }

        private void PrisonerTreatmentReportForm_Shown(object sender, EventArgs e)
        {
            List<Prisoner> prisoners = new List<Prisoner>();
            prisoners.Add(PrisonerRep);

            PresentationLayer.Administrator.Reports.PrisonerTreatmentReport treatmentReport = new PresentationLayer.Administrator.Reports.PrisonerTreatmentReport();
            treatmentReport.Database.Tables["Prisoner"].SetDataSource(prisoners);
            treatmentReport.Database.Tables["Treatment"].SetDataSource(TreatmentTable);

            crvTreatmentReport.ReportSource = null;
            crvTreatmentReport.ReportSource = treatmentReport;
        }
    }
}
