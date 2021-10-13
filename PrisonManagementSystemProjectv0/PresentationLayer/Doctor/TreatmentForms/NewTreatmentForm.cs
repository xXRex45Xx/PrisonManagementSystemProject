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
    public partial class NewTreatmentForm : Form
    {
        public Doctor CurrentUser { set; get; }
        public DoctorInfo CurrentDoctor { set; get; }
        public Prisoner CurrentPrisoner { set; get; }

        public NewTreatmentForm()
        {
            InitializeComponent();            
        }

        private void chkCurrentDT_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCurrentDT.Checked)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDiagnosis.Text.Equals(""))
            {
                MessageBox.Show("Diagnosis Field is Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Treatment treatment = new Treatment()
            {
                PrisonerNo = CurrentPrisoner.PrisonerNo,
                DoctorNo = CurrentDoctor.DoctorNo,
                Diagnosis = txtDiagnosis.Text
            };

            if (chkCurrentDT.Checked)
            {
                treatment.DateOfTreatment = DateTime.Now;
                treatment.TimeOfTreatment = DateTime.Now;
            }
            else
            {
                treatment.DateOfTreatment = dtpDate.Value;
                treatment.TimeOfTreatment = dtpTime.Value;
            }

            int rowsAdded = CurrentUser.AddTreatment(treatment);
            if (rowsAdded > 0)
            {
                string message = "Treatment Registered Successfully";                
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (rowsAdded == 0)
            {
                string error = "Error During Data Insertion! Restart your computer. If error persists constact your system administrator.";
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewTreatmentForm_Shown(object sender, EventArgs e)
        {
            lblPrisonerNumber.Text = CurrentPrisoner.PrisonerNo.ToString();
            lblPrisosnerFirstName.Text = CurrentPrisoner.FirstName;
            lblPrisonerLastName.Text = CurrentPrisoner.LastName;

            lblDoctorNumber.Text = CurrentDoctor.DoctorNo.ToString();
            lblDoctorFirstName.Text = CurrentDoctor.FirstName;
            lblDoctorLastName.Text = CurrentDoctor.LastName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
