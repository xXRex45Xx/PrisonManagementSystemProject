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
    public partial class SelectPrisonerForm : Form
    {
        public Prisoner SelectedPrisoner { set; get; }
        public User CurrentUser { set; get; }
        public SelectPrisonerForm()
        {
            InitializeComponent();
        }

        private void dgvPrisoner_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrisoner.SelectedRows.Count > 1)
                btnSelect.Hide();
            else
                btnSelect.Show();
        }

        private void SelectPrisonerForm_Shown(object sender, EventArgs e)
        {
            dgvPrisoner.DataSource = CurrentUser.GetAllPrisoners();
            if (dgvPrisoner.Rows.Count > 0)
                dgvPrisoner.SelectedRows[0].Selected = false;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedIndex < 0 || txtSearchValue.Text.Equals(""))
                return;
            dgvPrisoner.DataSource = CurrentUser.SearchPrisoner(txtSearchValue.Text, cmbSearchBy.SelectedItem.ToString());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(dgvPrisoner.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a prisoner!");
                return;
            }
            this.SelectedPrisoner = new Prisoner();
            this.SelectedPrisoner.PrisonerNo = Convert.ToInt32(dgvPrisoner.SelectedRows[0].Cells[0].Value);
            this.SelectedPrisoner.FirstName = dgvPrisoner.SelectedRows[0].Cells["fName"].Value.ToString();
            this.SelectedPrisoner.LastName = dgvPrisoner.SelectedRows[0].Cells["lName"].Value.ToString();
            this.DialogResult = DialogResult.Yes;
        }
    }
}
