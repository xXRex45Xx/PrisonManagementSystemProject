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
        public DataTable GetAllPrisoners()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spViewAllPrisoners", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtAllPrisoners");
                        return set.Tables["dtAllPrisoners"];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public int DeletePrisoner(int prisonerNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spDeletePrisoner", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@prisonerNo", prisonerNumber);
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

        public DataTable SearchPrisoner(int prisonerNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spSearchPrisonerById", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@prisonerNo", prisonerNo);
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

        public DataTable SearchPrisoner(string searchValue, string searchBy)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spSearchPrisoner", connection);
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

        public int AddPrisoner(Prisoner prisoner)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spAddPrisoner", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstName", prisoner.FirstName);
                    command.Parameters.AddWithValue("@lastName", prisoner.LastName);
                    command.Parameters.AddWithValue("@dateOfBirth", prisoner.DateOfBirth);
                    command.Parameters.AddWithValue("@phoneNumber", prisoner.PhoneNumber);
                    command.Parameters.AddWithValue("@address", prisoner.Address);
                    command.Parameters.AddWithValue("@email", prisoner.Email);
                    command.Parameters.AddWithValue("@dateIn", prisoner.ArriavlDate);
                    command.Parameters.AddWithValue("@cellNo", prisoner.CellNo);
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

        public int GetLastAddedPrisoner()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spGetLastPrisoner", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public DataTable GetPrisonerCases(int prisonerNo)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using(SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spViewPrisonerCase", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@prisonerNo", prisonerNo);
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtPrisonerCase");
                        connection.Close();
                        return set.Tables["dtPrisonerCase"];
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
