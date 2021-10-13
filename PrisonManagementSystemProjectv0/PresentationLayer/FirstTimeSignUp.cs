using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrisonManagementSystemProjectv0
{
    public partial class FirstTimeSignUpForm : Form
    {
        public FirstTimeSignUpForm()
        {
            InitializeComponent();
        }       
        private void txtCPwd_Leave(object sender, EventArgs e)
        {            
            if(!txtPwd.Text.Equals(txtCPwd.Text))
            {
                SignUpError.SetError(pnlConfirmPwd, "Passwords don't match!");
            }
            else
            {
                SignUpError.SetError(txtPwd, null);
            }
                
        }

        private void ibtnPwdVisibility_MouseDown(object sender, MouseEventArgs e)
        {
            ibtnPwdVisibility.ImageIndex = 1;
            txtPwd.PasswordChar = '\0';
            txtCPwd.PasswordChar = '\0';
            txtCPwd.Focus();
        }

        private void ibtnPwdVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            ibtnPwdVisibility.ImageIndex = 0;
            txtPwd.PasswordChar = '*';
            txtCPwd.PasswordChar = '*';
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {              
            if (txtUserName.Text.Equals("") || txtUserName.ForeColor.Equals(Color.Gray))
            {
                SignUpError.SetError(pnlUserName, "Username Field is Empty!");
                txtUserName.Focus();
            }
            else if (txtPwd.Text.Equals("") || txtPwd.ForeColor.Equals(Color.Gray))
            {
                SignUpError.SetError(pnlUserName, null);
                SignUpError.SetError(pnlPwd, "Password Field is Empty!");
                txtPwd.Focus();
            }
            else if (txtCPwd.Text.Equals("") || txtCPwd.ForeColor.Equals(Color.Gray))
            {                
                SignUpError.SetError(pnlConfirmPwd, "Confirm Password Field is Empty!");
                txtCPwd.Focus();
            }
            else if (!txtPwd.Text.Equals(txtCPwd.Text))
            {
                SignUpError.SetError(pnlUserName, null);
                SignUpError.SetError(pnlPwd, null);
                SignUpError.SetError(pnlConfirmPwd, "Passwords Dont Match!");
                txtCPwd.Focus();
            }
            else
            {                
                SignUpError.SetError(pnlPwd, null);
                SignUpError.SetError(pnlUserName, null);
                SignUpError.SetError(pnlConfirmPwd, null);
                Administrator admin = new Administrator(txtUserName.Text, txtPwd.Text);
                int rowsAdded = admin.CreateUser(admin);
                if (rowsAdded > 0)
                {
                    MessageBox.Show("Sign Up Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AdministratorForm administratorForm = new AdministratorForm();
                    administratorForm.ShowDialog();
                    NewLogin loginForm = new NewLogin();
                    loginForm.ShowDialog();
                    this.Close();
                }
                else if(rowsAdded == 0)
                {
                    string error = "Error During User Creation! Restart your computer. If error persists constact your system administrator.";
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.ForeColor.Equals(Color.Gray))
            {
                txtUserName.Clear();
                txtUserName.ForeColor = Color.FromArgb(51, 51, 76);
            }
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {
            if (txtPwd.ForeColor.Equals(Color.Gray))
            {
                txtPwd.Clear();
                txtPwd.PasswordChar = '*';
                txtPwd.ForeColor = Color.FromArgb(51, 51, 76);
            }
        }

        private void txtCPwd_Enter(object sender, EventArgs e)
        {
            if (txtCPwd.ForeColor.Equals(Color.Gray))
            {
                txtCPwd.Clear();
                txtCPwd.PasswordChar = '*';
                txtCPwd.ForeColor = Color.FromArgb(51, 51, 76);
            }
        }
    }
}
