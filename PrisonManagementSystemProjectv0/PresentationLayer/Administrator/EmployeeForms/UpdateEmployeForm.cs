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
    public partial class UpdateEmployeForm : Form
    {
        public Administrator CurrentUser { set; get; }
        public string Role { set; get; } 
        public int EmployeeNumber { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string PhoneNumber { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }
        public int Block { set; get; }
        
        public UpdateEmployeForm()
        {
            InitializeComponent();
        }

        private void UpdateEmployeForm_Load(object sender, EventArgs e)
        {
            if(!Role.Equals("Guard"))
            {
                cmbBlock.Hide();
                lblBlock.Hide();                
            }
            else
            {
                cmbBlock.Items.AddRange(new PrisonBlock().GetBlockList());
                cmbBlock.SelectedItem = Block;
            }
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            txtPhoneNumber.Text = PhoneNumber;
            txtEmail.Text = Email;
            txtAddress.Text = Address;
            dtpDateOfBirth.Value = DateOfBirth;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = "Please fill all the necessary information!";
            foreach (Control control in panel1.Controls)
            {
                if (control is TextBox box)
                {
                    if (box.Text.Equals(""))
                    {
                        MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if(control is ComboBox box1)
                {
                    if(box1.SelectedIndex < 0 && this.Role.Equals("Guard"))
                    {
                        MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            this.FirstName = txtFirstName.Text;
            this.LastName = txtLastName.Text;
            this.PhoneNumber = txtPhoneNumber.Text;
            this.Email = txtEmail.Text;
            this.Address = txtAddress.Text;
            this.DateOfBirth = dtpDateOfBirth.Value;
            this.Block = Convert.ToInt32(cmbBlock.SelectedItem);
            int rows = CurrentUser.UpdateEmployee(this);
            if(rows > 0)
            {
                message = "Employee Updated Successfully";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(rows == 0)
            {
                string error = "Error During Employee Update! Restart your computer. If error persists constact your system administrator.";
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pressedChar = e.KeyChar;
            if (!char.IsDigit(pressedChar) && pressedChar != 8 && pressedChar != 46 && pressedChar != 32)
                e.Handled = true;
        }
        private void ValidateAndCaptializeNames(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            int idxOfSpace = txtBox.Text.IndexOf(' ');
            string properName;

            if (txtBox.Text.Equals(""))
                return;

            for (int i = 0; i < txtBox.Text.Length; i++)
            {
                if (char.IsWhiteSpace(txtBox.Text[i]) || char.IsLetter(txtBox.Text[i]))
                    continue;
                else
                {
                    MessageBox.Show("Numbers or Symbols can not be included in names!");
                    txtBox.Clear();
                    txtBox.Focus();
                    return;
                }
            }
            if ((idxOfSpace < 0 && txtBox.Text.Length > 1) || (idxOfSpace == txtBox.Text.Length - 1) ||
                (idxOfSpace > 0 && txtBox.Text.Length > 1 && txtBox.Text.Substring(idxOfSpace + 1, 1).Equals(" ")))
                properName = txtBox.Text.Substring(0, 1).ToUpper() + txtBox.Text.Substring(1);
            else if (idxOfSpace >= 0 && txtBox.Text.Length > 1)
            {
                properName = txtBox.Text.Substring(0, 1).ToUpper() +
                    txtBox.Text.Substring(1, idxOfSpace) +
                    txtBox.Text.Substring(idxOfSpace + 1, 1).ToUpper() +
                    txtBox.Text.Substring(idxOfSpace + 2);

            }
            else
                properName = txtBox.Text.Substring(0, 1).ToUpper();
            txtBox.Text = properName;
        }
    }
}
