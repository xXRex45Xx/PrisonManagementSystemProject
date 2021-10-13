using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrisonManagementSystemProjectv0
{
    public class Visit
    {
        public int VisitorNo { set; get; }
        public int PrisonerNo { set; get; }
        public DateTime DateOfVisit { set; get; }
        public DateTime TimeOfVisit { set; get; }

        public DataTable GetPrisonerVisit(int prisonerNo)
        {
            DBLayer dB = new DBLayer();
            return dB.GetPrisonerVisit(prisonerNo);
        }

        public int DeletePrisonerVisit(int prisonerNo)
        {
            DBLayer dB = new DBLayer();
            return dB.DeletePrisonerVisit(prisonerNo);
        }

        public DataTable GetVisitorVisit(int visitorNo)
        {
            DBLayer dB = new DBLayer();
            return dB.GetVisitorVisit(visitorNo);
        }

        public int DeleteVisitorVisit(int visitorNo)
        {
            DBLayer dB = new DBLayer();
            return dB.DeletePrisonerVisit(visitorNo);
        }

        public DataTable GetAllVisits()
        {
            DBLayer dB = new DBLayer();
            return dB.GetAllVisits();
        }

        public int DeleteVisit()
        {
            DBLayer dB = new DBLayer();
            return dB.DeleteVisit(this);
        }

        public DataTable SearchVisit(int searchValue, string searchBy)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchVisit(searchValue, searchBy);
        }

        public DataTable SearchVisit(string searchValue, string searchBy)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchVisit(searchValue, searchBy);
        }

        public int AddVisit()
        {
            DBLayer dB = new DBLayer();
            return dB.AddVisit(this);
        }
    }
}
