using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystemProjectv0
{
    static class Program
    {        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
     
        static void Main()
        {
            int numberOfUsers = DBLayer.GetNumberOfUsers();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (numberOfUsers > 0)
                Application.Run(new NewLogin());
            else if (numberOfUsers == 0)
                Application.Run(new FirstTimeSignUpForm());
            else
                Application.Exit();
        }
    }
}
