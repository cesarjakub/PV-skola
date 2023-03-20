using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread___20._3
{
    public class Citac
    {

        private int hodnota;

        public int Hodnota
        {
            get { return hodnota; }
            set { hodnota = value; }
        }

        public Citac(int hodnota)
        {
            Hodnota = hodnota;
        }

        public int Zvys()
        {
            Hodnota += 1;
            return Hodnota;
        }

        public int Sniz()
        {
            Hodnota -= 1;
            return Hodnota;
        }

        public override string? ToString()
        {
            return "hodnota: "+Hodnota;
        }
    }
}
