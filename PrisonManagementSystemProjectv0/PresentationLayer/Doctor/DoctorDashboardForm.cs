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
    public partial class DoctorDashboardForm : Form
    {
        public Doctor CurrentUser { set; get; }
        public DoctorDashboardForm()
        {
            InitializeComponent();
        }

        private void DoctorDashboardForm_Shown(object sender, EventArgs e)
        {
            lblNumberOfPrisoners.Text = CurrentUser.GetNumberOfPrisoners().ToString();
            lblNumberOfDoctors.Text = CurrentUser.GetNumberOfDoctors().ToString();
            lblNumberOfTreatments.Text = CurrentUser.GetNumberOfTreatments().ToString();
        }
    }
}
