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
    public partial class SearchEmployeeForm : Form
    {
        private string _selectedRole;
        public Administrator CurrentUser { set; get; }
        public SearchEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedIndex < 0 || txtSearchValue.Text.Equals("") || _selectedRole == null)
                return;
            dgvEmployee.DataSource = CurrentUser.SearchEmployee(txtSearchValue.Text, cmbSearchBy.SelectedItem.ToString(), _selectedRole);
        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            btnDoctor.BackColor = Color.FromArgb(51, 51, 76);
            btnReception.BackColor = Color.FromArgb(51, 51, 76);
            btnGuard.BackColor = Color.FromArgb(51,5,76);
            _selectedRole = "Guard";
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            btnGuard.BackColor = Color.FromArgb(51, 51, 76);
            btnReception.BackColor = Color.FromArgb(51, 51, 76);
            btnDoctor.BackColor = Color.FromArgb(51,5,76);
            _selectedRole = "Doctor";
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            btnGuard.BackColor = Color.FromArgb(51, 51, 76);
            btnDoctor.BackColor = Color.FromArgb(51, 51, 76);
            btnReception.BackColor = Color.FromArgb(51,5,76);
            _selectedRole = "Reception";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool deleteError = false;
            if (dgvEmployee.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show("Are you sure you want to permanently delete the selected rows?", "Delete Rows", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                List<int> deleteList = new List<int>();
                if (_selectedRole.Equals("Reception"))
                {
                    foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
                        deleteList.Add(Convert.ToInt32(row.Cells["receptionNo"].Value));
                    foreach (int receptionNo in deleteList)
                    {
                        int rowsDeleted = CurrentUser.DeleteEmployee(receptionNo, _selectedRole);
                        if (rowsDeleted > 0)
                        {
                            foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
                            {
                                if (receptionNo == Convert.ToInt32(row.Cells["receptionNo"].Value))
                                    dgvEmployee.Rows.Remove(row);
                            }
                        }
                        else
                        {
                            deleteError = true;
                            string errorMessage = string.Format("Error deleting receptionist with id: {0}", receptionNo);
                            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (!deleteError)
                    {
                        MessageBox.Show("Deletion Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (_selectedRole.Equals("Doctor"))
                {
                    foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
                        deleteList.Add(Convert.ToInt32(row.Cells["doctorNo"].Value));
                    foreach (int doctorNo in deleteList)
                    {
                        int rowsDeleted = CurrentUser.DeleteEmployee(doctorNo, _selectedRole);
                        if (rowsDeleted > 0)
                        {
                            foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
                            {
                                if (doctorNo == Convert.ToInt32(row.Cells["doctorNo"].Value))
                                    dgvEmployee.Rows.Remove(row);
                            }
                        }
                        else
                        {
                            deleteError = true;
                            string errorMessage = string.Format("Error deleting doctor with id: {0}", doctorNo);
                            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (!deleteError)
                    {
                        MessageBox.Show("Deletion Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (_selectedRole.Equals("Guard"))
                {
                    foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
                        deleteList.Add(Convert.ToInt32(row.Cells["guardNo"].Value));
                    foreach (int guardNo in deleteList)
                    {
                        int rowsDeleted = CurrentUser.DeleteEmployee(guardNo, _selectedRole);
                        if (rowsDeleted > 0)
                        {
                            foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
                            {
                                if (guardNo == Convert.ToInt32(row.Cells["guardNo"].Value))
                                    dgvEmployee.Rows.Remove(row);
                            }
                        }
                        else
                        {
                            deleteError = true;
                            string errorMessage = string.Format("Error deleting doctor with id: {0}", guardNo);
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

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSearchBy.SelectedIndex == 0)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
                return;
            UpdateEmployeForm updateEmployee = new UpdateEmployeForm()
            {
                Role = this._selectedRole,
                FirstName = dgvEmployee.SelectedRows[0].Cells["FirstName"].Value.ToString(),
                LastName = dgvEmployee.SelectedRows[0].Cells["LastName"].Value.ToString(),
                PhoneNumber = dgvEmployee.SelectedRows[0].Cells["phoneNo"].Value.ToString(),
                Email = dgvEmployee.SelectedRows[0].Cells["email"].Value.ToString(),
                Address = dgvEmployee.SelectedRows[0].Cells["address"].Value.ToString(),
                DateOfBirth = DateTime.Parse(dgvEmployee.SelectedRows[0].Cells["dateOfBirth"].Value.ToString()),
                EmployeeNumber = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells[0].Value),
                CurrentUser = this.CurrentUser
            };
            if (_selectedRole.Equals("Guard"))
                updateEmployee.Block = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["blockNo"].Value);
            updateEmployee.ShowDialog();
            dgvEmployee.DataSource = CurrentUser.GetAllEmployee(_selectedRole);
        }

        private void dgvEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 1)
            {
                btnUpdate.Hide();
                btnResetCreds.Hide();
            }
            else
            {
                btnUpdate.Show();
                btnResetCreds.Show();
            }
        }
    }
}
