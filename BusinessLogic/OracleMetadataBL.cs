using DataLayer;
using DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class OracleMetadataBL
    {
        private const string sqlBase = "from ( " + Environment.NewLine +
select  "+ Environment.NewLine +
(case " + Environment.NewLine +
   when a.DATA_TYPE = 'NUMBER' THEN  " + Environment.NewLine +
     case when a.DATA_SCALE = 0  then  " + Environment.NewLine +
        'int'  " + Environment.NewLine +
     else  " + Environment.NewLine +
        'double'  " + Environment.NewLine +
     end+ Environment.NewLine +
   when a.DATA_TYPE = 'DATE' THEN+ Environment.NewLine +
      'DateTime'+ Environment.NewLine +
   when a.DATA_TYPE = 'VARCHAR2' or+ Environment.NewLine +
        a.DATA_TYPE = 'CLOB'  THEN+ Environment.NewLine +
      'string'+ Environment.NewLine +
   else+ Environment.NewLine +
      'NO-DEFINIDO'+ Environment.NewLine +
end ) as csharpType,+ Environment.NewLine +
replace(initcap (a.column_name), '_')  as CSharpAttribute,+ Environment.NewLine +
lower(SUBSTR(replace(initcap (a.column_name), '_'),1,1)) || + Environment.NewLine +
SUBSTR(replace(initcap (a.column_name), '_'),2 ,length(replace(a.column_name, '_')) - 1) as CSharpMember, + Environment.NewLine +
A.* " + Environment.NewLine +
FROM ALL_TAB_COLUMNS a
where a.TABLE_NAME = '&&tableName'
and a.OWNER = 'MYTEST') reg"
        OracleMetaDataDL oraMetaDL;
        public OracleMetadataBL()
        {
            this.oraMetaDL = new OracleMetaDataDL();
        }

        public string InfoTabla (string pTableName, string pLexemeName)
        {
            string res = string.Empty;

            try
            {

                return res;
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
