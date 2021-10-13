using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrisonManagementSystemProjectv0
{
    public class ReceptionInfo
    {
        public int ReceptionNo { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string PhoneNumber { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public int UserId { set; get; }
        public Reception UserInfo { set; get; }           

        public int SaveReceptionInfo()
        {
            DBLayer dB = new DBLayer();
            return dB.AddReceptionInfo(this);
        }
        
        public DataTable GetAllReceptions()
        {
            DBLayer dB = new DBLayer();
            return dB.GetAllReceptionsInfo();
        }

        public int DeleteRecepiton(int receptionNo)
        {
            DBLayer dB = new DBLayer();
            return dB.DeleteReception(receptionNo);
        }

        public DataTable SearchReception(int receptionNo)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchDoctor(receptionNo);
        }

        public DataTable SearchReception(string searchValue, string searchBy)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchDoctor(searchValue, searchBy);
        }

        public int UpdateReception()
        {
            DBLayer dB = new DBLayer();
            return dB.UpdateReception(this);
        }
    }
}
