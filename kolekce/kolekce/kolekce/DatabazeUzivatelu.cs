using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolekce
{
    public class DatabazeUzivatelu
    {
        private List<Uzivatel> uzivatels;

        public DatabazeUzivatelu()
        {
            uzivatels = new List<Uzivatel>();
        }

        public void Add(Uzivatel u)
        {
                uzivatels.Add(u);          
        }

        public int PocetUzivatelu()
        {
            return uzivatels.Count;
        }

        public void ZmenaJmena(string jmeno, string newjmeno)
        {
            foreach(Uzivatel u in uzivatels)
            {
                if(u.Jmeno == jmeno)
                {
                    u.Jmeno = newjmeno;
                }
            }
        }
    }
}
