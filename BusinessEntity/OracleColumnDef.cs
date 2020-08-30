using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class OracleColumnDef
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public string DataTypeMod { get; set; }
        public string DataTypeOwner { get; set; }
        public int DataLength { get; set; }
        public int DataPrecision { get; set; }
        public int DataScale { get; set; }
        public string Nullable { get; set; }
        public int ColumnId { get; set; }
        public int DefaultLength { get; set; }
        public object DataDefault { get; set; }
        public int NumDistinct { get; set; }
        public object LowValue { get; set; }
        public object HighValue { get; set; }
        public int Density { get; set; }
        public int NumNulls { get; set; }
        public int NumBuckets { get; set; }
        public DateTime? LastAnalyzed { get; set; }
        public int SampleSize { get; set; }
        public string CharacterSetName { get; set; }
        public int CharColDeclLength { get; set; }
        public string GlobalStats { get; set; }
        public string UserStats { get; set; }
        public int AvgColLen { get; set; }
        public int CharLength { get; set; }
        public string CharUsed { get; set; }
        public string V80FmtImage { get; set; }
        public string DataUpgraded { get; set; }
        public string Histogram { get; set; }
        public string DefaultOnNull { get; set; }
        public string IdentityColumn { get; set; }
        public string EvaluationEdition { get; set; }
        public string UnusableBefore { get; set; }
        public string UnusableBeginning { get; set; }
        public string Collation { get; set; }
    }
}
