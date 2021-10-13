using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrisonManagementSystemProjectv0
{
    public class PrisonBlock
    {
        public int BlockNo { get; set; }
        public string BlockType { get; set; }
        
        public string[] GetBlockList()
        {
            DBLayer dB = new DBLayer();
            DataTable table = dB.GetBlocks();
            List<string> blockList = new List<string>();            
            for(int i = 0; i < table.Rows.Count; i++)            
                blockList.Add(table.Rows[i].Field<int>("blockNo").ToString());          
            return blockList.ToArray();
        }
       
    }
}
