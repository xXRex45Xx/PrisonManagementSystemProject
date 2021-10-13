using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PrisonManagementSystemProjectv0
{
    public partial class DBLayer
    {
        public DataTable GetBlocks()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using(SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("spGetBlocks", connection);
                        DataSet set = new DataSet();
                        adapter.Fill(set, "dtBlocks");
                        return set.Tables["dtBlocks"];
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