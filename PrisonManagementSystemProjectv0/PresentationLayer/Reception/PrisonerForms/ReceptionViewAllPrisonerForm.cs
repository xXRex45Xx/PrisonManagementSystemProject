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
    public partial class ReceptionViewAllPrisonerForm : Form
    {
        public Reception CurrentUser { set; get; }

        private string _selectedTable = "Prisoner";
        public ReceptionViewAllPrisonerForm()
        {
            InitializeComponent();
        }

        private void btnPrisoner_Click(object sender, EventArgs e)
        {
            if (_selectedTable.Equals("Prisoner"))
                return;
            btnVisit.BackColor = Color.FromArgb(51, 51, 76);
            btnPrisoner.BackColor = Color.FromArgb(51, 5, 76);
            dgvPrisoner.DataSource = CurrentUser.GetAllPrisoners();
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
            _selectedTable = "Prisoner";
        }

        private void ReceptionViewAllPrisonerForm_Shown(object sender, EventArgs e)
        {
            dgvPrisoner.DataSource = CurrentUser.GetAllPrisoners();
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            if ((_selectedTable.CompareTo("Prisoner") == 0 && dgvPrisoner.SelectedRows.Count == 0) ||
               _selectedTable.Equals("Visit"))
                return;
            btnPrisoner.BackColor = Color.FromArgb(51, 51, 76);
            btnVisit.BackColor = Color.FromArgb(51, 5, 76);
            int prisonerNo = Convert.ToInt32(dgvPrisoner.SelectedRows[0].Cells["prisonerNo"].Value);
            dgvPrisoner.DataSource = CurrentUser.GetPrisonerVisit(prisonerNo);
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
            _selectedTable = "Visit";
        }

        private void dgvPrisoner_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrisoner.SelectedRows.Count > 1)
                btnVisit.Hide();
            else
                btnVisit.Show();
        }
    }
}
