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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
               
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals(""))
            {
                txtUserName.Focus();
                errEmptyFields.SetError(txtUserName, "Username Field is Empty!");
            }
            else if (txtPwd.Text.Equals(""))
            {                
                txtPwd.Focus();
                errEmptyFields.SetError(txtUserName, null);
                errEmptyFields.SetError(txtPwd, "Password Field is Empty!");
            }
            else
            {
                User u = new User(txtUserName.Text, txtPwd.Text);                
                errEmptyFields.SetError(txtUserName, null);
                errEmptyFields.SetError(txtPwd, null);                
                if(u.Login())
                {
                    lblAuthenticationError.Visible = false;
                    txtPwd.Clear();
                    txtUserName.Clear();
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    if (u.Role.Equals("Administrator"))
                    {
                        Administrator admin = (Administrator)u;
                        AdministratorForm administratorForm = new AdministratorForm();
                        administratorForm.ShowDialog();
                    }
                    else if (u.Role.Equals("Doctor"))
                    {

                    }
                    else if (u.Role.Equals("Guard"))
                    {

                    }
                    else if (u.Role.Equals("Reception"))
                    {

                    }
                    this.Show();
                }
                else
                {
                    lblAuthenticationError.Visible = true;
                    txtPwd.Clear();
                    txtUserName.Clear();
                    txtUserName.Focus();
                }

            }
        }          

        

        private void ibtnPwdVisibility_MouseDown(object sender, MouseEventArgs e)
        {
            btnPwdVisibility.ImageIndex = 1;            
            txtPwd.PasswordChar = '\0';
            txtPwd.Focus();
        }

        private void ibtnPwdVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            btnPwdVisibility.ImageIndex = 0;
            txtPwd.PasswordChar = '*';
        }        
    }
}
