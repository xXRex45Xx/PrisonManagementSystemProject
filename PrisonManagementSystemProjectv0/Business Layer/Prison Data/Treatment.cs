using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace PrisonManagementSystemProjectv0
{
    public class Treatment
    {
        public int DoctorNo { set; get; }
        public int PrisonerNo { set; get; }
        public DateTime DateOfTreatment { set; get; }
        public DateTime TimeOfTreatment{ set; get; }
        public string Diagnosis { set; get; }

        public DataTable GetTreatment(int prisonerNo)
        {
            DBLayer dB = new DBLayer();
            return dB.GetPrisonerTreatment(prisonerNo);
        }

        public int DeletePrisonerTreatment(int prisonerNo)
        {
            DBLayer dB = new DBLayer();
            return dB.DeletePrisonerTreatment(prisonerNo);
        }

        public int AddTreatment()
        {
            DBLayer dB = new DBLayer();
            return dB.AddTreatment(this);
        }

        public DataTable GetAllTreatment()
        {
            DBLayer dB = new DBLayer();
            return dB.GetAllTreatments();
        }

        public int UpdateTreatment()
        {
            DBLayer dB = new DBLayer();
            return dB.UpdateTreatment(this);
        }

        public DataTable SearchTreatment(int searchValue, string searchBy)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchTreatment(searchValue, searchBy);
        }

        public DataTable SearchTreatment(string searchValue, string searchBy)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchTreatment(searchValue, searchBy);
            
        }
    }
}
