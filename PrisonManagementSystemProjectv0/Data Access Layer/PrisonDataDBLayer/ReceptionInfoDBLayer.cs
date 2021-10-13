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
    public partial class DBLayer
    {
        public int AddReceptionInfo(ReceptionInfo reception)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spAddReception", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstName", reception.FirstName);
                    command.Parameters.AddWithValue("@lastName", reception.LastName);
                    command.Parameters.AddWithValue("@dateOfBirth", reception.DateOfBirth);
                    command.Parameters.AddWithValue("@phoneNumber", reception.PhoneNumber);
                    command.Parameters.AddWithValue("@address", reception.Address);
                    command.Parameters.AddWithValue("@email", reception.Email);
                    command.Parameters.AddWithValue("@userId", reception.UserId);
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
        public DataTable GetAllReceptionsInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spViewAllReceptions", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtAllReceptions");
                        return set.Tables["dtAllReceptions"];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public int DeleteReception(int receptionNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spDeleteReception", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@receptionNo", receptionNumber);
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
        
        public DataTable SearchReception(string searchValue, string searchBy)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spSearchReception", connection);
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

        public DataTable SearchReception(int receptionNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spSearchReceptionById", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@receptionNo", receptionNo);
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
        public int UpdateReception(ReceptionInfo reception)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spUpdateReception", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@receptionNo", reception.ReceptionNo);
                    command.Parameters.AddWithValue("@firstName", reception.FirstName);
                    command.Parameters.AddWithValue("@lastName", reception.LastName);
                    command.Parameters.AddWithValue("@dateOfBirth", reception.DateOfBirth);
                    command.Parameters.AddWithValue("@phoneNumber", reception.PhoneNumber);
                    command.Parameters.AddWithValue("@address", reception.Address);
                    command.Parameters.AddWithValue("@email", reception.Email);
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
