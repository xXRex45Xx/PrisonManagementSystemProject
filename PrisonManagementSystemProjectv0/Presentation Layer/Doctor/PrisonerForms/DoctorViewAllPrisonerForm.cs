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
    public partial class DoctorViewAllPrisonerForm : Form
    {
        public Doctor CurrentUser { set; get; }
        private string _selectedTable = "Prisoner";
        public DoctorViewAllPrisonerForm()
        {
            InitializeComponent();
        }

        private void btnPrisoner_Click(object sender, EventArgs e)
        {
            if (_selectedTable.Equals("Prisoner"))
                return;
            btnTreatment.BackColor = Color.FromArgb(51, 51, 76);
            btnPrisoner.BackColor = Color.FromArgb(51, 5, 76);
            dgvPrisoner.DataSource = CurrentUser.GetAllPrisoners();
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
            _selectedTable = "Prisoner";
            btnUpdate.Hide();
        }

        private void DoctorViewAllPrisonerForm_Shown(object sender, EventArgs e)
        {
            dgvPrisoner.DataSource = CurrentUser.GetAllPrisoners();
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            if ((_selectedTable.CompareTo("Prisoner") == 0 && dgvPrisoner.SelectedRows.Count == 0) ||
                _selectedTable.Equals("Treatment"))
                return;
            btnPrisoner.BackColor = Color.FromArgb(51, 51, 76);
            btnTreatment.BackColor = Color.FromArgb(51, 5, 76);
            int prisonerNo = Convert.ToInt32(dgvPrisoner.SelectedRows[0].Cells["prisonerNo"].Value);
            dgvPrisoner.DataSource = CurrentUser.GetPrisonerTreatment(prisonerNo);
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
            _selectedTable = "Treatment";
            btnUpdate.Show();
        }

        private void btnNewTreatment_Click(object sender, EventArgs e)
        {
            if (((_selectedTable.CompareTo("Prisoner") == 0) && dgvPrisoner.SelectedRows.Count == 0) ||
                _selectedTable.Equals("Treatment"))
                return;


            DataTable dataTable = CurrentUser.GetUserInfo();
            if(dataTable == null)
            {
                string error = "System Error! Please contact your system administrator";
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Prisoner currentPrisoner = new Prisoner()
            {
                PrisonerNo = Convert.ToInt32(dgvPrisoner.SelectedRows[0].Cells["prisonerNo"].Value),
                FirstName = dgvPrisoner.SelectedRows[0].Cells["fName"].Value.ToString(),
                LastName = dgvPrisoner.SelectedRows[0].Cells["lName"].Value.ToString()
            };

            DoctorInfo currentDoctor = new DoctorInfo()
            {
                DoctorNo = dataTable.Rows[0].Field<int>("doctorNo"),
                FirstName = dataTable.Rows[0].Field<string>("fName"),
                LastName = dataTable.Rows[0].Field<string>("lName")
            };

            NewTreatmentForm newTreatment = new NewTreatmentForm()
            {
                CurrentUser = this.CurrentUser,
                CurrentDoctor = currentDoctor,
                CurrentPrisoner = currentPrisoner                
            };
            newTreatment.ShowDialog();
        }

        private void dgvPrisoner_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPrisoner.SelectedRows.Count > 1)
            {
                btnNewTreatment.Hide();
                btnTreatment.Hide();
            }
            else
            {
                btnNewTreatment.Show();
                btnTreatment.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime dateOfTreatment;
            dateOfTreatment = (DateTime)dgvPrisoner.SelectedRows[0].Cells["dateOfTreatment"].Value;
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
                DoctorNo = Convert.ToInt32(dgvPrisoner.SelectedRows[0].Cells["DoctorNumber"].Value)
            };
            if (currentDoctor.DoctorNo != treatmentDoctor.DoctorNo)
            {
                string msg = "Permission Denied! Cannot modify another doctor's treatments!";
                MessageBox.Show(msg, "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Prisoner currentPrisoner = new Prisoner()
            {
                PrisonerNo = Convert.ToInt32(dgvPrisoner.SelectedRows[0].Cells["PrisonerNumber"].Value),
                FirstName = dgvPrisoner.SelectedRows[0].Cells["PrisonerFirstName"].Value.ToString(),
                LastName = dgvPrisoner.SelectedRows[0].Cells["PrisonerLastName"].Value.ToString()
            };

            Treatment currentTreatment = new Treatment()
            {
                PrisonerNo = currentPrisoner.PrisonerNo,
                DoctorNo = currentDoctor.DoctorNo,
                DateOfTreatment = (DateTime)dgvPrisoner.SelectedRows[0].Cells["dateOfTreatment"].Value,
                Diagnosis = dgvPrisoner.SelectedRows[0].Cells["diagnosis"].Value.ToString()
            };

            UpdateTreatmentForm treatmentForm = new UpdateTreatmentForm()
            {
                CurrentDoctor = currentDoctor,
                CurrentPrisoner = currentPrisoner,
                CurrentUser = this.CurrentUser,
                CurrentTreatment = currentTreatment
            };

            treatmentForm.ShowDialog();
            btnPrisoner.PerformClick();
        }
    }
}
