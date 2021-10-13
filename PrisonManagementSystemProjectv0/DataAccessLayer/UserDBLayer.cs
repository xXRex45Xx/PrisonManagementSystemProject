using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PrisonManagementSystemProjectv0
{
    partial class DBLayer
    {
        private static readonly string _connectionString = "server=localhost;database=PrisonDatabase;uid=esrom;pwd=esrom;";       
        public int AddUser(User u)
        {            
            try
            {                
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spAddUser", connection);
                    command.CommandType = CommandType.StoredProcedure;                    
                    command.Parameters.AddWithValue("@userName", u.UserName);
                    command.Parameters.AddWithValue("@password", u.Password);                    
                    command.Parameters.AddWithValue("@role", u.Role);
                    int rows = command.ExecuteNonQuery();
                    connection.Close();
                    return rows;                    
                }
            }
            catch(SqlException)
            {                
                MessageBox.Show(String.Format("Username {0} already exists!", u.UserName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch(Exception)
            {
                string error = "Database Error! Try restarting your computer. If error persists contact your system administrator.";
                MessageBox.Show(error, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return -1;
            }
        }

        public bool Login(User u)
        {  
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using(SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spLogin", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("userName", u.UserName);
                        adapter.SelectCommand.Parameters.AddWithValue("password", u.Password);
                        DataSet set = new DataSet();                        
                        adapter.Fill(set, "dtRole");
                        DataTable table = set.Tables["dtRole"];
                        
                        if (table.Rows.Count != 0)
                        {
                            u.Role = table.Rows[0].ItemArray[0].ToString();
                            return true;
                        }
                        else
                            return false;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            
        }

        public static int GetNumberOfUsers()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    int numberOfUsers;
                    connection.Open();
                    using(SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spCountUsers", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtUserCount");                        
                        connection.Close();
                        numberOfUsers = Convert.ToInt32(set.Tables["dtUserCount"].Rows[0].ItemArray[0]);
                        return numberOfUsers;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }
        
        public int GetId(string userName)
        {            
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spGetId", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userName", userName);
                    object objId = command.ExecuteScalar();
                    if (objId != null)
                        return Convert.ToInt32(objId);
                    else
                        return -1;                    
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public int DeleteUser(int userId)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spDeleteUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userId", userId);
                    int rows = command.ExecuteNonQuery();
                    return rows;
                }            
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public DataTable GetUserInfo(Doctor doctor)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using(SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spGetDoctorInfoByUser", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@userName", doctor.UserName);
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtDoctor");
                        connection.Close();
                        return set.Tables["dtDoctor"];
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public int ChangeUserCreds(string oldUserName, User newUser)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spUpdateUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@oldUserName", oldUserName);
                    command.Parameters.AddWithValue("@newUserName", newUser.UserName);
                    command.Parameters.AddWithValue("@newPassword", newUser.Password);
                    int rows = command.ExecuteNonQuery();
                    connection.Close();
                    return rows;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }       
    }
}
