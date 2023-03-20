using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolekce
{
    public class Uzivatel
    {
        private string jmeno;
        private string heslo;

        public Uzivatel(string jmeno, string heslo)
        {
            this.jmeno = jmeno;
            this.heslo = heslo;
        }

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public string Heslo
        {
            get { return heslo; }
            set
            {
                if (value.Length < 5)
                {
                    throw new Exception("delka musi byt delsi jak 5");
                }
                heslo = value;
            }
        }

        public override string? ToString()
        {
            return jmeno+":"+heslo;
        }
    }
}
