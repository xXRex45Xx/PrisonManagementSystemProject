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
    public partial class ChangeUserCredentialsForm : Form
    {
        public User CurrentUser { set; get; }
        public ChangeUserCredentialsForm()
        {
            InitializeComponent();
        }

        private void btnOPwdVisibility_MouseDown(object sender, MouseEventArgs e)
        {
            btnOPwdVisibility.ImageIndex = 1;
            txtOldPwd.PasswordChar = '\0';
            txtOldPwd.Focus();
        }

        private void btnOPwdVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            btnOPwdVisibility.ImageIndex = 0;
            txtOldPwd.PasswordChar = '*';
        }

        private void btnNPwdVisibility_MouseDown(object sender, MouseEventArgs e)
        {
            btnNPwdVisibility.ImageIndex = 1;
            txtNewPwd.PasswordChar = '\0';
            txtCPwd.PasswordChar = '\0';
            txtCPwd.Focus();
        }

        private void btnNPwdVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            btnNPwdVisibility.ImageIndex = 0;
            txtNewPwd.PasswordChar = '*';
            txtCPwd.PasswordChar = '*';          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("") || txtUserName.ForeColor.Equals(Color.Gray))
            {
                errEmptyFields.SetError(pnlUserName, "Username Field is Empty!");
                txtUserName.Focus();
            }
            else if (txtOldPwd.Text.Equals("") || txtOldPwd.ForeColor.Equals(Color.Gray))
            {
                errEmptyFields.SetError(pnlUserName, null);
                errEmptyFields.SetError(pnlOldPwd, "Old Password Field is Empty!");
                txtOldPwd.Focus();
            }
            else if (txtNewPwd.Text.Equals("") || txtNewPwd.ForeColor.Equals(Color.Gray))
            {
                errEmptyFields.SetError(pnlUserName, null);
                errEmptyFields.SetError(pnlOldPwd, null);
                errEmptyFields.SetError(pnlNewPwd, "New Password Field is Empty!");
                txtNewPwd.Focus();
            }
            else if(txtCPwd.Text.Equals("") || txtCPwd.ForeColor.Equals(Color.Gray))
            {
                errEmptyFields.SetError(pnlUserName, null);
                errEmptyFields.SetError(pnlOldPwd, null);
                errEmptyFields.SetError(pnlNewPwd, null);
                errEmptyFields.SetError(pnlConfirmPwd, "Confirm Password Field is Empty!");
                txtCPwd.Focus();
            }
            else if(!txtNewPwd.Text.Equals(txtCPwd.Text))
            {
                errEmptyFields.SetError(pnlUserName, null);
                errEmptyFields.SetError(pnlOldPwd, null);
                errEmptyFields.SetError(pnlNewPwd, null);
                errEmptyFields.SetError(pnlConfirmPwd, null);
                errPwdMismatch.SetError(pnlConfirmPwd, "Passwords Dont Match!");
                txtCPwd.Focus();
            }
            else
            {
                errEmptyFields.SetError(pnlUserName, null);
                errEmptyFields.SetError(pnlOldPwd, null);
                errEmptyFields.SetError(pnlNewPwd, null);
                errEmptyFields.SetError(pnlConfirmPwd, null);
                errPwdMismatch.SetError(pnlConfirmPwd, null);
                if (new User(CurrentUser.UserName, txtOldPwd.Text).Login())
                {
                    User u = new User(txtUserName.Text, txtNewPwd.Text);
                    int rowsChanged = u.ChangeCredentials(CurrentUser.UserName);
                    if (rowsChanged > 0)
                    {
                        MessageBox.Show("User Updated Successfuly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    else if (rowsChanged == 0)
                    {
                        MessageBox.Show("Error Occured While Updating User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;
                    }
                    else
                        this.DialogResult = DialogResult.No;
                }
                else
                {
                    MessageBox.Show("Incorrect Password!", "Passsword Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void txtCPwd_Enter(object sender, EventArgs e)
        {
            if (txtCPwd.ForeColor.Equals(Color.Gray))
            {
                txtCPwd.Clear();
                txtCPwd.ForeColor = Color.FromArgb(51, 51, 76);
                txtCPwd.PasswordChar = '*';
            }
        }

        private void txtNewPwd_Enter(object sender, EventArgs e)
        {
            if (txtNewPwd.ForeColor.Equals(Color.Gray))
            {
                txtNewPwd.Clear();
                txtNewPwd.ForeColor = Color.FromArgb(51, 51, 76);
                txtNewPwd.PasswordChar = '*';
            }
        }

        private void txtOldPwd_Enter(object sender, EventArgs e)
        {
            if (txtOldPwd.ForeColor.Equals(Color.Gray))
            {
                txtOldPwd.Clear();
                txtOldPwd.ForeColor = Color.FromArgb(51, 51, 76);
                txtOldPwd.PasswordChar = '*';
            }
        }

        private void ChangeUserCredentialsForm_Shown(object sender, EventArgs e)
        {
            if(this.CurrentUser == null)
            {
                MessageBox.Show("System Error Occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            txtUserName.ForeColor = Color.FromArgb(51, 51, 76);
            txtUserName.Text = CurrentUser.UserName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
