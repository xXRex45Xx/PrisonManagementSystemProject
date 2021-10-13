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
    public partial class NewPrisonerForm : Form
    {
        public Guard CurrentUser { set; get; }

        private Prisoner _prisoner;
        public NewPrisonerForm()
        {
            InitializeComponent();
            _prisoner = new Prisoner();

            PrisonCell cell = new PrisonCell();
            cmbCell.Items.AddRange(cell.GetCellList());
        }

        private void chkMultipleCase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMultipleCase.Checked)
                btnRegisterCase.Show();
            else
                btnRegisterCase.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals("") || txtLastName.Text.Equals(""))
                MessageBox.Show("Prisoner Name not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtpDateOfBirth.Value.Equals(DateTime.Now))
                MessageBox.Show("Date of Birth not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DateTime.Now.Subtract(dtpDateOfBirth.Value).Days < 6570)
                MessageBox.Show("Prisoner is less than 18 years old!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cmbCell.SelectedIndex < 0)
                MessageBox.Show("Cell Number not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(!chkMultipleCase.Checked)
                {
                    if (txtCaseNumber.Text.Equals(""))
                    {
                        MessageBox.Show("Case Number not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtCrimeType.Equals(""))
                    {
                        MessageBox.Show("Crime Committed not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (dtpDateOfCrime.Value.Equals(DateTime.Today))
                    {
                        MessageBox.Show("Date of Crime not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtYearDecided.Text.Equals(""))
                    {
                        MessageBox.Show("Years Decided not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Case prisonerCase = new Case()
                        {
                            CaseNo = int.Parse(txtCaseNumber.Text),
                            CrimeType = txtCrimeType.Text,
                            DateOfCrime = dtpDateOfCrime.Value,
                            DateOfVerdict = dtpDateOfVerdict.Value,
                            YearDecided = int.Parse(txtYearDecided.Text)
                        };
                        _prisoner.Cases.Add(prisonerCase);
                    }
                }
                
                _prisoner.FirstName = txtFirstName.Text;
                _prisoner.LastName = txtLastName.Text;
                _prisoner.PhoneNumber = txtPhoneNumber.Text;
                _prisoner.Email = txtEmail.Text;
                _prisoner.Address = txtAddress.Text;
                _prisoner.DateOfBirth = dtpDateOfBirth.Value;
                _prisoner.CellNo = Convert.ToInt32(cmbCell.SelectedItem);
                _prisoner.ArriavlDate = DateTime.Now;
                int rowsAdded = CurrentUser.AddPrisoner(_prisoner);
                if (rowsAdded > 0)
                {
                    int prisonerNo = CurrentUser.GetLastAddedPrisoner();
                    foreach (Case prisonerCase in _prisoner.Cases)
                    {
                        prisonerCase.PrisonerNo = prisonerNo;
                        int caseAdded = CurrentUser.AddPrisonerCase(prisonerCase);
                        if (caseAdded < 0)
                        {
                            string errorMsg = String.Format("Error occured while adding case number {0}", prisonerCase.CaseNo);
                            DialogResult dialog = MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            if (dialog.Equals(DialogResult.Cancel))
                                return;
                        }
                    }
                    MessageBox.Show("Prisoner Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    string errorMsg = "Error occured while adding prisoner!";
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegisterCase_Click(object sender, EventArgs e)
        {
            if (txtCaseNumber.Text.Equals(""))
                MessageBox.Show("Case Number not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtCrimeType.Equals(""))
                MessageBox.Show("Crime Committed not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtpDateOfCrime.Value.Equals(DateTime.Today))
                MessageBox.Show("Date of Crime not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtYearDecided.Text.Equals(""))
                MessageBox.Show("Years Decided not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Case prisonerCase = new Case()
                {
                    CaseNo = int.Parse(txtCaseNumber.Text),
                    CrimeType = txtCrimeType.Text,
                    DateOfCrime = dtpDateOfCrime.Value,
                    DateOfVerdict = dtpDateOfVerdict.Value,
                    YearDecided = int.Parse(txtYearDecided.Text)
                };
                _prisoner.Cases.Add(prisonerCase);
                chkMultipleCase.Enabled = false;
                foreach(Control control in gbCases.Controls)
                {
                    if (control is TextBox box)
                        box.Clear();
                    else if (control is DateTimePicker dtp)
                        dtp.MaxDate = DateTime.Now; 
                    
                }
            }                      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pressedChar = e.KeyChar;
            if (!char.IsDigit(pressedChar) && pressedChar != 8 && pressedChar != 46 && pressedChar != 32 && pressedChar != 43)
                e.Handled = true;
        }

        private void txtCaseNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void NewPrisonerForm_Shown(object sender, EventArgs e)
        {
            dtpDateOfBirth.MaxDate = DateTime.Now;
            dtpDateOfCrime.MaxDate = DateTime.Now;
            dtpDateOfVerdict.MaxDate = DateTime.Now;
        }
    }
}
