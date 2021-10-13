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
    public partial class UpdateTreatmentForm : Form
    {
        public Doctor CurrentUser { set; get; }
        public DoctorInfo CurrentDoctor { set; get; }
        public Prisoner CurrentPrisoner { set; get; }
        public Treatment CurrentTreatment { set; get; }
            public UpdateTreatmentForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtDiagnosis.Text.Equals(""))
            {
                MessageBox.Show("Diagnosis not specified!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CurrentTreatment.Diagnosis = txtDiagnosis.Text;
            int rows = CurrentUser.UpdateTreatment(CurrentTreatment);
            if (rows > 0)
            {
                string message = "Treatment Updated Successfully";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (rows == 0)
            {
                string error = "Error During Treatment Update! Restart your computer. If error persists constact your system administrator.";
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTreatmentForm_Shown(object sender, EventArgs e)
        {
            lblPrisonerNumber.Text = CurrentPrisoner.PrisonerNo.ToString();
            lblPrisosnerFirstName.Text = CurrentPrisoner.FirstName;
            lblPrisonerLastName.Text = CurrentPrisoner.LastName;

            lblDoctorNumber.Text = CurrentDoctor.DoctorNo.ToString();
            lblDoctorFirstName.Text = CurrentDoctor.FirstName;
            lblDoctorLastName.Text = CurrentDoctor.LastName;

            dtpDate.Value = CurrentTreatment.DateOfTreatment;

            txtDiagnosis.Text = CurrentTreatment.Diagnosis;            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
