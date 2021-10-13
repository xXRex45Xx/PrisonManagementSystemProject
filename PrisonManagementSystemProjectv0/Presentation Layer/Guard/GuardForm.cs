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
    public partial class GuardForm : Form
    {
        public Guard CurrentUser { set; get; }

        private string _selectedTable = "";

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public GuardForm()
        {
            InitializeComponent();
        }

        private void btnAddPrisoner_Click(object sender, EventArgs e)
        {            
            NewPrisonerForm prisonerForm = new NewPrisonerForm()
            {                
                CurrentUser = this.CurrentUser
            };
            prisonerForm.ShowDialog();
            btnAllPrisoners.PerformClick();
            btnAllPrisoners.PerformClick();
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

        private void pnlBorder_DoubleClick(object sender, EventArgs e)
        {
            btnMaxMin.PerformClick();
        }

        private void GuardForm_Shown(object sender, EventArgs e)
        {
            btnAllPrisoners.PerformClick();
        }

        private void btnAllPrisoners_Click(object sender, EventArgs e)
        {
            if (_selectedTable.Equals("Prisoner"))
                return;            
            btnAllPrisoners.BackColor = Color.FromArgb(51, 5, 76);
            btnViewCases.BackColor = Color.FromArgb(51, 51, 76);
            dgvPrisoner.DataSource = CurrentUser.GetAllPrisoners();
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
            _selectedTable = "Prisoner";
        }

        private void btnViewCases_Click(object sender, EventArgs e)
        {
            if (((_selectedTable.Equals("Prisoner") || _selectedTable.Equals("PrisonerSearch")) && dgvPrisoner.SelectedRows.Count == 0) ||
                _selectedTable.Equals("Case"))
                return;
            btnViewCases.BackColor = Color.FromArgb(51, 5, 76);
            btnAllPrisoners.BackColor = Color.FromArgb(51, 51, 76);
            dgvPrisoner.DataSource = CurrentUser.GetCases(Convert.ToInt32(dgvPrisoner.SelectedRows[0].Cells["prisonerNo"].Value));
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
            _selectedTable = "Case";
        }

        private void btnSearchPrisoner_Click(object sender, EventArgs e)
        {
            btnAllPrisoners.BackColor = Color.FromArgb(51, 51, 76);
            btnViewCases.BackColor = Color.FromArgb(51, 51, 76);
            if (cmbSearchBy.SelectedIndex < 0 || txtSearchValue.Text.Equals(""))
                return;
            dgvPrisoner.DataSource = CurrentUser.SearchPrisoner(txtSearchValue.Text, cmbSearchBy.SelectedItem.ToString());
            _selectedTable = "PrisonerSearch";
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

        private void dgvPrisoner_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrisoner.SelectedRows.Count > 1)
                btnViewCases.Hide();
            else
                btnViewCases.Show();
        }
    }
}
