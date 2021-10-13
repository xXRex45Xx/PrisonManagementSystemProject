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
    public partial class ViewAllVisitorForm : Form
    {        
        public Administrator CurrentUser { set; get; }
        private string _selectedTable = "Visitor";
        public ViewAllVisitorForm()
        {
            InitializeComponent();
        }

        private void ViewAllVisitorForm_Shown(object sender, EventArgs e)
        {
            dgvVisitor.DataSource = CurrentUser.GetAllVisitors();
            if (dgvVisitor.Rows.Count > 0)
                dgvVisitor.SelectedRows[0].Selected = false;
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            if (_selectedTable.Equals("Visitor"))
                return;
            btnVisit.BackColor = Color.FromArgb(51, 51, 76);
            btnVisitor.BackColor = Color.FromArgb(51, 5, 76);
            btnDelete.Show();
            dgvVisitor.DataSource = CurrentUser.GetAllVisitors();
            if (dgvVisitor.Rows.Count > 0)
                dgvVisitor.SelectedRows[0].Selected = false;
            _selectedTable = "Visitor";
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            if ((_selectedTable.CompareTo("Visitor") == 0 && dgvVisitor.SelectedRows.Count == 0) ||
               _selectedTable.Equals("Visit"))
                return;
            btnVisitor.BackColor = Color.FromArgb(51, 51, 76);
            btnVisit.BackColor = Color.FromArgb(51, 5, 76);
            btnDelete.Hide();
            int visitorNo = Convert.ToInt32(dgvVisitor.SelectedRows[0].Cells["visitorNo"].Value);
            dgvVisitor.DataSource = CurrentUser.GetVisitorVisit(visitorNo);
            if (dgvVisitor.Rows.Count > 0)
                dgvVisitor.SelectedRows[0].Selected = false;
            _selectedTable = "Visit";
        }

        private void dgvVisitor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVisitor.SelectedRows.Count > 1)
                btnVisit.Hide();
            else
                btnVisit.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool deleteError = false;
            if (dgvVisitor.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show("Are you sure you want to permanently delete the selected rows?", "Delete Rows", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                List<int> deleteList = new List<int>();
                if (_selectedTable.Equals("Visitor"))
                {
                    foreach (DataGridViewRow row in dgvVisitor.SelectedRows)
                        deleteList.Add(Convert.ToInt32(row.Cells["visitorNo"].Value));
                    foreach (int visitorNo in deleteList)
                    {                        
                        Visit visit = new Visit();
                        foreach (DataGridViewRow row in dgvVisitor.SelectedRows)
                        {                             
                            visit.DeleteVisitorVisit(visitorNo);
                        }
                        int rowsDeleted = CurrentUser.DeleteVisitor(visitorNo);
                        if (rowsDeleted > 0)
                        {

                            foreach (DataGridViewRow row in dgvVisitor.SelectedRows)
                            {
                                if (visitorNo == Convert.ToInt32(row.Cells["visitorNo"].Value))
                                    dgvVisitor.Rows.Remove(row);
                            }
                        }
                        else if (rowsDeleted == 0)
                        {
                            deleteError = true;
                            string errorMessage = string.Format("Error deleting visitor with id: {0}", visitorNo);
                            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (!deleteError)
                    {
                        MessageBox.Show("Deletion Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
