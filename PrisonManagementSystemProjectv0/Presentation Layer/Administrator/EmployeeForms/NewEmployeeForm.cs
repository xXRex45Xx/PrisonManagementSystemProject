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
    public partial class NewEmployeeForm : Form
    {
       
        public Administrator CurrentUser { get; set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );
        
        private enum Month { January, February, March, April, May, June, July, August, September, October, November, December};
        public NewEmployeeForm()
        {
            InitializeComponent();

            PrisonBlock block = new PrisonBlock();
            cmbBlock.Items.AddRange(block.GetBlockList());

            int year = DateTime.Now.Year - 100;
            for(int i = 0; i < 100; i++)
            {
                cmbYear.Items.Add(year++);
                if (year == DateTime.Now.Year - 18)
                    break;
            }                       
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbMonth.SelectedIndex == (int)Month.February)
            {
                cmbDay.Text = "Day";
                cmbDay.Items.Clear();
                for (int i = 1; i <= 28; i++)
                    cmbDay.Items.Add(i);
                if(cmbYear.SelectedIndex > 0)
                {
                    if((int)cmbYear.SelectedItem % 4 == 0)
                    {
                        if ((int)cmbYear.SelectedItem % 100 == 0)
                        {
                            if ((int)cmbYear.SelectedItem % 400 == 0)
                                cmbDay.Items.Add(29);
                        }
                        else
                            cmbDay.Items.Add(29);
                    }
                }
                
            }
            else if(cmbMonth.SelectedIndex == (int)Month.September ||
                cmbMonth.SelectedIndex == (int)Month.April ||
                cmbMonth.SelectedIndex == (int)Month.June ||
                cmbMonth.SelectedIndex == (int)Month.November)
            {
                cmbDay.Text = "Day";
                cmbDay.Items.Clear();
                for (int i = 1; i <= 30; i++)
                    cmbDay.Items.Add(i);               
            }else
            {
                cmbDay.Text = "Day";
                cmbDay.Items.Clear();
                for (int i = 1; i <= 31; i++)
                    cmbDay.Items.Add(i);
            }
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
                (idxOfSpace > 0  && txtBox.Text.Length > 1 && txtBox.Text.Substring(idxOfSpace + 1, 1).Equals(" ")))
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

        private void rBtnGuard_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnGuard.Checked)
            {
                cmbBlock.Show();
                lblBlock.Show();
            }
            else
            {
                cmbBlock.Hide();
                lblBlock.Hide();
            }
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pressedChar = e.KeyChar;
            if (!char.IsDigit(pressedChar) && pressedChar != 8 && pressedChar != 46 && pressedChar != 32 && pressedChar != 43)                
                e.Handled = true;           

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {            
            if (txtFirstName.Text.Equals("") || txtLastName.Text.Equals(""))
                errEmptyField.SetError(pnlLastName, "Full name not provided!");                        
            else if (txtPhoneNo.Text.Equals(""))            
                errEmptyField.SetError(pnlPhoneNo, "Phone Number not provided!");
            else if (txtEmail.Text.Equals(""))           
                errEmptyField.SetError(pnlEmail, "Email not provided!");                
            else if (!(rBtnDoctor.Checked || rBtnGuard.Checked || rBtnReception.Checked))
                errEmptyField.SetError(gBoxRole, "Employee role not provided!");
            else if (cmbDay.SelectedIndex < 0 || cmbMonth.SelectedIndex < 0 || cmbYear.SelectedIndex < 0)
                errEmptyField.SetError(cmbYear, "Birth date not provided!");
            else if (rBtnGuard.Checked && cmbBlock.SelectedIndex < 0)
                errEmptyField.SetError(cmbBlock, "Block not provided!");                
            else
            {                 
                foreach (Control control in this.Controls)
                    errEmptyField.SetError(control, null);
                string username;
                int indexOfSpace = txtFirstName.Text.IndexOf(' ');
                if (indexOfSpace > 0)
                    username = txtFirstName.Text.Substring(0, indexOfSpace);
                else
                    username = txtFirstName.Text;
                username += txtPhoneNo.Text.Substring(txtPhoneNo.Text.Length - 2);
                if (rBtnReception.Checked)
                {
                    ReceptionInfo reception = new ReceptionInfo()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        DateOfBirth = new DateTime(Convert.ToInt32(cmbYear.SelectedItem), Convert.ToInt32(cmbMonth.SelectedIndex) + 1, Convert.ToInt32(cmbDay.SelectedItem)),
                        PhoneNumber = txtPhoneNo.Text,
                        Address = txtAddress.Text,
                        Email = txtEmail.Text,
                        UserInfo = new Reception(username, username)
                    };
                    int rowsAdded = CurrentUser.CreateUser(reception.UserInfo);                    
                    if(rowsAdded > 0)
                    {
                        reception.UserId = reception.UserInfo.Id;
                        rowsAdded = reception.SaveReceptionInfo();
                        if(rowsAdded > 0)
                        {
                            string message = String.Format("Employee Registered Successfully.\n\nEmployee Credentials: \n\tUsername: {0}\n\tPassword: {0}", username);
                            ClearControls();
                            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (rowsAdded == 0)
                        {
                            CurrentUser.DeleteUser(reception.UserId);
                            string error = "Error During Data Insertion! Restart your computer. If error persists constact your system administrator.";
                            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if(rowsAdded == 0)
                    {
                        string error = "Error During User Creation! Restart your computer. If error persists constact your system administrator.";
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rBtnDoctor.Checked)
                {
                    DoctorInfo doctor = new DoctorInfo()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        DateOfBirth = new DateTime(Convert.ToInt32(cmbYear.SelectedItem), Convert.ToInt32(cmbMonth.SelectedIndex) + 1, Convert.ToInt32(cmbDay.SelectedItem)),
                        PhoneNumber = txtPhoneNo.Text,
                        Address = txtAddress.Text,
                        Email = txtEmail.Text,
                        UserInfo = new Doctor(username, username)
                    };
                    int rowsAdded = CurrentUser.CreateUser(doctor.UserInfo);
                    if(rowsAdded > 0)
                    {
                        doctor.UserId = doctor.UserInfo.Id;
                        rowsAdded = doctor.SaveDoctorInfo();
                        if(rowsAdded > 0)
                        {
                            string message = String.Format("Employee Registered Successfully.\n\nEmployee Credentials: \n\tUsername: {0}\n\tPassword: {0}", username);
                            ClearControls();
                            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if(rowsAdded == 0)
                        {
                            CurrentUser.DeleteUser(doctor.UserId);
                            string error = "Error During Data Insertion! Restart your computer. If error persists constact your system administrator.";
                            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if(rowsAdded == 0)
                    {
                        string error = "Error During User Creation! Restart your computer. If error persists constact your system administrator.";
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rBtnGuard.Checked)
                {
                    GuardInfo guard = new GuardInfo()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        DateOfBirth = new DateTime(Convert.ToInt32(cmbYear.SelectedItem), Convert.ToInt32(cmbMonth.SelectedIndex) + 1, Convert.ToInt32(cmbDay.SelectedItem)),
                        PhoneNumber = txtPhoneNo.Text,
                        Address = txtAddress.Text,
                        Email = txtEmail.Text,
                        BlockNo = Convert.ToInt32(cmbBlock.SelectedItem),
                        UserInfo = new Guard(username, username)
                    };
                    int rowsAdded = CurrentUser.CreateUser(guard.UserInfo);
                    if(rowsAdded > 0)
                    {
                        guard.UserId = guard.UserInfo.Id;
                        rowsAdded = guard.SaveGuardInfo();
                        if(rowsAdded > 0)
                        {
                            string message = String.Format("Employee Registered Successfully.\n\nEmployee Credentials: \n\tUsername: {0}\n\tPassword: {0}", username);
                            ClearControls();
                            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if(rowsAdded == 0)
                        {
                            CurrentUser.DeleteUser(guard.UserId);
                            string error = "Error During Data Insertion! Restart your computer. If error persists constact your system administrator.";
                            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }else if(rowsAdded == 0)
                    {
                        string error = "Error During User Creation! Restart your computer. If error persists constact your system administrator.";
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

                   
        }

        private void ClearControls()
        {
            foreach(Control control in this.Controls)
            {
                if (control is TextBox box)
                    box.Clear();
                else if (control is ComboBox box1)
                    box1.SelectedIndex = -1;
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {                      
            if (cmbMonth.SelectedIndex < 0 || cmbMonth.SelectedIndex != (int)Month.February)
                return;
            if(cmbDay.Items.Count == 29)
            {
                if((int)cmbYear.SelectedItem % 4 == 0)
                {
                    if ((int)cmbYear.SelectedItem % 100 == 0)
                    {
                        if ((int)cmbYear.SelectedItem % 400 == 0)
                            return;
                    }
                    else
                        return;
                }
                if (cmbDay.SelectedIndex == 28)
                {
                    cmbDay.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                        cmbDay.Items.Add(i);
                    cmbDay.Text = "Day";
                }
                else
                    cmbDay.Items.RemoveAt(28);
            }
            else
            {
                if (cmbYear.SelectedIndex > 0)
                {
                    if ((int)cmbYear.SelectedItem % 4 == 0)
                    {
                        if ((int)cmbYear.SelectedItem % 100 == 0)
                        {
                            if ((int)cmbYear.SelectedItem % 400 == 0)
                                cmbDay.Items.Add(29);
                        }
                        else
                            cmbDay.Items.Add(29);
                    }
                }
            }
        }
    }
}
