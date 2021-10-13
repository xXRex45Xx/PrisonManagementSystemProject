using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystemProjectv0
{
    public partial class DoctorForm : Form
    {
        public Doctor CurrentUser { set; get; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void btnNewTreatment_Click(object sender, EventArgs e)
        {

        }

        private void pnlBorder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = btnExit.Parent.BackColor;
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (this.Size.Equals(Screen.PrimaryScreen.WorkingArea.Size) || 
                this.WindowState.Equals(FormWindowState.Maximized))
            {
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = new Size(1311, 815);
            }
            else
            {
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlBorder_DoubleClick(object sender, EventArgs e)
        {
            btnMaxMin.PerformClick();
        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            if (!pnlTreatmentSubMenu.Visible)
            {
                pnlPrisonerSubMenu.Hide();
                pnlReportSubMenu.Hide();
                pnlTreatmentSubMenu.Show();                
            }
            else
                pnlTreatmentSubMenu.Hide();
        }

        private void btnPrisoner_Click(object sender, EventArgs e)
        {
            if (!pnlPrisonerSubMenu.Visible)
            {
                pnlTreatmentSubMenu.Hide();
                pnlReportSubMenu.Hide();
                pnlPrisonerSubMenu.Show();                
            }
            else
                pnlPrisonerSubMenu.Hide();
        }

        private void btnSearchTreatment_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "Treatment Search";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is SearchTreatmentForm)
                    return;
            pnlMainPanel.Controls.Clear();
            SearchTreatmentForm treatmentForm = new SearchTreatmentForm()
            {
                TopLevel = false,
                TopMost = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };            
            pnlMainPanel.Controls.Add(treatmentForm);
        }

        private void btnAllTreatments_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "All Treatments";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is ViewAllTreatmentForm)
                    return;
            pnlMainPanel.Controls.Clear();
            ViewAllTreatmentForm treatmentForm = new ViewAllTreatmentForm()
            {
                TopLevel = false,
                TopMost = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(treatmentForm);
        }

        private void btnSearchPrisoner_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "Prisoner Search";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is DoctorSearchPrisonForm)
                    return;
            pnlMainPanel.Controls.Clear();
            DoctorSearchPrisonForm treatmentForm = new DoctorSearchPrisonForm()
            {
                TopLevel = false,
                TopMost = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(treatmentForm);
        }

        private void btnAllPrisoner_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "All Prisoners";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is DoctorViewAllPrisonerForm)
                    return;
            pnlMainPanel.Controls.Clear();
            DoctorViewAllPrisonerForm treatmentForm = new DoctorViewAllPrisonerForm()
            {
                TopLevel = false,
                TopMost = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(treatmentForm);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!pnlUserSubMenu.Visible)
            {
                pnlPrisonerSubMenu.Hide();
                pnlTreatmentSubMenu.Hide();
                pnlUserSubMenu.Show();
            }
            else
                pnlUserSubMenu.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnChangeCredentials_Click(object sender, EventArgs e)
        {
            ChangeUserCredentialsForm credentialsForm = new ChangeUserCredentialsForm()
            {
                CurrentUser = this.CurrentUser
            };
            DialogResult changed = credentialsForm.ShowDialog();
            if (changed.Equals(DialogResult.Yes))
            {
                MessageBox.Show("Please login with your new username and password.", "Re-login", MessageBoxButtons.OK);
                btnLogout.PerformClick();
            }
        }

        private void DoctorForm_Shown(object sender, EventArgs e)
        {
            btnHomePage.PerformClick();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "Home";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is DoctorDashboardForm)
                    return;
            pnlMainPanel.Controls.Clear();
            DoctorDashboardForm dashboardForm = new DoctorDashboardForm()
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                Visible = true,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(dashboardForm);
        }

        private void btnPrisonerReports_Click(object sender, EventArgs e)
        {
            SelectPrisonerForm prisonerForm = new SelectPrisonerForm()
            {
                CurrentUser = this.CurrentUser
            };
            DialogResult isSelected = prisonerForm.ShowDialog();
            if (isSelected.Equals(DialogResult.Yes))
            {
                Prisoner selectedPrisoner = prisonerForm.SelectedPrisoner;
                PrisonerTreatmentReportForm treatmentReportForm = new PrisonerTreatmentReportForm()
                {
                    PrisonerRep = selectedPrisoner,
                    TreatmentTable = CurrentUser.GetPrisonerTreatment(selectedPrisoner.PrisonerNo)
                };
                treatmentReportForm.ShowDialog();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (!pnlReportSubMenu.Visible)
            {
                pnlTreatmentSubMenu.Hide();
                pnlPrisonerSubMenu.Hide();
                pnlReportSubMenu.Show();
            }
            else
                pnlReportSubMenu.Hide();
        }

        private void btnDoctorReports_Click(object sender, EventArgs e)
        {
            DataTable doctorData = CurrentUser.GetUserInfo();
            DoctorInfo doctor = new DoctorInfo()
            {
                DoctorNo = doctorData.Rows[0].Field<int>("doctorNo"),
                FirstName = doctorData.Rows[0].Field<string>("fName"),
                LastName = doctorData.Rows[0].Field<string>("fName")
            };
            DoctorTreatmentReportForm treatmentReportForm = new DoctorTreatmentReportForm()
            {
                DoctorRep = doctor,
                TreatmentTable = CurrentUser.GetDoctorTreatment(doctor.DoctorNo)
            };
            treatmentReportForm.ShowDialog();
        }
    }
}
