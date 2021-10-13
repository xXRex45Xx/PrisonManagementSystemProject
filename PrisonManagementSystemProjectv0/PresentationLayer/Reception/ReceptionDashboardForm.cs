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
    public partial class ReceptionDashboardForm : Form
    {
        public Reception CurrentUser { set; get; }
        public ReceptionDashboardForm()
        {
            InitializeComponent();
        }

        private void ReceptionDashboardForm_Shown(object sender, EventArgs e)
        {
            lblNumberOfPrisoners.Text = CurrentUser.GetNumberOfPrisoners().ToString();
            lblNumberOfReceptionists.Text = CurrentUser.GetNumberOfReceptionists().ToString();
            lblNumberOfVisitors.Text = CurrentUser.GetNumberOfVisitors().ToString();
            lblNumberOfVisits.Text = CurrentUser.GetNumberOfVisits().ToString();
            
        }
    }
}
