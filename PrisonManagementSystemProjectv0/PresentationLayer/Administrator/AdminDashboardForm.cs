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
    public partial class AdminDashboardForm : Form
    {
        public Administrator CurrentUser { set; get; }
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Shown(object sender, EventArgs e)
        {
            lblNumberOfDoctors.Text = CurrentUser.GetNumberOfDoctors().ToString();
            lblNumberOfGuards.Text = CurrentUser.GetNumberOfGuards().ToString();
            lblNumberOfPrisoners.Text = CurrentUser.GetNumberOfPrisoners().ToString();
            lblNumberOfVisitors.Text = CurrentUser.GetNumberOfVisitors().ToString();
            lblNumberOfReceptionists.Text = CurrentUser.GetNumberOfReceptionists().ToString();
        }
    }
}
