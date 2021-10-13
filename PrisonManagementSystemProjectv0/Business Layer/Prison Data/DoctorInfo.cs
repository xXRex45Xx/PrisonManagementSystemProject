using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrisonManagementSystemProjectv0
{
    public class DoctorInfo
    {
        public int DoctorNo { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string PhoneNumber { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public int UserId { set; get; }
        
        public Doctor UserInfo { set; get; }

        public int SaveDoctorInfo()
        {
            DBLayer dB = new DBLayer();
            return dB.AddDoctorInfo(this);
        }

        public DataTable GetAllDoctors()
        {
            DBLayer dB = new DBLayer();
            return dB.GetAllDoctorsInfo();
        }

        public int DeleteDoctor(int doctorNumber)
        {
            DBLayer dB = new DBLayer();
            return dB.DeleteDoctor(doctorNumber);
        }

        public DataTable SearchDoctor(int doctorNo)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchDoctor(doctorNo);
        }

        public DataTable SearchDoctor(string searchValue, string searchBy)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchDoctor(searchValue, searchBy);
        }

        public int UpdateDoctor()
        {
            DBLayer dB = new DBLayer();
            return dB.UpdateDoctor(this);
        }
    }
}
