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
        public DataTable GetCells()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spGetCells", connection);
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtCells");
                        return set.Tables["dtCells"];
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
