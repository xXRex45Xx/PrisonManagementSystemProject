using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data;


namespace PrisonManagementSystemProjectv0
{
    public class User
    {
        public int Id { set;  get; }
        public string UserName { get; }
        public string Password{ get; }       
        public string Role { get; set; }

        
        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = HashPassword(password);
        }
        public User(string userName, string password, string role) : this(userName, password)
        {
            this.Role = role;
        }
        public bool Login()
        {
            DBLayer dB = new DBLayer();
            if (dB.Login(this))
            {                
                return true;
            }
            else
            {
                return false;
            }
        }       
        private string HashPassword(string password)
        {
            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();            
            byte[] passowrd_bytes = Encoding.Unicode.GetBytes(password);
            byte[] encrypted_bytes = sha256.ComputeHash(passowrd_bytes);          
            return Convert.ToBase64String(encrypted_bytes);                    
        }
        
        public DataTable GetAllPrisoners()
        {
            Prisoner prisoner = new Prisoner();
            return prisoner.GetAllPrisoners();
        }

        public DataTable SearchPrisoner(object searchValue, string searchBy)
        {
            Prisoner prisoner = new Prisoner();
            if (searchBy.Equals("Prisoner Number"))
                return prisoner.SearchPrisoner(int.Parse(searchValue.ToString()));
            else
                return prisoner.SearchPrisoner(searchValue.ToString(), searchBy);            
        }

        public int GetNumberOfPrisoners()
        {
            Prisoner prisoner = new Prisoner();
            return prisoner.GetNumberOfPrisoners();
        }


        public int ChangeCredentials(string oldUserName)
        {
            DBLayer dB = new DBLayer();
            return dB.ChangeUserCreds(oldUserName, this);
        }

    }
}
