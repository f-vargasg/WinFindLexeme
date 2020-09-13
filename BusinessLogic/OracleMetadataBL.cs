using BusinessEntity;
using CommonLexeme;
using DataLayer;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{

    [ObsoleteAttribute("This Class has been deprecated. Use CodeExpandPck instead.", true)]
    public class OracleMetadataBL
    {
        OracleMetaDataDL oraMetaDL;

        public OracleMetadataBL(string pTableName, string pDiscFld)
        {
            this.TableName = pTableName;
            this.DiscFld = pDiscFld;
            this.oraMetaDL = new OracleMetaDataDL(pTableName, pDiscFld);
        }

        public string TableName { get ; set ; }

        public string DiscFld { get; set; }

        public string ObtPackageName()
        {
            string res = string.Empty;

            try
            {
                res = this.oraMetaDL.ObtPackageName();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }



    }

}
