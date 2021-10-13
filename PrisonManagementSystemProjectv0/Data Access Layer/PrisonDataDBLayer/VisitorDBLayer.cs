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
        public DataTable GetAllVisitors()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spViewAllVisitors", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtAllVisitors");
                        return set.Tables["dtAllVisitors"];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public int DeleteVisitor(int visitorNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spDeleteVisitor", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@visitorNo", visitorNumber);
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
        public DataTable SearchVisitor(int visitorNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spSearchVisitorById", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.Parameters.AddWithValue("@visitorNo", visitorNo);
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

        public DataTable SearchVisitor(string searchValue, string searchBy)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spSearchVisitor", connection);
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        if (searchBy.Equals("First Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@firstName", searchValue);
                        else if (searchBy.Equals("Last Name"))
                            adapter.SelectCommand.Parameters.AddWithValue("@lastName", searchValue);
                        else if (searchBy.Equals("Phone Number"))
                            adapter.SelectCommand.Parameters.AddWithValue("@phoneNo", searchValue);                        
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

        public int AddVisitor(Visitor visitor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spAddVisitor", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstName", visitor.FirstName);
                    command.Parameters.AddWithValue("@lastName", visitor.LastName);
                    command.Parameters.AddWithValue("@dateOfBirth", visitor.DateOfBirth);
                    command.Parameters.AddWithValue("@phoneNumber", visitor.PhoneNumber);
                    command.Parameters.AddWithValue("@address", visitor.Address);
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

        public int GetLastAddedVisitor()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spGetLastVisitor", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    return Convert.ToInt32(command.ExecuteScalar());
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
