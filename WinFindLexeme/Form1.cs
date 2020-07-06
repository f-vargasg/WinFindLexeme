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
    public partial class Form1 : Form
    {

        OracleMetadataBL oraMetaBL;
        public Form1()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.oraMetaBL = new OracleMetadataBL();
            txtTableName.Text = ConfigurationManager.AppSettings["defTableName"];
            string pathFileSpec = ConfigurationManager.AppSettings["pathSpec"];
            txtInput.Text = File.ReadAllText(pathFileSpec);

        }

        List<TokenTemp> FindLexemes(string pTexto)
        {
            List<TokenTemp> res;
            TokenTemp tok;
            string scrap = string.Empty; ;
            int vcb = 0;
            int inic = 0;
            int fin = 0;
            int tolerancia = 10000;
            int cont = 0;
            try
            {
                res = new List<TokenTemp>();
               // while (vcb < pTexto.Length && cont <= tolerancia)
                 while (vcb < pTexto.Length )
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



        private void butDo_Click(object sender, EventArgs e)
        {

            List<TokenTemp> lst;

            try
            {
                lst = FindLexemes(txtInput.Text);

                foreach (var item in lst)
                {
                    txtOutput.Text += item.ToString() + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            // Sustituirlos
        }

        private void butTest_Click(object sender, EventArgs e)
        {
            try
            {
                this.oraMetaBL.TableName = txtTableName.Text;
                string scrap = this.oraMetaBL.ParamKeyFields();
                txtOutput.Text = scrap;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }            
        }
    }
}
