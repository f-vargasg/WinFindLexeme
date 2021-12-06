using BusinessEntity;
using CommonLexeme;
using DataLayer;
using Microsoft.SqlServer.Server;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BusinessLogic
{
    public class ExplodePackageTemplate
    {
        // OracleMetaDataDL oracleMetaDataDL;
        OracleTableMetaDL oraTblMeta;

        
        public string TableName {
            get { return this.oraTblMeta.TableName; }
            set { this.oraTblMeta.TableName = value; }
        }
        public string DiscFld {
            get { return this.oraTblMeta.DiscFld; }
            set { this.oraTblMeta.DiscFld = value; }
        }

        public ExplodePackageTemplate(string pOwner, string pTableName, string pDiscFld)
        {
            this.oraTblMeta = new OracleTableMetaDL(pOwner, pTableName, pDiscFld);
        }

        public string ObtPackageName()
        {
            string res = string.Empty;
            string scrap = this.TableName;
            try
            {
                int pos = scrap.IndexOf('_');
                res = scrap;
                if (pos > 0)
                {
                    res = scrap.Substring(0, scrap.IndexOf('_') + 1);
                    int pos1 = pos + 1;
                    int lenStr = scrap.Length - (pos + 1);
                    res = res + "P" + scrap.Substring(pos + 1, lenStr);
                }
                else
                {
                    res = ("pck_"+ this.TableName);
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
            List<OraclePkColumnDef> tblCols = null;
            string res = string.Empty;
            bool ft = true;
            try
            {

                tblCols = this.oraTblMeta.ObtPkColumnDef();
                foreach (var item in tblCols)
                {
                    res += (ft ? string.Empty : ", " + Environment.NewLine) + "P" + item.ColumnName + " IN " + item.DataType;
                    ft = false;
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
            List<OraclePkColumnDef> tblCols = null;
            string res = string.Empty;
            bool ft = true;
            try
            {

                tblCols = this.oraTblMeta.ObtPkColumnDef();
                foreach (var item in tblCols)
                {
                    res += (ft ? string.Empty : Environment.NewLine + " AND ") + item.ColumnName + " =  p" + item.ColumnName;
                    ft = false;
                }
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
                //  res = this.oraMetaDL.GetCodeBasedColumns("", ",", true);
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string TblInsertFlds()
        {
            List<OracleColumnDef> tblCols = null;
            string res = string.Empty;
            bool ft = true;
            try
            {

                tblCols = this.oraTblMeta.ObtColumnDef();
                foreach (var item in tblCols)
                {
                    res += (ft ? string.Empty : ", " + Environment.NewLine) + item.ColumnName;
                    ft = false;
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ParamsToInserta()
        {
            List<OracleColumnDef> tblCols = null;
            string res = string.Empty;
            bool ft = true;
            try
            {
                tblCols = this.oraTblMeta.ObtColumnDef();
                foreach (var item in tblCols)
                {
                    res += (ft ? string.Empty : ", " + Environment.NewLine) +
                        (item.ColumnName.ToUpper().Equals(("COD_REGISTRO_N".ToUpper())) ? "w" : "p") + item.ColumnName;
                    ft = false;
                }
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
                // res = this.oraMetaDL.GetCodeBasedColumns("", ",", true);

                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string TblModifyFlds()
        {
            List<OracleColumnDef> tblCols = null;
            string res = string.Empty;
            bool ft = true;
            try
            {
                tblCols = this.oraTblMeta.ObtNoKeyColumnDef();
                foreach (var item in tblCols)
                {
                    res += (ft ? string.Empty : ", " + Environment.NewLine) +
                         item.ColumnName + " = " +
                         (item.ColumnName.Equals("COD_REGISTRO_N".ToUpper()) ? "w" : "p")
                         + item.ColumnName;
                    ft = false;
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string StmShowValues(string pColName,
                                    string pType)
        {
            try
            {
                string res = "' " + pColName + " = ' || ";
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
            List<OraclePkColumnDef> tblCols = null;
            string res = string.Empty;
            string scrap = string.Empty;
            string scrap1 = string.Empty;
            bool ft = true;
            try
            {

                tblCols = this.oraTblMeta.ObtPkColumnDef();
                foreach (var item in tblCols)
                {
                    scrap =item.ColumnName;
                    scrap1 = item.DataType;


                    scrap = StmShowValues(scrap, scrap1);
                    res += (ft ? string.Empty : " || " + Environment.NewLine) +
                        scrap;
                    ft = false;
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
            const string lexFldDb = "<%fldDb>";
            string res = string.Empty;
            string scrap = string.Empty;
            List<OraclePkColumnDef> tblCols = null;
            string template = " GE_PAMBCOMMON.ADDPARAMNUMBER(pParams => arrParams, " + Environment.NewLine +
                                                      "     PPARAMNAME => " + MyStringUtils.entreChar(lexFldDb, '\'') + ", " + Environment.NewLine +
                                                      "     PVALUE => P" + lexFldDb + ") ";
            bool ft = true;
            try
            {
                tblCols = this.oraTblMeta.ObtPkColumnDef();
                foreach (var item in tblCols)
                {
                    scrap = template;

                    scrap = scrap.Replace(lexFldDb, item.ColumnName);
                    res += (ft? string.Empty : Environment.NewLine + "; ") +
                        scrap;
                    ft = false; 
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
            List<OraclePkColumnDef> tblCols = null;

            bool ft = true;
            try
            {
                tblCols = this.oraTblMeta.ObtPkColumnDef();
                foreach (var item in tblCols)
                {

                    res += (ft ? string.Empty : Environment.NewLine + ", ") +
                        "p" + item.ColumnName + " => " + 
                         (item.ColumnName.Equals("COD_REGISTRO_N".ToUpper()) ? "w" : "p") + item.ColumnName;
                    ft = false;
                }

                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ParamNoDiscFlds()
        {
            string res = string.Empty;
            try
            {
                // res = this.oraMetaDL.ParamNoDiscFlds();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string CodeExpanded(string pLexeme,
                                    string pAlias)
        {
            try
            {
                string res = string.Empty;
                switch (pLexeme)
                {

                    case ConstExpandPck.lexPackageName:
                        res = ObtPackageName();
                        break;

                    case ConstExpandPck.lexTableName:
                        res = this.TableName;
                        break;
                    case ConstExpandPck.lexParamKeyFlds:
                        res = ParamKeyFields();
                        break;
                    case ConstExpandPck.lexParamKeysNoDiscFlds:
                        res = ParamKeysNoDiscFlds();
                        break;
                    case ConstExpandPck.lexParamTableFlds:
                        res = ParamTableFlds();
                        break;

                    case ConstExpandPck.lexCompareKeys:
                        res = CompareKeys();
                        break;
                    case ConstExpandPck.lexParamDefInsert:
                        res = ParamDefInsert();
                        break;
                    case ConstExpandPck.lexAsignaDiscFlds:
                        res = AsignaDiscFlds();
                        break;
                    /*case ConstExpandPck.lexInsertParams:
                        res = InsertParams();
                        break; */
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
                    /* case ConstExpandPck.lexParamNoDiscFlds:
                        res = ParamNoDiscFlds();
                        break; */
                    case ConstExpandPck.lexParamDiscFlds:
                        res = ParamDiscFlds();
                        break;
                    case ConstExpandPck.lexParamsNoKeys:
                        res = ParamsNoKeys();
                        break;

                    case ConstExpandPck.lexCmpNoDiscFlds:
                        res = CmpNoDiscFlds(pAlias);
                        break;
                    /*
        case ConstExpandPck.lexDiscFlds:
            res = this.DiscFld;
            break; */
                    case ConstExpandPck.lexSqlSelectConsec:
                        res = SqlSelectConsec(pAlias);
                        break;
                    case ConstExpandPck.lexParamConsecFunc:
                        res = ParamConsecFunc();
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

        private string ParamConsecFunc()
        {
            string res = string.Empty;
            string scrap = string.Empty;
            try
            {
                // res = "FUNCTION CONSECUTIVO <%paramKeysNoDiscFlds> RETURN NUMBER";
                res = "FUNCTION CONSECUTIVO " +  ConstExpandPck.lexParamKeysNoDiscFlds + " RETURN NUMBER";
                scrap = ParamKeysNoDiscFlds();
                scrap = (scrap.Length > 0 ? "(" + scrap + ")" : scrap);
                res = res.Replace(ConstExpandPck.lexParamKeysNoDiscFlds, scrap);
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string ParamDefInsert()
        {
            string res = string.Empty;
            string scrapTmp = string.Empty;
            try
            {
                scrapTmp = ParamKeysNoDiscFlds();
                res += scrapTmp;

                scrapTmp = ParamDiscFlds();
                res += (res.Length > 0 ? "," : string.Empty) + scrapTmp;

                scrapTmp = ParamsNoKeys();
                res += (res.Length > 0 ? "," : string.Empty) + scrapTmp;

                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string AsignaDiscFlds()
        {
            string res = string.Empty;
            string scrap = string.Empty;
            try
            {
                scrap = ParamCallConsecFunc();
                scrap = (scrap.Length > 0 ? "(" : string.Empty) + scrap + (scrap.Length > 0 ? ")" : string.Empty);
                res = "p" + this.DiscFld + " := Consecutivo " + scrap;
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string ParamTableFlds()
        {
            List<OracleColumnDef> tblCols = null;
            string res = string.Empty;
            bool ft = true;
            try
            {

                tblCols = this.oraTblMeta.ObtColumnDef();
                foreach (var item in tblCols)
                {
                    res += ((ft ? string.Empty : ", " + Environment.NewLine) + "p" + item.ColumnName + " IN " + item.DataType
                              + (item.ColumnName.Equals("COD_REGISTRO_N".ToUpper()) ? " DEFAULT NULL" : string.Empty)
                            );
                    ft = false;
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string ParamKeysNoDiscFlds()
        {
            List<OraclePkColumnDef> tblCols = null;
            string res = string.Empty;
            bool ft = true;
            try
            {

                tblCols = this.oraTblMeta.ObtPkColumnDef();
                foreach (var item in tblCols)
                {
                    if (item.ColumnName.CompareTo(this.DiscFld) != 0)
                    {
                        res += ((ft ? string.Empty : ", " + Environment.NewLine) + "p" + item.ColumnName + " IN " + item.DataType);
                    }
                    ft = false;
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string SqlSelectConsec(string pAlias)
        {
            string res = "SELECT NVL(MAX(" + ConstExpandPck.lexAliasTable + "." + ConstExpandPck.lexDiscFlds + "), 0) + 1 into wres " + Environment.NewLine +
                         "FROM " + ConstExpandPck.lexTableName + " <%aliasTable> " + Environment.NewLine +
                          ConstExpandPck.lexCmpNoDiscFlds;
            string lDiscFlds = string.Empty; ;
            string lCmpNoDiscFlds = string.Empty;
            string scrap = string.Empty;
            //bool ft;
            try
            {
                res = res.Replace(ConstExpandPck.lexDiscFlds, this.DiscFld);
                res = res.Replace(ConstExpandPck.lexTableName, this.TableName);
                res = res.Replace(ConstExpandPck.lexAliasTable, pAlias);
                scrap = CmpNoDiscFlds(pAlias);
                scrap = (scrap.Length > 0 ? "WHERE " + scrap : scrap);
                res = res.Replace(ConstExpandPck.lexCmpNoDiscFlds, scrap);
                /*
                string[] arrDiscFld = pDiscrFld.Split(',');
                string[] arrCmpNoDiscFlds = pCmpNoDiscFlds.Split('=');
                ft = true;
                foreach (var item in arrDiscFld)
                {
                    lDiscFlds += ((ft ? string.Empty : Environment.NewLine + ",") + item);
                    ft = false;
                }

                res = res.Replace(ConstExpandPck.lexDiscFlds, lDiscFlds); ;
                res = res.Replace(lexTableName, pTableName);
                res = res.Replace("<%aliasTable>", pAliasTable);
                res = res.Replace("<%cmpNoDiscFlds>", lCmpNoDiscFlds);
                */
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string CmpNoDiscFlds(string pAlias)
        {
            List<OraclePkColumnDef> tblCols = null;
            string res = string.Empty;
            bool ft = true;
            try
            {

                tblCols = this.oraTblMeta.ObtPkColumnDef();
                foreach (var item in tblCols)
                {
                    if (item.ColumnName.CompareTo(this.DiscFld) != 0)
                    {
                        res += (ft ? string.Empty : " AND " + Environment.NewLine) + pAlias + "." + item.ColumnName + "  = p" + item.ColumnName;
                        ft = false;
                    }


                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string ParamsNoKeys()
        {
            List<OracleColumnDef> tblCols = null;
            string res = string.Empty;
            bool ft = true;
            try
            {
                tblCols = this.oraTblMeta.ObtNoKeyColumnDef();
                foreach (var item in tblCols)
                {
                    res += ((ft ? string.Empty : ", " + Environment.NewLine) + "p" + item.ColumnName + " IN " + item.DataType +
                         (item.ColumnName.Equals("COD_REGISTRO_N".ToUpper()) ? " DEFAULT NULL" : string.Empty)
                        );
                    ft = false;
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string ParamDiscFlds()
        {
            List<OracleColumnDef> tblCols = null;
            string res = string.Empty;
            bool ft = true;
            try
            {
                tblCols = this.oraTblMeta.ObtColumnDef();
                foreach (var item in tblCols)
                {
                    if (item.ColumnName.CompareTo(this.DiscFld) == 0)
                    {
                        res += ((ft ? string.Empty : ", " + Environment.NewLine) + "p" + item.ColumnName + " OUT " + item.DataType);
                        ft = false;
                    }

                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string ParamCallConsecFunc()
        {
            List<OraclePkColumnDef> tblCols = null;
            string res = string.Empty;
            bool ft = true;
            try
            {
                tblCols = this.oraTblMeta.ObtPkColumnDef();
                foreach (var item in tblCols)
                {
                    if (item.ColumnName.CompareTo(this.DiscFld) != 0)
                    {
                        res += ((ft ? string.Empty : ", " + Environment.NewLine) + "p" + item.ColumnName + " => " + "p" + item.ColumnName);
                        ft = false;
                    }

                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<TokenTemp> FindLexemes(string pTexto)
        {
            List<TokenTemp> res;
            TokenTemp tok;
            string scrap = string.Empty; ;
            int vcb = 0;
            int inic = 0;
            int fin = 0;
#pragma warning disable CS0219 // La variable 'tolerancia' está asignada pero su valor nunca se usa
            int tolerancia = 10000;
#pragma warning restore CS0219 // La variable 'tolerancia' está asignada pero su valor nunca se usa
            int cont = 0;
            try
            {
                res = new List<TokenTemp>();
                // while (vcb < pTexto.Length && cont <= tolerancia)
                while (vcb < pTexto.Length)
                {
                    /*                    Console.WriteLine("vcb = " + vcb.ToString());
                                        Console.WriteLine("cont = " + cont.ToString()); */

                    ++cont;
                    vcb = pTexto.IndexOf("<%", inic);
                    if (vcb >= 0)
                    {
                        // busca el cierre
                        fin = pTexto.IndexOf(">", vcb);
                        if (fin >= 0)
                        {
                            scrap = pTexto.Substring(vcb, fin - vcb + 1);
                            tok = new TokenTemp(scrap);
                            if (!res.Contains(tok))
                            {
                                res.Add(tok);
                            }
                            inic = vcb = fin + 1;
                        }
                        else
                        {
                            vcb = pTexto.Length;
                        }
                    }
                    else
                    {
                        vcb = pTexto.Length;
                    }
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ExpandCode(string pTempText,
                                 string pAlias)
        {
            List<TokenTemp> lst;
            string res;
            try
            {
                string expandLex = string.Empty;
                lst = FindLexemes(pTempText);
                res = pTempText;
                foreach (var item in lst)
                {
                    expandLex = CodeExpanded(item.Lexema, pAlias);
                    res = res.Replace(item.Lexema, expandLex);

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
