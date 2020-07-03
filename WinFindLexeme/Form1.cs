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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void butDo_Click(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            string scrap;

            lst.Add ("<%lex1>");
            lst.Add ("<%lex2>");

            string hil1 = "<%lex1>  donde el mundo viaja <%lex2>";
            txtInput.Text = hil1;
            txtOutput.Text = hil1;

            // Recolectar Lexemas

            foreach (var item in lst)
            {

                scrap =  txtOutput.Text.Replace(item, "xxxxxx");
                txtOutput.Text = scrap;
            }

            

            // Sustituirlos
        }
    }
}
