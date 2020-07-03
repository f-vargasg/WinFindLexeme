using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbObjects
{
    public class DbTable
    {
        public string Name { get; set; }
        public List<ColumnDbTable> Columns { get; set; }

        public DbTable(string pName)
        {
            this.Name = pName;
            this.Columns = new List<ColumnDbTable>();
        }
    }
}
