using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFindLexeme
{
    public partial class FrmTestLexeme : Form
    {

        public string TableName { get; set; }
        public string DiscFld { get; set; }

        OracleMetadataBL oBl = new OracleMetadataBL();



        public FrmTestLexeme()
        {
            InitializeComponent();
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
                this.oBl.ExpandCode(txtBoxLexeme.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
