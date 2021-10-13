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
    public partial class DoctorTreatmentReportForm : Form
    {
        public DoctorInfo DoctorRep { set; get; }
        public DataTable TreatmentTable { set; get; }
        public DoctorTreatmentReportForm()
        {
            InitializeComponent();
        }

        private void DoctorTreatmentReportForm_Shown(object sender, EventArgs e)
        {
            List<DoctorInfo> doctors = new List<DoctorInfo>();
            doctors.Add(DoctorRep);
            PresentationLayer.Administrator.Reports.DoctorTreatmemntReport treatmemntReport = new PresentationLayer.Administrator.Reports.DoctorTreatmemntReport();
            treatmemntReport.Database.Tables["DoctorInfo"].SetDataSource(doctors);
            treatmemntReport.Database.Tables["Treatment"].SetDataSource(TreatmentTable);

            crvTreatmentReport.ReportSource = null;
            crvTreatmentReport.ReportSource = treatmemntReport;
        }
    }
}
