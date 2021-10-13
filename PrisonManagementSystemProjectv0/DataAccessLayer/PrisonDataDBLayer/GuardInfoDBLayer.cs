using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
 
namespace PrisonManagementSystemProjectv0
{
    public partial class DBLayer
    {
        public int AddGuardInfo(GuardInfo guard)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spAddGuard", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstName", guard.FirstName);
                    command.Parameters.AddWithValue("@lastName", guard.LastName);
                    command.Parameters.AddWithValue("@dateOfBirth", guard.DateOfBirth);
                    command.Parameters.AddWithValue("@phoneNumber", guard.PhoneNumber);
                    command.Parameters.AddWithValue("@address", guard.Address);
                    command.Parameters.AddWithValue("@email", guard.Email);
                    command.Parameters.AddWithValue("@blockNo", guard.BlockNo);
                    command.Parameters.AddWithValue("@userId", guard.UserId);
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
        
        public DataTable GetAllGuardsInfo()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using(SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spViewAllGuards", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtAllGuards");
                        return set.Tables["dtAllGuards"];
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public int DeleteGuard(int guardNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spDeleteGuard", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@guardNo", guardNumber);
                    int rows = command.ExecuteNonQuery();
                    return rows;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public DataTable SearchGuard(string searchValue, string searchBy)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spSearchGuard", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        if (searchBy.Equals("First Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@firstName", searchValue);
                        else if (searchBy.Equals("Last Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@lastName", searchValue);
                        else if (searchBy.Equals("Phone Number"))
                            adapter.SelectCommand.Parameters.AddWithValue("@phoneNo", searchValue);
                        else if (searchBy.Equals("Email"))
                            adapter.SelectCommand.Parameters.AddWithValue("@email", searchValue);
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtSearchResult");
                        return set.Tables["dtSearchResult"];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataTable SearchGuard(int guardNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spSearchGuardById", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@guardNo", guardNo);
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtSearchResult");
                        return set.Tables["dtSearchResult"];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        
        public int UpdateGuard(GuardInfo guard)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spUpdateGuard", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@guardNo", guard.GuardNo);
                    command.Parameters.AddWithValue("@firstName", guard.FirstName);
                    command.Parameters.AddWithValue("@lastName", guard.LastName);
                    command.Parameters.AddWithValue("@dateOfBirth", guard.DateOfBirth);
                    command.Parameters.AddWithValue("@phoneNumber", guard.PhoneNumber);
                    command.Parameters.AddWithValue("@address", guard.Address);
                    command.Parameters.AddWithValue("@email", guard.Email);
                    command.Parameters.AddWithValue("@blockNo", guard.BlockNo);
                    int rows = command.ExecuteNonQuery();
                    connection.Close();
                    return rows;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public int GetNumberOfGuards()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spGetNumberOfGuards", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    int numberOfGuards = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    return numberOfGuards;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
    }
}
