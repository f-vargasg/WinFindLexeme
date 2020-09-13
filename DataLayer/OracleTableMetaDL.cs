using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OracleTableMetaDL : DataWorker
    {
        private const string lexTableName = "<%tableName>";
        private const string lexOwner = "<%owner>";
        private const string lexDiscFld = "<%discFld>";
        #region SQL Base
        private const string sqlBase =
                "select a.* \n" +
                " FROM ALL_TAB_COLUMNS a \n" +
                        "where a.TABLE_NAME = '" + lexTableName + "' \n" +
                        "and a.OWNER = '" + lexOwner + "' \n";
        #endregion SQL Base

        #region SQL Keys
        private const string sqlKeysTable = "SELECT cons.owner, cols.table_name, tabcols.data_type, cols.column_name,  \n" +
                         " cols.position, cons.status, cons.owner \n" +
                         " FROM all_constraints cons, all_cons_columns cols, all_tab_columns tabcols \n" +
                           "  WHERE \n" +
                "  tabcols.owner = '" + lexOwner + "' \n" +
                "  AND cols.table_name = '" + lexTableName + "' \n" +
                "  AND cons.constraint_type = 'P' \n" +
                "  AND cons.constraint_name = cols.constraint_name \n" +
                "  AND cons.owner = cols.owner \n" +
                "and cols.column_name = tabcols.column_name \n" +
                " and cols.table_name = tabcols.table_name \n" +
                " and cols.owner = tabcols.owner \n" +
                "  ORDER BY cols.table_name, cols.position ";


        #endregion

        #region SQL No Keys
        private const string sqlNokeys = "SELECT a.owner, a.table_name, a.data_type, a.column_name, A.COLUMN_ID  \n" +
                                        " FROM ALL_TAB_COLUMNS a  \n" +
                                        " where a.TABLE_NAME = 'GE_AMBPRUEBA'  \n" +
                                        " and a.OWNER = 'MYTEST'  \n" +
                                        " MINUS  \n" +
                                        " SELECT cons.owner, cols.table_name, tabcols.data_type, cols.column_name, tabcols.column_id  \n" +
                                        " --cols.position, cons.status  \n" +
                                        " FROM all_constraints cons, all_cons_columns cols, all_tab_columns tabcols  \n" +
                                           " WHERE  \n" +
                                           " cols.table_name = '" + lexTableName + "'  \n" +
                                           " AND CONS.OWNER = 'MYTEST'  \n" +
                                        " AND cons.constraint_type = 'P' \n" +
                                        " AND cons.constraint_name = cols.constraint_name  \n" +
                                        "  AND cons.owner = cols.owner  \n" +
                                        " and cols.column_name = tabcols.column_name \n" +
                                         " and cols.table_name = tabcols.table_name  \n" +
                                         " and cols.owner = tabcols.owner \n" +
                                        " ORDER BY column_id";


        #endregion

        public string TableName { get; set; }
        public string Owner { get; set; }
        public string DiscFld { get; set; }

        public OracleTableMetaDL(string pOwner, string pTableName, string pDiscFld )
        {
            this.TableName = pTableName;
            this.Owner = pOwner;
            this.DiscFld = pDiscFld;
        }

        public List<OracleColumnDef> ObtColumnDef ()
        {
            List<OracleColumnDef> res = null;
            string sqlStm;

            try
            {
                res = new List<OracleColumnDef>();
                sqlStm = sqlBase;
                sqlStm = sqlStm.Replace(lexTableName, this.TableName);
                sqlStm = sqlStm.Replace(lexOwner, this.Owner);
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateCommand(sqlStm, connection))
                    {
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OracleColumnDef cdBe = new OracleColumnDef();
                                cdBe.Owner = Convert.ToString(reader["OWNER"]);
                                cdBe.TableName = Convert.ToString(reader["TABLE_NAME"]);
                                cdBe.ColumnName = Convert.ToString(reader["COLUMN_NAME"]);
                                cdBe.DataType = Convert.ToString(reader["DATA_TYPE"]);
                                cdBe.DataTypeMod = Convert.ToString(reader["DATA_TYPE_MOD"]);
                                cdBe.DataTypeOwner = Convert.ToString(reader["DATA_TYPE_OWNER"]);
                                cdBe.DataLength = Convert.ToInt32(reader["DATA_LENGTH"]);
                                cdBe.DataPrecision = Convert.ToInt32(reader["DATA_PRECISION"] == DBNull.Value ? -1 : reader["DATA_PRECISION"]);
                                cdBe.DataScale = Convert.ToInt32(reader["DATA_SCALE"] == DBNull.Value ? -1 : reader["DATA_SCALE"]);
                                cdBe.Nullable = Convert.ToString(reader["NULLABLE"] == DBNull.Value ? -1 : reader["NULLABLE"]) ;
                                cdBe.ColumnId = Convert.ToInt32(reader["COLUMN_ID"] == DBNull.Value ? -1 : reader["COLUMN_ID"]);
                                cdBe.DefaultLength = Convert.ToInt32(reader["DEFAULT_LENGTH"] == DBNull.Value ? -1 : reader["DEFAULT_LENGTH"]);
                                cdBe.DataDefault = null;
                                cdBe.NumDistinct = Convert.ToInt32(reader["NUM_DISTINCT"] == DBNull.Value ? -1 : reader["NUM_DISTINCT"]);
                                cdBe.LowValue = null;
                                cdBe.HighValue = null;
                                cdBe.Density = Convert.ToInt32(reader["DENSITY"] == DBNull.Value ? -1 : reader["DENSITY"]);
                                cdBe.NumNulls = Convert.ToInt32(reader["NUM_NULLS"] == DBNull.Value ? -1 : reader["NUM_NULLS"]);
                                cdBe.NumBuckets = Convert.ToInt32(reader["NUM_BUCKETS"] == DBNull.Value ? -1 : reader["NUM_BUCKETS"]);
                                cdBe.LastAnalyzed = Convert.ToDateTime(reader["LAST_ANALYZED"] == DBNull.Value ? null : reader["LAST_ANALYZED"]);
                                cdBe.SampleSize = Convert.ToInt32(reader["SAMPLE_SIZE"] == DBNull.Value ? -1 : reader["SAMPLE_SIZE"]);
                                cdBe.CharacterSetName = Convert.ToString(reader["CHARACTER_SET_NAME"] == DBNull.Value ? string.Empty : reader["CHARACTER_SET_NAME"]);
                                cdBe.CharColDeclLength = Convert.ToInt32(reader["CHAR_COL_DECL_LENGTH"] == DBNull.Value ? -1 : reader["CHAR_COL_DECL_LENGTH"]);
                                cdBe.GlobalStats = Convert.ToString(reader["GLOBAL_STATS"] == DBNull.Value ? string.Empty : reader["GLOBAL_STATS"]);
                                cdBe.UserStats = Convert.ToString(reader["USER_STATS"] == DBNull.Value ? string.Empty : reader["USER_STATS"]);
                                cdBe.AvgColLen = Convert.ToInt32(reader["AVG_COL_LEN"] == DBNull.Value ? -1 : reader["AVG_COL_LEN"]);
                                cdBe.CharLength = Convert.ToInt32(reader["CHAR_LENGTH"] == DBNull.Value ? -1 : reader["CHAR_LENGTH"]); ;
                                cdBe.CharUsed = Convert.ToString(reader["CHAR_USED"] == DBNull.Value ? string.Empty : reader["CHAR_USED"]);
                                cdBe.V80FmtImage = Convert.ToString(reader["V80_FMT_IMAGE"] == DBNull.Value ? string.Empty : reader["V80_FMT_IMAGE"]);
                                cdBe.DataUpgraded = Convert.ToString(reader["DATA_UPGRADED"] == DBNull.Value ? string.Empty : reader["DATA_UPGRADED"]);
                                cdBe.Histogram = Convert.ToString(reader["HISTOGRAM"] == DBNull.Value ? string.Empty : reader["HISTOGRAM"]);
                                cdBe.DefaultOnNull = Convert.ToString(reader["DEFAULT_ON_NULL"] == DBNull.Value ? string.Empty : reader["DEFAULT_ON_NULL"]);
                                cdBe.IdentityColumn = Convert.ToString(reader["IDENTITY_COLUMN"] == DBNull.Value ? string.Empty : reader["IDENTITY_COLUMN"]);
                                cdBe.EvaluationEdition = Convert.ToString(reader["EVALUATION_EDITION"] == DBNull.Value ? string.Empty : reader["EVALUATION_EDITION"]);
                                cdBe.UnusableBefore = Convert.ToString(reader["UNUSABLE_BEFORE"] == DBNull.Value ? string.Empty : reader["UNUSABLE_BEFORE"]);
                                cdBe.UnusableBeginning = Convert.ToString(reader["UNUSABLE_BEGINNING"] == DBNull.Value ? string.Empty : reader["UNUSABLE_BEGINNING"]);
                                cdBe.Collation = Convert.ToString(reader["COLLATION"] == DBNull.Value ? string.Empty : reader["COLLATION"]);

                                res.Add(cdBe);
                            }
                        }
                    }
                }
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<OraclePkColumnDef> ObtPkColumnDef ()
        {
            List<OraclePkColumnDef> res;
            string sqlStm;
            try
            {
                res = new List<OraclePkColumnDef>();
                sqlStm = sqlKeysTable;
                sqlStm = sqlStm.Replace(lexTableName, this.TableName);
                sqlStm = sqlStm.Replace(lexOwner, this.Owner);
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateCommand(sqlStm, connection))
                    {
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OraclePkColumnDef cdBe = new OraclePkColumnDef();
                                cdBe.Owner = Convert.ToString(reader["OWNER"] == DBNull.Value ? string.Empty : reader["OWNER"]);
                                cdBe.TableName = Convert.ToString(reader["TABLE_NAME"] == DBNull.Value ? string.Empty : reader["TABLE_NAME"]);
                                cdBe.DataType = Convert.ToString(reader["DATA_TYPE"] == DBNull.Value ? string.Empty : reader["DATA_TYPE"]);
                                cdBe.ColumnName = Convert.ToString(reader["COLUMN_NAME"] == DBNull.Value ? string.Empty : reader["COLUMN_NAME"]);
                                cdBe.Position = Convert.ToInt32(reader["POSITION"] == DBNull.Value ? string.Empty : reader["POSITION"]);
                                cdBe.Status = Convert.ToString(reader["STATUS"] == DBNull.Value ? string.Empty : reader["STATUS"]);
                                cdBe.Owner = Convert.ToString(reader["OWNER"] == DBNull.Value ? string.Empty : reader["OWNER"]);

                                res.Add(cdBe);
                            }
                        }
                    }
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    
        public List<OracleColumnDef> ObtNoKeyColumnDef ()
        {
            List<OracleColumnDef> res;
            string sqlStm;
            try
            {
                res = new List<OracleColumnDef>();
                sqlStm = "Select a.* \n" +
                        "from all_tab_columns a  \n" +
                        "where a.table_name = '" + lexTableName + "'  \n" +
                        "AND a.owner = '" + lexOwner + "'  \n" +
                        "and not exists (  \n" +
                        "    SELECT 1  \n" +
                        "    FROM all_constraints cons, all_cons_columns cols, all_tab_columns tabcols  \n" +
                        "    WHERE  \n" +
                        "    cons.table_name = '"+ lexTableName + "'\n" +
                        "    AND cons.owner = '" + lexOwner + "'  AND  \n" +
                        "    cons.constraint_type = 'P' and \n" +
                        "    cons.owner = a.owner \n" +
                        "    AND cons.table_name = a.table_name \n" +
                        "    and cols.column_name = a.column_name    AND   \n" +
                        "    cons.owner = cols.owner \n" +
                        "    AND cons.constraint_name = cols.constraint_name \n" +
                        "    AND CONS.TABLE_NAME = COLS.TABLE_NAME \n" +
                        "    and cols.owner = tabcols.owner \n" +
                        "    and cols.table_name = tabcols.table_name \n" +
                        "    and cols.column_name = tabcols.column_name  \n" +
                        " )";
                sqlStm = sqlStm.Replace(lexTableName, this.TableName);
                sqlStm = sqlStm.Replace(lexOwner, this.Owner);
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateCommand(sqlStm, connection))
                    {
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OracleColumnDef cdBe = new OracleColumnDef();
                                cdBe.Owner = Convert.ToString(reader["OWNER"]);
                                cdBe.TableName = Convert.ToString(reader["TABLE_NAME"]);
                                cdBe.ColumnName = Convert.ToString(reader["COLUMN_NAME"]);
                                cdBe.DataType = Convert.ToString(reader["DATA_TYPE"]);
                                cdBe.DataTypeMod = Convert.ToString(reader["DATA_TYPE_MOD"]);
                                cdBe.DataTypeOwner = Convert.ToString(reader["DATA_TYPE_OWNER"]);
                                cdBe.DataLength = Convert.ToInt32(reader["DATA_LENGTH"]);
                                cdBe.DataPrecision = Convert.ToInt32(reader["DATA_PRECISION"] == DBNull.Value ? -1 : reader["DATA_PRECISION"]);
                                cdBe.DataScale = Convert.ToInt32(reader["DATA_SCALE"] == DBNull.Value ? -1 : reader["DATA_SCALE"]);
                                cdBe.Nullable = Convert.ToString(reader["NULLABLE"] == DBNull.Value ? -1 : reader["NULLABLE"]);
                                cdBe.ColumnId = Convert.ToInt32(reader["COLUMN_ID"] == DBNull.Value ? -1 : reader["COLUMN_ID"]);
                                cdBe.DefaultLength = Convert.ToInt32(reader["DEFAULT_LENGTH"] == DBNull.Value ? -1 : reader["DEFAULT_LENGTH"]);
                                cdBe.DataDefault = null;
                                cdBe.NumDistinct = Convert.ToInt32(reader["NUM_DISTINCT"] == DBNull.Value ? -1 : reader["NUM_DISTINCT"]);
                                cdBe.LowValue = null;
                                cdBe.HighValue = null;
                                cdBe.Density = Convert.ToInt32(reader["DENSITY"] == DBNull.Value ? -1 : reader["DENSITY"]);
                                cdBe.NumNulls = Convert.ToInt32(reader["NUM_NULLS"] == DBNull.Value ? -1 : reader["NUM_NULLS"]);
                                cdBe.NumBuckets = Convert.ToInt32(reader["NUM_BUCKETS"] == DBNull.Value ? -1 : reader["NUM_BUCKETS"]);
                                cdBe.LastAnalyzed = Convert.ToDateTime(reader["LAST_ANALYZED"] == DBNull.Value ? null : reader["LAST_ANALYZED"]);
                                cdBe.SampleSize = Convert.ToInt32(reader["SAMPLE_SIZE"] == DBNull.Value ? -1 : reader["SAMPLE_SIZE"]);
                                cdBe.CharacterSetName = Convert.ToString(reader["CHARACTER_SET_NAME"] == DBNull.Value ? string.Empty : reader["CHARACTER_SET_NAME"]);
                                cdBe.CharColDeclLength = Convert.ToInt32(reader["CHAR_COL_DECL_LENGTH"] == DBNull.Value ? -1 : reader["CHAR_COL_DECL_LENGTH"]);
                                cdBe.GlobalStats = Convert.ToString(reader["GLOBAL_STATS"] == DBNull.Value ? string.Empty : reader["GLOBAL_STATS"]);
                                cdBe.UserStats = Convert.ToString(reader["USER_STATS"] == DBNull.Value ? string.Empty : reader["USER_STATS"]);
                                cdBe.AvgColLen = Convert.ToInt32(reader["AVG_COL_LEN"] == DBNull.Value ? -1 : reader["AVG_COL_LEN"]);
                                cdBe.CharLength = Convert.ToInt32(reader["CHAR_LENGTH"] == DBNull.Value ? -1 : reader["CHAR_LENGTH"]); ;
                                cdBe.CharUsed = Convert.ToString(reader["CHAR_USED"] == DBNull.Value ? string.Empty : reader["CHAR_USED"]);
                                cdBe.V80FmtImage = Convert.ToString(reader["V80_FMT_IMAGE"] == DBNull.Value ? string.Empty : reader["V80_FMT_IMAGE"]);
                                cdBe.DataUpgraded = Convert.ToString(reader["DATA_UPGRADED"] == DBNull.Value ? string.Empty : reader["DATA_UPGRADED"]);
                                cdBe.Histogram = Convert.ToString(reader["HISTOGRAM"] == DBNull.Value ? string.Empty : reader["HISTOGRAM"]);
                                cdBe.DefaultOnNull = Convert.ToString(reader["DEFAULT_ON_NULL"] == DBNull.Value ? string.Empty : reader["DEFAULT_ON_NULL"]);
                                cdBe.IdentityColumn = Convert.ToString(reader["IDENTITY_COLUMN"] == DBNull.Value ? string.Empty : reader["IDENTITY_COLUMN"]);
                                cdBe.EvaluationEdition = Convert.ToString(reader["EVALUATION_EDITION"] == DBNull.Value ? string.Empty : reader["EVALUATION_EDITION"]);
                                cdBe.UnusableBefore = Convert.ToString(reader["UNUSABLE_BEFORE"] == DBNull.Value ? string.Empty : reader["UNUSABLE_BEFORE"]);
                                cdBe.UnusableBeginning = Convert.ToString(reader["UNUSABLE_BEGINNING"] == DBNull.Value ? string.Empty : reader["UNUSABLE_BEGINNING"]);
                                cdBe.Collation = Convert.ToString(reader["COLLATION"] == DBNull.Value ? string.Empty : reader["COLLATION"]);

                                res.Add(cdBe);
                            }
                        }
                    }
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
