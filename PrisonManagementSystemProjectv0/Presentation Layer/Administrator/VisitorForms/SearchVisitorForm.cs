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
    public partial class SearchVisitorForm : Form
    {
        public Administrator CurrentUser { set; get; }

        private string _selectedTable = "";
        private DataTable SearchResult = null;
        public SearchVisitorForm()
        {
            InitializeComponent();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            if ((_selectedTable.CompareTo("Visitor") == 0 && dgvVisitor.SelectedRows.Count == 0) ||
               !_selectedTable.Equals("Visitor"))
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

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            if (_selectedTable.Equals("Visitor") || SearchResult == null)
                return;            
            btnVisit.BackColor = Color.FromArgb(51, 51, 76);
            btnVisitor.BackColor = Color.FromArgb(51, 5, 76);
            btnDelete.Show();
            dgvVisitor.DataSource = SearchResult;
            if (dgvVisitor.Rows.Count > 0)
                dgvVisitor.SelectedRows[0].Selected = false;
            _selectedTable = "Visitor";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedIndex < 0 || txtSearchValue.Text.Equals(""))
                return;
            SearchResult = CurrentUser.SearchVisitor(txtSearchValue.Text, cmbSearchBy.SelectedItem.ToString());
            _selectedTable = "";
            btnVisitor.PerformClick();
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedIndex == 0)
            {
                txtSearchValue.Clear();
                txtSearchValue.KeyPress += new KeyPressEventHandler(txtSearchValue_KeyPress);
            }
            else
            {
                txtSearchValue.KeyPress -= new KeyPressEventHandler(txtSearchValue_KeyPress);
            }
        }

        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
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

        private void dgvVisitor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVisitor.SelectedRows.Count > 1)
                btnVisit.Hide();
            else
                btnVisit.Show();
        }
    }
}
