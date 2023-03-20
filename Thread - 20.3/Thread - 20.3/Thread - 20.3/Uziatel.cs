using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread___20._3
{
    public class Uziatel
    {

        private string jmeno;
        private string heslo;
        private Prava prava;

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public string Heslo
        {
            get { return heslo; }
            set { heslo = value; }
        }

        public Prava Prava
        {
            get { return prava; }
            set { prava = value; }
        }

        public Uziatel(string jmeno, string heslo, Prava prava)
        {
            Jmeno = jmeno;
            Heslo = heslo;
            Prava = prava;
        }

        public override string? ToString()
        {
            return Jmeno+" "+Heslo+" prava: "+Prava;
        }
    }
}
