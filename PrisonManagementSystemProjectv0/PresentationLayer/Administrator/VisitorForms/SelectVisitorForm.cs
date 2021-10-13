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
    public partial class SelectVisitorForm : Form
    {
        public Administrator CurrentUser { set; get; }
        public Visitor SelectedVisitor { set; get; }
        public SelectVisitorForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedIndex < 0 || txtSearchValue.Text.Equals(""))
                return;
            dgvVisitor.DataSource = CurrentUser.SearchVisitor(txtSearchValue.Text, cmbSearchBy.SelectedItem.ToString());
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvVisitor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a visitor!");
                return;
            }
            this.SelectedVisitor = new Visitor();
            this.SelectedVisitor.VisitorNo = Convert.ToInt32(dgvVisitor.SelectedRows[0].Cells["visitorNo"].Value);
            this.SelectedVisitor.FirstName = dgvVisitor.SelectedRows[0].Cells["fName"].Value.ToString();
            this.SelectedVisitor.LastName = dgvVisitor.SelectedRows[0].Cells["lName"].Value.ToString();
            this.DialogResult = DialogResult.Yes;
        }

        private void SelectVisitorForm_Shown(object sender, EventArgs e)
        {
            dgvVisitor.DataSource = CurrentUser.GetAllVisitors();
            if (dgvVisitor.Rows.Count > 0)
                dgvVisitor.SelectedRows[0].Selected = false;
        }
    }
}
