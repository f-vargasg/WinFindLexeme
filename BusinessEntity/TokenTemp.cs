using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BusinessEntity
{
#pragma warning disable CS0659 // 'TokenTemp' invalida Object.Equals(object o) pero no invalida Object.GetHashCode()
    public class TokenTemp
#pragma warning restore CS0659 // 'TokenTemp' invalida Object.Equals(object o) pero no invalida Object.GetHashCode()
    {
        public TokenTemp(string lexema)
        {
            string scrap;
            Lexema = lexema;
            scrap = lexema;
            scrap = scrap.Replace("<%", string.Empty);
            scrap = scrap.Replace(">", string.Empty);
            Ptoken = scrap;
        }

        public string Lexema { get; set; }
        public string Ptoken { get; set; }


        public override bool Equals(object obj)
        {
            bool res;

            TokenTemp scrap = (TokenTemp)obj;

            res =( this.Ptoken.CompareTo( scrap.Ptoken) == 0);
            return res;
            
        }

        /*
        public override int GetHashCode()
        {
            int hashCode = 1254347603;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Lexema);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Ptoken);
            return hashCode;
        }
        */

        public override string ToString()
        {
            return "Lexema: " + this.Lexema + " => Token: " + this.Ptoken;
        }
    }
}
