using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Utilities;

namespace DataLayer
{
    public class OracleMetaDataDL : DataWorker
    {

        // Lexemas
        private const string lexTableName = "<%tableName>";
        private const string lexFldDb = "<%fldDb>";

        #region SQL Base
        private const string sqlBase =
                "Select reg.column_name  as listColumns, \n" +
                "'p' || reg.column_name  as listColsParams, \n" +
                "'p' || reg.column_name || ' IN ' || reg.data_type  as listParamSql, \n" +
                "reg.column_name || ' = p' || reg.column_name  as asignSqlValues, \n" +
                "reg.csharpType || ' p' || reg.CSharpAttribute || ', ' as ParamCSharp , \n" +
                "'this.'||reg.CSharpMember || ' = p' ||  reg.CSharpAttribute || ';' as AsignValues, \n" +
                "reg.column_name ||  ',' as columnsONly, \n" +
                "'scrap += \"' || reg.column_name || ' =\" + MyStringUtils.entreComas(' || lower(reg.column_name) || ')' as updateDL, \n" +
                "reg.csharpType || ' ' || reg.CSharpMember as classAttribute, \n" +
                "reg.CSharpMember, \n" +
                "reg.CSharpAttribute \n" +
                    "from ( \n" +
                        " select  \n" +
                        "(case \n" +
                        "   when a.DATA_TYPE = 'NUMBER' THEN  \n" +
                        "     case when a.DATA_SCALE = 0  then  \n" +
                        "        'int'  \n" +
                        "     else  \n" +
                        "        'double'  \n" +
                        "     end \n" +
                        "   when a.DATA_TYPE = 'DATE' THEN \n" +
                        "      'DateTime' \n" +
                        "   when a.DATA_TYPE = 'VARCHAR2' or \n" +
                        "        a.DATA_TYPE = 'CLOB'  THEN \n" +
                        "      'string' \n" +
                        "   else \n" +
                        "      'NO-DEFINIDO' \n" +
                        "end ) as csharpType, \n" +
                        "replace(initcap (a.column_name), '_')  as CSharpAttribute, \n" +
                        "lower(SUBSTR(replace(initcap (a.column_name), '_'),1,1)) || \n" +
                        "SUBSTR(replace(initcap (a.column_name), '_'),2 ,length(replace(a.column_name, '_')) - 1) as CSharpMember, \n" +
                        "A.* \n" +
                        "FROM ALL_TAB_COLUMNS a \n" +
                        "where a.TABLE_NAME = '" + lexTableName + "' \n" +
                        "and a.OWNER = 'MYTEST') reg";
        #endregion SQL Base

        #region SQL Keys
        private const string sqlKeysTable = "SELECT cons.owner, cols.table_name, tabcols.data_type, cols.column_name,  \n" +
                         " cols.position, cons.status, cons.owner \n" +
                         " FROM all_constraints cons, all_cons_columns cols, all_tab_columns tabcols \n" +
                           "  WHERE \n" +
                           "  cols.table_name = '" + lexTableName + "' \n" +
                "  AND cons.constraint_type = 'P' \n" +
                "  AND cons.constraint_name = cols.constraint_name \n" +
                "  AND cons.owner = cols.owner \n" +
                "and cols.column_name = tabcols.column_name \n" +
                " and cols.table_name = tabcols.table_name \n" +
                " and cols.owner = tabcols.owner \n" +
                "  ORDER BY cols.table_name, cols.position ";


        #endregion


        public string TableName { get; set; }


        public string ObtPackageName()
        {
            string res = string.Empty;
            string scrap = this.TableName;
            int inic = -1;
            int fin = -1;
            try
            {
                // Busca _
                fin = scrap.IndexOf('_', 0);
                if (fin >= 0)  // encontro
                {
                    res = this.TableName.Substring(0, fin + 1) + "P" +
                          this.TableName.Substring(fin + 1, this.TableName.Length - fin - 1);
                    ;
                }
                else
                {
                    res = "pck_" + this.TableName;
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }

        }



        public string ParamKeyFields()
        {
            string sqlStm;
            string res = string.Empty;
            bool ft = true;

            try
            {
                sqlStm = sqlKeysTable;
                sqlStm = sqlStm.Replace(lexTableName, this.TableName);
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateCommand(sqlStm, connection))
                    {
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                res += (ft ? string.Empty : ", " + Environment.NewLine) + 'p' + Convert.ToString(reader["COLUMN_NAME"]) + "  IN " + reader["DATA_TYPE"];
                                ft = false;
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

        public string CompareKeys()
        {
            string sqlStm;
            string res = string.Empty;
            bool ft = true;

            try
            {
                sqlStm = sqlKeysTable;
                sqlStm = sqlStm.Replace(lexTableName, this.TableName);
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateCommand(sqlStm, connection))
                    {
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                res += (ft ? string.Empty : Environment.NewLine + " AND ") +
                                    Convert.ToString(reader["COLUMN_NAME"]) + "  = p" + reader["COLUMN_NAME"];
                                ft = false;
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

        public string GetCodeBasedColumns(string pLexeme,
                                          string pSeparador,
                                          bool pTrailSeparator)
        {
            string sqlStm;
            string res = string.Empty;
            int contFilas = 0;
            bool ft = true;

            try
            {
                sqlStm = sqlBase;
                sqlStm = sqlStm.Replace(lexTableName, this.TableName);
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateCommand(sqlStm, connection))
                    {
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                res += (ft ? string.Empty : pSeparador + Environment.NewLine) +
                                Convert.ToString(reader[pLexeme]);
                                ft = false;
                            }
                            res += (pTrailSeparator ? pSeparador : string.Empty);
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

        public string AddKeysParametersInvoke()
        {
            string res = string.Empty;
            string sqlStm = string.Empty;
            string scrap = string.Empty;
            string template = " GE_PAMBCOMMON.ADDPARAMNUMBER(pParams => arrParams, " + Environment.NewLine +
                                                      "     PPARAMNAME => " + lexFldDb + ", " + Environment.NewLine +
                                                      "     PVALUE => P" + lexFldDb + "); ";
            bool ft = true;
            try
            {
                sqlStm = sqlKeysTable;
                sqlStm = sqlStm.Replace(lexTableName, this.TableName);
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateCommand(sqlStm, connection))
                    {
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                scrap = template;

                                scrap = scrap.Replace(lexFldDb, Convert.ToString(reader["COLUMN_NAME"]));
                                res += (ft ? string.Empty : Environment.NewLine + "; ") +
                                    scrap;
                                ft = false;
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

        public string ParamKeysCall()
        {
            string res = string.Empty;
            string scrap = string.Empty;
            bool ft = true;

            try
            {
                string sqlStm = sqlKeysTable;
                sqlStm = sqlStm.Replace(lexTableName, this.TableName);
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateCommand(sqlStm, connection))
                    {
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                scrap = reader["COLUMN_NAME"] + " => p" + reader["COLUMN_NAME"];
                                res += (ft ? string.Empty : ", " + Environment.NewLine) +
                                    scrap;
                                ft = false;
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

        private string stmShowValues(string pColName,
                                     string pType)
        {
            string res = string.Empty;
            try
            {
                res = "'" + pColName + " = ' || ";
                switch (pType)
                {
                    case "VARCHAR2":
                        res += ("p" + pColName);
                        break;
                    case "NUMBER":
                        res += ("TO_CHAR(p" + pColName + ")");
                        break;
                    case "DATE":
                        res += ("TO_DATE(p" + pColName + ", 'DD/MM/RRRR')");
                        break;
                    default:
                        break;
                }
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
            string scrap = string.Empty;
            string scrap1 = string.Empty;
            bool ft = true;

            try
            {
                string sqlStm = sqlKeysTable;
                sqlStm = sqlStm.Replace(lexTableName, this.TableName);
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateCommand(sqlStm, connection))
                    {
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                scrap = Convert.ToString(reader["COLUMN_NAME"]);
                                scrap1 = Convert.ToString(reader["DATA_TYPE"]);


                                scrap = stmShowValues(scrap, scrap1);
                                res += (ft ? string.Empty : " || " + Environment.NewLine) +
                                    scrap;
                                ft = false;
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
