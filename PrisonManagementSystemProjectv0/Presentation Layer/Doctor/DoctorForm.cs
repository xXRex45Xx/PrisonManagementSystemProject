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
            pnlTreatmentSubMenu.Show();
            pnlPrisonerSubMenu.Hide();
        }

        private void btnPrisoner_Click(object sender, EventArgs e)
        {
            pnlPrisonerSubMenu.Show();
            pnlTreatmentSubMenu.Hide();
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
    }
}
