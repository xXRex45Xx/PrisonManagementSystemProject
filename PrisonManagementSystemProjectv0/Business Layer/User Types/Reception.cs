using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrisonManagementSystemProjectv0
{
    public class Reception:User
    {
        public Reception(string userName, string password) : base(userName, password, "Reception") 
        {}

        public DataTable GetPrisonerVisit(int prisonerNo)
        {
            Visit visit = new Visit();
            return visit.GetPrisonerVisit(prisonerNo);
        }

        public DataTable GetAllVisitors()
        {
            Visitor visitor = new Visitor();
            return visitor.GetAllVisitors();
        }

        public DataTable GetVisitorVisit(int visitorNo)
        {
            Visit visit = new Visit();
            return visit.GetVisitorVisit(visitorNo);
        }

        public DataTable SearchVisitor(object searchValue, string searchBy)
        {
            Visitor visitor = new Visitor();
            if (searchBy.Equals("Visitor Number"))
                return visitor.SearchVisitor(int.Parse(searchValue.ToString()));
            else
                return visitor.SearchVisitor(searchValue.ToString(), searchBy);
        }

        public DataTable GetAllVisits()
        {
            Visit visit = new Visit();
            return visit.GetAllVisits();
        }

        public int DeleteVisit(Visit visit)
        {
            return visit.DeleteVisit();
        }

        public DataTable SearchVisit(object searchValue, string searchBy)
        {
            Visit visit = new Visit();
            if (searchBy.Equals("Prisoner Number") || searchBy.Equals("Visitor Number"))
                return visit.SearchVisit(int.Parse(searchValue.ToString()), searchBy);
            else
                return visit.SearchVisit(searchValue.ToString(), searchBy);
        }

        public int AddVisitor(Visitor visitor)
        {
            return visitor.AddVisitor();
        }

        public int GetLastAddedVisitor()
        {
            Visitor visitor = new Visitor();
            return visitor.GetLastAddedVisitor();
        }

        public int AddVisit(Visit visit)
        {
            return visit.AddVisit();
        }
    }
}
