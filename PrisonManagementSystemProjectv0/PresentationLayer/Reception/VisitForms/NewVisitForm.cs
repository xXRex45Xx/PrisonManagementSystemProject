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
    public partial class NewVisitForm : Form
    {
        public Reception CurrentUser { set; get; }
        public Visitor CurrentVisitor { set; get; }
        public Prisoner CurrentPrisoner { set; get; }
        public NewVisitForm()
        {
            InitializeComponent();
        }

        private void chkCurrentDT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCurrentDT.Checked)
            {
                dtpDate.Enabled = false;
                dtpTime.Enabled = false;
            }
            else
            {
                dtpDate.Enabled = true;
                dtpTime.Enabled = true;
            }
        }

        private void NewVisitForm_Shown(object sender, EventArgs e)
        {
            lblPrisonerNumber.Text = CurrentPrisoner.PrisonerNo.ToString();
            lblPrisosnerFirstName.Text = CurrentPrisoner.FirstName;
            lblPrisonerLastName.Text = CurrentPrisoner.LastName;

            lblVisitorNumber.Text = CurrentVisitor.VisitorNo.ToString();
            lblVisitorFirstName.Text = CurrentVisitor.FirstName;
            lblVisitorLastName.Text = CurrentVisitor.LastName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Visit visit = new Visit()
            {
                PrisonerNo = CurrentPrisoner.PrisonerNo,
                VisitorNo = CurrentVisitor.VisitorNo
            };

            if (chkCurrentDT.Checked)
            {
                visit.DateOfVisit = DateTime.Now;
                visit.TimeOfVisit = DateTime.Now;
            }
            else
            {
                visit.DateOfVisit = dtpDate.Value;
                visit.TimeOfVisit = dtpTime.Value;
            }

            int rowsAdded = CurrentUser.AddVisit(visit);
            if (rowsAdded > 0)
            {
                string message = "Visit Registered Successfully";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (rowsAdded == 0)
            {
                string error = "Error During Data Insertion! Restart your computer. If error persists constact your system administrator.";
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
