using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystemProjectv0
{
    public partial class AdministratorForm : Form
    {
        private bool _increase, _navigationBarLocked = false;

        public Administrator CurrentUser { set; get; }
        public AdministratorForm()
        {
            InitializeComponent();
            this.Text = string.Empty;            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void AdministratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnUsers_MouseDown(object sender, MouseEventArgs e)
        {
            //btnEmployee.BackColor = Color.Gold;
            //btnEmployee.ForeColor = Color.FromArgb(51, 51, 76);            
        }

        private void btnUsers_MouseUp(object sender, MouseEventArgs e)
        {
            //btnEmployee.BackColor = Color.FromArgb(51, 51, 76);
        }        

        private void pnlControls_MouseEnter(object sender, EventArgs e)
        {            
            _increase = true;
            timer.Start();

        }

        private void pnlMainPanel_MouseEnter(object sender, EventArgs e)
        {
            if (_navigationBarLocked)
                return;
            _increase = false;
            foreach (Control control in pnlControls.Controls)
                if (control is Panel)
                    control.Hide();
            timer.Start();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (!pnlEMSubMenu.Visible)
            {
                pnlPrisonerSubMenu.Hide();
                pnlVisitorSubMenu.Hide();
                pnlEMSubMenu.Show();
            }
            else
                pnlEMSubMenu.Hide();            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_increase)
            {
                if (pnlControls.Width >= 220)
                    timer.Stop();
                else
                {
                    btnEmployee.Width += 40;
                    btnVisitor.Width += 40;
                    btnPrisoner.Width += 40;
                    pnlControls.Width += 40;
                }
            }
            else
            {
                if (pnlControls.Width <= 75)
                    timer.Stop();
                else
                {
                    btnEmployee.Width -= 40;
                    btnVisitor.Width -= 40;
                    btnPrisoner.Width -= 40;
                    pnlControls.Width -= 40;
                }
            }
        }        

        private void btnPrisoner_Click(object sender, EventArgs e)
        {
            if (!pnlPrisonerSubMenu.Visible)
            {
                pnlEMSubMenu.Hide();
                pnlVisitorSubMenu.Hide();
                pnlPrisonerSubMenu.Show();
            }
            else
                pnlPrisonerSubMenu.Hide();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            if (!pnlVisitorSubMenu.Visible)
            {
                pnlEMSubMenu.Hide();
                pnlPrisonerSubMenu.Hide();
                pnlVisitorSubMenu.Show();
            }
            else
                pnlVisitorSubMenu.Hide();
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = btnExit.Parent.BackColor;
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            /*if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;*/
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

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "New Employee";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is NewEmployeeForm)
                    return;                
            pnlMainPanel.Controls.Clear();
            NewEmployeeForm employeeForm = new NewEmployeeForm()
            {
                TopLevel = false,
                TopMost = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser                
            };
            //employeeForm.MouseEnter += new EventHandler(pnlMainPanel_MouseEnter);            
            pnlMainPanel.Controls.Add(employeeForm);

        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "Employee Search";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is SearchEmployeeForm)
                    return;
            pnlMainPanel.Controls.Clear();
            SearchEmployeeForm employeeForm = new SearchEmployeeForm()
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(employeeForm);

        }

        private void btnAllEmployee_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "All Employees";
            foreach(Control control in pnlMainPanel.Controls)
                if(control is ViewAllEmployeeForm)
                    return;
            pnlMainPanel.Controls.Clear();
            ViewAllEmployeeForm employeeForm = new ViewAllEmployeeForm()
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(employeeForm);            
        }

        private void btnSearchPrisoner_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "Prisoner Search";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is SearchPrisonerForm)
                    return;
            pnlMainPanel.Controls.Clear();
            SearchPrisonerForm prisonerForm = new SearchPrisonerForm()
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(prisonerForm);
        }

        private void btnAllPrisoner_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "All Prisoners";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is ViewAllPrisonerForm)
                    return;
            pnlMainPanel.Controls.Clear();
            ViewAllPrisonerForm prisonerForm = new ViewAllPrisonerForm()
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(prisonerForm);
        }

        private void btnSearchVisitor_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "Visitor Search";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is SearchVisitorForm)
                    return;
            pnlMainPanel.Controls.Clear();
            SearchVisitorForm visitorForm = new SearchVisitorForm()
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(visitorForm);
        }

        private void btnAllVisitors_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "All Visitors";
            foreach (Control control in pnlMainPanel.Controls)
                if (control is ViewAllVisitorForm)
                    return;
            pnlMainPanel.Controls.Clear();
            ViewAllVisitorForm visitorForm = new ViewAllVisitorForm()
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                CurrentUser = this.CurrentUser
            };
            pnlMainPanel.Controls.Add(visitorForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblFormName.Text = "User";
        }

        private void pnlBorder_DoubleClick(object sender, EventArgs e)
        {
            btnMaxMin.PerformClick();
        }

        private void btnLockUnlockNav_Click(object sender, EventArgs e)
        {
            if (_navigationBarLocked)
            {              
                _navigationBarLocked = false;
            }
            else
            {
                pnlControls.Dock = DockStyle.Left;                
                _navigationBarLocked = true;
            }
        }
    }
}
