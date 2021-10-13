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
    public partial class NewVisitorForm : Form
    {
        public Reception CurrentUser { set; get; }
        public NewVisitorForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals("") || txtLastName.Text.Equals(""))
                MessageBox.Show("Prisoner Name not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtpDateOfBirth.Value.Equals(DateTime.Now))
                MessageBox.Show("Date of Birth not provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Visitor visitor = new Visitor()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    DateOfBirth = dtpDateOfBirth.Value,
                    PhoneNumber = txtPhoneNumber.Text,
                    Address = txtAddress.Text
                };

                int rowsAdded = CurrentUser.AddVisitor(visitor);
                if (rowsAdded > 0)
                {
                    MessageBox.Show("Visitor Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Error occured while adding visitor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pressedChar = e.KeyChar;
            if (!char.IsDigit(pressedChar) && pressedChar != 8 && pressedChar != 46 && pressedChar != 32 && pressedChar != 43)
                e.Handled = true;
        }
    }
}
