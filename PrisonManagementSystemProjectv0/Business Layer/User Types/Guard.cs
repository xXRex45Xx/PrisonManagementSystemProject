using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrisonManagementSystemProjectv0
{
    public class Guard:User
    {
        public Guard(string userName, string password) : base(userName, password, "Guard")
        {}

        public int AddPrisoner(Prisoner prisoner)
        {
            return prisoner.AddPrisoner();
        }

        public DataTable GetCases(int prisonerNo)
        {
            Prisoner prisoner = new Prisoner();
            return prisoner.GetCases(prisonerNo);
        }

        public int GetLastAddedPrisoner()
        {
            Prisoner prisoner = new Prisoner();
            return prisoner.GetLastAddedPrisoner();
        }

        public int AddPrisonerCase(Case prisonerCase)
        {
            return prisonerCase.AddCase();
        }
    }
}
