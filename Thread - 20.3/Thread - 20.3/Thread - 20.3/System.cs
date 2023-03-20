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

        public void newUzivatel(string jmeno, string heslo, Prava prava)
        {
            foreach(Uziatel uzivatel in uzivatele)
            {
                if (uzivatel.Jmeno == jmeno)
                {
                    Console.WriteLine("Erorr you can't use this name");
                    break;
                }
            }
            uzivatele.Add(new Uziatel(jmeno, heslo, prava));
            
        }



    }
}
