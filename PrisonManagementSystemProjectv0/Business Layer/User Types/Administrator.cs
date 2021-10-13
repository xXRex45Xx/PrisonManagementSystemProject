using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrisonManagementSystemProjectv0
{
    public class Administrator : User
    {       

        public Administrator(string userName, string password):base(userName, password)
        {
            Role = "Administrator";
        }

        public int CreateUser(User u)
        {
            DBLayer db = new DBLayer();               
            int rowsAdded = db.AddUser(u);
            if(rowsAdded > 0)
                u.Id = db.GetId(u.UserName);
            return rowsAdded;
        }

        public int GetId(string userName)
        {
            DBLayer dB = new DBLayer();
            return dB.GetId(userName);
        }

        public int DeleteUser(int userId)
        {
            DBLayer dB = new DBLayer();
            return dB.DeleteUser(userId);
        }

        public DataTable GetAllEmployee(string role)
        {
            if (role.Equals("Reception"))
            {
                ReceptionInfo reception = new ReceptionInfo();
                return reception.GetAllReceptions();

            }
            else if (role.Equals("Doctor"))
            {
                DoctorInfo doctor = new DoctorInfo();
                return doctor.GetAllDoctors();

            }
            else if (role.Equals("Guard"))
            {
                GuardInfo guard = new GuardInfo();
                return guard.GetAllGuards();
            }
            else
                return null;
        }

        public int DeleteEmployee(int employeeId, string role)
        {
            if (role.Equals("Reception"))
            {
                ReceptionInfo reception = new ReceptionInfo();
                return reception.DeleteRecepiton(employeeId);

            }
            else if (role.Equals("Doctor"))
            {
                DoctorInfo doctor = new DoctorInfo();
                return doctor.DeleteDoctor(employeeId);

            }
            
            else if (role.Equals("Guard"))
            {
                GuardInfo guard = new GuardInfo();
                return guard.DeleteGuard(employeeId);
            }
            else
                return -1;
        }

        public DataTable SearchEmployee(object searchValue, string searchBy,string role)
        {
            if (role.Equals("Doctor"))
            {
                DoctorInfo doctor = new DoctorInfo();
                if (searchBy.Equals("Employee Number"))
                    return doctor.SearchDoctor(int.Parse(searchValue.ToString()));
                else
                    return doctor.SearchDoctor(searchValue.ToString(), searchBy);
            }
            else if (role.Equals("Reception"))
            {
                ReceptionInfo reception = new ReceptionInfo();
                if (searchBy.Equals("Employee Number"))
                    return reception.SearchReception(int.Parse(searchValue.ToString()));
                else
                    return reception.SearchReception(searchValue.ToString(), searchBy);
            }

            else if (role.Equals("Guard"))
            {
                GuardInfo guard = new GuardInfo();
                if (searchBy.Equals("Employee Number"))
                    return guard.SearchGuard(int.Parse(searchValue.ToString()));
                else
                    return guard.SearchGuard(searchValue.ToString(), searchBy);
            }
            else
                return null;            
        }

        public int UpdateEmployee(UpdateEmployeForm update)
        {
            if(update.Role.Equals("Doctor"))
            {
                DoctorInfo doctor = new DoctorInfo()
                {
                    DoctorNo = update.EmployeeNumber,
                    FirstName = update.FirstName,
                    LastName = update.LastName,
                    DateOfBirth = update.DateOfBirth,
                    PhoneNumber = update.PhoneNumber,
                    Address = update.Address,
                    Email = update.Email
                };
                return doctor.UpdateDoctor();
            }
            else if (update.Role.Equals("Reception"))
            {
                ReceptionInfo reception = new ReceptionInfo() 
                {
                    ReceptionNo = update.EmployeeNumber,
                    FirstName = update.FirstName,
                    LastName = update.LastName,
                    DateOfBirth = update.DateOfBirth,
                    PhoneNumber = update.PhoneNumber,
                    Address = update.Address,
                    Email = update.Email
                };
                return reception.UpdateReception();
            }

            else if (update.Role.Equals("Guard"))
            {
                System.Windows.Forms.MessageBox.Show("Here");
                GuardInfo guard = new GuardInfo()
                {
                    GuardNo = update.EmployeeNumber,
                    FirstName = update.FirstName,
                    LastName = update.LastName,
                    DateOfBirth = update.DateOfBirth,
                    PhoneNumber = update.PhoneNumber,
                    Address = update.Address,
                    Email = update.Email,
                    BlockNo = update.Block
                };
                return guard.UpdateGuard();                
            }
            else
                return -1;
        }

        public int DeletePrisoner(int prisonerNo)
        {
            Prisoner prisoner = new Prisoner();
            return prisoner.DeletePrisoner(prisonerNo);
        }

        public DataTable GetPrisonerTreatment(int prisonerNo)
        {
            DBLayer dB = new DBLayer();
            return dB.GetPrisonerTreatment(prisonerNo);
        }

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
        public int DeleteVisitor(int visitorNo)
        {
            Visitor visitor = new Visitor();
            return visitor.DeleteVisitor(visitorNo);
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
    }
}
