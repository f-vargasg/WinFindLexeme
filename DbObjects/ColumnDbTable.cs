using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbObjects
{
    public class ColumnDbTable
    {
        public string Name { get; set; }
        public string TypeCol { get; set; }
        public int Precision { get; set; }
        public int Scale { get; set; }
        public bool IsPrimaryKey { get; set; }
    }
}
