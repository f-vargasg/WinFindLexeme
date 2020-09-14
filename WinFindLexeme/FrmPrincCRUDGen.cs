using BusinessEntity;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;

namespace WinFindLexeme
{
    public partial class FrmPrincCRUDGen : Form
    {

        // OracleMetadataBL oraMetaBL;
        ExplodePackageTemplate expandCode;
        string owner;

        public FrmPrincCRUDGen()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.Text = this.Text + " (" + this.Name + ")";
            this.owner = ConfigurationManager.AppSettings["defOwner"];
            txtOwner.Text = this.owner;
            // this.oraMetaBL = new OracleMetadataBL(txtTableName.Text, txtDiscFld.Text);
            txtTableName.Text = ConfigurationManager.AppSettings["defTableName"];
            txtDiscFld.Text = ConfigurationManager.AppSettings["defDiscFld"];
            this.expandCode = new ExplodePackageTemplate(this.owner, txtTableName.Text, txtDiscFld.Text);
            
            //string pathBodyFile = ConfigurationManager.AppSettings["pathBody"];
            LoadTemplates();

        }

        private void LoadTemplates()
        {
            string pathFileSpec = ConfigurationManager.AppSettings["pathSpec"];
            txtTempSpec.Text  = File.ReadAllText(pathFileSpec);
            string pathBodyFile = ConfigurationManager.AppSettings["pathBody"];
            txtTempBod.Text = File.ReadAllText(pathBodyFile);
        }



        private void DoTlsStrp_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                LoadTemplates();
                txtSpec.Text = this.expandCode.ExpandCode(txtTempSpec.Text, "a");
                txtBody.Text = this.expandCode.ExpandCode(txtTempBod.Text, "a");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }


        private void TestTlsStrp_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTestLexeme frm = new FrmTestLexeme();

                frm.ShowDialog();
                frm.Dispose();

                /*
                this.oraMetaBL.TableName = txtTableName.Text;
                this.oraMetaBL.DiscFld = txtDiscFld.Text;
                string scrap = this.oraMetaBL.StmSelectConsec();
                txtBody.Text = scrap;
                */

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ExittlsStr_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoadTempTlsStrp_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTemplates();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ButDo_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Text = string.Empty;
                //this.oBl.ExpandCode(txtBoxLexeme.Text, "a");
                OracleTableMetaBL   oBl = new OracleTableMetaBL(txtOwner.Text, txtTableName.Text, txtDiscFld.Text);
                txtOutput.Text += "<<<<<<<<<<<<<<<<<<PK>>>>>>>>>>>>>>>" + Environment.NewLine;
                List<OraclePkColumnDef> lstPk = new List<OraclePkColumnDef>();
                foreach (var item in oBl.ObtPkColumnDef())
                {
                    txtOutput.Text += (item.ColumnName + Environment.NewLine);
                }

                List<OracleColumnDef> lst = oBl.ObtColumnDef();
                txtOutput.Text += "<<<<<<<<<<<<<<<<<<Columns>>>>>>>>>>>>>>>" + Environment.NewLine;
                foreach (var item in lst)
                {
                    txtOutput.Text += item.ColumnName + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
