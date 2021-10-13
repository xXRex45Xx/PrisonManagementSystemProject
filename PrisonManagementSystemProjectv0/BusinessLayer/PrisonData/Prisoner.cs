using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrisonManagementSystemProjectv0
{
    public class Prisoner
    {

        public Prisoner()
        {
            Cases = new List<Case>();
            Visits = new List<Visit>();
            Treatments = new List<Treatment>();
        }

        public int PrisonerNo { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string PhoneNumber { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public DateTime ArriavlDate { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int CellNo { set; get; }

        public List<Case> Cases { set; get; }
        public List<Visit> Visits { set; get; }
        public List<Treatment> Treatments { set; get; }
        public DataTable GetAllPrisoners()
        {
            DBLayer dB = new DBLayer();
            return dB.GetAllPrisoners();
        }
        public int DeletePrisoner(int prisonerNo)
        {
            DBLayer dB = new DBLayer();
            return dB.DeletePrisoner(prisonerNo);
        }

        public DataTable SearchPrisoner(int prisonerNo)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchPrisoner(prisonerNo);
        }

        public DataTable SearchPrisoner(string searchValue, string searchBy)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchPrisoner(searchValue, searchBy);
        }

        public int AddPrisoner()
        {
            DBLayer dB = new DBLayer();
            return dB.AddPrisoner(this);
        }

        public DataTable GetCases(int prisonerNo)
        {
            DBLayer dB = new DBLayer();
            return dB.GetPrisonerCases(prisonerNo);
        }

        public int GetLastAddedPrisoner()
        {
            DBLayer dB = new DBLayer();
            return dB.GetLastAddedPrisoner();
        }

        public int GetNumberOfPrisoners()
        {
            DBLayer dB = new DBLayer();
            return dB.GetNumberOfPrisoners();
        }
    }
}
