using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tretihodina
{
    internal class UrocenyUcet : Ucet
    {
        private double urok;

        public UrocenyUcet(double urok, int vklad, int vyber, int stav) : base(vklad, vyber, stav)
        {
            this.urok = urok;
        }

        public double Urok
        {
            get { return urok; }
            set { urok = value; }
        }

        public void Urocek()
        {
            double jedno = Stav / 100;
            double dve = jedno * urok;
            double tri = dve + Stav;
        }
    }
}
