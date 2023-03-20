using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massenger
{
    public class Uzivatel
    {

        private string jmeno;
        private string heslo;


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

        public Uzivatel(string jmeno, string heslo)
        {
            this.jmeno = jmeno;
            this.heslo = heslo;
        }

        public override string? ToString()
        {
            return "jmeno: "+Jmeno+", Heslo: "+Heslo;
        }
    }
}
