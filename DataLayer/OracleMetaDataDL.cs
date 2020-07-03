using DbObjects;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataLayer
{
    public class OracleMetaDataDL
    {
        OracleConnection conn;

        public OracleMetaDataDL()
        {
            this.conn = ConnGl.Instance.Conn;
        }

        public DbTable ObtInfoTable(string ptableName)
        {
            
        }

    }
}
