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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFindLexeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            string pathFileSpec = ConfigurationManager.AppSettings["pathSpec"];
            txtInput.Text = File.ReadAllText(pathFileSpec);

        }

        List<string> FindLexemes(string pTexto)
        {
            List<string> res = null;
            string scrap = string.Empty; ;
            int vcb = 0;
            int inic = 0;
            int fin = 0;
            int tolerancia = 10000;
            int cont = 0;
            try
            {
                res = new List<string>();
               // while (vcb < pTexto.Length && cont <= tolerancia)
                 while (vcb < pTexto.Length )
                {
                    Console.WriteLine("vcb = " + vcb.ToString());
                    Console.WriteLine("cont = " + cont.ToString());
                    if (vcb == 15986)
                    {
                        Console.WriteLine("cont = " + cont.ToString());
                    }
                    ++cont;
                    vcb = pTexto.IndexOf("<%", inic);
                    if (vcb >= 0)
                    {
                        // busca el cierre
                        fin = pTexto.IndexOf(">", vcb);
                        if (fin >= 0)
                        {
                            scrap = pTexto.Substring(vcb, fin - vcb + 1);
                            if (!res.Contains(scrap))
                            {
                                res.Add(scrap);
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

            List<string> lst = null;

            try
            {
                lst = FindLexemes(txtInput.Text);

                foreach (var item in lst)
                {
                    txtOutput.Text += item + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            // Sustituirlos
        }
    }
}
