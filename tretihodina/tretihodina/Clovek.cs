using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tretihodina
{
    internal class Clovek
    {
        private Random random = new Random();
        protected string jmeno;

        public Clovek(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public virtual bool trueOrFalse()
        {
            int number = random.Next(0,2);
            if (number == 1)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return jmeno + " mluvi: "+ trueOrFalse();
        }
    }
}
