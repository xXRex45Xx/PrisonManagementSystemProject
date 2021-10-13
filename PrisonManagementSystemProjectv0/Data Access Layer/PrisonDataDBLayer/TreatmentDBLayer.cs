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
        public DataTable GetPrisonerTreatment(int prisonerNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spViewPrisonerTreatment", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@prisonerNo", prisonerNo);
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtPrisonerTreatment");
                        return set.Tables["dtPrisonerTreatment"];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public int DeletePrisonerTreatment(int prisonerNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spDeleteTreatment", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@prisonerNo", prisonerNo);
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

        public int AddTreatment(Treatment treatment)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spAddTreatment", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@prisonerNo", treatment.PrisonerNo);
                    command.Parameters.AddWithValue("@doctorNo", treatment.DoctorNo);
                    command.Parameters.AddWithValue("@dateOfTreatment", treatment.DateOfTreatment);
                    command.Parameters.AddWithValue("@timeOfTreatment", treatment.TimeOfTreatment);
                    command.Parameters.AddWithValue("@diagnosis", treatment.Diagnosis);
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

        public DataTable GetAllTreatments()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spViewAllTreatments", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtAllTreatments");
                        return set.Tables["dtAllTreatments"];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public int UpdateTreatment(Treatment treatment)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spUpdateTreatment", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@prisonerNo", treatment.PrisonerNo);
                    command.Parameters.AddWithValue("@doctorNo", treatment.DoctorNo);
                    command.Parameters.AddWithValue("@dateOfTreatment", treatment.DateOfTreatment);
                    command.Parameters.AddWithValue("@diagnosis", treatment.Diagnosis);
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

        public DataTable SearchTreatment(int searchValue, string searchBy)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        if (searchBy.Equals("Prisoner Number"))
                        {
                            adapter.SelectCommand = new SqlCommand("spSearchTreatmentByPrisonerNo", connection);
                            adapter.SelectCommand.Parameters.AddWithValue("@prisonerNo", searchValue);
                        }
                        else
                        {
                            adapter.SelectCommand = new SqlCommand("spSearchTreatmentByDoctorNo", connection);
                            adapter.SelectCommand.Parameters.AddWithValue("@doctorNo", searchValue);
                        }
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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

        public DataTable SearchTreatment(string searchValue, string searchBy)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spSearchTreatment", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        if (searchBy.Equals("Prisoner First Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@prisonerFName", searchValue);
                        else if (searchBy.Equals("Prisosner Last Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@prisonerLName", searchValue);
                        else if (searchBy.Equals("Doctor First Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@doctorFName", searchValue);
                        else if (searchBy.Equals("Doctor Last Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@doctorLName", searchValue);
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
    }
}
