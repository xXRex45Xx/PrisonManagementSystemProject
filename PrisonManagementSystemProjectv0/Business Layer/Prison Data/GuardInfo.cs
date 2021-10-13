using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrisonManagementSystemProjectv0
{
    public class GuardInfo
    {
        public int GuardNo { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string PhoneNumber { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public int BlockNo { set; get; }
        public int UserId { set; get; }

        //public PrisonBlock AssignedBlock { get; set; }
        public Guard UserInfo { set; get; }

        public int SaveGuardInfo()
        {
            DBLayer dB = new DBLayer();
            return dB.AddGuardInfo(this);
        }  
        
        public DataTable GetAllGuards()
        {
            DBLayer dB = new DBLayer();
            return dB.GetAllGuardsInfo();
        }

        public int DeleteGuard(int guardNumber)
        {
            DBLayer dB = new DBLayer();
            return dB.DeleteGuard(guardNumber);
        }

        public DataTable SearchGuard(int guardNo)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchDoctor(guardNo);
        }

        public DataTable SearchGuard(string searchValue, string searchBy)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchGuard(searchValue, searchBy);
        }

        public int UpdateGuard()
        {
            DBLayer dB = new DBLayer();
            return dB.UpdateGuard(this);
        }
    }
}
