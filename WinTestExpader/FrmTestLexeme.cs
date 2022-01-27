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

namespace WinTestExpader
{
    public partial class FrmTestLexeme : Form
    {

        ExplodePackageTemplate oBl;
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
            oBl = new ExplodePackageTemplate(txtOwner.Text, txtTableName.Text, txtDiscFld.Text);
        }

        private void butDo_Click(object sender, EventArgs e)
        {
            try
            {
                oBl.Owner = txtOwner.Text;
                oBl.TableName = txtTableName.Text;
                oBl.DiscFld = txtDiscFld.Text;
                string lexeme = "<%" + txtLexeme.Text + ">";
                txtOutput.Text = oBl.CodeExpanded(lexeme, "a");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
