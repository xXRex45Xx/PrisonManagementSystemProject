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
    public partial class ReceptionViewAllVisitorForm : Form
    {
        public Reception CurrentUser { set; get; }

        private string _selectedTable = "Visitor";
        public ReceptionViewAllVisitorForm()
        {
            InitializeComponent();
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            if (_selectedTable.Equals("Visitor"))
                return;
            btnVisit.BackColor = Color.FromArgb(51, 51, 76);
            btnVisitor.BackColor = Color.FromArgb(51, 5, 76);
            dgvVisitor.DataSource = CurrentUser.GetAllVisitors();
            if (dgvVisitor.Rows.Count > 0)
                dgvVisitor.SelectedRows[0].Selected = false;
            _selectedTable = "Visitor";
        }

        private void ReceptionViewAllVisitorForm_Shown(object sender, EventArgs e)
        {
            dgvVisitor.DataSource = CurrentUser.GetAllVisitors();
            if (dgvVisitor.Rows.Count > 0)
                dgvVisitor.SelectedRows[0].Selected = false;
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            if ((_selectedTable.CompareTo("Visitor") == 0 && dgvVisitor.SelectedRows.Count == 0) ||
               _selectedTable.Equals("Visit"))
                return;
            btnVisitor.BackColor = Color.FromArgb(51, 51, 76);
            btnVisit.BackColor = Color.FromArgb(51, 5, 76);
            int visitorNo = Convert.ToInt32(dgvVisitor.SelectedRows[0].Cells["visitorNo"].Value);
            dgvVisitor.DataSource = CurrentUser.GetVisitorVisit(visitorNo);
            if (dgvVisitor.Rows.Count > 0)
                dgvVisitor.SelectedRows[0].Selected = false;
            _selectedTable = "Visit";
        }

        private void dgvVisitor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVisitor.SelectedRows.Count > 1)
            {
                btnNewVisit.Hide();
                btnVisit.Hide();
            }
            else
                btnVisit.Show();
        }

        private void btnNewVisit_Click(object sender, EventArgs e)
        {
            if(dgvVisitor.SelectedRows.Count == 0 || dgvVisitor.Rows.Count == 0)
            {
                NewVisitorForm visitorForm = new NewVisitorForm()
                {
                    CurrentUser = this.CurrentUser
                };
                DialogResult result = visitorForm.ShowDialog();                
                
                if (result.Equals(DialogResult.Yes))
                {
                    SelectPrisonerForm selectPrisoner = new SelectPrisonerForm()
                    {
                        CurrentUser = this.CurrentUser
                    };
                    DialogResult isSelected = selectPrisoner.ShowDialog();
                    if(isSelected.Equals(DialogResult.Yes))
                    {
                        Prisoner currentPrisoner = selectPrisoner.SelectedPrisoner;
                        int visitorNo = CurrentUser.GetLastAddedVisitor();
                        DataTable visitorData = CurrentUser.SearchVisitor(visitorNo, "Visitor Number");
                        Visitor currentVisitor = new Visitor()
                        {
                            VisitorNo = visitorNo,
                            FirstName = visitorData.Rows[0].Field<string>("fName"),
                            LastName = visitorData.Rows[0].Field<string>("lName")
                        };
                        NewVisitForm visitForm = new NewVisitForm()
                        {
                            CurrentUser = this.CurrentUser,
                            CurrentPrisoner = currentPrisoner,
                            CurrentVisitor = currentVisitor
                        };
                        visitForm.ShowDialog();
                    }    
                }
            }
            else if(dgvVisitor.SelectedRows.Count > 0)
            {
                Visitor currentVisitor = new Visitor()
                {
                    VisitorNo = Convert.ToInt32(dgvVisitor.SelectedRows[0].Cells["visitorNo"].Value),
                    FirstName = dgvVisitor.SelectedRows[0].Cells["fName"].Value.ToString(),
                    LastName = dgvVisitor.SelectedRows[0].Cells["lName"].Value.ToString()
                };

                SelectPrisonerForm selectPrisoner = new SelectPrisonerForm()
                {
                    CurrentUser = this.CurrentUser
                };
                DialogResult isSelected = selectPrisoner.ShowDialog();
                if(isSelected.Equals(DialogResult.Yes))
                {
                    Prisoner currentPrisoner = selectPrisoner.SelectedPrisoner;
                    NewVisitForm visitForm = new NewVisitForm()
                    {
                        CurrentUser = this.CurrentUser,
                        CurrentPrisoner = currentPrisoner,
                        CurrentVisitor = currentVisitor
                    };
                    visitForm.ShowDialog();
                }
            }
            dgvVisitor.DataSource = CurrentUser.GetAllVisitors();
        }
    }
}
