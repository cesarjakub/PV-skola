using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tretihodina
{
    internal class UrocenyUcetSPoplatkem : UrocenyUcet
    {

        private int poplatek;

        public UrocenyUcetSPoplatkem(int poplatek,double urok, int vklad, int vyber, int stav) : base(urok, vklad, vyber, stav)
        {
            poplatek = vklad;
        }

        public int Poplatek
        {
            get { return poplatek; }
            set
            {
                poplatek = value;
            }
        }

        public void PrictiUrok()
        {
            double jedno = Stav / 100;
            double dve = jedno * Urok;
            double tri = dve + Stav;
            double ctyri = tri - poplatek;
        }
    }
}
