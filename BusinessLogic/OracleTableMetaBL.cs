using BusinessEntity;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class OracleTableMetaBL
    {

        OracleTableMetaDL orTblDef;

        public string TableName { get; set; }
        public string Owner { get; set; }

        public OracleTableMetaBL(string pOwner, 
                                  string pTableName,
                                  string pDiscFld)
        {
            this.TableName = pTableName;
            this.Owner = pOwner;
            this.orTblDef = new OracleTableMetaDL(pOwner, pTableName, pDiscFld);

        }

        public List<OracleColumnDef> ObtColumnDef()
        {
            List<OracleColumnDef> res = null;

            try
            {
                res = orTblDef.ObtColumnDef();
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<OraclePkColumnDef> ObtPkColumnDef()
        {
            List<OraclePkColumnDef> res = null;
            try
            {
                res = orTblDef.ObtPkColumnDef();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }





    }
}
