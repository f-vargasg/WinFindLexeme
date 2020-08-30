using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class OraclePkColumnDef
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string DataType { get; set; }
        public string ColumnName { get; set; }
        public int Position { get; set; }
        public string Status { get; set; }
    }
}
