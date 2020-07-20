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

        OracleMetadataBL oraMetaBL;
        public FrmPrincCRUDGen()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.Text = this.Text + " (" + this.Name + ")";
            this.oraMetaBL = new OracleMetadataBL();
            txtTableName.Text = ConfigurationManager.AppSettings["defTableName"];
            txtDiscFld.Text = ConfigurationManager.AppSettings["defDiscFld"];
            string pathFileSpec = ConfigurationManager.AppSettings["pathSpec"];
            txtTempSpec.Text = File.ReadAllText(pathFileSpec);

            string pathBodyFile = ConfigurationManager.AppSettings["pathBody"];
            txtTempBod.Text = File.ReadAllText(pathBodyFile);

        }
        

        private void DoTlsStrp_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.oraMetaBL.TableName = txtTableName.Text;
                this.oraMetaBL.DiscFld = txtDiscFld.Text;
                txtSpec.Text = this.oraMetaBL.ExpandCode(txtTempSpec.Text);
                txtBody.Text = this.oraMetaBL.ExpandCode(txtTempBod.Text);

                
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
                this.oraMetaBL.TableName = txtTableName.Text;
                this.oraMetaBL.DiscFld = txtDiscFld.Text;
                string scrap = this.oraMetaBL.StmSelectConsec();
                txtBody.Text = scrap;
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
    }
}
