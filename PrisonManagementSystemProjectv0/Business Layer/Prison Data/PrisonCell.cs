using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrisonManagementSystemProjectv0
{
    class PrisonCell
    {
        public int CellNo { get; set; }
        public int Floor { get; set; }
        public int BlockNo { get; set; }
        public PrisonBlock Block { set; get; }

        public string[] GetCellList()
        {
            DBLayer dB = new DBLayer();
            DataTable table = dB.GetCells();
            List<string> cellList = new List<string>();
            for (int i = 0; i < table.Rows.Count; i++)
                cellList.Add(table.Rows[i].Field<int>("cellNo").ToString());
            return cellList.ToArray();
        }
    }
}
