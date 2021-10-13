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
    public partial class ReceptionSearchPrisonerForm : Form
    {
        public Reception CurrentUser { set; get; }

        private string _selectedTable = "";
        private DataTable _searchResult = null;
        public ReceptionSearchPrisonerForm()
        {
            InitializeComponent();
        }

        private void btnPrisoner_Click(object sender, EventArgs e)
        {
            if (_selectedTable.Equals("Prisoner") || _searchResult == null)
                return;
            btnVisit.BackColor = Color.FromArgb(51, 51, 76);
            btnPrisoner.BackColor = Color.FromArgb(51, 5, 76);
            dgvPrisoner.DataSource = _searchResult;
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
            _selectedTable = "Prisoner";
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            if ((_selectedTable.CompareTo("Prisoner") == 0 && dgvPrisoner.SelectedRows.Count == 0) ||
               !_selectedTable.Equals("Prisoner"))
                return;
            btnPrisoner.BackColor = Color.FromArgb(51, 51, 76);
            btnVisit.BackColor = Color.FromArgb(51, 5, 76);
            int prisonerNo = Convert.ToInt32(dgvPrisoner.SelectedRows[0].Cells["prisonerNo"].Value);
            dgvPrisoner.DataSource = CurrentUser.GetPrisonerVisit(prisonerNo);
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
            _selectedTable = "Visit";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedIndex < 0 || txtSearchValue.Text.Equals(""))
                return;
            _searchResult = CurrentUser.SearchPrisoner(txtSearchValue.Text, cmbSearchBy.SelectedItem.ToString());
            _selectedTable = "";
            btnPrisoner.PerformClick();
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
                
                btnVisit.Hide();
            else
                btnVisit.Show();
        }
    }
}
