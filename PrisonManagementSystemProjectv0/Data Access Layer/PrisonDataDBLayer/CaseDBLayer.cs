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
        public int AddPrisonerCase(Case prisonerCase)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spAddPrisonerCase", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@caseNo", prisonerCase.CaseNo);
                    command.Parameters.AddWithValue("@crimeType", prisonerCase.CrimeType);
                    command.Parameters.AddWithValue("@dateOfCrime", prisonerCase.DateOfCrime);
                    command.Parameters.AddWithValue("@dateOfVerdict", prisonerCase.DateOfVerdict);
                    command.Parameters.AddWithValue("@prisonerNo", prisonerCase.PrisonerNo);
                    command.Parameters.AddWithValue("@yearsDecided", prisonerCase.YearDecided);
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

        public int DeletePrisonerCase(int prisonerNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spDeleteCase", connection);
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
    }
}
