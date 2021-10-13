using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrisonManagementSystemProjectv0
{
    public class Visitor
    {
        public int VisitorNo { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string PhoneNumber { set; get; }
        public string Address { set; get; }

        public DataTable GetAllVisitors()
        {
            DBLayer dB = new DBLayer();
            return dB.GetAllVisitors();
        }

        public int DeleteVisitor(int visitorNo)
        {
            DBLayer dB = new DBLayer();
            return dB.DeleteVisitor(visitorNo);
        }

        public DataTable SearchVisitor(int visitorNo)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchVisitor(visitorNo);
        }

        public DataTable SearchVisitor(string searchValue, string searchBy)
        {
            DBLayer dB = new DBLayer();
            return dB.SearchVisitor(searchValue, searchBy);
        }

        public int AddVisitor()
        {
            DBLayer dB = new DBLayer();
            return dB.AddVisitor(this);
        }

        public int GetLastAddedVisitor()
        {
            DBLayer dB = new DBLayer();
            return dB.GetLastAddedVisitor();
        }

        public int GetNumberOfVisitors()
        {
            DBLayer dB = new DBLayer();
            return dB.GetNumberOfVisitors();
        }
    }
}
