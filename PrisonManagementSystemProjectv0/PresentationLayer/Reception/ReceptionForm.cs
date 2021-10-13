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
    public partial class ReceptionForm : Form
    {
        public Reception CurrentUser { set; get; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public ReceptionForm()
        {
            InitializeComponent();
        }

        private void btnNewVisitor_Click(object sender, EventArgs e)
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
            if (this.Size.Equals(Screen.PrimaryScreen.WorkingArea.Size))
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

        private void btnAllPrisoner_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "All Prisoners";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is ReceptionViewAllPrisonerForm)
                    return;
            pnlMainPanel.Controls.Clear();
            ReceptionViewAllPrisonerForm prisonerForm = new ReceptionViewAllPrisonerForm()
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(prisonerForm);
        }

        private void btnSearchPrisoner_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "Prisoner Search";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is ReceptionSearchPrisonerForm)
                    return;
            pnlMainPanel.Controls.Clear();
            ReceptionSearchPrisonerForm prisonerForm = new ReceptionSearchPrisonerForm()
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(prisonerForm);
        }

        private void btnPrisoner_Click(object sender, EventArgs e)
        {
            if (!pnlPrisonerSubMenu.Visible)
            {
                pnlVisitorSubMenu.Hide();
                pnlVisitSubMenu.Hide();
                pnlPrisonerSubMenu.Show();
            }
            else
                pnlPrisonerSubMenu.Hide();
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            if (!pnlVisitorSubMenu.Visible)
            {
                pnlVisitSubMenu.Hide();
                pnlPrisonerSubMenu.Hide();
                pnlVisitorSubMenu.Show();
            }
            else
                pnlVisitorSubMenu.Hide();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            if (!pnlVisitSubMenu.Visible)
            {
                pnlVisitorSubMenu.Hide();
                pnlPrisonerSubMenu.Hide();
                pnlVisitSubMenu.Show();
            }
            else
                pnlVisitSubMenu.Hide();
        }

        private void btnAllVisitors_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "All Visitors";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is ReceptionViewAllVisitorForm)
                    return;
            pnlMainPanel.Controls.Clear();
            ReceptionViewAllVisitorForm visitorForm = new ReceptionViewAllVisitorForm()
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(visitorForm);
        }

        private void btnSearchVisitor_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "Visitor Search";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is ReceptionSearchVisitorForm)
                    return;
            pnlMainPanel.Controls.Clear();
            ReceptionSearchVisitorForm visitorForm = new ReceptionSearchVisitorForm()
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(visitorForm);
        }

        private void btnAllVisits_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "All Visits";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is ViewAllVisitForm)
                    return;
            pnlMainPanel.Controls.Clear();
            ViewAllVisitForm visitForm = new ViewAllVisitForm()
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(visitForm);
        }

        private void btnSearchVisit_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "Visit Search";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is SearchVisitForm)
                    return;
            pnlMainPanel.Controls.Clear();
            SearchVisitForm visitForm = new SearchVisitForm()
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(visitForm);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!pnlUserSubMenu.Visible)
            {
                pnlPrisonerSubMenu.Hide();
                pnlVisitorSubMenu.Hide();
                pnlVisitorSubMenu.Hide();
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

        private void ReceptionForm_Shown(object sender, EventArgs e)
        {
            btnHomePage.PerformClick();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "Home";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is ReceptionDashboardForm)
                    return;
            pnlMainPanel.Controls.Clear();
            ReceptionDashboardForm dashboardForm = new ReceptionDashboardForm()
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                Visible = true,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(dashboardForm);
        }
    }
}
