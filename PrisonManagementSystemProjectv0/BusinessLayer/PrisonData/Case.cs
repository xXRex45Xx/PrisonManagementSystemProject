using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonManagementSystemProjectv0
{
    public class Case
    {
        public int CaseNo { set; get; }
        public string CrimeType { set; get; }
        public DateTime DateOfCrime { set; get; }
        public DateTime DateOfVerdict { set; get; }
        public int PrisonerNo { set; get; }
        public int YearDecided { set; get; }

        public int AddCase()
        {
            DBLayer dB = new DBLayer();
            return dB.AddPrisonerCase(this);
        }

        public int DeletePrisonerCase(int prisonerNo)
        {
            DBLayer dB = new DBLayer();
            return dB.DeletePrisonerCase(prisonerNo);
        }
    }
}
