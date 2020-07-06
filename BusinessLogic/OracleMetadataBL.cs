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
                res = this.oraMetaDL.GetCodeBasedColumns("AsignSqlValues", ",");
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
