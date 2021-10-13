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
    public partial class SearchPrisonerForm : Form
    {
        public Administrator CurrentUser { set; get; }

        private string _selectedTable = "";
        private DataTable _searchResult = null;
        public SearchPrisonerForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedIndex < 0 || txtSearchValue.Text.Equals(""))
                return;
            _searchResult = CurrentUser.SearchPrisoner(txtSearchValue.Text, cmbSearchBy.SelectedItem.ToString());
            _selectedTable = "";
            btnPrisoner.PerformClick();
        }

        private void btnPrisoner_Click(object sender, EventArgs e)
        {            
            if (_selectedTable.Equals("Prisoner")  || _searchResult == null)
                return;
            btnTreatment.BackColor = Color.FromArgb(51, 51, 76);
            btnVisit.BackColor = Color.FromArgb(51, 51, 76);
            btnPrisoner.BackColor = Color.FromArgb(51, 5, 76);
            btnDelete.Show();
            dgvPrisoner.DataSource = _searchResult;
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
            _selectedTable = "Prisoner";
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            if ((_selectedTable.CompareTo("Prisoner") == 0 && dgvPrisoner.SelectedRows.Count == 0) ||
               _selectedTable.Equals("Visit") || _selectedTable.CompareTo("Prisoner") != 0)
                return;
            btnTreatment.BackColor = Color.FromArgb(51, 51, 76);
            btnPrisoner.BackColor = Color.FromArgb(51, 51, 76);
            btnVisit.BackColor = Color.FromArgb(51, 5, 76);
            btnDelete.Hide();
            int prisonerNo = Convert.ToInt32(dgvPrisoner.SelectedRows[0].Cells["prisonerNo"].Value);
            dgvPrisoner.DataSource = CurrentUser.GetPrisonerVisit(prisonerNo);
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
            _selectedTable = "Visit";
        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            if ((_selectedTable.CompareTo("Prisoner") == 0 && dgvPrisoner.SelectedRows.Count == 0) ||
                 _selectedTable.Equals("Treatment") || _selectedTable.CompareTo("Prisoner") != 0)
                return;
            btnVisit.BackColor = Color.FromArgb(51, 51, 76);
            btnPrisoner.BackColor = Color.FromArgb(51, 51, 76);
            btnTreatment.BackColor = Color.FromArgb(51, 5, 76);
            btnDelete.Hide();
            int prisonerNo = Convert.ToInt32(dgvPrisoner.SelectedRows[0].Cells["prisonerNo"].Value);
            dgvPrisoner.DataSource = CurrentUser.GetPrisonerTreatment(prisonerNo);
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
            _selectedTable = "Treatment";
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
            if (dgvPrisoner.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show("Are you sure you want to permanently delete the selected rows?", "Delete Rows", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                List<int> deleteList = new List<int>();
                if (_selectedTable.Equals("Prisoner"))
                {
                    foreach (DataGridViewRow row in dgvPrisoner.SelectedRows)
                        deleteList.Add(Convert.ToInt32(row.Cells["prisonerNo"].Value));
                    foreach (int prisonerNo in deleteList)
                    {
                        Treatment treatment = new Treatment();
                        Visit visit = new Visit();
                        foreach (DataGridViewRow row in dgvPrisoner.SelectedRows)
                        {
                            treatment.DeletePrisonerTreatment(prisonerNo);
                            visit.DeletePrisonerVisit(prisonerNo);
                        }
                        int rowsDeleted = CurrentUser.DeletePrisoner(prisonerNo);
                        if (rowsDeleted > 0)
                        {

                            foreach (DataGridViewRow row in dgvPrisoner.SelectedRows)
                            {
                                if (prisonerNo == Convert.ToInt32(row.Cells["prisonerNo"].Value))
                                    dgvPrisoner.Rows.Remove(row);
                            }
                        }
                        else if (rowsDeleted == 0)
                        {
                            deleteError = true;
                            string errorMessage = string.Format("Error deleting prisoner with id: {0}", prisonerNo);
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

        private void dgvPrisoner_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPrisoner.SelectedRows.Count > 1)
            {
                btnTreatment.Hide();
                btnVisit.Hide();
            }
            else
            {
                btnTreatment.Show();
                btnVisit.Show();
            }
        }
    }
}
