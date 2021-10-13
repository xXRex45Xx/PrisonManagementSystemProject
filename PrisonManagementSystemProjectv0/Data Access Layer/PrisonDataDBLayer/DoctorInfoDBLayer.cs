using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrisonManagementSystemProjectv0
{
    public partial class DBLayer
    {        
        public int AddDoctorInfo(DoctorInfo doctor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spAddDoctor", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstName", doctor.FirstName);
                    command.Parameters.AddWithValue("@lastName", doctor.LastName);
                    command.Parameters.AddWithValue("@dateOfBirth", doctor.DateOfBirth);
                    command.Parameters.AddWithValue("@phoneNumber", doctor.PhoneNumber);
                    command.Parameters.AddWithValue("@address", doctor.Address);
                    command.Parameters.AddWithValue("@email", doctor.Email);
                    command.Parameters.AddWithValue("@userId", doctor.UserId);
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

        public DataTable GetAllDoctorsInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spViewAllDoctors", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtAllDoctors");
                        return set.Tables["dtAllDoctors"];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public int DeleteDoctor(int doctorNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spDeleteDoctor", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@doctorNo", doctorNumber);
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

        public DataTable SearchDoctor(string searchValue, string searchBy)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spSearchDoctor", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        if (searchBy.Equals("First Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@firstName", searchValue);
                        else if(searchBy.Equals("Last Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@lastName", searchValue);
                        else if(searchBy.Equals("Phone Number"))
                            adapter.SelectCommand.Parameters.AddWithValue("@phoneNo", searchValue);
                        else if(searchBy.Equals("Email"))
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

        public DataTable SearchDoctor(int doctorNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spSearchDoctorById", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@doctorNo", doctorNo);
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

        public int UpdateDoctor(DoctorInfo doctor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spUpdateDoctor", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@doctorNo", doctor.DoctorNo);
                    command.Parameters.AddWithValue("@firstName", doctor.FirstName);
                    command.Parameters.AddWithValue("@lastName", doctor.LastName);
                    command.Parameters.AddWithValue("@dateOfBirth", doctor.DateOfBirth);
                    command.Parameters.AddWithValue("@phoneNumber", doctor.PhoneNumber);
                    command.Parameters.AddWithValue("@address", doctor.Address);
                    command.Parameters.AddWithValue("@email", doctor.Email);
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
    }
}
