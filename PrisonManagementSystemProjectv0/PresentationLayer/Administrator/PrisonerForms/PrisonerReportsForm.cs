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
    public partial class PrisonerReportsForm : Form
    {
        public Administrator CurrentUser { set; get; }
        public PrisonerReportsForm()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnTreatmentReport_Click(object sender, EventArgs e)
        {
            SelectPrisonerForm prisonerForm = new SelectPrisonerForm()
            {
                CurrentUser = this.CurrentUser
            };
            DialogResult isSelected = prisonerForm.ShowDialog();
            if (isSelected.Equals(DialogResult.Yes))
            {
                Prisoner selectedPrisoner = prisonerForm.SelectedPrisoner;
                PrisonerTreatmentReportForm treatmentReportForm = new PrisonerTreatmentReportForm()
                {
                    PrisonerRep = selectedPrisoner,
                    TreatmentTable = CurrentUser.GetPrisonerTreatment(selectedPrisoner.PrisonerNo)
                };
                treatmentReportForm.ShowDialog();
            }
        }

        private void btnVisitReport_Click(object sender, EventArgs e)
        {
            SelectPrisonerForm prisonerForm = new SelectPrisonerForm()
            {
                CurrentUser = this.CurrentUser
            };
            DialogResult isSelected = prisonerForm.ShowDialog();
            if (isSelected.Equals(DialogResult.Yes))
            {
                Prisoner selectedPrisoner = prisonerForm.SelectedPrisoner;
                PrisonerVisitReportForm visitReportForm = new PrisonerVisitReportForm()
                {
                    PrisonerRep = selectedPrisoner,
                    VisitTable = CurrentUser.GetPrisonerVisit(selectedPrisoner.PrisonerNo)
                };
                visitReportForm.ShowDialog();
            }
        }

        private void btnCaseReport_Click(object sender, EventArgs e)
        {
            SelectPrisonerForm prisonerForm = new SelectPrisonerForm()
            {
                CurrentUser = this.CurrentUser
            };
            DialogResult isSelected = prisonerForm.ShowDialog();
            if (isSelected.Equals(DialogResult.Yes))
            {
                Prisoner selectedPrisoner = prisonerForm.SelectedPrisoner;
                PrisonerCaseReportForm caseReport = new PrisonerCaseReportForm()
                {
                    PrisonerRep = selectedPrisoner,
                    CaseTable = CurrentUser.GetPrisonerCases(selectedPrisoner.PrisonerNo)
                };
                caseReport.ShowDialog();
            }
        }
    }
}
