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
    public partial class SelectDoctorForm : Form
    {
        public Administrator CurrentUser { set; get; }
        public DoctorInfo SelectedDoctor { set; get; }
        public SelectDoctorForm()
        {
            InitializeComponent();
        }

        private void SelectDoctorForm_Shown(object sender, EventArgs e)
        {
            dgvDoctor.DataSource = CurrentUser.GetAllEmployee("Doctor");
            if (dgvDoctor.Rows.Count > 0)
                dgvDoctor.SelectedRows[0].Selected = false;
        }

        private void dgvDoctor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDoctor.SelectedRows.Count > 1)
                btnSelect.Hide();
            else
                btnSelect.Show();
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
            dgvDoctor.DataSource = CurrentUser.SearchEmployee(txtSearchValue.Text, cmbSearchBy.SelectedItem.ToString(),"Doctor");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvDoctor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a doctor!");
                return;
            }
            this.SelectedDoctor = new DoctorInfo();
            this.SelectedDoctor.DoctorNo = Convert.ToInt32(dgvDoctor.SelectedRows[0].Cells["doctorNo"].Value);
            this.SelectedDoctor.FirstName = dgvDoctor.SelectedRows[0].Cells["FirstName"].Value.ToString();
            this.SelectedDoctor.LastName = dgvDoctor.SelectedRows[0].Cells["LastName"].Value.ToString();
            this.DialogResult = DialogResult.Yes;
        }
    }
}
