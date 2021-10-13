using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrisonManagementSystemProjectv0
{
    public class Doctor:User
    {
        public Doctor(string userName, string password) : base(userName, password, "Doctor")
        {}

        public DataTable GetPrisonerTreatment(int prisonerNo)
        {
            DBLayer dB = new DBLayer();
            return dB.GetPrisonerTreatment(prisonerNo);
        }

        public DataTable GetUserInfo()
        {
            DBLayer dB = new DBLayer();
            return dB.GetUserInfo(this);
        }

        public int AddTreatment(Treatment treatment) 
        {
            return treatment.AddTreatment();
        }

        public DataTable GetAllTreatments()
        {
            Treatment treatment = new Treatment();
            return treatment.GetAllTreatment();
        }

        public int UpdateTreatment(Treatment treatment)
        {
            return treatment.UpdateTreatment();
        }

        public DataTable SearchTreatment(object searchValue, string searchBy)
        {
            Treatment treatment = new Treatment();
            if (searchBy.Equals("Prisoner Number") || searchBy.Equals("Doctor Number"))
                return treatment.SearchTreatment(int.Parse(searchValue.ToString()), searchBy);
            else
                return treatment.SearchTreatment(searchValue.ToString(), searchBy);
        }
    }
}
