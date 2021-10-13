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
    public partial class ViewAllVisitForm : Form
    {
        public Reception CurrentUser { set; get; }
        public ViewAllVisitForm()
        {
            InitializeComponent();
        }

        private void ViewAllVisitForm_Shown(object sender, EventArgs e)
        {
            dgvVisit.DataSource = CurrentUser.GetAllVisits();
            if (dgvVisit.Rows.Count > 0)
                dgvVisit.SelectedRows[0].Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvVisit.SelectedRows)
            {
                Visit visit = new Visit()
                {
                    VisitorNo = Convert.ToInt32(row.Cells["VisitorNumber"].Value),
                    PrisonerNo = Convert.ToInt32(row.Cells["PrisonerNumber"].Value),
                    DateOfVisit = Convert.ToDateTime(row.Cells["dateOfVisit"].Value)
                };
                if (DateTime.Now.Subtract(Convert.ToDateTime(visit.DateOfVisit)).Days >= 1)
                {
                    string msg = String.Format("Records can't be modified after a day! Record given below won't be deleted!\n" + 
                        "Visitor Number: {0}\n" + 
                        "Prisoner Number: {1}\n" + 
                        "Date of Visit: {2}\n", visit.VisitorNo, visit.PrisonerNo, visit.DateOfVisit);
                    MessageBox.Show(msg, "Delete Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }
                int rowsDeleted = CurrentUser.DeleteVisit(visit);
                if (rowsDeleted > 0)
                {
                    dgvVisit.Rows.Remove(row);
                }
                else if (rowsDeleted == 0)
                {
                    string errorMessage = string.Format("Error deleting visit with\n" +
                        "Visitor Number: {0}\n" +
                        "Prisoner Number: {1}\n" +
                        "Date of Visit: {2}\n", visit.VisitorNo, visit.PrisonerNo, visit.DateOfVisit);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Deletion Done!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
