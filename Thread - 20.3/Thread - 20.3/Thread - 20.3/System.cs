using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread___20._3
{
    public class System
    {
        private List<Uziatel> uzivatele;

        public List<Uziatel> Uzivatele
        {
            get { return uzivatele; }
            set { uzivatele = value; }
        }

        public System()
        {
            uzivatele = new List<Uziatel>();
        }

        public void newUzivatel()
        {

        }

    }
}
