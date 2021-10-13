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
    public partial class SearchTreatmentForm : Form
    {
        public Doctor CurrentUser { set; get; }
        public SearchTreatmentForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedIndex < 0 || txtSearchValue.Text.Equals(""))
                return;
            dgvTreatment.DataSource = CurrentUser.SearchTreatment(txtSearchValue.Text, cmbSearchBy.SelectedItem.ToString());
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedIndex == 0 || cmbSearchBy.SelectedIndex == 3)
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
            DateTime dateOfTreatment;
            dateOfTreatment = (DateTime)dgvTreatment.SelectedRows[0].Cells["dateOfTreatment"].Value;
            DataTable dataTable = CurrentUser.GetUserInfo();
            if (DateTime.Now.Subtract(dateOfTreatment).Days > 7)
            {
                string msg = "Records can't be modified after 7 days!";
                MessageBox.Show(msg, "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataTable == null)
            {
                string error = "System Error! Please contact your system administrator";
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DoctorInfo currentDoctor = new DoctorInfo()
            {
                DoctorNo = dataTable.Rows[0].Field<int>("doctorNo"),
                FirstName = dataTable.Rows[0].Field<string>("fName"),
                LastName = dataTable.Rows[0].Field<string>("lName")
            };
            DoctorInfo treatmentDoctor = new DoctorInfo()
            {
                DoctorNo = Convert.ToInt32(dgvTreatment.SelectedRows[0].Cells["DoctorNumber"].Value)
            };
            if (currentDoctor.DoctorNo != treatmentDoctor.DoctorNo)
            {
                string msg = "Permission Denied! Cannot modify another doctor's treatments!";
                MessageBox.Show(msg, "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Prisoner currentPrisoner = new Prisoner()
            {
                PrisonerNo = Convert.ToInt32(dgvTreatment.SelectedRows[0].Cells["PrisonerNumber"].Value),
                FirstName = dgvTreatment.SelectedRows[0].Cells["PrisonerFirstName"].Value.ToString(),
                LastName = dgvTreatment.SelectedRows[0].Cells["PrisonerLastName"].Value.ToString()
            };

            Treatment currentTreatment = new Treatment()
            {
                PrisonerNo = currentPrisoner.PrisonerNo,
                DoctorNo = currentDoctor.DoctorNo,
                DateOfTreatment = (DateTime)dgvTreatment.SelectedRows[0].Cells["dateOfTreatment"].Value,
                Diagnosis = dgvTreatment.SelectedRows[0].Cells["diagnosis"].Value.ToString()
            };

            UpdateTreatmentForm treatmentForm = new UpdateTreatmentForm()
            {
                CurrentDoctor = currentDoctor,
                CurrentPrisoner = currentPrisoner,
                CurrentUser = this.CurrentUser,
                CurrentTreatment = currentTreatment
            };

            treatmentForm.ShowDialog();
            btnSearch.PerformClick();
        }

        private void dgvTreatment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTreatment.SelectedRows.Count > 1)
                btnUpdate.Hide();
            else
                btnUpdate.Show();
        }
    }
}
