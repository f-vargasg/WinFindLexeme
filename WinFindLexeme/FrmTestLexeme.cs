using BusinessEntity;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOraclePackage
{
    public partial class FrmTestLexeme : Form
    {

        public OracleTableMetaBL oBl { get; set; }
        public FrmTestLexeme()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            txtOwner.Text = "MYTEST";
            txtTableName.Text = ConfigurationManager.AppSettings["defTableName"];
            txtDiscFld.Text = ConfigurationManager.AppSettings["defDiscFld"];

        }

        private void butOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void butDo_Click(object sender, EventArgs e)
        {
            try
            {
                //this.oBl.ExpandCode(txtBoxLexeme.Text, "a");
                this.oBl = new OracleTableMetaBL(txtOwner.Text,  txtTableName.Text, txtDiscFld.Text );
                List<OracleColumnDef> lst = this.oBl.ObtColumnDef();
                txtOutput.Text += "<<<<<<<<<<<<<<<<<<Columns>>>>>>>>>>>>>>>" + Environment.NewLine ;
                foreach (var item in lst)
                {
                    txtOutput.Text += item.ColumnName + Environment.NewLine;
                }

                txtOutput.Text += "<<<<<<<<<<<<<<<<<<PK>>>>>>>>>>>>>>>" + Environment.NewLine;
                List<OraclePkColumnDef> lstPk = new List<OraclePkColumnDef>();
                foreach (var item in this.oBl.ObtPkColumnDef())
                {
                    txtOutput.Text += (item.ColumnName + Environment.NewLine);
                }

                // pk info




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int OptionalArgs (int p1 = 2, int p2 =4)
        {
            return p1 + p2;
        }


        private void butTestOptParams_Click(object sender, EventArgs e)
        {
            int res = OptionalArgs(p2:14);
            MessageBox.Show(res.ToString());
        }
    }
}
