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
        public DataTable GetPrisonerVisit(int prisonerNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spViewPrisonerVisit", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@prisonerNo", prisonerNo);
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtPrisonerVisit");
                        return set.Tables["dtPrisonerVisit"];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataTable GetVisitorVisit(int visitorNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spViewVisitorVisit", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@visitorNo", visitorNo);
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtVisitorVisit");
                        return set.Tables["dtVisitorVisit"];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public int DeletePrisonerVisit(int prisonerNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spDeleteVisitByPrisoner", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@prisonerNo", prisonerNo);
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

        public int DeleteVisitorVisit(int visitorNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spDeleteVisitByVisitor", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@visitorNo", visitorNo);
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

        public DataTable GetAllVisits()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using(SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spViewAllVisits", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtAllVisits");
                        return set.Tables["dtAllVisits"];
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public int DeleteVisit(Visit visit)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spDeleteVisit", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@prisonerNo", visit.PrisonerNo);
                    command.Parameters.AddWithValue("@visitorNo", visit.VisitorNo);
                    command.Parameters.AddWithValue("@dateOfVisit", visit.DateOfVisit);
                    int rowsDeleted = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsDeleted;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public DataTable SearchVisit(int searchValue, string searchBy)
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
                            adapter.SelectCommand = new SqlCommand("spSearchVisitByPrisonerNo", connection);
                            adapter.SelectCommand.Parameters.AddWithValue("@prisonerNo", searchValue);
                        }
                        else
                        {
                            adapter.SelectCommand = new SqlCommand("spSearchVisitByVisitorNo", connection);
                            adapter.SelectCommand.Parameters.AddWithValue("@visitorNo", searchValue);
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

        public DataTable SearchVisit(string searchValue, string searchBy)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spSearchVisit", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        if (searchBy.Equals("Prisoner First Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@prisonerFName", searchValue);
                        else if (searchBy.Equals("Prisosner Last Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@prisonerLName", searchValue);
                        else if (searchBy.Equals("Visitor First Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@visitorFName", searchValue);
                        else if (searchBy.Equals("Visitor Last Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@visitorLName", searchValue);
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

        public int AddVisit(Visit visit)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spAddVisit", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@prisonerNo", visit.PrisonerNo);
                    command.Parameters.AddWithValue("@visitorNo", visit.VisitorNo);
                    command.Parameters.AddWithValue("@dateOfVisit", visit.DateOfVisit);
                    command.Parameters.AddWithValue("@timeOfVisit", visit.TimeOfVisit);
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

        public int GetNumberOfVisits()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spGetNumberOfVisits", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    int numberOfVisits = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    return numberOfVisits;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
    }
}
