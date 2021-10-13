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
    public partial class NewLogin : Form
    {        
        public NewLogin()
        {
            InitializeComponent();
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
                txtPwd.ForeColor = Color.FromArgb(51, 51, 76);
                txtPwd.PasswordChar = '*';
            }
        }

        private void btnPwdVisibility_MouseDown(object sender, MouseEventArgs e)
        {
            btnPwdVisibility.ImageIndex = 1;
            txtPwd.PasswordChar = '\0';
            txtPwd.Focus();
        }

        private void btnPwdVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            btnPwdVisibility.ImageIndex = 0;
            txtPwd.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("") || txtUserName.ForeColor.Equals(Color.Gray))
            {
                txtUserName.Focus();
                errEmptyFields.SetError(pnlUserName, "Username Field is Empty!");
            }
            else if (txtPwd.Text.Equals("") || txtPwd.ForeColor.Equals(Color.Gray))
            {
                txtPwd.Focus();
                errEmptyFields.SetError(pnlUserName, null);
                errEmptyFields.SetError(pnlPwd, "Password Field is Empty!");
            }
            else
            {
                User u = new User(txtUserName.Text, txtPwd.Text);
                errEmptyFields.SetError(pnlUserName, null);
                errEmptyFields.SetError(pnlPwd, null);
                errIncorrectCred.SetError(pnlPwd, null);
                txtPwd.Clear();
                txtUserName.Clear();               
                txtUserName.Text = "Username";  
                txtUserName.ForeColor = Color.Gray;                
                if (u.Login())
                {                 
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    if (u.Role.Equals("Administrator"))
                    {
                        Administrator administrator = new Administrator(u.UserName, txtPwd.Text);
                        txtPwd.PasswordChar = '\0';
                        txtPwd.Text = "Password";
                        txtPwd.ForeColor = Color.Gray;
                        AdministratorForm administratorForm = new AdministratorForm()
                        {
                            CurrentUser = administrator
                        };
                        administratorForm.ShowDialog();
                    }
                    else if (u.Role.Equals("Doctor"))
                    {
                        Doctor doctor = new Doctor(u.UserName, txtPwd.Text);
                        txtPwd.PasswordChar = '\0';
                        txtPwd.Text = "Password";
                        txtPwd.ForeColor = Color.Gray;
                        DoctorForm doctorForm = new DoctorForm()
                        {
                            CurrentUser = doctor
                        };
                        doctorForm.ShowDialog();
                    }
                    else if (u.Role.Equals("Guard"))
                    {
                        Guard guard = new Guard(u.UserName, txtPwd.Text);
                        txtPwd.PasswordChar = '\0';
                        txtPwd.Text = "Password";
                        txtPwd.ForeColor = Color.Gray;
                        GuardForm guardForm = new GuardForm()
                        {
                            CurrentUser = guard
                        };
                        guardForm.ShowDialog();

                    }
                    else if (u.Role.Equals("Reception"))
                    {
                        Reception reception = new Reception(u.UserName, txtPwd.Text);
                        txtPwd.PasswordChar = '\0';
                        txtPwd.Text = "Password";
                        txtPwd.ForeColor = Color.Gray;
                        ReceptionForm receptionForm = new ReceptionForm()
                        {
                            CurrentUser = reception
                        };
                        receptionForm.ShowDialog();
                    }
                    this.Show();
                }
                else
                {
                    //lblAuthenticationError.Visible = true;
                    //MessageBox.Show("Incorrect Username or Password", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errIncorrectCred.SetError(pnlPwd, "Incorrect Username or Password!");
                    txtPwd.Clear();
                    txtPwd.Focus();
                    //txtUserName.Clear();
                    //txtUserName.Focus();
                }
            }
        }
    }
}
