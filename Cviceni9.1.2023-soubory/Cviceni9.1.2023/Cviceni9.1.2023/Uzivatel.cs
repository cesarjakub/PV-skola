using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni9._1._2023
{
    public class Uzivatel
    {
        private string jmeno;
        private string pass;
        private string email;
        private int tel;

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Email 
        {
            get { return email; }
            set { email = value; }
        }

        public int Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public Uzivatel(string jmeno, string pass, string email, int tel)
        {
            Jmeno = jmeno;
            Pass = pass;
            Email = email;
            Tel = tel;
        }

        public override string? ToString()
        {
            return Jmeno+" email: "+Email+" tel: "+Tel+" Heslo: "+Pass;
        }
    }
}
