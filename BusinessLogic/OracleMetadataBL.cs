using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class OracleMetadataBL
    {
        OracleMetaDataDL oraMetaDL;


        public OracleMetadataBL()
        {
            this.oraMetaDL = new OracleMetaDataDL();
        }

        public string TableName { get => this.oraMetaDL.TableName; set => this.oraMetaDL.TableName = value; }

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

        public string ParamKeyFields()
        {
            string res = string.Empty;
            try
            {
                res = this.oraMetaDL.ParamKeyFields();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string CompareKeys()
        {
            string res = string.Empty;
            try
            {
                res = this.oraMetaDL.CompareKeys();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string InsertParams()
        {
            string res = string.Empty;
            try
            {
                res = this.oraMetaDL.GetCodeBasedColumns("ListParamSQL", ",");
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string TblInsertFlds()
        {
            string res = string.Empty;
            try
            {
                res = this.oraMetaDL.GetCodeBasedColumns("ListColumns", ",");
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ParamsToInserta()
        {
            string res = string.Empty;
            try
            {
                res = this.oraMetaDL.GetCodeBasedColumns("ListColsParams", ",");
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ModifyParams()
        {
            string res = string.Empty;
            try
            {
                res = this.oraMetaDL.GetCodeBasedColumns("ListParamSql", ",");
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string TblModifyFlds()
        {
            string res = string.Empty;
            try
            {
                res = this.oraMetaDL.GetCodeBasedColumns("AsignSqlValues", ",");
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //TODO: paramKeyFlds
        public string ParamKeyFlds()
        {
            string res = string.Empty;
            try
            {
                res = this.oraMetaDL.ParamKeyFields();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string PrintLstKeys()
        {
            string res = string.Empty;
            try
            {
                res = this.oraMetaDL.PrintLstKeys();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    
        public string AddKeysParametersInvoke ()
        {
            string res = string.Empty;
            try
            {
                res = this.oraMetaDL.AddKeysParametersInvoke();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ParamKeysCall()
        {
            string res = string.Empty;
            try
            {
                res = this.oraMetaDL.ParamKeysCall();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string CodeExpanded (string plexeme)
        {
            try
            {
                string res = string.Empty;
                switch (plexeme)
                {
                    case ConstExpandPck.lexPackageName:
                        res = ObtPackageName();
                        break;
                    case ConstExpandPck.lexTableName:
                        res = TableName;
                        break;
                    case ConstExpandPck.lexParamKeyFlds:
                        res = ParamKeyFields();
                        break;
                    case ConstExpandPck.lexCompareKeys:
                        res = CompareKeys();
                        break;
                    case ConstExpandPck.lexInsertParams:
                        res = InsertParams();
                        break;
                    case ConstExpandPck.lexTblInsertFlds:
                        res = TblInsertFlds();
                        break;
                    case ConstExpandPck.lexParamsToInserta:
                        res = ParamsToInserta();
                        break;
                    case ConstExpandPck.lexModifyParams:
                        res = ModifyParams();
                        break;
                    case ConstExpandPck.lexTblModifyFlds:
                        res = TblModifyFlds();
                        break;
                    case ConstExpandPck.lexPrintLstKeys:
                        res = PrintLstKeys();
                        break;
                    case ConstExpandPck.lexAddKeysParametersInvoke:
                        res = AddKeysParametersInvoke();
                        break;
                    case ConstExpandPck.lexParamKeysCall:
                        res = ParamKeysCall();
                        break;
                    default:
                        res = "<NO_DEFINIDO>";
                        break;
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }

}
